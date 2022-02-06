namespace InternationalTradingData
{
    partial class MainForm
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
            this.Title = new System.Windows.Forms.Label();
            this.LBox_Countries = new System.Windows.Forms.ListBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_GDP = new System.Windows.Forms.Label();
            this.Label_Inflation = new System.Windows.Forms.Label();
            this.Label_TradeBalance = new System.Windows.Forms.Label();
            this.Label_HDI = new System.Windows.Forms.Label();
            this.Label_MainTradePartners = new System.Windows.Forms.Label();
            this.TBox_Name = new System.Windows.Forms.TextBox();
            this.TBox_GDP = new System.Windows.Forms.TextBox();
            this.TBox_Inflation = new System.Windows.Forms.TextBox();
            this.TBox_TradeBalance = new System.Windows.Forms.TextBox();
            this.TBox_HDI = new System.Windows.Forms.TextBox();
            this.TBox_MainTradePartners = new System.Windows.Forms.TextBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Label_N_Countries = new System.Windows.Forms.Label();
            this.Label_Height = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MItem_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.MItem_SearchName = new System.Windows.Forms.ToolStripMenuItem();
            this.MItem_SearchPartners = new System.Windows.Forms.ToolStripMenuItem();
            this.MItem_SearchTradeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Root = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(100, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(415, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "International Trading Data";
            // 
            // LBox_Countries
            // 
            this.LBox_Countries.FormattingEnabled = true;
            this.LBox_Countries.Location = new System.Drawing.Point(67, 76);
            this.LBox_Countries.Name = "LBox_Countries";
            this.LBox_Countries.Size = new System.Drawing.Size(120, 199);
            this.LBox_Countries.TabIndex = 1;
            this.LBox_Countries.SelectedIndexChanged += new System.EventHandler(this.LBox_Countries_SelectedIndexChanged);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(302, 77);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Name:";
            // 
            // Label_GDP
            // 
            this.Label_GDP.AutoSize = true;
            this.Label_GDP.Location = new System.Drawing.Point(216, 104);
            this.Label_GDP.Name = "Label_GDP";
            this.Label_GDP.Size = new System.Drawing.Size(124, 13);
            this.Label_GDP.TabIndex = 3;
            this.Label_GDP.Text = "Gross Domestic Product:";
            // 
            // Label_Inflation
            // 
            this.Label_Inflation.AutoSize = true;
            this.Label_Inflation.Location = new System.Drawing.Point(293, 131);
            this.Label_Inflation.Name = "Label_Inflation";
            this.Label_Inflation.Size = new System.Drawing.Size(47, 13);
            this.Label_Inflation.TabIndex = 4;
            this.Label_Inflation.Text = "Inflation:";
            // 
            // Label_TradeBalance
            // 
            this.Label_TradeBalance.AutoSize = true;
            this.Label_TradeBalance.Location = new System.Drawing.Point(260, 158);
            this.Label_TradeBalance.Name = "Label_TradeBalance";
            this.Label_TradeBalance.Size = new System.Drawing.Size(80, 13);
            this.Label_TradeBalance.TabIndex = 5;
            this.Label_TradeBalance.Text = "Trade Balance:";
            // 
            // Label_HDI
            // 
            this.Label_HDI.AutoSize = true;
            this.Label_HDI.Location = new System.Drawing.Point(201, 185);
            this.Label_HDI.Name = "Label_HDI";
            this.Label_HDI.Size = new System.Drawing.Size(139, 13);
            this.Label_HDI.TabIndex = 6;
            this.Label_HDI.Text = "Human Development Index:";
            // 
            // Label_MainTradePartners
            // 
            this.Label_MainTradePartners.AutoSize = true;
            this.Label_MainTradePartners.Location = new System.Drawing.Point(234, 212);
            this.Label_MainTradePartners.Name = "Label_MainTradePartners";
            this.Label_MainTradePartners.Size = new System.Drawing.Size(106, 13);
            this.Label_MainTradePartners.TabIndex = 7;
            this.Label_MainTradePartners.Text = "Main Trade Partners:";
            // 
            // TBox_Name
            // 
            this.TBox_Name.Enabled = false;
            this.TBox_Name.Location = new System.Drawing.Point(356, 74);
            this.TBox_Name.Name = "TBox_Name";
            this.TBox_Name.Size = new System.Drawing.Size(159, 20);
            this.TBox_Name.TabIndex = 8;
            // 
            // TBox_GDP
            // 
            this.TBox_GDP.Enabled = false;
            this.TBox_GDP.Location = new System.Drawing.Point(356, 101);
            this.TBox_GDP.Name = "TBox_GDP";
            this.TBox_GDP.Size = new System.Drawing.Size(159, 20);
            this.TBox_GDP.TabIndex = 9;
            // 
            // TBox_Inflation
            // 
            this.TBox_Inflation.Enabled = false;
            this.TBox_Inflation.Location = new System.Drawing.Point(356, 128);
            this.TBox_Inflation.Name = "TBox_Inflation";
            this.TBox_Inflation.Size = new System.Drawing.Size(159, 20);
            this.TBox_Inflation.TabIndex = 10;
            // 
            // TBox_TradeBalance
            // 
            this.TBox_TradeBalance.Enabled = false;
            this.TBox_TradeBalance.Location = new System.Drawing.Point(356, 155);
            this.TBox_TradeBalance.Name = "TBox_TradeBalance";
            this.TBox_TradeBalance.Size = new System.Drawing.Size(159, 20);
            this.TBox_TradeBalance.TabIndex = 11;
            // 
            // TBox_HDI
            // 
            this.TBox_HDI.Enabled = false;
            this.TBox_HDI.Location = new System.Drawing.Point(356, 182);
            this.TBox_HDI.Name = "TBox_HDI";
            this.TBox_HDI.Size = new System.Drawing.Size(159, 20);
            this.TBox_HDI.TabIndex = 12;
            // 
            // TBox_MainTradePartners
            // 
            this.TBox_MainTradePartners.Enabled = false;
            this.TBox_MainTradePartners.Location = new System.Drawing.Point(356, 209);
            this.TBox_MainTradePartners.Name = "TBox_MainTradePartners";
            this.TBox_MainTradePartners.Size = new System.Drawing.Size(159, 20);
            this.TBox_MainTradePartners.TabIndex = 13;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(537, 100);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 14;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(537, 178);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 15;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(537, 152);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 16;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(537, 126);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Submit.TabIndex = 17;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Label_N_Countries
            // 
            this.Label_N_Countries.AutoSize = true;
            this.Label_N_Countries.Location = new System.Drawing.Point(234, 260);
            this.Label_N_Countries.Name = "Label_N_Countries";
            this.Label_N_Countries.Size = new System.Drawing.Size(105, 13);
            this.Label_N_Countries.TabIndex = 18;
            this.Label_N_Countries.Text = "Number of countries:";
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(275, 280);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(64, 13);
            this.Label_Height.TabIndex = 19;
            this.Label_Height.Text = "Tree height:";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.Control;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItem_File});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(624, 24);
            this.MenuBar.TabIndex = 20;
            this.MenuBar.Text = "menuStrip1";
            // 
            // MItem_File
            // 
            this.MItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItem_Search,
            this.MItem_Quit});
            this.MItem_File.Name = "MItem_File";
            this.MItem_File.Size = new System.Drawing.Size(37, 20);
            this.MItem_File.Text = "File";
            // 
            // MItem_Search
            // 
            this.MItem_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItem_SearchName,
            this.MItem_SearchPartners,
            this.MItem_SearchTradeItem});
            this.MItem_Search.Name = "MItem_Search";
            this.MItem_Search.Size = new System.Drawing.Size(152, 22);
            this.MItem_Search.Text = "Search";
            // 
            // MItem_SearchName
            // 
            this.MItem_SearchName.Name = "MItem_SearchName";
            this.MItem_SearchName.Size = new System.Drawing.Size(233, 22);
            this.MItem_SearchName.Text = "Search By Name";
            this.MItem_SearchName.Click += new System.EventHandler(this.MItem_SearchName_Click);
            // 
            // MItem_SearchPartners
            // 
            this.MItem_SearchPartners.Name = "MItem_SearchPartners";
            this.MItem_SearchPartners.Size = new System.Drawing.Size(233, 22);
            this.MItem_SearchPartners.Text = "Search For Trade Partners";
            this.MItem_SearchPartners.Click += new System.EventHandler(this.MItem_SearchPartners_Click);
            // 
            // MItem_SearchTradeItem
            // 
            this.MItem_SearchTradeItem.Name = "MItem_SearchTradeItem";
            this.MItem_SearchTradeItem.Size = new System.Drawing.Size(233, 22);
            this.MItem_SearchTradeItem.Text = "Search Biggest Trade Potential";
            this.MItem_SearchTradeItem.Click += new System.EventHandler(this.MItem_SearchTradeItem_Click);
            // 
            // MItem_Quit
            // 
            this.MItem_Quit.Name = "MItem_Quit";
            this.MItem_Quit.Size = new System.Drawing.Size(152, 22);
            this.MItem_Quit.Text = "Quit";
            this.MItem_Quit.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Label_Root
            // 
            this.Label_Root.AutoSize = true;
            this.Label_Root.Location = new System.Drawing.Point(306, 244);
            this.Label_Root.Name = "Label_Root";
            this.Label_Root.Size = new System.Drawing.Size(33, 13);
            this.Label_Root.TabIndex = 21;
            this.Label_Root.Text = "Root:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 301);
            this.Controls.Add(this.Label_Root);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.Label_N_Countries);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.TBox_MainTradePartners);
            this.Controls.Add(this.TBox_HDI);
            this.Controls.Add(this.TBox_TradeBalance);
            this.Controls.Add(this.TBox_Inflation);
            this.Controls.Add(this.TBox_GDP);
            this.Controls.Add(this.TBox_Name);
            this.Controls.Add(this.Label_MainTradePartners);
            this.Controls.Add(this.Label_HDI);
            this.Controls.Add(this.Label_TradeBalance);
            this.Controls.Add(this.Label_Inflation);
            this.Controls.Add(this.Label_GDP);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.LBox_Countries);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "International Trading Data";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox LBox_Countries;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_GDP;
        private System.Windows.Forms.Label Label_Inflation;
        private System.Windows.Forms.Label Label_TradeBalance;
        private System.Windows.Forms.Label Label_HDI;
        private System.Windows.Forms.Label Label_MainTradePartners;
        private System.Windows.Forms.TextBox TBox_Name;
        private System.Windows.Forms.TextBox TBox_GDP;
        private System.Windows.Forms.TextBox TBox_Inflation;
        private System.Windows.Forms.TextBox TBox_TradeBalance;
        private System.Windows.Forms.TextBox TBox_HDI;
        private System.Windows.Forms.TextBox TBox_MainTradePartners;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Label Label_N_Countries;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MItem_File;
        private System.Windows.Forms.ToolStripMenuItem MItem_Search;
        private System.Windows.Forms.ToolStripMenuItem MItem_SearchName;
        private System.Windows.Forms.ToolStripMenuItem MItem_SearchPartners;
        private System.Windows.Forms.ToolStripMenuItem MItem_SearchTradeItem;
        private System.Windows.Forms.ToolStripMenuItem MItem_Quit;
        private System.Windows.Forms.Label Label_Root;
    }
}