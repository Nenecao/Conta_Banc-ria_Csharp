using System;

namespace ProvaP1___Semestre2
{
    

    class Conta
    {
        public float saldo;
        public string nome;
        public string nconta;

        public Conta()
        {
            saldo = 0;
            nome = "Vinícius Orrutia";
            nconta = "27067559-6";


        }

        public void Depositar(float va)
        {
            saldo += va;
        }

        public void Sacar(float vs)
        {
            saldo -= vs;
        }

        public void ObterNomeCliente()
        {
            Console.WriteLine(nome);
            
        }

        public void ObterSaldo()
        {
            Console.WriteLine("O seu saldo atual é de : R${0}", saldo);

        }

        public void ObterNumeroConta()
        {
            Console.WriteLine(nconta);
        }




    }


    class Program
    {

        static void Main(string[] args)
        {

            Conta c1 = new Conta();

            

            float va;
            float vs;
            int op;

            Console.WriteLine("         -*Conta Bancária*-");
            c1.ObterNomeCliente();
            c1.ObterNumeroConta();

            do
                {
                    Console.WriteLine();
                    
                    Console.WriteLine("1 - Depositar");
                    Console.WriteLine("2 - Sacar");
                    Console.WriteLine("3 - Dados da conta");
                    Console.WriteLine("4 - Calcular saldo");
                    Console.WriteLine("5 - Sair");
                    Console.WriteLine();

                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Insira o valor do depósito: "); va = float.Parse(Console.ReadLine());
                            c1.Depositar(va);
                            Console.WriteLine();
                            c1.ObterSaldo();
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Insira o valor a ser sacado: "); vs = float.Parse(Console.ReadLine());
                            c1.Sacar(vs);
                            Console.WriteLine();
                            c1.ObterSaldo();
                            break;

                        case 3:
                            Console.Write("O nome do titular da conta é: ");
                            c1.ObterNomeCliente();
                            Console.Write("O número da conta é: ");
                            c1.ObterNumeroConta();
                            break;

                        case 4:
                            Console.WriteLine();
                            c1.ObterSaldo();
                            break;

                        case 5:
                            break;
                    }
                } while (op != 5);


            

           

            

        }
    }
}
