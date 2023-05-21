using music.Stub;
using music.Model;


namespace music.View;

public partial class PagePrincpl : ContentPage
{
    public List<Podcaste> podcastes = new stubtwo().podcastes;
    public PagePrincpl()
	{
		InitializeComponent();
        Data.ItemsSource = podcastes;

    }
}
