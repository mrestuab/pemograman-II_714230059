namespace P5_4_714230059
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PilihanKelas = new System.Windows.Forms.GroupBox();
            this.PilihanJadwal = new System.Windows.Forms.GroupBox();
            this.sepakbola = new System.Windows.Forms.CheckBox();
            this.renang = new System.Windows.Forms.CheckBox();
            this.tenis = new System.Windows.Forms.CheckBox();
            this.yoga = new System.Windows.Forms.CheckBox();
            this.basket = new System.Windows.Forms.CheckBox();
            this.bulutangkis = new System.Windows.Forms.CheckBox();
            this.voli = new System.Windows.Forms.CheckBox();
            this.panahan = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PilihanKelas.SuspendLayout();
            this.PilihanJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " FORM PENDAFTARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "jenis kelamin";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "tanggal lahir";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // PilihanKelas
            // 
            this.PilihanKelas.Controls.Add(this.panahan);
            this.PilihanKelas.Controls.Add(this.voli);
            this.PilihanKelas.Controls.Add(this.bulutangkis);
            this.PilihanKelas.Controls.Add(this.basket);
            this.PilihanKelas.Controls.Add(this.yoga);
            this.PilihanKelas.Controls.Add(this.tenis);
            this.PilihanKelas.Controls.Add(this.renang);
            this.PilihanKelas.Controls.Add(this.sepakbola);
            this.PilihanKelas.Location = new System.Drawing.Point(61, 263);
            this.PilihanKelas.Name = "PilihanKelas";
            this.PilihanKelas.Size = new System.Drawing.Size(274, 146);
            this.PilihanKelas.TabIndex = 7;
            this.PilihanKelas.TabStop = false;
            this.PilihanKelas.Text = "pilihan kelas";
            // 
            // PilihanJadwal
            // 
            this.PilihanJadwal.Controls.Add(this.radioButton4);
            this.PilihanJadwal.Controls.Add(this.radioButton3);
            this.PilihanJadwal.Controls.Add(this.radioButton2);
            this.PilihanJadwal.Controls.Add(this.radioButton1);
            this.PilihanJadwal.Location = new System.Drawing.Point(436, 263);
            this.PilihanJadwal.Name = "PilihanJadwal";
            this.PilihanJadwal.Size = new System.Drawing.Size(302, 146);
            this.PilihanJadwal.TabIndex = 8;
            this.PilihanJadwal.TabStop = false;
            this.PilihanJadwal.Text = "pilihan jadwal";
            // 
            // sepakbola
            // 
            this.sepakbola.AutoSize = true;
            this.sepakbola.Location = new System.Drawing.Point(7, 25);
            this.sepakbola.Name = "sepakbola";
            this.sepakbola.Size = new System.Drawing.Size(112, 24);
            this.sepakbola.TabIndex = 9;
            this.sepakbola.Text = "sepak bola";
            this.sepakbola.UseVisualStyleBackColor = true;
            // 
            // renang
            // 
            this.renang.AutoSize = true;
            this.renang.Location = new System.Drawing.Point(7, 55);
            this.renang.Name = "renang";
            this.renang.Size = new System.Drawing.Size(85, 24);
            this.renang.TabIndex = 10;
            this.renang.Text = "renang";
            this.renang.UseVisualStyleBackColor = true;
            // 
            // tenis
            // 
            this.tenis.AutoSize = true;
            this.tenis.Location = new System.Drawing.Point(6, 85);
            this.tenis.Name = "tenis";
            this.tenis.Size = new System.Drawing.Size(69, 24);
            this.tenis.TabIndex = 11;
            this.tenis.Text = "tenis";
            this.tenis.UseVisualStyleBackColor = true;
            // 
            // yoga
            // 
            this.yoga.AutoSize = true;
            this.yoga.Location = new System.Drawing.Point(6, 115);
            this.yoga.Name = "yoga";
            this.yoga.Size = new System.Drawing.Size(69, 24);
            this.yoga.TabIndex = 12;
            this.yoga.Text = "yoga";
            this.yoga.UseVisualStyleBackColor = true;
            // 
            // basket
            // 
            this.basket.AutoSize = true;
            this.basket.Location = new System.Drawing.Point(125, 25);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(83, 24);
            this.basket.TabIndex = 13;
            this.basket.Text = "basket";
            this.basket.UseVisualStyleBackColor = true;
            // 
            // bulutangkis
            // 
            this.bulutangkis.AutoSize = true;
            this.bulutangkis.Location = new System.Drawing.Point(125, 55);
            this.bulutangkis.Name = "bulutangkis";
            this.bulutangkis.Size = new System.Drawing.Size(120, 24);
            this.bulutangkis.TabIndex = 14;
            this.bulutangkis.Text = "bulu tangkis";
            this.bulutangkis.UseVisualStyleBackColor = true;
            // 
            // voli
            // 
            this.voli.AutoSize = true;
            this.voli.Location = new System.Drawing.Point(125, 85);
            this.voli.Name = "voli";
            this.voli.Size = new System.Drawing.Size(57, 24);
            this.voli.TabIndex = 15;
            this.voli.Text = "voli";
            this.voli.UseVisualStyleBackColor = true;
            // 
            // panahan
            // 
            this.panahan.AutoSize = true;
            this.panahan.Location = new System.Drawing.Point(125, 115);
            this.panahan.Name = "panahan";
            this.panahan.Size = new System.Drawing.Size(98, 24);
            this.panahan.TabIndex = 16;
            this.panahan.Text = "panahan";
            this.panahan.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(234, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "senin s/d rabu, 14:00 - 16:00";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(251, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "selasa s/d kamis, 14:00 - 16:00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(256, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "sabtu s/d minggu, 09:00 - 11:00";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 114);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(187, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "minggu, 13:00 - 20:00";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "tampilan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PilihanJadwal);
            this.Controls.Add(this.PilihanKelas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ULBI SPORT";
            this.PilihanKelas.ResumeLayout(false);
            this.PilihanKelas.PerformLayout();
            this.PilihanJadwal.ResumeLayout(false);
            this.PilihanJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox PilihanKelas;
        private System.Windows.Forms.CheckBox basket;
        private System.Windows.Forms.CheckBox yoga;
        private System.Windows.Forms.CheckBox tenis;
        private System.Windows.Forms.CheckBox renang;
        private System.Windows.Forms.CheckBox sepakbola;
        private System.Windows.Forms.GroupBox PilihanJadwal;
        private System.Windows.Forms.CheckBox panahan;
        private System.Windows.Forms.CheckBox voli;
        private System.Windows.Forms.CheckBox bulutangkis;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

