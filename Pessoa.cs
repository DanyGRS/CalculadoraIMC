public class Pessoa
{
    public string Nome { get; set; }    
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get => Math.Round(((Peso) / (Altura * Altura)), 2); }

    public Pessoa(string nome, double altura, double peso)
    {
        this.Nome = nome;
        this.Altura = altura;
        this.Peso = peso;
    }

    public string CalculoIMC ()
    {
        if (Imc < 17) return "Muito abaixo do peso";

        else if (Imc >= 17.00 && Imc < 18.50) return "Abaixo do peso";

        else if (Imc >= 18.50 && Imc < 25.00) return "Peso normal";
      
        else if (Imc >= 25.00 && Imc < 30.00) return "Acima do peso";
   
        else if (Imc >= 30.00 && Imc < 35.00) return "Obesidade I";
  
        else if (Imc >= 35.00 && Imc < 40.00) return "Obesidade II(severa)";
    
        else if (Imc > 40.00) return "Obesidade III(mórbida)";

        return "-1";
    }
    
    public string PesoIdeal()
    {
        if(Imc < 18.50)
        {
            double pesoEssencial = Math.Round((18.50 - Imc), 2);

            return "Você precisa ganhar: " + (pesoEssencial) + "Kg";
        }

        else if(Imc >= 25)
        {
            double pesoEssencial = Math.Round((Imc - 24.99), 2);

            return "Você precisa perder:" + (pesoEssencial) +"Kg";
        }
    return "Você já está com o peso ideal!!!";  
    }
}