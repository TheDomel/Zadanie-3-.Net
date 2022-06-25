using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3.Net
{
    class Dane
    {
        public ObservableCollection<Album> Albumy { get; } = new ObservableCollection<Album>()
        {
            new Album()
            {
                Tytuł = "Mateusz", Autor = "Szpaku", Wydawca = "GUGU", Nośnik = "Płyta CD",
                DataWydania = Convert.ToDateTime("2022.02.28")
            },
            new Album()
            {
                Tytuł = "Piękny świat", Autor = "Gibbs x Kiełas", Wydawca = "DOPEHOUSE RECORDS", Nośnik = "Płyta CD",
                DataWydania = Convert.ToDateTime("2022.05.20")
            },
            new Album()
            {
                Tytuł = "Ostatni raz zatańczysz ze mną", Autor = "Tribbs ft. Kubańczyk", Wydawca = "Tribs",
                Nośnik = "streaming",
                DataWydania = Convert.ToDateTime("2022.05.20")
            }

        };

        public Album Nowy()
        {
            Album nowy = new Album();
            Albumy.Add(nowy);
            return nowy;
        }
    }


}
