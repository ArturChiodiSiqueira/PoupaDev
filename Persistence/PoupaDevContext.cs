using PoupaDev.Entities;

namespace PoupaDev.Persistence
{
    public class PoupaDevContext
    {
        public List<ObjetivoFinanceiro> Objetivos { get; set; }

        public PoupaDevContext()
        {
            Objetivos = new List<ObjetivoFinanceiro>();   
        }
    }
}
