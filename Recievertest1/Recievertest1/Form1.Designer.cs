namespace Recievertest1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbDataInlen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbDataIn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbComstat = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClosed = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxdata = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxcom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxbaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxstop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxparry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.tbDataIn);
            this.groupBox4.Location = new System.Drawing.Point(229, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 424);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reciever";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbDataInlen);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(130, 329);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(226, 45);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // lbDataInlen
            // 
            this.lbDataInlen.AutoSize = true;
            this.lbDataInlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInlen.Location = new System.Drawing.Point(89, 18);
            this.lbDataInlen.Name = "lbDataInlen";
            this.lbDataInlen.Size = new System.Drawing.Size(27, 20);
            this.lbDataInlen.TabIndex = 1;
            this.lbDataInlen.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Data In:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 112);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbDataIn
            // 
            this.tbDataIn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbDataIn.Enabled = false;
            this.tbDataIn.Location = new System.Drawing.Point(6, 19);
            this.tbDataIn.Multiline = true;
            this.tbDataIn.Name = "tbDataIn";
            this.tbDataIn.Size = new System.Drawing.Size(350, 217);
            this.tbDataIn.TabIndex = 0;
            this.tbDataIn.TextChanged += new System.EventHandler(this.tbDataIn_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btnClosed);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Location = new System.Drawing.Point(6, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 194);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbComstat);
            this.groupBox5.Location = new System.Drawing.Point(89, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(98, 123);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // lbComstat
            // 
            this.lbComstat.AutoSize = true;
            this.lbComstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComstat.Location = new System.Drawing.Point(26, 48);
            this.lbComstat.Name = "lbComstat";
            this.lbComstat.Size = new System.Drawing.Size(52, 25);
            this.lbComstat.TabIndex = 0;
            this.lbComstat.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 152);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClosed
            // 
            this.btnClosed.Location = new System.Drawing.Point(9, 86);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(75, 59);
            this.btnClosed.TabIndex = 1;
            this.btnClosed.Text = "Close";
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 59);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxdata);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cBoxcom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cBoxbaud);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cBoxstop);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cBoxparry);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 225);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // cBoxdata
            // 
            this.cBoxdata.FormattingEnabled = true;
            this.cBoxdata.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxdata.Location = new System.Drawing.Point(92, 76);
            this.cBoxdata.Name = "cBoxdata";
            this.cBoxdata.Size = new System.Drawing.Size(121, 24);
            this.cBoxdata.TabIndex = 1;
            this.cBoxdata.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parry Bits";
            // 
            // cBoxcom
            // 
            this.cBoxcom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxcom.FormattingEnabled = true;
            this.cBoxcom.Location = new System.Drawing.Point(92, 16);
            this.cBoxcom.Name = "cBoxcom";
            this.cBoxcom.Size = new System.Drawing.Size(121, 24);
            this.cBoxcom.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits";
            // 
            // cBoxbaud
            // 
            this.cBoxbaud.FormattingEnabled = true;
            this.cBoxbaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxbaud.Location = new System.Drawing.Point(92, 46);
            this.cBoxbaud.Name = "cBoxbaud";
            this.cBoxbaud.Size = new System.Drawing.Size(121, 24);
            this.cBoxbaud.TabIndex = 2;
            this.cBoxbaud.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bits";
            // 
            // cBoxstop
            // 
            this.cBoxstop.FormattingEnabled = true;
            this.cBoxstop.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxstop.Location = new System.Drawing.Point(92, 106);
            this.cBoxstop.Name = "cBoxstop";
            this.cBoxstop.Size = new System.Drawing.Size(121, 24);
            this.cBoxstop.TabIndex = 3;
            this.cBoxstop.Text = "One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // cBoxparry
            // 
            this.cBoxparry.FormattingEnabled = true;
            this.cBoxparry.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxparry.Location = new System.Drawing.Point(92, 136);
            this.cBoxparry.Name = "cBoxparry";
            this.cBoxparry.Size = new System.Drawing.Size(121, 24);
            this.cBoxparry.TabIndex = 4;
            this.cBoxparry.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Com Port";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Reciever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxparry;
        private System.Windows.Forms.ComboBox cBoxstop;
        private System.Windows.Forms.ComboBox cBoxbaud;
        private System.Windows.Forms.ComboBox cBoxdata;
        private System.Windows.Forms.ComboBox cBoxcom;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbDataIn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbComstat;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbDataInlen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
    }
}

