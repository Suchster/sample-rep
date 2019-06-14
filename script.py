import math
import os
import sys
import numpy as np

import requests

a = np.linspace(0,10,11)

# print(sys.version)
print(sys.executable)
print("This program is just a test for module and testing vs code")

def greet(who_to_greet):
    greeting = 'Hello, {}'.format(who_to_greet)
    return greeting


r = requests.get('https://google.com')
print(r.status_code)

# name = input("What is your name? ") #You must run this through terminal

# print(greet('World'))
# print(greet(name))
