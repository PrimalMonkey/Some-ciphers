using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2_Encryption_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.Legends.Clear();
            string hill = Form1.HillText.TextData;
            char[] hillArr = new char[hill.Length];
            int[] hillFreq = new int[hillArr.Length];
            using (StringReader sr = new StringReader(hill))
            {
                sr.Read(hillArr, 0, hill.Length);
            }

            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 40;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 36;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 5;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.Series[0].ChartType = SeriesChartType.Column;
            string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя,.!? ";
            StringReader srAlphabet = new StringReader(alphabet);
            string text = Form1.MainText.TextData;
            char[] symbols = new char[text.Length];
            StringReader srText = new StringReader(text);
            char[] indexOfSymbols = new char[alphabet.Length];
            srAlphabet.Read(indexOfSymbols, 0, alphabet.Length);
            text.ToLower();
            srText.Read(symbols, 0, text.Length);

            Hill.compareArray(hillArr, indexOfSymbols, hillFreq);

            for (int i = 0; i < indexOfSymbols.Length; i++)
            {
                int freq = Methods.freq(hillFreq, i);
                chart1.Series[0].Points.AddXY(i, freq);
            }

            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart2.Legends.Clear();

            string ceasar = Form1.CeasarText.TextData;
            char[] ceasarArr = new char[ceasar.Length];
            int[] ceasarFreq = new int[ceasarArr.Length];
            using (StringReader sr = new StringReader(ceasar))
            {
                sr.Read(ceasarArr, 0, ceasar.Length);
            }

            chart2.Series[0].Points.Clear();
            chart2.ChartAreas[0].AxisX.Maximum = 40;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 36;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Interval = 1;
            chart2.ChartAreas[0].AxisX.Interval = 5;
            chart2.ChartAreas[0].AxisX.Crossing = 0;
            chart2.ChartAreas[0].AxisY.Crossing = 0;
            chart2.Series[0].ChartType = SeriesChartType.Column;

            Hill.compareArray(ceasarArr, indexOfSymbols, ceasarFreq);

            for (int i = 0; i < indexOfSymbols.Length; i++)
            {
                int freq = Methods.freq(ceasarFreq, i);
                chart2.Series[0].Points.AddXY(i, freq);
            }

            chart3.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart3.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart3.Legends.Clear();

            string ceasarMoreKey = Form1.CeasarMoreKey.TextData;
            char[] ceasarMoreKeyArr = new char[ceasarMoreKey.Length];
            int[] ceasarMoreKeyFreq = new int[ceasarMoreKeyArr.Length];
            using (StringReader sr = new StringReader(ceasarMoreKey))
            {
                sr.Read(ceasarMoreKeyArr, 0, ceasarMoreKey.Length);
            }

            chart3.Series[0].Points.Clear();
            chart3.ChartAreas[0].AxisX.Maximum = 40;
            chart3.ChartAreas[0].AxisX.Minimum = 0;
            chart3.ChartAreas[0].AxisY.Maximum = 36;
            chart3.ChartAreas[0].AxisY.Minimum = 0;
            chart3.ChartAreas[0].AxisY.Interval = 1;
            chart3.ChartAreas[0].AxisX.Interval = 5;
            chart3.ChartAreas[0].AxisX.Crossing = 0;
            chart3.ChartAreas[0].AxisY.Crossing = 0;
            chart3.Series[0].ChartType = SeriesChartType.Column;

            Hill.compareArray(ceasarMoreKeyArr, indexOfSymbols, ceasarMoreKeyFreq);

            for (int i = 0; i < indexOfSymbols.Length; i++)
            {
                int freq = Methods.freq(ceasarMoreKeyFreq, i);
                chart3.Series[0].Points.AddXY(i, freq);
            }

            chart4.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart4.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart4.Legends.Clear();

            string ceasarLFSR = Form1.CeasarLFSR.TextData;
            char[] ceasarLFSRArr = new char[ceasarLFSR.Length];
            int[] ceasarLFSRFreq = new int[ceasarLFSRArr.Length];
            using (StringReader sr = new StringReader(ceasarLFSR))
            {
                sr.Read(ceasarLFSRArr, 0, ceasarLFSR.Length);
            }

            chart4.Series[0].Points.Clear();
            chart4.ChartAreas[0].AxisX.Maximum = 40;
            chart4.ChartAreas[0].AxisX.Minimum = 0;
            chart4.ChartAreas[0].AxisY.Maximum = 36;
            chart4.ChartAreas[0].AxisY.Minimum = 0;
            chart4.ChartAreas[0].AxisY.Interval = 1;
            chart4.ChartAreas[0].AxisX.Interval = 5;
            chart4.ChartAreas[0].AxisX.Crossing = 0;
            chart4.ChartAreas[0].AxisY.Crossing = 0;
            chart4.Series[0].ChartType = SeriesChartType.Column;

            Hill.compareArray(ceasarLFSRArr, indexOfSymbols, ceasarLFSRFreq);

            for (int i = 0; i < indexOfSymbols.Length; i++)
            {
                int freq = Methods.freq(ceasarLFSRFreq, i);
                chart4.Series[0].Points.AddXY(i, freq);
            }

            chart5.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart5.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart5.Legends.Clear();

            string text1 = Form1.MainText.TextData;
            char[] text1Arr = new char[text1.Length];
            int[] text1Freq = new int[text1Arr.Length];
            using (StringReader sr = new StringReader(text1))
            {
                sr.Read(text1Arr, 0, text1Arr.Length);
            }

            chart5.Series[0].Points.Clear();
            chart5.ChartAreas[0].AxisX.Maximum = 40;
            chart5.ChartAreas[0].AxisX.Minimum = 0;
            chart5.ChartAreas[0].AxisY.Maximum = 36;
            chart5.ChartAreas[0].AxisY.Minimum = 0;
            chart5.ChartAreas[0].AxisY.Interval = 1;
            chart5.ChartAreas[0].AxisX.Interval = 5;
            chart5.ChartAreas[0].AxisX.Crossing = 0;
            chart5.ChartAreas[0].AxisY.Crossing = 0;
            chart5.Series[0].ChartType = SeriesChartType.Column;

            Hill.compareArray(text1Arr, indexOfSymbols, text1Freq);

            for (int i = 0; i < indexOfSymbols.Length; i++)
            {
                int freq = Methods.freq(text1Freq, i);
                chart5.Series[0].Points.AddXY(i, freq);
            }
        }
    }
}
