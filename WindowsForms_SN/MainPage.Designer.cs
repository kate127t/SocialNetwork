namespace WindowsForms_SN
{
    partial class MainPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelFollowing = new System.Windows.Forms.Label();
            this.labelFollowers = new System.Windows.Forms.Label();
            this.buttonWritePost = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tableLayoutPanelRecentPosts = new System.Windows.Forms.TableLayoutPanel();
            this.labelInterests = new System.Windows.Forms.Label();
            this.buttonSearchPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearchPerson);
            this.splitContainer1.Panel1.Controls.Add(this.labelInterests);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.labelFollowing);
            this.splitContainer1.Panel1.Controls.Add(this.labelFollowers);
            this.splitContainer1.Panel1.Controls.Add(this.buttonWritePost);
            this.splitContainer1.Panel1.Controls.Add(this.labelUserName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelRecentPosts);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search person by login:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(16, 383);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(237, 22);
            this.textBoxSearch.TabIndex = 5;
            // 
            // labelFollowing
            // 
            this.labelFollowing.AutoSize = true;
            this.labelFollowing.Location = new System.Drawing.Point(12, 39);
            this.labelFollowing.Name = "labelFollowing";
            this.labelFollowing.Size = new System.Drawing.Size(64, 16);
            this.labelFollowing.TabIndex = 4;
            this.labelFollowing.Text = "Following";
            // 
            // labelFollowers
            // 
            this.labelFollowers.AutoSize = true;
            this.labelFollowers.Location = new System.Drawing.Point(13, 55);
            this.labelFollowers.Name = "labelFollowers";
            this.labelFollowers.Size = new System.Drawing.Size(65, 16);
            this.labelFollowers.TabIndex = 3;
            this.labelFollowers.Text = "Followers";
            // 
            // buttonWritePost
            // 
            this.buttonWritePost.Location = new System.Drawing.Point(16, 315);
            this.buttonWritePost.Name = "buttonWritePost";
            this.buttonWritePost.Size = new System.Drawing.Size(152, 23);
            this.buttonWritePost.TabIndex = 2;
            this.buttonWritePost.Text = "Write Post";
            this.buttonWritePost.UseVisualStyleBackColor = true;
            this.buttonWritePost.Click += new System.EventHandler(this.buttonWritePost_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(13, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(80, 18);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "UserName";
            // 
            // tableLayoutPanelRecentPosts
            // 
            this.tableLayoutPanelRecentPosts.AutoScroll = true;
            this.tableLayoutPanelRecentPosts.ColumnCount = 1;
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRecentPosts.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanelRecentPosts.Name = "tableLayoutPanelRecentPosts";
            this.tableLayoutPanelRecentPosts.RowCount = 1;
            this.tableLayoutPanelRecentPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRecentPosts.Size = new System.Drawing.Size(524, 447);
            this.tableLayoutPanelRecentPosts.TabIndex = 2;
            // 
            // labelInterests
            // 
            this.labelInterests.Location = new System.Drawing.Point(13, 83);
            this.labelInterests.Name = "labelInterests";
            this.labelInterests.Size = new System.Drawing.Size(240, 98);
            this.labelInterests.TabIndex = 7;
            this.labelInterests.Text = "Interests";
            // 
            // buttonSearchPerson
            // 
            this.buttonSearchPerson.Location = new System.Drawing.Point(16, 412);
            this.buttonSearchPerson.Name = "buttonSearchPerson";
            this.buttonSearchPerson.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPerson.TabIndex = 8;
            this.buttonSearchPerson.Text = "Search";
            this.buttonSearchPerson.UseVisualStyleBackColor = true;
            this.buttonSearchPerson.Click += new System.EventHandler(this.buttonSearchPerson_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonWritePost;
        private System.Windows.Forms.Label labelFollowing;
        private System.Windows.Forms.Label labelFollowers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRecentPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelInterests;
        private System.Windows.Forms.Button buttonSearchPerson;
    }
}