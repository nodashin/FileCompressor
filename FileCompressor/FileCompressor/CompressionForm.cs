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
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompressionForm_Load(object sender, EventArgs e)
        {
            this.comboBoxCompressionType.SelectedIndex = 0;
        }

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
            if (!CanTargetFileLoad())
                return;

            this.SetTargetFiles();
        }

        /// <summary>
        /// 圧縮ファイル全選択Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonTargetFileAllSelect_Click(object sender, EventArgs e)
        {
            this.SetAllTargetFilesSelectionState(true);
        }

        /// <summary>
        /// 圧縮ファイル全解除Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonTargetFileAllCancel_Click(object sender, EventArgs e)
        {
            this.SetAllTargetFilesSelectionState(false);
        }

        /// <summary>
        /// 圧縮ファイル出力先フォルダパス参照Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonOutputDirectoryPathDialog_Click(object sender, EventArgs e)
        {
            this.ShowDialogAndSetPath(this.folderBrowserDialogOutput, this.textBoxOutputDirectoryPath);
        }

        /// <summary>
        /// 同じパスへの出力Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void checkBoxOutptDirectoryPath_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxOutputDirectoryPath.Enabled = !this.checkBoxOutptDirectoryPath.Checked;
        }

        /// <summary>
        /// 圧縮Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonCompression_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
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

        /// <summary>
        /// 圧縮するファイルを指定した選択状態にする。
        /// </summary>
        /// <param name="isSelected">選択有無</param>
        void SetAllTargetFilesSelectionState(bool isSelected)
        {
            for (int i = 0; i < this.listBoxTargetFiles.Items.Count; i++)
                this.listBoxTargetFiles.SetSelected(i, isSelected);
        }

        #region エラーチェック
        /// <summary>
        /// 対象ファイルロード可能か。
        /// </summary>
        /// <returns>可否</returns>
        bool CanTargetFileLoad()
        {
            if (this.textBoxInputDirectoryPath.Text.Length == 0)
            {
                this.ShowErrorMessage($"{this.labelInputInputDirectoryPath.Text}未入力");
                return false;
            }
            return true;
        } 
        #endregion
        

        #region メッセージ
        /// <summary>
        /// エラーメッセージを表示する。
        /// </summary>
        /// <param name="message">メッセージ</param>
        void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #endregion

    }
}
