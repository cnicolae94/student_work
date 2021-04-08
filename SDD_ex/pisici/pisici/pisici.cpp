// pisici.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

using namespace std;

// cod, nume, varsta, greutate

struct pisica {
    int cod;
    char* nume;
    int varsta;
    float greutate;
};

void citirePisici(pisica* p, int n)
{
    char buffer[20];
    for (int i = 0; i < n; i++)
    {
        cout << "Introdu cod pisica: " << endl;
        cin >> p[i].cod;
        cout << "Introdu nume pisica: " << endl;
        cin >> buffer;
        p[i].nume = new char[strlen(buffer) + 1];
        strcpy_s(p[i].nume, strlen(buffer) + 1, buffer);
        cout << "Introdu varsta pisica: " << endl;
        cin >> p[i].varsta;
        cout << "Introdu greutatate pisica: " << endl;
        cin >> p[i].greutate;
    }
}

void citire4Pisici(int* coduri, char** numee, int* varste, float* greutate, int n)
{
    char buffer[20];
    for (int i = 0; i < n; i++)
    {
        cout << "Introdu cod pisica: " << endl;
        cin >> coduri[i];
        cout << "Introdu nume pisica: " << endl;
        cin >> buffer;
        numee[i] = new char[strlen(buffer) + 1];
        strcpy_s(numee[i], strlen(buffer) + 1, buffer);
        cout << "Introdu varsta pisica: " << endl;
        cin >> varste[i];
        cout << "Introdu greutate pisica: " << endl;
        cin >> greutate[i];

    }
}

void afisarePisici(pisica* p, int n)
{
    for (int i = 0; i < n; i++)
        cout << "Cod: " << p[i].cod << " " << "Nume: " << p[i].nume << " " << "Varsta: " << p[i].varsta << " " << "Greutate: " << p[i].greutate << endl;
}


void afisare4Pisici(int* coduri, char** numee, int* varste, float* greutate, int n)
{
    for (int i = 0; i < n; i++)
        cout << "Cod: " << coduri[i] << " " << "Nume: " << numee[i] << " " << "Varsta: " << varste[i] << " " << "Greutate: " << greutate[i] << endl; 
}

void dezalocarePisici(pisica* p, int n)
{
    for (int i = 0; i < n; i++)
        delete[] p[i].nume;
    delete[] p;
}

void dezalocare4Pisici(int* coduri, char** numee, int* varste, float* greutate, int n)
{
    for (int i = 0; i < n; i++)
        delete[] numee[i];
    delete[] coduri;
    delete[] varste;
    delete[] greutate;
}

int main()
{
    int n;

    cout << "Introdu nr de pisici: " << endl;
    cin >> n;

    pisica* vectorPisici = new pisica[n];

    int* coduri = new int[n];
    char** numee = new char*[n];
    int* varste = new int[n];
    float* greutate = new float[n];



    //citirePisici(vectorPisici, n);
    //afisarePisici(vectorPisici, n);
    //dezalocarePisici(vectorPisici, n);

    citire4Pisici(coduri, numee, varste, greutate, n);
    afisare4Pisici(coduri, numee, varste, greutate, n);
    dezalocare4Pisici(coduri, numee, varste, greutate, n);


    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
