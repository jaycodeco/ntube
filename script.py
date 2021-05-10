import sys
import time
#import pytube

#num1 = int(sys.argv[1])
#num2 = int(sys.argv[2])
#
#ans = num1+num2

#class calc:
#    def pro():
#        print("yo")
#        return "fuck"

def downloading(flag, data):
    if flag == '--file' :
        print('downloading from file')

    if flag == '--url' :
        print('downloading from url')

    if flag == '--list' :
        print('downloading from playlist')

    if flag == '--chc' :
        print('downloading from choice')





if __name__ == '__main__':
    #print("{dta},25,47,59".format(dta=ans))
    if sys.argv[1] == '-i' :
        print('initialising')

    if sys.argv[1] == '-s' :
        print('searching')

    if sys.argv[1] == '-p' :
        print('updating')

    if sys.argv[1] == '-d' :
        downloading(sys.argv[2], "data")