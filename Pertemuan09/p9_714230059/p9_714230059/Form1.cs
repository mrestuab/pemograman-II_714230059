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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void dataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
