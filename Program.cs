List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano"),
    new Eruption("Zaira", 766, "Japan", 1117, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

IEnumerable<Eruption> fring = eruptions.Where(x => x.Location == "Chile");
PrintEach(fring, " eruption in Chile.");

IEnumerable<Eruption> hawaiian = eruptions.Where(x => x.Location == "Hawaiian Is");
if(hawaiian == null) {
    Console.WriteLine("no Hawaiian eruptions found.");
}
PrintEach(hawaiian, " eruption in Hawaii.");

// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
IEnumerable<Eruption> kiwi = eruptions.Where(z => z.Year > 1900 && z.Location == "New Zealand");
PrintEach(kiwi, " eruptions after 1900 AD in New Zealand.");

// Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> tallest = eruptions.Where(z => z.ElevationInMeters > 2000);
PrintEach(tallest, "eruptions taller than 2000m.");

// Find all eruptions where the volcano's name starts with "Z" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> zIndex = eruptions.Where(volc => volc.Volcano.StartsWith("Z"));
PrintEach(zIndex, "eruptions with a z");
int count = eruptions.Count(c => c.Location.StartsWith("Z"));
Console.WriteLine(count + "eruptions found starting with z");

// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max(o => o.ElevationInMeters);
Console.WriteLine(highestElevation);

// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
IEnumerable<Eruption> elevated = eruptions.Where(elev => elev.ElevationInMeters == highestElevation);
PrintEach(elevated, "this the tallest eruption!");

// Print all Volcano names alphabetically.
IEnumerable<Eruption> alphabetical = eruptions.OrderBy(p => p.Volcano);
PrintEach(alphabetical, "volcanos alphabetically");

// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> prehistory = eruptions.OrderBy(p => p.Volcano).Where(y => y.Year < 1000);
PrintEach(prehistory, "eruptions before 1000CE");

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
