﻿int sayi1 = 16; 
int sayi2 = 30; 
sayi1 = sayi2; 
sayi2 = 65; 
//sayi1 ?? 30
int[] sayilar1 = new int[] { 10, 20, 30 }; 
int[] sayilar2 = new int[] { 100, 200, 300 }; 
sayilar1 = sayilar2; 
sayilar2[0] = 999;

Console.WriteLine(sayi1);
Console.WriteLine(sayi2);

Console.WriteLine(sayilar2[0]);


//int,decimal,float,double,bool => değer tip
//aray,class,interface => referans tip