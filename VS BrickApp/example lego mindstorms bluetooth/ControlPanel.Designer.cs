namespace Example_Lego_Mindstorms_Bluetooth
{
    partial class ControlPanel
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
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputlistBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.liftDown = new System.Windows.Forms.Button();
            this.liftUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.connectionGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.statusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.refreshButton);
            this.connectionGroupBox.Controls.Add(this.label1);
            this.connectionGroupBox.Controls.Add(this.portListBox);
            this.connectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(406, 131);
            this.connectionGroupBox.TabIndex = 4;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(275, 74);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(120, 23);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(275, 45);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(120, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(275, 16);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Referesh ports";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select the port that is connected to your EV3 device.";
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.FormattingEnabled = true;
            this.portListBox.Location = new System.Drawing.Point(9, 35);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(260, 82);
            this.portListBox.TabIndex = 5;
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.labelInstructions);
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Controls.Add(this.inputButton);
            this.inputGroupBox.Enabled = false;
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGroupBox.Location = new System.Drawing.Point(12, 151);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(200, 101);
            this.inputGroupBox.TabIndex = 5;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(9, 19);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(184, 18);
            this.labelInstructions.TabIndex = 4;
            this.labelInstructions.Text = "Custom command:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(9, 40);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(184, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton.Location = new System.Drawing.Point(9, 66);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(184, 23);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Send message";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputButton);
            this.outputGroupBox.Controls.Add(this.outputlistBox);
            this.outputGroupBox.Enabled = false;
            this.outputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputGroupBox.Location = new System.Drawing.Point(218, 151);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(200, 101);
            this.outputGroupBox.TabIndex = 6;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputButton
            // 
            this.outputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(2, 68);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(187, 23);
            this.outputButton.TabIndex = 0;
            this.outputButton.Text = "Read message";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputlistBox
            // 
            this.outputlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlistBox.FormattingEnabled = true;
            this.outputlistBox.Location = new System.Drawing.Point(7, 19);
            this.outputlistBox.Name = "outputlistBox";
            this.outputlistBox.Size = new System.Drawing.Size(187, 43);
            this.outputlistBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 21);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(125, 93);
            this.button1.TabIndex = 7;
            this.button1.Text = "˄";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 93);
            this.button2.TabIndex = 8;
            this.button2.Text = "■";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusBox
            // 
            this.statusBox.Controls.Add(this.liftDown);
            this.statusBox.Controls.Add(this.liftUp);
            this.statusBox.Controls.Add(this.label2);
            this.statusBox.Controls.Add(this.button5);
            this.statusBox.Controls.Add(this.button2);
            this.statusBox.Controls.Add(this.button1);
            this.statusBox.Controls.Add(this.button3);
            this.statusBox.Controls.Add(this.button4);
            this.statusBox.Enabled = false;
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.Location = new System.Drawing.Point(12, 258);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(406, 318);
            this.statusBox.TabIndex = 9;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "Status : Idle";
            // 
            // liftDown
            // 
            this.liftDown.Location = new System.Drawing.Point(287, 65);
            this.liftDown.Name = "liftDown";
            this.liftDown.Size = new System.Drawing.Size(75, 23);
            this.liftDown.TabIndex = 14;
            this.liftDown.Text = "˅ (Num 2)";
            this.liftDown.UseVisualStyleBackColor = true;
            this.liftDown.Click += new System.EventHandler(this.liftDown_Click);
            // 
            // liftUp
            // 
            this.liftUp.Location = new System.Drawing.Point(287, 36);
            this.liftUp.Name = "liftUp";
            this.liftUp.Size = new System.Drawing.Size(75, 23);
            this.liftUp.TabIndex = 13;
            this.liftUp.Text = "˄ (Num 8)";
            this.liftUp.UseVisualStyleBackColor = true;
            this.liftUp.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lift Control Beta";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(138, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 93);
            this.button5.TabIndex = 11;
            this.button5.Text = "˅";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(262, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 93);
            this.button3.TabIndex = 9;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(14, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 93);
            this.button4.TabIndex = 10;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 585);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Name = "ControlPanel";
            this.Text = "EV3 Movement PoC";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ListBox outputlistBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button liftDown;
        private System.Windows.Forms.Button liftUp;
        private System.Windows.Forms.Label label2;
    }
}

