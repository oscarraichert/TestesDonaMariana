using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMariana.WinApp.Entidades;
using TestesDonaMariana.WinApp.Repositorios;
using TestesDonaMariana.WinApp.Telas.Questoes;

namespace TestesDonaMariana.WinApp.Telas
{
    public partial class TelaMenuBase<T> : Form
    {              
        public IMenuConfig<T> MenuConfig { get; }
        public TelaCadastroQuestao telaCadastroQuestao;        

        public TelaMenuBase(IMenuConfig<T> menuConfig)
        {
            InitializeComponent();
            MenuConfig = menuConfig;
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            this.Text = $"Menu de {MenuConfig.Titulo}";
            btnNovoCadastro.Text = $"Novo(a) {MenuConfig.Titulo}";
            btnEditarCadastro.Text = $"Editar {MenuConfig.Titulo}";
            btnExcluirCadastro.Text = $"Excluir {MenuConfig.Titulo}";
            btnVisualizar.Text = $"Visualizar Tudo";

            listBoxCadastros.Items.Clear();

            listBoxCadastros.Items.Add(MenuConfig.Repositorio.Lista);
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            MenuConfig.TelaCadastro.ShowDialog();
        }
    }
}
