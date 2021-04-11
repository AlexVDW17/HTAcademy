// Pointers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Node.h"
using namespace std;
int main()
{
    /// cout is short for console out, and is pronounced "see-out". It is similar to console.write in C#
    /// endl is short for end of line, and will ensure the next thing we print is on its own line
    cout << "Inro to pointers" << endl;

    int a = 1;
    int b = 2;

    /// by using the syntax {data type}*, we create a pointer to a variable of that data type.
    /// for example, char* is a pointer to a character, int* points to an integer and car* might point to a custom data type of Car

    int* pointToA = &a;

    /// pointToA now "points" to the value stored in the variable a. We can change a as many times as we want, and pointToA will still "know" what that value is
    /// the & symbol in front of the a is a way to get the location of the variable. 
    /// A pointer points to the location a variable is stored. Even if we change a variable's value, the location stays the same
    
    cout << "The location of variable A is " << pointToA << endl;
    cout << "The value of variable A is " << *pointToA << endl;

    /// we use the *{pointer variable} syntax to "dereference" a pointer, or get the value it points to. 

    /// we can use the pointToA variable to directly modify the value of a

    *pointToA = 5;

    /// try to translate the above line: dereferenced pointToA = 5
    /// we know dereferenced pointer really means the value it points to, so we can translate this to a = 5

    cout << "The value of variable A is now " << a << endl;

    /// like any other variable, we can change the value of a pointer. For instance, we might be done with a and want to set our pointer to a new value

    pointToA = &b;

    /// now the a variable is out of the mix, and pointToA actually points to variable b! 
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
