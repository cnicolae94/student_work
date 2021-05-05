//1. Sa se realizeze o implementare de arbore binar de cautare echilibrat cu
//informatie utila de tip articol(din orice domeniu), care sa includa minim 3 atribute,
//dintre care minim unul de tip char* .Se vor implementa mecanismele de inserare cu date
//preluate din fisier text, traversari preordine, inordine, postordine, dezalocare. (0.5 p)
//2. Sa se implementeze functia pentru afisarea elementelor de pe un anumit nivel din arbore,
//iar apoi sa se traverseze arborele pe niveluri. (0.5 p)
//3. Sa se implementeze functia pentru determinarea elementelor din nodurile frunza ale arborelui
//si salvarea acestora intr - o alta structura de date. (0.5p)
//4. Sa se stearga un nod din arbore pe baza atributului de tip char* din structura articol,
//care nu reprezinta cheia de inserare in arbore. (0.5 p)

#include <iostream>
#include <fstream>

using namespace std;

//1

struct carte
{
    int cod;
    char* nume;
    string autor;
    float pret;
};

struct BTN //binary tree node
{
    int BF; 
    carte inf;
    BTN* left, * right;
};

//struct nodLS
//{
//    carte inf;
//    nodLS* next;
//};
//
//nodLS* inserareLS(nodLS* cap, carte c)
//{
//    nodLS* nou = new nodLS;
//    nou->inf.cod = c.cod;
//    nou->inf.nume = new char[strlen(c.nume) + 1];
//    strcpy_s(nou->inf.nume, strlen(c.nume) + 1, c.nume);
//    nou->inf.autor = c.autor;
//    nou->inf.pret = c.pret;
//    nou->next = NULL;
//    if (cap == NULL)
//        cap = nou;
//    else
//    {
//        nodLS* temp = cap;
//        while (temp->next != NULL)
//            temp = temp->next;
//        temp->next = nou;
//    }
//    return cap;
//}
//
//void traversareLS(nodLS* cap)
//{
//    nodLS* temp = cap;
//    while (temp != NULL)
//    {
//        cout << "Cartea " << temp->inf.nume << " este scrisa de " << temp->inf.autor << " are codul "
//            << temp->inf.cod << " si costa " << temp->inf.pret << "." << endl;
//        temp = temp->next;
//    }
//}

BTN* creareNod(carte c, BTN* left, BTN* right)
{
    BTN* nou = new BTN;
    nou->inf.cod = c.cod;
    nou->inf.nume = new char[strlen(c.nume) + 1];
    strcpy_s(nou->inf.nume, strlen(c.nume) + 1, c.nume);
    nou->inf.autor = c.autor;
    nou->inf.pret = c.pret;
    nou->left = left;
    nou->right = right;
    return nou;
}

BTN* inserareNod(carte c, BTN* root)
{
    BTN* temp = root;
    if (root == NULL)
    {
        root = creareNod(c, NULL, NULL);
        return root;
    }
    else
        while(true)
        {
            if (c.cod < temp->inf.cod)
                if (temp->left != NULL)
                    temp = temp->left;
                else
                {
                    temp->left = creareNod(c, NULL, NULL);
                    return root;
                }
            else
                if (c.cod > temp->inf.cod)
                    if (temp->right != NULL)
                        temp = temp->right;
                    else
                    {
                        temp->right = creareNod(c, NULL, NULL);
                        return root;
                    }
                else
                    return root;
        }
    
    /*if (root != NULL)
    {
        if (c.cod < root->inf.cod)
        {
            root->left = inserareNod(c, root->left);
            return root;
        }
        else
        {
            if (c.cod > root->inf.cod)
            {
                root->right = inserareNod(c, root->right);
                return root;
            }
            else
                return root;
        }
    }
    else
        return creareNod(c, NULL, NULL);*/
}

void traversarePreordine(BTN* root)
{
    if (root != NULL)
    {
        cout << "Cartea " << root->inf.nume << " este scrisa de " << root->inf.autor << " are codul "
            << root->inf.cod << " si costa " << root->inf.pret << "." << endl;
        traversarePreordine(root->left);
        traversarePreordine(root->right);
    }
}

void traversareInordine(BTN* root)
{
    if (root != NULL)
    {
        traversareInordine(root->left);
        cout << "Cartea " << root->inf.nume << " este scrisa de " << root->inf.autor << " are codul "
            << root->inf.cod << " si costa " << root->inf.pret << "." << endl;
        traversareInordine(root->right);
    }
}

