namespace WindowsForms_SN
{
    partial class PostUC
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.checkBoxLikes = new System.Windows.Forms.CheckBox();
            this.buttonShowLikes = new System.Windows.Forms.Button();
            this.LabelCommentNumber = new System.Windows.Forms.Label();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.buttonShowComments = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(22, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(22, 62);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(62, 16);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // labelBody
            // 
            this.labelBody.Location = new System.Drawing.Point(22, 88);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(472, 81);
            this.labelBody.TabIndex = 2;
            this.labelBody.Text = "Body\r\n";
            // 
            // checkBoxLikes
            // 
            this.checkBoxLikes.AutoSize = true;
            this.checkBoxLikes.Location = new System.Drawing.Point(27, 172);
            this.checkBoxLikes.Name = "checkBoxLikes";
            this.checkBoxLikes.Size = new System.Drawing.Size(68, 20);
            this.checkBoxLikes.TabIndex = 3;
            this.checkBoxLikes.Text = "- Likes";
            this.checkBoxLikes.UseVisualStyleBackColor = true;
            this.checkBoxLikes.CheckedChanged += new System.EventHandler(this.checkBoxLikes_CheckedChanged);
            // 
            // buttonShowLikes
            // 
            this.buttonShowLikes.Location = new System.Drawing.Point(27, 199);
            this.buttonShowLikes.Name = "buttonShowLikes";
            this.buttonShowLikes.Size = new System.Drawing.Size(109, 23);
            this.buttonShowLikes.TabIndex = 4;
            this.buttonShowLikes.Text = "Show Likes";
            this.buttonShowLikes.UseVisualStyleBackColor = true;
            this.buttonShowLikes.Click += new System.EventHandler(this.buttonShowLikes_Click);
            // 
            // LabelCommentNumber
            // 
            this.LabelCommentNumber.AutoSize = true;
            this.LabelCommentNumber.Location = new System.Drawing.Point(317, 176);
            this.LabelCommentNumber.Name = "LabelCommentNumber";
            this.LabelCommentNumber.Size = new System.Drawing.Size(78, 16);
            this.LabelCommentNumber.TabIndex = 5;
            this.LabelCommentNumber.Text = "- Comments";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(237, 199);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(108, 23);
            this.buttonAddComment.TabIndex = 6;
            this.buttonAddComment.Text = "Add comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // buttonShowComments
            // 
            this.buttonShowComments.Location = new System.Drawing.Point(355, 199);
            this.buttonShowComments.Name = "buttonShowComments";
            this.buttonShowComments.Size = new System.Drawing.Size(113, 23);
            this.buttonShowComments.TabIndex = 7;
            this.buttonShowComments.Text = "Show comments";
            this.buttonShowComments.UseVisualStyleBackColor = true;
            this.buttonShowComments.Click += new System.EventHandler(this.buttonShowComments_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(22, 36);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(45, 16);
            this.labelAuthor.TabIndex = 8;
            this.labelAuthor.Text = "Author";
            // 
            // PostUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonShowComments);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.LabelCommentNumber);
            this.Controls.Add(this.buttonShowLikes);
            this.Controls.Add(this.checkBoxLikes);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelTitle);
            this.Name = "PostUC";
            this.Size = new System.Drawing.Size(507, 237);
            this.Load += new System.EventHandler(this.PostUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.CheckBox checkBoxLikes;
        private System.Windows.Forms.Button buttonShowLikes;
        private System.Windows.Forms.Label LabelCommentNumber;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.Button buttonShowComments;
        private System.Windows.Forms.Label labelAuthor;
    }
}
