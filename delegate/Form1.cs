using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //delegate void dortişlem(int a,int b);

        //void Topla(int a, int b)
        //{
        //    int toplam = a + b;
        //    listBox1.Items.Add(toplam);
        //}
        //void Cıkarma(int a, int b)
        //{
        //    int cıkarma = a - b;
        //    listBox1.Items.Add(cıkarma);
        //}
        //void Carpma(int a, int b)
        //{
        //    int carpma = a * b;
        //    listBox1.Items.Add(carpma);
        //}
        //void Bölme(int a, int b)
        //{
        //    int bölme = a / b;
        //    listBox1.Items.Add(bölme);
        //}
        delegate int hesapkYolKm(int km, int yol);

        public int KmHesap1(int km,int yol)
        {
            int sonuc = yol / km;
            listBox1.Items.Add(sonuc);
            return sonuc;
        }
        public int KmHesap2(int km, int yol)
        {
            int sonuc = yol * km;
            listBox1.Items.Add(sonuc);
            return sonuc;
        }
        public int KmHesap3(int km, int yol)
        {
            int sonuc = km/ yol;
            listBox1.Items.Add(sonuc);
            return sonuc;
        }


        private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapkYolKm islem = new hesapkYolKm(KmHesap1);
            islem += KmHesap2;
            islem += KmHesap3;
            int km = Convert.ToInt32(textBox1.Text);
            int yol = Convert.ToInt32(textBox2.Text);
            islem(km, yol);
            //dortişlem islem = new dortişlem(Topla);
            //islem += Cıkarma;
            //islem += Carpma;
            //islem += Bölme;
            //int sayi = Convert.ToInt32(textBox1.Text);
            //int sayi2 = Convert.ToInt32(textBox2.Text);
            //islem(sayi,sayi2);

            //Topla(20, 20);
            //Cıkarma(10, 20);
            //Bölme(55, 2);
            //Carpma(10, 2);
        }
    }
}
