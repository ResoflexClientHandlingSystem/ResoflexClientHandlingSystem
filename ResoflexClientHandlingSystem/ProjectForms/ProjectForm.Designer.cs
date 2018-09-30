namespace ResoflexClientHandlingSystem
{
    partial class ProjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.addProjectBtn = new MetroFramework.Controls.MetroButton();
            this.updateProjectBtn = new MetroFramework.Controls.MetroButton();
            this.progressBtn = new MetroFramework.Controls.MetroButton();
            this.incomeBtn = new MetroFramework.Controls.MetroButton();
            this.searchProjectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.searchBtn = new MetroFramework.Controls.MetroButton();
            this.projIdTile = new MetroFramework.Controls.MetroTile();
            this.totExpenceTile = new MetroFramework.Controls.MetroTile();
            this.warrantyTile = new MetroFramework.Controls.MetroTile();
            this.projectGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.maintenanceBtn = new MetroFramework.Controls.MetroButton();
            this.profilebtn = new MetroFramework.Controls.MetroButton();
            this.reqBtn = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.schHome = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addProjectBtn.Location = new System.Drawing.Point(34, 214);
            this.addProjectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(103, 26);
            this.addProjectBtn.TabIndex = 0;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseSelectable = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click_1);
            // 
            // updateProjectBtn
            // 
            this.updateProjectBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.updateProjectBtn.Location = new System.Drawing.Point(172, 214);
            this.updateProjectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateProjectBtn.Name = "updateProjectBtn";
            this.updateProjectBtn.Size = new System.Drawing.Size(103, 26);
            this.updateProjectBtn.TabIndex = 1;
            this.updateProjectBtn.Text = "Update Project";
            this.updateProjectBtn.UseSelectable = true;
            this.updateProjectBtn.Click += new System.EventHandler(this.updateProjectBtn_Click_1);
            // 
            // progressBtn
            // 
            this.progressBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.progressBtn.Location = new System.Drawing.Point(446, 214);
            this.progressBtn.Margin = new System.Windows.Forms.Padding(2);
            this.progressBtn.Name = "progressBtn";
            this.progressBtn.Size = new System.Drawing.Size(103, 26);
            this.progressBtn.TabIndex = 2;
            this.progressBtn.Text = "View Ranks";
            this.progressBtn.UseSelectable = true;
            this.progressBtn.Click += new System.EventHandler(this.progressBtn_Click);
            // 
            // incomeBtn
            // 
            this.incomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.incomeBtn.Location = new System.Drawing.Point(349, 283);
            this.incomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(65, 24);
            this.incomeBtn.TabIndex = 3;
            this.incomeBtn.Text = "More Info";
            this.incomeBtn.UseCustomBackColor = true;
            this.incomeBtn.UseCustomForeColor = true;
            this.incomeBtn.UseSelectable = true;
            this.incomeBtn.UseStyleColors = true;
            this.incomeBtn.Click += new System.EventHandler(this.incomeBtn_Click);
            // 
            // searchProjectTxtBox
            // 
            // 
            // 
            // 
            this.searchProjectTxtBox.CustomButton.Image = null;
            this.searchProjectTxtBox.CustomButton.Location = new System.Drawing.Point(186, 2);
            this.searchProjectTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchProjectTxtBox.CustomButton.Name = "";
            this.searchProjectTxtBox.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.searchProjectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchProjectTxtBox.CustomButton.TabIndex = 1;
            this.searchProjectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchProjectTxtBox.CustomButton.UseSelectable = true;
            this.searchProjectTxtBox.CustomButton.Visible = false;
            this.searchProjectTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchProjectTxtBox.Lines = new string[0];
            this.searchProjectTxtBox.Location = new System.Drawing.Point(34, 283);
            this.searchProjectTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchProjectTxtBox.MaxLength = 32767;
            this.searchProjectTxtBox.Multiline = true;
            this.searchProjectTxtBox.Name = "searchProjectTxtBox";
            this.searchProjectTxtBox.PasswordChar = '\0';
            this.searchProjectTxtBox.PromptText = "Search by Project/Client Name";
            this.searchProjectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchProjectTxtBox.SelectedText = "";
            this.searchProjectTxtBox.SelectionLength = 0;
            this.searchProjectTxtBox.SelectionStart = 0;
            this.searchProjectTxtBox.ShortcutsEnabled = true;
            this.searchProjectTxtBox.Size = new System.Drawing.Size(208, 24);
            this.searchProjectTxtBox.TabIndex = 4;
            this.searchProjectTxtBox.UseSelectable = true;
            this.searchProjectTxtBox.WaterMark = "Search by Project/Client Name";
            this.searchProjectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchProjectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchProjectTxtBox.TextChanged += new System.EventHandler(this.searchProjectTxtBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(247, 283);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 24);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseSelectable = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // projIdTile
            // 
            this.projIdTile.ActiveControl = null;
            this.projIdTile.AutoSize = true;
            this.projIdTile.Location = new System.Drawing.Point(36, 86);
            this.projIdTile.Margin = new System.Windows.Forms.Padding(2);
            this.projIdTile.Name = "projIdTile";
            this.projIdTile.Size = new System.Drawing.Size(95, 91);
            this.projIdTile.TabIndex = 7;
            this.projIdTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.projIdTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.projIdTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.projIdTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.projIdTile.UseCustomBackColor = true;
            this.projIdTile.UseSelectable = true;
            this.projIdTile.Click += new System.EventHandler(this.projIdTile_Click);
            // 
            // totExpenceTile
            // 
            this.totExpenceTile.ActiveControl = null;
            this.totExpenceTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totExpenceTile.AutoSize = true;
            this.totExpenceTile.Location = new System.Drawing.Point(254, 86);
            this.totExpenceTile.Margin = new System.Windows.Forms.Padding(2);
            this.totExpenceTile.Name = "totExpenceTile";
            this.totExpenceTile.Size = new System.Drawing.Size(161, 91);
            this.totExpenceTile.TabIndex = 8;
            this.totExpenceTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totExpenceTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totExpenceTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totExpenceTile.UseCustomBackColor = true;
            this.totExpenceTile.UseSelectable = true;
            // 
            // warrantyTile
            // 
            this.warrantyTile.ActiveControl = null;
            this.warrantyTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warrantyTile.AutoSize = true;
            this.warrantyTile.BackColor = System.Drawing.Color.White;
            this.warrantyTile.Location = new System.Drawing.Point(552, 86);
            this.warrantyTile.Margin = new System.Windows.Forms.Padding(2);
            this.warrantyTile.Name = "warrantyTile";
            this.warrantyTile.Size = new System.Drawing.Size(95, 91);
            this.warrantyTile.TabIndex = 9;
            this.warrantyTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warrantyTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.warrantyTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.warrantyTile.UseCustomBackColor = true;
            this.warrantyTile.UseSelectable = true;
            // 
            // projectGrid
            // 
            this.projectGrid.AllowUserToAddRows = false;
            this.projectGrid.AllowUserToDeleteRows = false;
            this.projectGrid.AllowUserToResizeRows = false;
            this.projectGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.projectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.projectGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.projectGrid.EnableHeadersVisualStyles = false;
            this.projectGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.projectGrid.Location = new System.Drawing.Point(17, 323);
            this.projectGrid.Margin = new System.Windows.Forms.Padding(2);
            this.projectGrid.Name = "projectGrid";
            this.projectGrid.ReadOnly = true;
            this.projectGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.projectGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.projectGrid.RowTemplate.Height = 24;
            this.projectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectGrid.Size = new System.Drawing.Size(766, 252);
            this.projectGrid.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectGrid.TabIndex = 10;
            this.projectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectGrid_CellContentClick);
            this.projectGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.projectGrid_RowHeaderMouseClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(34, 60);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "No of Projects";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(254, 60);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Warranty Start";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(550, 60);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Total Visits";
            // 
            // metroButton1
            // 
            this.metroButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroButton1.Location = new System.Drawing.Point(424, 283);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 24);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Add Catagory";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.ForeColor = System.Drawing.Color.Crimson;
            this.metroLabel11.Location = new System.Drawing.Point(656, 582);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(145, 15);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "*Click row header to View ";
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // maintenanceBtn
            // 
            this.maintenanceBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.maintenanceBtn.Location = new System.Drawing.Point(312, 214);
            this.maintenanceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.maintenanceBtn.Name = "maintenanceBtn";
            this.maintenanceBtn.Size = new System.Drawing.Size(103, 26);
            this.maintenanceBtn.TabIndex = 27;
            this.maintenanceBtn.Text = "Maintenance";
            this.maintenanceBtn.UseSelectable = true;
            this.maintenanceBtn.Click += new System.EventHandler(this.maintenanceBtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.profilebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.profilebtn.Location = new System.Drawing.Point(678, 36);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(105, 29);
            this.profilebtn.TabIndex = 28;
            this.profilebtn.UseCustomBackColor = true;
            this.profilebtn.UseSelectable = true;
            // 
            // reqBtn
            // 
            this.reqBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reqBtn.Location = new System.Drawing.Point(521, 283);
            this.reqBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reqBtn.Name = "reqBtn";
            this.reqBtn.Size = new System.Drawing.Size(71, 24);
            this.reqBtn.TabIndex = 29;
            this.reqBtn.Text = "Request";
            this.reqBtn.UseCustomBackColor = true;
            this.reqBtn.UseCustomForeColor = true;
            this.reqBtn.UseSelectable = true;
            this.reqBtn.Click += new System.EventHandler(this.reqBtn_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(678, 96);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 31;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(590, 214);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(103, 26);
            this.metroButton2.TabIndex = 32;
            this.metroButton2.Text = "Reports";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // schHome
            // 
            this.schHome.BackColor = System.Drawing.Color.Transparent;
            this.schHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schHome.BackgroundImage")));
            this.schHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schHome.Location = new System.Drawing.Point(644, 36);
            this.schHome.Margin = new System.Windows.Forms.Padding(2);
            this.schHome.Name = "schHome";
            this.schHome.Size = new System.Drawing.Size(29, 29);
            this.schHome.TabIndex = 30;
            this.schHome.UseSelectable = true;
            this.schHome.Click += new System.EventHandler(this.schHome_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.schHome);
            this.Controls.Add(this.reqBtn);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.maintenanceBtn);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.projectGrid);
            this.Controls.Add(this.warrantyTile);
            this.Controls.Add(this.totExpenceTile);
            this.Controls.Add(this.projIdTile);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchProjectTxtBox);
            this.Controls.Add(this.incomeBtn);
            this.Controls.Add(this.progressBtn);
            this.Controls.Add(this.updateProjectBtn);
            this.Controls.Add(this.addProjectBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addProjectBtn;
        private MetroFramework.Controls.MetroButton updateProjectBtn;
        private MetroFramework.Controls.MetroButton progressBtn;
        private MetroFramework.Controls.MetroButton incomeBtn;
        private MetroFramework.Controls.MetroTextBox searchProjectTxtBox;
        private MetroFramework.Controls.MetroButton searchBtn;
        private MetroFramework.Controls.MetroTile projIdTile;
        private MetroFramework.Controls.MetroTile totExpenceTile;
        private MetroFramework.Controls.MetroTile warrantyTile;
        private MetroFramework.Controls.MetroGrid projectGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton maintenanceBtn;
        private MetroFramework.Controls.MetroButton profilebtn;
        private MetroFramework.Controls.MetroButton reqBtn;
        private MetroFramework.Controls.MetroButton schHome;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}