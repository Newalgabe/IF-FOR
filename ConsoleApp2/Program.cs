// task 1
//Console.Write("Enter a number between 1 and 100: ");

//int number = 0;

//number = Int32.Parse(Console.ReadLine());

//if (number >= 1 && number <= 100)
//    {
//        if (number % 3 == 0 && number % 5 == 0)
//        {
//            Console.WriteLine("Fizz Buzz");
//        }
//        else if (number % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//        else if (number % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//        else
//        {
//            Console.WriteLine(number);
//        }
//    }
//else
//    {
//        Console.WriteLine("Error: The number should be between 1 and 100");
//    }


// task 2
//Console.WriteLine("Choose an option:");
//Console.WriteLine("1.Convert from Fahrenheit to Celsius");
//Console.WriteLine("2.Convert from Celsius to Fahrenheit");
//int choice = Int32.Parse(Console.ReadLine());

//if (choice == 1)
//{
//    Console.Write("Enter temperature in Fahrenheit: ");
//    double fahrenheit = double.Parse(Console.ReadLine());
//    double celsius = (fahrenheit - 32) * 5 / 9;
//    Console.WriteLine("Temperature in Celsius: ");
//    Console.WriteLine(celsius);
//}
//else if (choice == 2)
//{
//    Console.Write("Enter temperature in Celsius: ");
//    double celsius = double.Parse(Console.ReadLine());
//    double fahrenheit = celsius * 9 / 5 + 32;
//    Console.WriteLine("Temperature in Fahrenheit: ");
//    Console.WriteLine(fahrenheit);
//}
//else
//{
//    Console.WriteLine("Invalid choice");
//}


// task 3
//Console.Write("Enter the first number: ");
//int firstNumber = Int32.Parse(Console.ReadLine());

//Console.Write("Enter the second number: ");
//int secondNumber = Int32.Parse(Console.ReadLine());

//if (firstNumber > secondNumber)
//{
//    int temp = firstNumber;
//    firstNumber = secondNumber;
//    secondNumber = temp;
//}

//Console.WriteLine("Even numbers between firstNumber and secondNumber:");

//for (int i = firstNumber; i <= secondNumber; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


// task 4
//Console.Write("Enter a six-digit number: ");
//int userInput = Int32.Parse(Console.ReadLine());

//if (userInput >= 100000 && userInput <= 999999)
//{
//    int reversedNumber = 0;
//    while (userInput > 0)
//    {
//        int digit = userInput % 10;
//        reversedNumber = reversedNumber * 10 + digit;
//        userInput /= 10;
//    }

//    Console.WriteLine("Reversed number: ");
//    Console.WriteLine(reversedNumber);
//}
//else
//{
//    Console.WriteLine("Error: Please enter a valid six-digit number.");
//}


// task 5
//Console.Write("Enter the lower number of the range: ");
//int lowerNum = Int32.Parse(Console.ReadLine());

//Console.Write("Enter the upper number of the range: ");
//int upperNum = Int32.Parse(Console.ReadLine());

//int prev = 0;
//int current = 1;
//int next = prev + current;

//Console.WriteLine("Fibonacci numbers in the range:");

//while (current <= upperNum)
//{
//    if (current >= lowerNum)
//    {
//        Console.WriteLine(current);
//    }

//    prev = current;
//    current = next;
//    next = prev + current;
//}


// task 6
//Console.Write("Enter the value of A: ");
//int A = Int32.Parse(Console.ReadLine());

//Console.Write("Enter the value of B: ");
//int B = Int32.Parse(Console.ReadLine());

//if (A > B)
//{
//    Console.WriteLine("Error: A should be less than or equal to B.");
//    return;
//}

//for (int i = A; i <= B; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}


// task 7
//Console.Write("Enter the length of the line: ");
//int length = Int32.Parse(Console.ReadLine());

//Console.Write("Enter the fill character: ");
//char fillCharacter = char.Parse(Console.ReadLine());

//Console.Write("Enter the direction (h for horizontal, v for vertical): ");
//char direction = char.Parse(Console.ReadLine());

//if (direction == 'h')
//{
//    for (int i = 0; i < length; i++)
//    {
//        Console.Write(fillCharacter);
//    }
//    Console.WriteLine();
//}
//else if (direction == 'v')
//{
//    for (int i = 0; i < length; i++)
//    {
//        Console.WriteLine(fillCharacter);
//    }
//}
//else
//{
//    Console.WriteLine("Invalid direction.");
//}