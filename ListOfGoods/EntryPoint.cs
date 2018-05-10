using System;

namespace ListOfGoods
{
  /// <summary>
  /// Entry point.
  /// </summary>
  class EntryPoint
  {
    private const string ADD_TO_THE_STORAGE = "\nStore the product №";
    private const string ENTER_THE_COMMAND = "\nEnter the command: ";
    private const string COUNT_TYPES = "count types";
    private const string COUNT_ALL = "count all";
    private const string AVERAGE_PRICE = "average price";
    private const string EXIT = "exit";
    private const string RESULT = "\nResult: ";
    private const string COMMAND_DOES_NOT_EXIST = "\nThis command doesn't exist.";
    private const string TYPE_DOES_NOT_EXIST = "\nStorage doesn't contain this type.";

    static void Main(string[] args)
    {
      try
      {
        InformationInput input = new InformationInput();
        ProductBuilder builder = new ProductBuilder();
        GoodsStorage storage = new GoodsStorage();
        string enteredCommand = null;
        int number = input.EnterTheNumberOfProducts();
        for (int i = 0; i < number; i++)
        {
          Console.WriteLine(ADD_TO_THE_STORAGE + (i + 1));
          storage.StoreTheProduct(builder.Build(input.EnterTheTypeOfProduct(), input.EnterTheNameOfProduct(), input.EnterTheAmountOfProduct(), input.EnterThePriceOfProduct()));
        }
        do
        {
          Console.Write(ENTER_THE_COMMAND);
          enteredCommand = Console.ReadLine();
          ICommand command;
          if (enteredCommand.Equals(COUNT_TYPES))
          {
            command = new CountTypesCommand(storage.listOfProducts);
            Console.WriteLine(RESULT + command.Count());
          }
          else if (enteredCommand.Equals(COUNT_ALL))
          {
            command = new CountAllCommand(storage.listOfProducts);
            Console.WriteLine(RESULT + command.Count());
          }
          else if (enteredCommand.Equals(AVERAGE_PRICE))
          {
            command = new AveragePriceCommand(storage.listOfProducts);
            Console.WriteLine(RESULT + command.Count());
          }
          else if (enteredCommand.Contains(AVERAGE_PRICE))
          {
            foreach (var product in storage.listOfProducts)
            {
              if (enteredCommand.Equals(AVERAGE_PRICE + ' ' + product.Type))
              {
                command = new AveragePriceCommand(storage.GetProcessingList(storage.listOfProducts, product.Type), product.Type);
                Console.WriteLine(RESULT + command.Count());
                break;
              }
              else if (ReferenceEquals(storage.listOfProducts[storage.listOfProducts.Count - 1], product))
              {
                Console.WriteLine(TYPE_DOES_NOT_EXIST);
              }
            }
          }
          else if (enteredCommand.Equals(EXIT))
          {
            return;
          }
          else
          {
            Console.WriteLine(COMMAND_DOES_NOT_EXIST);
          }
        } while (!enteredCommand.Equals(EXIT));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}