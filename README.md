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

## Development Tools
- Created using Unity
- Code edited using Visual Studio Code
- Audio edited using [Audacity](https://www.audacityteam.org/)
- 2D images created and edited using [Paint.NET](https://www.getpaint.net/)
