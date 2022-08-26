#include <iostream>

using namespace std;

int main ()
{
/*
    string sentence;
    int rows = 0;
    cout << "Type in the sentence: "; cin >> sentence;
    int s = sentence.length();
    cout << "Enter number of rows: "; cin >> rows;
    cout << endl << "You typed: " << sentence << " size: " << s << endl;
    cout << "Number of rows chosen: " << rows << endl;
    //Maths
    int sections = s/rows;
    cout << "sections: " << sections <<endl;


    //cout << "sentence[1]: " << sentence[1] << endl;
    char out[sections][sections];

    for (int i = 0; i<=rows; i++)
    {
        for (int j = 0; j<=sections; j++)
        {
            out[i,j] = sentence[i+j];
        }
    }

    for (int i = 0; i<=rows; i++)
    {
        for (int j = 0; j<=sections; j++)
            cout<<out[i,j];
    }
*/

    char* sentence;
    int rows = 0;
    cout << "Type in the sentence: "; cin >> sentence;
    int s = sizeof(sentence);
    cout << "Enter number of rows: "; cin >> rows;
    cout << endl << "You typed: " << sentence << " size: " << s << endl;
    cout << "Number of rows chosen: " << rows << endl;
    //Maths
    int sections = s/rows;
    cout << "sections: " << sections <<endl;


    //cout << "sentence[1]: " << sentence[1] << endl;
    char out[sections][sections];

    for (int i = 0; i<=rows; i++)
    {
        for (int j = 0; j<=sections; j++)
        {
            out[i,j] = sentence[i+j];
        }
    }

    for (int i = 0; i<=rows; i++)
    {
        for (int j = 0; j<=sections; j++)
            cout<<out[i,j];
    }
    //INPUT: LUIS ROWS 2 // expected output: LIUS

    return 0;
}
