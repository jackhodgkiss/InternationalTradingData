namespace InternationalTradingData
{
    partial class TradePotentialDialogue
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
            this.Label_TradePotential = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_TradePotential
            // 
            this.Label_TradePotential.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_TradePotential.Location = new System.Drawing.Point(0, 0);
            this.Label_TradePotential.Name = "Label_TradePotential";
            this.Label_TradePotential.Size = new System.Drawing.Size(284, 81);
            this.Label_TradePotential.TabIndex = 0;
            this.Label_TradePotential.Text = "Biggest Trade Potential:";
            this.Label_TradePotential.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TradePotentialDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.Label_TradePotential);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TradePotentialDialogue";
            this.Text = "Biggest Trade Potential";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_TradePotential;
    }
}