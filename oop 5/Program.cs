using oop_3;
using System.Diagnostics;

namespace oop_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1:

            #region Q01:

            /*Q1 : What is an interface in C#?
             * Why do we use interfaces instead of depending on concrete classes directly? 
             * Mention at least three benefits of using interfaces.
             */

            // contract that a class must follow with no impelemntation
            //Enable multiple inheritance ,Enable polymorphism without inheritance, loose coupling & testability




            #endregion



            #region Q02 :


            //a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?

            //    the both have the same Greet , the class use the one Greet to the two interfaces


            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?

            // by using the explicit implementation


            //c) After applying your fix, can you call Greet() directly on a Translator object (e.g. translator.Greet())? Why or why not? How do you call each version?

            // no i can only use them by an interface reference , like : englishSpeaker.Greet();

            #endregion


            #region Q03:

            /*
             Q3 : Explain the difference between a shallow copy and a deep copy.
            When would you use each one? 
            What is the risk of using a shallow copy when the object has reference-type fields?

             */

            // shallow make  a copy but the reference shared the same field , deep copy make a duplicate place

            // use shallow if the performance is important and if there is no reference 
            // use deep copy if the modifications should not affect original

            // the risk that the two share the same reference and the changes will affect both






            #endregion


            #region Q04:
            /*
               class Department { public string Name; }
                class Employee
                {
                    public string Title;
                    public Department Dept;
                    public Employee ShallowCopy() => (Employee)this.MemberwiseClone();
                }

                var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
                var e2 = e1.ShallowCopy();
                e2.Title = "QA";
                e2.Dept.Name = "Testing";

                Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
                Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");
             */

            // e1.Title : Dev     e1.Dept.Name : Testing

            // e2.Title : QA      e2.Dept.Name : Testing

            // the title is string with is immutable so when modifu will create new one
            // the dept.name is refernce wich the change will affect both 



            #endregion

            #endregion


            #region Part 2:

            Cinema cinema = new Cinema("Star");
            cinema.OpenCinema();

            StandardTicket t1 = new StandardTicket("Inception",  80 ,"A5");



            VIPTicket t2 = new VIPTicket("Avengers", 200, true);

            IMAXTicket t3 = new IMAXTicket("Avengers2", 123, true);       

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);   
            cinema.AddTicket(t3);


            cinema.Print();




            Console.WriteLine("\n--- Clone Test ---");

            VIPTicket copyVip = (VIPTicket)t2.Clone();
            copyVip.MovieName = "Interstellar";
            copyVip.Cancel();

            Console.Write("Original : ");
            t2.Print();
            Console.Write("Clone    : ");
            copyVip.Print();

            t1.Cancel();
            Console.WriteLine("\n--- After Cancellation ---");
            t1.Print();



            Console.WriteLine("\n--- Booking Helper ---");

            IPrintable[] printableArray = new IPrintable[] { t1, t2, t3 };
            BookingHelper.PrintAll(printableArray);

            cinema.CloseCinema();

            #endregion
        }
    }
}
