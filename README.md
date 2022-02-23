# LibSerial in C#
This lib was created to facilitate the consumption of serial port data from WinForms.

Using Lib Serial:
```C#
  using clsSerial;
```

Init Serial Port:
```C#
private void InitSerialPort()
{
  SerialModel serialModel = new SerialModel();
  serialModel.sPortName = "COMx";
  serialModel.iBaudRate = 9600;

  Serial serial = new Serial(serialModel);
  serial.OnReceiveData += OnReceiveData;
  serial.Open();
}
```

How to consume the data received by the serial:
```C#
private void OnReceiveData(string sDataReceive, byte[] bDataReceive)
{
  textBox.Text+= sDataReceive;
}
```

Update a ComboBox with available COMs ports:
```C#
Serial serial = new Serial();
serial.atualizaListaCOM(ref ComboBox);
```

