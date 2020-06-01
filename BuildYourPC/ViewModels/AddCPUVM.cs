using BuildYourPC.Database;
using BuildYourPC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BuildYourPC.ViewModels
{
    public class AddCPUVM : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private CPU _CPU;
        public CPU NewCPU 
        {
            get => _CPU;
            set
            {
                _CPU = value;
                OnPropertyChanged(nameof(NewCPU));
            }
        }
        public AddCPUVM()
        {
            NewCPU = new CPU();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
