﻿namespace FEFTwiddler.GUI.ChapterData
{
    partial class CastleMap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCastle = new System.Windows.Forms.PictureBox();
            this.lblSelectedBuilding = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCastle)).BeginInit();
            this.SuspendLayout();
            // 
            // picCastle
            // 
            this.picCastle.BackColor = System.Drawing.SystemColors.Control;
            this.picCastle.Location = new System.Drawing.Point(3, 3);
            this.picCastle.Name = "picCastle";
            this.picCastle.Size = new System.Drawing.Size(522, 540);
            this.picCastle.TabIndex = 0;
            this.picCastle.TabStop = false;
            this.picCastle.Paint += new System.Windows.Forms.PaintEventHandler(this.picCastle_Paint);
            this.picCastle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCastle_MouseClick);
            this.picCastle.MouseLeave += new System.EventHandler(this.picCastle_MouseLeave);
            this.picCastle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCastle_MouseMove);
            // 
            // lblSelectedBuilding
            // 
            this.lblSelectedBuilding.AutoSize = true;
            this.lblSelectedBuilding.Location = new System.Drawing.Point(3, 546);
            this.lblSelectedBuilding.Name = "lblSelectedBuilding";
            this.lblSelectedBuilding.Size = new System.Drawing.Size(85, 13);
            this.lblSelectedBuilding.TabIndex = 2;
            this.lblSelectedBuilding.Text = "Selected: (none)";
            // 
            // CastleMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectedBuilding);
            this.Controls.Add(this.picCastle);
            this.Name = "CastleMap";
            this.Size = new System.Drawing.Size(529, 572);
            this.Load += new System.EventHandler(this.CastleMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCastle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCastle;
        private System.Windows.Forms.Label lblSelectedBuilding;
    }
}
