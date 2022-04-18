
namespace BattleSim_v3._0
{
    partial class FRM_Battle
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
            this.PB_Player1_NeoFighter = new System.Windows.Forms.PictureBox();
            this.PB_Player2_NeoFighter = new System.Windows.Forms.PictureBox();
            this.BTN_Player1_Attack = new System.Windows.Forms.Button();
            this.BTN_Player2_Attack = new System.Windows.Forms.Button();
            this.LBL_Player1_Health = new System.Windows.Forms.Label();
            this.LBL_Player2_Health = new System.Windows.Forms.Label();
            this.RB_P2_Attack1 = new System.Windows.Forms.RadioButton();
            this.GB_P2 = new System.Windows.Forms.GroupBox();
            this.RB_P2_Attack3 = new System.Windows.Forms.RadioButton();
            this.RB_P2_Attack2 = new System.Windows.Forms.RadioButton();
            this.GB_P1 = new System.Windows.Forms.GroupBox();
            this.RB_P1_Attack3 = new System.Windows.Forms.RadioButton();
            this.RB_P1_Attack2 = new System.Windows.Forms.RadioButton();
            this.RB_P1_Attack1 = new System.Windows.Forms.RadioButton();
            this.LBL_Damage = new System.Windows.Forms.Label();
            this.LBL_CriticalHit = new System.Windows.Forms.Label();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player1_NeoFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player2_NeoFighter)).BeginInit();
            this.GB_P2.SuspendLayout();
            this.GB_P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Player1_NeoFighter
            // 
            this.PB_Player1_NeoFighter.Location = new System.Drawing.Point(12, 12);
            this.PB_Player1_NeoFighter.Name = "PB_Player1_NeoFighter";
            this.PB_Player1_NeoFighter.Size = new System.Drawing.Size(300, 300);
            this.PB_Player1_NeoFighter.TabIndex = 0;
            this.PB_Player1_NeoFighter.TabStop = false;
            // 
            // PB_Player2_NeoFighter
            // 
            this.PB_Player2_NeoFighter.Location = new System.Drawing.Point(488, 12);
            this.PB_Player2_NeoFighter.Name = "PB_Player2_NeoFighter";
            this.PB_Player2_NeoFighter.Size = new System.Drawing.Size(300, 300);
            this.PB_Player2_NeoFighter.TabIndex = 1;
            this.PB_Player2_NeoFighter.TabStop = false;
            // 
            // BTN_Player1_Attack
            // 
            this.BTN_Player1_Attack.Location = new System.Drawing.Point(12, 318);
            this.BTN_Player1_Attack.Name = "BTN_Player1_Attack";
            this.BTN_Player1_Attack.Size = new System.Drawing.Size(300, 38);
            this.BTN_Player1_Attack.TabIndex = 2;
            this.BTN_Player1_Attack.Text = "Attack";
            this.BTN_Player1_Attack.UseVisualStyleBackColor = true;
            this.BTN_Player1_Attack.Click += new System.EventHandler(this.BTN_Player1_Attack_Click);
            // 
            // BTN_Player2_Attack
            // 
            this.BTN_Player2_Attack.Enabled = false;
            this.BTN_Player2_Attack.Location = new System.Drawing.Point(488, 318);
            this.BTN_Player2_Attack.Name = "BTN_Player2_Attack";
            this.BTN_Player2_Attack.Size = new System.Drawing.Size(300, 38);
            this.BTN_Player2_Attack.TabIndex = 3;
            this.BTN_Player2_Attack.Text = "Attack";
            this.BTN_Player2_Attack.UseVisualStyleBackColor = true;
            this.BTN_Player2_Attack.Click += new System.EventHandler(this.BTN_Player2_Attack_Click);
            // 
            // LBL_Player1_Health
            // 
            this.LBL_Player1_Health.Location = new System.Drawing.Point(12, 359);
            this.LBL_Player1_Health.Name = "LBL_Player1_Health";
            this.LBL_Player1_Health.Size = new System.Drawing.Size(50, 16);
            this.LBL_Player1_Health.TabIndex = 4;
            this.LBL_Player1_Health.Text = "health";
            // 
            // LBL_Player2_Health
            // 
            this.LBL_Player2_Health.Location = new System.Drawing.Point(485, 359);
            this.LBL_Player2_Health.Name = "LBL_Player2_Health";
            this.LBL_Player2_Health.Size = new System.Drawing.Size(50, 16);
            this.LBL_Player2_Health.TabIndex = 5;
            this.LBL_Player2_Health.Text = "health";
            // 
            // RB_P2_Attack1
            // 
            this.RB_P2_Attack1.AutoSize = true;
            this.RB_P2_Attack1.Checked = true;
            this.RB_P2_Attack1.Location = new System.Drawing.Point(7, 21);
            this.RB_P2_Attack1.Name = "RB_P2_Attack1";
            this.RB_P2_Attack1.Size = new System.Drawing.Size(121, 20);
            this.RB_P2_Attack1.TabIndex = 6;
            this.RB_P2_Attack1.TabStop = true;
            this.RB_P2_Attack1.Text = "Player2 Attack1";
            this.RB_P2_Attack1.UseVisualStyleBackColor = true;
            // 
            // GB_P2
            // 
            this.GB_P2.Controls.Add(this.RB_P2_Attack3);
            this.GB_P2.Controls.Add(this.RB_P2_Attack2);
            this.GB_P2.Controls.Add(this.RB_P2_Attack1);
            this.GB_P2.Location = new System.Drawing.Point(488, 408);
            this.GB_P2.Name = "GB_P2";
            this.GB_P2.Size = new System.Drawing.Size(300, 100);
            this.GB_P2.TabIndex = 7;
            this.GB_P2.TabStop = false;
            this.GB_P2.Text = "Player2 Ability";
            // 
            // RB_P2_Attack3
            // 
            this.RB_P2_Attack3.AutoSize = true;
            this.RB_P2_Attack3.Location = new System.Drawing.Point(7, 73);
            this.RB_P2_Attack3.Name = "RB_P2_Attack3";
            this.RB_P2_Attack3.Size = new System.Drawing.Size(121, 20);
            this.RB_P2_Attack3.TabIndex = 8;
            this.RB_P2_Attack3.Text = "Player2 Attack3";
            this.RB_P2_Attack3.UseVisualStyleBackColor = true;
            // 
            // RB_P2_Attack2
            // 
            this.RB_P2_Attack2.AutoSize = true;
            this.RB_P2_Attack2.Location = new System.Drawing.Point(7, 47);
            this.RB_P2_Attack2.Name = "RB_P2_Attack2";
            this.RB_P2_Attack2.Size = new System.Drawing.Size(121, 20);
            this.RB_P2_Attack2.TabIndex = 7;
            this.RB_P2_Attack2.Text = "Player2 Attack2";
            this.RB_P2_Attack2.UseVisualStyleBackColor = true;
            // 
            // GB_P1
            // 
            this.GB_P1.Controls.Add(this.RB_P1_Attack3);
            this.GB_P1.Controls.Add(this.RB_P1_Attack2);
            this.GB_P1.Controls.Add(this.RB_P1_Attack1);
            this.GB_P1.Location = new System.Drawing.Point(12, 408);
            this.GB_P1.Name = "GB_P1";
            this.GB_P1.Size = new System.Drawing.Size(300, 100);
            this.GB_P1.TabIndex = 9;
            this.GB_P1.TabStop = false;
            this.GB_P1.Text = "Player1 Ability";
            // 
            // RB_P1_Attack3
            // 
            this.RB_P1_Attack3.AutoSize = true;
            this.RB_P1_Attack3.Location = new System.Drawing.Point(7, 73);
            this.RB_P1_Attack3.Name = "RB_P1_Attack3";
            this.RB_P1_Attack3.Size = new System.Drawing.Size(121, 20);
            this.RB_P1_Attack3.TabIndex = 8;
            this.RB_P1_Attack3.Text = "Player1 Attack3";
            this.RB_P1_Attack3.UseVisualStyleBackColor = true;
            // 
            // RB_P1_Attack2
            // 
            this.RB_P1_Attack2.AutoSize = true;
            this.RB_P1_Attack2.Location = new System.Drawing.Point(7, 47);
            this.RB_P1_Attack2.Name = "RB_P1_Attack2";
            this.RB_P1_Attack2.Size = new System.Drawing.Size(121, 20);
            this.RB_P1_Attack2.TabIndex = 7;
            this.RB_P1_Attack2.Text = "Player1 Attack2";
            this.RB_P1_Attack2.UseVisualStyleBackColor = true;
            // 
            // RB_P1_Attack1
            // 
            this.RB_P1_Attack1.AutoSize = true;
            this.RB_P1_Attack1.Checked = true;
            this.RB_P1_Attack1.Location = new System.Drawing.Point(7, 21);
            this.RB_P1_Attack1.Name = "RB_P1_Attack1";
            this.RB_P1_Attack1.Size = new System.Drawing.Size(121, 20);
            this.RB_P1_Attack1.TabIndex = 6;
            this.RB_P1_Attack1.TabStop = true;
            this.RB_P1_Attack1.Text = "Player1 Attack1";
            this.RB_P1_Attack1.UseVisualStyleBackColor = true;
            // 
            // LBL_Damage
            // 
            this.LBL_Damage.Location = new System.Drawing.Point(318, 12);
            this.LBL_Damage.Name = "LBL_Damage";
            this.LBL_Damage.Size = new System.Drawing.Size(164, 61);
            this.LBL_Damage.TabIndex = 10;
            this.LBL_Damage.Text = "LBL_Damage";
            this.LBL_Damage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_CriticalHit
            // 
            this.LBL_CriticalHit.AutoSize = true;
            this.LBL_CriticalHit.Location = new System.Drawing.Point(367, 73);
            this.LBL_CriticalHit.Name = "LBL_CriticalHit";
            this.LBL_CriticalHit.Size = new System.Drawing.Size(69, 16);
            this.LBL_CriticalHit.TabIndex = 11;
            this.LBL_CriticalHit.Text = "Critical Hit!";
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Location = new System.Drawing.Point(485, 375);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(90, 16);
            this.LBL_Status.TabIndex = 12;
            this.LBL_Status.Text = "LBL_StatusP2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "LBL_StatusP1";
            // 
            // FRM_Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.LBL_CriticalHit);
            this.Controls.Add(this.LBL_Damage);
            this.Controls.Add(this.GB_P1);
            this.Controls.Add(this.GB_P2);
            this.Controls.Add(this.LBL_Player2_Health);
            this.Controls.Add(this.LBL_Player1_Health);
            this.Controls.Add(this.BTN_Player2_Attack);
            this.Controls.Add(this.BTN_Player1_Attack);
            this.Controls.Add(this.PB_Player2_NeoFighter);
            this.Controls.Add(this.PB_Player1_NeoFighter);
            this.Name = "FRM_Battle";
            this.Text = "FRM_Battle";
            this.Load += new System.EventHandler(this.FRM_Battle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player1_NeoFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player2_NeoFighter)).EndInit();
            this.GB_P2.ResumeLayout(false);
            this.GB_P2.PerformLayout();
            this.GB_P1.ResumeLayout(false);
            this.GB_P1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Player1_NeoFighter;
        private System.Windows.Forms.PictureBox PB_Player2_NeoFighter;
        private System.Windows.Forms.Button BTN_Player1_Attack;
        private System.Windows.Forms.Button BTN_Player2_Attack;
        private System.Windows.Forms.Label LBL_Player1_Health;
        private System.Windows.Forms.Label LBL_Player2_Health;
        private System.Windows.Forms.RadioButton RB_P2_Attack1;
        private System.Windows.Forms.GroupBox GB_P2;
        private System.Windows.Forms.RadioButton RB_P2_Attack2;
        private System.Windows.Forms.RadioButton RB_P2_Attack3;
        private System.Windows.Forms.GroupBox GB_P1;
        private System.Windows.Forms.RadioButton RB_P1_Attack3;
        private System.Windows.Forms.RadioButton RB_P1_Attack2;
        private System.Windows.Forms.RadioButton RB_P1_Attack1;
        private System.Windows.Forms.Label LBL_Damage;
        private System.Windows.Forms.Label LBL_CriticalHit;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.Label label1;
    }
}