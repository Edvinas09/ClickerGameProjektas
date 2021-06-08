
namespace ClickerGameProjektas
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCoinsPerClick = new System.Windows.Forms.Button();
            this.btnExitShop = new System.Windows.Forms.Button();
            this.btnCoinsPerClick15 = new System.Windows.Forms.Button();
            this.btnCoinsPerClick30 = new System.Windows.Forms.Button();
            this.btnCoinsPerClick55 = new System.Windows.Forms.Button();
            this.btnBuyDamage = new System.Windows.Forms.Button();
            this.btnBuyDamage15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coins:";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(149, 13);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(35, 20);
            this.lblCoins.TabIndex = 1;
            this.lblCoins.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCoinsPerClick
            // 
            this.btnCoinsPerClick.Location = new System.Drawing.Point(10, 45);
            this.btnCoinsPerClick.Name = "btnCoinsPerClick";
            this.btnCoinsPerClick.Size = new System.Drawing.Size(114, 36);
            this.btnCoinsPerClick.TabIndex = 4;
            this.btnCoinsPerClick.Text = "+5 Coins per Click! Cost: 150";
            this.btnCoinsPerClick.UseVisualStyleBackColor = true;
            this.btnCoinsPerClick.Click += new System.EventHandler(this.btnCoinsPerClick_Click);
            // 
            // btnExitShop
            // 
            this.btnExitShop.Location = new System.Drawing.Point(188, 233);
            this.btnExitShop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitShop.Name = "btnExitShop";
            this.btnExitShop.Size = new System.Drawing.Size(97, 32);
            this.btnExitShop.TabIndex = 5;
            this.btnExitShop.Text = "Exit the Shop";
            this.btnExitShop.UseVisualStyleBackColor = true;
            this.btnExitShop.Click += new System.EventHandler(this.btnExitShop_Click);
            // 
            // btnCoinsPerClick15
            // 
            this.btnCoinsPerClick15.Location = new System.Drawing.Point(170, 45);
            this.btnCoinsPerClick15.Name = "btnCoinsPerClick15";
            this.btnCoinsPerClick15.Size = new System.Drawing.Size(114, 36);
            this.btnCoinsPerClick15.TabIndex = 6;
            this.btnCoinsPerClick15.Text = "+15 Coins per Click! Cost: 550 ";
            this.btnCoinsPerClick15.UseVisualStyleBackColor = true;
            this.btnCoinsPerClick15.Click += new System.EventHandler(this.btnCoinsPerClick15_Click);
            // 
            // btnCoinsPerClick30
            // 
            this.btnCoinsPerClick30.Location = new System.Drawing.Point(10, 114);
            this.btnCoinsPerClick30.Name = "btnCoinsPerClick30";
            this.btnCoinsPerClick30.Size = new System.Drawing.Size(114, 36);
            this.btnCoinsPerClick30.TabIndex = 7;
            this.btnCoinsPerClick30.Text = "+30 Coins per Click! Cost: 1250 ";
            this.btnCoinsPerClick30.UseVisualStyleBackColor = true;
            this.btnCoinsPerClick30.Click += new System.EventHandler(this.btnCoinsPerClick30_Click);
            // 
            // btnCoinsPerClick55
            // 
            this.btnCoinsPerClick55.Location = new System.Drawing.Point(170, 114);
            this.btnCoinsPerClick55.Name = "btnCoinsPerClick55";
            this.btnCoinsPerClick55.Size = new System.Drawing.Size(114, 36);
            this.btnCoinsPerClick55.TabIndex = 8;
            this.btnCoinsPerClick55.Text = "+55 Coins per Click! Cost: 1750 ";
            this.btnCoinsPerClick55.UseVisualStyleBackColor = true;
            this.btnCoinsPerClick55.Click += new System.EventHandler(this.btnCoinsPerClick55_Click);
            // 
            // btnBuyDamage
            // 
            this.btnBuyDamage.Location = new System.Drawing.Point(10, 173);
            this.btnBuyDamage.Name = "btnBuyDamage";
            this.btnBuyDamage.Size = new System.Drawing.Size(114, 36);
            this.btnBuyDamage.TabIndex = 9;
            this.btnBuyDamage.Text = "+5 Damage to the boss! Cost: 5000";
            this.btnBuyDamage.UseVisualStyleBackColor = true;
            this.btnBuyDamage.Click += new System.EventHandler(this.btnBuyDamage_Click);
            // 
            // btnBuyDamage15
            // 
            this.btnBuyDamage15.Location = new System.Drawing.Point(170, 173);
            this.btnBuyDamage15.Name = "btnBuyDamage15";
            this.btnBuyDamage15.Size = new System.Drawing.Size(114, 36);
            this.btnBuyDamage15.TabIndex = 10;
            this.btnBuyDamage15.Text = "+15 Damage to the boss! Cost: 9000";
            this.btnBuyDamage15.UseVisualStyleBackColor = true;
            this.btnBuyDamage15.Click += new System.EventHandler(this.btnBuyDamage15_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(294, 275);
            this.Controls.Add(this.btnBuyDamage15);
            this.Controls.Add(this.btnBuyDamage);
            this.Controls.Add(this.btnCoinsPerClick55);
            this.Controls.Add(this.btnCoinsPerClick30);
            this.Controls.Add(this.btnCoinsPerClick15);
            this.Controls.Add(this.btnExitShop);
            this.Controls.Add(this.btnCoinsPerClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shop";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Shop";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCoinsPerClick;
        private System.Windows.Forms.Button btnExitShop;
        private System.Windows.Forms.Button btnCoinsPerClick15;
        private System.Windows.Forms.Button btnCoinsPerClick30;
        private System.Windows.Forms.Button btnCoinsPerClick55;
        private System.Windows.Forms.Button btnBuyDamage;
        private System.Windows.Forms.Button btnBuyDamage15;
    }
}