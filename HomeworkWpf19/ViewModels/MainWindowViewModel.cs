using HomeworkWpf19.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeworkWpf19.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }
        private double lenght;
        public double Lenght
        {
            get => lenght;
            set
            {
                lenght = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalcCommand { get; }
        private void OnCalcCommandExecute(object p)
        {
            Lenght = Calculation.Calc(Radius);
        }
        private bool CanCalcCommandExecuted(object p)
        {
            return true;
        }
        public MainWindowViewModel()
        {
            CalcCommand = new RelayCommand(OnCalcCommandExecute, CanCalcCommandExecuted);
        }

    }
}
