using Maracanema.Base;
using Maracanema.DataService;
using Maracanema.Model;
using Maracanema.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Maracanema.ViewModel
{
    public class PartidaViewModel : ViewModelBase<Partida>
    {
        private PartidaDataService _servico;

        public ObservableCollection<Partida> Partidas
        {
            get;
        }

        public INavigation Navigation
        {
            get;
            set;
        }

        public ICommand _salvarCommand
        {
            get;
            set;
        }

        public ICommand _excluirCommand
        {
            get;
            set;
        }

        public ICommand _abrirCadastro
        {
            get;
            set;
        }


        public PartidaViewModel()
        {
            _servico = new PartidaDataService();
            Partidas = new ObservableCollection<Partida>();
            CarregarLista();
        }

        public PartidaViewModel(Partida partida)
            :this()
        {
            _servico = new PartidaDataService();
            EntidadeAtual = partida;
        }

        public void CarregarLista()
        {
            var lista = _servico.listar();
            if(lista != null)
            {
                foreach(var itens in lista)
                {
                    Partidas.Add(itens);
                }
            }
        }

        public ICommand AbrirCadastroCommand
        {
            get
            {
                return _abrirCadastro ?? (_abrirCadastro = new Command(() =>
                {
                    Navigation.PushAsync(new ViewCadastroPartida());
                }));
            }
        }

        public ICommand SalvarCommand
        {
            get
            {
                return _salvarCommand ?? (_salvarCommand = new Command(() =>
                {
                    int iretorno = _servico.Salvar(EntidadeAtual);
                    if(iretorno > 0)
                    {
                        Navigation.PushAsync(new ViewListaPartida());
                    }
                }));
            }
        }

        public ICommand ExcluirCommand
        {
            get
            {
                return _excluirCommand ?? (_excluirCommand = new Command(() =>
                {
                    _servico.Excluir(EntidadeAtual);
                }));
            }
        }


    }


}
