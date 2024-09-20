namespace Library
{
    public class CompuertaNOT:IValorVerdad
    {
        private string name;
        private IValorVerdad entrada;

        public CompuertaNOT(string name, IValorVerdad entrada)
        {
            this.name = name;
            this.entrada = entrada;
        }

        public bool Evaluar
        {
            get
            {
                return !entrada.Evaluar;
            }
        }
    }
}