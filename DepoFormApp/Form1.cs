using BusinessLayer;
using DataLayer.Database;
using Domain;
using System.Windows.Forms;

namespace DepoFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1; openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBox2.Text = filePath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Depo depo = new Depo();

            depo.Adi = textBox1.Text;

            if (int.TryParse(textBox3.Text, out int deger))
            {
                depo.Adedi = deger;
            }
            else
            {
                MessageBox.Show("Geçerli bir sayý giriniz!");
            }

            byte[] imageBytes = File.ReadAllBytes(textBox2.Text);

            depo.ImageData = imageBytes;

            DBMetot db = new DBMetot();

            var aa = db.DepoKaydet(depo);

            Form2 form3 = new Form2(aa);
            form3.Form2ye_Gidecek_Veri = aa;
            form3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}

