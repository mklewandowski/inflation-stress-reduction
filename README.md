# Inflation Stress Reduction
A stress reduction clicker designed to ease the pain of rising inflation.

![Inflation Stress Reduction gameplay](https://github.com/mklewandowski/inflation-stress-reduction/blob/main/Assets/Images/gameplay.gif?raw=true)

## Supported Platforms
Inflation Stress Reduction is designed for use on multiple platforms including:
- iOS
- Android
- Web
- Mac and PC standalone builds

## Running Locally
Use the following steps to run locally:
1. Clone this repo
2. Open repo folder using Unity 2021.3.23f1
3. Install Text Mesh Pro

## Building
Builds are made locally using Unity. At present iOS, Android, and WebGL are supported. To build:
1. Open in Unity
2. Set the target platform in build settings
3. Build application

### Android Build Settings
Under Project Settings > Player > Other Settings, set the following:
- set Target API Level to API Level 31 or higher (as of August 2022)
- set Scripting Backend to IL2CPP
- check ARM64 in Project Architecture
- create a new keystore, save locally, and add to publish settings (for this project, the keystore password is "inflation"). This only needs to be done once.
- Ensure the bundle identifier is set to `com.team2bit.inflationstressreduction`.

### WebGL Build
For embedding within itch.io and other web pages, we use the `better-minimal-webgl-template` seen here:
https://seansleblanc.itch.io/better-minimal-webgl-template

Setup of the `better-minimal-webgl-template` is as follows:
1. Download and unzip the template.
2. Copy the `WebGLTemplates` folder into the `Assets` folder.
3. File -> Build Settings... -> WebGL -> Player Settings... -> Select the "BetterMinimal" template.
4. Enter color in the "Background" field.
5. Enter "false" in the "Scale to fit" field to disable scaling.
6. Enter "true" in the "Optimize for pixel art" field to use CSS more appropriate for pixel art.

### Running a Unity WebGL Build
1. Install the "Live Server" VS Code extension.
2. Open the WebGL build output directory with VS Code.
3. Right-click `index.html`, and select "Open with Live Server".

## Development Tools
- Created using Unity
- Code edited using Visual Studio Code
- Audio edited using [Audacity](https://www.audacityteam.org/)
- 2D images created and edited using [Paint.NET](https://www.getpaint.net/)
