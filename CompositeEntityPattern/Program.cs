namespace CompositeEntityPattern
{
    public class Program
    {
        static void Main()
        {
            Composite pc = new Composite("Desktop");
            Composite pcCase = new Composite("Case");
            Composite pcPeripherals = new Composite("Peripherals");
            Composite mainBoard = new Composite("Mainboard");
            
            // mainboard
            Leaf ram = new Leaf("RAM", 1000);
            Leaf cpu = new Leaf("CPU", 3000);
            mainBoard.Add(ram);
            mainBoard.Add(cpu);

            // case
            Leaf hdd = new Leaf("HDD", 1000);
            pcCase.Add(mainBoard);
            pcCase.Add(hdd);
            
            // peripherals
            Leaf mouse = new Leaf("Mouse", 100);
            Leaf keyboard = new Leaf("Keyboard", 100);
            pcPeripherals.Add(mouse);
            pcPeripherals.Add(keyboard);

            // create pc
            pc.Add(pcPeripherals);
            pc.Add(pcCase);

            Console.WriteLine("\nDesktop information: ");
            pc.DisplayPrice();
            Console.WriteLine("\tTotal Price: " +pc.GetPrice());
        }
    }
}


