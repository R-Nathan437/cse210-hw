using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Video v1 = new Video("title1", "120", "author1");
        Video v2 = new Video("title2", "10", "author2");
        v1.addComment("author1", "text1");
        v2.addComment("author1", "text1");
        v2.addComment("author2", "text2");

        _videos.Add(v1);
        _videos.Add(v2);
        foreach (Video video in _videos)
        {
            video.Display();
        }

    }
}