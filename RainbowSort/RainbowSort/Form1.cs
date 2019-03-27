using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Engine.Initialize(pictureBox1);
            DisplaySize.Text = pictureBox1.Height.ToString();
        }

        private void DisplaySize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Height = int.Parse(DisplaySize.Text);
                Resources.ShowRainbow();
            }
            catch { }
        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            Engine.Shuffle();
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            Engine.Bubble();
        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
            Engine.Insertion();
        }

        private void SelectionSort_Click(object sender, EventArgs e)
        {
            Engine.Selection();
        }
    }
}
