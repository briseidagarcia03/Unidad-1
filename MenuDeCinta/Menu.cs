using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MenuDeCinta
{
    public class Menu
    {
        public ICommand? TableroDeportivoCommand { get; set; }
        public ICommand? AprendeBinarioCommand { get; set; }
        public ICommand? ContadorDigitalCommand { get; set; }
        public ICommand? FraccionesCommand { get; set; }

        public Menu()
        {
            TableroDeportivoCommand = new RelayCommand(TableroDep);
            AprendeBinarioCommand = new RelayCommand(AprendeBinario);
            ContadorDigitalCommand = new RelayCommand(Contador);
            FraccionesCommand = new RelayCommand(CalculadoraFracciones);
        }

        public static void TableroDep()
        {
            TableroWpf tablero = new TableroWpf();
            tablero.Show();
        }
        public static void Contador()
        {
            Contadorwpf contador = new Contadorwpf();
            contador.Show();
        }

        public static void AprendeBinario()
        {
            Binariowpf binario = new Binariowpf();
            binario.Show();
        }

        public static void CalculadoraFracciones()
        {
            Calculadorawpf calculadora = new Calculadorawpf();
            calculadora.Show();
        }
    }
}
