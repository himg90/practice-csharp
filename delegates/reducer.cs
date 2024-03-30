namespace Delegates;
public delegate int binaryIntOp(int i1, int i2);

public class Program
{
	public static void Run()
	{
		Functions fObj = new Functions();
		binaryIntOp delegateSum = new binaryIntOp(fObj.sumInt);
		foreach (Delegate d in delegateSum.GetInvocationList()) {
			Console.WriteLine(d.Target);
		}
		int r = Functions.reduce([1,2,3,4,5], 0, delegateSum);
		Console.Write($"DeleteSum result = {r}");
	}
}

public class Functions
{
	public  int sumInt(int i1, int i2) {
		return i1+i2;
	}
	
	public  int subtractInt(int i1, int i2) {
		return i1-i2;
	}
	
	public static int reduce(int[] arr, int seed, binaryIntOp f) {
		int result = seed;
		for(int i = 0; i<arr.Length; i++) {
			result = f(arr[i], result);
		}
		
		return result;
	}
}

