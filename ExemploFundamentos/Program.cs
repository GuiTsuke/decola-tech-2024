﻿using ExemploFundamentos.Models;

//Cast implicito - converte tipos de variaveis de maneira implicita
int a = 5;
double b = a;
Console.WriteLine(b);












// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);



//Cast/ Casting - convertendo tipos de variáveis
// Convert.ToInt32(metodo); - converte tipos de variáveis - o Convert aceita valor nulo 
// ou
// int.Parse(metodo); - converte tipos de variáveis o Parse não aceita valor nulo


// int a = Convert.ToUInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);




// int a = 10;
// int b = 20; 

// int c = a + b;

// // c = c + 5; 
// // combinação de operadores: +=, -=, /=, *= 

// c += 5;


// Console.WriteLine(c);







// DateTime  dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/mm/yyyy"));



// string apresentacao = "Olá, seja bem-vindo!";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade " + quantidade);
// Console.WriteLine("Valor da variavel altura " + altura);
// Console.WriteLine("Valor da variavel preço " + preco);
// Console.WriteLine("Valor da variavel condição " + condicao);




// // Pessoa pessoa1 = new Pessoa();
// // pessoa1.Nome = "Geovanna";
// // pessoa1.Idade = 21;
// // pe ssoa1.Apresentar();