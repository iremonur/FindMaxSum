namespace FindMaxSum
{
    partial class Form1
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
            this.lblChooseFile = new System.Windows.Forms.Label();
            this.lblMaxSum = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtMaxSum = new System.Windows.Forms.TextBox();
            this.lblFileContent = new System.Windows.Forms.Label();
            this.listBoxFileContent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblChooseFile
            // 
            this.lblChooseFile.AutoSize = true;
            this.lblChooseFile.Location = new System.Drawing.Point(79, 37);
            this.lblChooseFile.Name = "lblChooseFile";
            this.lblChooseFile.Size = new System.Drawing.Size(68, 13);
            this.lblChooseFile.TabIndex = 0;
            this.lblChooseFile.Text = "Choose File :";
            // 
            // lblMaxSum
            // 
            this.lblMaxSum.AutoSize = true;
            this.lblMaxSum.Location = new System.Drawing.Point(79, 79);
            this.lblMaxSum.Name = "lblMaxSum";
            this.lblMaxSum.Size = new System.Drawing.Size(57, 13);
            this.lblMaxSum.TabIndex = 1;
            this.lblMaxSum.Text = "Max Sum :";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(156, 32);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(100, 23);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Choose";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtMaxSum
            // 
            this.txtMaxSum.Location = new System.Drawing.Point(156, 76);
            this.txtMaxSum.Name = "txtMaxSum";
            this.txtMaxSum.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSum.TabIndex = 3;
            // 
            // lblFileContent
            // 
            this.lblFileContent.AutoSize = true;
            this.lblFileContent.Location = new System.Drawing.Point(364, 32);
            this.lblFileContent.Name = "lblFileContent";
            this.lblFileContent.Size = new System.Drawing.Size(69, 13);
            this.lblFileContent.TabIndex = 4;
            this.lblFileContent.Text = "File Content :";
            // 
            // listBoxFileContent
            // 
            this.listBoxFileContent.FormattingEnabled = true;
            this.listBoxFileContent.Location = new System.Drawing.Point(344, 48);
            this.listBoxFileContent.Name = "listBoxFileContent";
            this.listBoxFileContent.Size = new System.Drawing.Size(120, 95);
            this.listBoxFileContent.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 189);
            this.Controls.Add(this.listBoxFileContent);
            this.Controls.Add(this.lblFileContent);
            this.Controls.Add(this.txtMaxSum);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblMaxSum);
            this.Controls.Add(this.lblChooseFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Max Sum of File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseFile;
        private System.Windows.Forms.Label lblMaxSum;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtMaxSum;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.ListBox listBoxFileContent;
    }
}

