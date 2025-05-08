using System;
using System.Collections;
using System.Collections.Generic;

class MusicCatalog
{
    private Hashtable catalog = new Hashtable();

    public void AddAlbum(string albumName)
    {
        if (!catalog.ContainsKey(albumName))
        {
            catalog[albumName] = new List<string>();
            Console.WriteLine($"Диск '{albumName}' добавлен.");
        }
        else
        {
            Console.WriteLine($"Диск '{albumName}' уже существует!");
        }
    }

    public void RemoveAlbum(string albumName)
    {
        if (catalog.ContainsKey(albumName))
        {
            catalog.Remove(albumName);
            Console.WriteLine($"Диск '{albumName}' удалён.");
        }
        else
        {
            Console.WriteLine($"Диск '{albumName}' не найден!");
        }
    }

    public void AddSong(string albumName, string songName)
    {
        if (catalog.ContainsKey(albumName))
        {
            List<string> songs = (List<string>)catalog[albumName];
            songs.Add(songName);
            Console.WriteLine($"Песня '{songName}' добавлена на диск '{albumName}'.");
        }
        else
        {
            Console.WriteLine($"Диск '{albumName}' не найден!");
        }
    }

    public void RemoveSong(string albumName, string songName)
    {
        if (catalog.ContainsKey(albumName))
        {
            List<string> songs = (List<string>)catalog[albumName];
            if (songs.Remove(songName))
            {
                Console.WriteLine($"Песня '{songName}' удалена с диска '{albumName}'.");
            }
            else
            {
                Console.WriteLine($"Песня '{songName}' не найдена на диске '{albumName}'!");
            }
        }
        else
        {
            Console.WriteLine($"Диск '{albumName}' не найден!");
        }
    }

    public void ViewAlbum(string albumName)
    {
        if (catalog.ContainsKey(albumName))
        {
            List<string> songs = (List<string>)catalog[albumName];
            Console.WriteLine($"Диск '{albumName}' содержит следующие песни:");
            foreach (var song in songs)
            {
                Console.WriteLine($"- {song}");
            }
        }
        else
        {
            Console.WriteLine($"Диск '{albumName}' не найден!");
        }
    }

    public void ViewCatalog()
    {
        Console.WriteLine("\nКаталог музыкальных дисков:");
        foreach (DictionaryEntry entry in catalog)
        {
            Console.WriteLine($" {entry.Key}");
        }
    }
}

class Program
{
    static void Main()
    {
        MusicCatalog catalog = new MusicCatalog();

        catalog.AddAlbum("Rock Hits");
        catalog.AddSong("Rock Hits", "AC/DC");
        catalog.AddSong("Rock Hits", "Rolling");

        catalog.AddAlbum("Pop Classics");
        catalog.AddSong("Pop Classics", "Thriller");
        catalog.AddSong("Pop Classics", "Prayer");

        catalog.ViewAlbum("Rock Hits");
        catalog.ViewCatalog();

        catalog.RemoveSong("Rock Hits", "Storm");
        catalog.RemoveAlbum("Pop Classics");

        catalog.ViewCatalog();
    }
}
