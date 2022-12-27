namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        { 
            int pessoas = 0;
            int capacidade = Suite.Capacidade;
            
            foreach (var hospede in hospedes)
            {
                pessoas++;
            }
            if (capacidade >= pessoas)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Sua capecidade de hospedes excedeu.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            int QuantidadeHospedes = Hospedes.Count; 
            return  QuantidadeHospedes;
           
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            { 
                decimal desconto = valor/10;
                valor = valor - desconto; 
            }

            return valor;
        }
    }
}