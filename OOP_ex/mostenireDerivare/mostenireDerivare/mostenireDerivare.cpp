#include <fstream>
#include <iostream>

using namespace std;

class Vehicul
{
public:
    char* denumire;
    int anProductie;
private:
    int nrLocuri;
protected:
    float capCilindrica;

public:
    Vehicul()
    {
        denumire = nullptr;
        nrLocuri = 0;
        capCilindrica = 0;
        anProductie = 0;

    }

    Vehicul(const char* denumire, int nrLocuri, float capCilindrica, int anProductie) 
    {
        if (denumire != nullptr) 
        {
            this->denumire = new char[strlen(denumire) + 1];
            strcpy_s(this->denumire, strlen(denumire) + 1, denumire);
        }
        this->nrLocuri = nrLocuri;
        this->capCilindrica = capCilindrica;
        this->anProductie = anProductie;
    }

    Vehicul(const Vehicul& v) //constructor copiere
    {
        if (v.denumire != nullptr)
        {
            delete[] denumire;
        }
        denumire = new char[strlen(v.denumire) + 1];
        strcpy_s(denumire, strlen(v.denumire) + 1, v.denumire);
        nrLocuri = v.nrLocuri;
        capCilindrica = v.capCilindrica;
        anProductie = v.anProductie;
    }

    Vehicul operator=(const Vehicul& v) //supraincarcare =
    {
        if (v.denumire != nullptr)
        {
            delete[] v.denumire;
        }
        this->denumire = new char[strlen(v.denumire) + 1];
        strcpy_s(this->denumire, strlen(v.denumire) + 1, v.denumire); 
        this->nrLocuri = v.nrLocuri;
        this->capCilindrica = v.capCilindrica;
        this->anProductie = v.anProductie;
        return *this;
    }

    ~Vehicul()
    {
        if (denumire)
        {
            delete[] denumire;
        }   
    }

    virtual void deplasare()
    {
        cout << "Vehiculul se deplaseaza." << endl;
    }

    //char operator[] (int i)
    //{
    //    if (this->denumire != 0) 
    //    {
    //        if (i > 0 && i < strlen(this->denumire))
    //        {
    //            return denumire[i];
    //        }
    //    }
    //}

    friend ostream& operator<<(ostream&, Vehicul&);

};

ostream& operator<<(ostream& iesire, Vehicul& v)
{
    iesire << "Vehiculul cu denumirea " << v.denumire << " are " << v.nrLocuri << " locuri, este fabricata in " << v.anProductie <<" si o capacitate cilindrica de " << v.capCilindrica << endl;
    return iesire;
}

class Impozit // clasa abstracta
{
public:
    virtual float impozitare() = 0; // functie virtuala pura 
};

class Asigurare
{
public:
    virtual void asigurare() = 0;
};

class Masina : public Vehicul, private Impozit, public Asigurare
{
public: 
    char* nrInmatriculare;

    Masina()
    {
        nrInmatriculare = nullptr;
    };

    Masina(const char* denumire, int nrLocuri, float capCilindrica, int anProductie, const char* nrInmatriculare) : Vehicul(denumire, nrLocuri, capCilindrica, anProductie)
    {
        if (nrInmatriculare != nullptr) {
            this->nrInmatriculare = new char[strlen(nrInmatriculare) + 1];
            strcpy_s(this->nrInmatriculare, strlen(nrInmatriculare) + 1, nrInmatriculare);
        }
    }

    ~Masina()
    {
        cout << endl << "Destructorul masina a fost apelat pentru masina " << this->denumire << endl; //thats cool
        if (nrInmatriculare != nullptr)
        {
            delete[] nrInmatriculare;
        }
        
    }




    void deplasare()
    {
        cout << "Masina se deplaseaza pe uscat." << endl;
    }

    float impozitare()  //trb definita, altfel compilatorul va da eroare
    {
        if (this->capCilindrica < 2)
        {
            return 50;
        }
        else return 100;
    }

    void asigurare()
    {
        if (this->anProductie < 2005)
        {
            cout << "Masina nu poate fi asigurata." << endl;
        }
        else
        {
            cout << "Masina poate fi asigurata." << endl;
        }

    }

    
};



int main()
{
    Vehicul v1;
    Vehicul v2("Terestru", 10, 1992, 1.2);
    //Vehicul v3;
    Vehicul v3 = v2;
    cout << v2;
  
    Masina m1("Volvo", 5, 1.4, 1994, "AABBCCC");
    cout << m1 << endl;
    Masina m2("BMW", 2, 2.1, 2000, "B105CCC");
    cout << m2.denumire << endl;

 
    //v1 = m2; //orice vehicul e o masina

    //cout << v1.denumire << endl;

    Vehicul* pv = &v2;
    Masina* pm = &m2;

    pv->deplasare();
    pm->deplasare();

    pv = pm; //compilatorul stie ca adresa duce la masina si apeleza functia din cadrul clasei masina

    pv->deplasare();

    cout << m2.impozitare() << endl;

  

    m2.asigurare();


    return 0;

}
