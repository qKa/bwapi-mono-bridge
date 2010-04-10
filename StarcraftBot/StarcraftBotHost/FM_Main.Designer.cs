namespace StarcraftBotHost
{
    partial class FM_Main
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
            this.ED_Status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ED_Status
            // 
            this.ED_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ED_Status.BackColor = System.Drawing.SystemColors.Window;
            this.ED_Status.Location = new System.Drawing.Point(1, 2);
            this.ED_Status.Multiline = true;
            this.ED_Status.Name = "ED_Status";
            this.ED_Status.ReadOnly = true;
            this.ED_Status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ED_Status.Size = new System.Drawing.Size(446, 244);
            this.ED_Status.TabIndex = 0;
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 248);
            this.Controls.Add(this.ED_Status);
            this.Name = "FM_Main";
            this.Text = "Starcraft Bot Host v1.0";
            this.Shown += new System.EventHandler(this.FM_Main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ED_Status;
    }
}

