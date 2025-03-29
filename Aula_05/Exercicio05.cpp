#include <iostream>
#include <string>
using namespace std;
int main() {
    cout <<"\033[34m =================================================== \033[0m" << endl;
    cout <<"\033[34m Exercico05_Aula05 \033[0m" << endl;
    cout <<"\033[34m =================================================== \033[0m" << endl;

    int horasDia, horasSemanas;
    int horas, semanas, dias;
    int meses;

    cout <<"Quantas horas voce quer treinar por dia?" << endl;
    cin >> horasDia;

    horasSemanas = horasDia * 5;

    while(horas != 1000){
        horas += horasSemanas;
    }

    dias = horas / horasDia;
    semanas = horas / horasSemanas;
    meses = semanas / 4.5;

    cout << "Total de dias de treinamento: " << dias << " dias." << endl;
    cout << "Seriam necessarias " << semanas << " semanas de treinamento." << endl;
    cout << "Ou " << meses << " meses de treinamento." << endl;
}