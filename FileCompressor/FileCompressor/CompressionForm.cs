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

        #region イベント
        /// <summary>
        /// 圧縮ファイル格納フォルダパス参照Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonInputDeitectoryPathDialog_Click(object sender, EventArgs e)
        {
            if(!this.ShowDialogAndSetPath(this.folderBrowserDialogInput, this.textBoxInputDirectoryPath))
                return;
            this.SetTargetFiles();
        }

        /// <summary>
        /// 圧縮ファイルロードButton_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonTargetFileLoading_Click(object sender, EventArgs e)
        {
            if (this.textBoxInputDirectoryPath.Text.Length == 0)
            {
                MessageBox.Show($"{this.labelInputInputDirectoryPath.Text}未入力");
                return;
            }
            this.SetTargetFiles();
        }
        #endregion

        #region メソッド
        /// <summary>
        /// FolderBrowserDialogを表示し、パスを設定する。
        /// </summary>
        /// <param name="dialog">FolderBrowserDialog</param>
        /// <param name="pathTextBox">パスを設定するTextBox</param>
        /// <returns>パス設定有無</returns>
        bool ShowDialogAndSetPath(FolderBrowserDialog dialog, TextBox pathTextBox)
        {
            dialog.SelectedPath = pathTextBox.Text;
            if (dialog.ShowDialog() != DialogResult.OK)
                return false;

            pathTextBox.Text = dialog.SelectedPath;
            return true;
        }

        /// <summary>
        /// 対象ファイルを設定する。
        /// </summary>
        void SetTargetFiles()
        {
            this.listBoxTargetFiles.DataSource = new FileLoader(this.textBoxInputDirectoryPath.Text).LoadFiles().ToList();
        }
        #endregion
    }
}
