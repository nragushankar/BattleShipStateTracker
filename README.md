# BattleShipStateTracker
BattleShip game in .Net core using c#

### Models: 
- 2 Players
- 2 Boards for each player
  - OceanBoard (This is the 10*10 Game board where the ships would be placed)
  - TargetBoard (This is the 10*10 Target board where the Red/White Pegs get placed notifying Hit/Miss)
- 5 Ships for each player
  - Battleship
  - Carrier
  - Cruiser
  - Destroyer
  - Submarine 


### Game Rules
  This is a classic “Battleship” Game with
  • Two players
  • Each have a 10x10 board
  • During setup, players can place an arbitrary number of “battleships” on their board. 
  • The ships are 1-by-n sized, must fit entirely on the board, and must be aligned either vertically or horizontally.
  • During play, players take turn “attacking” a single position on the opponent’s board, and the opponent must respond by either reporting a “hit” on one of their battleships (if one occupies that position) or a “miss”
  • A battleship is sunk if it has been hit on all the squares it occupies
  • A player wins if all of their opponent’s battleships have been sunk.
  
## Structure
- Solution contains two projects 
  - BattleShipStateTrackerConsole - A Console Project to take user input
  - BattleShipStateTrackerAPI - the BattleShip API Project with game implementation

## Requirements
- Visual Studio
- .Net Core 3.1
- C#

### Building
- Open Visual Studio -> Build -> Build All

### Execution
- Open Visual Studio -> Run -> Start Without Debugging

### Implementation
The current implementation of the game is to just implement a Battleship state tracking API for a single player that must support the following logic:
• Create a board
• Add a battleship to the board
• Take an “attack” at a given position, and report back whether the attack
resulted in a hit or a miss.
Only the state tracker is implemented. No graphical interface or persistence layer is been implemented.
