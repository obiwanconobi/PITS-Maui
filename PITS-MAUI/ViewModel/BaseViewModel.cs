using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PITS_MAUI.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string title;
        bool isBusy;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;

                isBusy = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
