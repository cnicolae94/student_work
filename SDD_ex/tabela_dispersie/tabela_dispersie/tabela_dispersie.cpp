#include <iostream>
using namespace std;

struct student
{
    int cod;
    char* nume;
};

struct nodLS
{
    student inf;
    nodLS* next;
};

struct hashT //hashtable
{
    nodLS** vect; // vector de liste simple
    int size; 
};

int functieHash(int cheie, hashT tabela)
{
    return cheie % tabela.size; //  modulo marimea tabelei - se schimba dinamic, deci?
}

int inserare(hashT tabela, student s)
{
    int pozitie = 0; // initializam pozitia cu 0
    if (tabela.vect != NULL)
    {
        pozitie = functieHash(s.cod, tabela); // cheia va fi codul unic de student si tabela introdusa.
        nodLS* nou = (nodLS*)malloc(sizeof(nodLS));
        nou->inf.cod = s.cod;
        nou->inf.nume = new char[strlen(s.nume) + 1];
        strcpy_s(nou->inf.nume, strlen(s.nume) + 1, s.nume);
        nou->next = NULL;
        if (tabela.vect[pozitie] == NULL)
            tabela.vect[pozitie] = nou;
        else
        {
            nodLS* temp = tabela.vect[pozitie]; //pointer omg
            while (temp->next != NULL) 
            {
                temp = temp->next;
            }
            temp->next = nou;
        }
    }
    return pozitie; // pt ca functia este int, returnam pozitia.
}

void traversareLista(nodLS* cap)
{
    nodLS* temp = cap;
    while (temp != NULL)
    {
        cout << "Student:" << temp->inf.nume << " cod: " << temp->inf.cod;
        temp = temp->next;
    }
}

void traversareTabela(hashT tabela)
{
    if (tabela.vect != NULL)
    {
        for (int i = 0; i < tabela.size; i++)
        {
            if (tabela.vect[i] != NULL)
            {
                cout << "Pozitia: " << i << endl;
                traversareLista(tabela.vect[i]);
            }
        }
    }

}

void traversare(hashT tabela) //ia ca parametru tabela pe care sa o parcurga
{
    if (tabela.vect != NULL)
    {
        for (int i = 0; i < tabela.size; i++)
            if (tabela.vect[i] != NULL)
            {
                cout << "Pozitia: " << i << endl;
                nodLS* temp = tabela.vect[i];
                while (temp)
                {
                    cout << "Student:" << temp->inf.nume << " cod: " << temp->inf.cod;
                    temp = temp->next;
                }
            }
    }
}

int main()
{
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
