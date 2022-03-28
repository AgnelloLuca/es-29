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
            AlberoBinario dx = null;
            AlberoBinario r = new AlberoBinario(69);

            r.aggFiSx(new AlberoBinario(sx, dx, 69));
            sx = null;
            dx = new AlberoBinario(28);
            r.aggFiDx(new AlberoBinario(sx, dx, 69));
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

         /*   Console.WriteLine("stampa con i primi figli rimossi");
            r.rimSx(new AlberoBinario(sx, dx, 39));
            r.Stampa();
            
            Console.WriteLine("stampa con il To String");
            Console.WriteLine(r);*/
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
        /*public void rimSx(AlberoBinario a)
        {
            this.sx=null;
        }
        public void rimDx(AlberoBinario a)
        {
            this.dx = null;
        }*/
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
       /* public AlberoBinario rimuoviSx(AlberoBinario a)
        {
            if (sx==null)
            {
                Console.WriteLine("l' albero dalla parte sinistra è vuoto");
                return null;
            }
            else
            {
                AlberoBinario tmpsx = sx;
                sx.rimSx(a);
                dx.rimDx(a);
                return tmpsx;
            }
            if (dx == null)
            {
                Console.WriteLine("l' albero dalla parte destra è vuoto");
                return null;
            }
            else
            {
                AlberoBinario tmpdx = dx;
                sx.rimSx(a);
                dx.rimDx(a);
                return tmpdx;
            }
        }*/
        
        public override string ToString()
        {
            string s = null;
            if (sx == null && dx == null)
            {
                return this.val + "";
            }
            else if (sx != null && dx != null)
            {
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
                return this.val + "(" + sx + ")" + "(" + dx + ")";
            }
            else if (sx != null && dx == null)
            {
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
                return this.val + "(" + sx + ")" + "(" + 0 + ")";
            }
            else
            {
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
                return this.val + "(" + 0 + ")" + "(" + dx + ")";
            }
        }
    }
}

