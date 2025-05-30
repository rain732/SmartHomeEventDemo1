using SmartHomeNotificationSystem.Interfaces;

namespace SmartHomeNotificationSystem.Models;

public class LightSwitch : ISensor
{
    public event SensorEventHandler SensorTriggered;

    public void Trigger()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Light is On!");
        if(SensorTriggered != null )
            this.SensorTriggered(this, "The Light was On");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return "I am Light, ";
    }
}
