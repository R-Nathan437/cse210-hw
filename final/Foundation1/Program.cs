using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Video v1 = new Video("title", "120", "author");
        v1.addComment("author", "text");
        _videos.Add(v1);
        foreach (Video video in _videos)
        {
            video.Display();
        }

    }
}