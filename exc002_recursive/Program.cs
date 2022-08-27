// re_cursive_ factorial nd fibo

double Factorial(double x){
    if (x == 1) return 1;
    else return x * Factorial(x - 1);
}

Console.WriteLine(Factorial(5));

double Fibo(double x){
    if (x == 1 || x == 2) return 1;
    else return Fibo(x - 1) + Fibo(x - 2);
}

for (int i = 1; i < 10; i++){
    Console.WriteLine(Fibo(i));
}