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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.confirmBtn = new MetroFramework.Controls.MetroButton();
            this.amountTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.cashDateTimeTxtBox = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.projectIdBox = new MetroFramework.Controls.MetroTextBox();
            this.scheduleId = new MetroFramework.Controls.MetroTextBox();
            this.details = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.iouIdBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(86, 296);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Issued Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(86, 336);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Amount ";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(379, 375);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 55);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseSelectable = true;
            this.confirmBtn.Click += new System.EventHandler(this.metroButton1_Click);
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
            this.amountTxtBox.Location = new System.Drawing.Point(203, 336);
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
            this.cashDateTimeTxtBox.Location = new System.Drawing.Point(203, 277);
            this.cashDateTimeTxtBox.MinimumSize = new System.Drawing.Size(0, 29);
            this.cashDateTimeTxtBox.Name = "cashDateTimeTxtBox";
            this.cashDateTimeTxtBox.Size = new System.Drawing.Size(200, 29);
            this.cashDateTimeTxtBox.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(86, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "IOU ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(86, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Project ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(86, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Schedule ID";
            // 
            // projectIdBox
            // 
            // 
            // 
            // 
            this.projectIdBox.CustomButton.Image = null;
            this.projectIdBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.projectIdBox.CustomButton.Name = "";
            this.projectIdBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectIdBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectIdBox.CustomButton.TabIndex = 1;
            this.projectIdBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectIdBox.CustomButton.UseSelectable = true;
            this.projectIdBox.CustomButton.Visible = false;
            this.projectIdBox.Lines = new string[0];
            this.projectIdBox.Location = new System.Drawing.Point(213, 152);
            this.projectIdBox.MaxLength = 32767;
            this.projectIdBox.Name = "projectIdBox";
            this.projectIdBox.PasswordChar = '\0';
            this.projectIdBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectIdBox.SelectedText = "";
            this.projectIdBox.SelectionLength = 0;
            this.projectIdBox.SelectionStart = 0;
            this.projectIdBox.ShortcutsEnabled = true;
            this.projectIdBox.Size = new System.Drawing.Size(75, 23);
            this.projectIdBox.TabIndex = 17;
            this.projectIdBox.UseSelectable = true;
            this.projectIdBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectIdBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // scheduleId
            // 
            // 
            // 
            // 
            this.scheduleId.CustomButton.Image = null;
            this.scheduleId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.scheduleId.CustomButton.Name = "";
            this.scheduleId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.scheduleId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.scheduleId.CustomButton.TabIndex = 1;
            this.scheduleId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.scheduleId.CustomButton.UseSelectable = true;
            this.scheduleId.CustomButton.Visible = false;
            this.scheduleId.Lines = new string[0];
            this.scheduleId.Location = new System.Drawing.Point(213, 193);
            this.scheduleId.MaxLength = 32767;
            this.scheduleId.Name = "scheduleId";
            this.scheduleId.PasswordChar = '\0';
            this.scheduleId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scheduleId.SelectedText = "";
            this.scheduleId.SelectionLength = 0;
            this.scheduleId.SelectionStart = 0;
            this.scheduleId.ShortcutsEnabled = true;
            this.scheduleId.Size = new System.Drawing.Size(75, 23);
            this.scheduleId.TabIndex = 18;
            this.scheduleId.UseSelectable = true;
            this.scheduleId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.scheduleId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // details
            // 
            // 
            // 
            // 
            this.details.CustomButton.Image = null;
            this.details.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.details.CustomButton.Name = "";
            this.details.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.details.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.details.CustomButton.TabIndex = 1;
            this.details.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.details.CustomButton.UseSelectable = true;
            this.details.CustomButton.Visible = false;
            this.details.Lines = new string[0];
            this.details.Location = new System.Drawing.Point(213, 234);
            this.details.MaxLength = 32767;
            this.details.Name = "details";
            this.details.PasswordChar = '\0';
            this.details.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.details.SelectedText = "";
            this.details.SelectionLength = 0;
            this.details.SelectionStart = 0;
            this.details.ShortcutsEnabled = true;
            this.details.Size = new System.Drawing.Size(75, 23);
            this.details.TabIndex = 19;
            this.details.UseSelectable = true;
            this.details.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.details.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(86, 238);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Detail";
            // 
            // iouIdBox
            // 
            // 
            // 
            // 
            this.iouIdBox.CustomButton.Image = null;
            this.iouIdBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.iouIdBox.CustomButton.Name = "";
            this.iouIdBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.iouIdBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iouIdBox.CustomButton.TabIndex = 1;
            this.iouIdBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iouIdBox.CustomButton.UseSelectable = true;
            this.iouIdBox.CustomButton.Visible = false;
            this.iouIdBox.Lines = new string[0];
            this.iouIdBox.Location = new System.Drawing.Point(203, 98);
            this.iouIdBox.MaxLength = 32767;
            this.iouIdBox.Name = "iouIdBox";
            this.iouIdBox.PasswordChar = '\0';
            this.iouIdBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iouIdBox.SelectedText = "";
            this.iouIdBox.SelectionLength = 0;
            this.iouIdBox.SelectionStart = 0;
            this.iouIdBox.ShortcutsEnabled = true;
            this.iouIdBox.Size = new System.Drawing.Size(75, 23);
            this.iouIdBox.TabIndex = 21;
            this.iouIdBox.UseSelectable = true;
            this.iouIdBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iouIdBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CashIssuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.iouIdBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.details);
            this.Controls.Add(this.scheduleId);
            this.Controls.Add(this.projectIdBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cashDateTimeTxtBox);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Name = "CashIssuingForm";
            this.Text = "Cash Issuing";
            this.Load += new System.EventHandler(this.CashIssuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton confirmBtn;
        private MetroFramework.Controls.MetroTextBox amountTxtBox;
        private MetroFramework.Controls.MetroDateTime cashDateTimeTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox projectIdBox;
        private MetroFramework.Controls.MetroTextBox scheduleId;
        private MetroFramework.Controls.MetroTextBox details;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox iouIdBox;
    }
}