namespace Series
{
    public class Serie : EntidadeBase
    {
        //  Atributos

        private Genero Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}

        // Metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int Ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero:" + this.Genero + Enviroment.NewLine;
            retorno += "Titulo:" + this.Titulo + Enviroment.NewLine;
            retorno += "Descricao:" + this.Descricao + Enviroment.NewLine;
            retorno += "Ano de inicio:" + this.Ano + Enviroment.NewLine;
            return retorno;
        }
        public string retornaTitulo()
            {
                return this.Titulo;
            }
        
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}