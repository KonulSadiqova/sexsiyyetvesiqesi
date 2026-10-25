using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sexsiyyetvesiqesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Düymələrin işləməsi üçün əlaqələndirmə
            buttonSekilYukle.Click += buttonSekilYukle_Click;
            buttonTemizle.Click += buttonTemizle_Click;
            buttonYaddaSaxla.Click += buttonYaddaSaxla_Click;

            // Sağ tərəfdə yazılan məlumatların sol tərəfdə görünməsi üçün TextChanged bağlamaları:
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox6.TextChanged += textBox6_TextChanged;
            textBox7.TextChanged += textBox7_TextChanged;
            textBox8.TextChanged += textBox8_TextChanged;
            textBox9.TextChanged += textBox9_TextChanged;
            textBox10.TextChanged += textBox10_TextChanged;
            textBox11.TextChanged += textBox11_TextChanged;
            textBox12.TextChanged += textBox12_TextChanged;
        }

        // 1. Seriya və nömrə (TextBox1 -> Label5)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }

        // 2. FİN kod (TextBox2 -> Label6)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox2.Text;
        }

        // 3. Soyad (TextBox3 -> Label7)
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label7.Text = textBox3.Text;
        }

        // 4. Ad (TextBox4 -> Label8)
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox4.Text;
        }

        // 5. Ata adı (TextBox5 -> Label9)
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox5.Text;
        }

        // 6. Cins (TextBox6 -> Label10)
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox6.Text;
        }

        // 7. Doğum tarixi (TextBox7 -> Label11)
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label11.Text = textBox7.Text;
        }

        // 8. Doğum yeri (TextBox8 -> Label12)
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label12.Text = textBox8.Text;
        }

        // 9. Ailə vəziyyəti (TextBox9 -> Label13)
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            label13.Text = textBox9.Text;
        }

        // 10. Verilmə tarixi (TextBox10 -> Label14)
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            label14.Text = textBox10.Text;
        }

        // 11. Etibarlıdır (TextBox11 -> Label15)
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label15.Text = textBox11.Text;
        }

        // 12. Verən orqan (TextBox12 -> Label16)
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            label16.Text = textBox12.Text;
        }

        // Şəkil yükləmə düyməsi (buttonSekilYukle)
        private void buttonSekilYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Şəkil faylları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                Control[] foundControls = this.Controls.Find("labelFoto", true);
                if (foundControls.Length > 0)
                {
                    foundControls[0].Visible = false;
                }
            }
        }

        // Təmizləmə düyməsi (buttonTemizle)
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);

            pictureBox2.Image = null;

            Control[] foundControls = this.Controls.Find("labelFoto", true);
            if (foundControls.Length > 0)
            {
                foundControls[0].Visible = true;
            }

            MessageBox.Show("Məlumatlar təmizləndi.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Köməkçi metod - bütün textbox-ları təmizləmək üçün
        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        // Yadda saxla düyməsi (buttonYaddaSaxla)
        private void buttonYaddaSaxla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Zəhmət olmasa əsas xanaları doldurun!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Məlumatlar uğurla yadda saxlanıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ---- DİZAYNERDƏ TƏLƏB OLUNAN ƏLAVƏ METODLAR ----
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }
    }
}