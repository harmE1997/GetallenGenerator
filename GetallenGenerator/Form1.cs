using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetallenGenerator
{
    public partial class Form1 : Form
    {
        Random getal = new Random();
        List<int> numbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerate_Click_1(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(nudNumber.Value);
            numbers.Clear();
            GenerateNumbers(cbDoubles.Checked, amount, Convert.ToInt32(nudmin.Value), Convert.ToInt32(nudmax.Value));

            if (cbSort.Checked)
                numbers.Sort();

            addNumbersToOutput(amount);
        }

        private void addNumbersToOutput(int counter)
        {
            lbOutput.Items.Clear();
            foreach (int nr in numbers)
            {
                lbOutput.Items.Add(nr);
            }
        }

        private void GenerateNumbers(bool doubles, int amount, int min, int max)
        {
            if (max < min)
            {
                MessageBox.Show("Maximum kan niet kleiner zijn dan minimum!");
                return;
            }

            int dif = max - min;
            if (!doubles && dif < amount - 1)
            {
                MessageBox.Show("Kan niet genereren met de huidige instellingen!");
                return;
            }

            while (numbers.Count < amount)
            {
                int number = getal.Next(min, (max + 1));
                if (doubles || !numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }
        }
    }
}
