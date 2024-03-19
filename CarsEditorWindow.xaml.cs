using System.Linq;
using System.Windows;

namespace laba2ef
{
    public partial class CarsEditorWindow : Window
    {
        private lab1Entities lab1Entities = new lab1Entities();
        public CarsEditorWindow()
        {
            InitializeComponent();
            CarsDataGrid.ItemsSource = lab1Entities.cars.ToList();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            CarsDataGrid.ItemsSource = lab1Entities.cars.ToList().Where(item => item.model.Contains(searchBox.Text));
            ResetTextBoxes();
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            var searchtext = searchBox.Text;
            searchtext = searchtext.ToUpper();
            CarsDataGrid.ItemsSource = lab1Entities.cars.ToList().Where(item => item.number.Contains(searchtext));
            ResetTextBoxes();
        }

        private void colorButton_Click(object sender, RoutedEventArgs e)
        {
            var searchtext = searchBox.Text;
            searchtext = searchtext.ToLower();
            CarsDataGrid.ItemsSource = lab1Entities.cars.ToList().Where(item => item.color.Contains(searchtext));
            ResetTextBoxes();
        }

        private void ResetTextBoxes()
        {
            searchBox.Text = string.Empty;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            CarsDataGrid.ItemsSource = lab1Entities.cars.ToList();
            ResetTextBoxes();
        }

        /*
        
        private void createButton_Click(object sender, RoutedEventArgs e)
        {
           cars car = new cars();
           car.model = modelBox.Text;
           car.number = numberBox.Text;
           car.color = colorBox.Text;
           lab1Entities.cars.Add(car);
           SaveChanges();
           ResetTextBoxes();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
           if (CarsDataGrid != null)
           {
               var selected = CarsDataGrid.SelectedItem as cars;
               selected.model = modelBox.Text;
               selected.number = numberBox.Text;
               selected.color = colorBox.Text;
               SaveChanges();
           }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
           if(CarsDataGrid != null)
           {
               lab1Entities.cars.Remove(CarsDataGrid.SelectedItem as cars);
               SaveChanges();
               ResetTextBoxes();
           }
        }

        private void SaveChanges()
        {
           lab1Entities.SaveChanges();
           CarsDataGrid.ItemsSource = lab1Entities.cars.ToList();
        }

        private void ResetTextBoxes()
        {
           modelBox.Text = string.Empty;
           numberBox.Text = string.Empty;
           colorBox.Text = string.Empty;
        }

        */
    }
}
