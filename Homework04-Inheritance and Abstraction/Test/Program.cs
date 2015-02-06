using System;
using System.Collections.Generic;

class Program
{

    //public static void Main()
    //{
    //    var quacker = new RubberDuckQuack();
    //    var duck = new ConfigurableDuck(quacker);
    //    Console.WriteLine(duck.QuackIt());
    //    duck.Quackable = new WoodenDuckQuack();

    //    Console.WriteLine(duck.QuackIt());
    //}

    public class ConfigurableDuck
    {
        private IQuackable _quackable;
        public ConfigurableDuck(IQuackable quackable)
        {
            this._quackable = quackable;
        }
        public IQuackable Quackable
        {
            get
            {
                return this._quackable;
            }
            set
            {
                this._quackable = value;
            }
        }
        public string QuackIt()
        {
            return _quackable.Quack();
        }
    }
    public interface IQuackable
    {
        string Quack();
    }
    //public class RubberDuckQuack : IQuackable
    //{
    //    public string Quack()
    //    {
    //        return "Squeeq";
    //    }
    //}
    //public class WoodenDuckQuack : IQuackable
    //{
    //    public string Quack()
    //    {
    //        return "NA";
    //    }
    //}

    //public class Duck2  : Quackable2
    //{

    //    public override string Quack2()
    //    {
    //        return "Quack!";
    //    }
    //}

    //public abstract class Quackable2
    //{
    //    public abstract string Quack2();
    //}
 

}