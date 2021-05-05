#include <iostream>

using namespace std;

struct produs
{
	int cod;
	char* nume;
	float pret;
	float cantitate;
};

struct nodls
{
	produs inf;
	nodls* next, * prev; //punem pointer la nume aparent
};

nodls* inserare(nodls* cap, nodls** coada, produs p)
{
	nodls* nou = new nodls;
	nou->inf.cod = p.cod;
	nou->inf.nume = new char[strlen(p.nume) + 1];
	strcpy_s(nou->inf.nume, strlen(p.nume) + 1, p.nume);
	nou->inf.pret = p.pret;
	nou->inf.cantitate = p.cantitate;
	
	nou->next = NULL;
	nou->prev = NULL;
	if (cap == NULL)
	{
		cap = nou;
		*coada = nou;
	}
	else
	{
		nodls* temp = cap;
		while (temp->next != NULL)
			temp = temp->next;
		temp->next = nou;
		nou->prev = temp;
		*coada = nou;
	}

	return cap; // returnam doar capul.
}

void traversare(nodls* cap, nodls** coada)
{
	nodls* temp = cap;
	while (temp != NULL)
	{
		cout << "Produs: " << temp->inf.nume << " cod: " << temp->inf.cod << " pret: " << temp->inf.pret << " cantitate: " << temp->inf.cantitate << endl;
		temp = temp->next;
	}
}

void traversareInversa(nodls* cap, nodls** coada)
{
	nodls* temp = *coada;
	while (temp != NULL)
	{
		cout << "Produs: " << temp->inf.nume << " cod: " << temp->inf.cod << " pret: " << temp->inf.pret << " cantitate: " << temp->inf.cantitate << endl;
		temp = temp->prev;
	}
}

void dezalocare(nodls* cap, nodls** coada) //primeste capul si coada ca parametru, dar algoritmul ramane la fel
{
	nodls* temp = cap;
	while (temp != NULL)
	{
		nodls* temp2 = temp->next; //temp next va fi stocat in temp 2 si capul in temp simplu.
		delete[] temp->inf.nume;
		delete[] temp;
		temp = temp2;
	}
}

void main()
{
	/*produs p1;
	p1.nume = (char*)"Cosmetice";
	p1.cod = 55;
	p1.cantitate = 10;
	p1.pret = 7.55;

	cap = inserare(cap, &coada, p1);
	traversare(cap, &coada);*/
	produs p;
	nodls* cap = NULL;
	nodls* coada = NULL;	
	
	
	char buffer[20];
	int n;
	
	cout << "Introdu numarul de produse:" << endl;
	cin >> n;

	for (int i = 0; i < n; i++)
	{
		cout << "Cod: " << endl;
		cin >> p.cod;
		cout << "Nume: " << endl;
		cin >> buffer;
		p.nume = new char[strlen(buffer) + 1];
		strcpy_s(p.nume,strlen(buffer)+1, buffer);
		cout << "Cantitate: " << endl;
		cin >> p.cantitate;
		cout << "Pret: " << endl;
		cin >> p.pret;
		cap = inserare(cap, &coada, p);
	}
	traversare(cap, &coada);
	traversareInversa(cap, &coada);
	dezalocare(cap, &coada);

}