using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selv_TesterApp.Tester_Øvelser
{
    public class BrusInfo
    {
        List<Brus> _brusInfo = new List<Brus>();

        public void GetBrusInfo(string v, Brus brus) 
        {
           Console.WriteLine(brus.ToString());



            _brusInfo.Add(brus);
            Console.ReadKey();

            


        
        }
        
        

        
    }
    
    
}
