using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(330, 230);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("NAMA HARUS DI ISI");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("ANGKATAN HARUS DI ISI");
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("KELAS HARUS DI ISI");
            }

            String errorMsg = errorMessage.ToString();

            if(string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                   "Lengkap!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Size = new Size(330, 456);
            }

            else
            {
                MessageBox.Show(
                errorMsg.Trim(),
                    "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonWekday_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonWekday.Checked)
            {
                checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = false;
                checkBoxLibur.Enabled = true; checkBoxLibur.Checked = false;
                checkBoxLiburan.Enabled = false; checkBoxLiburan.Checked = false;
            }

        }

        private void radioButtonWekend_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonWekend.Checked)
            {
                checkBoxKuliah.Enabled = false; checkBoxKuliah.Checked = false;
                checkBoxLibur.Enabled = true; checkBoxLibur.Checked = false;
                checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            //string hari = null;
            //string kegiatan = null;

            //foreach(Control control in Controls)
            //{
            //    if(control is RadioButton radioButton && radioButton.Checked)
            //    {
            //        hari = radioButton.Text;
            //        break;
            //    }
            //}

            //foreach (Control control in Controls)
            //{
            //    if (control is CheckBox checkBox && checkBox.Checked)
            //    {
            //        if(!string.IsNullOrEmpty(kegiatan))
            //        {
            //            kegiatan += ", ";
            //        }
            //        kegiatan += checkBox.Text;
            //    }
            //}

            //menggunakan LINQ (LANGUAGE INTEGRATED QUERY)
            string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;

            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));

            MessageBox.Show(
                "Nama : " + textBoxNama.Text + "\n" +
                "Angkatan : " + comboBoxAngkatan.Text + "\n" +
                "Kelas : " + textBoxKelas.Text + "\n" +
                "====================================\n"+
                "hari : " + hari + "\n"+
                "kegiatan : " + kegiatan + "\n",
                "Informasi Data Submit",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //textBoxNama.Text = "";
            //comboBoxAngkatan.SelectedIndex = -1;
            //textBoxKelas.Text = "";
            //radioButtonWekday.Checked = false;
            //radioButtonWekend.Checked = false;
            //checkBoxKuliah.Checked = false;
            //checkBoxLibur.Checked = false;
            //checkBoxLiburan.Checked = false;

            MessageBox.Show(
                "Apakah Yakin Ingin Meriset Data? \n",
                "data riset",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Size = new Size(330, 230);

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = "";
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
            }
        }
    }
}
