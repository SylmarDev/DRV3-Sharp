# User's Manual for DRV3-Sharp

*TODO: Finish File Format Explanations, flesh out File Tree*

## Table of Contents
- [Getting Started](#getting-started)
  - [Editing Data](#editing-data)
- [File Formats](#file-formats)
  - [CPK](#cpk)
  - [SPC](#spc)
  - [SRD](#srd)
  - [STX](#stx)
  - [SFL](#sfl)
  - [WRD](#wrd)
- [File Tree](#file-tree)

## Getting Started
DRV3-Sharp is a command line tool that allows users to manipulate all of DRV3's data types, this manual can be used to understand the process top to bottom. The Editing Data section of this manaual (majority of it) is structured in order as though you were breaking down DRV3's files from the highest level.

The help function in DRV3-Sharp is always a good resource if you find yourself lost, it gives a simple overview of all the menu items.

### Editing Data
To start, navigate to your Danganronpa V3 installation. (PS4 and PS Vita installs are not supported) If you have it installed through Steam the path should be something like; 

``steam folder/steamapps/common/Danganronpa V3 Killing Harmony/data/win``

There you'll see three .CPK files. These are the outer layer archive format, and store all of the games data. The following breaks down what all they contain (see [file tree](#file-tree)). **I'd recommend backing these files up to avoid having to reinstall.**

I'd recommend to make a folder on its own, far from your DRV3 installation directory to play with and dig through DRV3's files, but  do what you like.

To extract these files, in DRV3-Sharp, navigate to Select File Type > CPK > Extract CPK. You'll be prompted to type a path or drag and drop them into your window.

Once you've given a path or dragged and dropped, *in the same directory as the file* DRV3-Sharp will unpack those files into their respective folders. From there you can start to view the files and see what you'd like.


## File Formats
### CPK
CPK files are the outer layer archive format, and store all the game data. All of the following file formats are sub-formats to CPK files.

### SPC
SPC files are the most common data archive format DRV3 uses.

To extract these files, choose SPC from the menu. DRV3-Sharp offers two methods to parse SPC files.

Quick Extract will simply move the files to a folder in the source file location.

Detailed Operations will allow you much more ability to access the SPC's contents, giving you the option to list files and view their sizes, adding new files, modfiying existing files and saving the updated spc archive.

### SRD
SRD Files contain images, 3D models, fonts, and lots of visual data.

To Load an SRD File select load and supply a path. DRV3-Sharp will parse it out and allow you to export textures (to PNGs/TGAs) and models from it.

### STX
STX Files...

### SFL
SFL Files are the primary animation and cutscene format. These are the least understood part of DRV3's data structure.

Currently the only operation that can be reliably performed on SFL files is SFL to JSON, which converts them to very large JSON objects.

### WRD
WRD Files...

---

## File Tree
This is the breakdown of files in the game's files, so if you're looking for something specific you can probably trace it through here. It should hopefully be a good resource if you're new to V3's file structure. Files that can't be parsed or .sfl's will be ignored for brevity's sake. Where there are different localiztaions of SRD files, the US localization's files will be listed.

- partition_data_win.cpk
  - flash
  - minigame
  - model
  - movie
  - prog_world
  - screen_effect
  - wrd_data
  - wrd_script
- partition_data_win_us.cpk
  - flash
  - minigame
  - model
  - movie
  - prog_world
  - trial_font
  - wrd_data
  - wrd_script
- partition_resident_win.cpk
  - boot
      - movie_logo.mp4, the Spike Chunsoft intro video file.
      - startup.spc
        - caution_download_US.srd contains the texture for the copyright warning at the beginning of the game
        - caution_gro_US.srd contains the "Any resemblance is purely coincidental" and "discretion advised" pop up
        - criwave.srd contains a .tga file of the Criware opening credit
        - nisa.srd contains a .tga file of the NIS America opening credit
  - game_resident
  - sound