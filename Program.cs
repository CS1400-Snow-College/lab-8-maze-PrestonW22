//preston waters, maze, 10/25/25
Console.Title = "Maze Game";

        // Step 1: Display intro
        Console.WriteLine("Welcome to the Maze Game!");
        Console.WriteLine("Use the arrow keys to move. Find the '*' to win.");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey(true);

        // Step 2: Load the maze from the file
        string[] mazeRows = File.ReadAllLines("map.txt");

        // Clear screen and print maze
        Console.Clear();
        foreach (string row in mazeRows)
        {
            Console.WriteLine(row);
        }

       