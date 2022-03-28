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
    public class Calculadora:INotifyPropertyChanged
    {
        public ICommand? SumarCommand { get; set; }
        public ICommand? RestarCommand { get; set; }
        public ICommand? ResetearCommand { get; set; }

        public Calculadora()
        {
            SumarCommand = new RelayCommand(Sumar);
            RestarCommand = new RelayCommand(Restar);
            ResetearCommand = new RelayCommand(Resetear);
        }

        public int? PrimerNumerador { get; set; }
        public int? PrimerDenominador { get; set; }
        public int? SegundoNumerador { get; set; }
        public int? SegundoDenominador { get; set; }

        public int? Resultado1 { get; set; }
        public int? Resultado2 { get; set; }
        public void Resetear()
        {
            PrimerNumerador = 0;
            SegundoNumerador = 0;
            PrimerDenominador = 0;
            SegundoDenominador = 0;
            Resultado1 = 0;
            Resultado2 = 0;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
        public void Sumar()
        {
                Resultado1 = (PrimerNumerador * SegundoDenominador) + (PrimerDenominador * SegundoNumerador);
                Resultado2 = PrimerDenominador * SegundoDenominador;
                if(PrimerDenominador == SegundoDenominador)
                {
                    Resultado1 = (PrimerNumerador + SegundoNumerador);
                    Resultado2 = PrimerDenominador;
                }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public void Restar()
        {

                Resultado1 = (PrimerNumerador * SegundoDenominador) - (PrimerDenominador * SegundoNumerador);
                Resultado2 = (PrimerDenominador * SegundoDenominador);
                if (PrimerDenominador == SegundoDenominador)
                {
                    Resultado1 = (PrimerNumerador  -  SegundoNumerador);
                    Resultado2 = PrimerDenominador;
                }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

