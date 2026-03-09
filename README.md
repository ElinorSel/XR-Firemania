# 🔥 XR Firemania

A virtual reality firefighting game built in Unity for the **Meta Quest**. Players use their XR controllers to combat fires across multiple environments before the clock runs out.

---

## 🎮 Gameplay

- Use your XR controllers to shoot water and extinguish fires using a one or two-handed water minigun
- Each fire you put out increases your score
- Survive for **1 min** after that
- Your score and session data can be logged to a CSV file

---

## 🌍 Scenes

| Scene | Description |
|---|---|
| Main Menu | Start screen with level select |
| Forest | Outdoor forest fire environment |
| Building | Indoor building fire environment |

---

## 🛠️ Concepts Practiced

- **XR & VR Development** — Building for Meta Quest using Unity's XR Interaction Toolkit, including controller input, ray interactors, and VR-compatible UI
- **Game Architecture** — Structuring a project with a centralised GameManager to handle game state, separating concerns across multiple scripts
- **Scene Management** — Loading and transitioning between multiple scenes, managing state across scene changes
- **UI in VR** — Working with World Space canvases, making UI interactable with XR controllers, and dynamically updating UI at runtime
- **Physics & Particle Systems** — Using particle collision callbacks to drive gameplay logic
- **Time Manipulation** — Controlling game time with `Time.timeScale` for slow motion effects
- **Data Logging** — Writing structured session data to CSV files for research and analysis purposes
- **Cross-script Communication** — Referencing and calling methods between scripts and GameObjects in a Unity project

---

## 🧰 Built With

- **Unity** (XR Interaction Toolkit)
- **Meta Quest** (Android / OpenXR)

---

## 👤 Author

**Elinor** — Mini-Project for VR
