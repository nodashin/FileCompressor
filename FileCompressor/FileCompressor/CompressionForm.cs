using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCompressor
{
    /// <summary>
    /// 圧縮Form
    /// </summary>
    public partial class CompressionForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CompressionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 圧縮ファイル格納フォルダパス参照Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonInputDeitectoryPathDialog_Click(object sender, EventArgs e)
        {
            this.ShowDialogAndSetPath(this.folderBrowserDialogInput, this.textBoxInputDirectoryPath);
        }

        /// <summary>
        /// FolderBrowserDialogを表示し、パスを設定する。
        /// </summary>
        /// <param name="dialog">FolderBrowserDialog</param>
        /// <param name="pathTextBox">パスを設定するTextBox</param>
        void ShowDialogAndSetPath(FolderBrowserDialog dialog, TextBox pathTextBox)
        {
            dialog.SelectedPath = pathTextBox.Text;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            pathTextBox.Text = dialog.SelectedPath;
        }
    }
}
