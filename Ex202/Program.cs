Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Num);
if (NumText.Length > 2){
  Console.WriteLine("третья цифра -> " + NumText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
