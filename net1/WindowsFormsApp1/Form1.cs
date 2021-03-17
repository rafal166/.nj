using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using net1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox2.Text);
            int seed = Int32.Parse(textBox1.Text);
            int size = Int32.Parse(textBox3.Text);
            RandomNumberGenerator rng = new RandomNumberGenerator(seed);
            List<item> items = new List<item>();
            Backpack bag = new Backpack(size);

            for (int i = 0; i < n; i++)
            {
                items.Add(new item(value: rng.nextInt(1, 29)));
            }
            for (int i = 0; i < n; i++)
            {
                items[i].set_weight(rng.nextInt(1, 29));
                bag.addNewItem(items[i]);
            }

            textBox5.Text = bag.getRemainingSize().ToString();
            textBox4.Text = bag.getValue().ToString();

        }
    }
}
