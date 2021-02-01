namespace proj
{
    partial class GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupedColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedModeToolStripMenuItem,
            this.disconnectedToolStripMenuItem,
            this.crystalReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectedModeToolStripMenuItem
            // 
            this.connectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem});
            this.connectedModeToolStripMenuItem.Name = "connectedModeToolStripMenuItem";
            this.connectedModeToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.connectedModeToolStripMenuItem.Text = "Connected_Mode";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.form1ToolStripMenuItem.Text = "Form1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // disconnectedToolStripMenuItem
            // 
            this.disconnectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDetailToolStripMenuItem,
            this.showsInfoToolStripMenuItem,
            this.masterDetailToolStripMenuItem1});
            this.disconnectedToolStripMenuItem.Name = "disconnectedToolStripMenuItem";
            this.disconnectedToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.disconnectedToolStripMenuItem.Text = "Disconnected";
            // 
            // masterDetailToolStripMenuItem
            // 
            this.masterDetailToolStripMenuItem.Name = "masterDetailToolStripMenuItem";
            this.masterDetailToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.masterDetailToolStripMenuItem.Text = "Search_Admin_Election";
            this.masterDetailToolStripMenuItem.Click += new System.EventHandler(this.masterDetailToolStripMenuItem_Click);
            // 
            // showsInfoToolStripMenuItem
            // 
            this.showsInfoToolStripMenuItem.Name = "showsInfoToolStripMenuItem";
            this.showsInfoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showsInfoToolStripMenuItem.Text = "Shows_Info";
            // 
            // masterDetailToolStripMenuItem1
            // 
            this.masterDetailToolStripMenuItem1.Name = "masterDetailToolStripMenuItem1";
            this.masterDetailToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.masterDetailToolStripMenuItem1.Text = "Master_Detail";
            // 
            // crystalReportsToolStripMenuItem
            // 
            this.crystalReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupedColumnsToolStripMenuItem,
            this.formulaToolStripMenuItem});
            this.crystalReportsToolStripMenuItem.Name = "crystalReportsToolStripMenuItem";
            this.crystalReportsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.crystalReportsToolStripMenuItem.Text = "Crystal_Reports";
            // 
            // groupedColumnsToolStripMenuItem
            // 
            this.groupedColumnsToolStripMenuItem.Name = "groupedColumnsToolStripMenuItem";
            this.groupedColumnsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.groupedColumnsToolStripMenuItem.Text = "Grouped_Columns";
            this.groupedColumnsToolStripMenuItem.Click += new System.EventHandler(this.groupedColumnsToolStripMenuItem_Click);
            // 
            // formulaToolStripMenuItem
            // 
            this.formulaToolStripMenuItem.Name = "formulaToolStripMenuItem";
            this.formulaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.formulaToolStripMenuItem.Text = "Formula";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDetailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crystalReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupedColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulaToolStripMenuItem;
    }
}