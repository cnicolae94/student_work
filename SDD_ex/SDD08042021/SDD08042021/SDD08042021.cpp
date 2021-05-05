#include <iostream>
#include <stdio.h>

using namespace std;

struct produs
{
    int cod; 
    char* denumire;
    float pret;
    float cantitate;
};

struct nodls
{
    produs inf;
    nodls* next;
};

nodls* inserare(nodls* cap, produs p)
{
    nodls* nou = (nodls*)malloc(sizeof(nodls));
    nou->inf.cod = p.cod;
    nou->inf.denumire = (char*)malloc((strlen(p.denumire) + 1)* sizeof(char));
    strcpy_s(nou->inf.denumire, strlen(p.denumire)+1, p.denumire);
    nou->inf.pret = p.pret;
    nou->inf.cantitate = p.cantitate;
    nou->next = NULL;  //copiem detaliile in nod si verificam daca mai exista altul
    if (cap == NULL)
        cap = nou; //daca nu, cel nou devine capul listei simple
    else
    {
        nodls* temp = cap; //daca da, nodul se adauga la sfarsit 
        while (temp->next != NULL)
        {
            temp = temp->next; //traversam lista sa ajungem la ultimul nod
        }
        temp->next = nou;
    }
  
    return cap;
}

void afisare(nodls* cap)
{
    nodls* temp = cap;
    while (temp != NULL)
    {
        cout << "Cod: " << temp->inf.cod << " Denumire: " << temp->inf.denumire << " Pret: " <<
            temp->inf.pret << " Cantitate: " << temp->inf.cantitate << endl;
        temp = temp->next; //continua sa afiseze urmatorul nod pana acesta ajunge la capat
    }
}
 
void dezalocare(nodls* cap)
{
    nodls* temp = cap;
    while (temp != NULL)
    {
        nodls* temp2 = temp->next;
        free(temp->inf.denumire); //dezalocam char* si dupa aceea intregul nod.
        free(temp);
        temp = temp2;
    }
}

int main()
{
    int n;
    cout << "Nr produse:" << endl;
    cin >> n;
    nodls* cap = NULL; // initiem cu null
    produs p;
    char buffer[20];
    for (int i = 0; i < n; i++)
    {
        cout << "Cod: " << endl;
        cin >> p.cod;
        cout << "Denumire: " << endl;
        cin >> buffer;
        p.denumire = new char[strlen(buffer) + 1]; //alocam memorie si copiem buffer-ul in variabila
        strcpy_s(p.denumire, strlen(buffer) + 1, buffer);
        cout << "Pret: " << endl;
        cin >> p.pret;
        cout << "Cantitate: " << endl;
        cin >> p.cantitate;
        cap = inserare(cap, p); //inseram produsul in cap si capul in lista
        afisare(cap);
        free(p.denumire);
    }
    
}

