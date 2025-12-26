# Adjust Exposure

A mod for Valheim that allows players to customize graphics settings for exposure (i.e. gamma/brightness) and tonemapping, enhancing visual clarity and gameplay experience.

## Configuration

The configuration file for this mod is automatically generated the first time you run the game with the mod installed. You can find it in your local BepInEx config directory (`BepInEx\config\ValheimAdjustExposure.cfg`).

You can customize the following settings in the configuration file:

- `Exposure`: Adjusts the overall brightness of the game. Higher values make the game brighter, while lower values make it darker. Default is `1.0`.
- `Tonemapping`: Changes the tonemapping method used in the game. Options include `None`, `ACES`, and `Neutral`. Default is `ACES`.

## Prerequisites

- Install a mod manager like [R2Modman](https://thunderstore.io/package/ebkr/r2modman/).
- Install [BepInExPack Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/) with mod manager.

## Install from Thunderstore

Install [AdjustExposure](https://thunderstore.io/c/valheim/p/Aidin/AdjustExposure/) with mod manager.

## Build from source

1. Install .NET SDK (Core 3.1 or later) from [Microsoft](https://dotnet.microsoft.com/en-us/download).
2. Download source code from [GitHub](https://github.com/aidinabedi/ValheimAdjustExposure).
3. Build release with .NET CLI command: `dotnet build -c Release`
4. Import generated `ValheimAdjustExposure.zip` as local mod using mod manager.
