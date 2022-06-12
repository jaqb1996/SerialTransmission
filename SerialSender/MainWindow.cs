using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialSender
{
    public partial class MainWindow : Form
    {
        private SerialPort serialPort = null;
        public MainWindow()
        {
            InitializeComponent();
            RefreshPortNames();
        }

        private void SendDataButton_Click(object sender, EventArgs e)
        {
            if (!SerialPortIsPrepared()) return;
            string data = DataToSendRichTextBox.Text;
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Nie ma nic do wysłania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            serialPort.WriteLine(data);
        }
        private bool SerialPortIsPrepared()
        {
            if (serialPort is null || !serialPort.IsOpen)
            {
                MessageBox.Show("Najpierw przygotuj transmisję", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private string GetPortName()
        {
            return ChoosePortComboBox.SelectedItem.ToString();
        }
        private void RefreshPortsButton_Click(object sender, EventArgs e)
        {
            RefreshPortNames();
        }
        private void RefreshPortNames()
        {
            var serialPorts = SerialPort.GetPortNames();
            ChoosePortComboBox.DataSource = serialPorts;
        }

        private void PrepareTransmissionButton_Click(object sender, EventArgs e)
        {
            CloseSerialPort();
            string portName = GetPortName();
            int baudRate = 0;
            try
            {
                baudRate = int.Parse(BaudRateInput.Text);
            }
            catch (FormatException ex)
            {
                BaudRateInput.Text = "";
                MessageBox.Show("Błędny format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
            serialPort.Open();
            TransmissionInfoTextBox.Text = $"Transmisja na porcie {portName} z prędkością {baudRate} bod/s";
        }
        private void CloseSerialPort()
        {
            if (serialPort is not null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSerialPort();
        }

        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            if (!SerialPortIsPrepared()) return;
            string data = serialPort.ReadLine();
            ReadDataRichTextBox.Text = data;
        }
    }
}
