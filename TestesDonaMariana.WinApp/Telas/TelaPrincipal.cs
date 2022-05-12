using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMariana.WinApp.ConfiguracoesMenu;
using TestesDonaMariana.WinApp.Entidades;
using TestesDonaMariana.WinApp.Repositorios;
using TestesDonaMariana.WinApp.Telas;

namespace TestesDonaMariana.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public IMenuConfig<Questao> menuConfigQuestao;
        Form telaMenu;

        public TelaPrincipal()
        {
            menuConfigQuestao = new MenuQuestaoConfig();
            InitializeComponent();
        }

        private void btnMenuTestes_Click(object sender, EventArgs e)
        {          
            
        }

        private void btnQuestoes_Click(object sender, EventArgs e)
        {
            telaMenu = new TelaMenuBase<Questao>(menuConfigQuestao);
            telaMenu.ShowDialog();
        }
    }
}
