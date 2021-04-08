#include <iostream>
#include <string>
#include <fstream>

using namespace std;


class Student
{
private:
    char* nume;
    int matricol;
    float medie;

public:

    Student() 
    {
        nume = nullptr;
        matricol = 0;
        medie = 5;
    }

    Student(const char* nume, int matricol, float medie) 
    {
        this->nume = new char[strlen(nume) + 1];
        strcpy_s(this->nume, strlen(nume) + 1, nume);

        this->matricol = matricol;
        this->medie = medie;
        
    }

    ~Student()
    {
        cout << "Destructorul a fost apelat." << endl;

        if (nume != nullptr)
        {
            delete[] nume;
        }
    }

    Student(const Student& s) //constructor de copiere
    {
        if (s.nume != nullptr)
        {
            this->nume = new char[strlen(s.nume) + 1];
            strcpy_s(this->nume, strlen(s.nume) + 1, s.nume);
        }
        else
        {
            this->nume = nullptr;
        }
        this->matricol = s.matricol;
        this->medie = s.medie;
    }

    char* getNume()
    {
        return nume;
    }

    void setNume(const char* nume)
    {
        if (this->nume != nullptr)
            delete[] this->nume;

        if (strlen(nume) > 3) {
            this->nume = new char[strlen(nume) + 1];
            strcpy_s(this->nume, strlen(nume) + 1, nume);
        }
        
        
    }

    int getMatricol()
    {
        return matricol;
    }

    void setMatricol(int matricol)
    {
        if (matricol != 0)
            this->matricol = matricol;
        else
            matricol = 0;
    }

    float getMedie()
    {
        return medie;
    }

    void setMedie(float)
    {
        this->medie = medie;
    }

    //supraincarcarea =, in cadrul clasei
    
    Student& operator=(const Student& s) //student prin referinta
    {
        if (this->nume != nullptr)
            delete[] this->nume;
        this->nume = new char[strlen(s.nume) + 1];
        strcpy_s(this->nume, strlen(s.nume) + 1, s.nume);
        this->matricol = s.matricol;
        this->medie = s.medie;
    }

    double operator+ (Student& s)
    {
        return this->medie + s.medie;
    }

    char operator[] (int i)
    {   
        if (this->nume != 0) {
            if (i > 0 && i < strlen(this->nume))
            {
                return nume[i];
            }
        }
        
    }

    operator int()
    {
        return this->medie;
    }

    friend const Student& operator++(Student&);
    friend const Student operator++(Student&, int);

    friend double operator+(Student&, double);
    friend double operator+(double, Student&);

    friend istream& operator>> (istream&, Student&);
    friend ostream& operator<< (ostream&, Student); //prin valoare pt ca doar il afisam
};

const  Student& operator++(Student& s)
{
    s.medie++;
    return s;
}

const  Student operator++(Student& s, int i)  //postcrementare 
{
    Student aux = s;
    s.medie++;
    return aux;
}

double operator+(Student& s, double x) //comutativitatea, scriem parametrii in ambele sensuri
{
    return s.medie + x;
}

double operator+(double x, Student& s)
{
    return s.medie + x;
}

istream& operator>>(istream& in, Student& s)
{
    cout << "Nume: ";
    char buffer[40];
    in >> buffer;
    s.setNume(buffer);
    cout << "Medie: ";
    in >> s.medie;
    cout << "Matricol: ";
    in >> s.matricol;
    return in;
}

ostream& operator<<(ostream& out, Student s)
{
    out << "Studentul " << s.nume << " are matricolul " << s.matricol << " si media " << s.medie << "." << endl;
    return out;
}

//Student::nrStudent = 0;

int main()
{

    Student s1("Violeta", 111, 9.25);

    //cout << "Numele este: " << s1.getNume() << endl;

    s1.setNume("Marcel");

    //cout << "Numele este: " << s1.getNume() << endl; 

   // Student s2; // student s2(s1) -> echivalent cu =

    Student s2 = s1;

    //cout << "Numele este: " << s2.getNume() << endl;

   
    //cout << s1 + s2 << endl;
    //cout << s1 + 3 << endl;
    //cout << 8 + s2 << endl;
    Student s3;
    cin >> s3; 
    cout << s3;

    cout << s3[2];

    return 0;
}
