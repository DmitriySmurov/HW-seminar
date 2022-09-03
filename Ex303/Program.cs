//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int i,ctr;
	Console.Write("\n\n");
    
    Console.Write("Введите число : ");
    ctr= Convert.ToInt32(Console.ReadLine());	
    for(i=1;i<=ctr;i++)
    
	 Console.Write("куб {1} -> :{2} \n",i,i, (i*i*i)); 
