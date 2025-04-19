#include <iostream>
#include <string>
using namespace std;
int inverteNum(int num) {
    int reverso = 0;

    while (num != 0) {
        int digito = num % 10;          
        reverso = reverso * 10 + digito;   
        num = num / 10;              
    }

    return reverso;
}

int main() {

    cout <<"\033[34m =================================================== \033[0m" << endl;
    cout <<"\033[34m Exercico01_Aula06 \033[0m" << endl;
    cout <<"\033[34m =================================================== \033[0m" << endl;

    int num;

    cout <<"Entre com o numero que voce deseja inverter: " << endl;
    cin >> num;

    int invertido = inverteNum(num);
    cout <<"Seu numero invertido e: "<< invertido << endl;
}