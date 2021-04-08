#include <stdio.h>
#include <iostream>

using namespace std;

struct apelUrgenta
{
	int prioritate;
	char* apelant;
};

struct heap
{
	apelUrgenta* vect; //vector cu nr de elemente
	int nrElem;
};

void filtrare(heap h, int index)
{
	int indexMax = index;
	int indexS = 2 * index + 1;
	int indexD = 2 * index + 2;

	if(indexS < h.nrElem && h.vect[indexS].prioritate > h.vect[indexMax].prioritate)
		indexMax = indexS;//interschimbam

	if (indexD < h.nrElem && h.vect[indexD].prioritate > h.vect[indexMax].prioritate)
		indexMax = indexD;

	if (index != indexMax)
	{
		apelUrgenta temp = h.vect[index];
		h.vect[index] = h.vect[indexMax];
		h.vect[indexMax] = temp;
		
	}
}

void inserare(heap* h, apelUrgenta elem)
{
	apelUrgenta* vect1 = new apelUrgenta[(*h).nrElem + 1];
	for(int i = 0; i < (h*).nrElem; i++)
		vect1[i] = (*h).vect[i];

	(*h).nrElem++;
	delete[](*h).vect;
	(*h).vect = vect1;

	(*h).vect[(*h).nrElem - 1] = elem;

	for (int i =0; ((*h).nrElem - 1) / 2; i >= 0; i--)
	{
		filtrare(h, indexMax);
	}
}

void extragere(heap* h, apelUrgenta* elem)
{
	//apelUrgenta* vect1 = (apelUrgenta*)malloc(((*h).nrElem - 1) * sizeof(apelUrgenta));
	apelUrgenta* vect1 = new apelUrgenta[(*h).nrElem - 1];

	apelUrgenta temp = (*h).vect[0]; // interschimbam ultimul elem cu ultimul vector
	(*h).vect[0] = (*h).vect[(*h).nrElem - 1];
	(*h).vect[(*h).nrElem - 1] = temp;

	*elem = (*h).vect[(*h).nrElem - 1]; // elementul maxim care se afla pe ultima pozitie in vector

	for (int i = 0; i < (*h).nrElem - 1; i++)
		vect1[i] = (*h).vect[i];

	(*h).nrElem--;
	//free((*h).vect);
	delete[](*h).vect;
	(*h).vect = vect1; // noul vector

	for (int i = ((*h).nrElem - 1) / 2; i >= 0; i--)
		filtrare((*h), i); // filtrare de jos in sus
}

int main()
{
	return 0;
}
