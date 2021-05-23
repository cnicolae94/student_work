# Capitol 3 problema 8: Fie 𝑓:[−1,1]×[0,0.2]×[−2,1]→ℝ, 𝑓(𝑥1,𝑥2,𝑥3)=1+𝑠𝑖𝑛(2𝑥1−𝑥3)+𝑥2 funcţia obiectiv a unei probleme de maxim.
# Un genotip este un vector 𝑥=(𝑥1,𝑥2,𝑥3)𝑇,𝑥∈[−1,1]×[0,0.2]×[−2,1]
# 	a. Scrieţi o funcţie Python pentru generarea aleatoare a unei populaţii, pop, cu dimensiunea dim;
# indivizii populaţiei sunt însoţiţi de funcţia merit (sunt vectori cu 4 componente).
# 	b. Pentru o probabilitate de recombinare dată, pc, scrieţi o funcţie de recombinare
# utilizând operatorul de recombinare aritmetică totală care, pe baza populaţiei pop obţine o nouă
# populaţie, popc. Populaţia rezultată are tot dim indivizi (este utilizată şi recombinarea asexuată
# şi calitatea fiecărui individ este memorată la sfârşitul fiecărei reprezentări cromozomiale).

import numpy as np
from FunctiiMutatieIndivizi import m_neuniforma
from math import sin


# functia fitness
def functieFitness(x):
    return 1+sin(2*x[0]-x[2])+x[1]


def popInit(dim, a, b):
    n = 4
    pop = np.zeros((dim, n))
    for i in range(dim):
        for j in range(3):
            pop[i, j] = np.random.uniform(a[j], b[j])  # verifica aici

        pop[i, 3] = functieFitness(pop[i, :n-1])
    return pop


def crossoverTotal(p1, p2, n, alfa):
    # c - copiil / p - parinte
    # alfa - ponderea la mediere
    c1 = p1.copy()
    c2 = p2.copy()
    for j in range(n):
        c1[j] = (alfa * p1[j] + (1 - alfa) * p2[j])
        c2[j] = (alfa * p2[j] + (1 - alfa) * p1[j])
    return c1, c2


def sortarePop(popTemp):
    ordonare = True
    while (ordonare == True):
        ordonare = False
        for i in range(0, len(popTemp) - 1):
            if (popTemp[i][3] < popTemp[i + 1][3]):
                # temp - stocare temporara pt un individ
                temp = popTemp[i]
                popTemp[i] = popTemp[i + 1]
                popTemp[i + 1] = temp
                ordonare = True
    return popTemp

def popFinala(dim, pop, alfa):
    popTemp = []
    for index in range(len(pop)):
        popTemp.append(pop[index])

    for index in range(0, len(pop)-1, 2):
        prob = np.random.uniform(0, 1)
        if(prob < alfa):
            c1, c2 = crossoverTotal(pop[index], pop[index+1], 3, alfa)
            c1[3] = functieFitness(c1)
            popTemp.append(c1)
            c2[3] = functieFitness(c2)
            popTemp.append(c2)

    popc = sortarePop(popTemp)
    for index in range(dim):
        popc[index] = popTemp[index]

    return popc

# pop = popInit(20,[-1,0,-2],[1,0.2,1])
# print(pop)
# print("")
# popc = popFinala(20, pop, 0.5)
# print(popc)






