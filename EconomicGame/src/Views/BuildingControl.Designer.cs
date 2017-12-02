namespace EconomicGame.src.Views
{
    partial class BuildingControl
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
            this.labelBuilding = new System.Windows.Forms.Label();
            this.flowLayoutPanelUpgradeBuilding = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxCostSquareMeter = new System.Windows.Forms.TextBox();
            this.checkBoxIsFreese = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelUpgradeBuilding.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuilding
            // 
            this.labelBuilding.BackColor = System.Drawing.Color.OliveDrab;
            this.labelBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBuilding.Location = new System.Drawing.Point(0, 0);
            this.labelBuilding.Margin = new System.Windows.Forms.Padding(0);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(88, 100);
            this.labelBuilding.TabIndex = 0;
            this.labelBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBuilding.Click += new System.EventHandler(this.labelBuilding_Click);
            // 
            // flowLayoutPanelUpgradeBuilding
            // 
            this.flowLayoutPanelUpgradeBuilding.Controls.Add(this.textBoxCostSquareMeter);
            this.flowLayoutPanelUpgradeBuilding.Controls.Add(this.checkBoxIsFreese);
            this.flowLayoutPanelUpgradeBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelUpgradeBuilding.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanelUpgradeBuilding.Name = "flowLayoutPanelUpgradeBuilding";
            this.flowLayoutPanelUpgradeBuilding.Size = new System.Drawing.Size(88, 61);
            this.flowLayoutPanelUpgradeBuilding.TabIndex = 1;
            // 
            // textBoxCostSquareMeter
            // 
            this.textBoxCostSquareMeter.Location = new System.Drawing.Point(3, 3);
            this.textBoxCostSquareMeter.Name = "textBoxCostSquareMeter";
            this.textBoxCostSquareMeter.Size = new System.Drawing.Size(82, 22);
            this.textBoxCostSquareMeter.TabIndex = 1;
            this.textBoxCostSquareMeter.TextChanged += new System.EventHandler(this.textBoxCostSquareMeter_TextChanged);
            // 
            // checkBoxIsFreese
            // 
            this.checkBoxIsFreese.AutoSize = true;
            this.checkBoxIsFreese.Location = new System.Drawing.Point(3, 31);
            this.checkBoxIsFreese.Name = "checkBoxIsFreese";
            this.checkBoxIsFreese.Size = new System.Drawing.Size(90, 21);
            this.checkBoxIsFreese.TabIndex = 0;
            this.checkBoxIsFreese.Text = "Зам. стр.";
            this.checkBoxIsFreese.UseVisualStyleBackColor = true;
            this.checkBoxIsFreese.CheckedChanged += new System.EventHandler(this.checkBoxIsFreese_CheckedChanged);
            // 
            // BuildingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelUpgradeBuilding);
            this.Controls.Add(this.labelBuilding);
            this.Name = "BuildingControl";
            this.Size = new System.Drawing.Size(88, 161);
            this.flowLayoutPanelUpgradeBuilding.ResumeLayout(false);
            this.flowLayoutPanelUpgradeBuilding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUpgradeBuilding;
        private System.Windows.Forms.TextBox textBoxCostSquareMeter;
        private System.Windows.Forms.CheckBox checkBoxIsFreese;
    }
}
