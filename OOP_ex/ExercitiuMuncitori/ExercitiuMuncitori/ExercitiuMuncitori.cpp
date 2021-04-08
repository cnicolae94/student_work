#include <iostream>

using namespace std;

class Muncitor;

class Recalculare
{
public:
    virtual float spor() = 0;
};

class Muncitor : public Recalculare
{
private:
    char* nume;
    char* prenume;
    float salariuBaza;
    string nivel;
    
public:

    Muncitor()
    {
        nume = nullptr;
        prenume = nullptr;
        salariuBaza = 100;
        nivel = "Muncitor";
    }

    Muncitor(const char* nume, const char* prenume, float salariuBaza, string nivel)
    {
        if (nume != nullptr)
        {
            this->nume = new char[strlen(nume) + 1];
            strcpy_s(this->nume, strlen(nume) + 1, nume);
        }
        if (prenume != nullptr)
        {
            this->prenume = new char[strlen(prenume) + 1];
            strcpy_s(this->prenume, strlen(prenume) + 1, prenume);
        }
        this->salariuBaza = salariuBaza;
        this->nivel = nivel;
    }

    ~Muncitor()
    {
        if (nume != nullptr)
        {
            delete[] nume;
        }
        if (prenume != nullptr)
        {
            delete[] prenume;
        }
    }

    float spor()
    {
        float bonus = 0;

        if (this->nivel == "Muncitor calificat")
        {
            float bonus = this->salariuBaza * 0.1;
            return bonus;
        }
        else if (this->nivel == "Maistru")
        {
            float bonus = this->salariuBaza * 0.2;
            return bonus;
        }
        else if (this->nivel == "Inginer")
        {
            float bonus = this->salariuBaza * 0.3;
            return bonus;
        }
        else
        {
            cout << "Verifica datele muncitorului(calificarea)." << endl;
            return 0;
        }  
    }
};

int main()
{
    Muncitor m1;
    Muncitor m2("Ovidiu", "Popescu", 4520.80, "Inginer");

    cout << m2.spor() << endl;
    if (m1.spor() == 0)
    {
        cout << "Verifica datele muncitorului(calificarea)." << endl;
    }
    cout << m1.spor() << endl;
    cout << "Hai sa vedem" << endl;
}

