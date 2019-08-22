namespace FileCompressor
{
    partial class CompressionForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInputInputDeitectoryPath = new System.Windows.Forms.Label();
            this.textBoxInputDeitectoryPath = new System.Windows.Forms.TextBox();
            this.buttonInputDeitectoryPathDialog = new System.Windows.Forms.Button();
            this.labelTargetFiles = new System.Windows.Forms.Label();
            this.listBoxTargetFiles = new System.Windows.Forms.ListBox();
            this.buttonTargetFileLoading = new System.Windows.Forms.Button();
            this.buttonTargetFileAllSelect = new System.Windows.Forms.Button();
            this.buttonTargetFileAllCancel = new System.Windows.Forms.Button();
            this.labelCompressionType = new System.Windows.Forms.Label();
            this.comboBoxCompressionType = new System.Windows.Forms.ComboBox();
            this.labelOutputDirectoryPath = new System.Windows.Forms.Label();
            this.buttonOutputDirectoryPathDialog = new System.Windows.Forms.Button();
            this.textBoxOutputDirectoryPath = new System.Windows.Forms.TextBox();
            this.checkBoxOutptDirectoryPath = new System.Windows.Forms.CheckBox();
            this.buttonCompression = new System.Windows.Forms.Button();
            this.folderBrowserDialogInput = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelInputInputDeitectoryPath
            // 
            this.labelInputInputDeitectoryPath.AutoSize = true;
            this.labelInputInputDeitectoryPath.Location = new System.Drawing.Point(12, 9);
            this.labelInputInputDeitectoryPath.Name = "labelInputInputDeitectoryPath";
            this.labelInputInputDeitectoryPath.Size = new System.Drawing.Size(284, 18);
            this.labelInputInputDeitectoryPath.TabIndex = 0;
            this.labelInputInputDeitectoryPath.Text = "圧縮するファイルが格納されているフォルダのパス";
            // 
            // textBoxInputDeitectoryPath
            // 
            this.textBoxInputDeitectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputDeitectoryPath.Location = new System.Drawing.Point(15, 30);
            this.textBoxInputDeitectoryPath.Name = "textBoxInputDeitectoryPath";
            this.textBoxInputDeitectoryPath.Size = new System.Drawing.Size(891, 25);
            this.textBoxInputDeitectoryPath.TabIndex = 1;
            // 
            // buttonInputDeitectoryPathDialog
            // 
            this.buttonInputDeitectoryPathDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInputDeitectoryPathDialog.Location = new System.Drawing.Point(912, 31);
            this.buttonInputDeitectoryPathDialog.Name = "buttonInputDeitectoryPathDialog";
            this.buttonInputDeitectoryPathDialog.Size = new System.Drawing.Size(75, 23);
            this.buttonInputDeitectoryPathDialog.TabIndex = 2;
            this.buttonInputDeitectoryPathDialog.Text = "参照";
            this.buttonInputDeitectoryPathDialog.UseVisualStyleBackColor = true;
            // 
            // labelTargetFiles
            // 
            this.labelTargetFiles.AutoSize = true;
            this.labelTargetFiles.Location = new System.Drawing.Point(12, 58);
            this.labelTargetFiles.Name = "labelTargetFiles";
            this.labelTargetFiles.Size = new System.Drawing.Size(104, 18);
            this.labelTargetFiles.TabIndex = 3;
            this.labelTargetFiles.Text = "圧縮するファイル";
            // 
            // listBoxTargetFiles
            // 
            this.listBoxTargetFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTargetFiles.FormattingEnabled = true;
            this.listBoxTargetFiles.ItemHeight = 18;
            this.listBoxTargetFiles.Location = new System.Drawing.Point(15, 79);
            this.listBoxTargetFiles.Name = "listBoxTargetFiles";
            this.listBoxTargetFiles.Size = new System.Drawing.Size(891, 364);
            this.listBoxTargetFiles.TabIndex = 4;
            // 
            // buttonTargetFileLoading
            // 
            this.buttonTargetFileLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTargetFileLoading.Location = new System.Drawing.Point(912, 79);
            this.buttonTargetFileLoading.Name = "buttonTargetFileLoading";
            this.buttonTargetFileLoading.Size = new System.Drawing.Size(75, 23);
            this.buttonTargetFileLoading.TabIndex = 5;
            this.buttonTargetFileLoading.Text = "ロード";
            this.buttonTargetFileLoading.UseVisualStyleBackColor = true;
            // 
            // buttonTargetFileAllSelect
            // 
            this.buttonTargetFileAllSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTargetFileAllSelect.Location = new System.Drawing.Point(912, 108);
            this.buttonTargetFileAllSelect.Name = "buttonTargetFileAllSelect";
            this.buttonTargetFileAllSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonTargetFileAllSelect.TabIndex = 6;
            this.buttonTargetFileAllSelect.Text = "全選択";
            this.buttonTargetFileAllSelect.UseVisualStyleBackColor = true;
            // 
            // buttonTargetFileAllCancel
            // 
            this.buttonTargetFileAllCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTargetFileAllCancel.Location = new System.Drawing.Point(912, 137);
            this.buttonTargetFileAllCancel.Name = "buttonTargetFileAllCancel";
            this.buttonTargetFileAllCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonTargetFileAllCancel.TabIndex = 7;
            this.buttonTargetFileAllCancel.Text = "全解除";
            this.buttonTargetFileAllCancel.UseVisualStyleBackColor = true;
            // 
            // labelCompressionType
            // 
            this.labelCompressionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCompressionType.AutoSize = true;
            this.labelCompressionType.Location = new System.Drawing.Point(12, 449);
            this.labelCompressionType.Name = "labelCompressionType";
            this.labelCompressionType.Size = new System.Drawing.Size(56, 18);
            this.labelCompressionType.TabIndex = 8;
            this.labelCompressionType.Text = "圧縮形式";
            // 
            // comboBoxCompressionType
            // 
            this.comboBoxCompressionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCompressionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompressionType.FormattingEnabled = true;
            this.comboBoxCompressionType.Location = new System.Drawing.Point(15, 470);
            this.comboBoxCompressionType.Name = "comboBoxCompressionType";
            this.comboBoxCompressionType.Size = new System.Drawing.Size(121, 26);
            this.comboBoxCompressionType.TabIndex = 9;
            // 
            // labelOutputDirectoryPath
            // 
            this.labelOutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutputDirectoryPath.AutoSize = true;
            this.labelOutputDirectoryPath.Location = new System.Drawing.Point(12, 499);
            this.labelOutputDirectoryPath.Name = "labelOutputDirectoryPath";
            this.labelOutputDirectoryPath.Size = new System.Drawing.Size(248, 18);
            this.labelOutputDirectoryPath.TabIndex = 10;
            this.labelOutputDirectoryPath.Text = "圧縮したファイルを出力するフォルダのパス";
            // 
            // buttonOutputDirectoryPathDialog
            // 
            this.buttonOutputDirectoryPathDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutputDirectoryPathDialog.Location = new System.Drawing.Point(912, 521);
            this.buttonOutputDirectoryPathDialog.Name = "buttonOutputDirectoryPathDialog";
            this.buttonOutputDirectoryPathDialog.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputDirectoryPathDialog.TabIndex = 12;
            this.buttonOutputDirectoryPathDialog.Text = "参照";
            this.buttonOutputDirectoryPathDialog.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputDirectoryPath
            // 
            this.textBoxOutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputDirectoryPath.Location = new System.Drawing.Point(15, 520);
            this.textBoxOutputDirectoryPath.Name = "textBoxOutputDirectoryPath";
            this.textBoxOutputDirectoryPath.Size = new System.Drawing.Size(891, 25);
            this.textBoxOutputDirectoryPath.TabIndex = 11;
            // 
            // checkBoxOutptDirectoryPath
            // 
            this.checkBoxOutptDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOutptDirectoryPath.AutoSize = true;
            this.checkBoxOutptDirectoryPath.Location = new System.Drawing.Point(15, 551);
            this.checkBoxOutptDirectoryPath.Name = "checkBoxOutptDirectoryPath";
            this.checkBoxOutptDirectoryPath.Size = new System.Drawing.Size(147, 22);
            this.checkBoxOutptDirectoryPath.TabIndex = 13;
            this.checkBoxOutptDirectoryPath.Text = "同じパスに出力する。";
            this.checkBoxOutptDirectoryPath.UseVisualStyleBackColor = true;
            // 
            // buttonCompression
            // 
            this.buttonCompression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCompression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCompression.Location = new System.Drawing.Point(912, 579);
            this.buttonCompression.Name = "buttonCompression";
            this.buttonCompression.Size = new System.Drawing.Size(75, 23);
            this.buttonCompression.TabIndex = 14;
            this.buttonCompression.Text = "圧縮";
            this.buttonCompression.UseVisualStyleBackColor = false;
            // 
            // folderBrowserDialogInput
            // 
            this.folderBrowserDialogInput.Description = "圧縮するファイルが格納されているフォルダのパスを指定してください";
            // 
            // folderBrowserDialogOutput
            // 
            this.folderBrowserDialogOutput.Description = "圧縮したファイルを出力するフォルダのパスを指定してください";
            // 
            // CompressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 614);
            this.Controls.Add(this.buttonCompression);
            this.Controls.Add(this.checkBoxOutptDirectoryPath);
            this.Controls.Add(this.buttonOutputDirectoryPathDialog);
            this.Controls.Add(this.textBoxOutputDirectoryPath);
            this.Controls.Add(this.labelOutputDirectoryPath);
            this.Controls.Add(this.comboBoxCompressionType);
            this.Controls.Add(this.labelCompressionType);
            this.Controls.Add(this.buttonTargetFileAllCancel);
            this.Controls.Add(this.buttonTargetFileAllSelect);
            this.Controls.Add(this.buttonTargetFileLoading);
            this.Controls.Add(this.listBoxTargetFiles);
            this.Controls.Add(this.labelTargetFiles);
            this.Controls.Add(this.buttonInputDeitectoryPathDialog);
            this.Controls.Add(this.textBoxInputDeitectoryPath);
            this.Controls.Add(this.labelInputInputDeitectoryPath);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompressionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ファイル圧縮";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputInputDeitectoryPath;
        private System.Windows.Forms.TextBox textBoxInputDeitectoryPath;
        private System.Windows.Forms.Button buttonInputDeitectoryPathDialog;
        private System.Windows.Forms.Label labelTargetFiles;
        private System.Windows.Forms.ListBox listBoxTargetFiles;
        private System.Windows.Forms.Button buttonTargetFileLoading;
        private System.Windows.Forms.Button buttonTargetFileAllSelect;
        private System.Windows.Forms.Button buttonTargetFileAllCancel;
        private System.Windows.Forms.Label labelCompressionType;
        private System.Windows.Forms.ComboBox comboBoxCompressionType;
        private System.Windows.Forms.Label labelOutputDirectoryPath;
        private System.Windows.Forms.Button buttonOutputDirectoryPathDialog;
        private System.Windows.Forms.TextBox textBoxOutputDirectoryPath;
        private System.Windows.Forms.CheckBox checkBoxOutptDirectoryPath;
        private System.Windows.Forms.Button buttonCompression;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
    }
}

