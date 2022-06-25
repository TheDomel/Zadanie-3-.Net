using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3.Net
{
    public class Album : INotifyPropertyChanged
    {

        static private readonly Dictionary<string, string[]> powiązaneWłaściwości
            = new Dictionary<string, string[]>()
            {
                ["Tytuł"] = new string[] { "Info"},
                ["Autor"] = new string[] { "Info"},
                ["Wydawca"] = new string[] { "Info"},
                ["Nośnik"] = new string[] { "Info"},
                ["DataWydania"] = new string[] { "Info" },
            };
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(
            [CallerMemberName] string daneUtworu = null,
            HashSet<string> gotoweDaneUtworu = null
            )
        {
            if (gotoweDaneUtworu == null)
                gotoweDaneUtworu = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(daneUtworu));
            gotoweDaneUtworu.Add(daneUtworu);
            if (powiązaneWłaściwości.ContainsKey(daneUtworu))
                foreach (string powiązanaWłaściwość in powiązaneWłaściwości[daneUtworu])
                    if (!gotoweDaneUtworu.Contains(powiązanaWłaściwość))
                        OnPropertyChanged(powiązanaWłaściwość, gotoweDaneUtworu);
        }

        string tytuł;
        string autor;
        string wydawca;
        string nośnik;
        DateTime? dataWydania;

        public string Tytuł
        {
            get
            {
                return tytuł;
            }
            set
            {
                tytuł = value;
                OnPropertyChanged();
            }
        }

        public string Autor
        {
            get { return autor; }

            set
            {
                autor = value;
                OnPropertyChanged();
            }
        }

        public string Wydawca
        {
            get
            {
                return wydawca;
            }
            set
            {
                wydawca = value;
                OnPropertyChanged();
            }
        }

        public string Nośnik
        {
            get
            {
                return nośnik;
            }
            set
            {
                nośnik = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataWydania
        {
            get
            {
                return dataWydania;
            }
            set
            {
                dataWydania = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return $"Tytuł: {Tytuł}, Autor: {Autor}, Wydawca: {Wydawca}, Nośnik: {Nośnik}, Data Wydania: {DataWydania}";
        }

        public string Info
        {
            get
            {
                return $"Tytuł: {Tytuł}, Autor: {Autor}, Wydawca: {Wydawca}, Nośnik: {Nośnik}, Data Wydania: {DataWydania}";
            }
        }
    }
}