Console.WriteLine("Hello, world!");

// Exercício 1 — Calculando uma compra


// Exercício 2 — Classificação de notas

/*
string nome = Console.ReadLine();

Console.Write("Nome do aluno: ");
Console.Write("Nota do aluno: ");

if(nota >= 10)
{
    Console.WriteLine("Nota inválida.");
}
else if( nota >= 7 && nota <= 10)
{
    Console.WriteLine("Aprovado!");
}
else if( nota >= 5 && nota < 7)
{
    Console.WriteLine("Recuperação!");
}
else
{
    Console.WriteLine("Reprovado!");
}
*/

// Exercício 3 — Adivinhe o número

// Exercício 4 — Calculadora com métodos

// Exercício 5 — Cadastro de notas em um array

// Exercício 6 — Lista de produtos

List<string> nome_produtos = new List<string>();

nome_produtos.Add("Produto 1");
nome_produtos.Add("Produto 2");
nome_produtos.Add("Produto 3");

Console.WriteLine(nome_produtos.Count);

Console.WriteLine(nome_produtos.Contains("Produto 2"));

nome_produtos.Remove("Produto 1");
Console.WriteLine(nome_produtos.Count);