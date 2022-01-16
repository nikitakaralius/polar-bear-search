using Core.Api;
using Core.Extensions;
using Core.Search;
using Microsoft.Extensions.Configuration;

namespace Core
{
    public partial class MainForm : Form
    {
        private readonly IHighlightSearch _search;

        public MainForm(IHighlightSearch search)
        {
            _search = search;
            InitializeComponent();
        }

        private async void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Images | *.png; *.jpg; *.JPEG; *.bmp"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (openFileDialog.SafeFileName is null)
            {
                return;
            }
            (bool found, Image? image) = await _search.SearchOnAsync(openFileDialog.FileName);
            if (found)
            {
                PictureBox.RefreshWith(image);
            }
            else
            {
                MessageBox.Show("Bear was not found ☹");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image is null)
            {
                return;
            }
            SaveFileDialog saveFileDialog = new()
            {
                FileName = "Bear",
                Filter = "*.JPG | *.JPG;"
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            PictureBox.Image.Save(saveFileDialog.FileName);
        }
    }
}