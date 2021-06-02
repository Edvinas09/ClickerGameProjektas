using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace ClickerGameProjektas
{
    public partial class Form1 : Form
    {
        Shop shopForm;
        int coins;
        int easterEgg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMainClick_Click(object sender, EventArgs e)
        {
            progressLevel.Value++;
            coins += 2;
            if (progressLevel.Value == 5 && lblLevel.Text == "1")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "2";
                progressLevel.Maximum = 10;
            }
            else if (progressLevel.Value == 10 && lblLevel.Text == "2")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "3";
                progressLevel.Maximum = 15;
                btnShop.Visible = true;
                easterEgg = 2;
            }
            else if (progressLevel.Value == 15 && lblLevel.Text == "3")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "4";
                progressLevel.Maximum = 20;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressLevel.Maximum = 5;
            progressLevel.Minimum = 0;
            btnShop.Visible = false;
            btnBossFight.Visible = false;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shopForm = new Shop(coins);
            shopForm.ShowDialog();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (easterEgg ==2)
            {
                MessageBox.Show("Congratulations you have found the 'special' cookie! You have been awarded 1000 coins!");
                coins += 1000;
                easterEgg = 1;
            }
            else if (easterEgg == 1)
            {
                MessageBox.Show("You have already found this easter egg!");
            }
        }
    }
}
