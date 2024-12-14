using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialVisualizer
{
    public partial class Form1 : Form
    {
        List<int> sred = new List<int>();
        int click = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
            label2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            click++;
            int randomValue = random.Next(0, 100);
            Series series = chart1.Series[0];
            int nextPointIndex = series.Points.Count + 1;
            sred.Add(randomValue);
            int pred = 0;
            for (int i = 0; i < sred.Count; i++) {
                pred += sred[i];
            }
            int final = pred / sred.Count;
            series.Points.AddXY(nextPointIndex, randomValue);
            label1.Text = final.ToString();
            label2.Text = click.ToString();
        }
    }
}