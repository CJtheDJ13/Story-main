// bool isAvlive = 3 > 16;
// bool isAvlive = 3 < 16;
// bool isAvlive = 3 == 16;
// bool isAvlive = 3 + 13 != 16;
// bool isAvlive = 3 + 13 != 16 && 3 > 3;
// Console.WriteLine(isAvlive);

Console.WriteLine("ZOMBIE APOCALYPS");
Thread.Sleep(2000);

Console.Clear();
Console.WriteLine("Du vaknar upp i en hög av bråte, yr och nyvaken.");
Thread.Sleep(1000);
Console.WriteLine("Med suddig blick ser du en helikopter en bit bort på ett tak med din kamrat som vinkar dit dig.");
Thread.Sleep(1000);
Console.WriteLine("Du måste ta dig dit på något sätt innan du blir uppäten av massorna av zombies som bara växer och växer.");
Thread.Sleep(1000);
Console.WriteLine("Du ser dig omkring, till vänster ser du ett fåtal zombies som inte verkar röra på sig.");
Thread.Sleep(1000);
Console.WriteLine("Åt höger ser du ett litet, rätt så säkert, skjul som ser mögligt och slitet ut.");
Thread.Sleep(1000);
Console.WriteLine("Åt vilket håll går du? Vänster(V) eller Höger(H)?");
Console.WriteLine("Svar:");

string choice = Console.ReadLine().ToLower();

