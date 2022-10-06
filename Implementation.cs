using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace InformationSecurityProgram
{
    class Implementation
    {

        static public string path = "";
        static public string text = "";
        static public int bitsUsage = 4;
        static public string pathOut = "";


        private const int INT8_BITS_COUNT = 8;
        private const int INT32_BITS_COUNT = 32;

        static public void Encode()
        {
            using (var bmp = (Bitmap)Image.FromFile(path))
            {
                var bd = bmp.LockBits(
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite,
                    bmp.PixelFormat
                    );
                // Буфер с текстом
                var buff = Encoding.Default.GetBytes(text);
                // Буфер с изображением (массив пикселей)
                var rgb = new byte[bd.Stride * bd.Height];
                Marshal.Copy(bd.Scan0, rgb, 0, rgb.Length);
                // Кодируем текст в изображение
                EncodeDataBitsToImage(buff, rgb, bitsUsage);

                Marshal.Copy(rgb, 0, bd.Scan0, rgb.Length);
                bmp.UnlockBits(bd);

                bmp.Save(pathOut, ImageFormat.Png);
            }

        }


        static public string Dencode()
        {
            string output = "";
            using (var bmp = (Bitmap)Image.FromFile(path))
            {
                var bd = bmp.LockBits(
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadOnly,
                    bmp.PixelFormat
                    );
                // Буфер с изображением (массив пикселей)
                var rgb = new byte[bd.Stride * bd.Height];
                Marshal.Copy(bd.Scan0, rgb, 0, rgb.Length);
                // Декодируем текст из изображение
                output = DecodeImageBitsToString(rgb, bitsUsage);
                bmp.UnlockBits(bd);
            }
            return output;
        }


        static void EncodeDataBitsToImage(byte[] text, byte[] image, int bitsUsage)
        {
            if (image == null)
                throw new NullReferenceException();
            if (text == null)
                throw new NullReferenceException();

            if (text.Length * (INT8_BITS_COUNT / bitsUsage) > image.Length)
                throw new OutOfMemoryException();

            WriteLength(image, text.Length, bitsUsage);

            int i = 0;              // Номер байта в массиве text
            int j;                  // Смещение бит
            int k = INT32_BITS_COUNT / bitsUsage; // Номер байта в массиве image

            byte mask0 = (byte)(~0 << bitsUsage);
            byte mask1 = (byte)(~mask0);

            for (i = 0; i < text.Length; ++i)
                for (j = 0; j < INT8_BITS_COUNT; j += bitsUsage)
                {
                    image[k] &= mask0;
                    image[k] |= (byte)((text[i] & (mask1 << j)) >> j);
                    k++;
                }
        }
        /// <summary>
        /// Извлечение текста из массива image, извлекая каждые bitsUsage младших бит из каждого байта image.
        /// </summary>
        /// <param name="image">Массив пикселей.</param>
        /// <param name="bitsUsage">Количество используемых бит (1, 2 или 4.).</param>
        /// <returns>Возвращает закодированную строку.</returns>
        static string
        DecodeImageBitsToString(byte[] image, int bitsUsage)
        {
            if (image == null)
                throw new NullReferenceException();

            int length = ReadLength(image, bitsUsage);
            var buff = new byte[length];

            int i = 0;              // Номер байта в массиве text
            int j;                  // Смещение бит
            int k = INT32_BITS_COUNT / bitsUsage; // Номер байта в массиве image

            byte mask0 = (byte)(~(~0 << bitsUsage));

            for (i = 0; i < length; ++i)
                for (j = 0; j < INT8_BITS_COUNT; j += bitsUsage)
                {
                    buff[i] |= (byte)((image[k] & mask0) << j);
                    k++;
                }

            return Encoding.Default.GetString(buff);
        }
        /// <summary>
        /// Запись значение length в массив байт, используя в каждом байте указанное число bitsUsage.
        /// </summary>
        /// <param name="buff">Массив с данными.</param>
        /// <param name="length">Значение длины.</param>
        /// <param name="bitsUsage">Количество используемых бит: 1, 2 или 4.</param>
        static void
        WriteLength(byte[] buff, int length, int bitsUsage)
        {
            byte mask0 = (byte)(~0 << bitsUsage);
            byte mask1 = (byte)(~mask0);

            for (int i = 0; i < INT32_BITS_COUNT / bitsUsage; ++i)
            {
                buff[i] &= mask0;
                buff[i] |= (byte)((length & (mask1 << i * bitsUsage)) >> i * bitsUsage);
            }
        }
        /// <summary>
        /// Извлечение длины из массива байт, извлекая каждые bitsUsage в байте.
        /// </summary>
        /// <param name="buff">Массив с данными.</param>
        /// <param name="bitsUsage">Количество используемых бит: 1, 2 или 4.</param>
        /// <returns>Возвращает закодированное значение длины.</returns>
        static int
        ReadLength(byte[] buff, int bitsUsage)
        {
            int length = 0;
            byte mask0 = (byte)(~(~0 << bitsUsage));

            for (int i = 0; i < INT32_BITS_COUNT / bitsUsage; ++i)
                length |= (buff[i] & mask0) << i * bitsUsage;

            return length;
        }
    }
}
