using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // using static directive

namespace Factories_Method
{
    //Both the Lion and Tiger classes will
    // implement the IAnima1 interface method.
    public interface IAnimal
    {
        void AboutMe();
    }
    // Lion class
    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is Lion.");
    }
    // Tiger class
    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is Tiger.");
    }

    //Both LionFactory and TigerFactory will use this.
    public abstract class AnimalFactory
    {
        /*
        Factory method lets a class defer instantiation to subclasses.
        The following method will create a Tiger or a Lion,
        but at this point it does not know whether it will get a Lion or a tiger.
        It will be decided by the subclasses i.e.LionFactory or TigerFactory.
        So, the following method is acting like a factory(of creation) .
        */
        public abstract IAnimal CreateAnima1();
    }
    //LionFactory is used to create Lions
    public class LionFactory : AnimalFactory
    {
        //Creating a Lion
        public override IAnimal CreateAnima1() => new Lion();
    }

    //TigerFactory is used to create Tiger
    public class TigerFactory : AnimalFactory
    {
        //Creating a Tiger
        public override IAnimal CreateAnima1() => new Tiger();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Factory Method Pattern Demo.***\n");
            //Create a list AnimalFactory included TigerFactory and LionFactory
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
            {
                new TigerFactory(),
                new LionFactory()
            };
            foreach (var animal in animalFactoryList)
            {
                animal.CreateAnima1().AboutMe();
            }
            ReadLine();
        }
    }
}
