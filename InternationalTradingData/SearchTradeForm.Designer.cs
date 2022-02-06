namespace InternationalTradingData
{
    partial class SearchTradeForm
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
            this.DGridView_Countries = new System.Windows.Forms.DataGridView();
            this.Label_TradePartner = new System.Windows.Forms.Label();
            this.TBox_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Countries)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView_Countries
            // 
            this.DGridView_Countries.AllowUserToAddRows = false;
            this.DGridView_Countries.AllowUserToDeleteRows = false;
            this.DGridView_Countries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridView_Countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_Countries.Location = new System.Drawing.Point(12, 55);
            this.DGridView_Countries.MultiSelect = false;
            this.DGridView_Countries.Name = "DGridView_Countries";
            this.DGridView_Countries.ReadOnly = true;
            this.DGridView_Countries.RowHeadersVisible = false;
            this.DGridView_Countries.Size = new System.Drawing.Size(680, 284);
            this.DGridView_Countries.TabIndex = 1;
            // 
            // Label_TradePartner
            // 
            this.Label_TradePartner.AutoSize = true;
            this.Label_TradePartner.Location = new System.Drawing.Point(12, 24);
            this.Label_TradePartner.Name = "Label_TradePartner";
            this.Label_TradePartner.Size = new System.Drawing.Size(119, 13);
            this.Label_TradePartner.TabIndex = 2;
            this.Label_TradePartner.Text = "Common Trade Partner:";
            // 
            // TBox_Search
            // 
            this.TBox_Search.Location = new System.Drawing.Point(133, 21);
            this.TBox_Search.Name = "TBox_Search";
            this.TBox_Search.Size = new System.Drawing.Size(131, 20);
            this.TBox_Search.TabIndex = 3;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(270, 18);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // SearchTradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 351);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.TBox_Search);
            this.Controls.Add(this.Label_TradePartner);
            this.Controls.Add(this.DGridView_Countries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchTradeForm";
            this.Text = "Search For Common Trade Partner";
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Countries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView_Countries;
        private System.Windows.Forms.Label Label_TradePartner;
        private System.Windows.Forms.TextBox TBox_Search;
        private System.Windows.Forms.Button Btn_Search;
    }
}