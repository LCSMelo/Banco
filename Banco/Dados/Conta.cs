namespace Dados
{
    public class Conta
    {
        public string Numero { get; set; }

        public string Agencia { get; set; }

        public double Saldo { get; private set; }

        /// <summary>
        /// Efetua um saque na conta do cliente
        /// </summary>
        /// <param name="Valor">Recebe um parametro do tipo double com o valor do saque</param>
        /// <returns>retorna o valor do saldo</returns>
        public double Sacar (double Valor){
            this.Saldo -= Valor;
            return this.Saldo;
        }

        /// <summary>
        /// Efetua um depósito na conta do cliente
        /// </summary>
        /// <param name="Valor">Recebe um parâmetro do tipo double com o valor do saque</param>
        /// <returns>Retorna o valor do Saldo</returns>
        public double Depositar (double Valor){
            this.Saldo += Valor;
            return this.Saldo;
        }



    }
}