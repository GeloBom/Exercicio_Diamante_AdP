namespace Exercicio_Diamante_AdP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ApresentaçãoPrograma();

                int inputNumeroImpar = ValidacaoInput();
                if (inputNumeroImpar % 2 == 0)
                {
                    continue;
                }

                LinhaSuperior(inputNumeroImpar);
                LinhaDoMeio(inputNumeroImpar);
                Console.WriteLine();
                LinhaInferior(inputNumeroImpar);
                return;
            }
        }
        
        #region Funções Do Programa
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

        private static bool GetInputInt(string mensagem, out int userInput)
        {
            Console.WriteLine(mensagem);
            return int.TryParse(Console.ReadLine(), out userInput);
        }

        private static int ValidacaoInput()
        {
            int inputNumeroImpar;
            if (!GetInputInt("Insira um numero impar para a criação do diamante: ", out inputNumeroImpar) || inputNumeroImpar % 2 == 0)
            {
                Console.WriteLine("Numero invalido, digite qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Console.Clear();
            }
            return inputNumeroImpar;
        }

        private static void LinhaSuperior(int inputNumeroImpar)
        {
            for (int qntX = 1; qntX < inputNumeroImpar; qntX += 2)
            {
                int espaços = (inputNumeroImpar - qntX) / 2;
                Console.Write(new string(' ', espaços));
                Console.WriteLine(new string('X', qntX));
            }
        }

        private static void LinhaDoMeio(int inputNumeroImpar)
        {
            for (int i = 0; i < inputNumeroImpar; i++)
            {
                Console.Write('X');
            }
        }

        private static void LinhaInferior(int inputNumeroImpar)
        {
            for (int qntX = inputNumeroImpar - 2; qntX >= 1; qntX -= 2)
            {
                int espaços = (inputNumeroImpar - qntX) / 2;
                Console.Write(new string(' ', espaços));
                Console.WriteLine(new string('X', qntX));
            }
        }
        #endregion
    }
}