namespace MobileAppDevPT20231201
{
    public partial class MainPage : ContentPage
    {
        public List<Item> Items { get; set; }
        public MainPage()
        {
            InitializeComponent();
            List<Item> items = new List<Item>
            {
                new Item
                {
                    Image = "img3.jpg",
                    Title = "Peach Tree in Blossom",
                    Price = "$950,000"
                },
                new Item
                {
                    Image = "img2.jpg",
                    Title = "Cafe Terrace at Night",
                    Price = "$1,920,000"
                }
            };
            Items = items;

            BindingContext = this;
        }

        public class Item
        {
            public string Image { get; set; }
            public string Title { get; set; }
            public string Price { get; set; }
        }
    }
}