if (choice == "v")
{
    Console.Clear();
    Console.WriteLine("Du bestämmer dig för att smyga igenom zombierna.");
    Thread.Sleep(1000);
    Console.WriteLine("Försiktigt börjar du gå med svettig panna och skagiga ben.");
    Thread.Sleep(1000);
    Console.WriteLine("Men när allting verkar gå som det ska, råkar du kliva på en liten pinne som bryts på mitten.");
    Thread.Sleep(1000);
    Console.WriteLine("Ditt hjärta stannar och alla zombies vänder sig blixtsnabbt om och stirrar på dig.");
    Thread.Sleep(1000);
    Console.WriteLine("Då märker du att de alla verkar vara blinda.");
    Thread.Sleep(1000);
    Console.WriteLine("Du ser dig omkring, rakt fram verkar det finnas en dörr som leder in till huset med helikoptern på.");
    Thread.Sleep(1000);
    Console.WriteLine("Antingen kan du plocka upp en sten och kasta iväg den för att lura bort dem.");
    Thread.Sleep(1000);
    Console.WriteLine("Eller kan du kuta allt vad du har för att komma fram till dörren.");
    Thread.Sleep(1000);
    Console.WriteLine("Vad gör du? Kastar en sten(KA)? eller Kutar(KU)?");
    Console.WriteLine("Svar:");

    string choice2 = Console.ReadLine().ToLower();

    if (choice2 == "ka")
    {
        Console.Clear();
        Console.WriteLine("Du plockar försiktigt upp en sten från marken och kastar iväg den åt sidan.");
        Thread.Sleep(1000);
        Console.WriteLine("Den landar med en duns och alla zombies rusar år det hållet.");
        Thread.Sleep(1000);
        Console.WriteLine("Då fortsätter du framåt med försiktiga steg tills du tillslut kommer fram till dörren.");
        Thread.Sleep(1000);
        Console.WriteLine("Försiktigt utan att göra för mycket ljud öppnar du den väldigt tröga dörren och smäller igen den efter dig.");
        Thread.Sleep(1000);
        Console.WriteLine("Nu rusar du upp för trapporna som tillslut leder till en öppning till taket där din kamrat står med helikoptern.");
        Thread.Sleep(1000);
        Console.WriteLine("Du klaradet det! Bra jobbat! Nu kan du åka iväg säkert utan att de där liken följer efter.");
        Thread.Sleep(1000);
        Console.WriteLine("*DU ÖVERLEVDE!*");
    }
    else if (choice2 == "ku")
    {
        Console.Clear();
        Console.WriteLine("Dina instinkter får dig tillslut att kuta allt vad du har till dörren några meter fram.");
        Thread.Sleep(1000);
        Console.WriteLine("Men nu när zombierna hör dig klart och tydligt, springer de efter dig.");
        Thread.Sleep(1000);
        Console.WriteLine("Du kom tillslut fram till dörren och märker att den var trögare att öppna än vad du först trott.");
        Thread.Sleep(1000);
        Console.WriteLine("Med all styrka du har i kroppen försöker du öppna dörren så fort du kan.");
        Thread.Sleep(1000);
        Console.WriteLine("Men bara efter några sekunder känner du hur ett par tänder tränger sig djupt in i ditt skin.");
        Thread.Sleep(1000);
        Console.WriteLine("Du dör en långsam och plågsam död utan någon som kan rädda dig.");
        Thread.Sleep(1000);
        Console.WriteLine("*DU DOG!*");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Zombiemassorna växer snabbare och snabbare men du verkar inte vilja göra någonting.");
        Thread.Sleep(1000);
        Console.WriteLine("Du bara står där utan att verka ha ett hopp för livet, som om din kropp fått kortslutning.");
        Thread.Sleep(1000);
        Console.WriteLine("Nu är det försent och högarna av levande lik börjar svärma in.");
        Thread.Sleep(1000);
        Console.WriteLine("Du blir nu uppäten levande och det blev ett lyckligt slut för zombierna.");
        Thread.Sleep(1000);
        Console.WriteLine("*DU DOG!*");
    }
}
else if (choice == "h")
{
    Console.Clear();
    Console.WriteLine("Du går in i skjulet med raska steg.");
    Thread.Sleep(1000);
    Console.WriteLine("Det luktar vidrigt, men ändå verkar det rätt säkert.");
    Thread.Sleep(1000);
    Console.WriteLine("Men för att ta dig till taket med helikoptern på måste du gå ut igenom dörren rakt fram.");
    Thread.Sleep(1000);
    Console.WriteLine("Innan du hinner tänka hör du flera zombies som rusar mot skjulet.");
    Thread.Sleep(1000);
    Console.WriteLine("De måste ha kännt stanken från det gamla sjulet som du tyvärr befinner dig i.");
    Thread.Sleep(1000);
    Console.WriteLine("En zombie kastar sig in i det öppna fönstret och snart är dem här inne.");
    Thread.Sleep(1000);
    Console.WriteLine("Du kan antingen ta upp en järnstång som ligger på marken för att skydda dig själv");
    Thread.Sleep(1000);
    Console.WriteLine("Eller kan du springa ut igenom dörren för att försöka komma upp på taket du ska till.");
    Thread.Sleep(1000);
    Console.WriteLine("Vad gör du? Slåss för ditt liv(SL) eller Springa ut ur dörren(SP)?");
    Console.WriteLine("Svar:");

    string choice2 = Console.ReadLine().ToLower();

    if (choice2 == "sl")
    {
        Console.Clear();
        Console.WriteLine("Du plockar upp den råstiga järnstången som låg på marken och förbereder dig för att sloss.");
        Thread.Sleep(1000);
        Console.WriteLine("Det första zombien snubblar in i skjulet och utan en andra tanke spetsar du den i huvudet innan det hinner ställa sig upp.");
        Thread.Sleep(1000);
        Console.WriteLine("Men det kommer in flera zombies än vad du hade trott.");
        Thread.Sleep(1000);
        Console.WriteLine("En av dem fick nästan tag på dig men du knuffade iväg dem.");
        Thread.Sleep(1000);
        Console.WriteLine("Det blir tuffare och tuffare att behålla kontrollen i skjulet och tillslut blir det överväldigt.");
        Thread.Sleep(1000);
        Console.WriteLine("Det trånga utrymmet samt de många zombies som kommer in, en efter en, blir aldelles för svårt att slåss mot.");
        Thread.Sleep(1000);
        Console.WriteLine("Tillslut får de tag på dig och börjar äta dig levande.");
        Thread.Sleep(1000);
        Console.WriteLine("*DU DOG!*");
    }
    else if (choice2 == "sp")
    {
        Console.Clear();
        Console.WriteLine("Du springer ut från skjulet så fort du kan i förhoppning om att det finns en väg upp till taket.");
        Thread.Sleep(1000);
        Console.WriteLine("Men allt du ser är en betongvägg med två stängselnät med taggtråd längst upp.");
        Thread.Sleep(1000);
        Console.WriteLine("Det finns ingen väg upp till taket.");
        Thread.Sleep(1000);
        Console.WriteLine("Som en sista plan bestämmer du dig att försöka fly över stängslet som leder ut.");
        Thread.Sleep(1000);
        Console.WriteLine("När du börjar klättra hör du redan hur flera zombies rusar mot dig.");
        Thread.Sleep(1000);
        Console.WriteLine("Du försöker klättra snabbare men fastnar tillslut i taggtråden som gör hemskt ont.");
        Thread.Sleep(1000);
        Console.WriteLine("Men medan du försöker ta dig loss, så börjar zombies klättra upp på andra sidan av stängslet.");
        Thread.Sleep(1000);
        Console.WriteLine("Utan något att göra får du stanna där och vänta på ditt öde.");
        Thread.Sleep(1000);
        Console.WriteLine("*DU DOG!*");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Zombiemassorna växer snabbare och snabbare men du verkar inte vilja göra någonting.");
        Thread.Sleep(1000);
        Console.WriteLine("Du bara står där utan att verka ha ett hopp för livet, som om din kropp fått kortslutning.");
        Thread.Sleep(1000);
        Console.WriteLine("Nu är det försent och högarna av levande lik börjar svärma in.");
        Thread.Sleep(1000);
        Console.WriteLine("Du blir nu uppäten levande och det blev ett lyckligt slut för zombierna.");
        Thread.Sleep(1000);
        Console.WriteLine("*DU DOG!*");
    }

}
else
{
    Console.Clear();
    Console.WriteLine("Zombiemassorna växer snabbare och snabbare men du verkar inte vilja göra någonting.");
    Thread.Sleep(1000);
    Console.WriteLine("Du bara står där utan att verka ha ett hopp för livet, som om din kropp fått kortslutning.");
    Thread.Sleep(1000);
    Console.WriteLine("Nu är det försent och högarna av levande lik börjar svärma in.");
    Thread.Sleep(1000);
    Console.WriteLine("Du blir nu uppäten levande och det blev ett lyckligt slut för zombierna.");
    Thread.Sleep(1000);
    Console.WriteLine("*DU DOG!*");
}

Console.ReadLine();