using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
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
            new Group("B")
            {
                new Item { Title = "Bernier", Subtitle = "Montana" },
                new Item { Title = "Benites", Subtitle = "Luis" },
                new Item { Title = "Barcos", Subtitle = "Felipe" },
                new Item { Title = "Bendezú", Subtitle = "Adrian" }
            },
            new Group("C")
            {
                new Item { Title = "Casas", Subtitle = "Alejandro" },
                new Item { Title = "Chavez", Subtitle = "Miguel" },
                new Item { Title = "Chilon", Subtitle = "Christian" },
                new Item { Title = "Cantú", Subtitle = "Maycol" }
            },
            new Group("D")
            {
                new Item { Title = "Dominguez", Subtitle = "Alejandra" },
                new Item { Title = "Díaz", Subtitle = "Miguel" },
                new Item { Title = "Delgado", Subtitle = "Julio" },
                new Item { Title = "De la Cruz", Subtitle = "Bryan" }
            },
            };
            GroupedView.ItemsSource = Groups;
        }
    }
}