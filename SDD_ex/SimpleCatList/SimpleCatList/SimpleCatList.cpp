#include <stdio.h>
#include <iostream>

using namespace std;

struct cat
{
    char* name;
    int age;
    char bloodType;
    float weight;
};

struct nodls
{
    cat inf;
    nodls* next;
};

nodls* insert(nodls* head, cat c) //pointerul la inceputul vectorului de noduri i.e. capul listei
{
    nodls* nou = (nodls*)malloc(sizeof(nodls));
    nou->inf.name = new char[strlen(c.name) + 1];
    strcpy_s(nou->inf.name, strlen(c.name) + 1, c.name);
    nou->inf.age = c.age;
    nou->inf.bloodType = c.bloodType;
    nou->inf.weight = c.weight;
    nou->next = NULL;
    if(head == NULL)
        head = nou; // nodul devine cap aici
    else
    {
        nodls* temp = head; //se copiaza capul!
        while (temp->next != NULL)
        {
            temp = temp->next;
        }
        temp->next = nou;
    }
    return head;
}

void show(nodls* head)
{
    nodls* temp = head;
    while (temp != NULL)
    {
        cout << "Name: " << temp->inf.name << " Age: " << temp->inf.age << " Bloodtype: " << temp->inf.bloodType << " Weight: " << temp->inf.weight << endl;
        temp = temp->next;
    }
}

void dezalocation(nodls* head)
{
    nodls* temp = head;
    while (temp != NULL)
    {
        nodls* temp2 = temp->next;
        delete[] temp->inf.name;
        free(temp);
        temp = temp2;
    }
}

int main()
{
    int n;
    cout << "Enter the number of cats: " << endl;
    cin >> n;
    nodls* head = NULL; //initialize head of list
    cat c; // initialize catto
    char buffer[20];
    for (int i = 0; i < n; i++)
    {
        cout << "Name: " << endl;
        cin >> buffer;
        c.name = new char[strlen(buffer) + 1];
        strcpy_s(c.name, strlen(buffer) + 1, buffer);
        cout << "Age: " << endl;
        cin >> c.age;
        cout << "Bloodtype(single character): " << endl;
        cin >> c.bloodType;
        cout << "Weight:" << endl;
        cin >> c.weight;
        head = insert(head, c);
    }
    show(head);
    dezalocation(head);
}

