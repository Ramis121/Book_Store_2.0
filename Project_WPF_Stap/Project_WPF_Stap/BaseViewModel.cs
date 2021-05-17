using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_WPF_Stap
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected bool SetValue<T>(ref T value, T newValue, [CallerMemberName] string property = null)
        {
            if (!EqualityComparer<T>.Default.Equals(value, newValue))
            {
                value = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
                return true;
            }
            return false;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
