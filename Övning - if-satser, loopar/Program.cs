// Skapa en if-sats som skriver ut "Hello, World!" ifall 6 är större än eller lika med 3.
// if (6 >= 3)
// {
//     Console.WriteLine("Hello World!");
// }
// Console.ReadLine();


// Skapa en kod som först hämtar in ett användarnamn från användaren via Console.ReadLine. Gör sedan en if-sats som skriver ut "Welcome!" Ifall användarnamnet är lika med "noname".
// Console.WriteLine("Skriv in ditt namn.");
// string name = Console.ReadLine();
// if (name != "noname")
// {
// Console.WriteLine($"Hej {name}!");
// }

// if (name == "noname")
// {
//     Console.WriteLine("Välkommen!");
// }
// Console.ReadLine();


// Komplettera föregående kod så att både användarnamn och lösenord efterfrågas. "Welcome" ska skrivas ut enbart om användarnamnet är lika med "noname" och lösenordet är "nopass". Om någon av dem inte stämmer så ska koden skriva ut "Wrong username or password".
// Console.WriteLine("Skriv in användarnamn och lösenord.");
// string name = Console.ReadLine();
// string pass = Console.ReadLine();
// if (name == "noname")
// {
//     if (pass == "nopass")
//     {
//         Console.WriteLine("Welcome!");
//     }
//     else 
//     {
//         Console.WriteLine("Fel användarnamn eller lösenord!");
//     }

// }
// else 
// {
//     Console.WriteLine("Fel användarnamn eller lösenord!");
// }



// Skriv en loop som skriver ut "Hello, World" 32 gånger. Välj själv om det ska vara en for-loop eller en while-loop.
// int hello = 0;
// for (hello = 0; hello <= 32; hello++)
// {
//     Console.WriteLine("Hello World!");

// }



// Skriv en loop som fortsätter så länge användaren inte har skrivit in rätt lösenord. Du måste alltså lägga in din Console.ReadLine inuti en while-loop.
// System.Console.WriteLine("Skriv in lösenord!");
// string pass = Console.ReadLine();
// int wrongPass = 0;
// while (pass != "nopass")
// {
//     Console.WriteLine("Fel!");
//     pass = Console.ReadLine();
//     if (pass == "nopass")
//     {
//         System.Console.WriteLine("Välkommen!");
//     }
// }
// if (pass == "nopass")
// {
    
// }


// Skriv en loop som körs 5 gånger. Varje gång loopen körs ska användaren skriva in ett tal. Om talet är högre än 5, skriv ut “högre än 5!”. Observera att du måste konvertera talet från en string till en int för att kunna göra jämförelsen.
// Console.WriteLine("Skriv ett nummer.");
// int loopCount = 0;
// for (loopCount = 0; loopCount < 4;)
// {
//     string number = Console.ReadLine();
//     int intNumber = Int32.Parse(number);
//     loopCount += 1;
    
//     if (intNumber > 5)
//     {
//         Console.WriteLine("Högre än 5!");
//     }
    
// }

Console.ReadLine();