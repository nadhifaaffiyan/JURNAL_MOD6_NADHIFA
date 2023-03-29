using System;

public class SayaTubeVideo
{
        public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;
    }
    public SayaTubeVideo(string a)
    {
        Random random = new Random();
        this.id = random.Next(1, 99999)

        this.playcount;
 = 0;
    }
    void increasePlayCount(int playcount)
    {
        this.playcount = playcount;
        playcount = playcount + 1;

    }

    void GetPlayCount()
    {
        return playcount;
    }
    void PrintVideodetails()
    {
        Console.WriteLine("ID" + this.id);
        Console.WriteLine("Title" + this.Title);
        Console.WriteLine("Play Count" + playcount);

    }
}
