using _19real.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _19real.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();
        public Main()
        {
            InitializeComponent();
            items.Add(new Item("Шакаф", 20000, "shakaf.png"));

            items.Add(new Item("ВК", 6767, "vk.png"));
            items.Add(new Item("ТГ", 999999, "telegramm.png"));
            items.Add(new Item("Ничего", 20000, ""));
            items.Add(new Item("Инстаграм", 676767, "instagram.png"));
            items.Add(new Item("тоже ничего", 0, ""));
            LoadItems();
        }


        public void LoadItems()
        {
            foreach (Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
