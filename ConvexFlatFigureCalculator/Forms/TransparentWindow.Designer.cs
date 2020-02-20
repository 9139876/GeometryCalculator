namespace ConvexFlatFigureCalculator
{
    partial class TransparentWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransparentWindow));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.СontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.СontextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.СontextMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Калькулятор плоских выпуклых фигур";
            this.NotifyIcon.Visible = true;
            // 
            // СontextMenu
            // 
            this.СontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExit});
            this.СontextMenu.Name = "СontextMenu";
            this.СontextMenu.Size = new System.Drawing.Size(121, 26);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(120, 22);
            this.MenuItemExit.Text = "Закрыть";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // TransparentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "TransparentWindow";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransparentWindow_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.TransparentWindow_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TransparentWindow_MouseClick);            
            this.СontextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip СontextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
    }
}

