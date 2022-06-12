
namespace SerialSender
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChoosePortComboBox = new System.Windows.Forms.ComboBox();
            this.ChoosePortLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.BaudRateInput = new System.Windows.Forms.TextBox();
            this.DataToSendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DataToSendLabel = new System.Windows.Forms.Label();
            this.SendDataButton = new System.Windows.Forms.Button();
            this.ReadDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ReadDataLabel = new System.Windows.Forms.Label();
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.RefreshPortsButton = new System.Windows.Forms.Button();
            this.PrepareTransmissionButton = new System.Windows.Forms.Button();
            this.TransmissionInfoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChoosePortComboBox
            // 
            this.ChoosePortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosePortComboBox.FormattingEnabled = true;
            this.ChoosePortComboBox.Location = new System.Drawing.Point(30, 54);
            this.ChoosePortComboBox.Name = "ChoosePortComboBox";
            this.ChoosePortComboBox.Size = new System.Drawing.Size(121, 23);
            this.ChoosePortComboBox.TabIndex = 0;
            // 
            // ChoosePortLabel
            // 
            this.ChoosePortLabel.AutoSize = true;
            this.ChoosePortLabel.Location = new System.Drawing.Point(77, 36);
            this.ChoosePortLabel.Name = "ChoosePortLabel";
            this.ChoosePortLabel.Size = new System.Drawing.Size(29, 15);
            this.ChoosePortLabel.TabIndex = 1;
            this.ChoosePortLabel.Text = "Port";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(227, 37);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(151, 15);
            this.BaudRateLabel.TabIndex = 2;
            this.BaudRateLabel.Text = "Prędkość transmisji (bod/s)";
            // 
            // BaudRateInput
            // 
            this.BaudRateInput.Location = new System.Drawing.Point(256, 54);
            this.BaudRateInput.Name = "BaudRateInput";
            this.BaudRateInput.Size = new System.Drawing.Size(100, 23);
            this.BaudRateInput.TabIndex = 3;
            this.BaudRateInput.Text = "115200";
            // 
            // DataToSendRichTextBox
            // 
            this.DataToSendRichTextBox.Location = new System.Drawing.Point(40, 238);
            this.DataToSendRichTextBox.Name = "DataToSendRichTextBox";
            this.DataToSendRichTextBox.Size = new System.Drawing.Size(284, 96);
            this.DataToSendRichTextBox.TabIndex = 4;
            this.DataToSendRichTextBox.Text = "";
            // 
            // DataToSendLabel
            // 
            this.DataToSendLabel.AutoSize = true;
            this.DataToSendLabel.Location = new System.Drawing.Point(122, 217);
            this.DataToSendLabel.Name = "DataToSendLabel";
            this.DataToSendLabel.Size = new System.Drawing.Size(99, 15);
            this.DataToSendLabel.TabIndex = 5;
            this.DataToSendLabel.Text = "Dane do wysłania";
            // 
            // SendDataButton
            // 
            this.SendDataButton.Location = new System.Drawing.Point(146, 340);
            this.SendDataButton.Name = "SendDataButton";
            this.SendDataButton.Size = new System.Drawing.Size(75, 23);
            this.SendDataButton.TabIndex = 6;
            this.SendDataButton.Text = "Wyślij";
            this.SendDataButton.UseVisualStyleBackColor = true;
            this.SendDataButton.Click += new System.EventHandler(this.SendDataButton_Click);
            // 
            // ReadDataRichTextBox
            // 
            this.ReadDataRichTextBox.Location = new System.Drawing.Point(40, 406);
            this.ReadDataRichTextBox.Name = "ReadDataRichTextBox";
            this.ReadDataRichTextBox.ReadOnly = true;
            this.ReadDataRichTextBox.Size = new System.Drawing.Size(284, 106);
            this.ReadDataRichTextBox.TabIndex = 7;
            this.ReadDataRichTextBox.Text = "";
            // 
            // ReadDataLabel
            // 
            this.ReadDataLabel.AutoSize = true;
            this.ReadDataLabel.Location = new System.Drawing.Point(133, 388);
            this.ReadDataLabel.Name = "ReadDataLabel";
            this.ReadDataLabel.Size = new System.Drawing.Size(88, 15);
            this.ReadDataLabel.TabIndex = 8;
            this.ReadDataLabel.Text = "Odebrane dane";
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Location = new System.Drawing.Point(133, 518);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(109, 23);
            this.ReadDataButton.TabIndex = 9;
            this.ReadDataButton.Text = "Odbierz dane";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // RefreshPortsButton
            // 
            this.RefreshPortsButton.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshPortsButton.Location = new System.Drawing.Point(157, 54);
            this.RefreshPortsButton.Name = "RefreshPortsButton";
            this.RefreshPortsButton.Size = new System.Drawing.Size(44, 23);
            this.RefreshPortsButton.TabIndex = 10;
            this.RefreshPortsButton.Text = "Odśwież";
            this.RefreshPortsButton.UseVisualStyleBackColor = true;
            this.RefreshPortsButton.Click += new System.EventHandler(this.RefreshPortsButton_Click);
            // 
            // PrepareTransmissionButton
            // 
            this.PrepareTransmissionButton.Location = new System.Drawing.Point(133, 97);
            this.PrepareTransmissionButton.Name = "PrepareTransmissionButton";
            this.PrepareTransmissionButton.Size = new System.Drawing.Size(126, 23);
            this.PrepareTransmissionButton.TabIndex = 11;
            this.PrepareTransmissionButton.Text = "Przygotuj transmisję";
            this.PrepareTransmissionButton.UseVisualStyleBackColor = true;
            this.PrepareTransmissionButton.Click += new System.EventHandler(this.PrepareTransmissionButton_Click);
            // 
            // TransmissionInfoTextBox
            // 
            this.TransmissionInfoTextBox.Location = new System.Drawing.Point(40, 142);
            this.TransmissionInfoTextBox.Name = "TransmissionInfoTextBox";
            this.TransmissionInfoTextBox.ReadOnly = true;
            this.TransmissionInfoTextBox.Size = new System.Drawing.Size(316, 23);
            this.TransmissionInfoTextBox.TabIndex = 12;
            this.TransmissionInfoTextBox.Text = "Transmisja nieprzygotowana";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 566);
            this.Controls.Add(this.TransmissionInfoTextBox);
            this.Controls.Add(this.PrepareTransmissionButton);
            this.Controls.Add(this.RefreshPortsButton);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.ReadDataLabel);
            this.Controls.Add(this.ReadDataRichTextBox);
            this.Controls.Add(this.SendDataButton);
            this.Controls.Add(this.DataToSendLabel);
            this.Controls.Add(this.DataToSendRichTextBox);
            this.Controls.Add(this.BaudRateInput);
            this.Controls.Add(this.BaudRateLabel);
            this.Controls.Add(this.ChoosePortLabel);
            this.Controls.Add(this.ChoosePortComboBox);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChoosePortComboBox;
        private System.Windows.Forms.Label ChoosePortLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.TextBox BaudRateInput;
        private System.Windows.Forms.RichTextBox DataToSendRichTextBox;
        private System.Windows.Forms.Label DataToSendLabel;
        private System.Windows.Forms.Button SendDataButton;
        private System.Windows.Forms.RichTextBox ReadDataRichTextBox;
        private System.Windows.Forms.Label ReadDataLabel;
        private System.Windows.Forms.Button ReadDataButton;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.Button PrepareTransmissionButton;
        private System.Windows.Forms.TextBox TransmissionInfoTextBox;
    }
}