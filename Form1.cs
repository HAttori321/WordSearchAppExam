using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDirectoryPath.Text = folderDialog.SelectedPath;
                }
            }
        }
        private async void btnStartSearch_Click(object sender, EventArgs e)
        {
            string directoryPath = txtDirectoryPath.Text;
            string searchWord = txtSearchWord.Text;

            if (string.IsNullOrEmpty(directoryPath) || string.IsNullOrEmpty(searchWord))
            {
                MessageBox.Show("Будь ласка введіть шлях до директорії та слово для пошуку");
                return;
            }
            dataGridViewResults.Rows.Clear();
            progressBar.Value = 0;

            var progress = new Progress<int>(value =>
            {
                progressBar.Value = value;
            });

            try
            {
                var results = await SearchWordInFilesWithProgressAsync(directoryPath, searchWord, progress);
                foreach (var result in results)
                {
                    dataGridViewResults.Rows.Add(result.FileName, result.FilePath, result.WordCount);
                }
                MessageBox.Show("Пошук завершено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message);
            }
        }
        private async Task<List<SearchResult>> SearchWordInFilesWithProgressAsync(string directoryPath, string searchWord, IProgress<int> progress)
        {
            List<SearchResult> results = new List<SearchResult>();
            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            int totalFiles = files.Length;
            int processedFiles = 0;

            foreach (var file in files)
            {
                int wordCount = await Task.Run(() => CountWordInFile(file, searchWord));
                results.Add(new SearchResult { FileName = Path.GetFileName(file), FilePath = file, WordCount = wordCount });

                processedFiles++;
                int percentage = (processedFiles * 100) / totalFiles;
                progress?.Report(percentage);
            }

            return results;
        }
        private int CountWordInFile(string filePath, string searchWord)
        {
            int count = 0;
            try
            {
                string content = File.ReadAllText(filePath);

                count = content.Split(new string[] { searchWord }, StringSplitOptions.None).Length - 1;
            }
            catch (Exception)
            {

            }

            return count;
        }
    }

    public class SearchResult
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int WordCount { get; set; }
    }
}
