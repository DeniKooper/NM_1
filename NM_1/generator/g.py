line = open('set.txt').readline().split(" ")
# число элементов в половине ленты, без учета диагонали
k = int(line[0])
# выбор соотношения размера ленты к размерам матрицы: 0 - 6:4, 1 - 7:3
# 2 - 8:2, 3 - 9:1
q = int(line[1])
t = 0

Mode = [4, 3, 2, 1]
Mode = Mode[q]

di = list()
v = list()
ad = list()
au = list()

m = 2*k+1
n = round((k+1)/Mode)*10

# Магия - не трогать!
for p in range(0, k, 1):
    ad.append(list())
    au.append(list())
    for i in range(0, k-t, 1):
        ad[p].append(0)
        au[p].append(0)
    for j in range(0, t, 1):
        ad[p].append(1)
        au[p].append(1)

    t=t+1

for i in range(0, n, 1):
    di.append(1)

for i in range(0, n, 1):
    v.append(1)

for j in range(k, n, 1):
    ad.append(list())
    au.append(list())
    for i in range(0, k, 1):
        ad[j].append(1)
        au[j].append(1)

f1 = open('../n.txt',mode='w')
f2 = open('../di.txt',mode='w')
f3 = open('../ad.txt',mode='w')
f4 = open('../au.txt',mode='w')
f5 = open('../v.txt',mode='w')

f1.write(str(n)+ "\n" + str(k))
for i in range(0, len(di), 1):
    f2.write(str(di[i]))
    f2.write('\n')

for i in range(0, len(ad), 1):
    for j in range(0, k, 1):
        f3.write(str(ad[i][j]) + "\n")

for i in range(0, len(au),1):
    for j in range(0, k, 1):
        f4.write(str(au[i][j]) + "\n")

for i in range(0, len(v),1):
   f5.write(str(v[i]))
   f5.write('\n')

