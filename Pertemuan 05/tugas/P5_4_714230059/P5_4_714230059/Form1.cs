using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714230059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string jenisKelamin = comboBox1.SelectedItem?.ToString() ?? "";
            DateTime tanggalLahir = dateTimePicker1.Value;

            List<string> pilihanKelas = new List<string>();
            if (sepakbola.Checked) pilihanKelas.Add("sepak bola");
            if (renang.Checked) pilihanKelas.Add("renang");
            if (tenis.Checked) pilihanKelas.Add("tenis");
            if (yoga.Checked) pilihanKelas.Add("yoga");
            if (basket.Checked) pilihanKelas.Add("basket");
            if (bulutangkis.Checked) pilihanKelas.Add("bulu tangkis");
            if (voli.Checked) pilihanKelas.Add("voli");
            if (panahan.Checked) pilihanKelas.Add("panahan");

            string pilihanJadwal = "";
            if (radioButton1.Checked) pilihanJadwal = "senin s/d rabu, 14:00 - 16:00";
            else if (radioButton2.Checked) pilihanJadwal = "selasa s/d kamis, 14:00 - 16:00";
            else if (radioButton3.Checked) pilihanJadwal = "sabtu s/d minggu, 09:00 - 11:00";
            else if (radioButton4.Checked) pilihanJadwal = "minggu, 13:00 - 20:00";

            if (pilihanKelas.Count == 0)
            {
                MessageBox.Show("Harus memilih salah satu dari kelas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pilihanJadwal))
            {
                MessageBox.Show("Harus memilih salah satu jadwal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hasil = $"Nama: {nama}\nJenis Kelamin: {jenisKelamin}\nTanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                           $"Pilihan Kelas: {string.Join(", ", pilihanKelas)}\nPilihan Jadwal: {pilihanJadwal}";

            MessageBox.Show(hasil, "Hasil Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Laki-laki");
            comboBox1.Items.Add("Perempuan");
            comboBox1.Text = "--Pilih Jenis Kelamin--";
        }
    }
}
