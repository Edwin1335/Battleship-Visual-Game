using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApplication
{
    class Board
    {
        struct Position
        {
            public bool occupied;
            public bool sunked;
            public int row;
            public int col;
        }

        private Position[,] position;
        private int shipsToSink = 3;


        public Board()
        {
            position = new Position[4, 4];
            for (int i = 0; i < position.GetLength(0); i++)
            {
                for (int j = 0; j < position.GetLength(1); j++)
                {
                    position[i, j].occupied = false;
                    position[i, j].sunked = false;
                    position[i, j].col = j;
                    position[i, j].row = i;
                }
            }
        }

        public bool placeShip(int row, int col)
        {
            if (!position[row, col].occupied)
            {
                position[row, col].occupied = true;
                return true;
            }
            return false;
        }

        public bool positionOccupied(int row, int col)
        {
            return position[row, col].occupied;
        }

        public void sinkShip(int row, int col)
        {
            if(positionOccupied(row,col))
            {
                position[row, col].sunked = true;
                shipsToSink--;
            }
        }

        public bool hasLost()
        {
            return (shipsToSink == 0);
        }
    }
}
