using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrisler
{
    public class Matrix
    {
        /// <summary>
        /// Matris Olusturur
        /// </summary>
        /// <param name="satir">Satir Sayisi</param>
        /// <param name="sutun">Sutun Sayisi</param>
        /// <param name="min">min Deger</param>
        /// <param name="max">max Deger</param>
        /// <returns>Matrisi dondurur</returns>
        public static int[,] Olustur(int satir=3, int sutun=3,int min=1,int max=9)
        {
            int[,] X = new int[satir, sutun];

            for(int i = 0; i < satir; i++)
            {
                for(int j = 0; j < sutun; j++)
                {
                    X[i,j] = new Random().Next(min,max);
                }
            }

            return X;
        }

        /// <summary>
        /// Parametre olarak aldigi matrisi yazar
        /// </summary>
        /// <param name="matris">Matris</param>
        public static void Yazdir(int[,] matris) 
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for ( int j = 0;j < matris.GetLength(1); j++)
                    Console.Write("{0,3}",matris[i, j]);
                Console.WriteLine();
            }
        }
    }
}
