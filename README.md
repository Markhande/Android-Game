# Android Game

A small **Unity** prototype built for Android. The player moves left and right and gets forward force through Unity physics.

## What it does

This project is an early Android game prototype in Unity. A `Player` script reads left/right input and moves the character horizontally, while a Rigidbody applies forward force so the player keeps traveling through the scene.

It is meant as a starting point for a mobile Unity game rather than a finished product.

## Features

- Horizontal player movement (left / right)
- Forward motion via Rigidbody force
- Unity physics-based control
- Android build target / modules configured in the Unity project

## Tech stack

| Area | Stack |
| --- | --- |
| Engine | Unity 2022.3.12f1 |
| Language | C# |
| Physics | Unity Rigidbody |
| Platform | Android |

## Project structure

```
Assets/            # Game assets and scripts (includes Player script)
Packages/          # Unity package manifest
ProjectSettings/   # Unity project and platform settings
Library/           # Unity-generated (local)
Logs/              # Unity logs
UserSettings/      # Editor user settings
```

Note: the player script file is currently named `plyaer.cs` in `Assets/` (typo of “player”).

## How the player works

1. Read left/right input (arrow keys in editor / mapped controls).
2. Move the player horizontally.
3. Apply forward Rigidbody force for continuous travel.

## Getting started

### Requirements

- Unity **2022.3.12f1** (or a compatible 2022.3 LTS build)
- Android Build Support modules in Unity Hub
- Optional: Android device or emulator for device testing

### Open and run

1. Open this folder in Unity Hub / Unity Editor.
2. Open the main scene from `Assets/`.
3. Press Play in the Editor to try movement.
4. Use File → Build Settings → Android to build an APK/AAB when ready.

## Notes

- This is a prototype: expect minimal content beyond player movement.
- Generated folders like `Library/`, `Logs/`, and `UserSettings/` are local Unity artifacts.
- Consider renaming `plyaer.cs` to `Player.cs` when you next tidy the project.

## Author

[Markhande](https://github.com/Markhande)
