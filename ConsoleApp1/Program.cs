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

            AlberoBinario a = new AlberoBinario(5, 4, 89);
        }
    }
public class AlberoBinario
    {
        private AlberoBinario sx;
        private AlberoBinario dx;
        private int val;
        
        public AlberoBinario(AlberoBinario sx,AlberoBinario dx, int val)
        {
            this.sx = sx;
            this.dx = dx;
            this.val = val;
        }
        public int getVal()
        {
            return val;
        }
        public AlberoBinario ins(AlberoBinario r)
        {
            r = new AlberoBinario(sx,dx,val);
            if (r != null)
            {
                if (r < val )
                {
                    sx.getVal() = val;
                }
                else
                {
                    dx.getVal() = val;
                }
            }
                return null;
            
        }
    }
}

