namespace SteelRetails.Screens
{
    partial class MainTemplateForm
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
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(800, 45);
            this.topBorderPanel.TabIndex = 0;
            this.topBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBorderPanel_MouseDown);
            this.topBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBorderPanel_MouseMove);
            // 
            // MainTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainTemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBorderPanel;
    }
}