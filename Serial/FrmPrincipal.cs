using System;
using System.Windows.Forms;
using clsSerial;

namespace DEMO_SERIAL
{
    public partial class FrmPrincipal : Form
    {
        Serial serial;
        SerialModel serialModel;
        private delegate void ExibeLog(ref TextBox txtLog, string sMsg);

        public FrmPrincipal()
        {
            InitializeComponent();

            serial = new Serial();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            serial.AtualizaListaCOM(ref cbxPorts);
        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOpenSerial.Text == "OpenSerial")
                {
                    string sNamePortCom = cbxPorts.Items[cbxPorts.SelectedIndex].ToString();

                    serialModel = new SerialModel();
                    serialModel.sPortName = sNamePortCom;
                    serialModel.iBaudRate = 115200;

                    serial = new Serial(serialModel);
                    serial.OnReceiveData += OnReceiveData;

                    if (!serial.Open())
                    {
                        addLog(ref txtLog, "Falha ao tentar abrir porta serial.\r\n");
                        return;
                    }

                    btnSendCmd.Enabled = true;
                    btnOpenSerial.Text = "CloseSerial";
                }
                else
                {
                    serial.Close();
                    btnSendCmd.Enabled = false;
                    btnOpenSerial.Text = "OpenSerial";
                }
            }
            catch (Exception ex)
            {
                showMessage("Erro (OpenSerial): " + ex.Message);
            }
        }

        private void OnReceiveData(string sDataReceive, byte[] bDataReceive)
        {
            addLog(ref txtLog, sDataReceive);
        }

        private void cbxPorts_DropDown(object sender, EventArgs e)
        {
            serial.AtualizaListaCOM(ref cbxPorts);
        }

        private void txtLog_DoubleClick(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComando.Text))
            {
                showMessage("Digite o comando!");
                return;
            }

            string sComando = txtComando.Text.Trim();
            bool bEnviado = serial.SendCmd(sComando);
            if (bEnviado)
            {
                addLog(ref txtLog, "Comando enviado: " + sComando + "\r\n");
            }
            else
            {
                addLog(ref txtLog, "Falha ao enviar comando: " + sComando + "\r\n");
            }
        }

        public static void showMessage(string sMsg)
        {
            MessageBox.Show(sMsg, ":l", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void addLog(ref TextBox txtLog, string sMsg)
        {
            if (txtLog.InvokeRequired)
                txtLog.BeginInvoke(new ExibeLog(_AddLog), new object[] { txtLog, sMsg });
            else
                _AddLog(ref txtLog, sMsg);
        }

        private static void _AddLog(ref TextBox txtLog, string sMsg)
        {
            try
            {
                string sDH = DateTime.Now.ToLongTimeString();

                //Adiciona log no text box e pula sempre para ultima linha.
                txtLog.Text += sDH + "- " + sMsg;
                if (txtLog.Text.Length > 0)
                {
                    txtLog.Select(txtLog.Text.Length - 1, 0);
                    txtLog.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                showMessage("Erro (_AddLog): " + ex.Message);
            }
        }
    }
}
