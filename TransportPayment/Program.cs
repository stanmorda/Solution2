﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TransportPayment
{
    class Program
    {
        private static Queue<EventArgs> _testEventsQueue = new Queue<EventArgs>();
        static void Main(string[] args)
        {
            // Создать класс транспортная карта
            //     ○ определить в нем делегат и событие с аргументом строчного типа (string), которое будет уведомлять об
            // операции
            //     ○ реализовать методы Пополнение (при вызове метода передаем какой суммой пополняем карту) и
            //     Оплата (снимаем из баланса карты 30 руб)
            //     ○ реализовать вызов события и оповещение текстом о случившимся событии пополнения и оплаты
            //     ○ в строке события писать текущий баланс карты
            //     ● Создать экземпляр класса транспортная карта
            //     ○ подписаться на событие уведомления о операциях по транспортной карте
            //     ○ вызвать методы пополнения карты и оплаты по карте
            //     ○ при срабатывании события - писать текст события в консоль
            //     

            var card1 = new Card(s => Console.WriteLine(s));

            card1.TestEvent += (sender, eventArgs) =>
            {
                _testEventsQueue.Enqueue(eventArgs);
            };
            
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    card1.Pay(100);
                    Thread.Sleep(100);
                }
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (_testEventsQueue.TryDequeue(out var result))
                    {
                        // do some works
                    }
                }
            });



            card1.Add(100);
            card1.Pay(10);
            card1.Pay(10);
            card1.Pay(10);
            card1.Add(99);
            card1.Pay(10);
            card1.Pay(10);
            
            Console.WriteLine("Hello World!");
        }

        class Card
        {

            private readonly object _sync = new object();
            
            
            public List<decimal> History { get; set; }
            
            public decimal Balance { get; set; }

            // с помощью делегата
            public delegate void Notify(string message);

            //public void ConsoleNotify(Notify)

            // с помощью Action
            private Action<string> _notifyAction;

            // private Predicate<decimal> _predicate;

            //private Func<decimal, decimal> _calculateCashback;


            public event EventHandler TestEvent;
            

            public Card(Action<string> notifyAction)
            {
                _notifyAction = notifyAction;
            }

            public void Add(decimal summ)
            {
                
                Balance += summ;
                _notifyAction($"{Balance}");
                
            }

            public void Pay(decimal summ)
            {
                lock (_sync)
                {
                    Balance -= summ;
                    _notifyAction($"{Balance}");

                    // add to list
                }

                OnTestEvent();

            }


            protected virtual void OnTestEvent()
            {
                TestEvent?.Invoke(this, EventArgs.Empty);
            }
        }
    }
    
    
}