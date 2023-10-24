int number1 = 2147483647; // int veri tipinin değer aralığı +-2147483647, 32bit yer kaplar
long number2 = 9223372036854775807;// int veri tipinin iki katı değer aralığı +-, 64bit yer kaplar
short number3 = -32768;//32767 ve -32768, 16bit
byte number4 = 255; //0-255 arası değer alıyor, 32bit
bool condition = true;// değer tiptedir.
char character = 'A';
double number5 = 10.4;//değer tiptedir. ondalıkla sayıları tutar, 64bit

Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Character is {0}", (int)character);//int'e çevirildi ve ascii kodunu verdi.
Console.WriteLine("Number4 is {0}", number5);


Console.ReadLine();