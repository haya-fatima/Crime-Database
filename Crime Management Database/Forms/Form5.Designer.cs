namespace Forms_CrimeDatabase
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register a Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Case ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Case Open Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(442, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "General Category:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theft",
            "Murder",
            "Arson",
            "Aggravated Assault"});
            this.comboBox1.Location = new System.Drawing.Point(597, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 458);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Supervisor:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(250, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 164);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(68, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Relevant FIRs:";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(721, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(577, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(479, 458);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(394, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Station:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(718, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Witnesses:";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(669, 222);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(145, 164);
            this.listBox6.TabIndex = 54;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(522, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Suspects:";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(48, 222);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(141, 164);
            this.listBox4.TabIndex = 52;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(305, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Victims:";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(479, 222);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(148, 164);
            this.listBox5.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(442, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Case Close Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(577, 134);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker2.TabIndex = 61;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(871, 608);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}