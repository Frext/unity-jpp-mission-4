# Unity Junior Programmer Pathway - Mission 4

[![Unity Version](https://img.shields.io/badge/Unity-2021.3.9f1-blue.svg?style=flat&logo=unity)](https://unity.com/)
[![Language](https://img.shields.io/badge/Language-C%23-green.svg?style=flat\&logo=c-sharp)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows-orange?logo=windows)](https://www.microsoft.com/windows/)
[![Project Foundation](https://img.shields.io/badge/Template-Unity%20Learn-lightgrey?style=flat&logo=unity)](https://learn.unity.com/)

> 💡 **Project Note:** This repository is built upon a starter template provided by **Unity Learn**. The core scene assets, UI layouts, and class structures were provided as a baseline; my role involved programming and implementing the architectural functionality (such as data persistence, OOP logic, and scene flow).

This repository contains 2 projects:
* [Lesson 4 - Sumo Warrior](https://learn.unity.com/pathway/junior-programmer/unit/gameplay-mechanics/tutorial/lesson-4-1-watch-where-you-re-going-2)
* [Challenge 4 - Soccer Scripting](https://learn.unity.com/pathway/junior-programmer/unit/gameplay-mechanics/tutorial/challenge-4-soccer-scripting-1)

---

## 🚀 Quick Start

Want to skip the code and just play? 

1. **[Download the Repository](https://github.com/Frext/Sumo-Warrior/archive/refs/heads/main.zip)**

2. Extract the ZIP file.
  
3. To play **Sumo Warrior:** Navigate to the `BuildWindows/SumoWarrior` folder and launch **`Sumo Warrior.exe`**.

4. To play **Soccer Balls:** Navigate to the `BuildWindows/SoccerBalls` folder and launch **`Sumo Warrior.exe`**.

---

## 🎮 Controls

| Key | Sumo Warrior | Soccer Balls |
| :---: | :--- | :--- |
| **W S** | Move | Move |
| **A D** | Rotate the Camera | Rotate the Camera |
| **SPACE** | N/A | Speed Boost |

---

## 🎬 Gameplay Preview

### Sumo Warrior
https://github.com/user-attachments/assets/3f503fba-2aa1-4290-b6f5-86b03e66e248

### Soccer Balls
https://github.com/user-attachments/assets/9f856bfc-178e-4b28-959e-72048f3c451f

---

## 📸 Screenshots

### Sumo Warrior

| Start | Gameplay |
|:---:|:---:|
| <img src="https://github.com/user-attachments/assets/622d5880-5be1-4103-9fe3-67f974610650" width="500" alt="Start"/> | <img src="https://github.com/user-attachments/assets/a533ac77-6363-4dd2-a82a-a4ba4a658fda" width="500" alt="Gameplay"/> |

### Soccer Balls

| Start | Gameplay |
|:---:|:---:|
| <img src="https://github.com/user-attachments/assets/a5e9319f-8c80-443e-8fd2-5bbf4aaec00d" width="500" alt="Start"/> | <img src="https://github.com/user-attachments/assets/cbf06c26-2ecb-45d8-be2d-fab684084382" width="500" alt="Gameplay"/> |

---

## 🎯 Implemented Parts

### Sumo Warrior

* **Camera & Movement Control:** The camera rotates around the island with horizontal input, and the player rolls in the camera's direction with vertical input.
* **Power-Ups:** Collecting a power-up activates a visual indicator and launches enemies flying on collision, disappearing after a set time.
* **Progressive Wave Spawning:** Enemies spawn in waves at random locations; every time a wave is cleared, the enemy count increases and a new power-up spawns.

### Soccer Balls

* **Enemy AI:** Enemies actively target you to push you into the net, but you can physically hit them to deflect them away.
* **Power-Ups:** Collecting a power-up gives you a visual indicator and temporary strength boost that automatically disappears after 5 seconds.
* **Progressive Wave Spawning:** When all enemy balls are cleared from the field, a new wave instantly spawns with one additional enemy.

---

## 🛠️ Built With

* **Game Engine:** Unity (2021.3.9f1)
* **Scripting Language:** C#
* **Course:** Unity Learn Junior Programmer Pathway (Mission 4: Gameplay Mechanics)

---

**2022**
