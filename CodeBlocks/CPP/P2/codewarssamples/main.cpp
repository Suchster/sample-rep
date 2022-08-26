// This Code will be used to complete the codewars sample problems.
// By Luis Angel Godinez Ramos
#include <iostream>
#include <limits>

using namespace std;

//Function declaration for each sample
void sample1();
void sample2();
int recursive_fib(int);

int main()
{

    int opt = 0;
    do{
    string samp1;
    system("cls"); cout << endl << endl;
    cout << "  Codewars Sample Menu  " << endl << endl;
    cout << " ___________________________" << endl;
    cout << "|| 1. Social Graces        ||" << endl;
    cout << "|| 2. Phi won't fly for pi ||" << endl;
    cout << " ___________________________" << endl;


    cout << "Choose an option: "; cin >> opt; system("cls");
    if(cin.fail()){cin.clear();cin.ignore(numeric_limits<streamsize>::max(), '\n'); opt=0;} //Validates int input.
        switch(opt){
        case 1:
            sample1();
            opt=0;
        break;
        case 2:
            sample2();
            cout<< recursive_fib(10);
            opt=0;
        break;
        default:
            system("cls");
            opt = 0;
        }
    }while(opt==0);
    return 0;
}

void sample1(){
    string samp1;
    cout << "|| Social Graces ||" << endl;
    cout << "PLease input your friends name: "; cin >>samp1;
    cout << "While we seem to disagree on this issue, " << samp1 << ", I respect your opinion and look forward to further discussion! " << endl;
    system("pause");
}

void sample2(){
    cout <<  "Fibonacci Series Altered" << endl;
    int f0,f1,fn,f,aux;
    cout << "Please enter f(0): "; cin >> f0;
    cout << "Please enter f(1): "; cin >> f1;
    cout << "Please enter f(n): "; cin >> fn;
    cout << f0 << ',' << f1;
    for (int i = 0; i<fn-2; i++){
        f = f0 + f1;
        f0 = f1;
        f1 = f;
        cout << ','<< f;
    }
    cout << endl;
    system("pause");
}

int recursive_fib(int f){
    return recursive_fib(f-1)+recursive_fib(f-2);
}
