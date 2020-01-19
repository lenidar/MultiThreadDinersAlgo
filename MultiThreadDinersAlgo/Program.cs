using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace MultiThreadDinersAlgo
{
    class Program
    {
        static Random _rnd = new Random();
        static bool[] _forks = new bool[] { true, true, true, true, true };

        static void Main(string[] args)
        {
            Thread[] diners = new Thread[]
            {
                new Thread(new ThreadStart(Diner1))
            ,   new Thread(new ThreadStart(Diner2))
            ,   new Thread(new ThreadStart(Diner3))
            ,   new Thread(new ThreadStart(Diner4))
            ,   new Thread(new ThreadStart(Diner5))
            };

            for(int x = 0; x < diners.Length; x++)
            {
                diners[x].Start();
                Thread.Sleep(100);
            }

            Console.ReadKey();

            for (int x = 0; x < diners.Length; x++)
            {
                diners[x].Abort();
                Console.WriteLine("Diner" + (x+1) + " has been stopped");
            }
        }

        static void Diner1()
        {
            int stat = 1; // 1 = waiting, 0 = rest, 2 = active
            int timer = 0;

            Console.WriteLine("Starting Diner1");
            while(true)
            {
                switch(stat)
                {
                    case 0:
                        timer--;
                        if(timer == 0)
                        {
                            stat = 1;

                            Console.WriteLine("Diner1 is waiting to be activated");
                        }
                        break;
                    case 1:
                        if (_forks[0] && _forks[1])
                        {
                            _forks[0] = false;
                            _forks[1] = false;

                            stat = 2;
                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner1 is now active for " + timer);
                        }
                        break;
                    case 2:
                        timer--;

                        if (timer == 0)
                        {
                            stat = 0;
                            _forks[0] = true;
                            _forks[1] = true;

                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner1 is now resting for " + timer);
                        }
                        break;
                }
                Thread.Sleep(1000);
            }
        }

        static void Diner2()
        {
            int stat = 1; // 1 = waiting, 0 = rest, 2 = active
            int timer = 0;

            Console.WriteLine("Starting Diner2");
            while (true)
            {
                switch (stat)
                {
                    case 0:
                        timer--;
                        if (timer == 0)
                        {
                            stat = 1;

                            Console.WriteLine("Diner2 is waiting to be activated");
                        }
                        break;
                    case 1:
                        if (_forks[1] && _forks[2])
                        {
                            _forks[1] = false;
                            _forks[2] = false;

                            stat = 2;
                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner2 is now active for " + timer);
                        }
                        break;
                    case 2:
                        timer--;

                        if (timer == 0)
                        {
                            stat = 0;
                            _forks[1] = true;
                            _forks[2] = true;

                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner2 is now resting for " + timer);
                        }
                        break;
                }
                Thread.Sleep(1000);
            }
        }

        static void Diner3()
        {
            int stat = 1; // 1 = waiting, 0 = rest, 2 = active
            int timer = 0;

            Console.WriteLine("Starting Diner3");
            while (true)
            {
                switch (stat)
                {
                    case 0:
                        timer--;
                        if (timer == 0)
                        {
                            stat = 1;

                            Console.WriteLine("Diner3 is waiting to be activated");
                        }
                        break;
                    case 1:
                        if (_forks[2] && _forks[3])
                        {
                            _forks[2] = false;
                            _forks[3] = false;

                            stat = 2;
                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner3 is now active for " + timer);
                        }
                        break;
                    case 2:
                        timer--;

                        if (timer == 0)
                        {
                            stat = 0;
                            _forks[2] = true;
                            _forks[3] = true;

                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner3 is now resting for " + timer);
                        }
                        break;
                }
                Thread.Sleep(1000);
            }
        }

        static void Diner4()
        {
            int stat = 1; // 1 = waiting, 0 = rest, 2 = active
            int timer = 0;

            Console.WriteLine("Starting Diner4");
            while (true)
            {
                switch (stat)
                {
                    case 0:
                        timer--;
                        if (timer == 0)
                        {
                            stat = 1;

                            Console.WriteLine("Diner4 is waiting to be activated");
                        }
                        break;
                    case 1:
                        if (_forks[3] && _forks[4])
                        {
                            _forks[3] = false;
                            _forks[4] = false;

                            stat = 2;
                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner4 is now active for " + timer);
                        }
                        break;
                    case 2:
                        timer--;

                        if (timer == 0)
                        {
                            stat = 0;
                            _forks[3] = true;
                            _forks[4] = true;

                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner4 is now resting for " + timer);
                        }
                        break;
                }
                Thread.Sleep(1000);
            }
        }

        static void Diner5()
        {
            int stat = 1; // 1 = waiting, 0 = rest, 2 = active
            int timer = 0;

            Console.WriteLine("Starting Diner5");
            while (true)
            {
                switch (stat)
                {
                    case 0:
                        timer--;
                        if (timer == 0)
                        {
                            stat = 1;

                            Console.WriteLine("Diner5 is waiting to be activated");
                        }
                        break;
                    case 1:
                        if (_forks[4] && _forks[0])
                        {
                            _forks[4] = false;
                            _forks[0] = false;

                            stat = 2;
                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner5 is now active for " + timer);
                        }
                        break;
                    case 2:
                        timer--;

                        if (timer == 0)
                        {
                            stat = 0;
                            _forks[4] = true;
                            _forks[0] = true;

                            timer = _rnd.Next(10) + 1;

                            Console.WriteLine("Diner5 is now resting for " + timer);
                        }
                        break;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