void traversarePostordine(BTN* root)
{
    if (root != NULL)
    {
        traversarePostordine(root->left);
        traversarePostordine(root->right);
        cout << "Cartea " << root->inf.nume << " este scrisa de " << root->inf.autor << " are codul "
            << root->inf.cod << " si costa " << root->inf.pret << "." << endl;
    }
}

void dezalocare(BTN* root)
{
    if (root != NULL)
    {
        BTN* left = root->left;
        BTN* right = root->right;
        delete[] root->inf.nume;
        delete root;
        dezalocare(left);
        dezalocare(right);
    }
}

BTN* cautare(BTN* root, int cheie)
{
    if (root != NULL)
    {
        if (cheie == root->inf.cod)
            return root;
        else
        {
            if (cheie < root->inf.cod)
                return cautare(root->left, cheie);
            else
                return cautare(root->right, cheie);
        }
    }
    else
        return NULL;
}

//2

int max(int a, int b)
{
    int max = a;
    if (max < b)
        max = b;
    return max;
}

int nrNiveluri(BTN* root)
{
    if (root != NULL)
    {
        return 1 + max(nrNiveluri(root->left), nrNiveluri(root->right));
    }
    else
        return 0;
}

void traversareNivel(BTN* root, int nivel)
{
    if (root == NULL)
        cout << "Arborele este gol" << endl;
    if (nivel == 1)
        cout << "Cartea " << root->inf.nume << " este scrisa de " << root->inf.autor << " are codul "
        << root->inf.cod << " si costa " << root->inf.pret << "." << endl;
    else if (nivel > 1)
    {
        traversareNivel(root->left, nivel - 1);
        traversareNivel(root->right, nivel - 1);
    }
}

void traversareNiveluri(BTN* root)
{
    int x = nrNiveluri(root);
    for (int i = 0; i <= x; i++)
    {
        traversareNivel(root, x);
    }
}

//3

//void conversieFrunze(BTN* root, nodLS* cap)
//{
//    if (root != NULL)
//    {
//        if (root->left == NULL && root->right == NULL)
//        {
//            cap = inserareLS(cap, root->inf);
//        }
//        conversieFrunze(root->left, cap);
//        conversieFrunze(root->right, cap);
//        
//    }
//} nereusit

void determinareFrunze(BTN* root, carte* carti, int* nr)
{
    if (root != NULL)
    {
        if (root->left == NULL && root->right == NULL)
        {
            carti[*nr].cod = root->inf.cod;
            carti[*nr].nume = new char[strlen(root->inf.nume) + 1];
            strcpy_s(carti[*nr].nume, strlen(root->inf.nume) + 1, root->inf.nume);
            carti[*nr].autor = root->inf.autor;
            carti[*nr].pret = root->inf.pret;
            (*nr)++;
        }

        determinareFrunze(root->left, carti, nr);
        determinareFrunze(root->right, carti, nr);
    }
}

//4

BTN* stergereRoot(BTN* root)
{
    BTN* temp = root;
    if (temp->left != NULL)
    {
        root = temp->left;
        if (temp->right != NULL)
        {
            BTN* aux = temp->left;
            while (aux->right)
                aux = aux->right;
            aux->right = temp->right;
        }
    }
    else
    {
        if (temp->right != NULL)
            root = temp->right;
        else
            root = NULL;
    }

    delete[] temp->inf.nume;
    delete temp;
    return root;    
}

BTN* stergereNod(BTN* root, int cheie)
{

    if (root == nullptr)
        return nullptr;
    else
    {
        if (root->inf.cod == cheie)
        {
            root = stergereRoot(root);
            return root;
        }
        else
        {
            BTN* aux = root;
            while (true)
            {
                if (cheie < aux->inf.cod)
                    if (aux->left == NULL)
                        break;
                    else
                    {
                        if (aux->left->inf.cod == cheie)
                            aux->left = stergereRoot(aux->left);
                        else
                            aux = aux->left;
                    }
                else
                {
                    if (cheie > aux->inf.cod)
                        if (aux->right == NULL)
                            break;
                        else
                            if (aux->right->inf.cod == cheie)
                                aux->right = stergereRoot(aux->right);
                            else
                                aux = aux->right;
                }

            }
            return root;

        }
    }
        
}

