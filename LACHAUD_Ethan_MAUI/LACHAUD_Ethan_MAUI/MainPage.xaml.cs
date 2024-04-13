namespace LACHAUD_Ethan_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            var image1 = (Image)FindByName("image1");
            var image2 = (Image)FindByName("image2");
            var gifImage = (Image)FindByName("gif");
            var button = (Button)FindByName("rotation");
            if (gifImage.IsVisible)
            {
                button.IsVisible = true;
                gifImage.IsVisible = false;
                image1.IsVisible = true;
                image2.IsVisible = true;
            }
            else
            {
                button.IsVisible = false;
                gifImage.IsVisible = true;
                image1.IsVisible = false;
                image2.IsVisible = false;
            }
        }
        
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            
            var image1 = (Image)FindByName("image1");
            var image2 = (Image)FindByName("image2");
            
            
            image1.RotateTo(360, 2000);
            image2.RotateTo(360, 2000);
            
            
        }
        
    }

}
