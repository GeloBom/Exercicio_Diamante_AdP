namespace Exercicio_Diamante_AdP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                ApresentaçãoPrograma();
                
                //Menu de entrada;
                
                int inputNumeroImpar;
                if (!GetInputInt("Insira um numero impar para a criação do diamante: ", out inputNumeroImpar) || inputNumeroImpar % 2 == 0)
                {
                    Console.WriteLine("Numero invalido, digite qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine($"O numero digitado foi de {inputNumeroImpar}, Aqui está seu desenho: \n");

                // Linha Superior
                for (int qntX = 1; qntX < inputNumeroImpar; qntX += 2)
                {
                    int espaços = (inputNumeroImpar - qntX) / 2;
                    Console.Write(new string(' ', espaços));
                    Console.WriteLine(new string('X', qntX));

                }

                // Linha Meio
                for (int i = 0; i < inputNumeroImpar; i++)
                {
                    Console.Write('X');
                }

                Console.WriteLine();

                //linha inferior
                for (int qntX = inputNumeroImpar - 2; qntX >= 1; qntX -= 2)
                {
                    int espaços = (inputNumeroImpar - qntX) / 2;
                    Console.Write(new string(' ', espaços));
                    Console.WriteLine(new string('X', qntX));
                }
                break;
            }
        }

        private static void ApresentaçãoPrograma()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|             Bem-vindo ao Programa                 |");
            Console.WriteLine("|           Desenho de Diamante em X                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|      Prepare-se para uma jornada criativa!        |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("=====================================================\n");
            Console.WriteLine("     Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static bool GetInputInt(string mensagem, out int userInput)
        {
            Console.WriteLine(mensagem);
            return int.TryParse(Console.ReadLine(), out userInput);
        }
    }
}