## 📔 Game Description
![Gif of Trash Grabbers gameplay](https://github.com/bibyru/bibyru/blob/main/Gifs/KnightlyPong.gif)

**Knightly Pong** is a pong game with 2 players where they hit each other’s castle to gain points.

Download game [here](https://github.com/bibyru/Knightly-Pong/releases/).

<br/>

## 🎮 Game Controls
This game uses keyboard inputs.
| **Action** | **Key binding** |
| :- | :- |
| Player 1 Up | W |
| Player 1 Down | S |
| Player 2 Up | P |
| Player 2 Down | L |

<br/>

## 📝 Project Info
This project was developed using Unity Engine v2022.3.32f1.
| **Role** | **Credit** | **Development Time** |
| :- | :- | :- |
| Game programmer | bibyru (Ruby) | 2 days |
| Project lead | bibyru (Ruby) | 3 days |
| Visual designer | bibyru (Ruby) | 1 day |
| Game designer | bibyru (Ruby) | 1 day |
| Sound designer | bibyru (Ruby) | 1 day |

<br/>

## ⭐ Scripts and Features
| **Script** | **Description** |
| :- | :- |
| `BallMovement.cs` | Script for ball to move, reset, and emit sound. |
| `CamShake.cs` | Script for camera to shake. |
| `Castle.cs` | Script for castle to change states, add score, and emit sound. |
| `KnightMovement.cs` | Script for knight (players' avatar) to move. |
| `P1Input.cs` | Script for knight object to read player 1 input. |
| `P2Input.cs` | Script for knight object to read player 2 input. |
| `Score.cs` | Script for managing players' score. |

<br/>

## 📁 File Description
```
├── KnightlyPong
    ├── ...
    ├── Assets
        ├── Anims    # for all game animations
        ├── Sauce    # for all game assets
        ├── Scenes   # for game map
            ├── Tilemap    # for tilemap data
        ├── Scripts  # for all game scripts
```

<br/>

## 💿 How to Open in Game Engine
1. Download `PONG.unitypackage`.
2. Launch Unity Engine v2022.3.32f1.
3. Press **Assets** -> **Import Package** -> **Custom Package**
4. Select the downloaded `PONG.unitypackage`.
