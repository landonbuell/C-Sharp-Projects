"""
Landon Buell
Python Backend
Integrate C# and Python
3 october 2020
"""

import sys

class Calculator:

    def add(self,x,y):
        """ Return sum of x,y """
        return x + y

    def subtract (self,x,y):
        """ Return difference of x,y """
        return x - y

    def multiply (self,x,y):
        """ Return product of x,y """
        return x * y

    def divide (self,x,y):
        """ Return division of x,y """
        return x / y

    def modulo(self,x,y):
        """ Return remainded of x/y """
        return x % y

    def exponent (self,x,y):
        """ Return x to the power of y """
        return x**y


if __name__ == "__main__":

    # parse inputs
    try:
        a,b = sys.argv[1],sys.argv[2]
    except:
        print("Could not parse inputs")
        x,y = 1,1

    # Create instance
    calc = Calculator()

    # Run methods
    print(calc.add(a,b))
    print(calc.subtract(a,-b))
    print(calc.multiply(a,b))
    print(calc.modulo(a,b))
