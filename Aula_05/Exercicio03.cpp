#include <iostream>
#include <string>
using namespace std;
int main() {

    cout <<"\033[34m =================================================== \033[0m" << endl;
    cout <<"\033[34m Exercico03_Aula05 \033[0m" << endl;
    cout <<"\033[34m =================================================== \033[0m" << endl;

    int soma = 0; 

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) { 
            soma += i;
        }
    }

    cout << "A soma dos numeros impares multiplos de 3 entre 50 e 500 e: " << soma << endl;
}