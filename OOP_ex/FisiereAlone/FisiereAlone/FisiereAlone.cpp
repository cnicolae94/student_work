#include <iostream>
#include <string>
#include <fstream>

using namespace std;


//class Dosar;

class Fisier
{
private:
    char* denumire;
    float dimensiune;
    string continut;
    char* extensie;
public:

    Fisier()
    {
        denumire = nullptr;
        dimensiune = 0;
        continut = "";
        extensie = nullptr;
    }

    Fisier(const char* denumire, float dimensiune, string continut, const char* extensie)
    {
        this->denumire = new char[strlen(denumire) + 1];
        strcpy_s(this->denumire, strlen(denumire) + 1, denumire);

        this->dimensiune = dimensiune;
        this->continut = continut;

        this->extensie = new char[strlen(extensie) + 1];
        strcpy_s(this->extensie, strlen(extensie) + 1, extensie);
    }

    ~Fisier()
    {
        if (denumire != nullptr)
        {
            delete[] denumire;
        }
        if (extensie != nullptr)
        {
            delete[] extensie;
        }
    }

    Fisier(const Fisier& f)
    {
        if (f.denumire != nullptr)
        {
            this->denumire = new char[strlen(f.denumire) + 1];
            strcpy_s(this->denumire, strlen(f.denumire) + 1, f.denumire);
        }

        this->dimensiune = f.dimensiune;
        this->continut = f.continut;

        if (f.extensie != nullptr)
        {
            this->extensie = new char[strlen(f.extensie) + 1];
            strcpy_s(this->extensie, strlen(f.extensie) + 1, f.extensie);
        }
    }

    char* getDenumire()
    {
        return this->denumire;
    }

    void setDenumire(char* denumire)
    {
        if (denumire != nullptr)
        {
            this->denumire = new char[strlen(denumire) + 1];
            strcpy_s(this->denumire, strlen(denumire) + 1, denumire);
        }
    }

    char* getExtensie()
    {
        return this->extensie;
    }

    void setExtensie(char* extensie)
    {
        if (extensie != nullptr)
        {
            this->extensie = new char[strlen(extensie) + 1];
            strcpy_s(this->extensie, strlen(extensie) + 1, extensie);
        }
    }

    string getContinut()
    {
        return this->continut;
    }

    void setContinut(string continut)
    {
        if (sizeof(continut) > 0)
        {
            this->continut = continut;
        }
    }

    friend ostream& operator<<(ostream& out, Fisier& f);
    friend istream& operator>>(istream& in, Fisier& f);
    friend ofstream& operator<<(ofstream& fout, Fisier f);
    
    void save()
    {
        ofstream f;
        f.open("fisier.txt", ios::app);
        f << "Denumirea fisierului este " << this->denumire << "." << this->extensie << " si are continut " << this->continut << endl;
    }

    void operator!()
    {
        string line;
        ifstream fin;
            if (this->denumire != nullptr)
            {
                ofstream f;
                f.open("fisier.txt");
                ifstream finf;

            }

    }
};

class Dosar
{
private:
    string denumireD;
    float dimensiuneD;
    int nrFisiere;
    int nrDosare;
    Fisier* fisiere;
    Dosar* dosare;

public:
    Dosar()
    {
        denumireD = nullptr;
        dimensiuneD = 0;
        nrFisiere = 0;
        nrDosare = 0;
        fisiere = nullptr;
        dosare = nullptr;
    }

    Dosar(string denumireD, float dimensiuneD,int nrFisiere, int nrDosare, Fisier* fisiere, Dosar* dosare)
    {
        this->denumireD = denumireD;
        this->dimensiuneD = dimensiuneD;
        this->nrFisiere = nrFisiere;
        this->nrDosare = nrDosare;
        
        this->fisiere = new Fisier[nrFisiere];
        for (int i = 0; i < nrFisiere; i++)
        {
            this->fisiere[i] = fisiere[i];
        }

        this->dosare = new Dosar[nrDosare];
        for (int j = 0; j < nrDosare; j++)
        {
            this->dosare[j] = dosare[j];
        }
    }

    ~Dosar()
    {
        if (fisiere != nullptr)
        {
            delete[] fisiere;

        }
        if (dosare != nullptr)
        {
            delete[] dosare;
        }
    }

};

ostream& operator<<(ostream& out, Fisier& f)
{
    out << "Fisierul " << f.denumire << "." << f.extensie << " are continut " << f.continut << " si o dimensiune de " << f.dimensiune << endl;
    return out;
}

istream& operator>>(istream& in, Fisier& f)
{
    cout << "Introdu numele fisierului(daca exista deja, va fi inlocuit): " << endl;
    if (f.denumire != nullptr)
    {
        delete[] f.denumire;
    }
    char buffer[30];
    in >> buffer;
    f.setDenumire(buffer);
    cout << "Introdu extensia fisierului: " << endl;
    if (f.extensie != nullptr)
    {
        delete[] f.extensie;
    }
    char temp[30];
    in >> temp;
    f.setExtensie(temp);
    cout << "Introdu continutul fisierului: " << endl;
    in >> f.continut;
    cout << "Introdu dimensiunea fisierului: " << endl;
    in >> f.dimensiune;
    return in;
}


ofstream& operator<<(ofstream& fout, Fisier f)
{
    if (fout.is_open())
    {
        fout << "Denumirea fisierului este: ";
        if (f.denumire != nullptr)
        {
            fout << f.denumire << endl;
        }
        else
        {
            fout << "necunoscut" << endl;
        }
        fout << "Dimensiunea: " << f.dimensiune << endl;

        fout << "Continutul: " << f.continut << endl;
    }

    return fout;
}



int main()
{
    Fisier f1("Fisier1", 15.2, "Audio", "mp3");

    //cout << f1.getContinut() << endl;

    //f1.setContinut("Muzica");

    //cout << f1.getContinut() << endl;

    //cout << f1 << endl;

    cout << sizeof(f1) << endl;

    //cout << sizeof(float) << "." << sizeof(char*) << "." << sizeof(string) << endl;
    Fisier f2(f1);
   /* cout << f1;
    cin >> f1;
    cout << f1;*/

    Fisier f3("Test", 50, "Testare", "tst");

    f3.save();

    cout << "S-a scris" << endl;

    return 0;
}
