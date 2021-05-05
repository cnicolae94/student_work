#include <iostream>

using namespace std;

struct produs
{
    char* nume;
    int cod;
};

struct nodStiva
{
    produs inf;
    nodStiva* next;
};

nodStiva* push(nodStiva* varf, produs p)
{
    nodStiva* nou = new nodStiva;
    nou->inf.nume = new char[strlen(p.nume) + 1];
    strcpy_s(nou->inf.nume, strlen(p.nume) + 1, p.nume);
    nou->inf.cod = p.cod;
    nou->next = NULL;
    if (varf == NULL)
        varf = nou;
    else
    {
        nou->next = varf;
        varf = nou;
    }
    return varf;
}

int pop(nodStiva** varf, produs* p)
{
    if(*varf  == NULL)
        return -1;
    else
    {
        (*p).cod = (*varf)->inf.cod;
        (*p).nume = new char[strlen((*varf)->inf.nume) + 1];
        strcpy_s((*p).nume, strlen((*varf)->inf.nume) + 1, (*varf)->inf.nume);
        //copiem ce e in varf intr-un produs p 
        nodStiva* temp = *varf; 
        (*varf) = (*varf)->next;
        //salvam varful actual in temp pt a il putea sterge
        //varf->next devine noul varf.
        delete[] temp->inf.nume;
        delete temp;
        return 0;d
    }
}

void traversare(nodStiva* varf)
{
    nodStiva* temp = varf;
    while (temp != NULL)
    {
        cout << "Nume produs: " << temp->inf.nume << " cod produs: " << temp->inf.cod << endl;
        temp = temp->next;
    }
}

int main()
{
    std::cout << "Hello World!\n";
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
