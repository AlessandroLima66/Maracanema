using Maracanema.Model;
using Maracanema.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Maracanema.View
{
    public partial class ViewCadastroPartida : ContentPage
    {
        public ViewCadastroPartida()
        {
            InitializeComponent();
            Partida partida = new Partida();
            partida.DtPartida = DateTime.Now;
            var viewModel = new PartidaViewModel(partida);
            viewModel.Navigation = this.Navigation;
            BindingContext = viewModel;

        }
    }
}
