using System;

class Atendente : Imposto
{
      public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto atendente do valor do vale alimentação R$: "+(salario*0.12));
    }
    
}