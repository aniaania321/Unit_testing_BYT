using Task2;

Calculator calculator1 = new Calculator(10,2,"/");
Console.WriteLine(calculator1.Calculate());

Calculator calculator2 = new Calculator(10,5,"*");
Console.WriteLine(calculator2.Calculate());

Calculator calculator4 = new Calculator(8,12,"+");
Console.WriteLine(calculator4.Calculate());

Calculator calculator3 = new Calculator(10,8,"-");
Console.WriteLine(calculator3.Calculate());