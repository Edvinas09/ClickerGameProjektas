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
    public partial class BossFight : Form
    {
        Thread th;
        public BossFight()
        {
            InitializeComponent();
        }

        private void BossFight_Load(object sender, EventArgs e)
        {
            progressBossHp.Maximum = 700;
            progressBossHp.Value = progressBossHp.Maximum;

            progressYourHp.Maximum = 500;
            progressYourHp.Value = progressYourHp.Maximum;

            th = new Thread(GenerateNumbers);
            th.Start();
        }

        private void btnDoDamage_Click(object sender, EventArgs e)
        {
            if (BossFightShopOptions.Is5DamageBought == true)
            {
                progressBossHp.Value -= 5;
            }
            else if (BossFightShopOptions.Is15DamageBought == true)
            {
                progressBossHp.Value -= 15;
            }
            else
            {
                progressBossHp.Value -= 2;
            }
            if (progressBossHp.Value == 0)
            {
                btnDoDamage.Enabled = false;
            }
        }

        void GenerateNumbers()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(5000);
                int randomNum = rnd.Next(21);
                int randomNum2 = rnd2.Next(21);

                if (randomNum == randomNum2)
                {
                    progressYourHp.Invoke(new MethodInvoker(DoDamage));
                }
            }
        }

        void DoDamage()
        {
            if (progressYourHp.Value == 0)
            {
                th.Abort();
                var mbox = MessageBox.Show("You have lost! Better luck next time!", "You have lost", MessageBoxButtons.OK);
                if (mbox == DialogResult.OK)
                {
                    BossFightShopOptions.IsGameFinished = true;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else if (progressBossHp.Value == 0)
            {
                var mbox = MessageBox.Show("Congratulations! You have won the game! Thanks for playing!", "You have won!", MessageBoxButtons.OK);
                th.Abort();
                if (mbox == DialogResult.OK)
                {
                    BossFightShopOptions.IsGameFinished = true;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                progressYourHp.Value -= 30;

            }
        }

    }
}
