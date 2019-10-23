using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GurjinderSingh_FireGame
{
    //abstract class that is used to override the method according to the working 
   public abstract class test {

        public abstract int clik(int a,int b);

        

    }
    public class mainClass:test
    {
        //class object of random class that is used to gerneate the random no to triigger 
        Random rd = new Random();
        //overridding the method of the abstract class that is used to pass the no to the main form so the bullet can be fire 
        public override int clik(int a,int b)
        {
            return rd.Next(a, b);
            throw new NotImplementedException();
        }
    }
}
