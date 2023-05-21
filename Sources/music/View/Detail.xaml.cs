using music.Stub;
using music.Model;
namespace music.View;

public partial class Detail : ContentPage
{
	public List<Musiclist> musique = new stub().musique;

    public Detail()
	{
		InitializeComponent();
		DataList.ItemsSource = musique;
	}
}
