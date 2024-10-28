using static System.Console;
using System.Text.RegularExpressions;


namespace ValidacaoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                WriteLine("Escreva seu nome com no mínimo 5 caracteres");
                string? nome = ReadLine();
                
                 while (nome.Length < 5)
                 {
                     WriteLine("O nome precisa ter pelo menos 5 caracteres");
                     nome = ReadLine();

                 }

                WriteLine("Escreva sua data de nascimento no formato DD/MM/YYYY. Precisa ter 18 ou mais anos.");
                string? idade = ReadLine();

                DateTime data;
                bool ehDataValida = DateTime.TryParse(idade, out data);
                DateTime dezoitoAnos = DateTime.Now.AddYears(-18);

                while (!ehDataValida || data > dezoitoAnos)
                {
                    WriteLine("A data precisa estar no formato DD/MM/YYYY e precisa ter 18 ou mais anos.");
                    idade = ReadLine();
                    ehDataValida = DateTime.TryParse(idade, out data);
                }

                WriteLine("Escreva situação do Estado Civil: C, S, V ou D (maiusculo ou minusculo)");
                string estadoCivil = ReadLine() ?? "";
                Match? m = Regex.Match(estadoCivil, "^[CSVD]$", RegexOptions.IgnoreCase);
                while (!m.Success)
                {
                    WriteLine("O estado civil precisa ser um caractere C,S,V ou D (maiusculo ou minusculo)");
                    estadoCivil = ReadLine() ?? "";
                    m = Regex.Match(estadoCivil, "^[CSVD]$", RegexOptions.IgnoreCase);
                }

                char charEstadoCivil = estadoCivil[0];

                WriteLine("Escreva a quantidade de dependentes (0 a 10)");
                int dependente = int.Parse(ReadLine());
                while(dependente < 0  || dependente > 10) {
                    WriteLine("A quantidade de dependentes precisa estar entre 0 e 10");
                    dependente = int.Parse(ReadLine());
                }

                WriteLine("Escreva um valor para renda mensal. Precisa ser maior ou igual a zero com até duas casas decimais em vírgula.");
                string rendaStr = ReadLine() ?? "";
                Match? m2 = Regex.Match(rendaStr, "^([1-9][0-9]*|0)(,([0-9]{1,2}))?$");
                while (!m2.Success)
                {
                    WriteLine("Precisa ser maior ou igual a zero com até duas casas decimais em vírgula.");
                    rendaStr = ReadLine() ?? "";
                    m2 = Regex.Match(rendaStr, "^([1-9][0-9]*|0),([0-9]{2})$");
                }


                // Como a "cultura" está definida como PT-BR o Parse funciona com o decimal sendo separado por uma vírgula na string
                // Se fosse necessário o método replace poderia substituir a vírgula por um ponto na string antes da conversão

                float renda = float.Parse(rendaStr);



                WriteLine("Insira seu CPF de acordo com as regras no Anexo A");
                string CPF = ReadLine() ?? "";
                CPF.Trim();

                bool cpfEhValido = false;

                while (!cpfEhValido)
                {
                    if(Regex.IsMatch(CPF, "^[0-9]{11}$"))
                    {
                        if (CPF.Distinct().Count() != 1) {

                            char[] digitos = CPF.ToCharArray();
                            int J = int.Parse(digitos[9].ToString());
                            int K = int.Parse(digitos[10].ToString());

                            int multi = 10;

                            int resultJ = 0;
                            int resultK = 0;

                            for(int i = 0; i < 9; i++)
                            {
                                resultJ += (digitos[i]-'0') * multi;
                                multi--;
                            }

                            multi = 11;

                            for(int i = 0; i < 10; i++)
                            {
                                resultK += (digitos[i] - '0') * multi;
                                multi--;
                            }

                            int restoJ = resultJ % 11;
                            int restoK = resultK % 11;

                            resultJ = restoJ == 0 || restoJ == 1 ? 0 : 11 - restoJ;
                            resultK = restoK == 0 || restoK == 1 ? 0 : 11 - restoK;

                            if (J == resultJ && K == resultK){
                                cpfEhValido = true;
                            }
                            else
                            {
                                WriteLine("Os dígitos verificadores do CPF não são válidos");
                                CPF = ReadLine() ?? "";
                            }

                        }
                        else
                        {
                            WriteLine("O CPF não pode ser composto de números repetidos.");
                            CPF = ReadLine() ?? "";
                        }


                    }
                    else
                    {
                        WriteLine("O CPF precisa ter somente 11 dígitos");
                        CPF = ReadLine() ?? "";

                    }

                }


                WriteLine($"{nome} {data} {estadoCivil} {dependente} {renda} {CPF}");
                break;
               
            }


        }
    }
}
