namespace QL
{
    partial class Form1
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
            this.PanelSideMenu = new MetroFramework.Controls.MetroPanel();
            this.PanelLogo = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PanelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelSideMenu.Controls.Add(this.metroButton1);
            this.PanelSideMenu.Controls.Add(this.PanelLogo);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideMenu.HorizontalScrollbarBarColor = true;
            this.PanelSideMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSideMenu.HorizontalScrollbarSize = 10;
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(250, 655);
            this.PanelSideMenu.TabIndex = 0;
            this.PanelSideMenu.VerticalScrollbarBarColor = true;
            this.PanelSideMenu.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSideMenu.VerticalScrollbarSize = 10;
            this.PanelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSideMenu_Paint);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.HorizontalScrollbarBarColor = true;
            this.PanelLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelLogo.HorizontalScrollbarSize = 10;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(250, 100);
            this.PanelLogo.TabIndex = 2;
            this.PanelLogo.VerticalScrollbarBarColor = true;
            this.PanelLogo.VerticalScrollbarHighlightOnWheel = false;
            this.PanelLogo.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.Location = new System.Drawing.Point(0, 100);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(250, 45);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 655);
            this.Controls.Add(this.PanelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelSideMenu;
        private MetroFramework.Controls.MetroPanel PanelLogo;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

