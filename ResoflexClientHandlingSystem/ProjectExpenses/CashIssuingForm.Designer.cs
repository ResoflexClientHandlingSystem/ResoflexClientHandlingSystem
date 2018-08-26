namespace ResoflexClientHandlingSystem
{
    partial class CashIssuingForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.amountTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.cashDateTimeTxtBox = new MetroFramework.Controls.MetroDateTime();
            this.staffNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Staff Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 183);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(48, 268);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Amount ";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(379, 375);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 55);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Confirm";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // amountTxtBox
            // 
            // 
            // 
            // 
            this.amountTxtBox.CustomButton.Image = null;
            this.amountTxtBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.amountTxtBox.CustomButton.Name = "";
            this.amountTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amountTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountTxtBox.CustomButton.TabIndex = 1;
            this.amountTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountTxtBox.CustomButton.UseSelectable = true;
            this.amountTxtBox.CustomButton.Visible = false;
            this.amountTxtBox.Lines = new string[0];
            this.amountTxtBox.Location = new System.Drawing.Point(186, 268);
            this.amountTxtBox.MaxLength = 32767;
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.PasswordChar = '\0';
            this.amountTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountTxtBox.SelectedText = "";
            this.amountTxtBox.SelectionLength = 0;
            this.amountTxtBox.SelectionStart = 0;
            this.amountTxtBox.ShortcutsEnabled = true;
            this.amountTxtBox.Size = new System.Drawing.Size(75, 23);
            this.amountTxtBox.TabIndex = 11;
            this.amountTxtBox.UseSelectable = true;
            this.amountTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cashDateTimeTxtBox
            // 
            this.cashDateTimeTxtBox.Location = new System.Drawing.Point(186, 183);
            this.cashDateTimeTxtBox.MinimumSize = new System.Drawing.Size(0, 29);
            this.cashDateTimeTxtBox.Name = "cashDateTimeTxtBox";
            this.cashDateTimeTxtBox.Size = new System.Drawing.Size(200, 29);
            this.cashDateTimeTxtBox.TabIndex = 12;
            // 
            // staffNameComboBox
            // 
            this.staffNameComboBox.FormattingEnabled = true;
            this.staffNameComboBox.ItemHeight = 23;
            this.staffNameComboBox.Location = new System.Drawing.Point(186, 102);
            this.staffNameComboBox.Name = "staffNameComboBox";
            this.staffNameComboBox.Size = new System.Drawing.Size(247, 29);
            this.staffNameComboBox.TabIndex = 13;
            this.staffNameComboBox.UseSelectable = true;
            this.staffNameComboBox.SelectedIndexChanged += new System.EventHandler(this.staffNameComboBox_SelectedIndexChanged);
            // 
            // CashIssuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.staffNameComboBox);
            this.Controls.Add(this.cashDateTimeTxtBox);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Name = "CashIssuingForm";
            this.Text = "Cash Issuing";
            this.Load += new System.EventHandler(this.CashIssuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox amountTxtBox;
        private MetroFramework.Controls.MetroDateTime cashDateTimeTxtBox;
        private MetroFramework.Controls.MetroComboBox staffNameComboBox;
    }
}