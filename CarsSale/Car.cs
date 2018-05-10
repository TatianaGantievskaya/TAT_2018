using System.Runtime.Serialization;

namespace CarsSale
{
  /// <summary>
  /// Car.
  /// </summary>
  [DataContract]
  public class Car
  {
    [DataMember]
    public string Make { get; set; }
    [DataMember]
    public string Model { get; set; }
    [DataMember]
    public string Style { get; set; }
    [DataMember]
    public string TransmissionType { get; set; }
    [DataMember]
    public string EngineType { get; set; }
    [DataMember]
    public string EngineCapacity { get; set; }
    [DataMember]
    public string EnginePower { get; set; }
    [DataMember]
    public string ClimateManagement { get; set; }
    [DataMember]
    public string InteriorType { get; set; }

    public Car(string make, string model, string style, string transmissionType, string engineType, string engineCapacity, string enginePower, string climateManagement, string interiorType)
    {
      Make = make;
      Model = model;
      Style = style;
      TransmissionType = transmissionType;
      EngineType = engineType;
      EngineCapacity = engineCapacity;
      EnginePower = enginePower;
      ClimateManagement = climateManagement;
      InteriorType = interiorType;
    }
  }
}