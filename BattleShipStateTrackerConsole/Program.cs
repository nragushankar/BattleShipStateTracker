using System;
using BattleShipStateTrackerAPI.Controllers;
using BattleShipStateTrackerAPI.Models.Boards;

namespace BattleShipStateTrackerConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(" -- Welcome to BattleShip Game! -- ");
      Console.WriteLine("\n Press Enter key to start the Game");
      Console.ReadLine();
      BattleShipTrackerController controller = new BattleShipTrackerController();
      controller.CreateBoard();

      Console.WriteLine("\n Wow The BattleShip Board is Created");
      Console.WriteLine("\n Press any key to Add all 5 BattleShips onto the Ocean Board");
      Console.ReadKey();
      controller.AddBattleshipsOnBoard();

      Console.WriteLine("\n");
      Console.WriteLine("\n Now The BattleShips are added on the Board");
      Console.WriteLine("\n Press any key to Attack at 3, 6 coordinates");
      Console.ReadKey();
      //Even though the coordinates are fixed but since the ships are placed randomly, hence they will never be at same place
      Coordinates coordinates = new Coordinates(3, 6);
      var status = controller.Attack(coordinates);
      Console.WriteLine("\n The Attack is a " + status);

      if (status == "Hit")
      {
        Console.WriteLine("\n You Won the Game");
      }
      else if (status == "Miss")
      {
        Console.WriteLine("\n you lost the Game");
      }
      return;
    }
  }
}
