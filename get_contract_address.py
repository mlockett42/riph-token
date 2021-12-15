#!/bin/python3
import re
# Extract the contract address from the truffle output

# Use utf-16 on Windows utf-8 on Linux
#file1 = open('build/truffle_output.txt', 'r', encoding='utf-16')
file1 = open('build/truffle_output.txt', 'r', encoding='utf-8')
lines = file1.readlines()

# Assuming we never have more than 1,000,000 lines in the file
numbered_lines = list(zip(range(1000000), lines))

# Find the line matches the name of the migration that creates the token
match = list(filter(lambda nl: nl[1].startswith("2_riphtoken.js"), numbered_lines))[0]

# Get all the lines after that match
lines = lines[match[0]:]

prog = re.compile("^\s*\> contract address:\s+")
contract_address_line = list(filter(lambda line: prog.match(line) is not None, lines))[0]

# Split the string on the whitespaces
line_parts = contract_address_line.split()

# The last fragment is the contract address
print(line_parts[-1])
