#include <iostream>
#include <math.h>
#include "calcPi.h"


using namespace std;

void greeting ();
void myName(string,int);

int main()
{
    //double pi = 2*acos(0.0);
    greeting();
    //cout << pi << endl;
    cout << "Pi = " << findingPi() << endl;
    return 0;
}

void greeting ()
{
    int age = 23;
    string name = "Luis";
    cout << "Hello world!" << endl;
    cout << "This is my first C++ program after a few years!" << endl;
    myName(name,age);
}
void myName (string name,int age)
{
    cout << "My name is " << name << ". I am " << age << " years old."  << endl;
}
