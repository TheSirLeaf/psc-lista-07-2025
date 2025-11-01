/*
1. Faça um programa que receba a temperatura média de cada mês do ano e
armazene-as em uma lista. Após isto, calcule a média anual das temperaturas e
mostre todas as temperaturas acima da média anual, e em que mês elas
ocorreram (mostrar o mês por extenso: 1 – Janeiro, 2 – Fevereiro, . . . ).
2. Utilizando listas faça um programa que faça 5 perguntas para uma pessoa
sobre um crime. As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve no final emitir uma classificação sobre a participação da
pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve
ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como
"Assassino". Caso contrário, ele será classificado como "Inocente".
3. Faça um programa que leia um número indeterminado de valores,
correspondentes a notas, encerrando a entrada de dados quando for
informado um valor igual a -1 (que não deve ser armazenado).
Após esta entrada de dados, faça:
Mostre a quantidade de valores que foram lidos;
Exiba todos os valores na ordem em que foram informados, um ao lado do
outro;
Exiba todos os valores na ordem inversa à que foram informados, um abaixo
do outro;
Calcule e mostre a soma dos valores;
Calcule e mostre a média dos valores;
Calcule e mostre a quantidade de valores acima da média calculada;
Calcule e mostre a quantidade de valores abaixo de sete;
Encerre o programa com uma mensagem.
4. Utilize uma lista para resolver o problema a seguir. Uma empresa paga seus
vendedores com base em comissões. O vendedor recebe $200 por semana
mais 9 por cento de suas vendas brutas daquela semana.
Por exemplo, um vendedor que teve vendas brutas de $3000 em uma semana
recebe $200 mais 9 por cento de $3000, ou seja, um total de $470.
Escreva um programa (usando um array de contadores) que determine
quantos vendedores receberam salários nos seguintes intervalos de valores:
$200 - $299
$300 - $399
$400 - $499
$500 - $599
$600 - $699
$700 - $799
$800 - $899
$900 - $999
$1000 em diante
*/

using static psc_lista_07_2025.Models.Atividades;

int menu = 0;
bool exit = false;

while (!exit)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Atividade 1");
        Console.WriteLine("2. Atividade 2");
        Console.WriteLine("3. Atividade 3");
        Console.WriteLine("4. Atividade 4");
        menu = Convert.ToInt32(Console.ReadLine());
        switch (menu)
        {
            case 1:
                Atividade1();
                break;
            case 2:
                Atividade2();
                break;
            case 3:
                Atividade3();
                break;
            case 4:
                Atividade4();
                break;
            default:
                exit = true;
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, insira um número válido.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro: " + ex.Message);
    }
    Console.WriteLine("Clique em qualquer tecla para continuar...");
    Console.ReadKey();
}