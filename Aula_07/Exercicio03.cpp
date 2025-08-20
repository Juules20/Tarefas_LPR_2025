#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
int main(){

    cout <<"\033[35m =================================================== \033[0m" << endl;
    cout <<"\033[35m Exercicio01_Aula07 \033[0m" << endl;
    cout <<"\033[35m =================================================== \033[0m" << endl;

    vector<string> cidades = {"Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo"}; 
    int matriz[4][4] = {
        {0,524,521,882},
        {524,0,434,586},
        {521,434,0,429},
        {882,586,429,0}
    };
    int cidOrigem, cidDestino;

    do{
        cout <<"Para qual cidade gostaria de ir?" <<endl;
        for(int i = 0; i < int(cidades.size()); i++){
            cout << i << " = " << cidades[i] << endl;
        }

        cout <<"Digite o numero correspondente a cidade que você quer sair:" <<endl;
        cin >> cidOrigem;

        cout <<"Digite o numero correspondente a cidade de destino: " <<endl;
        cin >> cidDestino;

        if(cidOrigem == cidDestino){
            cout << " As cidades sao iguais, Programa sendo encerrado" << endl;
        }
        else if(cidOrigem >= 0 && cidOrigem < 4 && cidDestino >=0 && cidDestino <4){
            cout <<" A distancia entre a cidade: " << cidades[cidOrigem] << ", e a cidade: " << cidades[cidDestino] << ", e de: " << matriz[cidOrigem][cidDestino] << " km."<<endl;
        }
        else{
            cout << "Numeros invalidos!!" << endl;
        }

    } while (cidOrigem != cidDestino);
}