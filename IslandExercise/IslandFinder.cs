using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandExercise
{
    internal class IslandFinder
    {
        int[,] _mapMatrix;
        public IslandFinder(int[,] mapMatrix)
        {
            _mapMatrix = mapMatrix;
        }

        public int NumOfIslandDFS()
        {
            int numOfFoundedIsland = 0;
            for (int i = 0;  i < _mapMatrix.GetLength(0); i++)
            {
                for(int j = 0;  j < _mapMatrix.GetLength(1); j++)
                {
                    if (_mapMatrix[i, j] == 1)
                    {
                        DFSHelper(i,j);
                        numOfFoundedIsland++;
                    }
                }
            }
            return numOfFoundedIsland;
        }
        private void DFSHelper(int rowPos, int columnPos) 
        {
            //base case
            if(!IsInBound(rowPos, columnPos) || _mapMatrix[rowPos,columnPos]!=1) {
                return;
            }
            _mapMatrix[rowPos, columnPos] = 2;//mark as visited

            DFSHelper(rowPos, columnPos+1); //go right
            DFSHelper(rowPos+1, columnPos); //go down
            DFSHelper(rowPos, columnPos - 1); //go left
            DFSHelper(rowPos-1, columnPos); // go up
        }
        private bool IsInBound(int rowPos, int columnPos)
        {
            if(rowPos>=0&&rowPos<_mapMatrix.GetLength(0) && columnPos>=0&& columnPos<_mapMatrix.GetLength(1)) 
            { 
                return true; 
            }
            return false;
        }
    }
}
