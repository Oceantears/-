using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拓展的冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees=new Employee[]
            {
                new Employee("farfe",1532),
                new Employee("asfweaf0",48465),
                new Employee("fgwaege",164651),
                new Employee("esag584",6486),
                new Employee("feasge",98456)
            };
            CommonSort<Employee>(employees,Employee.Compare);
            foreach (Employee emps in employees)
            {
                Console.WriteLine(emps);
            }

            Console.ReadKey();
        }

        static void CommonSort<T>(T[] sortArray, Func<T, T, bool> compareMethod)    //用Func委托对泛型T内对象做比较
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i], sortArray[i + 1]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }

    class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public static bool Compare(Employee e1, Employee e2)
        {
            if (e1.Salary > e2.Salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()         //重写ToString方法
        {
            return Name + ":" + Salary;
        }
    }
}
