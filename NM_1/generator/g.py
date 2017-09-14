import numpy as np
line = open('set.txt').readline().split(" ")
# число элементов в половине ленты, без учета диагонали
k = int(line[1])
# выбор соотношения размера ленты к размерам матрицы: 0 - 6:4, 1 - 7:3
# 2 - 8:2, 3 - 9:1
q = int(line[2])
t = 0

Mode = [4, 3, 2, 1]
Mode = Mode[q]

di = list()
v = list()
ad = list()
au = list()


m = 2*k+1
n = int(line[0])

line = np.diag(np.ones(n))



f1 = open('../n.txt',mode='w')
f4 = open('../k.txt',mode='w')
f2 = open('../di.txt',mode='w')
f3 = open('../line.txt',mode='w')
f5 = open('../v.txt',mode='w')

f1.write(str(n))
f4.write(str(k))
for i in range(0, len(di), 1):
    f2.write(str(di[i]))
    f2.write('\n')

for i in range(0, len(ad), 1):
    for j in range(0, k, 1):
        f3.write(str(ad[i][j]) + "\n")

# for i in range(0, len(au),1):
#     for j in range(0, k, 1):
#         f4.write(str(au[i][j]) + "\n")

for i in range(0, len(v),1):
   f5.write(str(v[i]))
   f5.write('\n')

