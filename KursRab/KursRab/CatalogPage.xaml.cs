using Xamarin.Forms;

namespace KursRab
{
    public partial class CatalogPage : ContentPage
    {
        public CatalogPage()
        {
            InitializeComponent();
        }
    }
    public class CarouselItem
    {
        public string ImageSource { get; set; }
        public string Description { get; set; }
    }
}