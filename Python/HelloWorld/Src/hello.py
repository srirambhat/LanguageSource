
import sys
import os
import datetime
from _ast import Num
import sys

def hello():
    print("Hello world my first function program")
    print(myvar)
    print("End") 
    print(datetime.datetime.now().time())
    
def hello1():
    print("In hello1 function")

def AddIt(val1=5, val2=5):
    print(val1,"+",val2,"=",(val1+val2));    
    
def VariableArgs(ArgCount, *VarArgs):
    print("You passed ", ArgCount, " arguments.")
    for Arg in VarArgs:
        print(Arg)
    
    return VarArgs[2];
       
def try_catch_block():
    try:
        Value = int(input("Type a number between 1 and 10:"))
    except ValueError:
        print("You must type a number between 1 and 10!")
    else:
            if ((Value > 0) and (Value <= 10)):
                print("You typed: ", Value)
            else:
                print("The value you typed is incorrect!")

def print_tables(X, Y, D):
    L = X
    print ('{:>5}'.format(' '), end= ' ')
    for X in range(1, D):
        print('{:>5}'.format(X), end=' ')
    print()
  
    for X in range(L,L+D):
        print('{:>5}'.format(X), end=' ')
        while Y <= D-1:
            print('{:>5}'.format(X * Y), end=' ')
            Y+=1
        print()
        Y=1

def open_file (filename): 
    try:
        File = open(filename)
    except IOError as e:
        print("Error opening file!\r\n" +
              "Error Number: {0}\r\n".format(e.errno) +
              "Error Text: {0}".format(e.strerror))
    else:
        print("File opened as expected.")
        File.close();
   
   
# print_tables(900, 1, 11)
# try_catch_block();
open_file("myfile.txt")


