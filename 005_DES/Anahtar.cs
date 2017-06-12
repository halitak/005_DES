using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_DES
{
    class Anahtar
    {


        public static string[,] Bol28e(string[] anahtar56lik)
        {
            string[,] anahtar28lik = new string[anahtar56lik.Length, 2];
            for (int i = 0; i < anahtar56lik.Length; i++)
            {
                for (int j = 0; j < anahtar56lik[i].Length; j++)
                {
                    if (j < 28)
                        anahtar28lik[i, 0] += anahtar56lik[i][j];
                    else
                        anahtar28lik[i, 1] += anahtar56lik[i][j];
                }
            }
            return anahtar28lik;
        }

        public static string[] Cevir56bite(string[] byte_dizi)
        {
            int k = -1;
            int len = 0;
            len = byte_dizi.Length / 7;
            if (byte_dizi.Length % 7 != 0)
                len++;
            string[] bit56Anahtar = new string[len];

            for (int i = 0; i < byte_dizi.Length; i++)
            {
                if (i % 7 == 0)
                    k++;
                bit56Anahtar[k] += byte_dizi[i];
            }
            return bit56Anahtar;
        }
        public static string[] Uret48lik(string[,] anahtar28lik)
        {
            string[] anahtar48likSonuc = new string[anahtar28lik.Length/2];
            string[] anahtar28likSol = new string[anahtar28lik.Length / 2];
            string[] anahtar28likSag = new string[anahtar28lik.Length / 2];
            int len = anahtar28lik.Length / 2;

            for (int i = 0; i < anahtar28likSol.Length; i++)
            {
                anahtar28likSol[i] = anahtar28lik[i, 0];
                anahtar28likSag[i] = anahtar28lik[i, 1];
            }

            int k = 0;
            for (int i = 0; i < anahtar28likSol.Length; i++)
            {
                for (int j=4; j < anahtar28likSol[i].Length; j++)
                {
                    if (anahtar28likSol[i][j] == null)
                        break;
                    anahtar48likSonuc[i] += anahtar28likSol[i][j];
                    k++;
                }
            }
            string a = "eh";
            for (int i = 0; i < anahtar28likSag.Length; i++)
            {
                if (anahtar28likSag[i] == null)
                    break;
                for (int j = 0; j < (anahtar28likSag[i].Length-4); j++)
                {
                    if (anahtar28likSag[i][j] == null)
                        break;
                    anahtar48likSonuc[i] += anahtar28likSag[i][j];
                    k++;
                }
            }


            a = "eh";
            return anahtar48likSonuc;
        }

        public static string[,] KaydirSola(string[,] anahtar28lik)
        {
            string[,] anahtar28likyeni = new string[1,anahtar28lik.Length];
            int k = 1;
            for (int i = 0; i < anahtar28lik.Length/2; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    if (j + 1 < 28)
                    {
                        anahtar28likyeni[i, 0] += anahtar28lik[i, 0][j + 1];
                        anahtar28likyeni[i, 1] += anahtar28lik[i, 1][j + 1];
                    }
                    else
                    {
                        anahtar28likyeni[i, 0] += anahtar28lik[i, 0][0];
                        anahtar28likyeni[i, 1] += anahtar28lik[i, 1][0];
                    }
                }
            }

            return anahtar28likyeni;
        }
    }
}
