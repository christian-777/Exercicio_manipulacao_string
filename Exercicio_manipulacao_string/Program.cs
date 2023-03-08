internal class Program
{
    private static void Main(string[] args)
    {
        string parametro;
        int cont = 0;
        string vogais = "aeiou";
        string consoantes = "bcdfghjklmnpqrstvwxyz";
        

        lerString();
        Menu();

        //Console.WriteLine("ola "+nome.Length);
        //Console.WriteLine("ola " + nome.ToLower());
        //Console.WriteLine("ola " + nome.ToUpper());
        //Console.WriteLine("ola " + nome.Trim('c'));

        //removeVogais(nome);

        //void removeVogais(string nome)
        //{
        //    string n="";
        //    for(int i = 0; i < nome.Length; i++)
        //    {
        //        if (nome[i] != 'a')
        //        {
                    
        //            n += nome[i];
        //        }
        //    }
        //    Console.WriteLine(n);
        //}

        void Menu()
        {
            int esc = 0;

            while(esc != 7)
            {
                Console.WriteLine("1- inserir um novo valor: ");
                Console.WriteLine("2- quantidade de caracteres: ");
                Console.WriteLine("3- quantidade de vogais: ");
                Console.WriteLine("4- quantidade de consoantes: ");
                Console.WriteLine("5- letras alternadas entre maiusculas e minusculas: ");
                Console.WriteLine("6- espelhar string: ");
                Console.WriteLine("7- sair: ");

                bool verifica= int.TryParse(Console.ReadLine(), out esc);

                if(verifica)
                {
                    switch (esc)
                    {
                        case 1:
                            lerString();
                            break;

                        case 2:
                            Console.WriteLine("a quantidade de caracteres da string \""+parametro+"\" eh: "+ parametro.Length);
                            break;

                        case 3:
                            Console.WriteLine("a quantidade de vogais da string \""+parametro+"\" eh: "+QuantidadeVogais());
                            break;

                        case 4:
                            Console.WriteLine("a quantidade de consoantes da string \"" + parametro + "\" eh: " + QuantidadeConsoantes());
                            break;

                        case 5:
                            Console.WriteLine("a string \"" + parametro + "\" com auternancia de tamanho: " + TamString(parametro));
                            break;

                        case 6:
                            Console.WriteLine("a string \"" + parametro + "\" espelhada fica: " + EspelharString(parametro));
                            break;

                        case 7:
                            Console.WriteLine("bye bye");
                            break;

                        default:
                            Console.WriteLine("esta operacao nao existe");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("digite um numero inteiro!!");
                }
            }
        }
        void lerString()
        {
            Console.WriteLine("digitee a string que deseja explorar: ");
            parametro=Console.ReadLine();
        }

        int QuantidadeVogais()
        {
            cont = 0;
            for(int i = 0; i < parametro.Length; i++)
            {
                for(int j = 0;j < vogais.Length; j++)
                {
                    if (parametro[i] == vogais[j])
                    {
                        cont++;
                    }
                }
            }
            return cont;
        }

        int QuantidadeConsoantes()
        {
            cont = 0;
            for (int i = 0; i < parametro.Length; i++)
            {
                for (int j = 0; j < consoantes.Length; j++)
                {
                    if (parametro[i] == consoantes[j])
                    {
                        cont++;
                    }
                }
            }
            return cont;
        }

        string TamString(string p)
        {
            string aux = "";

            for(int i = 0;i < p.Length; i++)
            {
                if(i%2 == 0)
                {
                    aux += char.ToUpper(p[i]);
                }
                else
                {
                    aux += char.ToLower(p[i]);
                }
            }
            return aux;
        }

        string EspelharString(string p)
        {
            string aux = "";

            for (int i = p.Length-1; i >= 0; i--)
            {
                aux += p[i];
            }
            return aux;
        }

        Console.ReadLine();
    }
}