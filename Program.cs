using static System.Console;

double n1, n2;

WriteLine("Digite o primeiro numero:");
n1 = Convert.ToInt32(ReadLine());
WriteLine("Digite o segundo numero:");
n2 = Convert.ToInt32(ReadLine());


if (n2 > n1)
{
    WriteLine($"{n2} é maior que {n1}");
}
else{
    WriteLine($"{n1} é maior que {n2}");
}

