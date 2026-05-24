using System.ComponentModel.Design;
using Core;

//var texFile = new SimpleTextFile("D:\\Documentos\\ITM\\Cuarto Semestre\\ESTRUCTURA DE DATOS Y LABORATORIO\\Unidad 4\\tmp\\data.txt");
//using var logger = new LogWriter("D:\\Documentos\\ITM\\Cuarto Semestre\\ESTRUCTURA DE DATOS Y LABORATORIO\\Unidad 4\\tmp\\log.txt");
//try
//{
//    logger.WriteLog("INFO", "Application started.");

//    var lines = texFile.ReadLines();
//    var list = lines.ToList();
//    var option = string.Empty;

//    do
//    {
//        option = Menu();
//        switch (option)
//        {
//            case "1":
//                Console.WriteLine("Shoe lines:");
//                foreach (var item in list)
//                {
//                    Console.WriteLine(item);
//                }
//                logger.WriteLog("INFO", "Displayed lines to the user.");
//                break;

//            case "2":
//                Console.Write("Enter a new line: ");
//                var newLine = Console.ReadLine();
//                list.Add(newLine!);
//                logger.WriteLog("INFO", $"Added a new line to the list. {newLine}");
//                break;

//            case "3":
//                texFile.WriteAllLines(list.ToArray());
//                Console.WriteLine("Changes saved.");
//                logger.WriteLog("INFO", "Saved changes to the file.");
//                break;

//            case "4":
//                Console.Write("Enter the line to remove: ");
//                var lineToRemove = Console.ReadLine();
//                if (list.Remove(lineToRemove!))
//                {
//                    Console.WriteLine("Line removed.");
//                    logger.WriteLog("INFO", $"Removed a line from the list. {lineToRemove}");
//                }
//                else
//                {
//                    Console.WriteLine("Line not found.");
//                    logger.WriteLog("WARNING", $"Attempted to remove a line that was not found. {lineToRemove}");
//                }
//                break;

//            case "5":
//                Console.Write("Enter the word to remove:");
//                var wordToRemove = Console.ReadLine();
//                for (int i = list.Count - 1; i >= 0; i--)
//                {
//                    if (list[i].Contains(wordToRemove!))
//                    {
//                        list.RemoveAt(i);
//                    }
//                }
//                logger.WriteLog("INFO", $"Removed all lines containing the word: {wordToRemove}");
//                break;                

//            case "6":
//                list.Sort();
//                Console.WriteLine("Lines sorted.");
//                logger.WriteLog("INFO", "Sorted the lines in the list.");
//                break;
                
//            case "0":
//                Console.WriteLine("Exiting...");
//                logger.WriteLog("INFO", "User chose to exit the application.");
//                break;

//            default:
//                Console.WriteLine("Invalid option. Please try again.");
//                logger.WriteLog("WARNING", $"User entered an invalid option: {option}");
//                break;
                
//        }
//    } while (option != "0");
//    texFile.WriteAllLines(list.ToArray());
//    Console.WriteLine("Changes saved.");
//    logger.WriteLog("INFO", "Application exited.");
//}
//catch (Exception ex)
//{
//    logger.WriteLog("ERROR", $"An error occurred: {ex.Message}");
//    Console.WriteLine("An error occurred. Please check the log for details.");
//}
//finally
//{
//    logger.WriteLog("INFO", "Application ended.");
//}


//string Menu()
//{
//    Console.WriteLine("Menu:");
//    Console.WriteLine("1. Shoe lines");
//    Console.WriteLine("2. Add line ");
//    Console.WriteLine("3. Save changes");
//    Console.WriteLine("4. Remove one ocurrence");
//    Console.WriteLine("5. Remove all ocurrences");
//    Console.WriteLine("6. Sort lines");
//    Console.WriteLine("0. Exit");
//    Console.Write("Choose an option: ");
//    return Console.ReadLine() ?? string.Empty;
//}

//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}


var people = new List<string[]>
{
    new[] { "ID", "Name", "Age"},
    new[] { "1", "Alice", "30"},
    new[] { "2", "Bob", "25"},
    new[] { "3", "Charlie", "35"},
    new[] { "4", "Diego", "34"},
};

var manualCsvHelper = new ManualCsvHelper();
manualCsvHelper.WriteCsv("D:\\Documentos\\ITM\\Cuarto Semestre\\ESTRUCTURA DE DATOS Y LABORATORIO\\Unidad 4\\tmp\\people.csv", people);

var loadedPeople = manualCsvHelper.ReadCsv("D:\\Documentos\\ITM\\Cuarto Semestre\\ESTRUCTURA DE DATOS Y LABORATORIO\\Unidad 4\\tmp\\people.csv");

foreach (var person in loadedPeople)
{
    Console.WriteLine(string.Join("|", person));
}