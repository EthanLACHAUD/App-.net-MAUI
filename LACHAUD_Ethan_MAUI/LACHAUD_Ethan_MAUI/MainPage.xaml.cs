namespace LACHAUD_Ethan_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        //affiche remplace les deux images par un gif avec un bouton
        private void Button_Clicked(object sender, EventArgs e)
        {
            var image1 = (Image)FindByName("image1");
            var image2 = (Image)FindByName("image2");
            var gifImage = (Image)FindByName("gif");
            //affiche le gif
            gifImage.IsVisible = true;
            //cache les deux images
            image1.IsVisible = false;
            image2.IsVisible = false;
        }
        
    }

}
