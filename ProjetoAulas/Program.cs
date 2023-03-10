using System;

namespace Aplication
{
    public class Program
    {
      static void Main(string[] args)
      {
        //AulaClasses();
        //AulaHeranca();
        //AulaSelada();
        //AulaAbstrat();
        //Conversores();
        //AulaTryParse();
        //TrabalhandoComStrings();
        TrabalhandoComDatas();

      }
    
    private static void TrabalhandoComDatas()
    {
      var TrabalhandoComDatas = new Modulo11.TrabalhandoComDatas();

      TrabalhandoComDatas.AulaDateTime();



    }


    private static void TrabalhandoComStrings(){
      var TrabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
      TrabalhandoComStrings.ConverterParaLetrasMinusculas();
    }

    private static void AulaTryParse(){
        var conversor = new Conversores.Conversor();
         conversor.AulaTryParse();
        

    }
    private static void AulaSelada()
    {
 /*   {
      var link = new Cadastro.Configuracao();
      link.Host ="localhost";
    }  ou */

    var link = new Cadastro.Configuracao{
       host ="localhost"
    };

    Console.WriteLine (link.host);
    }

    private static void AulaClasses()
      {
         var resultado = Cadastro.Calculos.SomarNUmeros(2,3);
         Console.WriteLine (resultado);
         /*
         var produto = new Cadastro.Produto();
         produto.Descricao = "Teclado";

         produto.ImprimirDescricao();
         */

      }
    private static void AulaHeranca()
      {
        var pessoaFisica = new Cadastro.PessoaFisica();
        pessoaFisica.id = 1;
        pessoaFisica.Endereco = "Endereco Teste";
        pessoaFisica.Cidade = "Atibaia";
        pessoaFisica.Cep = "12945-140";
        pessoaFisica.CPF = " 234124";

        var funcionario = new Cadastro.Funcionario();
        funcionario.id = 10;
        funcionario.Endereco = "Endereco Teste";
        funcionario.Cidade = "Atibaia";
        funcionario.Cep = "12945-140";
        funcionario.CPF = " 234124";
        funcionario.Matricula = "2026";
        funcionario.CPF = "134234";
        funcionario.Matricula =" 29489234F";

        funcionario.ImprimirDados();
        funcionario.ImprimiCPF();
        funcionario.ImprimiMatricula();

      }
    private static void AulaAbstrat()
      {
        var cachorro = new Cadastro.Cachorro();
       cachorro.Nome = "Dog";
        cachorro.ImprimirDados();
      }
    
    private static void Conversores()
    {
        var conversores = new Conversores.Conversor();
        conversores.ConvertAndParse();
    }
    
    
    
    }

}