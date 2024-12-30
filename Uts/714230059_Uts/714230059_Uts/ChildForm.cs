using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _714230059_Uts
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
            Size = new Size(735, 275);
        }
        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(npmTB.Text))
            {
                errorMessage.AppendLine("NPM Harus Angka!");
            }

            if (string.IsNullOrWhiteSpace(nameTB.Text))
            {
                errorMessage.AppendLine("Nama Belum Diisi!");
            }

            if (string.IsNullOrWhiteSpace(tahunATB.Text))
            {
                errorMessage.AppendLine("Format Tahun Akademik Salah!");
            }

            if (string.IsNullOrWhiteSpace(alamatTB.Text))
            {
                errorMessage.AppendLine("alamat Harus di isi!");
            }

            String errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                    "Lengkap!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Size = new Size(735,500);
            }

            else
            {
                MessageBox.Show(
                errorMsg.Trim(),
                        "ERROR",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jenis_kelamin = null;
            string kurikulum = null;
            string mata_kuliah = null;

            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    jenis_kelamin = radioButton.Text;
                    break;
                }
            }

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    kurikulum = radioButton.Text;
                    break;
                }
            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (!string.IsNullOrEmpty(mata_kuliah))
                    {
                        mata_kuliah += ", ";
                    }
                    mata_kuliah += checkBox.Text;
                }
            }

            if (string.IsNullOrEmpty(npmTB.Text) || string.IsNullOrEmpty(nameTB.Text) ||
                string.IsNullOrEmpty(jenis_kelamin) || string.IsNullOrEmpty(alamatTB.Text) ||
                string.IsNullOrEmpty(ProgramSCB.Text) || string.IsNullOrEmpty(tahunATB.Text) ||
                string.IsNullOrEmpty(kelasTB.Text) || string.IsNullOrEmpty(kurikulum))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                "NIM : " + npmTB.Text + "\n" +
                "Nama : " + nameTB.Text + "\n" +
                "Jenis Kelamin : " + jenis_kelamin + "\n" +
                "Alamat : " + alamatTB.Text + "\n" +
                "Program Studi : " + ProgramSCB.Text + "\n" +
                "Tahun Akademik : " + tahunATB.Text + "\n" +
                "Kelas : " + kelasTB.Text + "\n" +
                "====================================\n" +
                "Kurikulum : " + kurikulum + "\n" +
                "Mata Kuliah : " + mata_kuliah + "\n",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void npmTB_TextChanged(object sender, EventArgs e)
        {
            if (npmTB.Text == "")
            {
                SetErrorMessages(npmTB, "NPM Tidak Boleh Kosong!", "", "");
            }
            else if (npmTB.Text.All(Char.IsNumber))
            {
                SetErrorMessages(npmTB, "", "", "Benar!");
            }
            else
            {
                SetErrorMessages(npmTB, "", "Inputan NPM Hanya Boleh Angka!", "");
            }
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            if (nameTB.Text == "")
            {
                SetErrorMessages(nameTB, "Nama tidak boleh kosong!", "", "");
            }
            else if (nameTB.Text.All(Char.IsLetter))
            {
                SetErrorMessages(nameTB, "", "", "Benar!");
            }
            else
            {
                SetErrorMessages(nameTB, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void tahunATB_TextChanged(object sender, EventArgs e)
        {
            if (tahunATB.Text == "")
            {
                SetErrorMessages(tahunATB, "Tahun Akademik Tidak Boleh Kosong!", "", "");
            }
            else if (Regex.IsMatch(tahunATB.Text, @"^\d{4}/\d{4}$"))
            {
                SetErrorMessages(tahunATB, "", "", "Benar!");
            }
            else
            {
                SetErrorMessages(tahunATB, "", "Format Tahun Akademik salah!\nContoh: 2024/2025", "");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void semester1RB_CheckedChanged(object sender, EventArgs e)
        {
            if (semester1RB.Checked)
            {
                mtkCB.Enabled = true; mtkCB.Checked = false;
                aljabarCB.Enabled = false; aljabarCB.Checked = false;
                p1CB.Enabled = true; p1CB.Checked = false;
                p2CB.Enabled = false; p2CB.Checked = false;
                literasiTeknologiCB.Enabled = false; literasiTeknologiCB.Checked = false;
                basis1CB.Enabled = false; basis1CB.Checked = false;
                basis2CB.Enabled = false; basis2CB.Checked = false;
                literasiDataCB.Enabled = true; literasiDataCB.Checked = false;
                algo1CB.Enabled = true; algo1CB.Checked = false;
                algo2CB.Enabled = false; algo2CB.Checked = false;
                pknCB.Enabled = true; pknCB.Checked = false;
                logistikCB.Enabled = false; logistikCB.Checked = false;
            }
        }

        private void semester2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (semester2RB.Checked)
            {
                mtkCB.Enabled = false; mtkCB.Checked = false;
                aljabarCB.Enabled = true; aljabarCB.Checked = false;
                p1CB.Enabled = false; p1CB.Checked = false;
                p2CB.Enabled = false; p2CB.Checked = false;
                literasiTeknologiCB.Enabled = true; literasiTeknologiCB.Checked = false;
                basis1CB.Enabled = true; basis1CB.Checked = false;
                basis2CB.Enabled = false; basis2CB.Checked = false;
                literasiDataCB.Enabled = false; literasiDataCB.Checked = false;
                algo1CB.Enabled = false; algo1CB.Checked = false;
                algo2CB.Enabled = false; algo2CB.Checked = false;
                pknCB.Enabled = false; pknCB.Checked = false;
                logistikCB.Enabled = true; logistikCB.Checked = false;
            }
        }

        private void semester3RB_CheckedChanged(object sender, EventArgs e)
        {
            if (semester3RB.Checked)
            {
                mtkCB.Enabled = false; mtkCB.Checked = false;
                aljabarCB.Enabled = false; aljabarCB.Checked = false;
                p1CB.Enabled = false; p1CB.Checked = false;
                p2CB.Enabled = true; p2CB.Checked = false;
                literasiTeknologiCB.Enabled = false; literasiTeknologiCB.Checked = false;
                basis1CB.Enabled = false; basis1CB.Checked = false;
                basis2CB.Enabled = true; basis2CB.Checked = false;
                literasiDataCB.Enabled = false; literasiDataCB.Checked = false;
                algo1CB.Enabled = false; algo1CB.Checked = false;
                algo2CB.Enabled = true; algo2CB.Checked = false;
                pknCB.Enabled = false; pknCB.Checked = false;
                logistikCB.Enabled = false; logistikCB.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Apakah Yakin Ingin Meriset Data? \n",
                "data riset",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Size = new Size(735, 275);

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                    epWarning.SetError(textBox, "");
                    epWrong.SetError(textBox, "");
                    epCorrect.SetError(textBox, "");
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    epWarning.SetError(comboBox, "");
                    epWrong.SetError(comboBox, "");
                    epCorrect.SetError(comboBox, "");
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            foreach (Control groupControl in groupBox1.Controls)
            {
                if (groupControl is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            foreach (Control groupControl in groupBox2.Controls)
            {
                if (groupControl is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Enabled = true;
                }
            }
        }
    }
 }

