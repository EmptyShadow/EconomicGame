namespace EconomicGame.src.Views
{
    partial class FormAdvertisingAgency
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCostAdvertisingAgencyMarket = new System.Windows.Forms.Label();
            this.labelCostAdvertisingAgencyCondo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxAdvertisingСosts = new System.Windows.Forms.TextBox();
            this.buttonAdvertisingCondo = new System.Windows.Forms.Button();
            this.comboBoxListMarkets = new System.Windows.Forms.ComboBox();
            this.buttonAdvertisingMarket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelCostAdvertisingAgencyMarket);
            this.flowLayoutPanel1.Controls.Add(this.labelCostAdvertisingAgencyCondo);
            this.flowLayoutPanel1.Controls.Add(this.label);
            this.flowLayoutPanel1.Controls.Add(this.textBoxAdvertisingСosts);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdvertisingCondo);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxListMarkets);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdvertisingMarket);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 269);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelCostAdvertisingAgencyMarket
            // 
            this.labelCostAdvertisingAgencyMarket.AutoSize = true;
            this.labelCostAdvertisingAgencyMarket.Location = new System.Drawing.Point(5, 0);
            this.labelCostAdvertisingAgencyMarket.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCostAdvertisingAgencyMarket.Name = "labelCostAdvertisingAgencyMarket";
            this.labelCostAdvertisingAgencyMarket.Size = new System.Drawing.Size(318, 25);
            this.labelCostAdvertisingAgencyMarket.TabIndex = 0;
            this.labelCostAdvertisingAgencyMarket.Text = "Стоимость рекламы магазина";
            // 
            // labelCostAdvertisingAgencyCondo
            // 
            this.labelCostAdvertisingAgencyCondo.AutoSize = true;
            this.labelCostAdvertisingAgencyCondo.Location = new System.Drawing.Point(5, 25);
            this.labelCostAdvertisingAgencyCondo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCostAdvertisingAgencyCondo.Name = "labelCostAdvertisingAgencyCondo";
            this.labelCostAdvertisingAgencyCondo.Size = new System.Drawing.Size(287, 25);
            this.labelCostAdvertisingAgencyCondo.TabIndex = 1;
            this.labelCostAdvertisingAgencyCondo.Text = "Стоимость рекламы жилья";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(5, 50);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(204, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Трата на рекламу:";
            // 
            // textBoxAdvertisingСosts
            // 
            this.textBoxAdvertisingСosts.Location = new System.Drawing.Point(5, 80);
            this.textBoxAdvertisingСosts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxAdvertisingСosts.Name = "textBoxAdvertisingСosts";
            this.textBoxAdvertisingСosts.Size = new System.Drawing.Size(190, 32);
            this.textBoxAdvertisingСosts.TabIndex = 3;
            this.textBoxAdvertisingСosts.TextChanged += new System.EventHandler(this.textBoxAdvertisingСosts_TextChanged);
            // 
            // buttonAdvertisingCondo
            // 
            this.buttonAdvertisingCondo.AutoSize = true;
            this.buttonAdvertisingCondo.Location = new System.Drawing.Point(3, 120);
            this.buttonAdvertisingCondo.Name = "buttonAdvertisingCondo";
            this.buttonAdvertisingCondo.Size = new System.Drawing.Size(179, 35);
            this.buttonAdvertisingCondo.TabIndex = 4;
            this.buttonAdvertisingCondo.Text = "Реклама жилья";
            this.buttonAdvertisingCondo.UseVisualStyleBackColor = true;
            this.buttonAdvertisingCondo.Click += new System.EventHandler(this.buttonAdvertisingCondo_Click);
            // 
            // comboBoxListMarkets
            // 
            this.comboBoxListMarkets.FormattingEnabled = true;
            this.comboBoxListMarkets.Location = new System.Drawing.Point(3, 186);
            this.comboBoxListMarkets.Name = "comboBoxListMarkets";
            this.comboBoxListMarkets.Size = new System.Drawing.Size(320, 33);
            this.comboBoxListMarkets.TabIndex = 5;
            // 
            // buttonAdvertisingMarket
            // 
            this.buttonAdvertisingMarket.AutoSize = true;
            this.buttonAdvertisingMarket.Location = new System.Drawing.Point(3, 217);
            this.buttonAdvertisingMarket.Name = "buttonAdvertisingMarket";
            this.buttonAdvertisingMarket.Size = new System.Drawing.Size(210, 35);
            this.buttonAdvertisingMarket.TabIndex = 6;
            this.buttonAdvertisingMarket.Text = "Реклама магазина";
            this.buttonAdvertisingMarket.UseVisualStyleBackColor = true;
            this.buttonAdvertisingMarket.Click += new System.EventHandler(this.buttonAdvertisingMarket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список адресов магазинов";
            // 
            // FormAdvertisingAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 269);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormAdvertisingAgency";
            this.Text = "Рекламное агенство";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelCostAdvertisingAgencyMarket;
        private System.Windows.Forms.Label labelCostAdvertisingAgencyCondo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxAdvertisingСosts;
        private System.Windows.Forms.Button buttonAdvertisingCondo;
        private System.Windows.Forms.ComboBox comboBoxListMarkets;
        private System.Windows.Forms.Button buttonAdvertisingMarket;
        private System.Windows.Forms.Label label1;
    }
}