using System.Runtime.InteropServices;

while (true)  //loopar om koden så att det externa fönstret inte stängs av sig själv
{ 

    //string jobb = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("du ser ett brinnande hus och det stpr folk runt omkring som säger att folk är kvar och fast. Väljer du att gå in i huset för att rädda folken eller fortsätter du på din väg hem? (svara huset eller hem)");
    string vart = Console.ReadLine() ?? string.Empty;      //gör en string för vart så att användaren kan skriva in sitt svar
 
    
    if (vart.ToLower() == "huset")   //om användaren skriver huset så kommer det att hända det som står i if satsen
    {
        Console.Clear();
        Console.WriteLine("Du väljer att gå in i huset för att rädda de som är kvar. När du kommer in i huset ser du en liten flicka som är fast i en garderob. Men du märker att det är väldigt farligt att gå in och rädda henne då huset håller på att falla samman. Väljer du att rädda henne eller går du ut ur huset? svara(flicka eller ut)");

        string räddaFlicka = Console.ReadLine() ?? string.Empty;   // en till string för ett till val användaren kan göra

        if (räddaFlicka.ToLower() == "flicka") //om de väljer flickan händer det som är inut i if satsen
        {
            Console.Clear();
            Console.WriteLine("Du väljer att rädda flickan och hinner precis ta henne i din famn och springa ut ur den brinnande byggnaden. Du lämnar tillbaka flickan till sina föräldrar. Du är en hjälte!");

         } else if (räddaFlicka.ToLower() == "ut") {   //annars om de väljer att gå ut händer det som är i else if satsen

            Console.Clear();
            Console.WriteLine("Du väljer att inte gå in i huset och rädda de som är kvar. Du går vidare på din väg hem och tänker på de stackars människorna som är kvar i huset. Du vill på något sätt ta bort dem jobbiga tankarna. Ska du gå till en fest eller gå hem och sova? (svara fest eller sova)");

            string val = Console.ReadLine() ?? string.Empty;

            if(val.ToLower() == "fest") {

Console.Clear();
            Console.WriteLine("Du väljer att gå på festen och dricka bort dina dåliga tankar om folket. Du dricker tills du knappt kan se vad som händer runt omkring dig. Det visar sig att någon hade lagt droger i din dricka. Du blir bortförd och vaknar upp i en källare och blir sedan dödad av dina kidnappare");


            }

            else if (val.ToLower() == "sova") {

                 Console.Clear();

            Console.WriteLine("Du går hem med det stackars brinnande människorna på tanken. Du går hem och försöker lägga tanken på annat genom att kolla på en film, men allt du kan tänka på är skriken från människorna som är fast i huset. Vill du gå och lägga dig eller försöker du att ringa någon för att prata om det? (svara sova eller ringa)");

           string val2 = Console.ReadLine() ?? string.Empty;

            if (val2.ToLower() == "sova") {

                Console.Clear();

                Console.WriteLine("Du går och lägger dig och försöker att sova men dina tankar fylls av de brinnande människornas skrik och du kan inte somna för timmar och timmar. När du tillslut somnar fylls dina drömmar av eld och skrik och för hela resten av ditt liv kommer varje dröm och varje natt vara fylld av trauma. Du kommer aldrig kunna prata om upplevelsen och du lever med skulden att du inte räddade de som var kvar i huset");

         } if(val2.ToLower() == "ringa") {

             Console.Clear();

            Console.WriteLine("Du ringer en vän för att prata om det som hänt. Du berättar om hur du känner och hur du inte kan släppa tanken på de som är kvar i huset. Din vän lyssnar och tröstar dig och försöker förklara att det var otroligt farligt och att han hade gjort samma sak. Han vill hällre ha dig levenade än död från att du riskerar ditt liv. Du känner dig mycket bättre och kan sova gott med vetskapen om att du gjorde det rätta. Du är kanske inte en hjälte, men du lever fortfarande och det är din familj och vänner glada för");
    } 


            }

            }

            }

   else if (vart.ToLower() == "hem") {  //det som händer om de väljer att gå hem och inte in i det brinnande huset
        
        Console.Clear();

                    Console.WriteLine("Du väljer att inte gå in i huset uatn fortsätter påväg hem, du har haft en tuff dag och vill bara hem och lira lite games med polarna. På vägen hem stoppar du för att köpa lite snacks. Vill du köpa lösgodis, chips eller glass? (svara lösgodis, chips eller glass)");

                
            
            string snacks = Console.ReadLine() ?? string.Empty; // en string för vilka snacks de väljer att köpa

            if(snacks.ToLower() == "lösgodis") { // ifall de väljer lös godis
                Console.Clear();   
                
                Console.WriteLine("Du köper ditt lösgodis och sätter dig för att lira lite CS2, du hoppar in i ett call med boisen, snackar lite skit och har riktigt roligt. Men när du sätter dig för att äta ditt godis inser du att du hade köpt en godis som hade jordnötter i sig och du är dödligt allergisk till jordnötter. Du får en allergisk reaktion och dör");
                
                 } else if(snacks.ToLower() == "chips") {  //ifall de väljer chips
                     Console.Clear();
                     
                     Console.WriteLine("Du köper chips och sätter dig för att lira lite CS2, du hoppar in i ett call med boisen, snackar lite skit och har riktigt roligt. Men du moffar i dig lite för mycket chips medans to lirar och du sätter en sjuk mängd av chips i halsen och dör av kvävning");

                 } else if(snacks.ToLower() == "glass") {  //ifall de väljer glass
                     Console.Clear();
                     
                     Console.WriteLine("Du köper glass och sätter dig för att lira lite CS2, du hoppar in i ett call med boisen, ni sitter uppe nästan hela natten och spelar alla olika slags roliga spel. Du har en undebar kväll och inser att du gjorde rätt val. Du överlevde");
                 }

    }    

    Console.WriteLine("Vill du spela igen? (svara ja eller nej)");

    string spelaIgen = Console.ReadLine() ?? string.Empty;   //en string för om de vill spela igen eller inte
 
    if(spelaIgen.ToLower() == "nej") {  // om de väljer nej så stängs det externa terminalfönstret ned
        break;
    }
    else if(spelaIgen.ToLower() == "ja") { // om de väljer ja så fortsätter koden
        Console.Clear();
    }

}
