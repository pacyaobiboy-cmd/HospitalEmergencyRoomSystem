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

// Custom Stack ADT
// LIFO    (Last In First Out)
public class CustomStack
{
    private string[] items;
    private int top;

    public CustomStack(int capacity)
    {
        items = new string[capacity];
        top = -1;
    }
    public bool IsEmpty()
    {
        return top == -1;
    }
    public bool Push(string item)
    {
        if (top == items.Length - 1)
            return false;
        top++;
        items[top] = item;
        return true;
    }
    public string Pop()
    {
        if (IsEmpty())
            return null;
        string item = items[top];
        top--;
        return item;
    }
    public string Peek()
    {
        if (IsEmpty())
            return null;
        return items[top];
    }
    public void DisplayStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No Action History Available.");
            return;
        }
        Console.WriteLine("\nAction History:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(items[i]);
        }
    }
}

//CUSTOM PRIORITY QUEUE ADT
public class CustomPriorityQueue
{
    private Patient[] items;
    private int[] priorities;
    private int count;

    public CustomPriorityQueue(int capacity)
    {
        items = new Patient[capacity];
        priorities = new int[capacity];
        count = 0;
    }
    public bool IsEmpty()
    {
        return count == 0;
    }
    public bool Enqueue(Patient patient, int priority)
    {
        if(count == items.Length)
            return false;
        
        int position = count;

        while (position > 0 && priorities[position - 1] < priority)
        {
            items[position] = items[position - 1];
            priorities[position] = priorities[position - 1];
            position--;
        }
        items[position] = patient;
        priorities[position] = priority;
        count++;
        return true;
    }
    public Patient Dequeue()
    {
        if (IsEmpty())
            return null;
        Patient patient = items[0];
        for (int i = 1; i < count; i++)
        {
            items[i - 1] = items[i];
            priorities[i - 1] = priorities[i];
        }
        count--;
        items[count] = null;
        priorities[count] = 0;
        return patient;
    }
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No Emergency Patient Waiting.");
            return;
        }
        Console.WriteLine("\nEMEREGENCY TRIAGE:");
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine(items[i] + " - Priority " + priorities[i]);
        }

    }
}
