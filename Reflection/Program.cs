using System;
using System.Reflection;
using NUnit.Framework;

namespace Reflection
{
	class Program
	{
		static void Main(string[] args)
		{
			var types = Assembly.GetExecutingAssembly().GetTypes();
			// Names of all public classes in assembly
			Console.WriteLine("All public classes");
			foreach (var t in types)
			{
				Console.WriteLine(t.Name);
			}

			Console.WriteLine();

			// Public methods and properties
			Console.WriteLine("All public members of:");
			foreach (var t in types)
			{
				Console.WriteLine($"Class {t}");
				PrintPublicMembers(t);
				Console.WriteLine();
			}

			InvokePrivateMethod();

			InvokePublicMethod();
			Console.WriteLine();

			CreateAircraftInstance();

			PrintClassesWithMyAttribute();

			ScanTestAssembly();

			Console.ReadLine();
		}

		private static void ScanTestAssembly()
		{
			var assembly = Assembly.LoadFile(@"D:\Projekte\FPO\GIT7\bin\Debug\Pace.PLFPO.CC.TrajectorySolver.BlackBoxTest.dll");
			var counter = 0;

			foreach (var a in assembly.ExportedTypes)
			{

				if (a.GetCustomAttributes(typeof(TestFixtureAttribute), true).Length > 0)
				{
					Console.WriteLine(a.Name);
					counter++;
				}
			}
			Console.WriteLine(counter);
		}

		private static void PrintClassesWithMyAttribute()
		{
			var types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (var t in types)
			{
				if (t.GetCustomAttributes(typeof(MyAttribute), true).Length > 0)
				{
					Console.WriteLine(t.Name);
				}
			}
		}

		private static void CreateAircraftInstance()
		{
			//Aircraft aircraft = (Aircraft)Activator.CreateInstance(typeof(Aircraft));
			Aircraft aircraft = Activator.CreateInstance<Aircraft>();
		}

		private static void PrintPublicMembers(Type t)
		{
			var memberInfos = t.GetMembers();

			foreach (var member in memberInfos)
			{
				Console.WriteLine(member.Name);
			}
		}

		// Invoke method sing reflection
		private static Aircraft aircraft = new Aircraft();

		static void InvokePrivateMethod()
		{
			var t = typeof(Aircraft);
			var memberInfos = t.GetMethod("CalculateMach", BindingFlags.NonPublic | BindingFlags.Instance);

			memberInfos.Invoke(aircraft, new object[] { });
		}

		static void InvokePublicMethod()
		{
			var t = typeof(Aircraft);
			var methodInfo = t.GetMethod("PrintAltitude");

			methodInfo.Invoke(aircraft, new object[] { });
		}

	}
}
