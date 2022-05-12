using System.Collections.Generic;

namespace TestesDonaMariana.WinApp.Entidades
{
    public class Questao: EntidadeBase<Questao>
    {
        public string Descricao;
        public string Materia;
        public List<Alternativa> Alternativas;

        public Questao()
        {
            Alternativas = new List<Alternativa>();
        }
    }
}