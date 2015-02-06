using System;
using System.Linq;
using HumanStudnetWorker;
using System.Collections.Generic;

class StudentsWorkersExample
{
    public static void Main()
    {
        List<Studnet> students = new List<Studnet>() { new Studnet("Ivan", "Shishmanov", 251313021),
                                                       new Studnet("Dominik", "Stoyanov", 251313099),
                                                       new Studnet("Ivan", "Ivanov", 251313060),
                                                       new Studnet("Dimitar", "Petrov", 251313055),
                                                       new Studnet("Svetlin", "Nakov", 251313043),
                                                       new Studnet("Georgi", "Dimitrov", 251313045),
                                                       new Studnet("Georgi", "Klisarski", 251313050),
                                                       new Studnet("Ivan", "Ivanov", 251313040),
                                                       new Studnet("Dimitar", "Georgiev", 251313010),
                                                       new Studnet("Ivan", "Stoylov", 251313005),
                                                     };
        List<Worker> workers = new List<Worker>() { new Worker("Dimitar", "Stoyanov", 500, 8),
                                                    new Worker("Damyan", "Stoyanov", 1000, 8),
                                                    new Worker("Jhon", "Grifin", 600, 8),
                                                    new Worker("Petur", "Ivanov", 6000, 8),
                                                    new Worker("Stoil", "Ivanov", 5500, 8),
                                                    new Worker("Georgi", "Stoyanov", 5000, 8),
                                                    new Worker("Ognqn", "Draganov", 4000, 8),
                                                    new Worker("Nikolay", "Nikolov", 2000, 8),
                                                    new Worker("Ivan", "Petcanov", 8000, 8),
                                                    new Worker("Georgy", "Ivanov", 300, 8),
                                                  };
        IEnumerable<Studnet> studentsSorted = students.OrderBy(student => student.FacultyNumber);
        Console.WriteLine("Sorted student list by faculty number in ascending order");
        studentsSorted.ToList().ForEach(student => Console.WriteLine(student.FacultyNumber));
        Console.WriteLine();
        Console.WriteLine("Sorted work list by money per hour in descending order");
        IEnumerable<Worker> workersSorted = workers.OrderBy(worker => worker.MoneyPerHour()).Reverse();
        workersSorted.ToList().ForEach(worker => Console.WriteLine(worker.MoneyPerHour()));
        Console.WriteLine();
        List<Studnet> st = studentsSorted.ToList();
        List<Worker> wk = workersSorted.ToList();
        List<Human> finalList = new List<Human>();
        finalList.AddRange(st);
        finalList.AddRange(wk);
        Console.WriteLine("Sorted merge list by first name");
        finalList.OrderBy(student => student.FirstName);
        finalList.ForEach(student => Console.WriteLine(student.FirstName));
        Console.WriteLine();
        Console.WriteLine("Sorted merge list by last name");
        finalList.OrderBy(student => student.LastName);
        finalList.ForEach(studnet => Console.WriteLine(studnet.LastName));
    }
}

