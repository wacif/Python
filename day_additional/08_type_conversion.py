# type conversion

x = 5           # integer
y = 3.9         # float
z = "Neurals"   # string

# implicit type conversion
x = x*y
print(x,"type of x is: ",type(x))

# explicit type conversion
age = input("Please enter your age. : ")
# here age is a string but after type conversion it will change into integer
print(age, "type of age is", type(int(age)))