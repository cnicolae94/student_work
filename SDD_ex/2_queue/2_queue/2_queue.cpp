// 2_queue.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

using namespace std;

class Queue
{
private:
    int array[5];
    int rear;
    int front;
    //simple variables that keep track of location within structure
    //rear-ul este locul prin care "intra" toate valorile in queue
    //valorile vor iesi prin front

public:
    Queue()
    {
        front = -1;
        rear = -1;
        for (int i = 0; i < 5; i++)
        {
            array[i] = 0;
        }
    }

    bool isEmpty()
    {
        if (front == -1 && rear == -1)
            return true;
        else
            return false;
    }

    bool isFull()
    {
        if (rear == sizeof(array) - 1) // pozitia incepe de la 0
            return true;
        else
            return false;
    }

    void enqueue(int value) //va primi int ca parametru
    {
        if (isFull())
            cout << "Queue is full" << endl;
        else if (isEmpty())
        {
            rear = 0; //when we add the first value the position will be at 0
            front = 0;
            array[rear] = value;
        }
        else
        {
            rear++;
            array[rear] = value;  //ce valoare sa fie adaugata lol.
        }
    }

    int dequeue() //fara argumente aici pt ca nu returneaza ci sterge
    {
        int x;

        if (isEmpty())
        {
            cout << "Queue is empty." << endl;
            return 0; //trebuie sa ai return
        };
        else (front == rear)
        {
            x = array[front];
            front = -1;
            rear = -1;
            array[front] = 0;
            return x;
        }
    }
};


int main()
{

    int option, value;
    do
    {
        cout << "Press 0 to exit. Otherwise, please select desired option." << endl;
        cout << "1. Enqueue." << endl;
        cout << "2. Dequeue." << endl;
        cout << "3. isEmpty." << endl;
        cout << "4. isFull." << endl;
        cout << "5. Count." << endl;
        cout << "6. Display." << endl;
        cout << "7. Clear screen." << endl;

        cin >> option;

        switch (option)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            default:
                cout << "Please select a valid option." << endl;
                break;

        }


    } while (option != 0);

    return 0;
}

