using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating Leaf Objects
            IComponent hardDisk = new Leaf("Hard Disk", 20.00m);
            IComponent ram = new Leaf("RAM", 30.00m);
            IComponent cpu = new Leaf("CPU", 20.00m);
            IComponent mouse = new Leaf("Mouse", 20.00m);
            IComponent keyboard = new Leaf("Keyboard", 20.00m);

            //Creating composite objects
            Composite motherBoard = new Composite("Peripherals");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");
            
            //Creating tree structure
            //Adding CPU and RAM in Mother board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            //Adding mother board and hard disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            //Adding mouse and keyborad in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            //Adding cabinet and peripherals in computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);

            Console.WriteLine("--To display the Price of Computer--");
            computer.DisplayPrice();
            Console.WriteLine();

            Console.WriteLine("--To display the Price of Keyboard--");
            keyboard.DisplayPrice();
            Console.WriteLine();

            Console.WriteLine("--To display the Price of Cabinet--");
            cabinet.DisplayPrice();
            Console.Read();
        }
    }
}
