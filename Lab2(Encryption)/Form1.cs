using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab2_Encryption_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        public static class HillText
        {
            public static string TextData { get; set; }
        }

        public static class MainText
        {
            public static string TextData { get; set; }
        }

        public static class CeasarText
        {
            public static string TextData { get; set; }
        }

        public static class CeasarMoreKey
        {
            public static string TextData { get; set; }
        }

        public static class CeasarLFSR
        {
            public static string TextData { get; set; }
        }

        

        private OpenFileDialog openFileDialog1;

        private void buttonHill_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            textBox1.Text = fileText;
            MainText.TextData = fileText;
            MessageBox.Show("Файл открыт");
            string text = fileText.ToLower();
            char[] column = new char[text.Length];
            char[] result = new char[3];
            char[] columnX3 = new char[3];
            string test = "";
            int i = 0;
            string cipher = "";
            while (i < text.Length - 3)
            {
                test = text.Substring(i, 3);
                i += 3;
                using (StringReader sr = new StringReader(test))
                {
                    sr.Read(columnX3, 0, test.Length);
                }
                Hill.HillEncryption(columnX3, result, text);
                columnX3 = new char[3];
                for(int j = 0; j < result.Length; j++)
                {
                    cipher += result[j];
                }
                result = new char[3];
                textBoxCipher.Text = cipher;
                HillText.TextData = textBoxCipher.Text;
            }

        }

        private void buttonCeasar_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
            char[] column = new char[text.Length];
            string cipherCeasar = "";
            using (StringReader sr = new StringReader(text))
            {
                sr.Read(column, 0, text.Length);
            }
            char[] result = new char[text.Length];
            Hill.Ceasar(column, result, text);
            for(int i = 0; i < result.Length; i++)
            {
                cipherCeasar += result[i];
            }
            textBoxCesar.Text = cipherCeasar;
            CeasarText.TextData = textBoxCesar.Text;

        }

        private void buttonCeasarMoreKey_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
            char[] column = new char[text.Length];
            char[] result = new char[25];
            char[] columnX24 = new char[25];
            string test = "";
            int i = 0;
            string cipher = "";
            while (i < text.Length - 25)
            {
                test = text.Substring(i, 25);
                i += 24;
                using (StringReader sr = new StringReader(test))
                {
                    sr.Read(columnX24, 0, test.Length);
                }
                Hill.CeasarMoreKey(columnX24, result, text);
                columnX24 = new char[25];
                for (int j = 0; j < result.Length; j++)
                {
                    cipher += result[j];
                }
                result = new char[25];
                textBoxCeasarMoreKey.Text = cipher;
                CeasarMoreKey.TextData = textBoxCeasarMoreKey.Text;
            }
        }

        private void buttonLFSR_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
            char[] column = new char[text.Length];
            string cipherCeasarLFSR = "";
            using (StringReader sr = new StringReader(text))
            {
                sr.Read(column, 0, text.Length);
            }
            char[] result = new char[text.Length];
            Hill.CeasarLFSR(column, result, text);
            for (int i = 0; i < result.Length; i++)
            {
                cipherCeasarLFSR += result[i];
            }
            textBoxLFSR.Text = cipherCeasarLFSR;
            CeasarLFSR.TextData = textBoxLFSR.Text;
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
