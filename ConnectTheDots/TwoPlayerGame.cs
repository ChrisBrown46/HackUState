using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectTheDots
{
    public class TwoPlayerGame
    {
        // Server signal switches this bool, which dicatates if the player can make actions.
        private bool _player1Turn { get; set; }
        private int _rows { get; set; }
        private int _columns { get; set; }
        private int _player1score { get; set; }
        private int _player2score { get; set; }
        private int[,] nodes;

        public TwoPlayerGame(int rows, int columns)
        {
            _player1Turn = true;
            _player1score = 0;
            _player2score = 0;
            _rows = rows;
            _columns = columns;
            nodes = new int[rows, columns];
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < columns; ++j)
                    nodes[i, j] = 0;
        }
        public int addEdge(int[] firstPoint, int[] secondPoint)
        {
            // Adding edgenumber to first edge possibility
            int[] firstArray = { firstPoint[0] - secondPoint[0], firstPoint[1] - secondPoint[1] }; // Such as [0,1]
            int edgeNumber = getEdgeNumber(firstArray); // 1, 2, 4, or 8
            nodes[firstPoint[0], firstPoint[1]] += edgeNumber;

            //Adding edgenumber to second edge possibility
            int[] secondArray = { secondPoint[0] - firstPoint[0], secondPoint[1] - firstPoint[1] }; // Such as [0,1]
            edgeNumber = getEdgeNumber(secondArray); // 1, 2, 4, or 8
            nodes[secondPoint[0], secondPoint[1]] += edgeNumber;

            if (_player1Turn)
            {
                _player1score += checkBox(firstPoint, secondPoint, edgeNumber);
                return _player1score;
            }
            else
            {
                _player2score += checkBox(firstPoint, secondPoint, edgeNumber);
                return _player2score;
            }
        }

       
        private int checkBox(int[] node1, int[] node2, int edge)
        {
            int sum = 0;

            if (edge == 1 || edge == 4) // Vertical edge
            {
                if (nodes[node1[0] , node1[1]] >= 8 && nodes[node2[0] , node2[1]] >= 8)
                    if (nodes[node2[0] , node2[1] - 1] % 2 == 1)
                        ++sum;

                if (checkRightEdge(nodes[node1[0], node1[1]]) && checkRightEdge(nodes[node2[0], node2[1]]))
                    if (nodes[node2[0] , node2[1] + 1] % 2 == 1)
                        ++sum;
            }
            else // Horizontal edge
            {
                if (nodes[node1[0], node1[1]] % 2 == 1 && nodes[node2[0], node2[1]] % 2 == 1)
                    if (nodes[node2[0] - 1, node2[1]] >= 8)
                        ++sum;

                if (checkBottomEdge(nodes[node1[0], node1[1]]) && checkBottomEdge(nodes[node2[0], node2[1]]))
                    if (nodes[node1[0] + 1, node1[1]] % 2 == 1)
                        ++sum;
            }
       
            return sum;
        }
        private int getEdgeNumber(int[] edge)
        {
            int row = edge[0];
            int column = edge[1];

            int sum = 0;
            if (row == 0)
            {
                if (column == 1) // [0,1]  -> left  -> 8
                    sum += 8;
                else             // [0,-1] -> right -> 2
                    sum += 2;
            }
            else if (row == 1)   // [1,0]  -> up    -> 1
                sum += 1;
            else                 // [-1,0] -> down  -> 4
                sum += 4;

            return sum;
        }

        private bool checkBottomEdge(int edge)
        {
            switch(edge)
            {
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 15:
                    return true;
                default:
                    return false;
            }
        }

        private bool checkRightEdge(int edge)
        {
            switch(edge)
            {
                case 2:
                    return true;
                case 3:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                default:
                    return false;
            }
        }
    }
}
