namespace Search
{
    partial class Matcher
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
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.listBoxMatched = new System.Windows.Forms.ListBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelMatched = new System.Windows.Forms.Label();
            this.labelPattern = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(59, 219);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(213, 20);
            this.textBoxPattern.TabIndex = 2;
            // 
            // listBoxMatched
            // 
            this.listBoxMatched.FormattingEnabled = true;
            this.listBoxMatched.Location = new System.Drawing.Point(293, 31);
            this.listBoxMatched.Name = "listBoxMatched";
            this.listBoxMatched.Size = new System.Drawing.Size(260, 173);
            this.listBoxMatched.TabIndex = 4;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "Text";
            // 
            // labelMatched
            // 
            this.labelMatched.AutoSize = true;
            this.labelMatched.Location = new System.Drawing.Point(290, 9);
            this.labelMatched.Name = "labelMatched";
            this.labelMatched.Size = new System.Drawing.Size(49, 13);
            this.labelMatched.TabIndex = 6;
            this.labelMatched.Text = "Matched";
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(12, 222);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(41, 13);
            this.labelPattern.TabIndex = 7;
            this.labelPattern.Text = "Pattern";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(293, 217);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(15, 31);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(257, 173);
            this.textBoxText.TabIndex = 9;
            // 
            // Matcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 261);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelPattern);
            this.Controls.Add(this.labelMatched);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.listBoxMatched);
            this.Controls.Add(this.textBoxPattern);
            this.Name = "Matcher";
            this.Text = "Matcher";
            this.Load += new System.EventHandler(this.Matcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.ListBox listBoxMatched;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelMatched;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxText;
    }
}

