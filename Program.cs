using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar Alunos
                        Console.Write("Informe o nome do Aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Informe a nota do Aluno: ");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        //TODO: Listar Alunos
                        Console.Clear();
                        Console.WriteLine("Lista de Alunos e Notas:");
                        Console.WriteLine();  
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"    * Aluno: {a.Nome} - Nota: {a.Nota}");    
                            }
                        }
                        Console.WriteLine();
                        Console.Write("Precione qualquer tecla para voltar");
                        Console.ReadLine();  
                        break;
                    case "3":
                        //TODO: Calcular Média Geral
                        Console.Clear();
                        Console.WriteLine("Detalhamento:");
                        Console.WriteLine();
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"    * Média Geral: {mediaGeral}");
                        Console.WriteLine();
                        Console.Write("Precione qualquer tecla para voltar");
                        Console.ReadLine();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("****************************************************");
            Console.WriteLine("*    Revisão DIO - ALUNOS                          *");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("*        1- Inserir Novo Aluno                     *");
            Console.WriteLine("*        2- Listar Alunos                          *");
            Console.WriteLine("*        3- Calcular Média Geral                   *");
            Console.WriteLine("*        X- Sair                                   *");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();
            Console.Write("Insira a opção desejada: ");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
