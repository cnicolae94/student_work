# Fie 𝑓:{1,2,…,350}→ℝ,𝑓(𝑥)=𝑥2 funcţia obiectiv a unei probleme de maxim.
# Fiecărui fenotip 𝑥∈{1,2,…,350} îi corespunde un genotip şir binar obţinut prin codificarea Gray.
# 	a. Scrieţi o funcţie Python pentru generarea aleatoare a unei populaţii, pop, cu dimensiunea dim;
# 	b. Pentru o probabilitate de recombinare dată, pc, scrieţi o funcţie de recombinare utilizând
# operatorul de încrucişare uni-punct care, pe baza populaţiei pop obţine o nouă populaţie, popc.
# Populaţia rezultată are tot dim indivizi (este utilizată şi recombinarea asexuată).

import numpy as np

def popInit(dim):
    pop = []
    for index in range(dim):
        pop.append(nat2Gray(np.random.randint(1, 350), 9))
    return pop

def pctIncrucisare(parinte):
    pct = np.random.randint(1, len(parinte)-1)
    return pct

def incrucisareUnipct(dim, pop, pc):
    popc = []
    for index in range(0, dim, 2):
        probabilitate = np.random.uniform(0, 1)
        if (probabilitate < pc):
            punct = pctIncrucisare(pop[index])

            #prima generatie de copii
            c1 = ""
            c2 = ""
            for i in range (len(pop[index])):
                if (i < punct):
                    c1 = c1 + pop[index][i]
                    c2 = c2 + pop[index+1][i]
                else:
                    c1 = c1 + pop[index + 1][i]
                    c2 = c2 + pop[index][i]

            if(gray2Nat(c1) <= 350):
                popc.append(c1)

            if(gray2Nat(c2) <= 350):
                popc.append(c2)
    return popc

def sortarePop(pop):
    ordonare = True
    while (ordonare == True):
        ordonare = False
        for i in range(0, len(pop)-1):
            if(gray2Nat(pop[i]) < gray2Nat(pop[i+1])):
                temp = pop[i]
                pop[i] = pop[i+1]
                pop[i+1] = temp
                ordonare = True
    return pop

def popFinala(dim, pop):
    copii = incrucisareUnipct(dim, pop, 0.5)
    for index in range (len(copii)):
        pop.append(copii[index])

    temp2 = sortarePop(pop)

    if(len(temp2) > dim):
        del temp2[(dim):]

    pop = temp2
    return pop

def nat2Gray (x, m):
    #reprezentarea nr natural x in sir binar Gray pe m biti
    t=bin(x)[2:]
    t=t.zfill(m)
    rezultat = t[0]
    for i in range(1, m):
        bit= str(int(t[i]) ^ int(t[i-1]))
        rezultat = rezultat + bit
    return rezultat

def gray2Nat (bG):
    #functia de conversie din cod Gray la nr natural
    m = len(bG)
    bS = bG[0]
    val = int(bG[0])
    for i in range(1, m):
        if bG[i] == '1':
            val = int(not(val))
        bS = bS + str(val)
    n = int(bS, 2)
    return n


pop = popInit(20)
print(pop)
print("")
lista = []

for index in range(len(pop)):
    lista.append(gray2Nat(pop[index]))

print(lista)
print("")
print(popFinala(20, pop))
print("")

lista = []
for index in range(len(pop)):
    lista.append(gray2Nat(pop[index]))

print(lista)




























