namespace SmartHomeNotificationSystem.Interfaces;

public interface ISensor
{
    event SensorEventHandler SensorTriggered;
    void Trigger();
}
public delegate void SensorEventHandler(ISensor sensor, string text);