using Maracanema.Base;
using Maracanema.DataService;
using Maracanema.Model;
using Maracanema.View;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Maracanema.ViewModel
{
    public class JogadorViewModel : ViewModelBase<Jogador>
    {

        private JogadorDataService _servico;


        public ObservableCollection<Jogador> Jogadores
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

        public ICommand _listarCommand
        {
            get;
            set;
        }

        public ICommand _abrirCadastro
        {
            get;
            set;
        }

        public JogadorViewModel()
        {
            _servico = new JogadorDataService();
            Jogadores = new ObservableCollection<Jogador>();
            CarregarLista();
        }

        public JogadorViewModel(Jogador jogador)
            :this()
        {
            _servico = new JogadorDataService();
            EntidadeAtual = jogador;
        }


        public ICommand AbrirCadastroCommand
        {
            get
            {
                return _abrirCadastro ?? (_abrirCadastro = new Command(() =>
                {
                  Navigation.PushAsync(new ViewCadastroJogador());
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
                       Navigation.PushAsync(new ViewListaJogador());
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

        public ICommand Carregar
        {
            get
            {
                return _listarCommand ?? (_listarCommand = new Command(() =>
                {
                    _servico.listar();
                }));
            }
        }

        public void CarregarLista()
        {
          var listar = _servico.listar();
          if(listar != null)
           {
             foreach(var itens in listar)
               {
                 Jogadores.Add(itens);
               }
            }
         }

    }



}
