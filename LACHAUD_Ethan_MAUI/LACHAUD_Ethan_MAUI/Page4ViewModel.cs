using System.ComponentModel;

public class Page4ViewModel : INotifyPropertyChanged
{
    private List<string> _images;
    public List<string> Images
    {
        get { return _images; }
        set
        {
            _images = value;
            OnPropertyChanged(nameof(Images));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public Page4ViewModel()
    {
        Images = new List<string>
        {
            "image1.png",
            "bigmoustache.jpg",
            "hmm.png",
            "rocheposay.jpg",
            "earth.jpg"
        };
    }
}