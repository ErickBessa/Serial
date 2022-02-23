using System;
using System.IO.Ports;
using System.Text;

public class SerialModel
{
    //Propriedades serial
    public string sPortName = "COM1";
    public Int32 iBaudRate = 9600;
    public Encoding encoding = Encoding.Default;
    public int iDataBits = 8;
    public StopBits stopBits = StopBits.One;
    public Parity parity = Parity.None;
    public bool bDiscardNull = true;
    public int iReceivedBytesThreshold = 1;
    public bool bRtsEnable = false;
    public bool bDtrEnable = false;
    public int iReadTimeout = 1000;                    
}
