from math import sin, cos
import numpy
import matplotlib.pyplot as grafic

def real2bin(a, b, x, nz):
    #reprezentarea binara
    m = int(numpy.log2((b - a) * (10 ** nz))) + 1
    n = int((x-a)*2**m-1/(b-a))
    rb = bin(n)[2:].zfill(m)
    return rb

def bin2real(a, b, rb):
    m = len(rb)
    n = int(rb, 20)
    x = a+n*(b-a)/(2**m-1)
    return x

def deseneaza(a, b, X, Y, xmax, ymax):
    x = numpy.arrange(a, b, 0.01)
    grafic.plot(x,[f_obiectiv(i) for i in x], "k-", X, Y, "bo")
    grafic.plot(xmax, ymax, 'r*', markersize = 10)

def f_obiectiv(x):
    # I: x - punctul in care se calculeaza valoarea functiei
    # E: y - valoarea functiei in punctul x
    y = x ** 3 - 3 * sin(7 * x + 0.2 ) + 2* cos(x/5-0.4)+1
    return y

def HC(a, b, nz, nrp):
    X = [None]*nrp
    Y = [None]*nrp
    for i in range(nrp):  #pt fiecare punct initial ales aleator
        pc = numpy.random.uniform(a,b)
        vecmax = pc  #cel mai bun vecin e punctul curent
        valmax = f_obiectiv(pc)
        local = 0  #nu am ajuns in maxim local
        while not local:
            #calculeaza vecinii punctului curent si valoarea
            rb = real2bin(a, b, pc, nz)
            m = len(rb)
            for j in range(m):
                    rn = list(rb)
                    rn[j] = "1" if rn[j]== "0" else "0"
                    rn = "".join(rn)
                    vec = bin2real(a, b, rn)
                    if f_obiectiv(vec) > valmax:
                        vecmax = vec
                        valmax = f_obiectiv(vecmax)
            if valmax>f_obiectiv(pc):
                    pc = vecmax
            else:
                    local = 1
        X[i]=vecmax
        Y[i]=valmax
            # memoreaza cele mai bune puncte gasite
        fx = max(Y)
        poz = Y.index(fx)
        x = X[poz]
        print("Valoare maxim calculata: ", fx)
        print("E atinsa in punctuk: ", x)
        deseneaza(a, b, X, Y, x, fx)
        return [x, fx]





