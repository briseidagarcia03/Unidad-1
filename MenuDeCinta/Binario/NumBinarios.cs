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
    public class NumBinarios:INotifyPropertyChanged
    {
        int numero;
      
        public ICommand GenerarCommand { get; set; }
        public ICommand VerificarCommand { get; set; }
        public string NumBinario 
        {
            get { return Convert.ToString(numero, 2); } 
        }
        
        public int? Valor { get; set; }
        public bool Iniciar { get; set; }
        public bool? Jugar { get; set; }
        public bool Mensaje { get; set; }

     

        public NumBinarios()
        {
            GenerarCommand = new RelayCommand(GenerarNumBinario);
            VerificarCommand = new RelayCommand(Verificar);
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        public void GenerarNumBinario()
        {
          
              Random r = new();
              numero = r.Next(1, 255);
              Iniciar = true;
              Mensaje = false;
              Valor = null;
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            
        }

        public void Verificar()
        {
            
                if (Valor == numero)
                {
                    Jugar = false;
                    Iniciar = false;
                   
                }
                else
                {
                    Jugar = true;
                    
                }

                Mensaje = true;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));

        }

        
    }
}
