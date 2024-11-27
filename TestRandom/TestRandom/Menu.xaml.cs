using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

namespace TestRandom
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            Menuitem[] menuItems = new Menuitem[5];
            string guacomolePrice;
            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new Menuitem();
                if (i >= 0)
                {
                    menuItems[i].Breads = new string[]
                    {"Plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" };
                }

                menuItems[i].Generate();
            }

            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Description;
            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Description;
            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Description;
            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Description;
            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Description;
            Menuitem specialMenuItem = new Menuitem()
            {
                Proteins = new string[] { "Organic ham ", "Mushroom patty", "Mortadella" },
                Breads = new string[]{"a gluten free roll", "a wrap", "pita"},
                Condiments =new string[]{"dijon mustard", "miso dressing", "au jus"}
            };
            specialMenuItem.Generate();
            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            Menuitem guacamleMenuItem = new Menuitem();
            guacamleMenuItem.Generate();
            guacomolePrice = guacamleMenuItem.Price;
            guacamole.Text = "Add guacamole for " + guacomolePrice;
        }
    }
}
