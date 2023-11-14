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
        public static void Yazdir(int[,] matrix) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for ( int j = 0;j < matrix.GetLength(1); j++)
                    Console.Write("{0,3}", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// parametre olarak aldigi tek boyutlu matrixi yazar
        /// </summary>
        /// <param name="matrix">Matrix</param>
        public static void Yazdir(int[] matrix )
        {
            for (int i = 0; i < matrix.Length; i++)
                Console.Write("{0,3}", matrix[i]);

            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Cizgi cizer
        /// </summary>
        public static void Cizgi()
        {
            Console.WriteLine("{0}", new String('-', Console.BufferWidth));
            Console.WriteLine();
        }

        /// <summary>
        /// Sifir Matrix olusturur
        /// </summary>
        /// <param name="satir">satir sayisi</param>
        /// <param name="sutun">sutun sayisi</param>
        /// <returns>Matrix</returns>
        public static int[,] SifirMatrixOlustur(int satir,int sutun) 
        {
            return Olustur(satir, sutun, 0,0);
        }

        /// <summary>
        /// Birler Matrix olusturur
        /// </summary>
        /// <param name="satir">satir sayisi</param>
        /// <param name="sutun">sutun sayisi</param>
        /// <returns>Matrix</returns>
        public static int[,] BirlerMatrixOlustur(int satir,int sutun) 
        {
            return Olustur(satir, sutun, 1, 1);
        }

        /// <summary>
        /// Diagonal Matrix olusturur
        /// </summary>
        /// <param name="boyut">satir ve sutun sayisi</param>
        /// <param name="min">min</param>
        /// <param name="max">max</param>
        /// <returns>Diagonal Matrix</returns>
        public static int[,] DiagonalMatrixOlustur(int boyut,int min=1,int max=9)
        {
            // Sadece kare matrixler diagonal olabilir
            // Kosegenler disindaki yerler 0dir 
            int[,] matrix = SifirMatrixOlustur(boyut, boyut);
            for (int i = 0; i < boyut; i++)
                matrix[i,i] = new Random().Next(min,max);
            return matrix;
        }

        /// <summary>
        /// Skaler Matrix Olusturur
        /// </summary>
        /// <param name="boyut">satir ve sutun sayisi</param>
        /// <param name="skaler">kosegen degeri</param>
        /// <returns>Skaler Matrix</returns>
        public static int[,] SkalerMatrixOlustur(int boyut=3, int skaler=3)
        {
            // Skaler Matrixin kosegen degerleri aynıdır
            return DiagonalMatrixOlustur(boyut, skaler, skaler);
        }

        /// <summary>
        /// satir = sutunsa Kare Matrixtir
        /// </summary>
        /// <param name="matrix">matrix</param>
        /// <returns>bool</returns>
        public static bool KareMatrixMi(int[,] matrix)
        {
            // satir == sutun -> Kare Matrix
            return matrix.GetLength(0) == matrix.GetLength(1) ? true : false;
        }

        /// <summary>
        /// Birim Matrix olusturur
        /// </summary>
        /// <param name="boyut">satir sutun sayisi</param>
        /// <returns>Birim Matrix</returns>
        public static int[,] BirimMatrixOlustur(int boyut=3)
        {
            return SkalerMatrixOlustur(boyut, 1);
        }

        /// <summary>
        /// matrix birim mi kontrol eder
        /// </summary>
        /// <param name="matrix">matrix</param>
        /// <returns>bool</returns>
        public static bool BirimMatrixMi(int[,] matrix)
        {
            bool control = false;
            if(KareMatrixMi(matrix))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != 0 && i != j)
                        { control = false; break; }
                        else
                        {
                            if(matrix[i,i] == 1)
                                control = true;
                            
                        }
                    }
                } 
                return control;
            }
            else return control;
        }

        /// <summary>
        /// Diagonal elemanların listesini dondurur
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Array</returns>
        public static int[] DiagonalElementsList(int[,] matrix)
        {
            if(KareMatrixMi(matrix))
            {
                int[] list = new int[matrix.GetLength(0)];

                for (int i = 0; i < matrix.GetLength(0); i++)
                    list[i] = matrix[i, i];

                return list;
            }
            else
            {
                Console.WriteLine("Kare Matrix veriniz !!");
                return new int[0];
            }
        }

        /// <summary>
        /// Matrix Izini bulur
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>int</returns>
        public static int MatrixIzi(int[,] matrix)
        {
            // Matrix Izi kosegen toplamidir
            int toplam = 0;

            if(KareMatrixMi(matrix))
            {
                int[] D = DiagonalElementsList(matrix);
                for (int i = 0; i < matrix.GetLength(0); i++)
                    toplam += matrix[i, i];
                return toplam;
            }
            return toplam;
        }
    }
}
