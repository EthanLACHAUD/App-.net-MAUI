using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LACHAUD_Ethan_MAUI;

public partial class Page4 : ContentPage
{
    public Page4()
    {
        InitializeComponent();
        BindingContext = new Page4ViewModel();
    }
    
    private int clickCount = 0;

    public void OnButtonClicked(object sender, EventArgs e)
    {
        clickCount++;
        clickerButton.Text = clickCount.ToString();
    } 
}