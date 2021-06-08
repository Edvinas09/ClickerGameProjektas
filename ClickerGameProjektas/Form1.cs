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
        int coins;
        int easterEgg = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMainClick_Click(object sender, EventArgs e)
        {
            coins += 2;
            progressLevel.Value++;

            //Checking levels
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
            else if (progressLevel.Value == 20 && lblLevel.Text == "4")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "5";
                progressLevel.Maximum = 40;
            }
            else if (progressLevel.Value == 40 && lblLevel.Text == "5")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "6";
                progressLevel.Maximum = 60;
            }
            else if (progressLevel.Value == 60 && lblLevel.Text == "6")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "7";
                progressLevel.Maximum = 80;
            }
            else if (progressLevel.Value == 80 && lblLevel.Text == "7")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "8";
                progressLevel.Maximum = 100;
            }
            else if (progressLevel.Value == 100 && lblLevel.Text == "8")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "9";
                progressLevel.Maximum = 120;
            }
            else if (progressLevel.Value == 120 && lblLevel.Text == "9")
            {
                progressLevel.Value = 0;
                lblLevel.Text = "10";
                progressLevel.Maximum = 140;
            }
            if (progressLevel.Value == 140 && lblLevel.Text == "10")
            {
                btnBossFight.Visible = true;
                MessageBox.Show("Congratulations, you have reached level 10, which means there is one boss fight left to complete the game!");
                btnMainClick.Enabled = false;
                BossFightShopOptions.CanYouBuy = true;
            }





            //Checking coins
            if (Coins.coins5 == true)
            {
                coins += 3;
            }
            if (Coins.coins15 == true)
            {
                coins += 10;
            }
            if (Coins.coins30 == true)
            {
                coins += 20;
            }
            if (Coins.coins55 == true)
            {
                coins += 20;
            }







        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BossFightShopOptions.CanYouBuy = false;
            progressLevel.Maximum = 5;
            progressLevel.Minimum = 0;
            btnShop.Visible = false;
            btnBossFight.Visible = false;
            Coins.coins5 = false;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop(coins);
            shopForm.ShowDialog();
            if (CoinsReturn.ifCoinsSpent == true)
            {
                coins = CoinsReturn.coins;
                CoinsReturn.ifCoinsSpent = false;
            }

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (easterEgg == 2)
            {
                MessageBox.Show("Congratulations you have found the 'special' cookie! You have been awarded 200 coins!");
                coins += 200;
                easterEgg = 1;
            }
            else if (easterEgg == 1)
            {
                MessageBox.Show("You have already found this easter egg!");
            }
        }

        private void btnBossFight_Click(object sender, EventArgs e)
        {
            var boss = MessageBox.Show("Are you sure you want to start a Boss fight?", "Are you sure?", MessageBoxButtons.OKCancel);
            if (boss == DialogResult.OK)
            {
                BossFight bossFightForm = new BossFight();
                bossFightForm.ShowDialog();
                btnShop.Enabled = false;
                btnBossFight.Enabled = false;
            }
            if (BossFightShopOptions.IsGameFinished == true)
            {
                this.Close();
            }
        }
    }
}
