# 1. Fie 𝑓:[−1,1]×[0,0.2]×[−2,1]→ℝ, 𝑓(𝑥1,𝑥2,𝑥3)=1+𝑠𝑖𝑛(2𝑥1−𝑥3)+𝑥2 funcţia obiectiv a unei probleme de
# maxim. Un genotip este un vector 𝑥=(𝑥1,𝑥2,𝑥3)𝑇,𝑥∈[−1,1]×[0,0.2]×[−2,1].
# a. Scrieţi o funcţie Python pentru generarea aleatoare a unei populaţii, pop, cu dimensiunea
# dim;
# b. Pentru o probabilitate de mutaţie dată, pm, scrieţi o funcţie mutaţie de tip fluaj
# cu pragul 𝑡=0.6 (𝜎=𝑡3) care, pe baza populaţiei pop obţine o nouă populaţie, cu indivizii
# eventual mutanţi ai lui pop.

import numpy as np
from math import sin

def functieFitness(x):
    #x1 = 0 // x2 = 1 // x3 = 2
    return 1 + sin(2*x[0]-x[2])+x[1]

def popInit(dim, a, b): #pt vectori
    n = 4
    pop = np.zeros((dim, 2))
    for i in range(dim):
        for j in range(dim):
            pop[i, j] = np.random.uniform(a[j], b[j])
        val[] = functieFitness(pop[i, n-1])
    return pop

pop = popInit(20,[-1,0,-2],[1,0.2,1])



