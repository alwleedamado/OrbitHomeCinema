using OrbitHomeCinema.Models;
using System.Collections.ObjectModel;

namespace OrbitHomeCinema.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private ObservableCollection<ListItem> _items = [
        new ListItem(1, "Movies", Open)
    ,new ListItem(2, "Series", Open),
        new ListItem(3, "Podcasts", Open)];

    public static void Open()
    {

    }
}
