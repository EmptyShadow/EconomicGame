namespace EconomicGame.src.Views
{
    partial class FormBuilding
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
            this.labelBuilding = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTypeBuilding = new System.Windows.Forms.ComboBox();
            this.comboBoxListBuilding = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoEllipsis = true;
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBuilding.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuilding.Location = new System.Drawing.Point(0, 60);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(189, 27);
            this.labelBuilding.TabIndex = 1;
            this.labelBuilding.Text = "Описание здания";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Controls.Add(this.button1);
            this.flowLayoutPanel.Controls.Add(this.button2);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(343, 38);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxTypeBuilding
            // 
            this.comboBoxTypeBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxTypeBuilding.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeBuilding.FormattingEnabled = true;
            this.comboBoxTypeBuilding.Location = new System.Drawing.Point(0, 0);
            this.comboBoxTypeBuilding.Name = "comboBoxTypeBuilding";
            this.comboBoxTypeBuilding.Size = new System.Drawing.Size(343, 30);
            this.comboBoxTypeBuilding.TabIndex = 3;
            this.comboBoxTypeBuilding.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeBuilding_SelectedIndexChanged);
            // 
            // comboBoxListBuilding
            // 
            this.comboBoxListBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxListBuilding.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxListBuilding.FormattingEnabled = true;
            this.comboBoxListBuilding.Location = new System.Drawing.Point(0, 30);
            this.comboBoxListBuilding.Name = "comboBoxListBuilding";
            this.comboBoxListBuilding.Size = new System.Drawing.Size(343, 30);
            this.comboBoxListBuilding.TabIndex = 4;
            this.comboBoxListBuilding.SelectedIndexChanged += new System.EventHandler(this.comboBoxListBuilding_SelectedIndexChanged);
            // 
            // FormBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(343, 164);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.labelBuilding);
            this.Controls.Add(this.comboBoxListBuilding);
            this.Controls.Add(this.comboBoxTypeBuilding);
            this.Name = "FormBuilding";
            this.Text = "Выбор здания";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxTypeBuilding;
        private System.Windows.Forms.ComboBox comboBoxListBuilding;
    }
}