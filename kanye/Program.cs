
//System.Threading.Thread.Sleep(10000);
using System.Security.Cryptography.X509Certificates;

Console.Clear();


//I am a Comment

/*
I
Am
A
Comment
*/
//______________________________________

/*
using System.IO.Compression;

Console.WriteLine("Kanye West!");

Console.Write("Wake up Mr. West ");

Console.WriteLine("Wake up Mr. West");

Console.WriteLine("Wake up Mr. West, Mr. West");



 //___________________

//Datatypes: int, float, string, bool
/*
int = Helt talt (-5, 4, 6, 5000)
Float = decimal
String= tekst
*/


//variables

/*
int x; //declaring x

x = 4; // instansiating x

int y = 5, z = 6; //declaring and instantsiatiing y

int d = x + y - z * x / z % y;


Console.WriteLine("x = " + x + " and y = " + y + " and z = " + z);
Console.WriteLine("Result of d is = " + d);

float e = 5.5F; 

Console.WriteLine("printing e as a float:" + e);

int f = Convert.ToInt16(e);

Console.WriteLine("printing e as a float:" + f);

string str = "I am a string" + " and so am I ";

Console.WriteLine(str);


string str One = "O"

Console.WriteLine("x + y = " + Z);  
*/

/*

using System.IO.Compression;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello");
Console.WriteLine("Victor");



int x = 4;

int y = 5;

Console.WriteLine(" 4 + 5 is "+(x + y));


int x = 5;

int y = 4;

Console.WriteLine(" 5 - 4 is "+(x - y));


int x = -1;

int y = 4;

int z = 6;

Console.WriteLine(+(x + y * z));



Console.WriteLine("The result of (-1 + 4 * 6) = " + (-1+4*6));
Console.WriteLine("The result is ((35 + 5) % 7) = "+ ((35 + 5) % 7));
Console.WriteLine("The result is (14 + (-4) * 6 / 11) = "+ (14 + (-4) * 6 / 11));
Console.WriteLine("The result is (2 + 15 / 6 * 1 - 7 % 2) = "+ (2 + 15 / 6 * 1 - 7 % 2));


void SwapNumbers(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int x = 5;
int y = 6;

Console.WriteLine("x: " + x);
Console.WriteLine("y: " + y);

SwapNumbers(ref x, ref y);
Console.WriteLine("Swapped");

Console.WriteLine("x: " + x);
Console.WriteLine("y: " + y);



int number1, number2, number3;

Console.Write("\nWrite the First number to multiply ");
number1 = int.Parse(Console.ReadLine());
Console.Write("\nWrite the Second number to multiply ");
number2 = int.Parse(Console.ReadLine());
Console.Write("\nWrite the Third number to multiply ");
number3 = int.Parse(Console.ReadLine());
Console.WriteLine( number1 * number2 * number3);
Console.ReadLine();




int number1, number2,

Console.Write("\nWrite the First number to multiply ");
number1 = int.Parse(Console.ReadLine());
Console.Write("\nWrite the Second number to multiply ");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine( number1 + number2);
Console.ReadLine();

int number3, number4,

Console.Write("\nWrite the First number to multiply ");
number1 = int.Parse(Console.ReadLine());
Console.Write("\nWrite the Second number to multiply ");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine( number3 - number4);
Console.ReadLine();

int number5, number6,

Console.Write("\nWrite the First number to multiply ");
number1 = int.Parse(Console.ReadLine());
Console.Write("\nWrite the Second number to multiply ");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine( number5 - number6);
Console.ReadLine();



int num1, num2, add, subtract, multiply, divide, mod;

Console.Write("Please enter your first number: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Please enter your second number: " );
num2 = int.Parse(Console.ReadLine());

add = num1 + num2;
subtract = num1 - num2;
multiply = num1 * num2;
divide = num1 / num2;
mod = num1 % num2;

Console.WriteLine("These two numbers added is: {0}\nSubtracted: {1}\nMulitplied: {2}\nDivided: {3}\nModulus: {4}",add,subtract,multiply,divide,mod);





{
private static int numberX;

static void Main(string[] args)
{
Console.WriteLine("Type a number: ");
numberX = int.Parse(Console.ReadLine());

Console.WriteLine("The Multiplication Table of this number is: ");
Console.WriteLine(value: numberX * 0);
Console.WriteLine(value: numberX * 1);
Console.WriteLine(value: numberX * 2);
Console.WriteLine(value: numberX * 3);
Console.WriteLine(value: numberX * 4);
Console.WriteLine(value: numberX * 5);
Console.WriteLine(value: numberX * 6);
Console.WriteLine(value: numberX * 7);
Console.WriteLine(value: numberX * 8);
Console.WriteLine(value: numberX * 9);
Console.WriteLine(value: numberX * 10);
}
}
}




{  
    char letter1,letter2,letter3;
  
    Console.WriteLine("Input first letter: ");
    letter1 = Convert.ToChar(Console.ReadLine());
 
    Console.WriteLine("Input second letter: ");
    letter2 = Convert.ToChar(Console.ReadLine());       
 
    Console.WriteLine("Input third letter: ");
    letter3 = Convert.ToChar(Console.ReadLine());
     
    Console.WriteLine("{0} {1} {2}", letter3, letter2, letter1);
   }
   */

