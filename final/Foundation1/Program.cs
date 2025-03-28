using System;

class Program
{
    static void Main(string[] args)
    {

        Video catMeme = new Video("Rolling in yarn", "Grandma Pete", 57);
        catMeme.AddComment("Barbara Jenkins", "Awwww. Look at the little fuz ball sufficate in fuzz balls!");     
        catMeme.AddComment("Grandpa George", "Is that my lawn the cat's in? If I see you on my lawn one more time I'll shoot that cat!");  
        catMeme.AddComment("Unnecissary Advertiser", "Like cats? Buy my low quality yarn for no reason!"); 

        Video minecraft = new Video("The Zombies are Scary", "An Eight Year Old", 2717);
        minecraft.AddComment("Technoblade", "This kids trash. 17 views is too many.");     
        minecraft.AddComment("Markiplier", "Keep goin kid! You'll make it someday!");  
        minecraft.AddComment("Dream", "Want to see the zombie apocolypse add in action? Check it out: https://www.youtube.com/watch?v=itsfakelinktmp"); 
        minecraft.AddComment("SB737", "Your on day five. Good luck.");

        Video sillySong = new Video("Larry Sings a Silly Song", "Veggi Tales", 106);
        sillySong.AddComment("Manatee", "This is redicuolous. Absolutely offencive.");     
        sillySong.AddComment("Bob the Tomato", "Larry, you only published the first half of the video...");  
        sillySong.AddComment("Cutecomber", "Want a date? 💋💋💋 ❤️ ❤️ ❤️  🥒🥒🥒"); 

        List<Video> videos = new List<Video>{sillySong, catMeme, minecraft};

        Console.Clear();

        foreach (Video video in videos)
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" --------------");
            System.Console.WriteLine("|              |");
            System.Console.WriteLine("|      |>      |");
            System.Console.WriteLine("|              |");
            System.Console.WriteLine(" --------------");
            video.Display();
            System.Console.WriteLine($"Total Comments: {video.GetCommentCount()}");
            video.DisplayComments();
            System.Console.WriteLine();
        }
    }
}