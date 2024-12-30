using p9_714230059.controller;
using p9_714230059.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p9_714230059
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            //query db get MGS
            dataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            //mengubah nama kolom tabel
            dataMahasiswa.Columns[0].HeaderText = "NPM";
            dataMahasiswa.Columns[0].HeaderText = "Nama";
            dataMahasiswa.Columns[0].HeaderText = "Angkatan";
            dataMahasiswa.Columns[0].HeaderText = "Alamat";
            dataMahasiswa.Columns[0].HeaderText = "Email";
            dataMahasiswa.Columns[0].HeaderText = "No HP";
        }

        public void ResetForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textBox1.Text;
                m_mhs.Nama = textBox2.Text;
                m_mhs.Angkatan = comboBox1.Text;
                m_mhs.Alamat = textBox4.Text;
                m_mhs.Email = textBox5.Text;
                m_mhs.Nohp = textBox6.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                M_mahasiswa m_mhs = new M_mahasiswa();

                // Isi properti model M_mahasiswa dengan data dari form
                m_mhs.Npm = textBox1.Text;
                m_mhs.Nama = textBox2.Text;
                m_mhs.Angkatan = comboBox1.Text;
                m_mhs.Alamat = textBox4.Text;
                m_mhs.Email = textBox5.Text;
                m_mhs.Nohp = textBox6.Text;

                // Panggil metode Update dengan parameter yang benar
                bool result = mhs.Update(m_mhs, textBox1.Text);

                if (result)
                {
                    MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm(); // Bersihkan form
                Tampil();    // Refresh tampilan data
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void dataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textBox1.Text);
                ResetForm();
                Tampil();
            }
        }
    }
}
