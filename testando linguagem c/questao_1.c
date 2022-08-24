#include <stdio.h>
#include <stdlib.h>

/*1) Quando um lote de ações de uma companhia é vendido, o ganho de capital (ou, às vezes, a perda) 
é a diferença entre o preço de venda do lote e o preço originalmente pago por ele. Essa regra é fácil 
de entender para um único lote, mas se vendermos múltiplos lotes comprados em tempos diferentes temos 
de identificar os lotes sendo vendidos. Um método usado para identificar que lotes são vendidos é usar
uma estrutura que suporte o protocolo FIFO, na qual os lotes vendidos são aqueles que temos há mais
tempo (este é o método usado em vários softwares de finanças pessoais). Por exemplo, suponha que 
compramos 100 lotes a $20 cada no dia 1, 20 lotes a $24 no dia 2, 200 lotes a $36 no dia 3 e vendemos
150 lotes no dia 4 a $30 cada. Aplicando o protocolo FIFO, significa que dos 150 lotes vendidos, 100
foram comprados no dia 1, 20 foram comprados no dia 2 e 30 foram comprados no dia 3. O ganho de 
capital neste caso seria 100.10+20.6+30.(-6), ou $940.
a)Escreva um programa que recebe como entrada uma sequência de transações da forma

•compre X lotes a $Y cada
ou 
•venda X lotes a $Y cada

b) assumindo que as transações ocorrem em dias consecutivos e que os valores x e y são inteiros. 

Dada esta sequência de entradas, a saída deve ser o ganho total (ou perda) de capital para a 
sequência completa, usando o protocolo FIFO para identificar os lotes.

Obs: Utilize uma lista encadeada para armazenar os elementos.
*/

int main(){
    int i, quant[10];
    float valorTotal = 0, valorParcial, valor[10];

    for(i = 0; i < 10; i++){
        printf("Digite o valor do lote e a quantidade vendida");
        scanf("%f%d", &valor[i], &quant[i]);
    }
//letra a
    for(i = 0; i < 10; i++){
        valorParcial = quant[i] * valor[i];
        printf("Vendido:  %d\t Valor unitario R$%.2f\tValor total R$%.2f\n", quant[i], valor[i], valorParcial);
        valorTotal += valorParcial;
     }

     printf("Valor total das vendas R$%.2f\n", valorTotal);

//letra b
    for(i = 0; i < 10; i++){
        if(quant[i]> maisVendido)
            maisVendido = quant[i];
    }
    for(i = 0; i < 10; i++){
        if(quant[i] == maisVendido){
            printf("Posição:  %d\t R$%.2f\n", i, valor[i]);
        }
    }

    
    return 0;
}
