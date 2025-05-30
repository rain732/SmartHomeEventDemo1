# SmartHomeEventDemo1
# 🏠 SmartHomeNotificationSystem (.NET Console App)

A simple **event-driven Smart Home simulation** built with C# and .NET.  
This project demonstrates **Events**, **Delegates**, and the **Publisher/Subscriber pattern** using real-world-inspired smart devices.

---

## 🚀 What This Project Does

This app simulates a basic smart home system with the following components:

- **Devices (Publishers)**:
  - `DoorSensor`
  - `MotionSensor`
  - `LightSwitch`

- **NotificationHub (Subscriber)**:
  - Subscribes to any device that implements the `ISensor` interface
  - Responds to triggered events with custom notifications

Each device raises an event using a delegate, and the hub listens and reacts.

---

## 📸 Example Output

```text
Motion Detected!
[Notification] I am Motion,  A Motion was detected.

Door Opened!
[Notification] I am Door,  The Door was open

Light is On!
[Notification] I am Light,  The Light was On

🧠 Concepts Demonstrated
✅ C# Events & Delegates
✅ EventHandler
✅ Loose coupling using Interfaces
✅ Basic SOLID Principles (Liskov, Dependency Inversion)
✅ Timer-based simulation using async/await
✅ Separation of concerns in class design

🧩 File Structure

SmartHomeNotificationSystem/
│
├── Interfaces/
│   ├── ISensor.cs
|
├── Models/
│   ├── DoorSensor.cs
│   ├── LightSensor.cs
│   ├── MotionSensor.cs
│
├── Services/
│   └── NotificationHub.cs
│
└── Program.cs

🛠 How to Run

1. Clone the repo:
git clone https://github.com/rain732/SmartHomeEventDemo1.git
cd SmartHomeNotificationSystem

2. Build and run the project:
dotnet build
dotnet run


📚 Learnings & Use Cases
Understand how events work under the hood in C#

Implement a clean pub/sub pattern with loose coupling

Simulate real-world behavior in a console app

Serve as a base to extend into logging, UI, or IoT devices
