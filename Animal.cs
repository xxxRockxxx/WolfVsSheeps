using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfsVsSheeps
{
    public class Animal
    {
        protected int _numberOfAnimal;
        private int _direction_of_travel;
        protected int _x;
        protected int _y;
        protected int _oldMatrix_x;
        protected int _oldMatrix_y;
        protected static bool _WokrGame = true;
        protected static char[,] Matrix;
        protected static char[,] newMatrix;
        protected static int _LengthX;
        protected static int _LengthY;
        protected  static int _numberOfmoves;
        protected static int _countSheeps;
        protected static int _countWolfs;

        public void GenerationMatrix(int numberOfAnimals)
        {
            _LengthX = numberOfAnimals * 2;
            _LengthY = numberOfAnimals * 2;
            Matrix = new char[_LengthX, _LengthY];
            newMatrix = new char[_LengthX, _LengthY];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = '0';
                    newMatrix[i, j] = '0';
                }
            }
        }

        protected void GenerationAnimal(char nameAnimal, int numberAnimal)
        {
            Random rnd = new Random();
            int count = 0;
            while (count < numberAnimal)
            {
                _oldMatrix_x = rnd.Next(0, _LengthX);
                _oldMatrix_y = rnd.Next(0, _LengthY);
                if (Matrix[_oldMatrix_y, _oldMatrix_x] == '0')
                {
                    Matrix[_oldMatrix_y, _oldMatrix_x] = nameAnimal;
                    count++;
                }
            }
        }


        protected void Motion(char Animal)
        {
            _oldMatrix_y = 0;
            _oldMatrix_x = 0;

            while (_oldMatrix_y != _LengthY)
            {
                if (Matrix[_oldMatrix_y, _oldMatrix_x] == Animal)
                {
                    if (_oldMatrix_y == 0 & _oldMatrix_x == 0)
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_y >= 0 & _x >= 0)
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else if (_oldMatrix_x == 0 &(_oldMatrix_y != _LengthY - 1 & _oldMatrix_y != 0))
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_x >= 0)
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else if (_oldMatrix_y == _LengthY - 1 & _oldMatrix_x == 0)
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_y <_LengthY & _x >= 0)
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else if (_oldMatrix_y == 0 & _oldMatrix_x == _LengthX - 1)
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_y >= 0 & _x <= 0)
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else if (_oldMatrix_x == _LengthX - 1 & (_oldMatrix_y != _LengthY - 1 & _oldMatrix_y != 0))
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_x <_LengthX )
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else if (_oldMatrix_x == _LengthX - 1 & _oldMatrix_y == _LengthY - 1)
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_x <_LengthX & _y < _LengthY )
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else if (_oldMatrix_y == 0 & (_oldMatrix_x != _LengthX - 1 & _oldMatrix_x != 0))
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_y >= 0)
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else if (_oldMatrix_y == _LengthY - 1 & (_oldMatrix_x != _LengthX - 1 & _oldMatrix_x != 0))
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_y < _LengthY)
                            {
                                if(Matrix[_y, _x] == '0')
                                {
                                    newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                                }
                            }
                            else
                            {
                                _x = _oldMatrix_x;
                                _y = _oldMatrix_y;
                            }
                        }
                    }

                    else
                    {
                        while (newMatrix[_y, _x] != Animal)
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (Matrix[_y, _x] == '0')
                            {
                                newMatrix[_y, _x] = Matrix[_oldMatrix_y, _oldMatrix_x];
                            }
                        }
                    }
                }
                _x = 0;
                _y = 0;
                _oldMatrix_x++;
                if (_oldMatrix_x == _LengthX)
                {
                    _oldMatrix_x = 0;
                    _oldMatrix_y++;
                }
            }
        }
        
        protected void CopyMatrix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = newMatrix[i, j];
                    newMatrix[i, j] = '0';
                }
            }
        }

        protected virtual void Multiply()
        {
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        if (Matrix[i, j] == 'S')
                        {
                            if (i == 0 & j == 0)
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j + 1] == '0' & Matrix[i, j + 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'S';

                                }
                            }
                            else if (i == 0 & (j != 0 & j != _LengthX - 1))
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j + 1] == '0' & Matrix[i, j + 1] == '0' & Matrix[i, j - 1] == '0' & Matrix[i + 1, j - 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'S';

                                }
                            }

                            else if (i == 0 & j == _LengthX - 1)
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j - 1] == '0' & Matrix[i, j - 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'S';

                                }
                            }
                            else if (j == 0 & (i != _LengthY - 1 & i != 0))
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j + 1] == '0' & Matrix[i, j + 1] == '0' & Matrix[i - 1, j + 1] == '0' & Matrix[i - 1, j] == '0')
                                {
                                    Matrix[i, j + 1] = 'S';
                                }
                            }
                            else if (j == 0 & i == _LengthY - 1)
                            {
                                if (Matrix[i - 1, j] == '0' & Matrix[i - 1, j + 1] == '0' & Matrix[i, j + 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'S';
                                }
                            }
                            else if (j == _LengthX - 1 & (i != _LengthY - 1 & i != 0))
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j - 1] == '0' & Matrix[i, j - 1] == '0' & Matrix[i - 1, j - 1] == '0' & Matrix[i - 1, j] == '0')
                                {
                                    Matrix[i, j - 1] = 'S';
                                }
                            }
                            else if (j == _LengthX - 1 & i == _LengthY - 1)
                            {
                                if (Matrix[i - 1, j] == '0' & Matrix[i - 1, j - 1] == '0' & Matrix[i, j - 1] == '0')
                                {
                                    Matrix[i, j - 1] = 'S';
                                }

                            }
                            else if ((j != _LengthX - 1 & j != 0) & (i != _LengthY - 1 & i != 0))
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j - 1] == '0' & Matrix[i, j - 1] == '0' & Matrix[i - 1, j - 1] == '0' & Matrix[i - 1, j] == '0' & Matrix[i - 1, j + 1] == '0' &
                                    Matrix[i, j + 1] == '0' & Matrix[i + 1, j + 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'S';
                                }
                            }
                        }

                    }
                }
                _numberOfmoves = 0;
        }

        private void GenerateNumber()
        {
            Random rnd = new Random();
            _direction_of_travel = rnd.Next(0, 8);
        }

        private void ChooseMotion()
        {
            switch (_direction_of_travel)
            {
                case 0:
                    _y--;
                    break;
                case 1:
                    _y++;
                    break;
                case 2:
                    _x--;
                    break;
                case 3:
                    _x++;
                    break;
                case 4:
                    _x++;
                    _y++;
                    break;
                case 5:
                    _y++;
                    _x--;
                    break;
                case 6:
                    _x--;
                    _y--;
                    break;
                case 7:
                    _x++;
                    _y--;
                    break;
            }
        }
        protected void CountAnimal()
        {
            _countSheeps = 0;
            _countWolfs = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 'S')
                    {
                        _countSheeps++;
                    }
                    else if (Matrix[i, j] == 'W')
                    {
                        _countWolfs++;
                    }
                }
            }

            if(_countWolfs==0 || _countSheeps == 0)
            {
                _WokrGame = false;
            }
        }
        


    }
}


