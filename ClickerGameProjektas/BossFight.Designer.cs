
namespace ClickerGameProjektas
{
    partial class BossFight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BossFight));
            this.progressBossHp = new System.Windows.Forms.ProgressBar();
            this.progressYourHp = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoDamage = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBossHp
            // 
            this.progressBossHp.Location = new System.Drawing.Point(12, 38);
            this.progressBossHp.Name = "progressBossHp";
            this.progressBossHp.Size = new System.Drawing.Size(388, 21);
            this.progressBossHp.TabIndex = 0;
            // 
            // progressYourHp
            // 
            this.progressYourHp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressYourHp.Location = new System.Drawing.Point(449, 38);
            this.progressYourHp.Name = "progressYourHp";
            this.progressYourHp.Size = new System.Drawing.Size(388, 21);
            this.progressYourHp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boss Hp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Hp:";
            // 
            // btnDoDamage
            // 
            this.btnDoDamage.Location = new System.Drawing.Point(596, 79);
            this.btnDoDamage.Name = "btnDoDamage";
            this.btnDoDamage.Size = new System.Drawing.Size(131, 39);
            this.btnDoDamage.TabIndex = 4;
            this.btnDoDamage.Text = "Do damage";
            this.btnDoDamage.UseVisualStyleBackColor = true;
            this.btnDoDamage.Click += new System.EventHandler(this.btnDoDamage_Click);
            // 
            // backgroundWorker1
            //             // 
            // BossFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 130);
            this.Controls.Add(this.btnDoDamage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressYourHp);
            this.Controls.Add(this.progressBossHp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BossFight";
            this.Text = "BossFight";
            this.Load += new System.EventHandler(this.BossFight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBossHp;
        private System.Windows.Forms.ProgressBar progressYourHp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoDamage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}