﻿namespace PoisonCup
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnTip = new System.Windows.Forms.Button();
            this.BtnPoison = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRulesList = new System.Windows.Forms.Label();
            this.lblRulesLabel = new System.Windows.Forms.Label();
            this.lblOutOfTips = new System.Windows.Forms.Label();
            this.btnCup6 = new System.Windows.Forms.Button();
            this.btnCup4 = new System.Windows.Forms.Button();
            this.btnCup5 = new System.Windows.Forms.Button();
            this.btnCup2 = new System.Windows.Forms.Button();
            this.btnCup3 = new System.Windows.Forms.Button();
            this.btnCup1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.Teal;
            this.btnDrink.Enabled = false;
            this.btnDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.Location = new System.Drawing.Point(277, 302);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(243, 41);
            this.btnDrink.TabIndex = 6;
            this.btnDrink.Text = "Drink";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.BtnDrink_Click);
            // 
            // btnTip
            // 
            this.btnTip.BackColor = System.Drawing.Color.Teal;
            this.btnTip.Enabled = false;
            this.btnTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTip.Location = new System.Drawing.Point(528, 302);
            this.btnTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(243, 41);
            this.btnTip.TabIndex = 7;
            this.btnTip.Text = "Tip";
            this.btnTip.UseVisualStyleBackColor = false;
            this.btnTip.Click += new System.EventHandler(this.BtnTip_Click);
            // 
            // BtnPoison
            // 
            this.BtnPoison.BackColor = System.Drawing.Color.Turquoise;
            this.BtnPoison.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPoison.Location = new System.Drawing.Point(464, 236);
            this.BtnPoison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPoison.Name = "BtnPoison";
            this.BtnPoison.Size = new System.Drawing.Size(117, 58);
            this.BtnPoison.TabIndex = 8;
            this.BtnPoison.Text = "Poison";
            this.BtnPoison.UseVisualStyleBackColor = false;
            this.BtnPoison.Click += new System.EventHandler(this.BtnPoison_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(251, -1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(575, 62);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Welcome to Poison Cup";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRulesList
            // 
            this.lblRulesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesList.Location = new System.Drawing.Point(16, 95);
            this.lblRulesList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRulesList.Name = "lblRulesList";
            this.lblRulesList.Size = new System.Drawing.Size(1035, 138);
            this.lblRulesList.TabIndex = 10;
            this.lblRulesList.Text = resources.GetString("lblRulesList.Text");
            // 
            // lblRulesLabel
            // 
            this.lblRulesLabel.AutoSize = true;
            this.lblRulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesLabel.Location = new System.Drawing.Point(13, 49);
            this.lblRulesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRulesLabel.Name = "lblRulesLabel";
            this.lblRulesLabel.Size = new System.Drawing.Size(176, 31);
            this.lblRulesLabel.TabIndex = 11;
            this.lblRulesLabel.Text = "How To Play:";
            // 
            // lblOutOfTips
            // 
            this.lblOutOfTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfTips.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfTips.Location = new System.Drawing.Point(528, 342);
            this.lblOutOfTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutOfTips.Name = "lblOutOfTips";
            this.lblOutOfTips.Size = new System.Drawing.Size(243, 28);
            this.lblOutOfTips.TabIndex = 12;
            // 
            // btnCup6
            // 
            this.btnCup6.BackColor = System.Drawing.Color.Transparent;
            this.btnCup6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCup6.Image = global::PoisonCup.Resource1.soloCupFull;
            this.btnCup6.Location = new System.Drawing.Point(779, 374);
            this.btnCup6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCup6.Name = "btnCup6";
            this.btnCup6.Size = new System.Drawing.Size(117, 130);
            this.btnCup6.TabIndex = 5;
            this.btnCup6.Text = "6";
            this.btnCup6.UseVisualStyleBackColor = false;
            this.btnCup6.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // btnCup4
            // 
            this.btnCup4.BackColor = System.Drawing.Color.Transparent;
            this.btnCup4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCup4.Image = global::PoisonCup.Resource1.soloCupFull;
            this.btnCup4.Location = new System.Drawing.Point(528, 374);
            this.btnCup4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCup4.Name = "btnCup4";
            this.btnCup4.Size = new System.Drawing.Size(117, 130);
            this.btnCup4.TabIndex = 4;
            this.btnCup4.Text = "4";
            this.btnCup4.UseVisualStyleBackColor = false;
            this.btnCup4.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // btnCup5
            // 
            this.btnCup5.BackColor = System.Drawing.Color.Transparent;
            this.btnCup5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCup5.Image = global::PoisonCup.Resource1.soloCupFull;
            this.btnCup5.Location = new System.Drawing.Point(653, 374);
            this.btnCup5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCup5.Name = "btnCup5";
            this.btnCup5.Size = new System.Drawing.Size(117, 130);
            this.btnCup5.TabIndex = 3;
            this.btnCup5.Text = "5";
            this.btnCup5.UseVisualStyleBackColor = false;
            this.btnCup5.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // btnCup2
            // 
            this.btnCup2.BackColor = System.Drawing.Color.Transparent;
            this.btnCup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCup2.Image = global::PoisonCup.Resource1.soloCupFull;
            this.btnCup2.Location = new System.Drawing.Point(277, 374);
            this.btnCup2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCup2.Name = "btnCup2";
            this.btnCup2.Size = new System.Drawing.Size(117, 130);
            this.btnCup2.TabIndex = 2;
            this.btnCup2.Text = "2";
            this.btnCup2.UseVisualStyleBackColor = false;
            this.btnCup2.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // btnCup3
            // 
            this.btnCup3.BackColor = System.Drawing.Color.Transparent;
            this.btnCup3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCup3.Image = global::PoisonCup.Resource1.soloCupFull;
            this.btnCup3.Location = new System.Drawing.Point(403, 374);
            this.btnCup3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCup3.Name = "btnCup3";
            this.btnCup3.Size = new System.Drawing.Size(117, 130);
            this.btnCup3.TabIndex = 1;
            this.btnCup3.Text = "3";
            this.btnCup3.UseVisualStyleBackColor = false;
            this.btnCup3.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // btnCup1
            // 
            this.btnCup1.BackColor = System.Drawing.Color.White;
            this.btnCup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCup1.Image = global::PoisonCup.Resource1.soloCupFull;
            this.btnCup1.Location = new System.Drawing.Point(152, 374);
            this.btnCup1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCup1.Name = "btnCup1";
            this.btnCup1.Size = new System.Drawing.Size(117, 130);
            this.btnCup1.TabIndex = 0;
            this.btnCup1.Text = "1";
            this.btnCup1.UseVisualStyleBackColor = false;
            this.btnCup1.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblOutOfTips);
            this.Controls.Add(this.lblRulesLabel);
            this.Controls.Add(this.lblRulesList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnPoison);
            this.Controls.Add(this.btnTip);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnCup6);
            this.Controls.Add(this.btnCup4);
            this.Controls.Add(this.btnCup5);
            this.Controls.Add(this.btnCup2);
            this.Controls.Add(this.btnCup3);
            this.Controls.Add(this.btnCup1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "Game Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCup1;
        private System.Windows.Forms.Button btnCup3;
        private System.Windows.Forms.Button btnCup2;
        private System.Windows.Forms.Button btnCup5;
        private System.Windows.Forms.Button btnCup4;
        private System.Windows.Forms.Button btnCup6;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnTip;
        private System.Windows.Forms.Button BtnPoison;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRulesList;
        private System.Windows.Forms.Label lblRulesLabel;
        private System.Windows.Forms.Label lblOutOfTips;
    }
}

