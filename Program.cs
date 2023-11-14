using Matrisler;

// constructor degerlerinde Matrix olusturur
int[,] Y = Matrix.Olustur();
Console.WriteLine("\n  Constructor Matrixi  \n");
Matrix.Yazdir(Y);
Matrix.Cizgi();

// 4-4 Sifir Matrix Olusturur
int[,] sifirMatrix = Matrix.SifirMatrixOlustur(4, 4);
Console.WriteLine("  Sifir Matrix  \n");
Matrix.Yazdir(sifirMatrix);
Matrix.Cizgi();

// 3-3 Birler Matrix Olusturur
int[,] birlerMatrix = Matrix.BirlerMatrixOlustur(3, 2);
Console.WriteLine("  Birler Matrixi  \n");
Matrix.Yazdir(birlerMatrix);
Matrix.Cizgi();

// 5-5 Diagonal Matrix Olusturur
int[,] diagonalMatrix = Matrix.DiagonalMatrixOlustur(5);
Console.WriteLine("  Diagonal Matrix  \n");
Matrix.Yazdir(diagonalMatrix);
Matrix.Cizgi();

// 3-3 Kosegen degeri 6 olan Skaler Matrix Olusturur
int[,] skalerMatrix = Matrix.SkalerMatrixOlustur(3,6);
Console.WriteLine("  Skaler Matrix  \n");
Matrix.Yazdir(skalerMatrix);
Matrix.Cizgi();

// verilen matrix kare matrix mi
Console.WriteLine("  Verilen matrix kare matrix mi  \n");
Matrix.Yazdir(birlerMatrix);
Console.WriteLine("{0}",Matrix.KareMatrixMi(birlerMatrix) ? "  Kare matrix.\n" : "  Kare matrix degil.\n");
Matrix.Cizgi();

// default degerleri ile Birim Matrix Olusturur
Console.WriteLine("  Birim Matrix \n");
int[,] birimMatrix = Matrix.BirimMatrixOlustur();
Matrix.Yazdir(birimMatrix);
Matrix.Cizgi();

// verilen matrix birim matrix mi
Console.WriteLine("  Verilen matrix birim matrix mi  \n");
int[,] birimMatrix2 = { { 1, 0, 0 },
                        { 0, 1, 0 },
                        { 1, 0, 1 },};
Matrix.Yazdir(birimMatrix2);
Console.WriteLine("{0}", Matrix.BirimMatrixMi(birimMatrix2) ? "  Birim matrix.\n" : "  Birim matrix degil.\n");
Matrix.Cizgi();


// Diagonal elamanlar
Console.WriteLine("  Diagonal Matrix  \n");
int[,] diagonalMatrix2 = Matrix.DiagonalMatrixOlustur(6);
Matrix.Yazdir(diagonalMatrix2);
Console.WriteLine("  Diagonal elemanlar  \n");
int[] D = Matrix.DiagonalElementsList(diagonalMatrix2);
Matrix.Yazdir(D);

// Matrix Izi
Console.WriteLine("  Matrixin Izi = {0} \n",Matrix.MatrixIzi(diagonalMatrix2));
Matrix.Cizgi();



Console.ReadKey();