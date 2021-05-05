#include <iostream>

using namespace std;

struct produs
{
    int cod;
    char* nume;
    float pret;
};

struct nodls
{
    produs inf;
    nodls* next, * prev;
};

nodls* inserare(nodls* cap, nodls** coada, produs p)
{
    nodls* nou = new nodls;
    nou->inf.cod = p.cod;
    nou->inf.nume = new char[strlen(p.nume) + 1];
    strcpy_s(nou->inf.nume, strlen(p.nume) + 1, p.nume);
    nou->inf.pret = p.pret;
    nou->prev = NULL;
    nou->next = NULL;
    if (cap == NULL)
    {
        cap = nou;
        //adaugam si next/prev + pointer la coada
        nou->prev = nou;
        nou->next = nou;
        (*coada) = nou;
    }
    else
    {
        nodls* temp = cap;
        while (temp->next != cap )
        {
            temp = temp->next;
        }
        temp->next = nou; //urm. nod devine nodul nou.
        nou->prev = temp; // nodul anterior "nou" este temp-ul 
        *coada = nou; // coada devine si ea tot nodul nou
        (*coada)->next = cap; // nodul urmator cozii va fi capul
        cap->prev = *coada; // supradefinim prev-ul capului care va fi *coada 

    }
    return cap;
}

void traversare(nodls* cap)
{
    nodls* temp = cap;
    while (temp->next != cap)
    {
        cout << "Nume produs: " << temp->inf.nume << " cod: " << temp->inf.cod << " pret: " << temp->inf.pret << endl;
        temp = temp->next;
    }
    cout << "Nume produs: " << temp->inf.nume << " cod: " << temp->inf.cod << " pret: " << temp->inf.pret << endl;
}

void traversareInversa(nodls* coada)
{
    nodls* temp = coada;
    while (temp->prev != coada)
    {
        cout << "Nume produs: " << temp->inf.nume << " cod: " << temp->inf.cod << " pret: " << temp->inf.pret << endl;
        temp = temp->prev;
    }
    cout << "Nume produs: " << temp->inf.nume << " cod: " << temp->inf.cod << " pret: " << temp->inf.pret << endl;
}

void dezalocare(nodls* cap)
{
    nodls* temp = cap;
    while (temp->next != cap) // sa fie diferit de cap, nu avem null in lista circulara
    {
        nodls* temp2 = temp->next;
        delete[] temp->inf.nume;
        delete[] temp;
        temp = temp2;
    }
    delete[] temp->inf.nume;
    delete[] temp; //stergem ultimul nod aici.
}

int main()
{
    produs p1;
    produs p2;
    nodls* cap = NULL;
    nodls* coada = NULL;
    p1.cod = 11;
    p1.nume = (char*)"cosmetice";
    p1.pret = 13.5;

    p2.cod = 22;
    p2.nume = (char*)"fructe";
    p2.pret = 7.7;

    cap = inserare(cap, &coada, p1);
    inserare(cap, &coada, p2);
    //traversare(cap);
    traversareInversa(coada);
    dezalocare(cap);

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
