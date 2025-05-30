using SmartHomeNotificationSystem.Models;
using SmartHomeNotificationSystem.Sevices;

var door1 = new DoorSensor();
var light1 = new LightSwitch();
var motion1 = new MotionSensor();

var hub = new NotificationHub();

hub.Subscribe(door1);
hub.Subscribe(light1);
hub.Subscribe(motion1);

await Task.Delay(1500);
motion1.Trigger();

await Task.Delay(3000);
door1.Trigger();

await Task.Delay(2000);
light1.Trigger();

Console.ReadKey();