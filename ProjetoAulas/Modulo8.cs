namespace Cadastro{

    public static class Calculos{
        public static int SomarNUmeros(int a, int b){
            return (a+b);
        }
    }

    public class Produto{
        public string Descricao { get; set;}

        public int Estoque {get;}

        public Produto(){
            Estoque = 1;
        }

        public void ImprimirDescricao(){
            Console.WriteLine(Descricao);
        }
    }
    public sealed class Configuracao
    {
        public string host {get;set;}
    }

    public class Pessoa {
        public int id {get; set;}
        public string Endereco {get; set;}

        public string Cidade {get; set;}

        public string Cep {get; set;}

        public void ImprimirDados(){
            Console.WriteLine("Codigo "+id);
            Console.WriteLine("Endereço "+Endereco);
            Console.WriteLine("Cidade "+Cidade);
            Console.WriteLine("Cep "+Cep);
      

        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF {get; set;}

        public void ImprimiCPF()
        {
                Console.WriteLine("CPF " + CPF);
        }

    }

    public class Funcionario : PessoaFisica
    {
            public string Matricula {get; set;}

            public void ImprimiMatricula()
            {
                Console.WriteLine("Matrícula : "+ Matricula);
            }
    }

    public abstract class Animal
    {
        public string Nome {get;set;}

        public abstract string GetInformacoesDog();

        public void ImprimirDados()
        {
            Console.WriteLine ("Nome do animal : "+ Nome );
            Console.WriteLine ("Informações : "+GetInformacoesDog());
        }
    }

        public class Cachorro : Animal
        {
            public override string GetInformacoesDog()
            {
                return "Cachoro é legal !";
            }
  
        }
    
}
    
