using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
        {
            new Group("Familia")
            {
                new Item { Title = "Adriana Olivera", Subtitle = "977703415" },
                new Item { Title = "Basilio Marques", Subtitle = "900814776" },
                new Item { Title = "Ali Cerezo", Subtitle = "975982719" },
                new Item { Title = "Sergi Giraldo", Subtitle = "922994019" }
            },
            new Group("Amigos")
            {
                new Item { Title = "Lola Carvajal", Subtitle = "914305753" },
                new Item { Title = "Noemi Fariña", Subtitle = "959363619" },
                new Item { Title = "Rafael Quiles", Subtitle = "970570744" },
                new Item { Title = "Marian Balaguer", Subtitle = "996827899" }
            },
            new Group("Bloqueados")
            {
                new Item { Title = "Eneko Bonet", Subtitle = "918771374" },
                new Item { Title = "Antia Martin", Subtitle = "959316405" },
                new Item { Title = "Oriol Falcon", Subtitle = "922538002" },
                new Item { Title = "Maria-Cecilia Peris", Subtitle = "996952896" }
            },
        };
            GroupedView.ItemsSource = Groups;
        }
    }
}