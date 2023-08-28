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
DRV3-Sharp is a command line tool that allows users to manipulate all of DRV3's data types, this manual can be used to understand the process top to bottom. The Editing Data section of this manual (majority of it) is structured in order as though you were breaking down DRV3's files from the highest level.

The help function in DRV3-Sharp is always a good resource if you find yourself lost, it gives a simple overview of all the menu items.

### Editing Data
To start, navigate to your Danganronpa V3 installation. (PS4 and PS Vita installs are not supported) If you have it installed through Steam the path should be something like; 

``steam folder/steamapps/common/Danganronpa V3 Killing Harmony/data/win``

There you'll see three .CPK files. These are the outer layer archive format, and store all of the games data. The [file tree](#file-tree) breaks down what all they contain, if you're looking for something specific. **I'd recommend backing up these files up to avoid having to reinstall.**

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
This is the breakdown of files in the game's files, so if you're looking for something specific you can probably trace it through here. It should hopefully be a good resource if you're new to V3's file structure. Files that can't be parsed and .sfl's will be ignored for brevity's sake. Where there are different localiztaions of SRD files, the US localization's files will be listed. This is currently unfinished, because of the work involved but feel free to look around yourself with DRV3-Tools.

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
    - adv_resident.spc
    - ainori_resident.spc
    - e01_resident.spc
    - e02_resident.spc
    - e03_resident.spc
    - e04_resident.spc
    - e05_resident.spc
    - e06_resident.spc
    - epilogue_resident.spc
      - files from adv_resident to epilogue_resident only contain one .acb file that stores game information related to each chapter of the game
    - game_resident.spc
      - *Also contains a lot of other files, omitted here*
      - circle32.srd
      - common_window.spc
      - common_window_bikkuri.spc
      - decide_circle.srd
      - decide_circle_shader.srd
      - decide_square.srd
      - decide_square_shader.srd
      - dummy_black.srd
      - dummy_distortion.srd
      - dummy_normal.srd
      - font_bar.srd
      - font_line.srd
      - map_change.srd
      - pad_texture.srd
      - particle.srd
      - postprocess_heat_shimmer_texture.srd
      - sea.srd
      - spot_test_00.srd
      - spot_test_00_shader.srd
      - st_save_load_scroll.spc
      - touch_00.srd
      - t_sub_jinbutu_fade_normal.spc
      - t_sub_kuro_fade_normal.spc
    - game_resident_US.spc
      - contains specific localization information for the US
    - minigame_resident
    - minigame_resident_ENG
    - prologue_resident
      - matches with epilogue and episodes resident files
    - rsc_resident
    - trial_resident
    - voice_resident
    - voice_resident_ENG
  - sound
    - *Contains all bgm from the game as .vis and jingles and sound for opening movies. It also contains two voice files that presumably have voice acting files*
    - BGM.awb
    - JINGLE.awb
    - MOVIE.awb
    - V3_BGM_000_OP.vis
    - V3_BGM_001.vis
    - V3_BGM_002.vis
    - V3_BGM_003.vis
    - V3_BGM_004.vis
    - V3_BGM_005.vis
    - V3_BGM_006.vis
    - V3_BGM_007.vis
    - V3_BGM_008.vis
    - V3_BGM_009.vis
    - V3_BGM_010.vis
    - V3_BGM_011.vis
    - V3_BGM_012.vis
    - V3_BGM_013.vis
    - V3_BGM_014.vis
    - V3_BGM_015.vis
    - V3_BGM_016.vis
    - V3_BGM_017.vis
    - V3_BGM_018.vis
    - V3_BGM_019.vis
    - V3_BGM_020.vis
    - V3_BGM_021.vis
    - V3_BGM_022.vis
    - V3_BGM_023.vis
    - V3_BGM_024.vis
    - V3_BGM_025.vis
    - V3_BGM_026.vis
    - V3_BGM_027.vis
    - V3_BGM_028.vis
    - V3_BGM_029.vis
    - V3_BGM_030.vis
    - V3_BGM_031.vis
    - V3_BGM_032.vis
    - V3_BGM_033.vis
    - V3_BGM_034.vis
    - V3_BGM_035.vis
    - V3_BGM_036.vis
    - V3_BGM_037.vis
    - V3_BGM_038.vis
    - V3_BGM_039.vis
    - V3_BGM_040.vis
    - V3_BGM_041.vis
    - V3_BGM_042.vis
    - V3_BGM_043.vis
    - V3_BGM_044.vis
    - V3_BGM_045.vis
    - V3_BGM_046.vis
    - V3_BGM_047.vis
    - V3_BGM_048.vis
    - V3_BGM_049.vis
    - V3_BGM_050.vis
    - V3_BGM_051.vis
    - V3_BGM_052.vis
    - V3_BGM_053.vis
    - V3_BGM_054.vis
    - V3_BGM_055.vis
    - V3_BGM_056.vis
    - V3_BGM_057.vis
    - V3_BGM_058.vis
    - V3_BGM_059.vis
    - V3_BGM_060.vis
    - V3_BGM_061.vis
    - V3_BGM_062.vis
    - V3_BGM_063.vis
    - V3_BGM_064.vis
    - V3_BGM_065.vis
    - V3_BGM_066.vis
    - V3_BGM_067.vis
    - V3_BGM_068.vis
    - V3_BGM_069.vis
    - V3_BGM_070.vis
    - V3_BGM_071.vis
    - V3_BGM_072.vis
    - V3_BGM_073.vis
    - V3_BGM_074.vis
    - V3_BGM_075.vis
    - V3_BGM_076.vis
    - V3_BGM_077.vis
    - V3_BGM_078.vis
    - V3_BGM_079.vis
    - V3_BGM_080.vis
    - V3_BGM_081.vis
    - V3_BGM_082.vis
    - V3_BGM_083.vis
    - V3_BGM_084.vis
    - V3_BGM_085.vis
    - V3_BGM_086.vis
    - V3_BGM_087.vis
    - V3_BGM_088.vis
    - V3_BGM_089.vis
    - V3_BGM_090.vis
    - V3_BGM_091.vis
    - V3_BGM_092.vis
    - V3_BGM_093.vis
    - V3_BGM_094.vis
    - V3_BGM_095.vis
    - V3_BGM_096.vis
    - V3_BGM_097.vis
    - V3_BGM_098.vis
    - VOICE.awb
    - VOICE_ENG.awb