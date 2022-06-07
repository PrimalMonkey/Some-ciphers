using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_Encryption_
{
    class Hill
    {
        public static void matrixCalc(int[,] matrix, int[] column, int[] result)
        {
            int[] temp = new int[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < column.Length; j++)
                {
                    temp[i] += (matrix[i, j] * column[j]);
                    result[i] = temp[i] % 37;
                    //result[i] += (matrix[i, j] * column[j]);
                }
            }
        }

        public static void matrixCalcForLFSR(int[,] matrix, int[] column, int[] result)
        {
            int[] temp = new int[5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    temp[i] += (matrix[i, j] * column[j]);
                    result[i] = temp[i] % 2;
                }
            }
        }
        public static void genLFSR(int size, double[] arr)
        {
            int a5 = 1;
            int a4 = 0;
            int a3 = 0;
            int a2 = 1;
            int a1 = 0;
            int a0 = 1;

            int[,] matrix = { { a4, a3, a2, a1, a0 }, { 1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0 } };
            int[] column = { a4, a3, a2, a1, a0 };
            int[] x0 = new int[5];
            matrixCalcForLFSR(matrix, column, x0);
            //int[] result = new int[5];

            for (int i = 0; i < size; i++)
            {
                //matrixCalc(matrix, column, x0);
                int temp = to10(x0);
                arr[i] = temp;
                int[] xn = x0;
                x0 = new int[5];
                matrixCalcForLFSR(matrix, xn, x0);
            }

        }

        public static int to10(int[] arr)
        {
            string temp = "";
            int mod = 0;
            int s = 0;
            int count = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
            }

            int num = Convert.ToInt32(temp);
            while (num > 0)
            {
                mod = num % 10;
                s = Convert.ToInt32(Math.Pow(2, count));
                result = result + mod * s;
                count++;
                num = num / 10;
            }

            return result;
        }

        public static void compareArray(char[] column, char[] text, int[] result)
        {
            for (int i = 0; i < column.Length; i++)
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == column[i])
                    {
                        result[i] = j+1;
                    }
                }
        }

        public static void compareArrayForSymbol(int[] column, char[] text, char[] result)
        {
            /*for (int i = 0; i < column.Length; i++)
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == column[i])
                    {
                        result[i] = text[j];
                    }
                }*/
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = text[column[i]];
            }
        }
        // А = 1 Б = 2 В = 3 Г = 4 Д = 5 Е = 6 Ж = 7 З = 8 
        // И = 9 Й = 10 К = 11 Л = 12 М = 13 Н = 14 О = 15
        // П = 16 Р = 17 С = 18 Т = 19 У = 20 Ф = 21 Х = 22
        // Ц = 23 Ч = 24 Ш = 25 Щ = 26 Ъ = 27 Ы = 28 Ь = 29
        // Э = 30 Ю = 31 Я = 32 , = 33 . = 34 ! = 35 ? = 36
        // " " = 37
        // эвакуация
        // 30 3 1 11 20 1 23 9 32

        public static void HillEncryption(char[] column, char[] resultChar, string text)
        {
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя,.!? ";
            StringReader srAlphabet = new StringReader(alphabet);
            int[,] matrix = { { 30, 3, 1 }, { 11, 20, 1 }, { 23, 9, 32 } };
            char[] symbols = new char[text.Length];
            StringReader srText = new StringReader(text);
            char[] indexOfSymbols = new char[alphabet.Length];
            srAlphabet.Read(indexOfSymbols, 0, alphabet.Length);
            text.ToLower();
            srText.Read(symbols, 0, text.Length);
            int[] code = new int[3];
            int[] result = new int[3];
            compareArray(column, indexOfSymbols, code);
            matrixCalc(matrix, code, result);
            compareArrayForSymbol(result, indexOfSymbols, resultChar);

        }
        public static void Ceasar(char[] column, char[] result, string text)
        {
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя,.!? ";
            StringReader srAlphabet = new StringReader(alphabet);
            char[] symbols = new char[text.Length];
            StringReader srText = new StringReader(text);
            char[] indexOfSymbols = new char[alphabet.Length];
            srAlphabet.Read(indexOfSymbols, 0, alphabet.Length);
            text.ToLower();
            srText.Read(symbols, 0, text.Length);
            int[] code = new int[text.Length];
            compareArray(column, indexOfSymbols, code);
            for(int i = 0; i < code.Length; i++)
            {
                result[i] = indexOfSymbols[(code[i] + 3) % indexOfSymbols.Length];
            }
        }
        public static void CeasarMoreKey(char[] column, char[] result, string text)
        {
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя,.!? ";
            string key = "неразводиусокначужойкусок";
            char[] keyColumn = new char[key.Length];
            StringReader srKey = new StringReader(key);
            srKey.Read(keyColumn, 0, key.Length);
            StringReader srAlphabet = new StringReader(alphabet);
            char[] symbols = new char[text.Length];
            StringReader srText = new StringReader(text);
            char[] indexOfSymbols = new char[alphabet.Length];
            srAlphabet.Read(indexOfSymbols, 0, alphabet.Length);
            text.ToLower();
            srText.Read(symbols, 0, text.Length);
            int[] code = new int[key.Length];
            int[] codeKey = new int[key.Length];
            compareArray(keyColumn, indexOfSymbols, codeKey);
            compareArray(column, indexOfSymbols, code);
            for (int i = 0; i < code.Length; i++)
            {
                result[i] = indexOfSymbols[(code[i] + keyColumn[i]) % indexOfSymbols.Length];
            }
        }

        public static void CeasarLFSR(char[] column, char[] result, string text)
        {
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя,.!? ";
            double[] key = new double[text.Length];
            genLFSR(text.Length, key);
            int[] keyWord = new int[text.Length];
            for(int i = 0; i < key.Length; i++)
            {
                keyWord[i] = Convert.ToInt32(key[i]);
            }
            StringReader srAlphabet = new StringReader(alphabet);
            char[] symbols = new char[text.Length];
            StringReader srText = new StringReader(text);
            char[] indexOfSymbols = new char[alphabet.Length];
            srAlphabet.Read(indexOfSymbols, 0, alphabet.Length);
            text.ToLower();
            srText.Read(symbols, 0, text.Length);
            int[] code = new int[text.Length];
            compareArray(column, indexOfSymbols, code);
            for (int i = 0; i < code.Length; i++)
            {
                result[i] = indexOfSymbols[(code[i] + keyWord[i]) % indexOfSymbols.Length];
            }
        }

        /*public static void HillDecryption(char[] column, string decryption, string text)
        {
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя,.!? ";
            StringReader srAlphabet = new StringReader(alphabet);
            double[,] matrix = { { (631 / 17582) % 37, (-87 / 17582) % 37, (-17 / 17582) % 37 }, { (-329 / 17582) % 37, (937 / 17582) % 37, (-19 / 17582) % 37 }, { (-361 / 17582) % 37, (-201 / 17582) % 37, (567 / 17582) % 37 } };
            char[] symbols = new char[text.Length];
            StringReader srText = new StringReader(text);
            char[] indexOfSymbols = new char[alphabet.Length];
            srAlphabet.Read(indexOfSymbols, 0, alphabet.Length);
            text.ToLower();
            srText.Read(symbols, 0, text.Length);
            int[] code = new int[3];
            for(int i = 0; i < column.Length; i++)
            {
                code[i] = column[i];
            }
            int[] result = new int[3];
            matrixCalc(matrix, code, result);
            for(int i = 0; i < result.Length; i++)
            {
                decryption += indexOfSymbols[result[i]];
            }
        }*/
    }
}
