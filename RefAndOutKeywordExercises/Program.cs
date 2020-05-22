using System;
using System.Runtime.InteropServices;

namespace RefAndOutKeywordExercises
{
	class Program
	{
		class MyClass
		{
			public string Name { get; set; } = "NoName";
		}


		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			DoSmth();
			int i = DoSmthAndReturn1Value();


			int i2=DoSmthAndReturn2Values(out int f);

			bool b = int.TryParse("123", out var _);

			var (wind, temp) = DoSmthAndReturn2ValuesAsTuple();

			var c1=new MyClass();
			var c2=new MyClass();
			IntPtr c1Addr =  GCHandle.ToIntPtr(GCHandle.Alloc(c1));
			IntPtr c2Addr =  GCHandle.ToIntPtr(GCHandle.Alloc(c2));

			i = 5;
			int y = 2;
			FuncWithRef(ref i, y, ref c1, c2);
		}

		static void DoSmth() { }

		static int DoSmthAndReturn1Value()
		{
			return 1;
		}


		static int DoSmthAndReturn2Values(out int a)
		{

			a = 0;
			switch (a)
			{
				case 1:
					return 1;
				case 2:
					return 1;
				case 3:
					return 1;
				case 4:
					return 1;

			}
			return 1;
		}


		static (int wind, int temp) DoSmthAndReturn2ValuesAsTuple()
		{
			return (1, 2);
		}


		static void FuncWithRef(ref int i, int y, ref MyClass c1, MyClass c2)
		{
			i = 7;
			y = 7;


			IntPtr c1AddrBefore = GCHandle.ToIntPtr(GCHandle.Alloc(c1));
			IntPtr c2AddrBefore = GCHandle.ToIntPtr(GCHandle.Alloc(c2));

			c1 = new MyClass();
			c1.Name = "asd";
			c2 = new MyClass();
			c2.Name = "asd";



			IntPtr c1Addr = GCHandle.ToIntPtr(GCHandle.Alloc(c1));
			IntPtr c2Addr = GCHandle.ToIntPtr(GCHandle.Alloc(c2));
		}
	}
}
