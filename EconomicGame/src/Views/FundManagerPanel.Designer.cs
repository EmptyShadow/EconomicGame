namespace EconomicGame.src.Views
{
    partial class FundManagerPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.labelCountMaxMonth = new System.Windows.Forms.Label();
            this.labelCurSeason = new System.Windows.Forms.Label();
            this.labelCountCurMonth = new System.Windows.Forms.Label();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelBankAccountBalance = new System.Windows.Forms.Label();
            this.buttonShowFormAdvertisingAgency = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer.Panel2.Controls.Add(this.groupBoxPlayer);
            this.splitContainer.Size = new System.Drawing.Size(651, 511);
            this.splitContainer.SplitterDistance = 458;
            this.splitContainer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.buttonNextMonth);
            this.groupBox2.Controls.Add(this.labelCountMaxMonth);
            this.groupBox2.Controls.Add(this.labelCurSeason);
            this.groupBox2.Controls.Add(this.labelCountCurMonth);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.AutoSize = true;
            this.buttonNextMonth.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNextMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNextMonth.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextMonth.ForeColor = System.Drawing.Color.Gold;
            this.buttonNextMonth.Location = new System.Drawing.Point(3, 92);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(183, 33);
            this.buttonNextMonth.TabIndex = 4;
            this.buttonNextMonth.Text = "Закончить ход";
            this.buttonNextMonth.UseVisualStyleBackColor = false;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click);
            // 
            // labelCountMaxMonth
            // 
            this.labelCountMaxMonth.AutoSize = true;
            this.labelCountMaxMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCountMaxMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountMaxMonth.Location = new System.Drawing.Point(3, 70);
            this.labelCountMaxMonth.Name = "labelCountMaxMonth";
            this.labelCountMaxMonth.Size = new System.Drawing.Size(60, 22);
            this.labelCountMaxMonth.TabIndex = 3;
            this.labelCountMaxMonth.Text = "label3";
            // 
            // labelCurSeason
            // 
            this.labelCurSeason.AutoSize = true;
            this.labelCurSeason.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCurSeason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurSeason.Location = new System.Drawing.Point(3, 48);
            this.labelCurSeason.Name = "labelCurSeason";
            this.labelCurSeason.Size = new System.Drawing.Size(60, 22);
            this.labelCurSeason.TabIndex = 2;
            this.labelCurSeason.Text = "label2";
            // 
            // labelCountCurMonth
            // 
            this.labelCountCurMonth.AutoSize = true;
            this.labelCountCurMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCountCurMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountCurMonth.Location = new System.Drawing.Point(3, 26);
            this.labelCountCurMonth.Name = "labelCountCurMonth";
            this.labelCountCurMonth.Size = new System.Drawing.Size(60, 22);
            this.labelCountCurMonth.TabIndex = 1;
            this.labelCountCurMonth.Text = "label1";
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.AutoSize = true;
            this.groupBoxPlayer.Controls.Add(this.buttonShowFormAdvertisingAgency);
            this.groupBoxPlayer.Controls.Add(this.labelCapital);
            this.groupBoxPlayer.Controls.Add(this.labelBankAccountBalance);
            this.groupBoxPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPlayer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPlayer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(189, 106);
            this.groupBoxPlayer.TabIndex = 0;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "groupBox1";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCapital.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCapital.Location = new System.Drawing.Point(3, 48);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(108, 22);
            this.labelCapital.TabIndex = 5;
            this.labelCapital.Text = "labelCapital";
            // 
            // labelBankAccountBalance
            // 
            this.labelBankAccountBalance.AutoSize = true;
            this.labelBankAccountBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBankAccountBalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBankAccountBalance.Location = new System.Drawing.Point(3, 26);
            this.labelBankAccountBalance.Name = "labelBankAccountBalance";
            this.labelBankAccountBalance.Size = new System.Drawing.Size(60, 22);
            this.labelBankAccountBalance.TabIndex = 0;
            this.labelBankAccountBalance.Text = "label1";
            // 
            // buttonShowFormAdvertisingAgency
            // 
            this.buttonShowFormAdvertisingAgency.AutoSize = true;
            this.buttonShowFormAdvertisingAgency.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonShowFormAdvertisingAgency.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowFormAdvertisingAgency.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowFormAdvertisingAgency.ForeColor = System.Drawing.Color.Gold;
            this.buttonShowFormAdvertisingAgency.Location = new System.Drawing.Point(3, 70);
            this.buttonShowFormAdvertisingAgency.Name = "buttonShowFormAdvertisingAgency";
            this.buttonShowFormAdvertisingAgency.Size = new System.Drawing.Size(183, 33);
            this.buttonShowFormAdvertisingAgency.TabIndex = 6;
            this.buttonShowFormAdvertisingAgency.Text = "Реклама";
            this.buttonShowFormAdvertisingAgency.UseVisualStyleBackColor = false;
            this.buttonShowFormAdvertisingAgency.Click += new System.EventHandler(this.buttonShowFormAdvertisingAgency_Click);
            // 
            // FundManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer);
            this.Name = "FundManagerPanel";
            this.Size = new System.Drawing.Size(651, 511);
            this.VisibleChanged += new System.EventHandler(this.FundManagerPanel_VisibleChanged);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Label labelCountMaxMonth;
        private System.Windows.Forms.Label labelCurSeason;
        private System.Windows.Forms.Label labelCountCurMonth;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Label labelBankAccountBalance;
        private System.Windows.Forms.Button buttonShowFormAdvertisingAgency;
    }
}
