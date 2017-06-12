using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_DES
{
    class BitIslemleri
    {

        public static string[] CevirBite(byte[] byte_dizi)
        {
            string[] bit_ = new string[byte_dizi.Length];
            for (int i = 0; i < bit_.Length; i++)
            {
                //Convert.ToString(bit_[i],2) ile <strong>byte</strong> dizimizdeki değeri 
                //2'lik tabana çevirdik ve <strong>PadLeft</strong> 
                //komutu ile soldan uzunluğu 8 olacak şekilde 0'a tamamlama işlemini yaptık.
                bit_[i] = Convert.ToString(byte_dizi[i], 2).PadLeft(8, '0');
            }
            return bit_;
        }
        public static string[] Cevir64bite(string[] byte_dizi)
        {
            int k = -1;
            int len = 0;
            len = byte_dizi.Length / 8;
            if (byte_dizi.Length % 8 != 0)
                len++;
            string[] bit64Veri = new string[len];

            for (int i = 0; i < byte_dizi.Length; i++)
            {
                if (i % 8 == 0)
                    k++;
                bit64Veri[k] += byte_dizi[i];
            }
            return bit64Veri;
        }
        public static string[,] Cevir32bite(string[] bit64Veri)
        {
            string[,] bit32Veri = new string[bit64Veri.Length, 2];
            for (int i = 0; i < bit64Veri.Length; i++)
            {
                for (int j = 0; j < bit64Veri[i].Length; j++)
                {
                    if (j < 32)
                        bit32Veri[i, 0] += bit64Veri[i][j];
                    else
                        bit32Veri[i, 1] += bit64Veri[i][j];
                }
            }
            return bit32Veri;
        }
    }
}
