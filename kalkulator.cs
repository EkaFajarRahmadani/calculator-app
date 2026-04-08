{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6
		
		console.WriteLine("hasil penambahan: {0} + {1} = {2}", a,b, penambahan(a, b));
		console.WriteLine("hasil pengurangan: {0} - {1} = {2}", a,b, pengurangan(a, b));
		
		console.WriteLine("\nTeken sembarang key untuk keluar")
		console.ReadKey();
	}
	
	static int penambahan (int a, int b)
	{
		return a + b;
	}
	
	static int pengurangan (int a, int b)
	{
		return a - b;
	}
