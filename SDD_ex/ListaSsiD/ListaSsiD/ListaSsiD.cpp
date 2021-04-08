#include <stdio.h>
#include <iostream>
#include <fstream>

using namespace std;
struct Student {
	int id;
	char* nume;
	float medie;
};

int main{
	Student stud;
stud.nume = (char*)malloc((strlen("Ionescu") + 1) * sizeof(char));
strcpy(stud.nume, "Ionescu");
if (stud.nume)
free(stud.nume);
stud.nume = (char*)malloc((strlen("Vasilescu") + 1) * sizeof(char));
strcpy(stud.nume, "Vasilescu");

return 0;
}


//
//struct produs
//{
//    int cod;
//    char* denumire;
//    float pret;
//    float cantitate;
//};
//
//struct nodls
//{
//    produs info;
//    nodls* next;
//};
//
//nodls* inserare(nodls* cap, produs p) //parametrii vor fi capul de lista? si un produs oarecare
//{
//    nodls* nou = (nodls*)malloc(sizeof(nodls));
//    nou->info.cod = p.cod;
//    nou->info.denumire = (char*)malloc((strlen(p.denumire)+1) * sizeof(char));
//    strcpy(nou->info.denumire, p.denumire); //strcpy are 2 parametri, destinatia si sursa
//    nou->info.pret = p.pret;
//    nou->info.cantitate = p.cantitate;
//    nou->next = NULL; //noul nod e initiat cu null!!
//    if (cap == NULL)
//        cap = nou;
//    else
//    {
//        nodls* temp = cap;
//        while (temp->next != NULL)
//            temp = temp->next;   //atata timp cat next nu e null, se sare la urmatorul nod si se verifica din nou
//        temp->next = nou; //cand conditia temp->next==NULL , adauga nodul "nou" creat anteriot functiei if else
//    }
//    return cap;
//}
//
//void traversare(nodls* cap)
//{
//    nodls* temp = cap;
//    while (temp != NULL) //nu nextul, ci actualul trb sa fie diferit de null
//    {
//        cout << "Cod: " << temp->info.cod << " " << "Denumire: " << temp->info.denumire << " " << "Pret:  " << temp->info.pret << " " << "Cantitate: " << temp->info.cantitate << endl;
//        temp = temp->next;
//    }
//}
//
//void dezalocare(nodls* cap)
//{
//    nodls* temp = cap;
//    while (temp != NULL)
//    {
//        nodls* temp2 = temp->next;
//        free(temp->info.denumire); 
//        free(temp);
//        temp = temp2; 
//    }
//}
//
//int main()
//{
//    int n;
//
//    cout << "Introdu numarul  de produse: " << endl;
//    cin >> n;
//    nodls* cap = NULL;
//    produs p;
//
//    char buffer[20];
//    for (int i = 0; i < n; i++)
//    {
//        cout << "Cod produs: ";
//        cin >> p.cod;
//        cout << "Denumire produs: ";
//        cin >> buffer;
//        p.denumire = new char[strlen(buffer) + 1];
//        strcpy_s(p.denumire, (strlen(buffer) + 1), buffer);
//        cout << "Pret produs: ";
//        cin >> p.pret;
//        cout << "Cantitate produs: ";
//        cin >> p.cantitate;
//        cout << endl;
//
//        cap = inserare(cap, p);
//        free(p.denumire);
//    }
//    traversare(cap);
//    dezalocare(cap);
//
//    return 0;
//}