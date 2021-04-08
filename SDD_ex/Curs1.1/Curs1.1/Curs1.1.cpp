#include <stdio.h>
#include <iostream>
using namespace std;


struct produs
{
    int cod;
    char* den;
    float pret;
    float cant;
};

void citireVector(produs* p, int n)
{
    char buffer[20];
    for (int i = 0; i < n; i++)
    {
        cout << "Introdu cod: " << endl;
        cin >> p[i].cod;
        cout << "Introdu denumirea: " << endl;
        cin >> buffer; // introducem in buffer denumirea fara spatii
        p[i].den = new char[strlen(buffer) + 1];
        strcpy_s(p[i].den, strlen(buffer) + 1, buffer);
        cout << "Introdu pretul: " << endl;
        cin >> p[i].pret;
        cout << "Introdu cantitatea: " << endl;
        cin >> p[i].cant;
        cout << endl;
    }
}


void citire4Vectori(int* cod, char** den, float* pret, float* cant, int n)
{
    char buffer[20];
    for (int i = 0; i < n; i++) 
    {
        cout << "Introdu cod: " << endl;
        cin >> cod[i];
        cout << "Introdu denumire: " << endl;
        cin >> buffer;
        den[i] = new char[strlen(buffer) + 1];
        strcpy_s(den[i], strlen(buffer) + 1, buffer);
        cout << "Introdu pret: " << endl;
        cin >> pret[i];
        cout << "Introdu cantitate: " << endl;
        cin >> cant[i];
        cout << endl;
       
    }
}

void afisareVector(produs* p, int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << "Codul: " << p[i].cod << " " << "Denumirea: " << p[i].den << " " << "Pretul: " << p[i].pret << " " << "Cantitatea: " << p[i].cant << endl;
    }
}


void afisare4vectori(int* cod, char** den, float* pret, float* cant, int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << "Codul: " << cod[i] << " " << "Denumirea: " << den[i] << " " << "Pretul: " << pret[i] << " " << "Cantitatea: " << cant[i] << endl;
    }
}


void dezalocareVector(produs* p, int n)
{
    for (int i = 0; i < n; i++)
        delete[] p[i].den;
    delete[] p;
    
}

void dezalocare4vectori(int* cod, char** den, float* pret, float* cant, int n)
{
    for (int i = 0; i < n; i++)
        delete[] den[i];
    delete[] cod;
    delete[] pret;
    delete[] cant;
}

void citireMatrice(float** mat, int n)
{
    for(int i = 0; i < n; i++)
        for (int j = 0; j < 3; j++)
        {
            cout << "mat [" << i << "][" << j << "] = ";
            cin >> mat[i][j];
        }
}

void afisareMatrice(float** mat, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < 3; j++)
            cout << mat[i][j] << " ";
        cout << endl;
    }
}

void dezalocareMatrice(float** mat, int n)
{
    
    for (int i = 0; i < n; i++)
        delete[] mat[i];
    delete[] mat;

}


int main()
{

    int n; 

    cout << "Introdu cate produse sa fie create: " << endl;
    cin >> n;

    float** mat = new float* [n];
    for (int i = 0; i < n; i++)
        mat[i] = new float[3];  //sa fie maxim 3 coloane create

    citireMatrice(mat, n);
    afisareMatrice(mat, n);

    /*int* coduri = new int[n];
    char** denumiri = new char* [n];
    float* preturi = new float[n];
    float* cantitati = new float[n];

    produs* vectorP = new produs[n];  
    citireVector(vectorP , n);
    afisareVector(vectorP, n);
    citire4Vectori(coduri, denumiri, preturi, cantitati, n);
    afisare4vectori(coduri, denumiri, preturi, cantitati, n);
    dezalocare4vectori(coduri, denumiri, preturi, cantitati, n); */

    float** mat = new float* [n];
    for (int i = 0; i < n; i++)
        mat[i] = new float[3];

    cout << "test";


    return 0;
}
