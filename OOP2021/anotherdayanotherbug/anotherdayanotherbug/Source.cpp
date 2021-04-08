#include <iostream>
#include <string>

using namespace std;

enum grad {
	Usoara, Grea, FoarteGrea // lunile anului, etc - set ierarhic
};

//evidenta activitatilor unei persoane

class Activitate
{
private:
	const int idActivitate; // trb initializat un constructor

protected:
	char* denumire;
	string locatie; //char locatie[50];
	int durata; // in minute
	int nrObiecte; //de cate obiecte avem nevoie pt activitate
	string* denumireObiecte;
	float* greutateObiecte; 
// greutateObiecte vector numeric - mai multe obiecte, mai multe pointere, logic?
	grad gradDificultate;

public:
	static int numarator; //intializam dupa ce creem clasa

	Activitate() : idActivitate(numarator++) 
		//initializam inline cu idActivitate (care este numarator si incrementam pt nr ID)
	{
		this->denumire = new char[strlen(denumire) + 1];
		strcpy(this->denumire, denumire); 
		this->locatie = "Necunoscut";
		this->durata = 0;
		this->nrObiecte = 0;
		this->denumireObiecte = nullptr;
		this->greutateObiecte = nullptr;
		this->gradDificultate = Usoara;
	}

	//constructor cu toti parametrii 
	//recomandare: cu toti parametrii if otherwise requested in exam
	
	Activitate(const char* denumire, string locatie, int durata, int nrObiecte, string* denumireObiecte, float* greutateObiecte, grad gradDificultate) : idActivitate(numarator++)
	{
		//validarea pt char* 
		if (strlen(denumire) >= 3)  //sa aibe mai mult de 3 char
		{
			this->denumire = new char[strlen("") + 1];
			strcpy(this->denumire, (""));
		}
		else
		{
			this->denumire = new char[strlen("Necunoscut") + 1];

			strcpy(this->denumire, denumire);
		}
	}

	const int getIdActivitate()
	{
		return this->idActivitate;
	}

	char* getDenumire()
	{
		return this->denumire;
	}
	

//aici scriem toate atributele - se adauga CONST doar la CHAR sa dam noi numele de la tastatura,
//altfel trebuie sa ii dam noi adresa variabilei de unde sa ia denumirea
};

//cum se initializeaza un static
//in afara clasei
int Activitate::numarator = 1;

int main()
{
	
	Activitate a;
	cout << a.getIdActivitate() << endl;
	cout << a.getDenumire() << endl; 
	//return 0;
}