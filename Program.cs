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

        // Step 3: Basic user controls
        // Start position (top-left corner)
        int cursorTop = 1;
        int cursorLeft = 1;
        Console.SetCursorPosition(cursorLeft, cursorTop);

        ConsoleKey key;
        bool running = true;
 do
        {
            key = Console.ReadKey(true).Key;

            int proposedTop = cursorTop;
            int proposedLeft = cursorLeft;

            // Process key input
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    proposedTop--;
                    break;
                case ConsoleKey.DownArrow:
                    proposedTop++;
                    break;
                case ConsoleKey.LeftArrow:
                    proposedLeft--;
                    break;
                case ConsoleKey.RightArrow:
                    proposedLeft++;
                    break;
                case ConsoleKey.Escape:
                    running = false;
                    break;
            }
             // Step 4: Try moving
            TryMove(proposedTop, proposedLeft, mazeRows, ref cursorTop, ref cursorLeft);

            // Step 5: Check for win condition
            if (mazeRows[cursorTop][cursorLeft] == '*')
            {
                Console.Clear();
                Console.WriteLine(" yay you won! ");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
                break;
            }

           
        } while (running);


    // Step 4: TryMove method
    static void TryMove(int proposedTop, int proposedLeft, string[] mazeRows, ref int cursorTop, ref int cursorLeft)
{
    // Check bounds
    if (proposedTop < 0 || proposedTop >= mazeRows.Length)
        return;

    if (proposedLeft < 0 || proposedLeft >= mazeRows[proposedTop].Length)
        return;

    // Check for walls
    if (mazeRows[proposedTop][proposedLeft] == '#')
        return;

    // If valid move
    cursorTop = proposedTop;
    cursorLeft = proposedLeft;
    Console.SetCursorPosition(cursorLeft, cursorTop);
}
           