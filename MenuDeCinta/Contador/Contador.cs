using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MenuDeCinta
{
    public class Contador:INotifyPropertyChanged
    {
        int contador;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand SubeCommand { get; set; }
        public ICommand BajaCommand { get; set; }
        public ICommand ReseteaCommand { get; set; }

        public int Contadorr
        {
            get { return contador; }
            set
            {
                contador = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public Contador()
        {
            SubeCommand = new RelayCommand(Sube);
            BajaCommand = new RelayCommand(Baja);
            ReseteaCommand = new RelayCommand(Reinicio);
        }
        public void Sube()
        {
            if(contador >= 999)
            {
                contador = 0;  
            }
            
            contador++;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public void Baja()
        {
            if(contador == 0)
            {
                contador = 0;    
            }
            else
            {
                contador--;
            }
  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public void Reinicio()
        {
            contador = 0;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }

}
