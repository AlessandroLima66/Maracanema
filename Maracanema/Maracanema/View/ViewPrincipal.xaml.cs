using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Maracanema.View
{
    public partial class ViewPrincipal : ContentPage
    {
        public ViewPrincipal()
        {
            InitializeComponent();
        }

        protected void OnJogador(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewListaJogador());
        }

        protected void OnPartida(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewListaPartida());
        }


    }
}
