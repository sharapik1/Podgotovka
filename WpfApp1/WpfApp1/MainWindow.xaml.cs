using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    public partial class MainWindow : Window, INotifyPropertyChanged //добавляем интерфейс к окну
    {
        public List<City> CityList { get; set; }
        public string SelectedCity = "";
        public event PropertyChangedEventHandler PropertyChanged; //реализуем интерфейс
        private IEnumerable<Pokupateli> _PokupateliList = null;
        public IEnumerable<Pokupateli> PokupateliList
        {
            get
            {
                var res = _PokupateliList;
                 res=res.Where(c => (SelectedCity == "Все города" || c.City == SelectedCity));
                // если фильтр не пустой, то ищем ВХОЖДЕНИЕ подстроки поиска в кличке без учета регистра
                if (SearchFilter != "")
                    res = res.Where(c => c.Name.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                if (SortAsc) res = res.OrderBy(c => c.Summapokupki);
                else res = res.OrderByDescending(c => c.Summapokupki);
                return res;
            }
            set
            {
                _PokupateliList = value;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            PokupateliList = Globals.dataProvider.GetPokupatelis();
            CityList = Globals.dataProvider.GetCities().ToList();
            CityList.Insert(0, new City { Title = "Все города" });
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //изменился список покупателей, сообщает визуальной части
        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("PokupateliList"));
        }
        //вызов этого методач
        private void CityFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCity = (CityFilterComboBox.SelectedItem as City).Title;
            Invalidate();
        }
        private string SearchFilter = "";

        //В коде окна создаем переменную для хранения строки поиска и запоминаем её в обработчике ввода текста (SearchFilter_KeyUp)
        private void SearchFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTexBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }

    }
}