// {

    /*

 int number1,number2,number3;
double x1, x2;

Console.WriteLine("Input first sqr number: ");

number1 = Convert.ToInt32(Console.ReadLine());
number2 = Convert.ToInt32(Console.ReadLine());
number3 = Convert.ToInt32(Console.ReadLine());

double d = number2 * number2 - 4 * number1 * number3;

if (d < 0)
{
Console.WriteLine("There is no answer");
 }
else if (d == 0)
{
    int answer = 0;

}
else if (d > 0)
{
int answer1 = 0;
int answer2 = 0;
Console.WriteLine("Both roots are Equal");


x1 = (-number2 + Math.Sqrt(d))/(2*number1); 
x2 = (-number2 - Math.Sqrt(d))/(2*number1);

Console.Write("First  Root Root1= {0}\n",x1);
Console.Write("Second Root root2= {0}\n",x2);

}

else

{
Console.Write("Root are imeainary;\nNo Solution. \n\n");


}







Console.Write("Input the value of a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of c: ");
int c = Convert.ToInt32(Console.ReadLine());

var root1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
var root2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

if (root1 == root2)
{
Console.WriteLine("\nBoth roots are equal.");
Console.WriteLine("First root equals {0}", root1);
Console.WriteLine("Second root equals {0}", root2);
}
else if (double.IsNaN(root1) || double.IsNaN(root2));

 

int x = 4;

if (x == 4){
    Console.WriteLine("x is four");
} else if (x == 3){
    Console.WriteLine("x is tree");
} else {
    Console.WriteLine("everything else");
}


static void Main(string[] args)
        {
    double rl,phy,che,ca,total;
    double per;
    string nm,div;

    Console.Write("\n\n");
    Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
    Console.Write("-------------------------------------------------------------------------------");
    Console.Write("\n\n");


    Console.Write("Input the Roll Number of the student :");
    rl = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input the Name of the Student :");
    nm = Console.ReadLine();

    Console.Write("Input  the marks of Physics : ");
    phy= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  the marks of  Chemistry : ");
    che = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  the marks of Computer Application : ");
    ca = Convert.ToInt32(Console.ReadLine());

    total = phy+che+ca;
    per = total/3.0;
    if (per>=60)
	 div="First";
    else
	if (per<60&&per>=48)
	    div="Second";
	else
	    if (per<48&&per>=36)
		div="Pass";
	     else
		div="Fail";

       Console.Write("\nRoll No : {0}\nName of Student : {1}\n",rl,nm);
       Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n",phy,che,ca);
       Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n",total,per,div);
}

int x = 45000;

switch (x){
    case 1:
    Console.WriteLine("x is 1");
    break;

case 2:
    Console.WriteLine("x is 2");
    break;

default:

    Console.WriteLine("x is not 1 or 2");
    break;
    
}

*/

for (int i = 0; i < 100; i++){

    if (i == 5){
        continue;
    }

        if (i == 7){
        continue;
    }

    
    if (i == 43){
        continue;
    }

        if (i == 45){
        continue;
    }

        if (i == 67){
        break;
        
    Console.WriteLine(i);
}





