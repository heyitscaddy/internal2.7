
using System;

namespace Nutrient_Internal
{
    public ReadFromFile()
{
    static void Main()
    {
        // The files used in this example are created in the topic
        // How to: Write to a Text File. You can change the path and
        // file name to substitute text files of your own.

        // Example #1
        // Read the file as one string.
        string text = System.IO.File.ReadAllText(@"C:\Users\m.a.caddle\Desktop\Nutrient Internal\Nutrientfile.txt\");

        // Display the file contents to the console. Variable text is a string.
        System.Console.WriteLine("Contents of Nutrientfile.txt = {0}", text);
    }