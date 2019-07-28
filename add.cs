using System;			
public class Venky
{
	public static void Main()
	{
		string[] s = Console.ReadLine().Split();
		int res,a,b,n,sum=0;
		n = int.Parse(s[0]);
		a = int.Parse(s[1]);
		b = int.Parse(s[2]);
		sum = a+b;
		res = sum*n;
		Console.WriteLine(res);
	}
}
