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
        public Shop(int coins)
        {
            coins1 = coins;
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            lblCoins.Text = coins1.ToString();
        }

        private void btnCoinsPerClick_Click(object sender, EventArgs e)
        {
            var mbox = MessageBox.Show("Are you sure you want to buy this?", "Clicker shop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mbox == DialogResult.Yes)
            {
                MessageBox.Show("Test");
            }
        }
    }

}
