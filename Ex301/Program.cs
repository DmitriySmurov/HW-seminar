//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом


int num,r,sum=0,t;
        Console.Write("\n\n");  	
    Console.Write("ВВедите число: ");
    num = Convert.ToInt32(Console.ReadLine()); 	
    for(t=num;num!=0;num=num/10){
         r=num % 10;
         sum=sum*10+r;
    }
    if(t==sum)
         Console.Write("{0} да это число палндром.\n",t);
    else
         Console.Write("{0} нет это число не палиндром.\n",t);

