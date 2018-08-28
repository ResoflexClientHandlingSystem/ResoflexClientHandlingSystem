namespace ResoflexClientHandlingSystem
{
    partial class ProjectManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManager));
            this.home = new MetroFramework.Controls.MetroPanel();
            this.btnTasks = new MetroFramework.Controls.MetroButton();
            this.btnEvents = new MetroFramework.Controls.MetroButton();
            this.btnSchedule = new MetroFramework.Controls.MetroButton();
            this.btnProjects = new MetroFramework.Controls.MetroButton();
            this.home.SuspendLayout();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home.Controls.Add(this.btnTasks);
            this.home.Controls.Add(this.btnEvents);
            this.home.Controls.Add(this.btnSchedule);
            this.home.Controls.Add(this.btnProjects);
            this.home.HorizontalScrollbarBarColor = true;
            this.home.HorizontalScrollbarHighlightOnWheel = false;
            this.home.HorizontalScrollbarSize = 10;
            this.home.Location = new System.Drawing.Point(20, 60);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(760, 520);
            this.home.TabIndex = 0;
            this.home.VerticalScrollbarBarColor = true;
            this.home.VerticalScrollbarHighlightOnWheel = false;
            this.home.VerticalScrollbarSize = 10;
            // 
            // btnTasks
            // 
            this.btnTasks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTasks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTasks.BackgroundImage")));
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTasks.Location = new System.Drawing.Point(393, 283);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(2);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(225, 193);
            this.btnTasks.TabIndex = 24;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTasks.UseSelectable = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEvents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEvents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEvents.BackgroundImage")));
            this.btnEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEvents.Location = new System.Drawing.Point(142, 283);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(225, 193);
            this.btnEvents.TabIndex = 23;
            this.btnEvents.Text = "Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEvents.UseSelectable = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSchedule.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchedule.BackgroundImage")));
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSchedule.Location = new System.Drawing.Point(393, 37);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(225, 193);
            this.btnSchedule.TabIndex = 22;
            this.btnSchedule.Text = "Schedules";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSchedule.UseSelectable = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProjects.BackgroundImage")));
            this.btnProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProjects.Location = new System.Drawing.Point(142, 37);
            this.btnProjects.Margin = new System.Windows.Forms.Padding(2);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(225, 193);
            this.btnProjects.TabIndex = 21;
            this.btnProjects.Text = "Projects";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProjects.UseSelectable = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.home);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ProjectManager";
            this.Text = "Project Manager";
            this.Load += new System.EventHandler(this.ProjectManager_Load);
            this.home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel home;
        private MetroFramework.Controls.MetroButton btnTasks;
        private MetroFramework.Controls.MetroButton btnEvents;
        private MetroFramework.Controls.MetroButton btnSchedule;
        private MetroFramework.Controls.MetroButton btnProjects;
    }
}
