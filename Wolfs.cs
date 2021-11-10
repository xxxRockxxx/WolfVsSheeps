using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfsVsSheeps
{
    class Wolfs : Animal
    {
        protected char Woolfs = 'W';
        public void GenerationWolfsinMatrix(int numberWolfs)
        {
            char Woolfs = 'W';
            GenerationAnimal(Woolfs, numberWolfs);
        }
        public void MoveWolfs()
        {
            Motion(Woolfs);
            _numberOfmoves++;
            CopyMatrix();
            Multiply();
            if (_numberOfmoves == 4)
            {
                base.Multiply();
            }
            CountAnimal();
        }
        protected override void Multiply()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 'S')
                    {
                        if (i == 0 & j == 0)
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else if (i == 0 & (j != 0 & j != _LengthX - 1))
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W' || Matrix[i, j - 1] == 'W' || Matrix[i + 1, j - 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else if (i == 0 & j == _LengthX - 1)
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j - 1] == 'W' & Matrix[i, j - 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else if (j == 0 & (i != _LengthY - 1 & i != 0))
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W' || Matrix[i - 1, j + 1] == 'W' & Matrix[i - 1, j] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else if (j == 0 & i == _LengthY - 1)
                        {
                            if (Matrix[i - 1, j] == 'W' || Matrix[i - 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else if (j == _LengthX - 1 & (i != _LengthY - 1 & i != 0))
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j - 1] == 'W' || Matrix[i, j - 1] == 'W' || Matrix[i - 1, j - 1] == 'W' || Matrix[i - 1, j] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else if (j == _LengthX - 1 & i == _LengthY - 1)
                        {
                            if (Matrix[i - 1, j] == 'W' || Matrix[i - 1, j - 1] == 'W' || Matrix[i, j - 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else if (i==_LengthY-1 &(j!=_LengthX-1 & j != 0))
                        {
                            if (Matrix[i-1,j] == 'W' || Matrix[i - 1, j+1] == 'W' || Matrix[i - 1, j - 1] == 'W' || Matrix[i , j + 1] == 'W' || Matrix[i , j -1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }

                        else
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j - 1] == 'W' || Matrix[i, j - 1] == 'W' || Matrix[i - 1, j - 1] == 'W' || Matrix[i - 1, j] == 'W' || Matrix[i - 1, j + 1] == 'W' ||
                                Matrix[i, j + 1] == 'W' || Matrix[i + 1, j + 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'S';
                            }
                        }
                    }
                    else
                    {
                        newMatrix[i, j] = Matrix[i, j];
                    }
                }
            }
             if(_numberOfmoves == 4)
            {
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        if (Matrix[i, j] == 'W')
                        {
                            Matrix[i, j] = '0';
                        }
                    }
                }
            }
            

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = newMatrix[i, j];
                    newMatrix[i, j] = '0';
                }
            }
        }
    }
}
