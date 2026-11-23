using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_2
{
    bool Playing = true;

    bool Slaapkamer = true;
    bool Gang = false;
    bool Beneden = false;
    bool Buiten = false;
    public void Start()
    {

        //Anders werkt de terug functie niet.
        while (Playing)
        {

            //Slaapkamer interactions

            if (Slaapkamer)
            {
                Console.WriteLine("----Will je door de deur uit je kamer gaan, uit het raam springen van je kamer, een baterij eten voor geen eene reden of misschien je lamp hervangen?");
                Console.WriteLine("--(Typ raam, deur, baterij, of lamp)");
                string Slaapkamer_Vraag = Console.ReadLine();
                if (Slaapkamer_Vraag == "raam") { Console.WriteLine(">Je springt uit je raam en beland precies op je nek, niet precies een slim idee. Game Over"); Playing = false; }
                else if (Slaapkamer_Vraag == "baterij") { Console.WriteLine(">Je gaat dood omdat je een baterij heb gegeten, best logisch. Game Over"); Playing = false; }
                else if (Slaapkamer_Vraag == "lamp") { Console.WriteLine(">Je gaat dood doordat jij je lamp wou vervangen maar de stroom niet eerst heb uit gezet. Game Over"); Playing = false; }
                else if (Slaapkamer_Vraag == "deur")
                {
                    Console.WriteLine(">Goed idee, je gaat door je deur ");
                    Slaapkamer = false;
                    Gang = true;
                }
                else { Console.WriteLine(">Dat was nie eens een optie man."); }
            }

            //Gang interactions

            if (Gang)
            {
                Console.WriteLine("----Waar wil je nu naar toe? Naar beneden, naar de badkamer, naar het balkon of gewoon weer terug naar je kamer?");
                Console.WriteLine("--(Typ balkon, badkamer, terug, of beneden)");
                string Gang_Vraag = Console.ReadLine();
                if (Gang_Vraag == "badkamer") { Console.WriteLine(">Je gaat de badkamer in, maar glijd uit of de nate tegels. Je valt en breekt je nek. Game Over"); Playing = false; }
                else if (Gang_Vraag == "balkon") { Console.WriteLine(">Je gaat naar het balkon, maar het balkon geeft er ineens mee op. Het valt helemaal naar beneden met jou er in en jij land, je raad het, op je nek. Game Over"); Playing = false; }
                else if (Gang_Vraag == "terug") { Console.WriteLine(">Toch geen zin om naar buiten te gaan? Wat jij wilt."); Gang = false; Slaapkamer = true; }
                else if (Gang_Vraag == "beneden")
                {
                    Console.WriteLine(">Goed idee, je gaat naar beneden.");
                    Gang = false;
                    Beneden = true;
                }
                else { Console.WriteLine(">Dat was nie eens een optie man."); }
            }

            //Beneden interactions

            if (Beneden)
            {
                Console.WriteLine("----Waar wil je nu naar toe? Naar de keuken, naar de achtertuin, gewoon weer naar boven, of naar buiten door de voordeur?");
                Console.WriteLine("--(Typ achtertuin, voordeur, achtertuin, of terug)");
                string Beneden_Vraag = Console.ReadLine();
                if (Beneden_Vraag == "keuken") { Console.WriteLine(">Je gaat naar de keuken en ziet dat je het fornuis niet heb uitgedaan. Huis gaat kabiem. Game Over"); Playing = false; }
                else if (Beneden_Vraag == "achtertuin") { Console.WriteLine(">Je gaat door de achterdeur, maar de seconde dat je met bijde voeten op de grond staat, valt het balkon op je. Je had altijd al een idee dat het niet zo goed vast zat, wat een rot ding. Game Over"); Playing = false; }
                else if (Beneden_Vraag == "terug") { Console.WriteLine(">Toch niet naar beneden? Kan ook."); Beneden = false; Gang = true; }
                else if (Beneden_Vraag == "voordeur")
                {
                    Console.WriteLine(">Best logisch, je gaat de voordeur uit.");
                    Beneden = false;
                    Buiten = true;  
                }
                else { Console.WriteLine(">Dat was nie eens een optie man."); }
            }

            //Buiten interactions (/endings ig)

            if (Buiten)
            {
                Console.WriteLine("----Wat zou je nu willen doen? Grass aan raken, naar boven kijken, terug naar binnen gaan, of misschien die eene baterij in je broekzak opeten?");
                Console.WriteLine("--(Typ grass, naar boven kijken, terug naar binnen, of baterij)");
                string Buiten_Vraag = Console.ReadLine();
                if (Buiten_Vraag == "grass") { Console.WriteLine(">>Je raakt grass aan, gefeliciteerd! Ending 1: Gezond (goed genoeg)"); Playing = false; }
                else if (Buiten_Vraag == "naar boven kijken") { Console.WriteLine(">>Je kijkt naar boven, wat een mooie dag, maar waarom ziet het er uit alsof de maan dichterbij komt? Ending 2: The Legend of Zelda, Majora's Mask (Nintendo don't sue me pls)"); Playing = false; }
                else if (Buiten_Vraag == "terug naar binnen") { Console.WriteLine(">>Je gaat gewoon weer terug naar binnen. Ending 3: A true game developer"); Playing = false; }
                else if (Buiten_Vraag == "baterij") {Console.WriteLine(">>Je eet de baterij op en gaat dood, zo dichtbij maar zo verweg. Ending 4: Nog altijd een mongool"); Playing = false;}

                else { Console.WriteLine(">Dat was nie eens een optie man."); }
            }
        }
    }
}
