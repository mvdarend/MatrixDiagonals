using System;
using System.Collections.Generic;

namespace Matrix.Bll
{
    public class Calculations
    {
		public static int CalculateMatrix(List<int> matrixValueList)
		{
			// get the grid size from the square root of the matrixValueList count
			int gridSize = (int)Math.Sqrt(matrixValueList.Count);

			// top left -> bottom right
			int firstDiagonal = 0;
			// bottom left -> top right
			int secondDiagonal = 0;

			// Loop through myMatrix and grab the corresponding value from MyList
			for (int x = 0; x < gridSize; x++)
			{
				for (int y = 0; y < gridSize; y++)
				{
					// Get the value from myList
					int myValue = matrixValueList[x * gridSize + y];

					// if x==y then it's a 'top left -> bottom right' match
					if (x == y) { firstDiagonal += myValue; }

					// if x + y == matrixSize-1 then it's a 'bottom left -> top right' match
					if (x + y == gridSize - 1) { secondDiagonal += myValue; }
				}
			}

			return Math.Abs(firstDiagonal - secondDiagonal);
		}
	}
}
