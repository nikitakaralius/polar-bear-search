using Core.Common;
using Core.Extensions;
using Core.IO;
using Core.Search;
using Core.ViewModels;

namespace Core
{
    public partial class MainForm : Form
    {
        private readonly IHighlightSearch _search;
        private readonly IDialogFilter _dialogFilter;

        public MainForm(IHighlightSearch search, IDialogFilter dialogFilter)
        {
            _dialogFilter = dialogFilter;
            InitializeComponent();
            _search = new LabeledSearch(search, SearchingLabel);
        }

        private async void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = _dialogFilter.OfOpen
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (openFileDialog.FileName is null)
            {
                return;
            }
            Maybe<Image> bearOnImage = await _search.BearOnImageAsync(openFileDialog.FileName);
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
                Filter = _dialogFilter.OfSave
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            PictureBox.Image.Save(saveFileDialog.FileName);
        }
    }
}