# School Java Project: Matrix Determinant

I wrote this code during my computer science class (in 9th grade)in Germany on BlueJ

## About the Project
A Java program that calculates the determinant of an n x n square matrix using recursive Laplace expansion (minor/cofactor expansion).

## How it Works
* **`findDeterminant`**: Recursively breaks down the matrix into smaller minors, alternating the signs of the coefficients.
* **`minorMatrix`**: Creates a smaller submatrix by excluding the specified row and column.
* **`determinantTwoXTwo`**: The base case that calculates the determinant for a 2 x 2 matrix.
