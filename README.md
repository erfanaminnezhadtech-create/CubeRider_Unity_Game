# 🏃 Endless Runner Game

**Unity 3D endless runner** where players navigate through obstacles, collect points, and progress through levels.  

---

## 🎮 Project Overview
A simple 3D game built in Unity featuring:  

- Player movement mechanics  
- Scoring system  
- Collision detection  
- Level progression  

---

## 🚀 Game Features

### 🕹 Player Movement
- **Forward Movement**: Continuous automatic forward motion  
- **Sideways Control**: `A` and `D` keys to move left and right  
- **Physics-Based**: Uses Rigidbody for realistic movement  

### 💎 Scoring System
- **Real-Time Score**: Score = Player's Z-position (distance traveled)  
- **UI Integration**: Score displayed on the screen via UI Text  

### ⚔ Gameplay Mechanics
- **Collision Detection**: Obstacles & hazards  
- **Game Over**: Falls below Y = -1  
- **Level Completion**: Reach end zone to complete level  
- **Restart**: Automatic restart after game over (configurable delay)  

### 🏁 Level Progression
- **Level Complete Screen**: Shows when reaching level end  
- **Next Level**: Click to proceed  

---

## 📜 Scripts Description

| Script | Purpose |
|--------|---------|
| `GameManager.cs` | Manages game state, game over, level completion, scene restart |
| `PlayerMovement.cs` | Handles player input & physics-based movement |
| `score.cs` | Tracks player distance & updates UI |
| `LevelComplete.cs` | Loads next level & handles transitions |
| `followPlayer.cs` | Camera follows player |
| `playerCollision.cs` | Detects collisions with obstacles |
| `EndTrigger.cs` | Triggers level complete event |
| `Menu.cs` | Handles main menu navigation & UI |

---

## ⚙ Installation & Setup

1. Open project in **Unity**  
2. Place all scripts in `Assets/Scripts`  
3. Scene hierarchy setup:  
   - Player (with Rigidbody & `PlayerMovement`)  
   - Obstacles (Rigidbody)  
   - UI Canvas with Score Text  
   - Camera with `followPlayer` script  
4. Configure **Game Manager references** in Inspector  
5. Test and play! 🎉  

---

## ⌨ Controls

| Key | Action |
|-----|--------|
| `A` | Move Left |
| `D` | Move Right |

---

## 💀 Game Over Conditions
- Player collides with an obstacle  
- Player falls below Y = -1  

---

## 🌟 Future Enhancements
- Sound effects  
- Difficulty progression  
- Power-ups & collectibles  
- Enhanced visual effects  
- Leaderboard system  
- Mobile touch controls  

---

## 🔧 Notes
- Adjust `forwardForce` in `PlayerMovement.cs` to change difficulty  
- Modify `sidewaysForce` for responsiveness  
- Configure `restartDelay` in `GameManager.cs`  

---

✅ Ready to play & expand!  
