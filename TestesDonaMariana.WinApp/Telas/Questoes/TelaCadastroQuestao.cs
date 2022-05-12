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

namespace TestesDonaMariana.WinApp.Telas.Questoes
{
    public partial class TelaCadastroQuestao : Form
    {        
        public RepositorioBase<Questao> Repositorio { get; }
        public Questao Questao;

        public TelaCadastroQuestao(RepositorioBase<Questao> repositorio)
        {
            InitializeComponent();
            Repositorio = repositorio;
            Questao = new Questao();
            AtualizarListBox();
        }

        private void btnAdicionarAlternativa_Click(object sender, EventArgs e)
        {
            TelaCadastroAlternativas telaAlternativas = new TelaCadastroAlternativas();
            telaAlternativas.ShowDialog();

            if (telaAlternativas.DialogResult == DialogResult.OK)
            {
                Questao.Alternativas.Add(telaAlternativas.alternativa);
                AtualizarListBox();
            }
        }

        private void AtualizarListBox()
        {
            listBoxAlternativas.Items.Clear();

            foreach (Alternativa alternativa in Questao.Alternativas)
            {
                listBoxAlternativas.Items.Add(alternativa);
            }
        }
    }
}
