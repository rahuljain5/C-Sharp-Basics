using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Program6
    {
        static void Main()
        {
            int lcm=60,count = 1;
            for (int i = 0; count <= 4; i=i+lcm)
            {
                if((i+1)%7==0 )
                {
                    if (count !=3)
                    {
                        Console.Write(i+1);
                
                    }
                    count++;
                }

                }
        }
        
    }
}
