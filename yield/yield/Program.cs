// a program to use Yield and return only 4,5 from list of 1,2,3,4,5

using System.Collections.Generic;
using static System.Console;

List<int> MyList = new List<int>();

void FillValue()
{

    for (int i = 1; i < 6; i++)
    {
        MyList.Add(i);
    }

}

FillValue();

// print every element
Write($"every element of MyList are: ");
foreach (var item in MyList)
{
    Write(item + " ");

}


//print elements begger than 3
WriteLine();
WriteLine();
Write($"elements that are bigger than 3 of MyList are: ");
foreach (int i in Filter())
{
    Write(i + " ");
       
}
IEnumerable<int> Filter()
{
    foreach (int i in MyList)
    {
        if (i > 3)
        {
            yield return i;
        }
    }
}

// print accumulative value of 1 to 5
WriteLine();
WriteLine();
Write($"print accumulative value of 1 to 5: ");
foreach (int i in RunningTotal())
{
    Write(i + " ");
}

IEnumerable<int> RunningTotal()
{
    int runningtotal = 0;
    foreach (int i in MyList)
    {
        runningtotal += i;
        yield return (runningtotal);
    }
}

WriteLine();
WriteLine();
