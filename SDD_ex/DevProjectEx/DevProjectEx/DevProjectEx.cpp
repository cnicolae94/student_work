//Se consideră structura de tip articol Proiect utilizată pentru stocarea datelor specifice unui proiect
//de dezvoltare software dintr - o organizaţie / companie.Sa se realizeze funcţia pentru construirea unei 
//tabele de dispersie pe baza unei chei numerice din structura Proiect.Mecanismul de tratare a coliziunilor 
//este chaining.Datele de intrare sunt preluate dintr - un fişier text cu minim 20 de seturi de date de
//intrare(20 de proiecte).

#include <iostream>
#include <fstream>

using namespace std;

enum limbaje { 
    Java,
    Cpp, 
    CSharp, 
    COBOL, 
    SQL, 
    Python,
    Necunoscut,
};

ostream& operator<<(ostream& output, limbaje limbaj)
{
    switch (limbaj) {
        case 0:
            output << "Java";
            break;
        case 1:
            output << "C++";
            break;
        case 2:
            output << "C#";
            break;
        case 3:
            output << "COBOL";
            break;
        case 4:
            output << "SQL";
            break;
        case 5:
            output << "Python";
            break;
        case 6:
            output << "Necunoscut";
            break;
    }

    return output;
}

struct proiect
{
    int id;
    char* denumire;
    float durata;
    limbaje limbaj;
};

struct nodLS
{
    proiect inf;
    nodLS* next;
};

struct hashT
{
    nodLS** vect; // vectorul de liste sau lista de liste
    int size; // dimensiunea. 
};

int hashing(int cheie, hashT tabela)
{
    return cheie % tabela.size;
}

int inserare(hashT tabela, proiect p)
{
    int pozitie = 0;
    if (tabela.vect != NULL)
    {
        pozitie = hashing(p.id, tabela);
        nodLS* nou = new nodLS;
        nou->inf.denumire = new char[strlen(p.denumire) + 1];
        strcpy_s(nou->inf.denumire, strlen(p.denumire) + 1, p.denumire);
        nou->inf.id = p.id;
        nou->inf.durata = p.durata;
        nou->inf.limbaj = p.limbaj;
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

void traversareLista(nodLS* cap)
{
    nodLS* temp = cap;
    while (temp != NULL)
    {
        cout << "Proiectul are id-ul " << temp->inf.id << " denumirea " << temp->inf.denumire << 
            ". Durata acestuia va fi de " << temp->inf.durata << " si va fi scris in limbajul " << temp->inf.limbaj << "." << endl;
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
                cout << "Pozitie: " << i;
                traversareLista(tabela.vect[i]);
            }
        }
    }
}

void traversare(hashT tabela)
{
    if (tabela.vect != NULL)
    {
        for (int i = 0; i < tabela.size; i++)
        {
            if (tabela.vect[i] != NULL)
            {
                cout << "Pozitie: " << i << ": ";
                nodLS* temp = tabela.vect[i];
                while (temp != NULL)
                {
                    cout << "Proiectul are id-ul " << temp->inf.id << " denumirea " << temp->inf.denumire <<
                        ". Durata acestuia va fi de " << temp->inf.durata << " si va fi scris in limbajul " << temp->inf.limbaj << "." << endl;
                    temp = temp->next;
                }
            }
        }
    }
}

void dezalocareLista(nodLS* cap)
{
    nodLS* temp = cap;
    while (temp != NULL)
    {
        nodLS* temp2 = temp->next;
        delete[] temp->inf.denumire;
        delete temp;
        temp = temp2;
    }
}

void dezalocareTabela(hashT tabela)
{
    if (tabela.vect != NULL)
    {
        for (int i = 0; i < tabela.size; i++)
        {
            if (tabela.vect[i] != NULL)
                dezalocareLista(tabela.vect[i]); // aici indicam CARE lista sa o stearga.
        }
    }
}

void dezalocare(hashT tabela)
{
    if (tabela.vect != NULL)
    {
        for (int i = 0; i < tabela.size; i++)
        {
            if (tabela.vect[i] != NULL)
            {
                nodLS* temp = tabela.vect[i];
                while (temp)
                {
                    nodLS* temp2 = temp->next;
                    delete[] temp->inf.denumire;
                    delete[] temp;
                    temp = temp2;
                }
            }
        }
    }
}

void stergereNod(nodLS* nod)
{
    delete[] nod->inf.denumire;
    delete[] nod;
}

int stergere(hashT tabela, int id)
{
    int pozitie = 0;
    if (tabela.vect != NULL)
    {
        pozitie = hashing(id, tabela);
        if (tabela.vect[pozitie] == NULL)
            return -1;
        else
        {
            if (tabela.vect[pozitie]->inf.id == id) //id-ul din cadrul nodului
            {
                if (tabela.vect[pozitie]->next == NULL)
                {
                    stergereNod(tabela.vect[pozitie]);
                    tabela.vect[pozitie] = NULL;
                }
                else
                {
                    nodLS* temp = tabela.vect[pozitie];
                    tabela.vect[pozitie] = temp->next;
                    stergereNod(temp);
                }
            }
            else
            {
                nodLS* temp = tabela.vect[pozitie];
                while (temp->next != NULL && temp->next->inf.id != id)
                {
                    temp = temp->next;
                }
                nodLS* p = temp->next;
                if (p->next != NULL)
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
    //initializam tabela
    hashT tabela;
    tabela.size = 50; //nr specific?
    tabela.vect = (nodLS**)malloc(tabela.size * sizeof(nodLS*)); // initializam listele din vectorul de liste
    for (int i = 0; i < tabela.size; i++)
    {
        tabela.vect[i] = NULL; // listele vor fi goale
    }

    ifstream fisier;
    fisier.open("fisier.txt");
    proiect p;
    char buffer[20];
    int buffer2;
    int n;
    fisier >> n;

    for (int i = 0; i < n; i++)
    {
        fisier >> p.id;
        fisier >> buffer;
        p.denumire = (char*)malloc((strlen(buffer) + 1) * sizeof(char));
        strcpy_s(p.denumire, strlen(buffer) + 1, buffer);
        fisier >> p.durata;
        fisier >> buffer2;

        switch (buffer2)
        {
        case 1:
            p.limbaj = Java;
            break;
        case 2:
            p.limbaj = Cpp;
            break;
        case 3:
            p.limbaj = CSharp;
            break;
        case 4:
            p.limbaj = COBOL;
            break;
        case 5:
            p.limbaj = SQL;
            break;
        case 6:
            p.limbaj = Python;
            break;
        default:
            p.limbaj = Necunoscut;
            break;
        };
       
        inserare(tabela, p);
        //cout << hashing(p.id, tabela) << endl;
    }

    fisier.close();
    traversare(tabela);
  
    

    return 0;
}
