namespace WordSearchApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDirectoryPath = new TextBox();
            btnSelectDirectory = new Button();
            txtSearchWord = new TextBox();
            btnStartSearch = new Button();
            progressBar = new ProgressBar();
            dataGridViewResults = new DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            FilePath = new DataGridViewTextBoxColumn();
            WordCount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // txtDirectoryPath
            // 
            txtDirectoryPath.Location = new Point(52, 26);
            txtDirectoryPath.Multiline = true;
            txtDirectoryPath.Name = "txtDirectoryPath";
            txtDirectoryPath.Size = new Size(690, 47);
            txtDirectoryPath.TabIndex = 0;
            // 
            // btnSelectDirectory
            // 
            btnSelectDirectory.Location = new Point(143, 79);
            btnSelectDirectory.Name = "btnSelectDirectory";
            btnSelectDirectory.Size = new Size(511, 23);
            btnSelectDirectory.TabIndex = 1;
            btnSelectDirectory.Text = "Choose a directory";
            btnSelectDirectory.UseVisualStyleBackColor = true;
            btnSelectDirectory.Click += btnSelectDirectory_Click;
            // 
            // txtSearchWord
            // 
            txtSearchWord.Location = new Point(52, 118);
            txtSearchWord.Multiline = true;
            txtSearchWord.Name = "txtSearchWord";
            txtSearchWord.Size = new Size(690, 41);
            txtSearchWord.TabIndex = 2;
            // 
            // btnStartSearch
            // 
            btnStartSearch.Location = new Point(143, 165);
            btnStartSearch.Name = "btnStartSearch";
            btnStartSearch.Size = new Size(511, 23);
            btnStartSearch.TabIndex = 3;
            btnStartSearch.Text = "Start Search";
            btnStartSearch.UseVisualStyleBackColor = true;
            btnStartSearch.Click += btnStartSearch_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(52, 217);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(690, 23);
            progressBar.TabIndex = 4;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Columns.AddRange(new DataGridViewColumn[] { FileName, FilePath, WordCount });
            dataGridViewResults.Location = new Point(52, 267);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(690, 150);
            dataGridViewResults.TabIndex = 5;
            // 
            // FileName
            // 
            FileName.HeaderText = "FileName";
            FileName.Name = "FileName";
            // 
            // FilePath
            // 
            FilePath.HeaderText = "FilePath";
            FilePath.Name = "FilePath";
            // 
            // WordCount
            // 
            WordCount.HeaderText = "WordCount";
            WordCount.Name = "WordCount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(dataGridViewResults);
            Controls.Add(progressBar);
            Controls.Add(btnStartSearch);
            Controls.Add(txtSearchWord);
            Controls.Add(btnSelectDirectory);
            Controls.Add(txtDirectoryPath);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDirectoryPath;
        private Button btnSelectDirectory;
        private TextBox txtSearchWord;
        private Button btnStartSearch;
        private ProgressBar progressBar;
        private DataGridView dataGridViewResults;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewTextBoxColumn WordCount;
    }
}
