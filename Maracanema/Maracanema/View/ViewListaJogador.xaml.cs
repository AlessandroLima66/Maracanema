using Maracanema.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Maracanema.View
{
    public partial class ViewListaJogador : ContentPage
    {
        public ViewListaJogador()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var viewModel = new JogadorViewModel();
            viewModel.Navigation = this.Navigation;
            BindingContext = viewModel;
        }

    }


}
