namespace avtobus_tapsirigi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 110);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(305, 41);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 2;
            label1.Text = "BMU Travel";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bus;
            pictureBox2.Location = new Point(622, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bmu_logo;
            pictureBox1.Location = new Point(51, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 263);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel information";
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Showcard Gothic", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(293, 32);
            button1.Name = "button1";
            button1.Size = new Size(53, 69);
            button1.TabIndex = 8;
            button1.Text = "<\r\n>\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 26);
            textBox1.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(120, 135);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 26);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bakı", "Kürdəmir", "Füzuli", "Xaçmaz", "Yevlax" });
            comboBox2.Location = new Point(120, 87);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 26);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bakı", "Kürdəmir", "Füzuli", "Xaçmaz", "Yevlax" });
            comboBox1.Location = new Point(120, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 26);
            comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 190);
            label5.Name = "label5";
            label5.Size = new Size(41, 18);
            label5.TabIndex = 3;
            label5.Text = "Yer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 135);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 2;
            label4.Text = "Tarix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 87);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 1;
            label3.Text = "Haraya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 32);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 0;
            label2.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(415, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 263);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal information";
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.ForeColor = Color.White;
            button2.Location = new Point(118, 228);
            button2.Name = "button2";
            button2.Size = new Size(193, 29);
            button2.TabIndex = 11;
            button2.Text = "Bilet al";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 26);
            textBox2.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 26);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 26);
            textBox3.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(146, 132);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 26);
            maskedTextBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 190);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 3;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 135);
            label7.Name = "label7";
            label7.Size = new Size(77, 18);
            label7.TabIndex = 2;
            label7.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 87);
            label8.Name = "label8";
            label8.Size = new Size(36, 18);
            label8.TabIndex = 1;
            label8.Text = "FIN:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 32);
            label9.Name = "label9";
            label9.Size = new Size(106, 18);
            label9.TabIndex = 0;
            label9.Text = "Ad ve soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(37, 418);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(737, 104);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.ForeColor = Color.White;
            button3.Location = new Point(36, 545);
            button3.Name = "button3";
            button3.Size = new Size(203, 29);
            button3.TabIndex = 4;
            button3.Text = "Siyahidan sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.ForeColor = Color.White;
            button4.Location = new Point(569, 545);
            button4.Name = "button4";
            button4.Size = new Size(205, 29);
            button4.TabIndex = 5;
            button4.Text = "Proqramdan çıxış";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 586);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
    }
}
