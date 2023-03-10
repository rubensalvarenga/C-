namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        //int numero = int.Parse("1");
        int numero = Convert.ToInt32("1");
        Console.WriteLine("Numero convertido >>>> "+ numero);
    }

    public void AulaTryParse()
    {
        var numero = "abc";

        if (int.TryParse(numero, out int numeroConvertido)){
            Console.WriteLine("Numero convertido com sucesso ");
            Console.WriteLine(numeroConvertido);
        }else{
            Console.WriteLine("Coversão Incorreta ...");
            Console.WriteLine(numeroConvertido);
        }

        

    }
}