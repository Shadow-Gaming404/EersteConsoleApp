using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




internal class Opdracht_3
{

    bool typingIsGood = true;
    public void Start() {


            //weer check
            if (typingIsGood) { 
            Console.WriteLine("Wat is het weer vandaag? (zonnig/regenachtig/bewolkt)");
            string weer = Console.ReadLine();
            //schrijf check
            if (weer == "zonnig" || weer == "regenachtig" || weer == "bewolkt") { }
            else { Console.WriteLine("Zo slecht gespeld dat ik het programma afsluit."); typingIsGood = false; }

            if (typingIsGood)
            {
                //temperatuur check
                Console.WriteLine("En hoe koud/warm is het?");
                string temperatuur = Console.ReadLine();
                //schrijf check
                bool hasLetter = temperatuur.Any(char.IsLetter);



                if (hasLetter) { Console.WriteLine("Gij kan nie typen man, dat is nie eens een getal. Typ de volgende keer maar beter."); }

                else if (!hasLetter) {
                    int temp = Convert.ToInt32(temperatuur);

                    if (weer == "zonnig") 
                    {

                        if (temp >= 20) { Console.WriteLine("Het is zonnig en warm, ga lekker naar buiten, geen jas nodig."); }
                        else if (temp < 20) { Console.WriteLine("Wel je jas aan houden, maar misschien ook wat zonnebrand mee nemen als het te zonnig wordt."); }
                    }
                    else if (weer == "regenachtig")
                    {

                        if (temp >= 20) { Console.WriteLine("Het is regenachtig en warm, ik zou zeggen dat je een paraplu nodig hebt als je zonder jas buiten wilt zijn."); }
                        else if (temp < 20) { Console.WriteLine("Jas aan doen, het is erg koud. Of blijf gewoon binnen, veel makkelijker met dit spuug weer."); }
                    }
                    else if (weer == "bewolkt")
                    {

                        if (temp >= 20) { Console.WriteLine("Het is bewolkt maar warm, ga lekker naar buiten, niet echt een jas nodig."); }
                        else if (temp < 20) { Console.WriteLine("Wel je jas aan houden, het is best koud."); }
                    }
                }
            }
        }
    }
}

