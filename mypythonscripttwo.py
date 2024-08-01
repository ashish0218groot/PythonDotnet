import sys
import os


def say_hello(): 
    return "Hi, this is First Method Output"

def test(message): 
    directory = os.getcwd()
    return message + ": " + directory
