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
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");    
                            }
                        }    
                        break;
                    case "3":
                        //TODO: Calcular Média Geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
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
