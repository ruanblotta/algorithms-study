#include <stdio.h>
#include <math.h>

int main() {
    int tamanho_lista = 128;
    int tamanho_lista2 =  256;
    int max_tentativas = (int)log2(tamanho_lista);
    int max_tentativas2 = (int)log2(tamanho_lista2);

    printf("o número máximo de tentativas na busca binária é: %d\n", max_tentativas);
    printf("o número máximo de tentativas na busca binária é: %d\n", max_tentativas2);

    return 0;
}