using System;
namespace program{
public class Hello{
public static void Main(){
calculator obj = new calculator();
Console.WriteLine("sum :" + obj.sum(10,20));
Console.WriteLine("sub :" + obj.sub(10,20));
Console.WriteLine("multiply :" + obj.multiply(10,20));
Console.WriteLine("divide :" + obj.divide(10,20));
Console.WriteLine("exponeniate :" + obj.exponeniate(10));

}
class calculator{
public int a = 10;
public int b = 20;

public double sum (double a , double b){
return a + b;
}
public double sub (double a , double b){
return a - b;
}
public double multiply (double a , double b){
return a * b;
}
public double divide (double a , double b){
return a / b;
}
public double exponeniate (double a){
return Math.Exp(a);
}
}

}
}
