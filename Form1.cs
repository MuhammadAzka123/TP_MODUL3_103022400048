using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022400048
{
    public partial class Form1 : Form
    {
        double angka1 = 0;
        double angka2 = 0;
        double hasil = 0;
        bool tambah = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Lbl_output.Text = Lbl_output.Text + "0";
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (Lbl_output.Text != "")
            {
                if (!Lbl_output.Text.EndsWith("+"))
                {
                    Lbl_output.Text += "+";
                }
            }
        }

        private void btn_samadengan_Click(object sender, EventArgs e)
        {
            string[] angka = Lbl_output.Text.Split('+');

            hasil = 0;

            foreach (string a in angka)
            {
                hasil += Convert.ToDouble(a);
            }

            Lbl_output.Text = hasil.ToString();
        }
    }
}