using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            var lift = new Lift();
            lift.floor = 15;
            lift.Gruz = 4;
            lift.GetInfo();
            Console.WriteLine($"Лифт на {lift.level} этаже ");
            Console.WriteLine("Выберите нужный вам этаж");
            input=Convert.ToInt32(Console.ReadLine());
            lift.Go(input);
            
        }
    }
    public class Lift
    { 
        public int level { get; private set; }
        public States State { get; private set; }
        public int floor; //Этажность здания
        private int gruz; //Грузоподъемность 

        public Lift()
        {
            level = 1;

        }
        public enum States
        {
            GoingUp,
            GoingDown,
            Stoped
        }


        public void Go(int Level)
        {
            State = States.GoingUp;
            OpenDoor();
            if (Level > 15 || Level < 1)
            {
                Console.WriteLine("Это несуществующий этаж");
            }
            else
            {
                Console.WriteLine("Going up to:{0}", Level);
                
            }
            

            CloseDoor();
        }


        public void Down(int Lavel)
        {
            State = States.GoingDown;
            OpenDoor();
            Console.WriteLine("Going down to:{0}", Lavel);
            
           
            CloseDoor();

        }

        private void OpenDoor()
        {
            Console.WriteLine("Door opening");
        }

        private void CloseDoor()
        {
            Console.WriteLine("Door cloding, at floor: {0}",this.level);
        }


        public int Gruz
        {
            set
            {
                if (value > 4)
                {
                    Console.WriteLine("Людей в лифте не должно быть больше 4");
                }
                else
                {
                    gruz = value;
                }
            }

            get
            { 
                return gruz;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Этажей в зданий:{floor}   Грузоподъемнось:{gruz}");
        }
    }
}
