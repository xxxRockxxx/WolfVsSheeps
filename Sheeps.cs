using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfsVsSheeps
{
    class Sheeps:Animal
    {
        protected char Sheeeps = 'S';
        public void GenerationSheepinMatrix(int numberSheeps)
        {
            base.GenerationAnimal(Sheeeps, numberSheeps);
        }
        public void  MoveSheeps()
        {
            Motion(Sheeeps);
        }

            
    }
}
