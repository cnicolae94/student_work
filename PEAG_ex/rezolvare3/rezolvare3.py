# Capitol 3, problema 2: Fie 𝑓:{1,2, … ,350} → ℝ, 𝑓(𝑥) = 𝑥^2 funcţia obiectiv a unei probleme de maxim. Fiecărui
# fenotip 𝑥 ∈ {1,2, … ,350} îi corespunde un genotip şir binar obţinut prin codificarea Gray.
# a. Scrieţi o funcţie Python pentru generarea aleatoare a unei populaţii, pop, cu dimensiunea dim;
# b. Pentru o probabilitate de mutaţie dată, pm, scrieţi o funcţie mutaţie care, pe baza populaţiei
# pop obţine o nouă populaţie, cu indivizii eventual mutanţi ai lui pop.

import numpy as np

def functieFitness(x):
    return x ** 2

def popInit(dim):
    pop = []
    for index in range(dim):
        pop.append(nat2Gray(np.random.randint(1, 350), 9))
    return pop

def nat2Gray (x, m):
    t=bin(x)[2:]
    t=t.zfill(m)
    rezultat = t[0]
    for i in range(1, m):
        bit= str(int(t[i]) ^ int(t[i-1]))
        rezultat = rezultat + bit
    return rezultat

def gray2bin(bG):
    m = len(bG)
    bS = bG[0]
    val=int(bG[0])
    for i in range(1,m):
        if bG[i]=='1':
            val=int(not(val))
        bS=bS+str(val)
    n = int(bS, 2)
    return n

def mutatie(x):
    y=- x
    return y

def mutatiePop(popc, dimc, pm):
    # pm - probabilitatea mutatiei
    # popc - populatie copii
    # dimc - dimensiunea populatiei de copii
    # cm - copii mutanti
    # xm - x mutat
    # y - calitatea individului in cod binar
    cm = copii.copy()
    for i in range(dimc):
        r = np.random.uniform(0, 1)
        if r <= pm:
            x = cm[i][0]
            xm = mutatie(x)
            if(gray2Nat(xNou) < 350):
                y = functieFitness(gray2bin(xm))
                cm[i][0] = xm
                cm[i][1] = y
    print("new gen")
    return cm
















