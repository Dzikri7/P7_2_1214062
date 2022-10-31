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
using System.Xml.Linq;

namespace P7_2_1214062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(976, 303);
        }

        private void gbMKP_Enter(object sender, EventArgs e)
        {

        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                if (tbNIM.Text != "")
                {
                    if (rbLK.Checked || rbPR.Checked)
                    {
                        if (tbAlamat.Text != "")
                        {
                            if (cbPS.Text != "")
                            {
                                if (tbTA.Text != "")
                                {
                                    if (Regex.IsMatch(tbTA.Text, @"^\d{4}/\d{4}$"))
                                    {
                                        if (tbSem.Text != "")
                                        {
                                            if ((tbSem.Text).All(Char.IsNumber))
                                            {
                                                MessageBox.Show
                                                ("Lengkap!",
                                                "Informasi Data Submit",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Size = new System.Drawing.Size(976, 582);
                                            }
                                            else
                                            {
                                                MessageBox.Show
                                                ("Inputan Semester Hanya Boleh Angka!",
                                                "Informasi Data Submit",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                                MessageBox.Show
                                                ("Semester Belum Diisi!",
                                                "Informasi Data Submit",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show
                                        ("Format Tahun Akademik Salah!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show
                                        ("Tahun Akademik Belum Diisi!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show
                                    ("Program Studi Belum Dipilih!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                                ("Alamat Belum Di Isi!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                            ("Pilih Jenis Kelamin!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                        ("NIM Belum Di Isi!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                    ("Nama Belum Di Isi!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTA_TextChanged(object sender, EventArgs e)
        {
            if (tbTA.Text == "")
            {
                epWrong.SetError(tbTA, "");
            }
            else
            {
                if (Regex.IsMatch(tbTA.Text, @"^\d{4}/\d{4}$"))
                {
                    epWrong.SetError(tbTA, "");
                }
                else
                {
                    epWrong.SetError(tbTA, "Format Tahun Akademik Salah!");
                }
            }
        }

        private void tbSem_TextChanged(object sender, EventArgs e)
        {
            if (tbSem.Text == "")
            {
                epWrong.SetError(tbSem, "");
            }
            else
            {
                if ((tbSem.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(tbSem, "");
                }
                else
                {
                    epWrong.SetError(tbSem, "Inputan Semester Hanya Boleh Angka!");
                }
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            cb1.Enabled = true; cb1.Checked = false;
            cb2.Enabled = true; cb2.Checked = false;
            cb3.Enabled = true; cb3.Checked = false;
            cb4.Enabled = true; cb4.Checked = false;
            cb5.Enabled = true; cb5.Checked = false;
            cb6.Enabled = true; cb6.Checked = false;
            cb7.Enabled = true; cb7.Checked = false;
            cb8.Enabled = true; cb8.Checked = false;
            cb9.Enabled = false; cb9.Checked = false;
            cb10.Enabled = true; cb10.Checked = false;
            cb11.Enabled = true; cb11.Checked = false;
            cb12.Enabled = false; cb12.Checked = false;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            cb1.Enabled = false; cb1.Checked = false;
            cb2.Enabled = true; cb2.Checked = false;
            cb3.Enabled = true; cb3.Checked = false;
            cb4.Enabled = true; cb4.Checked = false;
            cb5.Enabled = true; cb5.Checked = false;
            cb6.Enabled = true; cb6.Checked = false;
            cb7.Enabled = true; cb7.Checked = false;
            cb8.Enabled = true; cb8.Checked = false;
            cb9.Enabled = false; cb9.Checked = false;
            cb10.Enabled = true; cb10.Checked = false;
            cb11.Enabled = true; cb11.Checked = false;
            cb12.Enabled = true; cb12.Checked = false;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            cb1.Enabled = false; cb1.Checked = false;
            cb2.Enabled = true; cb2.Checked = false;
            cb3.Enabled = true; cb3.Checked = false;
            cb4.Enabled = true; cb4.Checked = false;
            cb5.Enabled = true; cb5.Checked = false;
            cb6.Enabled = true; cb6.Checked = false;
            cb7.Enabled = true; cb7.Checked = false;
            cb8.Enabled = true; cb8.Checked = false;
            cb9.Enabled = true; cb9.Checked = false;
            cb10.Enabled = true; cb10.Checked = false;
            cb11.Enabled = true; cb11.Checked = false;
            cb12.Enabled = false; cb12.Checked = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string jk = null;

            if (rbLK.Checked)
            {
                jk = rbLK.Text;
            }
            else
            {
                jk = rbPR.Text;
            }

            string kulkum = null;

            if (rb1.Checked)
            {
                kulkum = rb1.Text;
            }
            else if (rb2.Checked)
            {
                kulkum = rb2.Text;
            }
            else
            {
                kulkum = rb3.Text;
            }

            string matkul = null;

            if (cb1.Checked)
            {
                matkul += cb1.Text + ", ";
            }
            if (cb2.Checked)
            {
                matkul += cb2.Text + ", ";
            }
            if (cb3.Checked)
            {
                matkul += cb3.Text + ", ";
            }
            if (cb4.Checked)
            {
                matkul += cb4.Text + ", ";
            }
            if (cb5.Checked)
            {
                matkul += cb5.Text + ", ";
            }
            if (cb6.Checked)
            {
                matkul += cb6.Text + ", ";
            }
            if (cb7.Checked)
            {
                matkul += cb7.Text + ", ";
            }
            if (cb8.Checked)
            {
                matkul += cb8.Text + ", ";
            }
            if (cb9.Checked)
            {
                matkul += cb9.Text + ", ";
            }
            if (cb10.Checked)
            {
                matkul += cb10.Text + ", ";
            }
            if (cb11.Checked)
            {
                matkul += cb11.Text + ", ";
            }
            if (cb12.Checked)
            {
                matkul += cb12.Text + ", ";
            }

            MessageBox.Show
            ("Nama : " + tbNama.Text +
            "\nNIM : " + tbNIM.Text +
            "\nJenis Kelamin : " + jk +
            "\nAlamat : " + tbAlamat.Text +
            "\nProgram Studi : " + cbPS.Text +
            "\nTahun Akademik : " + tbTA.Text +
            "\nSemester : " + tbSem.Text +
            "\nKurikulum : " + kulkum +
            "\nMata Kuliah : " + matkul,
            "Data Telah Di Input",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbNama.Clear();
            tbNIM.Clear();
            rbLK.Checked = false;
            rbPR.Checked = false;
            tbAlamat.Clear();
            cbPS.ResetText();
            tbTA.Clear();
            tbSem.Clear();
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb6.Checked = false;
            cb7.Checked = false;
            cb8.Checked = false;
            cb9.Checked = false;
            cb10.Checked = false;
            cb11.Checked = false;
            cb12.Checked = false;
            this.Size = new System.Drawing.Size(976, 303);
        }
    }
}
