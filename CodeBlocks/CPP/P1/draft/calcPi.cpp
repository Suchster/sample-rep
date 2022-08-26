#include "calcPi.h"

double findingPi()
{
    double pi;
    int x = 2, aux = 0;
    //pi =  3 + (4/(2*3*4) - 4/(4*5*6));

    for (int i=1; i<=300; i++)
    {
        for(int j=2; j<=300; j+=2)
        {
            aux = aux +((-1^i)*(4/(i*(i+1)*(i*2))));
        }
    }

    //pi = 3.1416;

    return pi;
}

