#include <fstream>
#include <iostream>

//O companie de electricitate implementează o aplicație de gestiune a încasării plăților
//facturilor de energie electrică.Încasările ajung în sistem pe două canale : încasări 
//prin canale electronice și încasări prin ghiseele companiei.Fiecare încasare conține
//informații referitoare la facturile încasate.Definiți structura Factura ce conține : 
//cod client(string de tip char*), valoare factura(numeric fara semn), data emiterii(string
//de tip char*), data scadentă(string de tip char*), canal încasare(valoare în mulţimea{ 
//electronic, ghiseu }).Aplicația trebuie să încarce datele despre facturi 
//într - o structură de date de tip tabelă de dispersie care permite structurarea
//încasărilor după valoarea facturilor.Mecanismul de evitare a coliziunilor este chaining.
//Datele de intrare sunt preluate dintr - un fisier text ce conține minim 5 înregistrări.

using namespace std;

enum incasare
{
    electronic,
    ghiseu,
};

struct factura
{
    char* cod;
    unsigned int valoare;
    char* emitere;
    char* scadenta;
    incasare metoda;
};

struct nodLS
{
    factura inf;
    nodLS* next;
};

struct hashT
{
    nodLS** vect;
    int size;
};

int hashing(char cheie[20], hashT tabela) // primeste ca parametru o cheie, alfanumerica, si tabela
{
    return cheie[0] % tabela.size;
}

int inserare(hashT tabela, factura f)
{
    int pozitie = 0;
    if (tabela.vect != NULL)
    {
        pozitie = hashing(f.cod, tabela);
        nodLS* nou = new nodLS;
        nou->inf.cod = new char[strlen(f.cod) + 1];
        strcpy_s(nou->inf.cod, strlen(f.cod) + 1, f.cod);
        nou->inf.valoare = f.valoare;
        nou->inf.emitere = new char[strlen(f.emitere) + 1];
        strcpy_s(nou->inf.emitere, strlen(f.emitere) + 1, f.emitere);
        nou->inf.scadenta = new char[strlen(f.scadenta) + 1];
        strcpy_s(nou->inf.scadenta, strlen(f.scadenta) + 1, f.scadenta);
        nou->inf.metoda = f.metoda;
        nou->next = NULL;
        if (tabela.vect[pozitie] == NULL)
            tabela.vect[pozitie] = nou;
        else
        {
            nodLS* temp = tabela.vect[pozitie];
            while (temp->next != NULL)
                temp = temp->next;
            temp->next = nou;
        }
    }
    return pozitie;
}

ostream& operator<<(ostream& out, incasare metoda)
{
    switch (metoda)
    {
    case electronic:
        out << "electronic";
        break;
    case ghiseu:
        out << "ghiseu";
        break;
    default:
        out << "neplatit";
        break;
    }
    return out;
}

void traversareLista(nodLS* cap)
{
    nodLS* temp = cap;
    while (temp)
    {
        cout << "Factura pentru client" << temp->inf.cod << " a fost emisa la data de " << temp->inf.emitere
            << "cu valoarea de " << temp->inf.valoare << ". Factura a fost scadenta la data de " << temp->inf.scadenta
            << " si a fost incasata (la) " << temp->inf.metoda << endl;
        temp = temp->next;
    }
}

void traversareTabela(hashT tabela)
{
    if (tabela.vect != NULL)
    {
        for(int i = 0 ; i < tabela.size ; i++)
            if (tabela.vect[i] != NULL)
            {
                cout << "Pozitie:" << i;
                traversareLista(tabela.vect[i]);
            }
    }
}

//void traversare(hashT tabela)
//{
//    if (tabela.vect != NULL)
//    {
//        for (int i = 0; i < tabela.size; i++)
//        {
//            if (tabela.vect[i] != NULL)
//            {
//                cout << "Pozitie:" << i;
//                nodLS* temp = tabela.vect[i];
//                while (temp)
//                {
//                    cout << "Factura pentru client" << temp->inf.cod << " a fost emisa la data de " << temp->inf.emitere
//                        << "cu valoarea de " << temp->inf.valoare << ". Factura a fost scadenta la data de " << temp->inf.scadenta
//                        << " si a fost achitata in mod: " << temp->inf.metoda << endl;
//                    temp = temp->next;
//
//                }
//            }
//        }
//    }
//}

void dezalocareLista(nodLS* cap)
{
    nodLS* temp = cap;
    while (temp)
    {
        nodLS* temp2 = temp->next;
        delete[] temp->inf.cod;
        delete[] temp->inf.emitere;
        delete[] temp->inf.scadenta;
        delete temp;
        temp = temp2;
    }
}

void dezalocareTabela(hashT tabela)
{
    if (tabela.vect != NULL)
    {
        for(int i = 0; i < tabela.size; i++)
        {
            if (tabela.vect[i] != NULL)
            {
                dezalocareLista(tabela.vect[i]);
            }
        }
    }
}

void stergereNod(nodLS* nod)
{
    delete[] nod->inf.cod;
    delete[] nod->inf.emitere;
    delete[] nod->inf.scadenta;
    delete nod;
}

int stergere(hashT tabela, char cod[20])
{
    int pozitie = 0;
    if (tabela.vect != NULL)
    {
        pozitie = hashing(cod, tabela);
        if (tabela.vect[pozitie] == NULL)
            return -1;
        else
        {
            if (strcmp(tabela.vect[pozitie]->inf.cod, cod) == 0)
            {
                if (tabela.vect[pozitie]->next == NULL)
                {
                    stergereNod(tabela.vect[pozitie]);
                    tabela.vect[pozitie] == NULL;
                }
                else
                {
                    nodLS* temp = tabela.vect[pozitie];
                    stergereNod(temp);
                }
            }
            else
            {
                nodLS* temp = tabela.vect[pozitie];
                while (temp->next != NULL && strcmp(temp->next->inf.cod, cod) != 0)
                    temp = temp->next;
                nodLS* p = temp->next;
                if (p != NULL)
                {
                    temp->next = p->next;
                    stergereNod(p);
                }
                else
                {
                    temp->next = NULL;
                    stergereNod(p);
                }

            }
            
        }
    }
    return pozitie;
}

int main()
{
    hashT tabela;
    tabela.size = 101;
    tabela.vect = (nodLS**)malloc(tabela.size * sizeof(nodLS*));
    //size * vector = vector de vectori
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
