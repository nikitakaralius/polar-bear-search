using Core.Common;
using Core.Extensions;
using Core.Search;
using Core.ViewModels;

namespace Core
{
    public partial class MainForm : Form
    {
        private readonly IHighlightSearch _search;

        public MainForm(IHighlightSearch search)
        {
            InitializeComponent();
            _search = new LabeledSearch(search, SearchingLabel);
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
            Maybe<Image> bearOnImage = await _search.SearchOnAsync(openFileDialog.FileName);
            if (bearOnImage.HasValue)
            {
                PictureBox.Replace(bearOnImage.Value);
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