using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_2
{
    public void Start()
    {
        bool Start = true;
        if (Start)
        {
            Console.WriteLine("Will je door de deur uit je kamer gaan, uit het raam springen van je kamer, een baterij eten voor geen eene reden of misschien je lamp hervangen? (typ deur, raam, baterij of lamp)");
            string Slaapkamer_Vraag = Console.ReadLine();
            if (Slaapkamer_Vraag == "raam") { Console.WriteLine("Je springt uit je raam en beland precies op je nek, niet precies een slim idee. Game Over"); }
            if (Slaapkamer_Vraag == "baterij") { Console.WriteLine("Je gaat dood omdat je een baterij heb gegeten, best logisch. Game Over"); }
            if (Slaapkamer_Vraag == "lamp") { Console.WriteLine("Je gaat dood doordat jij je lamp wou vervangen maar de stroom niet eerst heb uit gezet. Game Over"); }
            if (Slaapkamer_Vraag == "deur")
            {
                Console.WriteLine("Goed idee, je gaat door je deur ");

                Console.WriteLine("Waar wil je nu naar toe? Naar beneden, naar de badkamer, naar het balkon of gewoon weer terug naar je kamer? (typ benden, badkamer, balkon of terug)");

                Console.WriteLine("Will je door de deur uit je kamer gaan, uit het raam springen van je kamer, een baterij eten voor geen eene reden of misschien je lamp hervangen? (typ deur, raam, baterij of lamp)");
                string Gang_Vraag = Console.ReadLine();
                if (Gang_Vraag == "badkamer") { Console.WriteLine("Je springt uit je raam en beland precies op je nek, niet precies een slim idee. Game Over"); }
                if (Gang_Vraag == "baterij") { Console.WriteLine("Je gaat dood omdat je een baterij heb gegeten, best logisch. Game Over"); }
                if (Gang_Vraag == "lamp") { Console.WriteLine("Toch geen zin om naar buiten te gaan? Wat jij wilt."); }
                if (Gang_Vraag == "beneden")
                {
                    Console.WriteLine("Goed idee, je gaat door je deur ");

                    Console.WriteLine("Waar wil je nu naar toe? Naar beneden, naar de badkamer, naar het balkon of gewoon weer terug naar je kamer? (typ benden, badkamer, balkon of terug)");

                }
            }
        }
    }
}
