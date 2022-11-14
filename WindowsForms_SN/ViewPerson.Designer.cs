namespace WindowsForms_SN
{
    partial class ViewPerson
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonFollow = new System.Windows.Forms.Button();
            this.labelInterests = new System.Windows.Forms.Label();
            this.labelFollowers = new System.Windows.Forms.Label();
            this.labelFollowing = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelRecentPosts = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelShortestPath = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.labelShortestPath);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFollow);
            this.splitContainer1.Panel1.Controls.Add(this.labelInterests);
            this.splitContainer1.Panel1.Controls.Add(this.labelFollowers);
            this.splitContainer1.Panel1.Controls.Add(this.labelFollowing);
            this.splitContainer1.Panel1.Controls.Add(this.labelUserName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelRecentPosts);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonFollow
            // 
            this.buttonFollow.Location = new System.Drawing.Point(15, 168);
            this.buttonFollow.Name = "buttonFollow";
            this.buttonFollow.Size = new System.Drawing.Size(126, 23);
            this.buttonFollow.TabIndex = 5;
            this.buttonFollow.Text = "Follow/Unfollow";
            this.buttonFollow.UseVisualStyleBackColor = true;
            this.buttonFollow.Click += new System.EventHandler(this.buttonFollow_Click);
            // 
            // labelInterests
            // 
            this.labelInterests.AutoSize = true;
            this.labelInterests.Location = new System.Drawing.Point(15, 194);
            this.labelInterests.Name = "labelInterests";
            this.labelInterests.Size = new System.Drawing.Size(57, 16);
            this.labelInterests.TabIndex = 4;
            this.labelInterests.Text = "Interests";
            // 
            // labelFollowers
            // 
            this.labelFollowers.AutoSize = true;
            this.labelFollowers.Location = new System.Drawing.Point(15, 113);
            this.labelFollowers.Name = "labelFollowers";
            this.labelFollowers.Size = new System.Drawing.Size(72, 16);
            this.labelFollowers.TabIndex = 3;
            this.labelFollowers.Text = "- Followers";
            // 
            // labelFollowing
            // 
            this.labelFollowing.AutoSize = true;
            this.labelFollowing.Location = new System.Drawing.Point(15, 97);
            this.labelFollowing.Name = "labelFollowing";
            this.labelFollowing.Size = new System.Drawing.Size(71, 16);
            this.labelFollowing.TabIndex = 2;
            this.labelFollowing.Text = "- Following";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(15, 66);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(80, 18);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are viewing:";
            // 
            // tableLayoutPanelRecentPosts
            // 
            this.tableLayoutPanelRecentPosts.ColumnCount = 1;
            this.tableLayoutPanelRecentPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRecentPosts.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelRecentPosts.Name = "tableLayoutPanelRecentPosts";
            this.tableLayoutPanelRecentPosts.RowCount = 1;
            this.tableLayoutPanelRecentPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRecentPosts.Size = new System.Drawing.Size(524, 444);
            this.tableLayoutPanelRecentPosts.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelShortestPath
            // 
            this.labelShortestPath.AutoSize = true;
            this.labelShortestPath.Location = new System.Drawing.Point(15, 139);
            this.labelShortestPath.Name = "labelShortestPath";
            this.labelShortestPath.Size = new System.Drawing.Size(95, 16);
            this.labelShortestPath.TabIndex = 6;
            this.labelShortestPath.Text = "Shortest path: -";
            // 
            // ViewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ViewPerson";
            this.Text = "ViewPerson";
            this.Load += new System.EventHandler(this.ViewPerson_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonFollow;
        private System.Windows.Forms.Label labelInterests;
        private System.Windows.Forms.Label labelFollowers;
        private System.Windows.Forms.Label labelFollowing;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRecentPosts;
        private System.Windows.Forms.Label labelShortestPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}