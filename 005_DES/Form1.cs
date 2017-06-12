using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_DES
{
    public partial class Form1 : Form
    {
        byte[] asciiVeri;
        string[] bitVeri;
        string[] bitSifre;
        string[] bit64Veri;
        string[] anahtar56lik;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            asciiVeri = Encoding.ASCII.GetBytes(txtboxVeri.Text);
            bitVeri = BitIslemleri.CevirBite(asciiVeri);
            asciiVeri = Encoding.ASCII.GetBytes(txtBoxSifre.Text);
            bitSifre = BitIslemleri.CevirBite(asciiVeri);

            bit64Veri = BitIslemleri.Cevir64bite(bitVeri);
            anahtar56lik = Anahtar.Cevir56bite(bitSifre);
            string[,] anahtar28lik = Anahtar.Bol28e(anahtar56lik);

            for (int i = 0; i < 16; i++)
            {
                bit64Veri = Basla(bit64Veri, txtboxVeri.Text, anahtar28lik);
                anahtar28lik = Anahtar.KaydirSola(anahtar28lik);
            }


            txtBoxSonuc.Text = bit64Veri[0];
        }
        public static string[] Basla(string[] bit64Veri, string textboxVeri, string[,] anahtar28lik)
        {
            string[] bit32VeriSol;
            string[] bit32VeriSag;
            string[,] bit32Veri;

            bit32Veri = BitIslemleri.Cevir32bite(bit64Veri);
            bit32VeriSol = new string[bit32Veri.Length / 2];
            bit32VeriSag = new string[bit32Veri.Length / 2];
            for (int i = 0; i < bit32Veri.Length / 2; i++)
            {
                bit32VeriSol[i] = bit32Veri[i, 0];
                bit32VeriSag[i] = bit32Veri[i, 1];
            }
            int len = textboxVeri.Length / 8;
            if (textboxVeri.Length % 8 != 0)
                len++;
            string[] sonuc32lik = Fonksiyon.Ffonksiyonu(bit32VeriSag, anahtar28lik, len);
            string[] yeniSol32lik = new string[1];
            for (int i = 0; i < 32; i++)
            {
                yeniSol32lik[0] += Fonksiyon.XOR(sonuc32lik[0][i], bit32VeriSol[0][i]);
            }
            string[] yeni64luk = new string[1];
            yeni64luk[0] = bit32VeriSag[0] + yeniSol32lik[0];

            return yeni64luk;
        }
    }
}
