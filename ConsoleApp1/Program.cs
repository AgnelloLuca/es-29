using System;
using System.Collections;
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
            AlberoBinario sx = null;
            AlberoBinario dx = null;
            AlberoBinario p = new AlberoBinario(39);
            AlberoBinario r = new AlberoBinario(69);

            sx = new AlberoBinario(39);
            dx = new AlberoBinario(66);
            r.aggFiSx(new AlberoBinario(sx, dx, 89));
            
            sx = new AlberoBinario(2);
            dx = new AlberoBinario(71);
            p.aggFiSx(new AlberoBinario(sx, dx, 39));
     
            sx = new AlberoBinario(44);
            dx = new AlberoBinario(12);
            r.aggFiDx(new AlberoBinario(sx, dx, 28));

            r.Stampa();
               Console.WriteLine("stampa con il To String");
               Console.WriteLine(r);

              /* Console.WriteLine("--Iterativa--------------");
               r.stampaIterativa();
               Console.WriteLine("--Iterativa2--------------");
               r.stampaIterativa2();*/
   
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
            this.val = valore;
            this.sx = null;
            this.dx = null;
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
        public void stampait()
        {
            Stack s = new Stack();
            s.Push(this);
            while (s.Count != 0)
            {
                AlberoBinario tmp = (AlberoBinario)s.Pop();
                Console.WriteLine(tmp.val);
                if (tmp.dx != null)
                    s.Push(tmp.dx);
                if (tmp.sx != null)
                    s.Push(tmp.sx);
            }
        }
        public void stampait2()
        {
             Queue c = new Queue();
            c.Enqueue(this);
            AlberoBinario tmp = this;
            while (c.Count != 0)
            {
                do
                {
                    Console.WriteLine(tmp.val);
                    c.Enqueue(tmp);
                    tmp = tmp.dx;
                } while (tmp != null);
                do
                {
                    tmp = (AlberoBinario)c.Dequeue();
                } while (tmp.sx == null);
                tmp = tmp.sx;
            }
        }
        public override string ToString()
        {
            string s = null;
            if (sx == null && dx == null)
            {
                return "(" + this.val + ")";
            }
            else
            {
                s += "(" + this.val;
                if (sx != null)
                {
                    s += sx.ToString();
                }
                if (dx != null)
                {
                    s += dx.ToString() + ")";
                }
            }
            return s;
        }
    }
}

