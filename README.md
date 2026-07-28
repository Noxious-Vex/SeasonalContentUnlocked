![Version](https://img.shields.io/badge/version-1.0.0-blue)
![Game](https://img.shields.io/badge/game-Valheim-orange)
![Framework](https://img.shields.io/badge/framework-BepInEx-purple)
![Dependency](https://img.shields.io/badge/dependency-J%C3%B6tunn-green)

# Seasonal Content Unlocked

## Overview

Seasonal Content Unlocked is a lightweight client-side Valheim mod that makes existing seasonal content permanently available outside of its original event periods.

This mod does not add, replace, or modify any game assets, mechanics, features, or functionality. Instead, it simply removes the seasonal restrictions applied to content that is already present within Valheim, allowing players to craft and use seasonal items whenever they choose.

All restored seasonal content can be individually enabled or disabled through the configuration file, giving players full control over which seasonal features are available in their world.

## Features

* Fully client-side mod with no server-side installation required.
* Restores access to existing seasonal content already included in Valheim.
* Removes seasonal availability restrictions without modifying game assets or gameplay systems.
* Restores unavailable seasonal crafting recipes.
* Restores unavailable seasonal build pieces.
* Configurable enable/disable controls for individual seasonal content.
* Preserves vanilla item behavior, stats, recipes, and functionality.
* Lightweight implementation designed for compatibility within all scenarios.

## Supported Seasonal Content

### Midsummer
* Maypole
* Midsummer Crown

### Yule (Christmas)
* Christmas Tree
* Christmas Crown
* Christmas Garland
* Mistletoe
* Small Christmas Gift
* Medium Christmas Gift
* Large Christmas Gift

### Halloween
* Jack-o-Turnip

# Configuration

**Seasonal Content Unlocked** uses a client-only configuration system, so this mod can work even on multiplayer servers that don't have it installed.

## Configuration File

`BepInEx/config/SeasonalContentUnlocked.cfg`

The configuration file allows you to customize which seasonal content is restored by enabling or disabling individual categories.

## Available Configuration Options

### [Midsummer]
*Control the availability of Midsummer seasonal content, including:*
* Maypole
* Midsummer crown


### [Halloween]
*Control the availability of Halloween seasonal content, including:*
* Jack-o-Turnip
* Pointy hat

### [Yule]
*Control the availability of Yule seasonal content, including:*
* Yule Tree
* Yule wreath
* Yule garland
* Mistletoe
* Yuleklapp (small)
* Yuleklapp (medium)
* Yuleklapp (large)

# Compatibility
Seasonal Content Unlocked is designed to be lightweight and minimally invasive.
Because the mod does not add new assets, modify existing assets, or alter vanilla gameplay systems, it is intended to maintain broad compatibility with other Valheim mods.

### Client-Side
Client-side only.
Does not require installation on dedicated servers.
Players may install or remove the mod without affecting world data.

### Vanilla Gameplay
This mod does not:
* Add new items.
* Modify existing item statistics.
* Change crafting recipes.
* Alter game mechanics or progression.
* Replace or modify game assets.

Instead, it simply removes the seasonal availability restrictions applied to existing seasonal content.

### Dependencies

* [BepInEx](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)

### Uncompatible Mods:

* No confirmed incompatiblities yet.
* Mods that modify/remove the vanilla Seasonal Content.

## Known Limitations

*No known limitations at this time.*

---

# Installation

## Thunderstore Mod Manager / r2modman

The recommended installation method is through Thunderstore using a mod manager such as r2modman or Thunderstore Mod Manager.

1. Open r2modman or Thunderstore Mod Manager.
2. Select **Valheim** as the game.
3. Search for **Seasonal Content Unlocked**.
4. Install the mod.
5. Launch Valheim through the mod manager.

The required dependencies will be handled automatically by the mod manager.

---

## Manual Installation

1. Install BepInEx for Valheim.
2. Place `SeasonalContentUnlocked.dll` into:

```
BepInEx/plugins/
```

---

# Credits

Created by:
**Noxious Vex**

Built using:
• [BepInEx](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)

---

# License

Seasonal Content Unlocked uses a custom license designed to allow gameplay use,
server hosting, and modpack inclusion while protecting original work.

See the LICENSE file included with this project for full terms.

---

# Support

For issues, bug reports, and suggestions:
Feature requests are welcome.
Bug reports should include:
• Mod version
• Game version
• BepInEx version
• Player.log (Ideally with Debug Logging enabled from Config)

Discord Username:
> `noxiousvex`
