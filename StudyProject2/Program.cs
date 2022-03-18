
int[] myArray = { 5, 3, 3, 1, 2, 3, 425 };

//------ Диапозоны
int[] myArray2 = myArray[^4..^1];// другие записи: [1..6] [..5]
for (int i = 0; i < myArray2.Length; i++)
    Console.Write(myArray2[i] + " ");
//---------


Console.WriteLine("\n");


//разбор диапозона myArray[1..4];
Range myRange = new Range(1,4);
int [] myArray3 = myArray[myRange];
for (int i = 0; i < myArray3.Length; i++)
    Console.Write(myArray3[i] + " ");
//-------


Console.WriteLine("\n");


//--------структура Index         разбор записи  myArray[^2]
Index myIndex = ^2; //глубже это выглядит так: ... = new Index(2, true);
Console.WriteLine($"\nvalue {myIndex.Value}, isFromEnd {myIndex.IsFromEnd}");
Console.WriteLine("\n" + myArray[myIndex]);
//---------

// Стринговый массив
string str = "Hello World !!! =)";
Console.WriteLine("\n" + str[6..11]);