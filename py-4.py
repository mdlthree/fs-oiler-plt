import time
 
def main():
  a = 999
  b = 999
  palinD = [0,0,1]
 
  t = time.time()
 
    while a > 99:
        while b > 99:
            c = a*b
            if c < palinD[2]: break
            if palinTest(str(c)):
                palinD = [a,b,c]
                b -=1
 
        if max([a,b]) < min(palinD[0:2]): break
        a -= 1
        b = a
 
  print 'time: ' + str(time.time()-t) 
  print palinD
  return
 
def palinTest(p):
  i = 0
  while i <= len(p)/2:
    if p[i] != p[-(i+1)]: return False
    else: i+=1
      
  return True
 
if __name__ == '__main__':
  main()
