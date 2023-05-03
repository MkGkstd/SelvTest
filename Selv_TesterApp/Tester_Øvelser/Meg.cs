using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selv_TesterApp.Tester_Øvelser
{
    public class Meg
    {
        public Meg()
        {
        }

        public Meg(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }
        

        
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? FullName { get; set; }


        public string GetFullName(string fname, string lname) 
        {
            return $"{fname}  {lname}";
            
        
        
        }



        public override string ToString()
        {
            return $"FirstName: {Fname}  {Lname}";
        }



    }
}

