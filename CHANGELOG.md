# Changelog

All notable changes to this project will be documented in this file.

The format is based on Keep a Changelog.

---

# [1.0.0] - 2026-07-27

## Added

### Seasonal Content Restoration

- Restored access to existing seasonal content that is normally restricted outside of event periods.
- Added configurable restoration support for individual seasonal build pieces and crafting recipes.

### Restored Seasonal Content

#### Midsummer

- Maypole
- Midsummer Crown

#### Yule

- Christmas Tree
- Christmas Crown
- Christmas Garland
- Mistletoe
- Small Christmas Gift
- Medium Christmas Gift
- Large Christmas Gift

#### Halloween

- Jack-o-Turnip
- Pointy hat

### Configuration System

- Added configuration controls for enabling or disabling individual seasonal content categories.
- Added configurable logging verbosity levels:
  - Minimal
  - Warnings
  - Standard
  - Debug

### Compatibility

- Implemented as a lightweight client-side modification.
- Does not modify vanilla assets, gameplay systems, or existing functionality.
- Restores access by removing seasonal availability restrictions only.

### Logging

- Added structured logging for:
  - Plugin initialization
  - Restoration attempts
  - Successful restorations
  - Warnings and errors
  - Debug information

## Fixed

- Restored seasonal recipes that were unavailable outside their intended event periods.
- Corrected seasonal build pieces not appearing as available content.

## Notes

- This is the first stable release of Seasonal Content Unlocked.
- Configuration changes require restarting Valheim before taking effect.