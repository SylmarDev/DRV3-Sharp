# DRV3-Sharp
DRV3-Sharp is a tool and library for working with various formats from Danganronpa V3 for PC (PS Vita/PS4 are not fully supported!). These tools are currently run from the command line, such as Windows Command Prompt, PowerShell, or the Linux/Unix/macOS terminal of your choice. This is planned to change to be a GUI interface that's more user-friendly.

## Downloading the Prebuilt Version
These tools are in a constant state of rewrites and adjustments, so I currently do not provide pre-built copies via GitHub's "Releases" section right now. These builds are unstable and probably have bugs. If you would like to check out the latest builds without building locally, follow these steps:

1. View commits. You can do this by scrolling to the top of the page, and clicking the option in the top right that says "x commits"
2. Find a recent commit, within the past month, and click the green checkmark
3. Click off to the side where the new pop-up says "Details"
4. This will take you to the appveyor site for this build. On the right side of the screen, click "Artifacts". If there isn't an artifact present, try  with an older commit
5. Click on the generated zip archive. Extract it with your favorite unzipping software
6. Run DRV3-Sharp.exe. Congratulations, you're running DRV3-Sharp

## Building Locally
### Prerequistes
- Visual Studio 2022
- Dotnet SDK

### Steps
1. Open the DRV3-Sharp repo in Visual Studio 2022 (or your IDE of choice)
2. In a terminal/powershell window, navigate to the project directory (if you aren't there already) and run `dotnet --version`
3. Ensure your dotnet version is .NET 7.0. (It can be newer, but then you run the risk of breaking changes)
4. ***To build a local copy***, run `dotnet build`
5. ***To run in visual studio***, select `DRV3-Sharp.csproj` as your target
6. Click run. The project should launch

### Troubleshooting
Building on other platforms is currently not strictly supported because the Scarlet libraries are only built for Windows. However, you should be able to build them from [this repo](https://github.com/CaptainSwag101/Scarlet) and import them to this project and be able to build locally.

## User's Manual
Read the [User's Manual](usersManual.md) if you're lost.

## Documentation
>TODO

## Why don't you provide any instructions on how to use these tools?
Well... frankly, it's because I'm constantly rewriting these tools and have changed how they work drastically several times. These tools are by no means stable yet (I've just completed the second major overhaul of the codebase as I write this, which COMPLETELY changed how the project is structured and how the program will be invoked), so I can't easily provide a good guide for other people to use them when I myself still haven't decided on how they should be used. That said, now that this overhaul is done, I feel rather pleased with how the project is shaping up, so hopefully I won't need to make any major design overhauls in the future, and can start to work on documenting things better. Overall, the program should be very easy to interact with: just use your arrow keys, the Enter key, and the Spacebar for multi-item selection (where applicable).

I know that's probably not an entirely satisfactory answer, but I'm a largely self-taught programmer who's figuring out how to do all this as I go along. I'm working on the code and underlying research in my spare time between university, work, and the rest of my personal life and hobby projects. I create these tools and libraries and publish them as open-source in the hopes that others may find them useful and to provide some sort of documentation for my work, but their primary focus at this time is to help myself research and understand Danganronpa V3 and its data.

I do intend to find an end result that should be much more user-friendly (a GUI frontend that I intend to call FlashbackLight which will provide a nice interface for interacting with these tools), but I have no estimate on when that will be ready, as it inherently needs these tools and their research to be in a place I'm happy with.

## Credits/Acknowledgements
A special thanks to:

[yukinogatari](https://github.com/yukinogatari) (formerly BlackDragonHunt) for her work on [Danganronpa-Tools](https://github.com/yukinogatari/Danganronpa-Tools). Without that initial insight into SPC compression, I might never have been able to make any of this possible in the first place.

[Insomniacboy](https://github.com/Insomniacboy) for their suggestion and example of a list-based UI, which this new overhaul got its inspiration from.
