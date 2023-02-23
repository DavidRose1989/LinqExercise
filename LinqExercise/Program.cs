using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            
            var sum = numbers.Sum();                //This will get you the sum of all of the numbers. You need the var sum to use as a containter for the numbers. 
            var avg = numbers.Average();            //This will get you the average of the numbers. Average and Sum is an extension method that works of IEnumerable.
            
            Console.WriteLine("sum");
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("Average");

            //TODO: Print the Average of numbers

            Console.WriteLine(avg);                 //When you print the average you use the variable avg because that's what's storing the numbers in it. 

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine();
            Console.WriteLine("Ascending");
            var ascending = numbers.OrderBy(num => num);

            foreach (var num in ascending)
            {
                Console.WriteLine(num);
            }



            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine();
            Console.WriteLine("descending");

            var decending = numbers.OrderByDescending(n => n);
           
            foreach  (var n in decending)
            {
                Console.WriteLine(n);
            }

           


            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine();    
            Console.WriteLine("Numbers greater than 6");

            var LargerThanSIx = numbers.Where(num => num > 6);
            foreach (var item in LargerThanSIx)
            {
                Console.WriteLine(item);
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine();
            Console.WriteLine("First 4 decending");
            foreach (var item in decending.Take(4))
            {
                Console.WriteLine(item);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine();
            Console.WriteLine("My age and numbers in decending order");
            numbers[4] = 33;
            var decending2 = numbers.OrderByDescending(n => n);

            foreach (var n in decending2)
            {
                Console.WriteLine(n);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine();
            var n2 = employees.Where(human => human.FullName[0] == 'C' || human.FullName[0] == 'S').OrderBy(human => human.FullName);

            Console.WriteLine("First names that start with C or S");

            foreach (var employee in n2) 
            { 
                Console.WriteLine(employee.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var n3 = employees.Where(human => human.Age > 26).OrderBy(human => human.FullName).ThenBy(human => human.Age);

            Console.WriteLine();
            Console.WriteLine("Order by Fullname and Age older than 26");

            foreach (var employee in n3)
            {
                Console.WriteLine($"{employee.Age} Age: {employee.FullName}" );

            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine();
            Console.WriteLine("Sum of YOE");
            var employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine();
            Console.WriteLine("Average of YOE");
            var employeeSAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);

            //TODO: Add an employee to the end of the list without using employees.Add()

            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Portebella";
            newEmployee.LastName = "Mushrooms";
            newEmployee.YearsOfExperience = 10;

            employees.Add(newEmployee);

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
