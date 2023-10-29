using ContractsCalcBot.Entities;
using System.Globalization;
using ContractsCalcBot.Services;

namespace ContractsCalcBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO ASSISTENTE DE CONTRATOS!");
            Console.WriteLine("Informe os dados do contrato");
            Console.Write("Número: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Data de fechamento de contrato: ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valer do contrato: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de parcelas: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine();
            Console.WriteLine("Installments: ");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}