namespace DesignPatterns2.Cap3
{
    public class Estado
    {
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
            DataQueEstadoFoiSalvo = DateTime.Now;
        }

        public Contrato Contrato { get; private set; }
        public DateTime DataQueEstadoFoiSalvo { get; private set; }
    }
}
