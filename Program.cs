
        ContaBancaria conta = null;
        string opcao = "";

        while (opcao != "5")
        {
            Console.WriteLine("Banco dos Programadores");
            Console.WriteLine("1 - criar conta");
            Console.WriteLine("2 - depositar");
            Console.WriteLine("3 - sacar");
            Console.WriteLine("4 - exibir dados");
            Console.WriteLine("5 - sair");
            Console.Write("escolha: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                if (conta != null)
                {
                    Console.WriteLine("conta já foi criada");
                }
                else
                {
                    Console.Write("nome completo: ");
                    string nome = Console.ReadLine();

                    Console.Write("número da conta: ");
                    int numero = int.Parse(Console.ReadLine());

                    Console.Write("saldo inicial: ");
                    decimal saldoInicial = decimal.Parse(Console.ReadLine());

                    conta = new ContaBancaria(nome, numero, saldoInicial);
                    Console.WriteLine("conta criada com sucesso");
                }
            }
            else if (opcao == "2")
            {
                if (conta == null)
                {
                    Console.WriteLine("crie uma conta primeiro");
                }
                else
                {
                    Console.Write("valor do depósito: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                }
            }
            else if (opcao == "3")
            {
                if (conta == null)
                {
                    Console.WriteLine("crie uma conta primeiro");
                }
                else
                {
                    Console.Write("valor do saque: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valor);
                }
            }
            else if (opcao == "4")
            {
                if (conta == null)
                {
                    Console.WriteLine("crie uma conta primeiro");
                }
                else
                {
                    conta.ExibirDados();
                }
            }
            else if (opcao == "5")
            {
                Console.WriteLine("sistema encerrado");
            }
            else
            {
                Console.WriteLine("opção inválida");
            }
        }

