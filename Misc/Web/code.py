import re
file_path = 'Misc\Web\main.txt'
sum = 0
with open(file_path) as file:
    content = file.readlines()
for line in content:
    line = line.rstrip()
    numbers = re.findall('[0-9]+', line)
    for number in numbers:
        total_sum = int(number)
        sum = sum + total_sum
print(sum)

