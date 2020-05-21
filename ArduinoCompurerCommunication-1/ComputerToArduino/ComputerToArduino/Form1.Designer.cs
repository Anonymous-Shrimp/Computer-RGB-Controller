namespace ComputerToArduino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.delayTimer = new System.Windows.Forms.NumericUpDown();
            this.hex2 = new System.Windows.Forms.Label();
            this.hex1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.blueLabel2 = new System.Windows.Forms.Label();
            this.greenLabel2 = new System.Windows.Forms.Label();
            this.redLabel2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.blueIn2 = new System.Windows.Forms.TrackBar();
            this.greenIn2 = new System.Windows.Forms.TrackBar();
            this.redIn2 = new System.Windows.Forms.TrackBar();
            this.colorBox2 = new System.Windows.Forms.PictureBox();
            this.blueLabel1 = new System.Windows.Forms.Label();
            this.greenLabel1 = new System.Windows.Forms.Label();
            this.redLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blueIn1 = new System.Windows.Forms.TrackBar();
            this.greenIn1 = new System.Windows.Forms.TrackBar();
            this.redIn1 = new System.Windows.Forms.TrackBar();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.colorBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueIn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.delayTimer);
            this.groupbox1.Controls.Add(this.hex2);
            this.groupbox1.Controls.Add(this.hex1);
            this.groupbox1.Controls.Add(this.button2);
            this.groupbox1.Controls.Add(this.blueLabel2);
            this.groupbox1.Controls.Add(this.greenLabel2);
            this.groupbox1.Controls.Add(this.redLabel2);
            this.groupbox1.Controls.Add(this.label7);
            this.groupbox1.Controls.Add(this.label8);
            this.groupbox1.Controls.Add(this.label9);
            this.groupbox1.Controls.Add(this.blueIn2);
            this.groupbox1.Controls.Add(this.greenIn2);
            this.groupbox1.Controls.Add(this.redIn2);
            this.groupbox1.Controls.Add(this.colorBox2);
            this.groupbox1.Controls.Add(this.blueLabel1);
            this.groupbox1.Controls.Add(this.greenLabel1);
            this.groupbox1.Controls.Add(this.redLabel1);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.blueIn1);
            this.groupbox1.Controls.Add(this.greenIn1);
            this.groupbox1.Controls.Add(this.redIn1);
            this.groupbox1.Controls.Add(this.linkLabel);
            this.groupbox1.Controls.Add(this.colorBox1);
            this.groupbox1.Font = new System.Drawing.Font("Ubuntu Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.Location = new System.Drawing.Point(12, 30);
            this.groupbox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupbox1.Size = new System.Drawing.Size(382, 234);
            this.groupbox1.TabIndex = 8;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "LED Control";
            this.groupbox1.Enter += new System.EventHandler(this.groupbox1_Enter);
            // 
            // delayTimer
            // 
            this.delayTimer.Location = new System.Drawing.Point(292, 121);
            this.delayTimer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.delayTimer.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.delayTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayTimer.Name = "delayTimer";
            this.delayTimer.Size = new System.Drawing.Size(83, 20);
            this.delayTimer.TabIndex = 37;
            this.delayTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // hex2
            // 
            this.hex2.AutoSize = true;
            this.hex2.BackColor = System.Drawing.Color.Transparent;
            this.hex2.Location = new System.Drawing.Point(316, 84);
            this.hex2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hex2.Name = "hex2";
            this.hex2.Size = new System.Drawing.Size(44, 16);
            this.hex2.TabIndex = 36;
            this.hex2.Text = "#FFFFFF";
            this.hex2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hex2.Click += new System.EventHandler(this.hex2_Click);
            // 
            // hex1
            // 
            this.hex1.AutoSize = true;
            this.hex1.BackColor = System.Drawing.Color.Transparent;
            this.hex1.Location = new System.Drawing.Point(316, 32);
            this.hex1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hex1.Name = "hex1";
            this.hex1.Size = new System.Drawing.Size(44, 16);
            this.hex1.TabIndex = 35;
            this.hex1.Text = "#FFFFFF";
            this.hex1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hex1.Click += new System.EventHandler(this.hex1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 28);
            this.button2.TabIndex = 33;
            this.button2.Text = "Play Fade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // blueLabel2
            // 
            this.blueLabel2.AutoSize = true;
            this.blueLabel2.Location = new System.Drawing.Point(240, 37);
            this.blueLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel2.Name = "blueLabel2";
            this.blueLabel2.Size = new System.Drawing.Size(13, 16);
            this.blueLabel2.TabIndex = 32;
            this.blueLabel2.Text = "0";
            // 
            // greenLabel2
            // 
            this.greenLabel2.AutoSize = true;
            this.greenLabel2.Location = new System.Drawing.Point(189, 37);
            this.greenLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greenLabel2.Name = "greenLabel2";
            this.greenLabel2.Size = new System.Drawing.Size(13, 16);
            this.greenLabel2.TabIndex = 31;
            this.greenLabel2.Text = "0";
            // 
            // redLabel2
            // 
            this.redLabel2.AutoSize = true;
            this.redLabel2.Location = new System.Drawing.Point(147, 34);
            this.redLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel2.Name = "redLabel2";
            this.redLabel2.Size = new System.Drawing.Size(13, 16);
            this.redLabel2.TabIndex = 30;
            this.redLabel2.Text = "0";
            this.redLabel2.Click += new System.EventHandler(this.redLabel2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Blue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Green";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Red";
            // 
            // blueIn2
            // 
            this.blueIn2.Location = new System.Drawing.Point(234, 57);
            this.blueIn2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.blueIn2.Maximum = 255;
            this.blueIn2.Name = "blueIn2";
            this.blueIn2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueIn2.Size = new System.Drawing.Size(45, 171);
            this.blueIn2.TabIndex = 26;
            this.blueIn2.TickFrequency = 15;
            this.blueIn2.Scroll += new System.EventHandler(this.blueIn2_Scroll);
            // 
            // greenIn2
            // 
            this.greenIn2.Location = new System.Drawing.Point(192, 57);
            this.greenIn2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.greenIn2.Maximum = 255;
            this.greenIn2.Name = "greenIn2";
            this.greenIn2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenIn2.Size = new System.Drawing.Size(45, 171);
            this.greenIn2.TabIndex = 25;
            this.greenIn2.TickFrequency = 15;
            this.greenIn2.Scroll += new System.EventHandler(this.greenIn2_Scroll);
            // 
            // redIn2
            // 
            this.redIn2.Location = new System.Drawing.Point(149, 54);
            this.redIn2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.redIn2.Maximum = 255;
            this.redIn2.Name = "redIn2";
            this.redIn2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redIn2.Size = new System.Drawing.Size(45, 174);
            this.redIn2.TabIndex = 24;
            this.redIn2.TickFrequency = 15;
            this.redIn2.Scroll += new System.EventHandler(this.redIn2_Scroll);
            // 
            // colorBox2
            // 
            this.colorBox2.BackColor = System.Drawing.Color.White;
            this.colorBox2.Location = new System.Drawing.Point(292, 65);
            this.colorBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(83, 48);
            this.colorBox2.TabIndex = 23;
            this.colorBox2.TabStop = false;
            // 
            // blueLabel1
            // 
            this.blueLabel1.AutoSize = true;
            this.blueLabel1.Location = new System.Drawing.Point(98, 37);
            this.blueLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel1.Name = "blueLabel1";
            this.blueLabel1.Size = new System.Drawing.Size(13, 16);
            this.blueLabel1.TabIndex = 22;
            this.blueLabel1.Text = "0";
            // 
            // greenLabel1
            // 
            this.greenLabel1.AutoSize = true;
            this.greenLabel1.Location = new System.Drawing.Point(47, 37);
            this.greenLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greenLabel1.Name = "greenLabel1";
            this.greenLabel1.Size = new System.Drawing.Size(13, 16);
            this.greenLabel1.TabIndex = 21;
            this.greenLabel1.Text = "0";
            // 
            // redLabel1
            // 
            this.redLabel1.AutoSize = true;
            this.redLabel1.Location = new System.Drawing.Point(5, 34);
            this.redLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel1.Name = "redLabel1";
            this.redLabel1.Size = new System.Drawing.Size(13, 16);
            this.redLabel1.TabIndex = 20;
            this.redLabel1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Blue";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Green";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Red";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // blueIn1
            // 
            this.blueIn1.Location = new System.Drawing.Point(92, 57);
            this.blueIn1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.blueIn1.Maximum = 255;
            this.blueIn1.Name = "blueIn1";
            this.blueIn1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueIn1.Size = new System.Drawing.Size(45, 171);
            this.blueIn1.TabIndex = 16;
            this.blueIn1.TickFrequency = 15;
            this.blueIn1.Scroll += new System.EventHandler(this.blueIn_Scroll);
            // 
            // greenIn1
            // 
            this.greenIn1.Location = new System.Drawing.Point(50, 57);
            this.greenIn1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.greenIn1.Maximum = 255;
            this.greenIn1.Name = "greenIn1";
            this.greenIn1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenIn1.Size = new System.Drawing.Size(45, 171);
            this.greenIn1.TabIndex = 15;
            this.greenIn1.TickFrequency = 15;
            this.greenIn1.Scroll += new System.EventHandler(this.greenIn_Scroll);
            // 
            // redIn1
            // 
            this.redIn1.Location = new System.Drawing.Point(7, 54);
            this.redIn1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.redIn1.Maximum = 255;
            this.redIn1.Name = "redIn1";
            this.redIn1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redIn1.Size = new System.Drawing.Size(45, 174);
            this.redIn1.TabIndex = 14;
            this.redIn1.TickFrequency = 15;
            this.redIn1.Scroll += new System.EventHandler(this.redIn_Scroll);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(292, 202);
            this.linkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(88, 16);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Go to a color picker";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // colorBox1
            // 
            this.colorBox1.BackColor = System.Drawing.Color.White;
            this.colorBox1.Location = new System.Drawing.Point(292, 15);
            this.colorBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(83, 48);
            this.colorBox1.TabIndex = 8;
            this.colorBox1.TabStop = false;
            this.colorBox1.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Ubuntu Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 268);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(387, 89);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Connection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Reset for new Fade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Font = new System.Drawing.Font("Ubuntu Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(419, 409);
            this.MinimumSize = new System.Drawing.Size(419, 409);
            this.Name = "Form1";
            this.Text = "Ardiuno Aesthetics";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueIn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.PictureBox colorBox1;
        private System.Windows.Forms.TrackBar blueIn1;
        private System.Windows.Forms.TrackBar greenIn1;
        private System.Windows.Forms.TrackBar redIn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label blueLabel1;
        private System.Windows.Forms.Label greenLabel1;
        private System.Windows.Forms.Label redLabel1;
        private System.Windows.Forms.Label blueLabel2;
        private System.Windows.Forms.Label greenLabel2;
        private System.Windows.Forms.Label redLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar blueIn2;
        private System.Windows.Forms.TrackBar greenIn2;
        private System.Windows.Forms.TrackBar redIn2;
        private System.Windows.Forms.PictureBox colorBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label hex2;
        private System.Windows.Forms.Label hex1;
        private System.Windows.Forms.NumericUpDown delayTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

