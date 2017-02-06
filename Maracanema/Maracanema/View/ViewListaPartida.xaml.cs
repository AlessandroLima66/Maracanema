using Maracanema.ViewModel;

using Xamarin.Forms;

namespace Maracanema.View
{
    public partial class ViewListaPartida : ContentPage
    {
        public ViewListaPartida()
        {
            InitializeComponent();
            var viewModel = new PartidaViewModel();
            viewModel.Navigation = this.Navigation;
            BindingContext = viewModel;
        }
    }
}
