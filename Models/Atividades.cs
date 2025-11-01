using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psc_lista_07_2025.Models
{
    public class Atividades
    {
        public static void Atividade1()
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            var temperaturas = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Temperatura média de {meses[i]}: ");
                double val;
                while (!double.TryParse(Console.ReadLine(), out val))
                {
                    Console.Write("Valor inválido. Digite novamente: ");
                }
                temperaturas.Add(val);
            }
            double media = temperaturas.Sum() / temperaturas.Count;
            Console.WriteLine($"Média anual: {media:F2}");
            Console.WriteLine("Meses com temperatura acima da média:");
            for (int i = 0; i < 12; i++)
            {
                if (temperaturas[i] > media)
                    Console.WriteLine($"{meses[i]}: {temperaturas[i]:F2}");
            }
        }

        public static void Atividade2()
        {
            string[] perguntas = {
                "Telefonou para a vítima?",
                "Esteve no local do crime?",
                "Mora perto da vítima?",
                "Devia para a vítima?",
                "Já trabalhou com a vítima?"
            };
            int positivos = 0;
            foreach (var p in perguntas)
            {
                Console.Write(p + " ");
                var resp = Console.ReadLine() ?? "";
                if (resp.Trim().ToLower().StartsWith("s"))
                    positivos++;
            }
            string classificacao;
            if (positivos == 5) classificacao = "Assassino";
            else if (positivos >= 3) classificacao = "Cúmplice";
            else if (positivos == 2) classificacao = "Suspeita";
            else classificacao = "Inocente";
            Console.WriteLine($"Classificação: {classificacao}");
        }

        public static void Atividade3()
        {
            var notas = new List<double>();
            while (true)
            {
                Console.Write("Informe uma nota (-1 para encerrar): ");
                if (!double.TryParse(Console.ReadLine(), out double v))
                {
                    Console.WriteLine("Valor inválido.");
                    continue;
                }
                if (v == -1) break;
                notas.Add(v);
            }
            int quantidade = notas.Count;
            Console.WriteLine($"Quantidade de valores lidos: {quantidade}");
            Console.Write("Valores na ordem informada: ");
            for (int i = 0; i < notas.Count; i++)
            {
                if (i > 0) Console.Write(" ");
                Console.Write(notas[i].ToString("F2"));
            }
            Console.WriteLine();
            Console.WriteLine("Valores na ordem inversa:");
            for (int i = notas.Count - 1; i >= 0; i--)
                Console.WriteLine(notas[i].ToString("F2"));
            double soma = notas.Sum();
            double media = quantidade > 0 ? soma / quantidade : 0;
            Console.WriteLine($"Soma: {soma:F2}");
            Console.WriteLine($"Média: {media:F2}");
            int acimaMedia = notas.Count(x => x > media);
            int abaixoSete = notas.Count(x => x < 7);
            Console.WriteLine($"Quantidade acima da média: {acimaMedia}");
            Console.WriteLine($"Quantidade abaixo de sete: {abaixoSete}");
            Console.WriteLine("Encerrando o programa.");
        }

        public static void Atividade4()
        {
            int[] contadores = new int[9];
            while (true)
            {
                Console.Write("Vendas brutas do vendedor (-1 para encerrar): ");
                if (!double.TryParse(Console.ReadLine(), out double vendas))
                {
                    Console.WriteLine("Valor inválido.");
                    continue;
                }
                if (vendas == -1) break;
                double salario = 200 + 0.09 * vendas;
                int idx;
                if (salario >= 1000) idx = 8;
                else
                {
                    idx = (((int)salario) - 200) / 100;
                    if (idx < 0) idx = 0;
                    if (idx > 7) idx = 7;
                }
                contadores[idx]++;
            }
            var faixas = new[] {
                "$200 - $299",
                "$300 - $399",
                "$400 - $499",
                "$500 - $599",
                "$600 - $699",
                "$700 - $799",
                "$800 - $899",
                "$900 - $999",
                "$1000 em diante"
            };
            for (int i = 0; i < contadores.Length; i++)
                Console.WriteLine($"{faixas[i]}: {contadores[i]} vendedor(es)");
        }
    }
}