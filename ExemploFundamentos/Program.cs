using ExemploFundamentos.Models;


//Classe calculadora 
Calculadora calc = new Calculadora();

calc.Somar(7, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15,45);
calc.Dividir(2, 2);



















// //Operador NOT (!)
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }











// //Operador AND (&&)

// bool possuiPresencaMinima = true; 
// double media = 7; 


// if (possuiPresencaMinima && media >= 7 )

// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }








// // Operador OR (||)
// bool maiorDeIdade = false;
// bool possuiAutorizacaoResponsavel = true;


// if (maiorDeIdade || possuiAutorizacaoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else 
// {
//     Console.WriteLine("Entrada não liberada");
// }






// //Switch Case
// Console.WriteLine("Digite uma letra ");
// string letra = Console.ReadLine();


// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//         default:
//             Console.WriteLine("Consoante");
//         break;
// }


// if (letra ==  "a" ||
//     letra ==  "e" ||
//     letra ==  "i" ||
//     letra ==  "o" ||
//     letra ==  "u")

//   {
//      Console.WriteLine("Vogal");
    
//   } 

// else
// {
//     Console.WriteLine("Consoante");
// } 






















//Operador Condicional (if aninhado)

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0; 
// bool possivelVenda =quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda?  {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");

// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidadr desejada no estoque");
// }
















// int b = 0;

// int.TryParse(a, out b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso");




//Ordem dos operadores
// double a = 4 / (2 + 2); 

// Console.WriteLine(a);


//Cast implicito - converte tipos de variaveis de maneira implicita
// int a = 5;
// double b = a;
// Console.WriteLine(b);



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