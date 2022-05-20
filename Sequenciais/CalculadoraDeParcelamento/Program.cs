/*9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.*/

/* entrada mais 2 prestações
 * entrada tem que ser maior ou igual às prestações
 * prestações devem ser iguais
 * prestações devem ser no maior valor possível */

double entrada, prestacão, precoMercadoria, resto;

Console.WriteLine("Calculadora de vendas a prazo");
Console.Write("Informe o valor da mercadoria: ");
precoMercadoria = double.Parse(Console.ReadLine());

resto = precoMercadoria % 3;
entrada = (precoMercadoria / 3) + resto;
prestacão = (precoMercadoria / 3) - resto;

Console.WriteLine("Para um produto de valor R$ " + precoMercadoria + ", a entrada fica em R$ " + Math.Round(entrada, 2) + ", com mais duas parcelas de R$ " + Math.Round(prestacão, 2));