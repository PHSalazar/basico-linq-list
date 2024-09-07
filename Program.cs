using LINQ_com_DotNET;
using System;
using System.Collections.Generic;
using System.Linq;

// Usando LINQ
// https:\\learn.microsoft.com/pt-br/dotnet/csharp/linq/get-started/introduction-to-linq-queries

var listaPessoas = new List<Pessoas>
{
    new Pessoas("João Silva", 29, 'M'),
    new Pessoas("Cassia Souza", 42, 'F'),
    new Pessoas("Pedro Salazar", 31, 'M'),
    new Pessoas("Paulo Santiado", 17, 'M'),
    new Pessoas("Ana Montes", 14, 'F'),
    new Pessoas("Julio Santos", 43, 'M'),
    new Pessoas("Paula Juscelino", 18, 'F')
};


Console.WriteLine("------------- Pessoas do Sexo Masculino (M) -------------");
var pessoasSexoMasculino = listaPessoas.Where(x => x.Sexo == 'M').ToList();
Console.WriteLine($"{pessoasSexoMasculino.Count} pessoas são do sexo MASCULINO");
foreach (var pessoa in pessoasSexoMasculino)
{
    Console.WriteLine(pessoa.ToString());
}

Console.WriteLine("------------- Pessoas do Sexo Feminino (F) -------------");
var pessoasSexoFeminino = from pessoa in listaPessoas where pessoa.Sexo == 'F' select pessoa;
foreach (var pessoa in pessoasSexoFeminino)
{
    Console.WriteLine(pessoa.ToString());
}

Console.WriteLine("------------- Pessoas com 18 anos ou mais -------------");
var pessoasMaisDe18Anos = listaPessoas.Where(x => x.Idade >= 18).ToList();
Console.WriteLine($"{pessoasMaisDe18Anos.Count} pessoas tem 18 anos ou mais");
foreach (var pessoa in pessoasMaisDe18Anos)
{
    Console.WriteLine(pessoa);
}

Console.WriteLine("------------- Pessoas com menos de 18 anos em Ordem ASCENDENTE -------------");
var pessoasMenosDe18Anos = listaPessoas.Where(x => x.Idade < 18).OrderBy(x => x.Idade).ToList();
//var pessoasMenosDe18Anos = from pessoa in listaPessoas where pessoa.Idade < 18 select pessoa;
Console.WriteLine($"{pessoasMenosDe18Anos.Count} pessoas tem menos de 18 anos");
foreach (var pessoa in pessoasMenosDe18Anos)
{
    Console.WriteLine(pessoa);
}

Console.WriteLine($"------------- Todos os nomes em Ordem Alfabética: {listaPessoas.Count} pessoas na lista. -------------");
var nomesOrdemAlfabetica = listaPessoas.OrderBy(x => x.Nome).ToList();
foreach (var pessoa in nomesOrdemAlfabetica)
{
    Console.WriteLine(pessoa);
}

Console.WriteLine("------------- Primeiro nome da Lista -------------");
var primeiroNomeListaPessoas = listaPessoas.FirstOrDefault();
Console.WriteLine(primeiroNomeListaPessoas);


Console.WriteLine("------------- Último nome da Lista -------------");
var ultimoNomeListaPessoas = listaPessoas.LastOrDefault();
Console.WriteLine(ultimoNomeListaPessoas);