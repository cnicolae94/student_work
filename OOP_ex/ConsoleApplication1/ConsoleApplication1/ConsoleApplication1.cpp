#include <iostream>
#include <string>

using namespace std;


class Cabinet
{
private:
    static string nume;
   
protected:
    string oras;
    char* nrTelefon;
    int nrMedici;

public:
    const int codUnic;

    Cabinet() : codUnic(500)
    {
        oras = "Bucuresti";
        nrTelefon = nullptr;
        nrMedici = 10;

    }

    Cabinet(string oras, char* nrTelefon, int nrMedici) : codUnic(500)
    {
        this->oras = oras;
        if (nrTelefon != nullptr)
        {
            this->nrTelefon = new char[strlen(nrTelefon) + 1];
            strcpy_s(this->nrTelefon, strlen(nrTelefon) + 1, nrTelefon);
        }
        else
        {
            this->nrTelefon = nullptr;
        }
        this->nrMedici = nrMedici;
        this->nrTelefon = nullptr; 
    }

    string getOras()
    {
        return oras;
    }

    void setOras(string)
    {
        if (size(oras) > 5)
        {
            this->oras = oras;
        }
        else
        {
            oras = "Necunoscut";
        }
        
    }

};
string Cabinet::nume = "Stomatodental";

int main()
{
    Cabinet c1;
    cout << c1.getOras() << endl;
    string oras = "Arad";
    char telefon[11] = "0785855855";
    Cabinet c2("Arad", telefon, 10);
    cout << c2.getOras() << endl;

}
//
//
//
//class Vaccin
//{
//public: 
//    const int id;
//
//    Vaccin() : id(++cantitate)
//    {
//        denumire = nullptr;
//        this->producator = "Undefined";
//        this->temperaturaTransport = 7.50;
//    }//constructorul implicit
//
//    Vaccin(char* denumire, string producator, double temperaturaTransport) : id(++cantitate) // constructor explicit
//    {
//        if (denumire != nullptr)                                //validare
//        {
//            this->denumire = new char[strlen(denumire) + 1];
//            strcpy_s(denumire, strlen(denumire) + 1, denumire);
//        }
//        else 
//        {
//            denumire = nullptr;
//        }
//        this->producator = producator;
//        this->temperaturaTransport = temperaturaTransport;
//    }
//  /*  ~Vaccin()    //destructor
//    {
//        if (denumire != nullptr)
//        {
//            delete[] denumire;
//        }
//    }*/
//
//
//
//    int getId()
//    {
//        return id;
//    }
//
//
//private:
//    static int cantitate;
//
//protected:
//    char* denumire;
//    string producator;
//    double temperaturaTransport;
//
//
//};
//
//int Vaccin::cantitate = 0;  //scriem fara static in afara clasei si int main
//
//    //class vaccinCovid : public Vaccin
//    //{
//    //
//    //};
//
//int main()
//{
// /*   char den1[8] = "Vaccin1";
//    Vaccin v2(den1, "Pfizer", 7.50);
//    cout << "Hello bitches" << endl;*/
//    Vaccin v1;
//    cout << v1.getId() << endl;
//    
//}
