using Selv_TesterApp;
using Selv_TesterApp.Tester_Øvelser;
using System;
using System.Diagnostics.CodeAnalysis;

internal class Program
  
{
    
   
  

    static void Main(string[] arg) 
    {
      /*
        Meg Maki = new Meg();
        Maki.Fname = "Maki";
        Maki.Lname = " Muxammad";
      
        Meg Ameerah = new Meg("Ahmed", "Adi");
        var n = Maki.GetFullName("maki", " m");
        


        Console.WriteLine(Maki.Fname + Maki.Lname.ToString());
        Console.WriteLine(Ameerah.ToString());
        Console.WriteLine(n);
      */
       
        /*
        List<Brus> _bruslist = new List<Brus>();

        Brus _isbandhays = new Brus("isbandhays", 2000);
        Brus _mangoMushakal = new Brus("mangoMushakal", 1500);
        Brus cambeSaafi = new Brus("cambesaafi", 1200);

        _bruslist.Add(_isbandhays);
        _bruslist.Add(_mangoMushakal);
        _bruslist.Add(cambeSaafi);

        Console.WriteLine("Velkommen til vår brusnettbutikk!\n");
        Console.WriteLine("Vi har følgende brus på lager:");


        foreach (Brus c in _bruslist) 
        {
            Console.WriteLine(c.ToString());
        
        
        
        }
        Console.WriteLine("\nHvilken brus vil du ha? Skriv inn navnet på brusen:");

        string? valgtNavn = Console.ReadLine();
        Brus valgtBrus = null;

        foreach(Brus c in _bruslist)
        {
            if (c.Navn.ToLower() == valgtNavn.ToLower())
            {
                valgtBrus = c;
                break;
            }

            if (valgtBrus != null)
            {
                Console.WriteLine($"Du har valgt {valgtBrus.Navn}. Prisen er {valgtBrus.Pris} kr. Takk for handelen!");
            }
            else
            {
                Console.WriteLine("Vi har ikke denne brusen på lager. Prøv igjen med en annen brus.");
            }
            Console.ReadKey();
        }
        */
        BrusInfo brus= new BrusInfo();
        
       

        brus.GetBrusInfo("dd",23);
        

        
        







    }




}

