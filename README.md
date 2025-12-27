# Argon Assault

A Unity-based space shooter game built with C#.

## Overview

Argon Assault is an action-packed space combat game where players control a spaceship to battle enemies and defend against incoming threats. The game features dynamic enemy spawning, particle effects, scoring systems, and immersive gameplay mechanics.

## Features

- **Player Controls**: Smooth spaceship movement with intuitive keyboard/controller input
  - Directional movement (up, down, left, right)
  - Rotation based on player input and screen position
  - Customizable control sensitivity

- **Combat System**: 
  - Player laser weapons with multiple firing options
  - Enemy detection and health system
  - Particle effects for visual feedback
  - Score tracking and progression

- **Enemy AI**:
  - Dynamic enemy spawning
  - Collision detection with player lasers
  - Death effects with particle animations
  - Variable difficulty and enemy types

- **User Interface**:
  - Score display system
  - TextMesh Pro integration for UI rendering
  - Real-time feedback and game state information

- **Audio/Visual Polish**:
  - Music and sound effects
  - Particle effects for explosions and impacts
  - Shader-based text rendering with TextMesh Pro

## Project Structure

```
Assets/
├── Scripts/
│   ├── PlayerControls.cs      # Player movement and input handling
│   ├── Enemy.cs               # Enemy behavior and health
│   └── ScoreBoard.cs          # Score management
├── Prefabs/                   # Reusable game objects
├── Scenes/                    # Game levels
├── Materials/                 # Shader materials
├── Particles/                 # Particle effects
├── Music & SFX/               # Audio files
└── TextMesh Pro/              # UI and text assets
```

## Controls

- **Movement**: Arrow Keys or WASD
- **Rotation**: Automatic based on mouse position
- **Fire**: Space or Left Mouse Button

## Requirements

- Unity 2020 LTS or newer
- TextMesh Pro
- Input System

## Installation

1. Clone or download the repository
2. Open the project in Unity
3. Load the main scene from `Assets/Scenes/`
4. Press Play to start the game

## Development

### Key Scripts

- **PlayerControls.cs**: Handles player input, movement, rotation, and weapon firing
- **Enemy.cs**: Manages enemy health, damage, and destruction
- **ScoreBoard.cs**: Tracks and displays player score

### Customization

You can adjust gameplay parameters directly in the Inspector:
- Player control speed and movement range
- Enemy hit points and scoring values
- Laser firing rate and damage
- Particle effect intensity

## Build

The game includes a WebGL build in the `Builds/Build/` directory for browser-based play.

## License

This project is provided as-is for educational and personal use.