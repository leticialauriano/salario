using System;

/*
 Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
salário bruto.
quanto pagou ao INSS.
quanto pagou ao sindicato.
o salário líquido.
calcule os descontos e o salário líquido, conforme a tabela abaixo:
+ Salário Bruto : R$
- IR (11%) : R$
- INSS (8%) : R$
- Sindicato (5%) : R$
= Salário Liquido : R$
Obs.: Salário Bruto - Descontos = Salário Líquido.
 */

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double TAXAIR = 0.11;
            const double TAXAINSS = 0.08;
            const double TAXASINDICATO = 0.05;

            Console.WriteLine("--Programa Salário--\n");

            Console.WriteLine("Informe alguns dados por favor.");
            
            Console.Write("Número de horas trabalhadas:");
            double numeroHorasTrabalhadas = double.Parse(Console.ReadLine());

            Console.Write("Valor por hora:");
            double valorHora = double.Parse(Console.ReadLine());
            
            double salarioBruto = numeroHorasTrabalhadas * valorHora;
            double ir = salarioBruto * TAXAIR;
            double inss = salarioBruto * TAXAINSS;
            double sindicato = salarioBruto * TAXASINDICATO;

            Console.WriteLine($"\n+ Salário Bruto : R$ {salarioBruto:0.00}");
            Console.WriteLine($"- IR (11%) : R$ {ir:0.00}");
            Console.WriteLine($"- INSS (8%) : R$ {inss:0.00}");
            Console.WriteLine($"- Sindicato (5%) : R$ {sindicato:0.00}");
            Console.WriteLine($"= Salário Liquido: R$ {salarioBruto - ir - inss - sindicato:0.00}");
                        
            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
