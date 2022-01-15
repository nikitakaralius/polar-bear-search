using Core.Search;

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
    }
}