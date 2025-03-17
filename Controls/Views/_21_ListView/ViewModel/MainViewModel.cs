using System.Collections.ObjectModel;
using _21_ListView.Model;

namespace _21_ListView.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<GroceryItem>? GI { get; set; }

        public MainViewModel() {
            
            // Start with an empty collection so adding items it can store
            GI = [];
        }
    }
}
