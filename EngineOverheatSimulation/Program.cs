using EngineOverheatSimulation;

IEngine first = new FirstTestEngine();
double value;
bool success;
do
{
    Console.Write("Enter a temperature: ");
    success = double.TryParse(Console.ReadLine(), out value);
    if (!success)
    {
        Console.WriteLine("Invalid value. Try again.");
    }
} while (!success);
EngineSimulation simulation = new EngineSimulation(first, value);
simulation.StartTest();
Console.ReadKey();
