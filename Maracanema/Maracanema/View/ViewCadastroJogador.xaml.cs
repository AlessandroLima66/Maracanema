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
    public partial class ViewCadastroJogador : ContentPage
    {
        public ViewCadastroJogador()
        {
            InitializeComponent();
            Jogador jogador = new Jogador();
            jogador.DtNascimento = DateTime.Now;
            jogador.NmPosicao = "Atacante";
            var viewModel = new JogadorViewModel(jogador);
            viewModel.Navigation = this.Navigation;
            BindingContext = viewModel;
        }
    }
}
