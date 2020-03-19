using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    public static class FileApp
    {
        public static void Run()
        {
            bool isAppRunning = true; 
            while (isAppRunning)
            {
                var userOption = GetUserOption();

                switch (userOption)
                {
                    case UserOptions.Add:
                        HandleAdd();
                        break;
                    case UserOptions.Delete:
                        HandleDelete();
                        break;
                    case UserOptions.Append:
                        HandleAddingFileContent(true);
                        break;
                    case UserOptions.OverWrite:
                        HandleAddingFileContent(false);
                        break;
                    default: 
                        Console.WriteLine("lol");
                        break;
                }

                isAppRunning = GetUserYesNoInput("would you like to do more file IO things?");

            }
        }

        private static void HandleAddingFileContent(bool append)
        {
            string fileName = GetFileName();

            Console.WriteLine("What are we adding to this file?");

            var userInputs = new List<string>();

            bool isAddingLines = true;
            while (isAddingLines)
            {
                Console.WriteLine("what do you want to enter to the file? (we will add something line by line)");
                userInputs.Add(Console.ReadLine());
                isAddingLines = GetUserYesNoInput("Do you want to add more stuff? [yes / no]");
            }

            FileUtility.ModifyExistingFile(fileName, userInputs, append);

            Console.WriteLine($"Files added to {fileName}");

        }

        private static bool GetUserYesNoInput(string message)
        {
            Console.WriteLine(message);
            var userDecision = Console.ReadLine();

            if (userDecision.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return true;
        }

        private static void HandleAppendToFile()
        {
            throw new NotImplementedException();
        }

        private static void HandleDelete()
        {
            string fileName = GetFileName();

            FileUtility.DeleteFile(fileName);

            Console.WriteLine($"File Deleted: {fileName}");
        }

        private static void HandleAdd()
        {
            string fileName = GetFileName();

            FileUtility.CreateFile(fileName);

            Console.WriteLine($"File created: {fileName}");
        }

        private static string GetFileName()
        {
            Console.WriteLine("what is your file name?");
            var fileName = Console.ReadLine();
            return fileName;
        }

        private static UserOptions GetUserOption()
        {
            bool invalidInput = true;

            UserOptions userOption = UserOptions.Add;
            while (invalidInput)
            {
                PrintMenu();
                string userInput = Console.ReadLine();

                if (Enum.TryParse<UserOptions>(userInput, out userOption) && Enum.IsDefined(typeof(UserOptions), userOption))
                {
                    invalidInput = false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            return userOption;
        }

        public static void PrintMenu()
        {
            Console.WriteLine("what do you want to do with this file app my dude? (choose 1 - 4)");
            Console.WriteLine("[1]. Add File");
            Console.WriteLine("[2]. Delete File");
            Console.WriteLine("[3]. Append to a file");
            Console.WriteLine("[4]. Overwrite a file");
        }
    }
}
