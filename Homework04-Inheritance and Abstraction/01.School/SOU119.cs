using System;
using SchoolSpace;
using System.Collections.Generic;

class SOU119
{
    static void Main()
    {
        Student dimitar = new Student("Dimitar Stoyanov", 11);
        Student dominik = new Student("Dominik Stoyanov", 10);

        Teacher rozaBuchvarova = new Teacher("Roza Buchvarova");
        Teacher marinaBozadjieva = new Teacher("Marina Bozadjieva");

        Class a12 = new Class("12A");
        Class c10 = new Class("10C");

        Discipline history = new Discipline("History", 10);
        Discipline matematic = new Discipline("Matematics", 14);
        Discipline english = new Discipline("English", 12);

        rozaBuchvarova.Disciplines = new List<Discipline>() { history, matematic };
        marinaBozadjieva.Disciplines = new List<Discipline>() { history, english };

        history.Students = new List<Student>() { dimitar, dominik };
        matematic.Students = new List<Student>() { dimitar, dominik };
        english.Students = new List<Student>() { dimitar, dominik };

        School sou119 = new School();
        sou119.Students = new List<Student>() { dimitar, dominik };
        sou119.Teachers = new List<Teacher>() { rozaBuchvarova, marinaBozadjieva };
        sou119.Classes = new List<Class>() { a12, c10 };
        sou119.Disciplines = new List<Discipline>() { history, matematic, english };

        Details statsDimitar = new Details(dimitar, a12, new List<Teacher>() { rozaBuchvarova, marinaBozadjieva}, new List<Discipline>() { history, matematic, english } );

        Console.WriteLine("All the students in 119 SOU are: ");
        sou119.Students.ForEach(studnet => Console.WriteLine(studnet.Name));
        Console.WriteLine();
        Console.WriteLine("All the teachers in 119 SOU are: ");
        sou119.Teachers.ForEach(teacher => Console.WriteLine(teacher.Name));
        Console.WriteLine();
        Console.WriteLine("All the classes in 119 SOU are: ");
        sou119.Classes.ForEach(clas => Console.WriteLine(clas.UniqueTextIndentifier));
        Console.WriteLine();
        Console.WriteLine("All the discipline in 119 SOU are: ");
        sou119.Disciplines.ForEach(discipline => Console.WriteLine(discipline.Name));
        Console.WriteLine();
        Console.WriteLine("The pupil {0}, is in {1} class", statsDimitar.Studnets.Name, statsDimitar.Classes.UniqueTextIndentifier);
        Console.WriteLine();
        Console.WriteLine("{0}, has the follow teachers: ", statsDimitar.Studnets.Name);
        statsDimitar.Teachers.ForEach(teacher => Console.WriteLine(teacher.Name));
        Console.WriteLine();
        Console.WriteLine("{0}, is learning: ", statsDimitar.Studnets.Name);
        statsDimitar.Disciplines.ForEach(discipline => Console.WriteLine(discipline.Name + " " + discipline.NumberOfLectures + " per week"));
    }
}

