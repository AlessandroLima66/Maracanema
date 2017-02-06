using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using Xamarin.Forms;

namespace Maracanema.Base
{
    public abstract class ViewModelBase<T> : INotifyPropertyChanged
        where T : class, new()
    {

        private T _entidade;

        public INavigation Navigation
        {
            get;
            set;
        }

        public IMessage Mensagem
        {
            get;
            set;
        }

        public T EntidadeAtual
        {
            get { return _entidade; }
            set { _entidade = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notificacao<T>(Expression<System.Func<T>> expression)
        {
            var member = expression.Body as MemberExpression;
            var propertyInfo = member.Member as PropertyInfo;

            if (propertyInfo != null)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyInfo.Name));
                }
            }

        }


    }
}
