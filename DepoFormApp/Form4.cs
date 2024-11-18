using BusinessLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoFormApp
{
    public partial class Form4 : Form
    {
        public Guid kullanilacak;

        public string veri;

        public Depo depo;
        public Form4(string guid)
        {
            InitializeComponent();
            veri = guid.ToString();
            
            Guid kullanilacak = Guid.Parse(veri);

            DBMetot dBMetot = new DBMetot();

            var aa = dBMetot.KayitGetir(kullanilacak);

            depo = aa;

            textBox1.Text = aa.Adi;
            textBox3.Text = aa.Adedi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(textBox2.Text);

            depo.Adedi= adet;

            DBMetot dBMetot= new DBMetot();

            dBMetot.DepoDuzenle(depo);

            Form4 form4 = new Form4(depo.Id.ToString());

            form4.ShowDialog();
        }

    }
}
