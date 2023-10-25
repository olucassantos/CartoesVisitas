using System;

/*
    Criar um programa para escrever um cartão
    de visita. O programa deve mostrar o nome,
    profissão, email, descrição e telefone.
*/

// Cria as variáveis para armazenar os valores
string? nome;
string? profissao;
string? telefone;
string? email;
string? descricao;

// Solicita as informações do cartão
Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual sua profissão?");
profissao = Console.ReadLine();

Console.WriteLine("Qual seu telefone?");
telefone = Console.ReadLine();

Console.WriteLine("Qual seu email?");
email = Console.ReadLine();

Console.WriteLine("Qual sua mensagem?");
descricao = Console.ReadLine();

// Escreve o cartão de visita
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
Console.WriteLine("x          "+ nome +"       x");
Console.WriteLine("x  "+ profissao +"          x");
Console.WriteLine("x  "+ telefone +"           x");
Console.WriteLine("x  "+ email +"              x");
Console.WriteLine("x                           x");
Console.WriteLine("x  "+ descricao +"          x");
Console.WriteLine("x                           x");
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");