namespace IndianRailways
{
    partial class Traininfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Informations = new System.Windows.Forms.GroupBox();
            this.trnnameerror = new System.Windows.Forms.Label();
            this.trnnoerror = new System.Windows.Forms.Label();
            this.trnNobox = new System.Windows.Forms.TextBox();
            this.trnNamebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Informations.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Informations);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 535);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(34, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 108);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(187, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "R&efresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(358, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "D&elete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(306, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(239, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "V&iew";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(123, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "S&ave";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Informations
            // 
            this.Informations.Controls.Add(this.trnnameerror);
            this.Informations.Controls.Add(this.trnnoerror);
            this.Informations.Controls.Add(this.trnNobox);
            this.Informations.Controls.Add(this.trnNamebox);
            this.Informations.Controls.Add(this.label3);
            this.Informations.Controls.Add(this.label2);
            this.Informations.Location = new System.Drawing.Point(16, 156);
            this.Informations.Name = "Informations";
            this.Informations.Size = new System.Drawing.Size(579, 147);
            this.Informations.TabIndex = 0;
            this.Informations.TabStop = false;
            this.Informations.Text = "Imformations";
            // 
            // trnnameerror
            // 
            this.trnnameerror.AutoSize = true;
            this.trnnameerror.ForeColor = System.Drawing.Color.Red;
            this.trnnameerror.Location = new System.Drawing.Point(451, 95);
            this.trnnameerror.Name = "trnnameerror";
            this.trnnameerror.Size = new System.Drawing.Size(120, 13);
            this.trnnameerror.TabIndex = 9;
            this.trnnameerror.Text = "!! Train name is required";
            // 
            // trnnoerror
            // 
            this.trnnoerror.AutoSize = true;
            this.trnnoerror.ForeColor = System.Drawing.Color.Red;
            this.trnnoerror.Location = new System.Drawing.Point(451, 36);
            this.trnnoerror.Name = "trnnoerror";
            this.trnnoerror.Size = new System.Drawing.Size(106, 13);
            this.trnnoerror.TabIndex = 8;
            this.trnnoerror.Text = "!! Train no is required";
            this.trnnoerror.Click += new System.EventHandler(this.trnnoerror_Click);
            // 
            // trnNobox
            // 
            this.trnNobox.Location = new System.Drawing.Point(212, 33);
            this.trnNobox.Name = "trnNobox";
            this.trnNobox.Size = new System.Drawing.Size(167, 20);
            this.trnNobox.TabIndex = 7;
            this.trnNobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trnNobox_KeyPress);
            // 
            // trnNamebox
            // 
            this.trnNamebox.Location = new System.Drawing.Point(212, 95);
            this.trnNamebox.Name = "trnNamebox";
            this.trnNamebox.Size = new System.Drawing.Size(167, 20);
            this.trnNamebox.TabIndex = 6;
            this.trnNamebox.TextChanged += new System.EventHandler(this.trnNamebox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Train Name     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Train No         :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 117);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "www.irctc.co.in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\projects\\IndianRial\\railwaylogo1.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trains Infomation";
            // 
            // Traininfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 537);
            this.Controls.Add(this.panel1);
            this.Name = "Traininfo";
            this.Text = "Traininfo";
            this.Load += new System.EventHandler(this.Traininfo_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Informations.ResumeLayout(false);
            this.Informations.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Informations;
        private System.Windows.Forms.TextBox trnNobox;
        private System.Windows.Forms.TextBox trnNamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label trnnoerror;
        private System.Windows.Forms.Label trnnameerror;
        private System.Windows.Forms.Label label4;
    }
}