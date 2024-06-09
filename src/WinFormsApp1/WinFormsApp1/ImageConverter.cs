using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ImageConverter
    {
        public static string getASCUser(Bitmap img)
        {
            int[,] binaryArray = new int[8, img.Width];

            // Mendefinisikan warna hitam dan putih
            Color black = Color.FromArgb(255, 0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255, 255);

            int facH = img.Height % 8;

            int temp = 0;

            if ((img.Height - facH) % 2 == 1)
            {
                temp = (img.Height - facH - 1) / 16;
            }
            else
            {
                temp = (img.Height - facH) / 16;
            }

            int addH = temp * 8;

            string asciiString = "";
            for (int y = 0; y < img.Width; y++)
            {
                string asciiChar = "";
                for (int x = 0; x < 8; x++)
                {
                    // Mendapatkan warna pixel pada posisi (x, y)
                    Color pixelColor = img.GetPixel(y, x + addH);

                    // Mengecek apakah pixel tersebut hitam atau putih dan mengisi array
                    if (pixelColor.ToArgb() == black.ToArgb())
                    {
                        binaryArray[x, y] = 1;
                    }
                    else if (pixelColor.ToArgb() == white.ToArgb())
                    {
                        binaryArray[x, y] = 0;
                    }
                    else
                    {
                        // Asumsi default: anggap non-putih sebagai hitam
                        binaryArray[x, y] = 1;
                    }
                    string t = binaryArray[x, y].ToString();
                    asciiChar += t;
                }

                //MessageBox.Show(asciiChar);

                int intValue = Convert.ToInt32(asciiChar, 2);
                char charValue = (char)intValue;
                asciiString += charValue;
            }

            return asciiString;
        }

        public static string getASCDB(Bitmap img)
        {
            int[,] binaryArray = new int[8, 30];

            // Mendefinisikan warna hitam dan putih
            Color black = Color.FromArgb(255, 0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255, 255);

            int facH = img.Height % 8;

            int temp = 0;

            if ((img.Height - facH) % 2 == 1)
            {
                temp = (img.Height - facH - 1) / 16;
            }
            else
            {
                temp = (img.Height - facH) / 16;
            }

            int addH = temp * 8;

            string asciiString = "";
            for (int y = 0; y < 30; y++)
            {
                string asciiChar = "";
                for (int x = 0; x < 8; x++)
                {
                    // Mendapatkan warna pixel pada posisi (x, y)
                    Color pixelColor = img.GetPixel(y, x + addH);

                    // Mengecek apakah pixel tersebut hitam atau putih dan mengisi array
                    if (pixelColor.ToArgb() == black.ToArgb())
                    {
                        binaryArray[x, y] = 1;
                    }
                    else if (pixelColor.ToArgb() == white.ToArgb())
                    {
                        binaryArray[x, y] = 0;
                    }
                    else
                    {
                        // Asumsi default: anggap non-putih sebagai hitam
                        binaryArray[x, y] = 1;
                    }
                    string t = binaryArray[x, y].ToString();
                    asciiChar += t;
                }

                //MessageBox.Show(asciiChar);

                int intValue = Convert.ToInt32(asciiChar, 2);
                char charValue = (char)intValue;
                asciiString += charValue;
            }

            return asciiString;
        }

        public static string[]  GetBmpFiles (string directory)
        {
            // Cek apakah direktori ada
            if (!Directory.Exists(directory))
            {
                Console.WriteLine("Direktori tidak ditemukan.");
                return new string[] { };
            }

            // Dapatkan semua file BMP dalam direktori
            string[] bmpFiles = Directory.GetFiles(directory, "*.bmp");

            // Ekstrak nama file dari path lengkapnya
            string[] bmpFileNames = bmpFiles.Select(Path.GetFileName).ToArray();

            return bmpFiles;
        }
    }
}
