#include <iostream>
using namespace std;

void mediaNumerosPares(int quantidade) {
    int num, contador = 0;
    double soma = 0;

    for (int i = 0; i < quantidade; i++) {
        cout << "Digite um numero: ";
        cin >> num;

        if (num % 2 == 0) {
            soma += num;
            contador++;
        }
    }

    if (contador > 0) {
        double media = soma / contador;
        cout << "A media dos numeros pares e: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }
}

void somaImparesMultiplosDeTres() {
    int soma = 0;
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    cout << "A soma dos impares multiplos de 3 entre 50 e 500 e: " << soma << endl;
}

void somaDigitosQuadrado(int numero) {
    int quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    cout << "A soma dos digitos do quadrado de " << numero << " e: " << soma << endl;
}

int main() {

    cout <<"\033[34m =================================================== \033[0m" << endl;
    cout <<"\033[34m Exercico01_Aula06 \033[0m" << endl;
    cout <<"\033[34m =================================================== \033[0m" << endl;
    
    int opcao;

    do {
        cout << "\n==== MENU DE EXERCICIOS ====" << endl;
        cout << "1 - Media dos numeros pares" << endl;
        cout << "2 - Soma dos impares multiplos de 3 (50 a 500)" << endl;
        cout << "3 - Soma dos digitos do quadrado de um numero" << endl;
        cout << "0 - Sair" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1: {
                int quantidade;
                cout << "Quantos numeros voce ira digitar? ";
                cin >> quantidade;
                mediaNumerosPares(quantidade);
                break;
            }
            case 2:
                somaImparesMultiplosDeTres();
                break;

            case 3: {
                int numero;
                cout << "Digite um numero: ";
                cin >> numero;
                somaDigitosQuadrado(numero);
                break;
            }

            case 0:
                cout << "Saindo do programa..." << endl;
                break;

            default:
                cout << "Opcao invalida!" << endl;
        }

    } while (opcao != 0);

    cin.get(); 
    return 0;
}
