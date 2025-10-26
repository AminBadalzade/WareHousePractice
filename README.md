# Warehouse Management System Practice

A console-based C# application simulating a warehouse processing queue for hardware items.  
I created this project as a self-learning exercise to explore event-driven programming, queues, and object-oriented design in C#.

---

## Features

- Queue-based processing of hardware items such as Drills, Ladders, Hammers, and Paint Brushes.  
- Real-time console updates showing items added to the queue and their processing status.  
- Batch processing of items, automatically processed when a batch size is reached.  
- Displays item details including `Id`, `Name`, `Type`, `Quantity`, and `UnitValue`.  
- Demonstrates usage of **events** to notify when queue updates occur.  

---

## Technologies

- C#  
- .NET Console Application  
- Object-Oriented Programming (OOP)  
- Event-driven programming  

---

## What It Demonstrates

This project helped me practice:  

- Implementing custom generic queues with event notifications.  
- Real-time updates in console applications.  
- Designing an inheritance hierarchy for hardware items using interfaces and abstract classes.  
- Batch processing logic for queues.  
- Simulating a warehouse inventory system in memory without a database.  

---

## How It Works

1. Hardware items such as `Drill`, `Hammer`, `Ladder`, and `PaintBrush` are added to a `CustomQueue`.  
2. Each addition triggers a queue event, displaying the real-time status and the list of queued items.  
3. When the queue reaches a defined batch size, items are automatically processed.  
4. Item details including ID, name, type, quantity, and value are printed neatly in a tabular format in the console.