BTN* stergereDen(BTN* root, char* nume)
{
    if (root != NULL)
    {
        if (strcmp(root->inf.nume, nume) == 0)
        {
            root = stergereNod(root, root->inf.cod);
            return root;
        }
        else
        {
            root->left = stergereDen(root->left, nume);
            root->right = stergereDen(root->right, nume);
            return root;
        }
    }
    else
        return NULL;
}

void computeBF(BTN* root)
{
    if (root != NULL)
    {
        root->BF = nrNiveluri(root->right) - nrNiveluri(root->left);
        computeBF(root->left);
        computeBF(root->right);
    }
}

BTN* rotateRight(BTN* root)
{
    cout << "Rotatie dreapta." << endl;
    BTN* nod1 = root->left;
    root->left = nod1->right;
    nod1->right = root;
    root = nod1;
    return root;
}

BTN* rotateLeft(BTN* root)
{
    cout << "Rotatie stanga." << endl;
    BTN* nod1 = root->left;
    root->right = nod1->left;
    nod1->left = root;
    root = nod1;
    return root;
}

BTN* rotateRL(BTN* root)
{
    cout << "Rotatie dreapta-stanga." << endl;
    BTN* nod1 = root->right;
    BTN* nod2 = nod1->left;
    nod1->left = nod2->right;
    nod2->right = nod1;
    root->right = nod2->left;
    nod2->left = root;
    root = nod2;
    return root;
}

BTN* rotateLR(BTN* root)
{
    cout << "Rotatie stanga-dreapta." << endl;
    BTN* nod1 = root->left;
    BTN* nod2 = nod1->right;
    nod1->right = nod2->left;
    nod2->left = nod1;
    root->left = nod2->right;
    nod2->right = root;
    root = nod2;
    return root;
}

BTN* reechilibrare(BTN* root)
{
    computeBF(root);
    if (root->BF <= -2 && root->left->BF <= -1)
    {
        root = rotateRight(root);
        computeBF(root);
    }
    else
        if (root->BF >= 2 && root->right->BF >= 1)
        {
            root = rotateLeft(root);
            computeBF(root);
        }
        else
            if (root->BF >= 2 && root->right->BF <= -1)
            {
                root = rotateRL(root);
                computeBF(root);
            }
            else
                if (root->BF <= -2 && root->left->BF >= 1)
                {
                    root = rotateLR(root);
                    computeBF(root);
                }         
    return root;
}


int main()
{

    BTN* root = NULL;
    int n;
    carte c;
    //nodLS* cap = NULL;

    ifstream fisier;
    fisier.open("carti.txt");
    char buffer[20];
    fisier >> n;

    for (int i = 0; i < n; i++)
    {
        fisier >> c.cod;
        fisier >> buffer;
        c.nume = new char[strlen(buffer)+1];
        strcpy_s(c.nume, strlen(buffer) + 1, buffer);
        fisier >> c.autor;
        fisier >> c.pret;
        root = inserareNod(c, root);
        root = reechilibrare(root);
        
        delete[] c.nume;
    }

    int nr = 0;
    carte* vect = new carte[n];
    determinareFrunze(root, vect, &nr);
    
    for (int i = 0; i < nr; i++)
    {
        cout << "Cartea " << vect[i].cod << " este scrisa de " << vect[i].autor << " are codul " << vect[i].cod << " si costa " << vect[i].pret << "." << endl;
        
    }

    for (int i = 0; i < nr; i++)
    {
        delete[] vect[i].nume;
    }

    
    /*traversareInordine(root);
    stergereNod(root, 89);
    cout << endl;
    traversareInordine(root);*/

    /*cout << "introdu nr de carti" << endl;
    cin >> n;
    for (int i = 0; i < n; i++) 
    {
        char buffer[20];
        cout << "Cod: " << endl;
        cin >> c.cod;
        cout << "Nume: " << endl;
        cin >> buffer;
        c.nume = new char[strlen(buffer) + 1];
        strcpy_s(c.nume, strlen(buffer) + 1, buffer);
        cout << "Autor: " << endl;
        cin >> c.autor;
        cout << "Pret: " << endl;
        cin >> c.pret;
        root = inserareNod(c, root);
    }*/

    //traversarePostordine(root);

   /* traversareInordine(root);
    cout << endl;
    traversarePostordine(root);
    cout << endl;
    traversarePreordine(root);*/

    return 0;
}
