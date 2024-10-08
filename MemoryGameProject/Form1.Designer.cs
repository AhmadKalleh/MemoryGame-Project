namespace MemoryGameProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(437, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Game ";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.OrangeRed;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1129, 727);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(196, 76);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Khaki;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(856, 727);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(196, 76);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTimer);
            this.groupBox1.Controls.Add(this.cbSpeed);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(883, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 469);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Details";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(205, 236);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(91, 32);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Your Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timer";
            // 
            // cbTimer
            // 
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTimer.Location = new System.Drawing.Point(42, 133);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(127, 40);
            this.cbTimer.TabIndex = 1;
            this.cbTimer.Text = "1";
            // 
            // cbSpeed
            // 
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "1x",
            "1.5x",
            "2x"});
            this.cbSpeed.Location = new System.Drawing.Point(246, 133);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(127, 40);
            this.cbSpeed.TabIndex = 0;
            this.cbSpeed.Text = "1x";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::MemoryGameProject.Properties.Resources.EmptyStar;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(322, 391);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MemoryGameProject.Properties.Resources.EmptyStar;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(248, 391);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MemoryGameProject.Properties.Resources.EmptyStar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(176, 391);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MemoryGameProject.Properties.Resources.EmptyStar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(103, 391);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MemoryGameProject.Properties.Resources.EmptyStar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn10
            // 
            this.btn10.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10.Location = new System.Drawing.Point(303, 195);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(136, 139);
            this.btn10.TabIndex = 11;
            this.btn10.Tag = "?";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.button_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.Location = new System.Drawing.Point(490, 195);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(136, 139);
            this.btn9.TabIndex = 10;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.Location = new System.Drawing.Point(29, 354);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(136, 139);
            this.btn8.TabIndex = 9;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.Location = new System.Drawing.Point(213, 354);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(136, 139);
            this.btn7.TabIndex = 8;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.Location = new System.Drawing.Point(397, 354);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(136, 139);
            this.btn6.TabIndex = 7;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.Location = new System.Drawing.Point(124, 517);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(136, 139);
            this.btn5.TabIndex = 6;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.Location = new System.Drawing.Point(303, 517);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(136, 139);
            this.btn4.TabIndex = 5;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.Location = new System.Drawing.Point(581, 354);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(136, 139);
            this.btn3.TabIndex = 4;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Location = new System.Drawing.Point(490, 517);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(136, 139);
            this.btn2.TabIndex = 3;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::MemoryGameProject.Properties.Resources.Queation;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Location = new System.Drawing.Point(124, 195);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(136, 139);
            this.btn1.TabIndex = 2;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClose.BackgroundImage = global::MemoryGameProject.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1285, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1350, 877);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTimer;
        private System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

