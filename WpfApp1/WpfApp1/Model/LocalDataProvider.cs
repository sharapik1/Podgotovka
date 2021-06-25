using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Pokupateli> GetPokupatelis()
        {
            return new Pokupateli[]
            {
                new Pokupateli{Name="Екатерина Шарапова", Age=20, City="Йошкар-Ола", Summapokupki=2323.87, Data= new DateTime(2021,08,09), Magazin="Пятерочка" },
                new Pokupateli{Name="Александра Шарапова", Age=28, City="Москва", Summapokupki=45563.10, Data= new DateTime(2021,10,10), Magazin="ЦУМ" },
                new Pokupateli{Name="Мария Шарапова", Age=40, City="Казань", Summapokupki=1003.99, Data= new DateTime(2020,12,12), Magazin="Спортмастер" },
            };
        }
        
            public IEnumerable<City> GetCities()
            {
                return new City[]
                {
                new City { Title="Йошкар-Ола"},
                new City { Title="Москва"},
                new City { Title="Уфа"},
                };
            }
    }
}
