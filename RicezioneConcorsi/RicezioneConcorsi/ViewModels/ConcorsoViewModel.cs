using RicezioneConcorsi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RicezioneConcorsi.ViewModels
{
    class ConcorsoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string username;

        private List<Concorso> concorsi = new List<Concorso>();

        public Command Ricerca { get; }

        public List<Concorso> Concorsi
        {
            get
            {
                return concorsi;
            }
            set
            {
                concorsi = new List<Concorso>(value);
                OnPropertychanged();
            }
        }

        public ConcorsoViewModel()
        {
            Ricerca = new Command(AvviaRicerca);
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertychanged();
            }
        }
        private async void AvviaRicerca()
            
        {
            REST<Concorso> x = new REST<Concorso>();
            Dati.Instance.Username = username;
            Concorso ciao = new Concorso(5,"ricchio");
          //  Concorsi =  await REST<Concorso>.GetJson("http://192.168.125.12/concorsi.php");
            Concorsi = await x.PostJson("http://192.168.125.12/concorsi.php",ciao);
            if (Concorsi.Count == 0)
            {
                Username = x.warning;
            }
        }

        private void OnPropertychanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
