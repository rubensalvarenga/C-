namespace Modulo10{

        public class TrabalhandoComStrings{

            public void ConverterParaLetrasMinusculas()
            {
                Console.Write("Favor digitar uma informação : ");
                var linha = Console.ReadLine();
                Console.WriteLine("Tudo Mínusculo !!!");
                Console.WriteLine(linha.ToLower());
                Console.WriteLine("Tudo Maíusculo !!!");
                Console.WriteLine(linha.ToUpper());
                Console.WriteLine("Pedaço da String");
                Console.WriteLine(linha.Substring(0,4));
                Console.WriteLine("Ranger pega 4 primeiros caracteres");
                Console.WriteLine(linha[..4]);
                Console.WriteLine("Ranger ultimos 3 caracteres");
                Console.WriteLine(linha[^3..]);
                Console.WriteLine("Ranger a partir do 3 pegar 3");
                Console.WriteLine(linha[3..^4]);

                
            }
        }


}