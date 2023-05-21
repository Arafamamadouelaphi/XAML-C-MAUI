using System;
using music.Model;
namespace music.Stub
{
	public class stubtwo
	{
        public List<Podcaste> podcastes { get; set; }
        public stubtwo()
		{
            podcastes = new List<Podcaste>
            {
                new Podcaste
                { Image = "kn.png",
                Title = "Speak no evil Ruby..",
                Description = "Wayne shorter"
                },
                 new Podcaste
            {
                Image = "album.png",
                Title = "Now what i means ? ",
                Description = "cannonball aberley"
            },
            new Podcaste
            {
                Image = "anbros.png",
                Title = "search",
                Description = "Description "
            },
            new Podcaste
            {
                Image = "anbros.png",
                Title = "Podcast 2",
                Description = "Description du podcast 2"
            },
             new Podcaste
            {
                Image = "kn.png",
                Title = "Podcast 1",
                Description = "Description du podcast 1"
            },
            new Podcaste
            {
                Image = "album.png",
                Title = "Podcast 2",
                Description = "Description du podcast 2"
            },
             
            new Podcaste
            {
                Image = "anbros.png",
                Title = "Podcast 2",
                Description = "Description du podcast 2"
            },
            };

        }
    }
}

