using System;
using DefuseBomb;

namespace DefuseProgram
{
    class Program
    { 
        static void Main(string[] args)
        {
            Bomb defuseBomb = new Bomb();//Rules are added in the constructor

            defuseBomb.CutWires(Constants.Input1);
        }
    }
}
