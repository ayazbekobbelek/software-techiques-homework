class Program
{

    static void Main(string[] args)
    {
        // This is the list that stores the song objects
        List<Song> songs = new List<Song>();

        // Reading the file, adding items to the songs list
        StreamReader sr = null;
        try
        {
            // The @ char turns off escaping in strings.
            //No need to write ‘\\’ instead of ‘\’.
            sr = new StreamReader(@"C:/temp/music.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                // The line local variable contains a whole line
                // Split the line at ‘;’ chars
                string[] lineItems = line.Split(';');

                // If the line was empty
                if (lineItems.Length == 0)
                    continue;

                // The first item should hold the name of the artist
                // Trim removes all leading and ending whitespaces
                string artist = lineItems[0].Trim();

                // Iterate through the songs and add each to the list
                for (int i = 1; i < lineItems.Length; i++)
                {
                    Song song = new Song(artist, lineItems[i].Trim());
                    songs.Add(song);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error during processing the file.");
            // E.Message contains only the textual message of the exception. 
            // Call e.ToString() if you want to print all information (e.g. stack trace) about the exception.

            Console.WriteLine(e.Message);
        }
        finally
        {
            // It is important to place the file closing in the finally block 
            // to prevent leaving unclosed files behind even in case of exceptions.

            // Instead of the try-finally block we could also use a using block (will be discussed later)

            if (sr != null)
                sr.Close();
        }

        // Write each item of the songs list to the console
        foreach (Song song in songs)
            Console.WriteLine(song.ToString());
    }
}