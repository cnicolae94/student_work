#include <iostream>

using namespace std;

//stiva

struct produs
{
	int cod;
	char* nume;
};

struct nodStiva
{
	produs inf;
	nodStiva* next;
};

nodStiva* push(nodStiva* varf, produs p)
{
	nodStiva* nou = new nodStiva;
	nou->inf.cod = p.cod;
	nou->inf.nume = new char[strlen(p.nume) + 1];
	strcpy_s(nou->inf.nume, strlen(p.nume) + 1, p.nume);
	nou->next = NULL;

	if (varf == NULL)
	{
		varf = nou;
	}

	else
	{
		nou->next = varf; //varful actual este trimis in spate.
		varf = nou; // noul varf este asignat in varf
	}
	return varf;
}

int pop(nodStiva** varf, produs* p) // stergerea ultimului element/ varfului 
{
	if (*varf == NULL)
	{
		return -1; //stiva e vida.
	}
	else  //deep copy + dezalocare
	{
		(*p).cod = (*varf)->inf.cod;
		(*p).nume = new char[strlen((*varf)->inf.nume) + 1];
		strcpy_s((*p).nume, strlen((*varf)->inf.nume) + 1, (*varf)->inf.nume);
		nodStiva* temp = *varf;
		*varf = (*varf)->next;

		delete[] temp->inf.nume; 
		delete temp;
		return 0;
	}
}

void traversare(nodStiva* varf)
{
	nodStiva* temp = varf;
	while (temp != NULL)
	{
		cout << "Cod: " << temp->inf.cod << " Nume: " << temp->inf.nume << endl;
		temp = temp->next;
	}
}

//coada

//struct produs
//{
//	char* nume;
//	int cod;
//};
//
//struct nodCoada
//{
//	produs inf;
//	nodCoada* next;
//};
//
//void put(nodCoada** prim, nodCoada** ultim, produs p)
//{
//	nodCoada* nou = new nodCoada;
//	nou->inf.cod = p.cod;
//	nou->inf.nume = new char[strlen(p.nume) + 1];
//	strcpy_s(nou->inf.nume, strlen(p.nume) + 1, p.nume);
//	nou->next = NULL;
//	if (*prim == NULL && *ultim == NULL)
//	{
//		*prim = nou;
//		*ultim = nou;
//	}
//	else
//	{
//		(*ultim)->next = nou; // punem pointerul la ultimul nod din coada (nou)
//		*ultim = nou; //aici devine nou ultimul nod
//	}
//}
//
//int get(nodCoada** prim, nodCoada** ultim, produs* p) // pointer peste tot
//{
//	if (*prim != NULL && *ultim != NULL)
//	{
//		(*p).cod = (*prim)->inf.cod;
//		(*p).nume = new char[strlen((*prim)->inf.nume) + 1];
//		strcpy_s((*p).nume, strlen((*prim)->inf.nume) + 1, (*prim)->inf.nume);
//
//		nodCoada* temp = *prim;
//		*prim = (*prim)->next;
//		delete[] temp->inf.nume;
//		delete temp;
//		return 0;
//	}
//	else
//	{
//		if (*prim == NULL)
//			*ultim = NULL;
//		return -1;
//	}
//}
//
//void traversare(nodCoada* prim)
//{
//	nodCoada* temp = prim;
//	while (temp != NULL)
//	{
//		cout << "Cod: " << temp->inf.cod << " Nume: " << temp->inf.nume << endl;
//		temp = temp->next;
//	}
//
//}

int main()
{
   
	produs p1;
	produs p2;

	nodStiva* varf = NULL;

	p1.cod = 1515;
	p1.nume = (char*)"Cosmetice";

	p2.cod = 13;
	p2.nume = (char*)"Alimente";
	
	
	//nodCoada *prim = NULL;
	//nodCoada *ultim = NULL;

	//put(&prim, &ultim, p1);
	//put(&prim, &ultim, p2);
	//traversare(prim);
	//get(&prim, &ultim, &p1); //referinta la toate cele 3
	//traversare(prim);


	varf = push(varf, p1);
	varf = push(varf, p2); 
	traversare(varf);
	cout << endl;
	pop(&varf, &p2);
	traversare(varf);
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
