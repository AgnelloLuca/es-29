using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlberoBinario sx = new AlberoBinario(89);
            AlberoBinario dx = new AlberoBinario(28);
            AlberoBinario r = new AlberoBinario(69);

            sx = new AlberoBinario(39);
            dx = new AlberoBinario(66);
            r.aggFiSx(new AlberoBinario(sx, dx, 89));
            sx = new AlberoBinario(2);
            dx = new AlberoBinario(71);
            r.aggFiSx(new AlberoBinario(sx, dx, 39));
            sx = new AlberoBinario(44);
            dx = new AlberoBinario(12);
            r.aggFiDx(new AlberoBinario(sx, dx, 28));
            r.Stampa();
            Console.WriteLine("stampa con il To String");
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
    public class AlberoBinario
    {
        private AlberoBinario sx;
        private AlberoBinario dx;
        private int val;
        public AlberoBinario(AlberoBinario sx, AlberoBinario dx, int val)
        {
            this.sx = sx;
            this.dx = dx;
            this.val = val;
        }
        public AlberoBinario(int valore)
        {
            this.sx = null;
            this.dx = null;
            this.val = valore;
        }
        public void aggFiSx(AlberoBinario a)
        {
            this.sx = a;
        }
        public void aggFiDx(AlberoBinario a)
        {
            this.dx = a;
        }
        public void Stampa()
        {
            if (sx == null && dx == null)
            {
                Console.WriteLine(this.val);
            }
            else
            {
                Console.WriteLine(this.val);
                try
                {
                    sx.Stampa();
                }
                catch
                {

                }
                try
                {
                    dx.Stampa();
                }
                catch
                {

                }
            }
        }
        public override string ToString()
        {
            string s = null;
            if (sx == null && dx == null)
            {
                s += this.val;  
            }
            else
            {
                s += this.val;
            try
            {
                    s += sx.ToString();
                }
                catch
                {

                }
                try
                {
                    s += dx.ToString();
                }
                catch
                {

                }
            }
            return "(" + s + ")";
        }
    }
}

