# Uso de LINQ em C#

Uso de LINQ para obter resultados de uma consulta em uma lista em C#, cada consulta tem um objetivo.

- Listar pessoas da lista de acordo com o seu Sexo
    - usando 'Where' e 'from pessoa in pessoas where pessoa.Sexo == 'M' select pessoa',
- Filtra as pessoas com mais e menos de 18 anos,
    - usando 'Where(x => x.Idade < 18)'
- Ordena a lista em ordem alfabética usando o 'OrderBy',
- Obtem o primeira e última pessoa da lista usando o 'FirstOrDefault' e 'LastOrDefault'