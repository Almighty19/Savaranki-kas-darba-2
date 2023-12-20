namespace Sisteminis_sd2
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
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            textBox5 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 330);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(546, 195);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 531);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 1;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(116, 531);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // button3
            // 
            button3.Location = new Point(483, 531);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(416, 41);
            textBox4.MaxLength = 1;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 7;
            label1.Text = "Vardas Pavardė";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 23);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Pažymiai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 23);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 9;
            label3.Text = "Egzamino balas";
            // 
            // button4
            // 
            button4.Location = new Point(13, 70);
            button4.Name = "button4";
            button4.Size = new Size(89, 33);
            button4.TabIndex = 10;
            button4.Text = "Įvesti";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(124, 70);
            button5.Name = "button5";
            button5.Size = new Size(82, 33);
            button5.TabIndex = 11;
            button5.Text = "Atnaujinti";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 67);
            label4.Name = "label4";
            label4.Size = new Size(188, 15);
            label4.TabIndex = 12;
            label4.Text = "Pažymiai įvedami atskiriant tarpais";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(347, 85);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Vidurkis";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(434, 85);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 19);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mediana";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 312);
            label5.Name = "label5";
            label5.Size = new Size(247, 15);
            label5.TabIndex = 15;
            label5.Text = "Laukelis kopijavimui saugojimui ir pastaboms";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 109);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(546, 145);
            textBox5.TabIndex = 16;
            textBox5.MouseClick += textBox5_MouseClick;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button6
            // 
            button6.Location = new Point(13, 260);
            button6.Name = "button6";
            button6.Size = new Size(122, 35);
            button6.TabIndex = 17;
            button6.Text = "Copy all";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(160, 260);
            button7.Name = "button7";
            button7.Size = new Size(123, 35);
            button7.TabIndex = 18;
            button7.Text = "Copy selected";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(212, 531);
            button8.Name = "button8";
            button8.Size = new Size(90, 23);
            button8.TabIndex = 19;
            button8.Text = "Save as";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 566);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private SaveFileDialog saveFileDialog1;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private TextBox textBox5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}