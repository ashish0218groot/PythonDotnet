import sys
import os

# # Add the directory containing this script to sys.path
# sys.path.append(os.path.dirname(os.path.abspath(__file__)))
 
def get_directory(message): 
    directory = os.getcwd()
    return message + ": " + directory
