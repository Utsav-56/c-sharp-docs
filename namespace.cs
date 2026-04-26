using System;
using ns1;
using ns2;

/*
What are namespaces in C#?
A namespace is a way to organize code and prevent naming conflicts in C#. 
It is a container that holds a set of related classes, interfaces, structs, enums, and other namespaces. 

Features of namespaces in C#:
1. Organization: Namespaces help to organize code into logical groups, making it easier to manage
2. Avoiding Naming Conflicts: By using namespaces, you can avoid naming conflicts between classes or other types that may have the same name.
3. Access Control: Namespaces can be used to control the accessibility of types. You can specify which types are accessible from outside the namespace.


THE `using` DIRECTIVE:
    - The `using` directive is used to import a namespace into a C# file
    - this allows you to use the types defined in that namespace without having to specify the fully qualified name of the type.

For example, if you have a class named `Animal` in a namespace called `ns1`, 
you can use the `using` directive to import the `ns1` namespace and then use the `Animal` class directly without having to write `ns1.Animal` every time.
*/


namespace ns1
{
    class Animal
    {
        public void sound()
        {
            Console.WriteLine("ANIMAL MAKES SOUND");
        }
    }

}

namespace ns2
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("DOG EATS FOOD");
        }
    }

}

/*
Look above code, we have two namespaces ns1 and ns2, both contain a class named Animal with a method sound().
But because they are in different namespaces, there is no conflict between the two classes.

To use the classes from these namespaces, 
1. we can use the fully qualified name of the class, which includes the namespace. E.G ns1.Animal animal1 = new ns1.Animal();
2. Or we can use the 'using' directive to import the namespace and then use the class directly. 

fOLLOWING IS THE EXAMPLE OF USING THE same class but from different namespaces:

*/


class Program
{
    static void Main(string[] args)
    {
        ns1.Animal animal1 = new ns1.Animal();
        animal1.sound(); // Output: ANIMAL MAKES SOUND

        ns2.Animal animal2 = new ns2.Animal();
        animal2.eat(); // Output: DOG EATS FOOD

        // Using 'using' directive to import the namespace
        // the using must be at the top of the file, above the namespace declaration

        Animal animal3 = new Animal(); // This will cause a conflict because both namespaces have a class named Animal
        animal3.eat(); // This will cause a compile-time error because the compiler does not know which Animal class to use


    }
}

