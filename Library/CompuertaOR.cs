namespace Library
{
    public class CompuertaOR : IValorVerdad
    {
        private string name;
        private List<IValorVerdad> entradas = new List<IValorVerdad>();

        public CompuertaOR(string name, IValorVerdad entrada)
        {
            this.name = name;
            this.entradas.Add(entrada);
        }

        public bool Evaluar
        {
            get
            {
                bool resultado = entradas[0].Evaluar;
                for (int i = 1; i < entradas.Count; i++)
                {
                    resultado = resultado || this.entradas[i].Evaluar;
                }

                return resultado;
            }
        }


    }
}
