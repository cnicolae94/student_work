#include <iostream>

using namespace std;

struct produs
{
    char* nume;
    int cod;
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
    nodls* nou = new nodls;
    nou->inf.nume = new char[strlen(p.nume) + 1];
    strcpy_s(nou->inf.nume, strlen(p.nume) + 1, p.nume);
    nou->inf.cod = p.cod;
    nou->inf.pret = p.pret;
    nou->inf.cantitate = p.cantitate;
    nou->next = NULL; // initializare nod inclusiv next care e null.
    if (cap == NULL)
        cap = nou;
    else
    {
        nodls* temp = cap;
        while (temp->next != NULL)
        {
            temp = temp->next;
        }
        temp->next = nou;
    }
    return cap;
}

void afisare(nodls* cap)
{
    nodls* temp = cap;
    while(temp != NULL)
    {
        cout << "Nume produs: " << temp->inf.nume << " Pret: " << temp->inf.pret << " Cod: " << temp->inf.cod << " Cantitate: " << temp->inf.cantitate << endl;
        temp = temp->next;
    }
}

void dezalocare(nodls* cap)
{
    nodls* temp = cap;
    while (temp->next != NULL)
    {
        nodls* temp2 = temp->next;  //pointer la urmatorul 
        delete[] temp->inf.nume;
        delete[] temp;
        temp = temp2;
    }
}

int main()
{
    produs p1;
    produs p2;

 
    p1.nume = (char*)"Banane";
    p1.cantitate = 30;
    p1.cod = 1212;
    p1.pret = 10.1;
     
    p2.nume = (char*)"Nuci de cocos";
    p2.cantitate = 20;
    p2.cod = 1313;
    p2.pret = 7.5;

    nodls* cap = NULL;
    //inserare(cap, p1);
    cap = inserare(cap, p1);
    inserare(cap, p2);
    afisare(cap);
    dezalocare(cap);

    

}