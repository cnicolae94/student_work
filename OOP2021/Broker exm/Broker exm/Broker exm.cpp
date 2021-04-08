#include <iostream>
#include <fstream>
#include <stdio.h>
#include <string>

using namespace std;

class Conversie 
{
public:
	virtual float conversie(float curs) = 0;
};

class Asigurare : private Conversie
{
protected:
	string valuta;
private:
	char* nume;
	float suma;
	string tip;
	int durata;

public:

	Asigurare() 
	{
		valuta = "necunoscut";
		nume = nullptr;
		suma = 0;
		tip = "necunoscut";
		durata = 0;
	}

	Asigurare(string valuta, const char* nume, float suma, string tip, int durata)
	{
		this->valuta = valuta;
		if(nume != nullptr)
		{
			this->nume = new char[strlen(nume) + 1];
			strcpy_s(this->nume, strlen(nume) + 1, nume);
		}
		
		this->suma = suma;
		this->tip = tip;
		this->durata = durata;
	}

	~Asigurare()
	{
		cout << "Destructorul a fost apelat." << endl;
		if (nume != nullptr)
		{
			delete[] nume;
		}
	}

	Asigurare(const Asigurare& a) // se face fara this->
	{
		valuta = a.valuta;
		if (a.nume != nullptr)
		{
			nume = new char[strlen(a.nume) + 1];
			strcpy_s(nume, strlen(a.nume) + 1, a.nume);
		}

		suma = a.suma;
		tip = a.tip;
		durata = a.durata;
	}

	Asigurare operator=(const Asigurare& a) // se face cu this
	{
		this->valuta = a.valuta;
		if (a.nume != nullptr)
		{
			this->nume = new char[strlen(a.nume) + 1];
			strcpy_s(this->nume, strlen(a.nume) + 1, a.nume);
		}
		this->suma = a.suma;
		this->tip = a.tip;
		this->durata = a.durata;
	}

	float conversie(float curs)
	{
		//int curs;
		/*cout << "Introdu cursul de schimb:" << endl;
		cin >> curs;*/
		float sumaConvertita = 0;
		if (suma > 0)
		{
			sumaConvertita = suma / curs;
			return sumaConvertita;
		}
		else
		{
			cout << "Nu se poate face conversia.";
		}
		return 0;
	}

	char* getNume()
	{
		return nume;
	}

	void setNume(const char* nume)
	{
		if (this->nume != nullptr)
		{
			delete[] this->nume;
		}
		this->nume = new char[strlen(nume) + 1];
		strcpy_s(this->nume, strlen(nume) + 1, nume);
	}

	friend ostream& operator<< (ostream&, Asigurare&);
	friend istream& operator>> (istream&, Asigurare&);
	friend ifstream& operator<< (ifstream&, Asigurare);
	friend ofstream& operator>> (ofstream&, Asigurare); //doar afisam, fara referinta 
};

ostream& operator<<(ostream& iesire, Asigurare& a)
{ 
	iesire << "Asiguratul/Asigurata " << a.nume << " are o asigurare de tip " << a.tip << " pentru pretul de " << a.suma << " " << a.valuta << " pentru o perioada de " << a.durata << " luni." << endl;
	return iesire;
}

istream& operator>>(istream& intrare, Asigurare& a)
{
	cout << "Introdu numele asiguratului" << endl;
	char buffer[40];
	intrare >> buffer;
	a.setNume(buffer);
	cout << "Introdu moneda" << endl;
	intrare >> a.valuta;
	cout << "Introdu tipul asigurarii (RCA/CASCO):" << endl;
	intrare >> a.tip;
	cout << "Introdu pretul asigurarii" << endl;
	intrare >> a.suma;
	cout << "Introdu durata contractuala" << endl;
	intrare >> a.durata;
	return intrare;
}

int main()
{

	Asigurare a1("RON", "Gabi", 101, "rca", 15);
	//cout << a1.getNume() << endl;

	cout << a1 << endl;

	cout << a1.conversie(4.5) << endl;

	Asigurare a2(a1);

	Asigurare a3;

	cin >> a3;
	cout << a3;
	
		

	return 0;
}

