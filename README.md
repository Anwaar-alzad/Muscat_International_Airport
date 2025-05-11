# ✈️ Entity Framework Assignment – Muscat International Airport

## 📖 Description

Muscat International Airport is located in the capital city of Oman. It’s an international airport that serves thousands of passengers daily.

This assignment focuses on building a simple airport management system using **C# Console Application**, **Entity Framework Core**, and **SQL Server**. The goal is to model the main components of the airport such as airlines, flights, passengers, baggage, officers, terminals, gates, and checkpoints.

---

## 📋 Requirements

### Airline
- Name
- Contact Number
- Contact Email
- Person representing the airline in the airport

> Each airline operates multiple flights daily.

### Flight
- Departure City
- Destination City
- Departure Time
- Arrival Time
- Flight Status
- Gate Number

### Passenger
- First Name
- Last Name
- Date of Birth
- Gender
- Nationality
- Passport Number
- Contact Phone
- Contact Email

> Each passenger can have multiple baggage items.

### Baggage
- Baggage ID
- Passenger ID (foreign key)
- Weight
- Tracking Number

### Officer
- Personal ID
- First Name
- Last Name
- Position
- Department
- Contact Phone
- Contact Email

> Officers work at security checkpoints.

### Terminal
- Terminal ID
- Terminal Name
- Capacity
- Location

> Each terminal contains multiple gates.

### Gate
- Gate ID
- Terminal ID (foreign key)
- Gate Number
- Airline ID (foreign key)
- Availability Status

### Security Checkpoint
- Checkpoint ID
- Terminal ID (foreign key)
- Terminal Name
- Passenger Capacity
- Location


