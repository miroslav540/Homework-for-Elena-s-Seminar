//ЗАДАЧА 2
int num1 = 5;
int num2 = 7;
if(num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else 
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}

int num3 = 2;
int num4 = 10;
if(num1 > num2)
{
    Console.WriteLine($"Число {num3} больше числа {num4}");
}
else 
{
    Console.WriteLine($"Число {num3} меньше числа {num4}");
}

int num5 = -9;
int num6 = -3;
if(num5 > num6)
{
    Console.WriteLine($"Число {num5} больше числа {num6}");
}
else 
{
    Console.WriteLine($"Число {num5} меньше числа {num6}");
}

//ЗАДАЧА 4
int number1 = 2;
int number2 = 3;
int number3 = 7;
if (number1 > number2 && number1 > number3)
    Console.WriteLine(number1);
else if (number2 > number1 && number2 > number3)
    Console.WriteLine(number2);
    else if (number3 > number1 && number3 > number2)
            Console.WriteLine(number3); 

            
int number4 = 44;
int number5 = 5;
int number6 = 78;
if (number4 > number5 && number4 > number6)
    Console.WriteLine(number4);
else if (number5 > number4 && number5 > number6)
    Console.WriteLine(number5);
    else if (number6 > number4 && number6 > number5)
            Console.WriteLine(number6); 

            
int number7 = 22;
int number8 = 3;
int number9 = 9;
if (number7 > number8 && number7 > number9)
    Console.WriteLine(number7);
else if (number8 > number7 && number8 > number9)
    Console.WriteLine(number8);
    else if (number9 > number7 && number9 > number8)
            Console.WriteLine(number9); 


//ЗАДАЧА 6
int n1 = 4;
if (n1 % 2 == 0)
    Console.WriteLine("{0} yes", n1);
    else
        Console.WriteLine("{0} no", n1);

int n2 = -3;
if (n2 % 2 == 0)
    Console.WriteLine("{0} yes", n2);
    else
        Console.WriteLine("{0} no", n2);

int n3 = 7;
if (n2 % 2 == 0)
    Console.WriteLine("{0} yes", n3);
    else
        Console.WriteLine("{0} no", n3);


//ЗАДАЧА 8
Console.WriteLine("enter the number less then 10");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    if (i % 2 != 0)
        continue;
    Console.WriteLine(i);
}