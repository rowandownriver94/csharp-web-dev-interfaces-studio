using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DVD miniSeries = new DVD("Over the Garden Wall", 110, "animated mini series", "DVD", true, "How the gentle wind beckons through the leaves as autumn colors fall...");
            CD blueOysterCult = new CD("Blue Oyster Cult", 39, "Fire of Unknown Origin", "Audio CD", true, 2, "Burnin' For You", "Home in the valley, home in the city, home isn't pretty, ain't no home for me...");

            miniSeries.SpinDisc();
            blueOysterCult.SpinDisc();
        }
    }
}
