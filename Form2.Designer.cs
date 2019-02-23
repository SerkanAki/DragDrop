namespace DragDrop_1
{
    partial class Form2
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
            this.lstGonderen = new System.Windows.Forms.ListBox();
            this.lstAlan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstGonderen
            // 
            this.lstGonderen.FormattingEnabled = true;
            this.lstGonderen.Items.AddRange(new object[] {
            "Merve",
            "Emin",
            "Hakan",
            "Serkan",
            "Yusuf",
            "Gülcan"});
            this.lstGonderen.Location = new System.Drawing.Point(42, 12);
            this.lstGonderen.Name = "lstGonderen";
            this.lstGonderen.Size = new System.Drawing.Size(120, 199);
            this.lstGonderen.TabIndex = 0;
            this.lstGonderen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstGonderen_MouseDown);
            // 
            // lstAlan
            // 
            this.lstAlan.AllowDrop = true;
            this.lstAlan.FormattingEnabled = true;
            this.lstAlan.Location = new System.Drawing.Point(212, 12);
            this.lstAlan.Name = "lstAlan";
            this.lstAlan.Size = new System.Drawing.Size(120, 199);
            this.lstAlan.TabIndex = 1;
            this.lstAlan.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAlan_DragDrop);
            this.lstAlan.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAlan_DragEnter);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAlan);
            this.Controls.Add(this.lstGonderen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGonderen;
        private System.Windows.Forms.ListBox lstAlan;
    }
}