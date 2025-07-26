# Tic Tac Toe (Windows Forms App)

A simple two-player **Tic Tac Toe** game built with C# and Windows Forms. This project provides a clean, interactive interface for two players to take turns marking "X" and "O" until one wins or the game ends in a draw.

## 🧩 Features

- Two-player turn-based gameplay.
- Visual "X" and "O" icons displayed on the game board.
- Automatic win detection for rows, columns, and diagonals.
- Draw detection when all cells are filled with no winner.
- Restart button to reset the board and play again.
- Player turn indicator and winner announcement.

## 📷 Interface Overview

- The board consists of 9 clickable cells arranged in a 3×3 grid.
- Each cell is a `PictureBox`, updated dynamically with player symbols.
- The game displays the current player's turn and the final result.

## 🛠 Technologies Used

- **C#**
- **Windows Forms**
- **.NET Framework**

## 💡 How It Works

- The game starts with **Player 1 ("X")**.
- On clicking a cell, the symbol is placed and the turn switches.
- If a player wins or all cells are filled, a message is shown.
- The game can be restarted at any time using the **Restart Game** button.

## 📂 Project Structure

- `Form1.cs` — Contains the game logic, event handling, and UI updates.
- `Properties/Resources.resx` — Stores image assets for X, O, and question mark cell.

## 🚀 Getting Started

### Prerequisites

- Visual Studio (2019 or later)
- .NET Framework (4.7.2 or later recommended)

### Steps

1. Clone or download the project.
2. Open the solution in Visual Studio.
3. Run the project (`F5` or click **Start**).
