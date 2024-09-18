#region Variables
int age = 25;
Console.WriteLine(age);

float pi = 3.14e30f;
Console.WriteLine(pi);

double temperature = 36.6e90;
Console.WriteLine(temperature);

char dollar = '$';
Console.WriteLine(dollar);

string name = "Nuno";
Console.WriteLine(name);
#endregion

#region Primitive Datatypes
byte byteVariable = 25;
Console.WriteLine(byteVariable);

sbyte signedByteVariable = -30;
Console.WriteLine(signedByteVariable);

short shortVariable = -330;
Console.WriteLine(shortVariable);

ushort unsignedShortVariable = 20;
Console.WriteLine(unsignedShortVariable);

long longVariable = 255;
Console.WriteLine(longVariable);

ulong unsignedLongVariable = 10000000;
Console.WriteLine(unsignedLongVariable);
#endregion

#region Char and Strings
char literal = 'C';
Console.WriteLine(literal);

char unicode = '\u0043';
Console.WriteLine(unicode);

char ascii = (char)67;
Console.WriteLine(ascii);

string string1 = "Hello";
string string2 = "World";
string string3 = "Program";
Console.WriteLine(string1 + " " + string2 + " " + string3);
#endregion

#region Casting
int i = 123; double d;
d = i;
Console.WriteLine(d);

short s = 100;
int j;
j = s;
Console.WriteLine(j);

char c = 'A';
int k;
k = c;
Console.WriteLine(k); // ASCII is printed

int asciiCode = 65;
char ch = (char)asciiCode;
Console.WriteLine(ch); // Unicode is printed

float f = 3.14f;
int a;
a = (int)f;
Console.WriteLine(a); // Data could be lost in the process
#endregion

#region String Manipulation
int id = 10;
string title = "Nuno";
Console.WriteLine("Hello! My ID is " + id + " and my title is " + title); // String Concatenation
Console.WriteLine("Hello! My ID is {0} and my title is {1}", id, title); // String Composite
Console.WriteLine($"Hello! My ID is {id} and my title is {title}"); // String Interpolation
Console.WriteLine(@"The sky was a deep shade of blue,
dotted with fluffy, white clouds.
She sipped her coffee slowly,
\A

enjoying the rich aroma and the warmth it brought on a cold morning.
The old oak tree stood tall,
its branches swaying gently in the breeze as birds chirped in the distance."); // Verbatim Strings
#endregion