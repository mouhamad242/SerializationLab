using System;

public class Event
{
    public int EventNumber { get; set; }
    public string Location { get; set; }
    public string EventName { get; set; }
}

class Program
{
    static void Main()
    {
        // Step 2: Create an Event object and assign values
        Event myEvent = new Event
        {
            EventNumber = 1,
            Location = "Calgary",
            EventName = "Tech Competition"
        };

        // Step 3 & 4: Instead of serialization, just manually format as a string
        string eventData = FormatEvent(myEvent);
        Event deserializedEvent = ParseEvent(eventData);

        // Print deserialized object data
        Console.WriteLine(deserializedEvent.EventNumber);
        Console.WriteLine(deserializedEvent.Location);
        Console.WriteLine(deserializedEvent.EventName);

        // Step 5: Simulating file read with a string
        ReadFromString("Hackathon");
    }

    // Simulates serialization by formatting data as a string
    static string FormatEvent(Event obj)
    {
        return obj.EventNumber + ";" + obj.Location + ";" + obj.EventName;
    }

    // Simulates deserialization by parsing the formatted string
    static Event ParseEvent(string data)
    {
        string[] parts = data.Split(';');
        return new Event
        {
            EventNumber = int.Parse(parts[0]),
            Location = parts[1],
            EventName = parts[2]
        };
    }

    // Simulating ReadFromFile but using a string (for mobile compatibility)
    static void ReadFromString(string word)
    {
        Console.WriteLine("\nIn Word: " + word);
        Console.WriteLine("The First Character is: \"" + word[0] + "\"");
        Console.WriteLine("The Middle Character is: \"" + word[word.Length / 2] + "\"");
        Console.WriteLine("The Last Character is: \"" + word[word.Length - 1] + "\"");
    }
}
