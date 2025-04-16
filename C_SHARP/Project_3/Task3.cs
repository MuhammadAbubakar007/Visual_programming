using System;

public class VariableExample
{
    // Class-level (global) variable
    private string _message = "Global greeting";
    
    public void ShowMessages()
    {
        // Local variable
        string temporaryMessage = "Local greeting";
        
        Console.WriteLine(_message);
        Console.WriteLine(temporaryMessage);
    }

    public static void Main()
    {
        VariableExample example = new VariableExample();
        example.ShowMessages();
    }
}