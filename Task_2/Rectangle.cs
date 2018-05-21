using System;

namespace Task_2
{
  /// <summary>
  /// This class represents rectangle and method for work with it.
  /// </summary>
  public class Rectangle
  {
    private const string SIDE_A = "Side A: ";
    private const string SIDE_B = "Side B: ";
    private const string SIDE_EXCEPTION_MESSAGE = "rectangle's side exception. Side cannot be less than 1.";

    private double sideA;
    private double sideB;

    /// <summary>
    /// Initialize the side, check the value of the entered side.
    /// </summary>
    public double SideA
    {
      get
      {
        return sideA;
      }
      set
      {
        sideA = value;
        if (sideA <= 0)
        {
          throw new Exception($"{SIDE_A}{SIDE_EXCEPTION_MESSAGE}");
        }
      }
    }

    /// <summary>
    /// Initialize the side, check the value of the entered side.
    /// </summary>
    public double SideB
    {
      get
      {
        return sideB;
      }
      set
      {
        sideB = value;
        if (sideB <= 0)
        {
          throw new Exception($"{SIDE_B}{SIDE_EXCEPTION_MESSAGE}");
        }
      }
    }

    public Rectangle(string firstSide, string secondSide)
    {
      SideA = double.Parse(firstSide);
      SideB = double.Parse(secondSide);
    }

    /// <summary>
    /// Calculate the rectangle's square.
    /// </summary>
    /// <returns></returns>
    public double CalculateTheRectangleSquare()
    {
      return SideA * SideB;
    }
  }
}