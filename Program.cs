using System;
namespace HospitalEmergencyRoomSystem;

// PATIENT CLASS   
public class Patient
{
    public string PatientId { get; private set; }
    public string FullName { get; private set; }
    public int Age { get; private set; }
    public string MedicalConcern { get; private set; }
    public int PriorityLevel { get; private set; }

    public Patient(string id, string name, int age,
                   string concern, int priority)
    {
        PatientId = id;
        FullName = name;
        Age = age;
        MedicalConcern = concern;
        PriorityLevel = priority;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("---------------------------------"); 
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + FullName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Medical Concern: " + MedicalConcern);
        Console.WriteLine("Priority Level: " + PriorityLevel);
        Console.WriteLine("---------------------------------");
    }
    public override string ToString()
    {
        return PatientId + " - " + FullName + "(Priority: " + PriorityLevel + ")";
    }
}