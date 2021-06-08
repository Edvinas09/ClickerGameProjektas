using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGameProjektas
{
    public partial class Shop : Form
    {
        int coins1;
        int cost;
        public Shop(int coins)
        {
            coins1 = coins;
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            lblCoins.Text = coins1.ToString();

            btnBuyDamage.Visible = false;
            btnBuyDamage15.Visible = false;

            if (BossFightShopOptions.CanYouBuy == true)
            {
                btnBuyDamage.Visible = true;
                btnBuyDamage15.Visible = true;
            }


            //Check if buttons should be enabled
            if (Coins.coins5 == true)
            {
                btnCoinsPerClick.Enabled = false;
            }
            if (Coins.coins15 == true)
            {
                btnCoinsPerClick15.Enabled = false;
            }
            if (Coins.coins30 == true)
            {
                btnCoinsPerClick30.Enabled = false;
            }
            if (Coins.coins55 == true)
            {
                btnCoinsPerClick55.Enabled = false;
            }

        }

        private void btnCoinsPerClick_Click(object sender, EventArgs e)
        {
            cost = 150;
            var mbox = MessageBox.Show("Are you sure you want to buy this?", "Clicker shop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mbox == DialogResult.Yes)
            {
                if (coins1 < cost)
                {
                    MessageBox.Show("You don't have enough coins!");
                }
                else
                {
                    coins1 -= cost;
                    lblCoins.Text = coins1.ToString();
                    btnCoinsPerClick.Enabled = false;
                    CoinsReturn.coins = coins1;
                    CoinsReturn.ifCoinsSpent = true;
                    Coins.coins5 = true;
                }
            }
        }

        private void btnExitShop_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCoinsPerClick15_Click(object sender, EventArgs e)
        {
            cost = 550;
            if (Coins.coins5 != true)
            {
                MessageBox.Show("You can't buy that yet!");
            }
            else
            {
                var mbox = MessageBox.Show("Are you sure you want to buy this?", "Clicker shop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbox == DialogResult.Yes)
                {
                    if (coins1 < cost)
                    {
                        MessageBox.Show("You don't have enough coins!");
                    }
                    else
                    {
                        coins1 -= cost;
                        lblCoins.Text = coins1.ToString();
                        btnCoinsPerClick15.Enabled = false;
                        CoinsReturn.coins = coins1;
                        CoinsReturn.ifCoinsSpent = true;
                        Coins.coins15 = true;
                    }
                }
            }
        }

        private void btnCoinsPerClick30_Click(object sender, EventArgs e)
        {
            cost = 1250;
            if (Coins.coins15 != true)
            {
                MessageBox.Show("You can't buy that yet!");
            }
            else
            {
                var mbox = MessageBox.Show("Are you sure you want to buy this?", "Clicker shop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbox == DialogResult.Yes)
                {
                    if (coins1 < cost)
                    {
                        MessageBox.Show("You don't have enough coins!");
                    }
                    else
                    {
                        coins1 -= cost;
                        lblCoins.Text = coins1.ToString();
                        btnCoinsPerClick30.Enabled = false;
                        CoinsReturn.coins = coins1;
                        CoinsReturn.ifCoinsSpent = true;
                        Coins.coins30 = true;
                    }
                }
            }
        }

        private void btnCoinsPerClick55_Click(object sender, EventArgs e)
        {
            cost = 1750;
            if (Coins.coins30 != true)
            {
                MessageBox.Show("You can't buy that yet!");
            }
            else
            {
                var mbox = MessageBox.Show("Are you sure you want to buy this?", "Clicker shop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbox == DialogResult.Yes)
                {
                    if (coins1 < cost)
                    {
                        MessageBox.Show("You don't have enough coins!");
                    }
                    else
                    {
                        coins1 -= cost;
                        lblCoins.Text = coins1.ToString();
                        btnCoinsPerClick55.Enabled = false;
                        CoinsReturn.coins = coins1;
                        CoinsReturn.ifCoinsSpent = true;
                        Coins.coins55 = true;
                    }
                }
            }
        }

        private void btnBuyDamage_Click(object sender, EventArgs e)
        {
            cost = 5000;

            var mbox = MessageBox.Show("Are you sure you want to buy this?", "Clicker shop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mbox == DialogResult.Yes)
            {
                if (coins1 < cost)
                {
                    MessageBox.Show("You don't have enough coins!");
                }
                else
                {
                    coins1 -= cost;
                    lblCoins.Text = coins1.ToString();
                    btnBuyDamage.Enabled = false;
                    CoinsReturn.coins = coins1;
                    CoinsReturn.ifCoinsSpent = true;
                    BossFightShopOptions.Is5DamageBought = true;
                }
            }
        }

        private void btnBuyDamage15_Click(object sender, EventArgs e)
        {
            cost = 9000;

            var mbox = MessageBox.Show("Are you sure you want to buy this?", "Clicker shop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mbox == DialogResult.Yes)
            {
                if (coins1 < cost)
                {
                    MessageBox.Show("You don't have enough coins!");
                }
                else
                {
                    coins1 -= cost;
                    lblCoins.Text = coins1.ToString();
                    btnBuyDamage15.Enabled = false;
                    CoinsReturn.coins = coins1;
                    CoinsReturn.ifCoinsSpent = true;
                    BossFightShopOptions.Is15DamageBought = true;
                }
            }
        }
    }
}

