#include <iostream>
#include <string>
using namespace std;
int main() {

    cout <<"\033[34m =================================================== \033[0m" << endl;
    cout <<"\033[34m Exercico01_Aula05 \033[0m" << endl;
    cout <<"\033[34m =================================================== \033[0m" << endl;

    int quant,num;
    double soma = 0; 
    int i = 0;
    int contador = 0;

    cout <<"Quantos numeros voce ira digitar?" << endl;
    cin >> quant;

    while( i < quant ){
        cout << "Digite um numero: " << endl;
        cin >> num;

        if( num % 2 == 0 ){
            soma += num;
            contador++;
        }

        i++;
    }

    if( contador > 0 ){

        double media = soma/contador;
        cout << "A media dos numeros pares e: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }
}