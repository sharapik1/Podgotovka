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

namespace WpfLibrary3.Model
{
    public class LocalDataProvider : IDataProvide
    {
        public IEnumerable<pokipateli> GetPokipatelis()
        {
            return new pokipateli[]
            {
                new pokipateli{Name="Сергей", Familia="Смирнов", Age=32, Symmapokipok=6767.54, Data=new DateTime(2021,05,21), City="Йошкар-Ола" },
                new pokipateli{Name="Тимур", Familia="Пирождок", Age=17, Symmapokipok=99999.99, Data=new DateTime(2021,07,02), City="Казань"},
                new pokipateli{Name="Екатерина", Familia="Шарапова", Age=17, Symmapokipok=99999.99, Data=new DateTime(2021,08,21), City="Нижнекамск"}
            };
        }
    }
}
