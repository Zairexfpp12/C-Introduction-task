
////1) Bir integer arrayi yaradın, daha sonra istifadəçidən yaşını soruşun,
////    \əgər istifadəçinin yaşı bu arrayda varsa true əks halda false çap edin


//int[] num = { 9, 23, 45, 34, 56 };
//head:
//Console.WriteLine("yasinizi daxil edin");
//string val = Console.ReadLine();
//bool number = int.TryParse(val, out int age);
//int count=0;
//if(number== false)
//{
//    goto head;
//}

//foreach (var item in num)
//{
//    if (age == item)
//    {
//        count++;
//    }
//}
//if (count == 1)
//{
//    Console.WriteLine(true);

//}
//else
//{
//    Console.WriteLine(false);
//}



string[] names = {"aysel", "eli", "ruslan", "hesen" };
head:
Console.WriteLine("Telebenin adini  daxil edin");
string name = Console.ReadLine();
int count = 0;
foreach (var item in names)
{
    if (name == item)
    {
        count++;
    }
}
 if (count >= 1)
{ 
          
                Console.WriteLine("-------------");
                Console.WriteLine(name);
}
else
{
                Console.WriteLine("Bu adda telebe yoxdur");
                goto head;
}
              



