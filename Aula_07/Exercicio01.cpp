#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
int main(){

    cout <<"\033[35m =================================================== \033[0m" << endl;
    cout <<"\033[35m Exercicio01_Aula07 \033[0m" << endl;
    cout <<"\033[35m =================================================== \033[0m" << endl;

    vector<int> numeros(10); 
    vector<int> pares(10);
    vector<int> impares(10);
    int contpares = 0;
    int contimpares = 0;

    for(int linha = 0;  linha < int(numeros.size()); linha++){

        cout << "Entre com o " << linha + 1 << "o valor" << endl;
        cin >> numeros[linha];
    }

    for(int i =0; i < 10; i++){
        if(numeros[i] % 2 == 0){
            pares[contpares] = numeros[i];
            contpares++;
        }else{
            impares[contimpares] = numeros[i];
            contimpares++;
        }
    }

    cout << "Os numeros pares sao: " << endl;
    for(int i = 0; i < 10; i++){
        if( pares[i] != 0){
            cout << pares[i] << endl;
        }
    }

    cout << "Os numeros impares sao: " << endl;
    for(int i = 0; i < 10; i++){
        if( pares[i] != 0){
            cout << impares[i] << endl;
        }
    }
}