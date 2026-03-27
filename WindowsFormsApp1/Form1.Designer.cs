namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLinkToSearchResult;
        private System.Windows.Forms.TextBox txtLinkToSearchResult;
        private System.Windows.Forms.Label lblSearchHistory;
        private System.Windows.Forms.ListBox lstSearchHistory;
        private System.Windows.Forms.Button btnCloseBrowser;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLinkToSearchResult = new System.Windows.Forms.Label();
            this.txtLinkToSearchResult = new System.Windows.Forms.TextBox();
            this.lblSearchHistory = new System.Windows.Forms.Label();
            this.lstSearchHistory = new System.Windows.Forms.ListBox();
            this.btnCloseBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(24, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(457, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLinkToSearchResult
            // 
            this.lblLinkToSearchResult.AutoSize = true;
            this.lblLinkToSearchResult.Location = new System.Drawing.Point(24, 87);
            this.lblLinkToSearchResult.Name = "lblLinkToSearchResult";
            this.lblLinkToSearchResult.Size = new System.Drawing.Size(103, 13);
            this.lblLinkToSearchResult.TabIndex = 4;
            this.lblLinkToSearchResult.Text = "link to search result";
            // 
            // txtLinkToSearchResult
            // 
            this.txtLinkToSearchResult.Location = new System.Drawing.Point(24, 105);
            this.txtLinkToSearchResult.Name = "txtLinkToSearchResult";
            this.txtLinkToSearchResult.ReadOnly = true;
            this.txtLinkToSearchResult.Size = new System.Drawing.Size(548, 20);
            this.txtLinkToSearchResult.TabIndex = 5;
            // 
            // lblSearchHistory
            // 
            this.lblSearchHistory.AutoSize = true;
            this.lblSearchHistory.Location = new System.Drawing.Point(24, 150);
            this.lblSearchHistory.Name = "lblSearchHistory";
            this.lblSearchHistory.Size = new System.Drawing.Size(78, 13);
            this.lblSearchHistory.TabIndex = 6;
            this.lblSearchHistory.Text = "Search history";
            // 
            // lstSearchHistory
            // 
            this.lstSearchHistory.FormattingEnabled = true;
            this.lstSearchHistory.HorizontalScrollbar = true;
            this.lstSearchHistory.Location = new System.Drawing.Point(24, 168);
            this.lstSearchHistory.Name = "lstSearchHistory";
            this.lstSearchHistory.Size = new System.Drawing.Size(548, 147);
            this.lstSearchHistory.TabIndex = 7;
            // 
            // btnCloseBrowser
            // 
            this.btnCloseBrowser.Location = new System.Drawing.Point(24, 339);
            this.btnCloseBrowser.Name = "btnCloseBrowser";
            this.btnCloseBrowser.Size = new System.Drawing.Size(158, 31);
            this.btnCloseBrowser.TabIndex = 8;
            this.btnCloseBrowser.Text = "Close browser";
            this.btnCloseBrowser.UseVisualStyleBackColor = true;
            this.btnCloseBrowser.Click += new System.EventHandler(this.btnCloseBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 392);
            this.Controls.Add(this.btnCloseBrowser);
            this.Controls.Add(this.lstSearchHistory);
            this.Controls.Add(this.lblSearchHistory);
            this.Controls.Add(this.txtLinkToSearchResult);
            this.Controls.Add(this.lblLinkToSearchResult);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBay Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
