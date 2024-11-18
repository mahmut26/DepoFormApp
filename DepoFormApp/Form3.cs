using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace DepoFormApp
{
    public partial class Form3 : Form
    {
        private FilterInfoCollection CapDev;
        private VideoCaptureDevice cap;
        public string gidecek;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CapDev = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo Device in CapDev)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cap = new VideoCaptureDevice(CapDev[comboBox1.SelectedIndex].MonikerString);
            cap.NewFrame += Capdev_new;
            cap.Start();
            timer1.Start();
        }

        private void Capdev_new(object sender, NewFrameEventArgs newFrame)
        {
            pictureBox1.Image = (Bitmap)newFrame.Frame.Clone();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cap.IsRunning == true)
            {
                cap.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //BarcodeReader barcodeReader = new BarcodeReader();
                Bitmap bitmap = pictureBox1.Image as Bitmap;
                if (bitmap == null)
                {
                    MessageBox.Show("Görüntü uygun formatta değil veya null.");
                    return;
                }
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode(bitmap);

                if (result != null)
                {
                    textBox1.Text = result.Text;

                    timer1.Stop(); if (cap != null && cap.IsRunning) { cap.SignalToStop(); cap.WaitForStop(); }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gidecek = textBox1.Text;
            Form4 form4 = new Form4(gidecek);
            form4.Show();
        }
    }

}
