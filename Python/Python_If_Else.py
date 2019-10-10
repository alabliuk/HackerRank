# https://www.hackerrank.com/challenges/py-if-else/problem

import math
import os
import random
import re
import sys


if __name__ == '__main__':
    n = int(input().strip())

    if(n % 2 != 0):
        x = 'Weird'
    else:
        x = 'Not Weird'

    if(n % 2 == 0 and n >= 2 and n <= 5):
        x = 'Not Weird'

    if(n % 2 == 0 and n >= 6 and n <= 20):
        x = 'Weird'

    if(n % 2 == 0 and n > 20):
        x = 'Not Weird'

    print(x)
