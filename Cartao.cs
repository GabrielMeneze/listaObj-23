namespace listaObj_23
{
    public class Cartao
    {
        public string Titular { get; set; }
        public long Numero { get; set; }
        public string Vencimento { get; set; }
        public int Cvv { get; set; }


        public Cartao(string Titular, long Numero, string Vencimento, int Cvv){
            this.Titular = Titular;
            this.Numero = Numero;
            this.Vencimento = Vencimento;
            this.Cvv = Cvv;
        }
    }
}