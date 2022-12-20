using System;
using System.Collections.Generic;
using System.IO;
using DRV3_Sharp_Library.Formats.Archive.SPC;

namespace DRV3_Sharp.Menus;

internal sealed class SpcMenu : IMenu
{
    private List<(string name, SpcData data)> loadedData = new();
    //private bool unsavedChanges = false;

    public MenuEntry[] AvailableEntries
    {
        get
        {
            List<MenuEntry> entries = new()
            {
                // Add always-available entries
                new("Load", "Load an SPC file, or whole folder of SPC files.", Load),
                new("Help", "View descriptions of currently-available operations.", Help),
                new("Back", "Return to the previous menu.", Program.PopMenu)
            };
            
            // Add context-sensitive entries, if applicable
            if (loadedData.Count > 0)
            {
                entries.Insert(1, new("Save", "Save the currently-loaded SPC file(s).", Save));
                entries.Insert(2, new("List Files", "List the contents of the currently-loaded SPC file(s).", ListFiles));
                entries.Insert(3, new("Extract File(s)", "Extract one or more files from the currently-loaded SPC file(s).", ExtractFiles));
                
                // Add multi-file operations if we have more than one loaded at once
                if (loadedData.Count > 1)
                {
                    
                }
            }

            return entries.ToArray();
        }
    }
    
    public int FocusedEntry { get; set; }

    private void Load()
    {
        var paths = Utils.ParsePathsFromConsole("Type the files/directories you wish to load, or drag-and-drop them onto this window, separated by spaces and/or quotes: ", true, true);

        if (paths is null) return;
        
        // TODO: Check with the user if there are existing loaded files before clearing the list
        loadedData.Clear();

        foreach (var info in paths)
        {
            // If the path is a directory, load all SPC files within it
            if (info is DirectoryInfo directoryInfo)
            {
                var contents = directoryInfo.GetFiles("*.spc");

                foreach (var file in contents)
                {
                    using FileStream fs = new(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    SpcSerializer.Deserialize(fs, out SpcData data);
                    loadedData.Add((file.FullName, data));
                }
            }
            else if (info is FileInfo)
            {
                using FileStream fs = new(info.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
                SpcSerializer.Deserialize(fs, out SpcData data);
                loadedData.Add((info.FullName, data));
            }
        }
        
        Console.WriteLine($"Loaded {loadedData.Count} SPC file(s). Press ENTER to continue...");
        Console.ReadLine();
    }

    private void Save()
    {
        
    }

    private void ListFiles()
    {
        Console.Clear();
        foreach (var (name, data) in loadedData)
        {
            Console.WriteLine($"{name}:");
            foreach (var file in data.Files)
            {
                Console.WriteLine($"\t{file}");
            }
        }
        Console.ReadLine();
    }

    private void ExtractFiles()
    {
        foreach (var (name, data) in loadedData)
        {
            foreach (var file in data.Files)
            {
                string outputDir = name.Remove(name.Length - (".SPC".Length));
                
                // Create output directory if it does not exist
                Directory.CreateDirectory(outputDir);
                using BinaryWriter writer = new(new FileStream(Path.Combine(outputDir, file.Name), FileMode.Create, FileAccess.ReadWrite, FileShare.Read));

                byte[] fileContents = file.Data;
                if (file.IsCompressed)
                {
                    fileContents = SpcCompressor.Decompress(fileContents);
                }
            
                writer.Write(fileContents);
                writer.Close();
            }
        }
    }

    private void Help()
    {
        Utils.PrintMenuDescriptions(AvailableEntries);
    }
}