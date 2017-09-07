line = open('set.txt').readline().split(" ")
# число элементов в половине ленты, без учета диагонали
k = int(line[0])
# выбор соотношения размера ленты к размерам матрицы: 0 - 6:4, 1 - 7:3
# 2 - 8:2, 3 - 9:1
q = int(line[1])
t = 0

Mode = [4, 3, 2, 1]
Mode = Mode[q]

line= list()
m = 2*k+1
n = round((k+1)/Mode)*10
v = list()

for i in range(n):
    v.append(1)

for i in range( k ):
    line.append(list())
    for j in range(k-i):
        line[i].append(0)
for i in range(k):
    for j in range(i+1+k):
        line[i].append(1)

for i in range( n - 2 * k ):
    line.append(list())
    for j in range(m):
        line[len(line) - 1].append(1)


for i in range( k ):
    line.append(list())
    for j in range(m-i-1):
        line[len(line)-1].append(1)
    for j in range(i+1):
        line[len(line)-1].append(0)

f1 = open('../n.txt',mode='w')
f2 = open('../line.txt',mode='w')
f5 = open('../v.txt',mode='w')

f1.write(str(n)+ "\n" + str(k))
for i in range(0, len(line), 1):
    for j in range(m):
        f2.write(str(line[i][j]))
        f2.write('\n')


for i in range(0, len(v),1):
   f5.write(str(v[i]))
   f5.write('\n')

