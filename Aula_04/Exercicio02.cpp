#include <iostream>
#include <string>
using namespace std;
int main() {

    cout <<"\033[35m =================================================== \033[0m" << endl;
    cout <<"\033[35m Exercico02_Aula04 \033[0m" << endl;
    cout <<"\033[35m =================================================== \033[0m" << endl;

    int a,b;

    cout <<"Entre com o valor de A" << endl;
    cin >> a;

    cout <<"Entre com o valor de B" << endl;
    cin >> b;

    if( a % b == 0 ){
        cout << "\033[32m Os numeros: " << a << " e " << b << " sao multiplos \033[0m";

    }else if( b % a == 0){
        cout << "\033[32m Os numeros: " << b << " e " << a << " sao multiplos \033[0m";

    }else {
        cout << "\033[31m Os numeros: " << a << " e " << b << " nao sao multiplos \033[0m";

    }
}