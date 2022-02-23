using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace clsSerial
{
    public class Serial
    {
        public SerialPort serialPort { get; private set; }

        public delegate void DelOnReceiveData(string sDataReceive, byte[] bDataReceive);
        public DelOnReceiveData OnReceiveData;

        public Serial()
        {
        }
        public Serial(SerialModel _serialModel)
        {
            this.serialPort = new SerialPort();

            //Set configs.
            serialPort.PortName = _serialModel.sPortName;
            serialPort.BaudRate = _serialModel.iBaudRate;
            serialPort.Encoding = _serialModel.encoding;
            serialPort.DataBits = _serialModel.iDataBits;
            serialPort.StopBits = _serialModel.stopBits;
            serialPort.Parity = _serialModel.parity;
            serialPort.DiscardNull = _serialModel.bDiscardNull;
            serialPort.ReceivedBytesThreshold = _serialModel.iReceivedBytesThreshold;
            serialPort.RtsEnable = _serialModel.bRtsEnable;
            serialPort.DtrEnable = _serialModel.bDtrEnable;
            serialPort.ReadTimeout = _serialModel.iReadTimeout;

            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int iSizeBuuf = serialPort.BytesToRead;
                byte [] bDataReceive = new byte[iSizeBuuf];
                serialPort.Read(bDataReceive, 0, iSizeBuuf);

                string sDataReceive = Encoding.ASCII.GetString(bDataReceive, 0, iSizeBuuf);

                if (OnReceiveData != null)
                    OnReceiveData(sDataReceive, bDataReceive);
            }
            catch (Exception ex)
            {
                ShowMessage("Erro (SerialPort_DataReceived): " + ex.Message);
            }
        }

        public string[] GetPortsCOM()
        {
            return SerialPort.GetPortNames();
        }

        public void AtualizaListaCOM(ref ComboBox cbxPorts)
        {
            try
            {
                int iContador = 0;
                bool bQuantidadeDiferente = false;

                string[] sPortsCOM = GetPortsCOM();
                if (cbxPorts.Items.Count == sPortsCOM.Length)
                {
                    foreach (string sPortName in sPortsCOM)
                    {
                        if (cbxPorts.Items[iContador++].Equals(sPortName) == false)
                            bQuantidadeDiferente = true;
                    }
                }
                else
                    bQuantidadeDiferente = true;

                //Se não foi detectado diferença.
                if (bQuantidadeDiferente == false)
                    return;

                //Limpa comboBox.
                cbxPorts.Items.Clear();

                //Adiciona todas as COM diponíveis na lista.
                foreach (string s in sPortsCOM)
                {
                    cbxPorts.Items.Add(s);
                }

                //Seleciona a última posição da lista.
                cbxPorts.SelectedIndex = cbxPorts.Items.Count - 1;
            }
            catch (Exception ex)
            {
                ShowMessage("Erro (atualizaListaCOM): " + ex.Message);
            }
        }

        /// <summary>
        /// Envia um comando via serial.
        /// </summary>
        /// <param name="sComando"></param>
        public bool SendCmd(string sComando)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Write(sComando);
                    return true;
                }
                ShowMessage("Porta Serial não está aberta.");
            }
            catch (Exception ex)
            {
                ShowMessage("Erro (sendCmd/sComando): " + ex.Message); ;
            }
            return false;
        }

        /// <summary>
        /// Envia um comando via serial.
        /// </summary>
        /// <param name="bComando"></param>
        public bool SendCmd(byte[] bComando)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Write(bComando, 0, bComando.Length);
                    return true;
                }
                else
                    ShowMessage("Porta Serial não está aberta.");
            }
            catch (Exception ex)
            {
                ShowMessage("Erro (SendCmd/bComando): " + ex.Message); ;
            }
            return false;
        }

        /// <summary>
        /// Abre a conexão com a porta serial.
        /// </summary>
        /// <returns></returns>
        public bool Open()
        {
            try
            {
                if (serialPort.IsOpen)
                    serialPort.Close();

                //Abre a serial.
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    try
                    {
                        serialPort.DiscardInBuffer();
                        serialPort.DiscardOutBuffer();
                    }
                    catch { }

                    return true;
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Erro (Open): " + ex.Message);
            }
            return false;
        }


        /// <summary>
        /// Fecha a conexão com a porta serial.
        /// </summary>
        public void Close()
        {
            try
            {
                serialPort.Close();
            }
            catch { }
        }

        public static void ShowMessage(string sMsg)
        {
            MessageBox.Show(sMsg, ":l", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
