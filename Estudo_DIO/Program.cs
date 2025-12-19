using System.Diagnostics.Contracts;
using Estudo_DIO_Classes;

// - LISTAS

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine("LISTA COM FOR");

for(int i=0; i<listaString.Count; i++)
{
    Console.WriteLine($"Posição n° {i+1} = {listaString[i]}");
}

Console.WriteLine("LISTA COM FOREACH");

int iforeach = 1;
foreach(string item in listaString)
{
    Console.WriteLine($"Estado N° {iforeach} = {item}");
    iforeach++;
}





//----------------------------------------------------

//- ARRAYS

// int[] vetorInteiros = new int[3];

// vetorInteiros[0] = 13;
// vetorInteiros[1] = 27;
// vetorInteiros[2] = 35;

// // MUDA O TAMANHO DO VETOR
// // Array.Resize(ref vetorInteiros, vetorInteiros.Length * 2);


// //CRIA UM NOVO VETOR COM O DOBRO DO TAMANHO
// int[] vetorDobrado = new int[vetorInteiros.Length * 2];
// Array.Copy(vetorInteiros, vetorDobrado, vetorInteiros.Length);



// for (int i = 0; i < vetorInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição {i+1} = {vetorInteiros[i]}");
// }

// //- FOREACH 
// foreach (int item in vetorInteiros)
// {
//     Console.WriteLine($"Valor do item = {item}");
// }


//----------------------------------------------------

//- MENU INTERATIVO

// string opcao="0";

// while(true)
// {
//     Console.WriteLine("1 - ADICIONAR CADASTRO");
//     Console.WriteLine("2 - PESQUISAR CADASTRO");
//     Console.WriteLine("3 - EXCLUIR CADASTRO");
//     Console.WriteLine("4 - SAIR");
//     Console.WriteLine("Escolha um opção");
//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("FORMS DE CADASTRO");
//             break;

//         case "2":
//             Console.WriteLine("FORMS DE PESQUISA");
//             break;

//         case "3":
//             Console.WriteLine("FORMS DE EXCLUSAO");
//             break;

//         case "4":
//             Console.WriteLine("ENCERRANDO PROGRAMA");            
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("OPCAO INVÁLIDA. TENTE NOVAMENTE.");
//             Console.WriteLine("Escolha uma das opcoes:");
//             Console.WriteLine("1 - ADICIONAR CADASTRO");
//             Console.WriteLine("2 - PESQUISAR CADASTRO");
//             Console.WriteLine("3 - EXCLUIR CADASTRO");
//             Console.WriteLine("4 - SAIR");
//             break;

//     }
    
// }



//----------------------------------------------------

//- DO WHILE

// int soma=0, numero=0;

// do
// {
//     Console.WriteLine("Digite um numero (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine()); // ReadLine apenas lê String
//     soma+=numero;
// }while(numero!=0);

// Console.WriteLine($"A soma dos números é: {soma}");



//--------------------------------------------------------

//- WHILE

// int num = 7, i=0;

// while (i<10)
// {
//     Console.WriteLine($"{num} x {i+1} = {num*(i+1)}");
//     i++;    
// }


// For - Funciona como em C

// int num = 7;

// Console.WriteLine($"Tabuada do {num}: ");

// for(int i=0; i<10; i++) //pode declarar o contador dentro dos parênteses
// {
//     Console.WriteLine($"{num} x {i+1} = {num*(i+1)}");
// }



//-------------------------------------------
// - CALCULANDO USANDO A CLASSE MATH

// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// calc.Potencia(3, 2);

// calc.Somar(20, 40);
// calc.Subtrair(15, 7);
// calc.Multiplicar(2, 9);
// calc.Dividir(26, 3);

//--------------------------------------

//- USANDO OPERADORES LÓGICOS

//- NOT

// bool choveu = true;
// bool estaTarde = true;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Eba! Vou sair");
// }
// else
// {
//     Console.WriteLine("Não dá pra sair... Sadge");
// }

//- AND

// bool presencaMinima = true;
// double media = 5.9;

// if(presencaMinima && media >= 6)
// {
//     Console.WriteLine("Aluno aprovado!");
// }
// else
// {
//     Console.WriteLine("Aluno reprovado!");
// }

//---------------------------------------------

//- IF E SWITCH CASE

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }

// if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// {
//     Console.WriteLine("É uma vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

// int emEstoque = 10;
// int compra = 0;
// bool possivelVenda = compra > 0 && emEstoque >= compra;

// Console.WriteLine($"Quantidade de estoque: {emEstoque}");
// Console.WriteLine($"Quantidade da compra: {compra}");
// Console.WriteLine($"É possivel fazer a venda? {possivelVenda}");

// if(compra == 0)
// {
//     Console.WriteLine("Compra inválida");
// }
// else if(possivelVenda)
// {
//     Console.WriteLine("Compra aprovada");
// }
// else
// {
//     Console.WriteLine("Não há estoque suficiente");
// }

//-------------------------------------------------------

// - CASTING (CONVERSÃO)

// string a = "5-";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Convertido com sucesso!");



//DateTime dataAtual = DateTime.Now.AddDays(15);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//-----------------------------------------------------------

//- VARIÁVEIS

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

//------------------------------------------------------
//-USANDO A PRIMEIRA CLASSE

//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Joyce";
//pessoa1.Idade = 28;
//pessoa1.Apresentar();
