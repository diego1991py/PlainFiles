using System.ComponentModel.Design;
using Core;

var texFile = new SimpleTextFile("D:\\Documentos\\ITM\\Cuarto Semestre\\ESTRUCTURA DE DATOS Y LABORATORIO\\Unidad 4\\tmp\\data.txt");
var lines = texFile.ReadLines();
var list = lines.ToList();
var option = string.Empty;

do
{
  option = Menu();
  switch (option)
    {
        case "1":
            Console.WriteLine("Shoe lines:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            break;

        case "2":
            Console.Write("Enter a new line: ");
            var newLine = Console.ReadLine();
            list.Add(newLine!);
            break;

        case "3":
            texFile.WriteAllLines(list.ToArray());
            Console.WriteLine("Changes saved.");
            break;

        case "4":
            Console.Write("Enter the line to remove: ");
            var lineToRemove = Console.ReadLine();
            if (list.Remove(lineToRemove!))
            {
                Console.WriteLine("Line removed.");
            }
            else
            {
                Console.WriteLine("Line not found.");
            }
            break;

        case "5":
            Console.Write("Enter the word to remove:");
            var wordToRemove = Console.ReadLine();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].Contains(wordToRemove!))
                {
                    list.RemoveAt(i);
                }
            }
            break;

        case "6":
            list.Sort();
            Console.WriteLine("Lines sorted.");
            break;
        case "0":
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
} while (option != "0");
texFile.WriteAllLines(list.ToArray());
Console.WriteLine("Changes saved.");


string Menu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Shoe lines");
    Console.WriteLine("2. Add line ");
    Console.WriteLine("3. Save changes");
    Console.WriteLine("4. Remove one ocurrence");
    Console.WriteLine("5. Remove all ocurrences");
    Console.WriteLine("6. Sort lines");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine() ?? string.Empty;
}

foreach (var line in lines)
{
    Console.WriteLine(line);
}