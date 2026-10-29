using System;
using System.Windows.Forms;

namespace OyutniiBurtgel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string country = "";

            if (lstCountry.SelectedItem != null)
                country = lstCountry.SelectedItem.ToString();

            string major = "";

            if (cmbMajor.SelectedItem != null)
                major = cmbMajor.SelectedItem.ToString();

            string study = "";

            if (rbTulburtei.Checked)
                study = "Төлбөртэй";
            else if (rbUdur.Checked)
                study = "Өдрийн";
            else if (rbOroi.Checked)
                study = "Оройн";

            rtbInfo.Text =
                "ОЮУТНЫ БҮРТГЭЛ\r\n" +
                "----------------------\r\n" +
                "Код: " + txtCode.Text + "\r\n" +
                "Утас: " + txtPhone.Text + "\r\n" +
                "Нас: " + numAge.Value + "\r\n" +
                "Төрсөн өдөр: " +
                dtpBirth.Value.ToString("yyyy-MM-dd") + "\r\n" +
                "Сургалт: " + study + "\r\n" +
                "Тэнхим: " + major + "\r\n" +
                "Улс: " + country;

            dgvStudent.Rows.Clear();

            dgvStudent.Rows.Add(
                txtCode.Text,
                txtPhone.Text,
                numAge.Value,
                country
            );

            MessageBox.Show(
                "Оюутан амжилттай бүртгэгдлээ!",
                "Мэдээлэл",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtPhone.Clear();

            numAge.Value = 20;
            dtpBirth.Value = new DateTime(2005, 11, 6);

            lstCountry.SelectedIndex = 0;
            cmbMajor.SelectedIndex = 0;

            for (int i = 0; i < clbSubject.Items.Count; i++)
                clbSubject.SetItemChecked(i, false);

            clbSubject.SetItemChecked(3, true);

            rbUdur.Checked = true;

            dgvStudent.Rows.Clear();

            rtbInfo.Clear();
        }

        private void pictureStudent_Click(object sender, EventArgs e)
        {

        }

        private void pictureStudent_Click_1(object sender, EventArgs e)
        {

        }
    }
}