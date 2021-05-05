#include <iostream>

using namespace std;

struct produs
{
    int cod;
    char* nume;
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
    nou->prev = NULL;
    nou->next = NULL;
    if (cap == NULL)
    {
        cap = nou; 
        nou->prev = nou;
        nou->next = nou;
        *coada = nou;
    }
    else
    {
        nodls* temp = cap;
        while (temp->next != cap)
        {
            temp = temp->next;
        }
        temp->next = nou;
        nou->prev = temp;
        *coada = nou;
        (*coada)->next = cap;
        cap->prev = *coada; 
    }
    return cap;
  
}

void traversare(nodls* cap)
{
    nodls* temp = cap;
    while (temp->next != cap)
    {
        cout << "Cod: " << temp->inf.cod << "Nume: " << temp->inf.nume << endl;
        temp = temp->next;
    }
    cout << "Cod: " << temp->inf.cod << "Nume: " << temp->inf.nume << endl;
}

void traversareInversa(nodls* coada)
{
    nodls* temp = coada;
    while (temp->prev != coada)
    {
        cout << "Cod: " << temp->inf.cod << "Nume: " << temp->inf.nume << endl;
        temp = temp->prev;
    }
    cout << "Cod: " << temp->inf.cod << "Nusme: " << temp->inf.nume << endl;
}

void dezalocare(nodls* cap)
{
    nodls* temp = cap;
    while (temp->next != cap)
    {
        nodls* temp2 = temp->next;
        delete[] temp->inf.nume;
        delete[] temp;
        temp = temp2;
    }
    delete[] temp->inf.nume;
    delete[] temp;
}
    
int main()
{
    int n;
    produs p;
    nodls* cap = NULL;
    nodls* coada = NULL;
    
    cout << "Nr produse" << endl;
    cin >> n;
    char buffer[20];

    for (int i = 0; i < n; i++)
    {
        cout << "Introdu cod" << endl;
        cin >> p.cod;
        cout << "Introdu nume" << endl;
        cin >> buffer;
        p.nume = new char[strlen(buffer) + 1];
        strcpy_s(p.nume, strlen(buffer) + 1, buffer);
        cap = inserare(cap, &coada, p);
    }

    traversare(cap);
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
