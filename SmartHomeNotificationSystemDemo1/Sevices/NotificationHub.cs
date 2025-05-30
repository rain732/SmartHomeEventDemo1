using SmartHomeNotificationSystem.Interfaces;

namespace SmartHomeNotificationSystem.Sevices;

public class NotificationHub
{
    public void Subscribe(ISensor sensor)
    {
        sensor.SensorTriggered += OnSensorTriggered;
    }

    public void Unsubscribe(ISensor sensor)
    {
        sensor.SensorTriggered -= OnSensorTriggered;
    }

    public void OnSensorTriggered(ISensor sender, string message)
    {
        Console.WriteLine($"[Notification] {sender.ToString()} {message}");
        File.AppendAllText("logs.txt", $"{DateTime.Now}: {message}\n");
    }
}
