// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

struct Muzeu 
{
    char* nume;
    float pretBilet;
    int nrVizitatori;
};

struct Nod 
{
    //char inf;
    Muzeu info; //informatia nodului actual
    Nod* next; //urmatorul nod, daca e ultimul setam ca NULL sau 0
};

void citireMuzeu()
{
    Muzeu muzeu;
    char buffer[20];
    cout << "Nume muzeu: " << endl;
    cin >> buffer;
    muzeu.nume = (char*)malloc(sizeof(char) * (strlen(buffer) + 1));
    /*muzeu.nume = new char[strlen(buffer) + 1];*/
    strcpy_s(muzeu.nume, strlen(buffer) + 1, buffer);
    cout << "Pretul biletului: " << endl;
    cin >> muzeu.pretBilet;
    cout << "Numar vizitatori: " << endl;
    cin >> muzeu.nrVizitatori;
};

Nod* creareNod(Muzeu m, Nod* urm)
{
    Nod* nou;
    nou = (Nod*)malloc(sizeof(Nod));
    nou->info = m; //shallow copy, a copiat adresa
    nou->info.nume = (char*)malloc(sizeof(char) * strlen(m.nume) + 1);
    strcpy_s(nou->info.nume, strlen(m.nume) + 1, m.nume);
    nou->next = urm;
    return nou;
}

int main()
{
    //int n;

    Nod* lista = NULL; // lista goala

   /* lista = creareNod(citireMuzeu(), lista);
    lista = creareNod
    */
    return 0;
}

