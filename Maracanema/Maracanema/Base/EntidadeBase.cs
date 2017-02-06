using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maracanema.Base
{
    public class EntidadeBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void Notificacao([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null && string.IsNullOrEmpty(propertyName))
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
