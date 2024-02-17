class Program
{
    static void Main()
    {
        float saldoatual;
        int operacao;

        saldoatual = PerguntaSaldo();


        do
        {
            operacao = Opcoes();

            if (operacao == 1)

                saldoatual = Saque(saldoatual);

            else if (operacao == 2)
                saldoatual = Deposito(saldoatual);

            else if (operacao == 3)
                saldoatual = PagamentoDeConta(saldoatual);

            else if (operacao == 4)
                saldoatual = Transferencia(saldoatual);

            else if (operacao == 5)

                Console.WriteLine("Ate mais.");

            else

                Console.WriteLine("Digite um nome valido: ");



            Console.WriteLine($"Seu atual da conta: {saldoatual}");

        } while (operacao != 5);



    }

    static int Opcoes()
    {
        int operacao;

        Console.WriteLine("Digite a operacao: 1) Saque \n 2) Depósito \n 3) Pagamento de Conta \n 4) Transferência \n 5) Sair ");
        operacao = int.Parse(Console.ReadLine());

        return operacao;
    }

    static float PerguntaSaldo()
    {
        float saldoatual;

        Console.WriteLine("Digite o saldo atual da conta:");
        saldoatual = float.Parse(Console.ReadLine());

        return saldoatual;
    }

    static float Saque(float saldoatual)
    {
        float saque;

        Console.WriteLine("Digite o valor do saque:");
        saque = float.Parse(Console.ReadLine());

        saldoatual -= saque;

        return saldoatual;

    }

    static float Deposito(float saldoatual)
    {
        float Deposito;

        Console.WriteLine("Digite o valor deposito:");
        Deposito = float.Parse(Console.ReadLine());

        saldoatual += Deposito;

        return saldoatual;

    }

    static float PagamentoDeConta(float saldoatual)
    {
        float pagamento;

        Console.WriteLine("Digite o valor do pagamento de conta:");
        pagamento = float.Parse(Console.ReadLine());

        saldoatual -= pagamento;

        return saldoatual;

    }

    static float Transferencia(float saldoatual)
    {
        float Transferencia;

        Console.WriteLine("Digite o valor da transferencia de conta:");
        Transferencia = float.Parse(Console.ReadLine());

        saldoatual -= Transferencia;

        return saldoatual;

    }






}







