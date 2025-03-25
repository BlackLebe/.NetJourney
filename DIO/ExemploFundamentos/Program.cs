using ExemploFundamentos.Models;

Calculadora calc = new Calculadora();


Console.WriteLine("Você está aqui para realizar operações com ângulos? [S/N]");
string resposta = Console.ReadLine();

if (resposta == "s")
{
    Console.WriteLine(@"Digite a operação trignométrica que deseja calcular 
    sen -> para seno 
    cos -> para coseno 
    tan -> para tangente");

    string operacao = Console.ReadLine();

    Console.WriteLine("Digite o valor do ângulo (Não digite em radianos, realizarei a conversão sozinho)");
    double angulo = Convert.ToDouble(Console.ReadLine());

    switch (operacao)
    {
        case "sen":
            calc.Seno(angulo);
            break;
        case "cos":
            calc.Coseno(angulo);
            break;
        case "tan":
            calc.Tangente(angulo);
            break;
        default:
            Console.WriteLine("Valor Inválidp");
            break;
        
    }
} 
else if (resposta == "n")
{
    Console.WriteLine("Deseja realizar operação matemática? [S/N]");
    resposta = Console.ReadLine();
    if (resposta == "s")
    {
        Console.WriteLine("Se então Deseja realizar outra operação matemática");

        Console.WriteLine(@"Digite a Operação matemática que você deseja realizar dentre essas 
        + -> para somar\n- - > para subtrair
        * -> para multiplicar
        / -> para dividir (divisões sem resto)
        ^ -> para potenciação (primeiro expoente e depois a base)
        $ -> para raiz quadrada (bota o primeiro valor e o segundo 0)");
        
        string operacao = Console.ReadLine();

        Console.WriteLine("Digite o primeiro número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int y = Convert.ToInt32(Console.ReadLine());



        switch (operacao) 
        {
            case "+":
                calc.Somar(x, y);
                break;
            case "-":
                calc.Subtrair(x, y);
                break;
            case "*":
                calc.Multiplicar(x, y);
                break;
            case "/":
                calc.Dividir(x, y);
                break;
            case "^":
                calc.Potenciar(x, y);
                break;
            case "$":
                calc.raizQuadrada(x);
                break;
            default:
                Console.WriteLine("Valor inválido");
                break;
        }
    }
    else
    {
        Console.WriteLine("Se não deseja nada programa está sendo encerrado");
    }
    
}
else
{
    Console.WriteLine("Encerrando programa");
}



// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando  o 10");
// numero++;// equivalente a numero = numero + 1; e para subtração utiliza-se numero--

// Console.WriteLine(numero);





// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde) // esse sinal de ! representa a operação lógica de NOT ou seja, ele considera o inverso do que tem lá
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }



// bool presenca = true;
// double media = 7.5;

// if (presenca && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }




// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Tudo bem, você pode entrar");
// }
// else
// {
//     Console.WriteLine("Você não pode entrar");
// }






// Console.WriteLine("Digite uma letra");
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
//         Console.WriteLine("Não é uma vogal");
//         break;
// }





// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" || // || ==> ou, && = e
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("A Letral é uma vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }




// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe não tempos a quantidade desejada em estoque");
// }






// string a = "15-";

// int b = 0;

// Para tratamento de falhas usa-se o TryParse, pois com ele é possível "falar" pro C# exibir uma mensagem, um código, tanto faz indicando o problema com o código, invés de dar só o erro de exception
// bool teste = int.TryParse(a, out b);

// if (teste == false) // Aqui eu me arrisquei a fazer uma estrutura condicional afim de tentar fazer o programa se adaptar a uma resposta se o valor de a é válido ou não
// { 
//     Console.WriteLine("O teste falhou");
// } 
// else
// {
//         Console.WriteLine("Conversão realizada com sucesso!");
//         Console.WriteLine(b);
// }


// int inteiro = 5;
// string a = 5.ToString();
// Console.WriteLine(a+5);


// Cast - Casting --> o ato de converter o tipo de uma variável (pega a classe convert e seleciona um dos métodos dela)
//  int a = Convert.ToInt32("5");
//int a = int.Parse("5");

//Console.WriteLine(a);











// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5; // 30 + 5

// c += 5;

// c = c - 5;

// c *= 5;






// DateTime dataAtual = DateTime.Now; // é possível colocar diversos métodos a ele, sim calebe do futuro dá pra pegar só o ano!! só colocar o . e ver os métodos.
// Console.WriteLine(dataAtual);



// Console.WriteLine("Digite Seu nome");
// string name = Console.ReadLine();

// string apresentacao = "Olá meu nome é " + name;

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("O valor da variável de quantidade é: " + quantidade);
// Console.WriteLine("O valor da variável de altura é: " + altura.ToString("0.00"));
// Console.WriteLine("O valor da variável de preco é: " + preco);
// Console.WriteLine("O valor da variável de condicao é: " + condicao);


// Pessoa pessoa1 = new Pessoa ();
// pessoa1.Nome = name;
// pessoa1.Idade = 21;

// pessoa1.Apresentar();