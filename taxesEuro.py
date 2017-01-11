#################################################
## Name of Program: Tax Calculator
## Description:		This program asks the user to enter a cost and a state/country tax and the output is the total cost including the tax. 
## Authour(s):		Al Bedouin (Render)
#################################################

# Create a function that simply prints a new line.
def NewLine():
	print("")

# Create another function that checks if the input is a number, since obviously you cannot multiply together alphabetical characters and symbols. 
# Ex. y * d = ? || $ * & = ? || 5 * 3 = 15
def CheckIfNumber(number):
	try: # Try to see if the character(s) that were inputted were numbers.
   		 value = float(number) # Check if the the value is a float, which allows decimals, unlike int.

   		 return value # If All went well, return the value.
	except ValueError: # If the character was NOT an integer throw an error.
   		print("Error: Invalid Input! Input must be a number!")
   		quit()

## Declare Variables and recieve input for the two main variables. ##

# This is the cost BEFORE the tax
cost = input("Enter the cost before tax: €")
CheckIfNumber(cost)
NewLine()

# This is the tax. 
tax = input("Enter the State/Country Tax: ")
CheckIfNumber(tax)
NewLine()

# Calculate the Total
total = float(float(cost) * float(tax))

# Convert the total to a string and insert a euro sign in front of the total.
print("€" + str(total))

# 
input("Press the Return key to continue...")
