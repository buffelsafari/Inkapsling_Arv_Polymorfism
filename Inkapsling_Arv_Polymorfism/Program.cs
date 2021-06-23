using Inkapsling_Arv_Polymorfism.Error;
using Inkapsling_Arv_Polymorfism.Zoo;
using Inkapsling_Arv_Polymorfism.Zoo.Birds;
using System;
using System.Collections.Generic;

namespace Inkapsling_Arv_Polymorfism
{
    class Program
    {
        // svar:
        // 3.2.13 I Bird classen.
        // 3.2.14 I animal classen
        // 3.3.9 för att Horse objectet inte är ett Dog object, även om båda är animals ärver inte Horse ifrån sama gren som Dog
        // 3.3.10 av Animal classen, alla djur tillhör Animal
        // 3.3.13 override ordet gör att funktionspekaren refererar till den senast overridade funktionen i arvskedjan, och ifrån den overridade funktionen kan bas funktionen anropas.
        // 3.3.17 För att alla animals har inte den metoden, därför tillåts inte det om inte Animal castas om till Dog
        // 3.4.11 Kan leda till flexiblare och mindre kod.
        // 3.4.12 lättare att lägga till nya saker, kanske enklare att ändra koden då abstraktionerna minskar ner på dupliceringen av kod
        // 3.4.13 Det är tillåtet att ärva ifrån flertalet interface men endast en abstract class(i c#), ett interface innehåller ingen kod, en abstract klass kan innehålla kod men varken
        //        interface eller abstract class kan vara objectinstancer.


        static void Main()
        {
            //Person p1 = new Person();

            PersonHandler handler = new PersonHandler();
            List<Person> crew = new List<Person>();
            try
            {
                crew.Add(handler.CreatePerson(42, "Ola", "Banan", 1.80, 75.123));
                crew.Add(handler.CreatePerson(22, "Berra", "Bamyl", 1.50, 63));
                crew.Add(handler.CreatePerson(22, "Karro", "Kanin", 1.60, 163.1));

                Person agent = handler.CreatePerson(33, "Sam", "Sung", 1.78, 68.8);
                handler.SetAge(agent, 34);
                handler.SetName(agent, "Björne", "Blackhat");
                handler.SetHeight(agent, 1.90);
                handler.SetWeight(agent, 70);

                crew.Add(agent);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            foreach (Person p in crew)
            {
                handler.PrintPersonalInfo(p);
                Console.WriteLine("----------------------------------");
            }

            //-----------------------------------the animal part---------------------------------------------------
            int owner = 0;
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Dog("fido", owner++, 23, 0.5, true));
            animalList.Add(new Hedgehog("sonic", owner++, 2, 0.2, 1245));
            animalList.Add(new Horse("Adolf", owner++, 200, 2.3, 0.4));
            animalList.Add(new Wolf("Lupus", owner++, 40, 1.4, Wolf.Status.alphaWolf));
            animalList.Add(new WolfMan("Anthony", owner++, 98, 2, Wolf.Status.loneWolf));
            animalList.Add(new Bird("Peepers1", owner++, 1, 0.31, 1));
            animalList.Add(new Flamingo("Peepers2", owner++, 1, 0.31, 1, 0.6));
            animalList.Add(new Pelican("Dunedee", owner++, 1, 0.51, 3, 5));
            animalList.Add(new Swan("Elizabeth", owner++, 1, 0.49, 2, 0.7));
            animalList.Add(new Worm("Jim", owner++, 0.01, 0.01, 0.999));


            Console.WriteLine("---------------sounds-------------------");
            foreach (Animal a in animalList)
            {
                a.DoSound();
                if(a is Zoo.Person)
                {
                    ((Zoo.Person)a).Talk();
                }
            }

            Console.WriteLine("-----------------stats-----------------");
            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Stats());
            }

            Console.WriteLine("-----------------stats(dogs only)-----------------");
            foreach (Animal a in animalList)
            {
                if (a is Dog)
                {
                    Console.WriteLine(a.Stats());
                }
            }

            Console.WriteLine("-----------------treats-----------------");
            foreach (Animal a in animalList)
            {
                if (a is Dog)
                {
                    Console.WriteLine(((Dog)a).GiveTreat());
                }
            }



            List<Dog> dogList = new List<Dog>();
            //dogList.Add(new Horse("Brunte", 0, 200, 2.00, 0.47));

            //-----------------------------------------------------------

            List<UserError> errorList = new List<UserError>();

            errorList.Add(new TextInputError());
            errorList.Add(new RangeInputError());
            errorList.Add(new NumericInputError());
            errorList.Add(new NullInputError());
            errorList.Add(new DivineTruthError());

            Console.WriteLine("----------------------errors-------------------------");
            foreach (UserError e in errorList)
            {
                Console.WriteLine(e.UEMessage());
            }

        }
    }
}
