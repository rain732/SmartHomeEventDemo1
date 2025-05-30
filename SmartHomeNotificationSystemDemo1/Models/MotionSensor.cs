using SmartHomeNotificationSystem.Interfaces;

namespace SmartHomeNotificationSystem.Models;

public class MotionSensor : ISensor
{
    public event SensorEventHandler SensorTriggered;

    public void Trigger()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Motion Detected!");
        this.SensorTriggered?.Invoke(this, "A Motion was detected.");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return "I am Motion, ";
    }
}
