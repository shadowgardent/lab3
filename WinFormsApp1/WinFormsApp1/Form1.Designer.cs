namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxscore = new TextBox();
            textBoxname = new TextBox();
            textBoxid = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            textBoxnamemin = new TextBox();
            textBoxMin = new TextBox();
            textBox6 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            textBoxnameMAX = new TextBox();
            label5 = new Label();
            textBoxidMax = new TextBox();
            label6 = new Label();
            textBoxscoreMAX = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxscore);
            groupBox1.Controls.Add(textBoxname);
            groupBox1.Controls.Add(textBoxid);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(40, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกข้อมูล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 165);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 136);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 107);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 4;
            label1.Text = "id";
            // 
            // textBoxscore
            // 
            textBoxscore.Location = new Point(74, 157);
            textBoxscore.Name = "textBoxscore";
            textBoxscore.Size = new Size(100, 23);
            textBoxscore.TabIndex = 3;
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(74, 128);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(100, 23);
            textBoxname.TabIndex = 2;
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(74, 99);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(100, 23);
            textBoxid.TabIndex = 1;
            textBoxid.TextChanged += textBoxid_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(74, 195);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBoxnamemin);
            groupBox2.Controls.Add(textBoxMin);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxnameMAX);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxidMax);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxscoreMAX);
            groupBox2.Location = new Point(393, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 370);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "กรอกข้อมูล";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(298, 230);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 19;
            // 
            // textBoxnamemin
            // 
            textBoxnamemin.Location = new Point(192, 175);
            textBoxnamemin.Name = "textBoxnamemin";
            textBoxnamemin.Size = new Size(100, 23);
            textBoxnamemin.TabIndex = 17;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(86, 175);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(100, 23);
            textBoxMin.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(298, 175);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 136);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 15;
            label9.Text = "max";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 178);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "min";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 238);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 13;
            label7.Text = "average";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 115);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "score";
            // 
            // textBoxnameMAX
            // 
            textBoxnameMAX.Location = new Point(192, 133);
            textBoxnameMAX.Name = "textBoxnameMAX";
            textBoxnameMAX.Size = new Size(100, 23);
            textBoxnameMAX.TabIndex = 8;
            textBoxnameMAX.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 115);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 11;
            label5.Text = "name";
            // 
            // textBoxidMax
            // 
            textBoxidMax.Location = new Point(86, 133);
            textBoxidMax.Name = "textBoxidMax";
            textBoxidMax.Size = new Size(100, 23);
            textBoxidMax.TabIndex = 7;
            textBoxidMax.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 115);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 10;
            label6.Text = "id";
            // 
            // textBoxscoreMAX
            // 
            textBoxscoreMAX.Location = new Point(298, 133);
            textBoxscoreMAX.Name = "textBoxscoreMAX";
            textBoxscoreMAX.Size = new Size(100, 23);
            textBoxscoreMAX.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxscore;
        private TextBox textBoxname;
        private TextBox textBoxid;
        private Button button1;
        private Label label4;
        private TextBox textBoxnameMAX;
        private Label label5;
        private TextBox textBoxidMax;
        private Label label6;
        private TextBox textBoxscoreMAX;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBoxnamemin;
        private TextBox textBoxMin;
        private TextBox textBox6;
    }
}
