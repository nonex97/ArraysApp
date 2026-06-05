

//string[] firstNames = new string[5];

//firstNames[0] = "Neven";
//firstNames[1] = "Tim";
//firstNames[2] = "Bob";
//// we don't need to have data in all positions, but it's better to do that
//firstNames[4] = "Jane";

//Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}.");

//firstNames[0] = "Johhny";

//Console.WriteLine(firstNames[0]);

////firstNames[5] = "Robert"; // this will not work since it's out of range of the array

//// If we really need to expand the array, we would need to make a new array with the desired size, then copy the old array to the new (not ideal)

// single quote identifies a single character (a bit more efficient)
// double quote identifies a string

string data = "Tim,Sue,Bob,Jane,Frank";
string[] firstNames = data.Split(',');

Console.WriteLine(firstNames[1]);

Console.WriteLine(firstNames.Length);

Console.WriteLine(firstNames[firstNames.Length - 1]); // this will give us the last name in the array

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] { 20, 34, 41 };