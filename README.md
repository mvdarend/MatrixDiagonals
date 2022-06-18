# MatrixDiagonals
Calculate the diagonals of a matrix

During the recruitment process for a position I had applied for I was given the following problem to solve.

Given a square matrix, calculate the absolute difference between the sums of its diagonals. For example,
the square matrix is shown below:
```
1 2 3
4 5 6
9 8 9
```
(See copy of full document below)

I decided to make a simple Blazor interface to allow the user/tester to create a matrix with a size of their own choosing so that the matrix is not restricted to a 3x3 grid.

The first commit in this repo is the exact solution that I submitted to the recruiter. 

But... when I wrote the code I was sure there must be a better way to do the actual calculation that I had created. A few days after submitting my code to the recruiter I decided to find a better way to do it. 

A quick Google search found multiple versions of this *exact* problem :) I was a bit disappointed that the most of them where pretty close to my solution. Most of the solutions I found looped through both the 'x' and 'y' axis of the matrix with a nested loop algo like I had done. 

But I did find one where the writer only used the 'x' axis and calculated the value from there, you can find the answer here:
https://www.geeksforgeeks.org/find-difference-between-sums-of-two-diagonals/

Nice solution, good explanation, and lots of code examples.

------------------------------------------------------
# Problem
Given a square matrix, calculate the absolute difference between the sums of its diagonals. For example,
the square matrix is shown below:
```
1 2 3
4 5 6
9 8 9
```
The left-to-right diagonal = 1 + 5 + 9 = 15. The right to left diagonal = 3 + 5 + 9 = 17. Their absolute
difference is |15 – 17| = 2.
## Assignment
Create a program that solves the problem above. You can choose the programming language and
framework you like. There are no constraints on the user interface.
## Input
A single integer n, representing the number of rows and columns in the matrix .
n enumerations of n integers. Each enumeration describes a row. These integers must be between -100
and 100.
## Output
The absolute difference between the sums of the matrix's two diagonals as a single integer.
### Sample Input
```
11 2 4
4 5 6
10 8 -12
```
### Sample Output
15

