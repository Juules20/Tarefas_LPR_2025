#include <iostream>
#include <algorithm>

using namespace std;

struct Livro{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco; 
};

int main(){

    cout <<"\033[35m =================================================== \033[0m" << endl;
    cout <<"\033[35m Exercicio01_Aula08 \033[0m" << endl;
    cout <<"\033[35m =================================================== \033[0m" << endl;

    Livro a1, a2, a3;

        cout <<"Digite nesta ordem o titulo, autor, ano de publicacao, numero de paginas e o preco do 1o livro: " << endl;
        cin >> a1.Titulo;
        cin >> a1.Autor;
        cin >> a1.AnoPublicacao;
        cin >> a1.NumeroPaginas;
        cin >> a1.Preco;

        cout <<"Digite nesta ordem o titulo, autor, ano de publicacao, numero de paginas e o preco do 2o livro: " << endl;
        cin >> a2.Titulo;
        cin >> a2.Autor;
        cin >> a2.AnoPublicacao;
        cin >> a2.NumeroPaginas;
        cin >> a2.Preco;

        cout <<"Digite nesta ordem o titulo, autor, ano de publicacao, numero de paginas e o preco do 3o livro: " << endl;
        cin >> a3.Titulo;
        cin >> a3.Autor;
        cin >> a3.AnoPublicacao;
        cin >> a3.NumeroPaginas;
        cin >> a3.Preco;

        double precoTotal = a1.Preco + a2.Preco + a3.Preco;
        double mediaPag = (a1.NumeroPaginas + a2.NumeroPaginas + a3.NumeroPaginas)/3;

        cout <<"O preco total dos seus livros e: " << precoTotal <<" reais." << endl;
        cout <<"Seus livros tem uma media de " << mediaPag << " paginas." << endl;
}