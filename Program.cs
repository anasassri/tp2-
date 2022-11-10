using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3
{
    internal class point
    {
        private int X; 
        private int Y;

        public point (int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public int Getx()
        {
            return X;   
        }
        public int Gety()
        {
            return Y;
        }
        public void Setx(int X )
        {
            this.X = X; 
        }
        public void Sety( int Y)
        {
            this.Y = Y;
        }
        
        public point Transaltion(point q) {
         point p_resulat = new point (X+q.X , Y+q.Y);
            return p_resulat;
           

        }

      public int Distance(point p , point q)
        {

            int resultat; 
            q = new point (X,Y);
            p= new point(X, Y;
            resu = (int)Math.Sqrt( Math.Pow(p.X-q.X,2) - Math.Pow(p.Y-q.Y,2) ); 
            return resutat; 

        }

    }