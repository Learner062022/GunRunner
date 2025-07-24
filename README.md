# GunRunner

## Description
**GunRunner** is a fast-paced 3D run-and-gun arcade shooter set in a gritty sci-fi world. Inspired by genre-defining classic like **DOOM**, **Quake**, and **Half-Life**, it blends the relentless action of arcade-style combat with immersive environments and intelligent enemy behaviour. Players will battle through hostile levels, wield a diverse arsenal and experience a retro-inspired shooter reimagined with modern design.

## Installation & Setup

### System Requirements
Refer to [Unity System Requirements](https://docs.unity3d.com/6000.0/Documentation/Manual/system-requirements.html) to meet the minimum and recommended specifications.  

### Pre-requisits
Before setting up the project, ensure the following tools and software are installed:

- **Git** - Latest stable version
- **Unity Hub** - Any recent version 
- **Unity Editor** - Version **2023.2.20f1 or later** 
- **Visual Studio Community 2022** - With **Game Development with Unity** workload installed
- **Visual Studio Code** - Optional lightweight editor (recommended version: 1.80+)

### Project Setup Instructions

#### 1. Install Dependencies
Open Unity and ensure the following packages are installed via the **Package Manager**:

- **Input System** - v1.5.1
- **Universal Render Pipeline (URP)** - v14.0.8
- **TextMeshPro** - v2.1.6

#### 2. Clone Repository
```bash
git clone https://github.com/Learner062022/GunRunner.git
cd GunRunner
```

#### 3. Open in Unity
- Launch Unity Hub
- Click Open and select the cloned `GunRunner` folder.

## Usage

### Controls

| Action        | Key               |
|---------------|-------------------|
| Move          | WASD / Arrow Keys |
| Shoot         | Left Mouse Button |
| Switch Weapon | Number Keys (1-3) |
| Pause         | Esc               |

### Gameplay Overview
- Navigate through levels filled with enemies.
- Collect ammo to keep weapons firing.
- Use different weapons to handle ranged and melee threats.
- Dodge slow projectiles and avoid close-range attacks.

## Levels

### Level 1: Rustspire Hold 
A rusted industrial facility deep within a mining colony. The player awakens in a damaged corridor after a containment breach. The level introduces core mechanics: fast movement, shooting, ammo pickups, and basic enemy encounters.

### Level 2: The Alien Outpost
A remote alien research base overtaken by hostile lifeforms. The level expands gameplay with new weapons, enemy types, and light puzzle elements.

## Menus
- **Main** - Start, exit game
- **Pause** - Resume, exit to main menu

## GUI
The GUI is built using Unity's **Canvas system** and includes:

- Health and ammo indicators.
- Weapon selection UI.
- Pause and Main Menu interfaces.

## Pathfinding
Enemy pathfinding is implemented using Unity's **Navmesh system**, allowing AI to navigate complex environments and pursue the player intelligently.

## AI System
All enemy behaviour is controlled using **Finite State Machines (FSMs)**, with states such as:

- **Patrol** - Enemies move between waypoints until altered.
- **Chase** - Enemies pursue the player usijng Navmesh.
- **Attack** - Enemies engage with melee or ranged attacks.

Optional advanced states (if time permits):

- **Retreat** - Enemies back off when low on health.
- **Re-engage** - Enemies return to combat after recovery or repositioning.

## Features
- **No Reloading** - Weapons fire continuously without the need to reload, keeping combat fast and uninterrupted.
- **Ammo Pickups** - Ammo is scattered throughout the environment and can be collected to keep weapons stocked.
- **Varied Weapon Types** - Players can access multiple weapon types, each offering distinct adavantages and tactical options.
- **Enemy Attacks** - Enemies engage the player with slow-moving projectiles or close-range melee strikes, encouraging movement and dodging.
- **Enemy Variety** - Includes multiple enemy types with unique behaviours and parameters. At minimum, there is:
  - **One ranged enemy** that attacks from a distance.
  - **One melee enemy** that closes in for direct combat.

## Contributing
To learn how to contribute, pleaes refer to GitHub's official guide:
[Contributing to a project – GitHub Docs](https://docs.github.com/en/get-started/exploring-projects-on-github/contributing-to-a-project)

## License
The project is licensed under the [GPL-3.0 License](https://www.gnu.org/licenses/gpl-3.0.en.html)