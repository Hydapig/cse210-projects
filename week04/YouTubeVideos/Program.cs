using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("How to buid a PC", "PC Builders", 730);
        Video vid2 = new Video("How to Play Satisfactory", "Hydapig", 927);
        Video vid3 = new Video("Coming Closer to Christ", "Church of Jesus Christ of Latter-day Saints", 450);

        vid1.AddComments(new Comment("ILovePickles", "Great build!"));
        vid1.AddComments(new Comment("PCwannabe", "Looks complicated. Can you just build it for me?"));
        vid1.AddComments(new Comment("JimJam004", "Thanks for the tutorial"));

        vid2.AddComments(new Comment("FactoryBuilder21", "I love this game!"));
        vid2.AddComments(new Comment("user-1234", "How did you build that?"));
        vid2.AddComments(new Comment("onepunch0", "You need to add more color to your factories"));
        vid2.AddComments(new Comment("Hydapig", "Thanks for the commentary!"));

        vid3.AddComments(new Comment("user-0924", "I really needed this."));
        vid3.AddComments(new Comment("user-1234", "Thank you for helping me feel the spirit."));
        vid3.AddComments(new Comment("JimJam004", "I can't wait to share this with my friend"));

        List<Video> vids = new List<Video> {vid1,vid2,vid3};
        foreach (var vid in vids)
        {
            vid.DisplayVideoInfo();
            Console.WriteLine("");
        }
    }
}