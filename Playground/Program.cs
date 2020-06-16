using System;
using System.Collections.Generic;
using Autofac;

namespace Playground
{
	class Program
	{
		static IEnumerable<int> GetSomeNumbers()
		{
			Console.WriteLine("We just entered GetSomeNumbers()");

			yield return 7;

			Console.WriteLine("after yield return 7");
			yield return 42;


			Console.WriteLine("after yield return 42");
		}


		static void Main(string[] args)
		{
			//

			DIContainerDemo();
			//


			foreach (var item in GetSomeNumbers())
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();
			Console.WriteLine();
			{
				IEnumerable<int> enumerable = GetSomeNumbers();
				var enumerator = enumerable.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						var item = enumerator.Current;
						Console.WriteLine(item);
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}


			Console.WriteLine();
			Console.WriteLine();

			{
			
				IEnumerable<int> enumerable = GetSomeNumbers();
				if (enumerable != null)
				{
					var enumerator1 = enumerable.GetEnumerator();
					var enumerator2 = enumerable.GetEnumerator();

					enumerator1.MoveNext();

					enumerator2.MoveNext();
					enumerator2.MoveNext();

					Console.WriteLine(enumerator1.Current);
					Console.WriteLine(enumerator2.Current);
				}
			}

			return;

			{
				List<int> list = new List<int>() { 1, 2, 3, 4 };

				foreach (var item in list)
				{
					Console.WriteLine(item);
				}


				var enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						var item = enumerator.Current;
						Console.WriteLine(item);
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}
					   			 		  
			Console.ReadLine();
		}




		class A {}

		class B
		{
			private readonly A _pA;
			private readonly IConfig _pConfig;

			public B(A pA)
			{
				_pA = pA;
				//_pConfig = pConfig;
			}
		}

		class C
		{
			private readonly A _pA;
			private readonly B _pB;
			private readonly CalculatorFactory _pCalcFactory;
			private readonly IConfig _pConfig;
			private readonly ILogger _pLogger;

			public C(A pA, B pB, CalculatorFactory pCalcFactory)
			{
				_pA = pA;
				_pB = pB;
				_pCalcFactory = pCalcFactory;

				var calculator = _pCalcFactory.Create();
			}
		}

		interface ICalculator {
			void Calculate();
		}

		interface IConfig
		{
			void Configure();
		}

		private class Config : IConfig
		{
			public void Configure()
			{

			}
		}

		public class Calc : ICalculator
		{
			private readonly ILogger _logger;

			public Calc(ILogger logger)
			{
				_logger = logger;
			}

			public void Calculate()
			{
				//_logger
			}
		}
		public interface ILogger { }

		private class NullLogger : ILogger
		{
		}

		public class Logger : ILogger
		{
			
		}

		class CalculatorFactory
		{
			private readonly ILogger _logger;

			public CalculatorFactory(ILogger logger)
			{
				_logger = logger;
			}
			public ICalculator Create()
			{
				return new Calc(_logger);
			}
		}

		private static void DIContainerDemo()
		{
			//var pA = new A();
			
			//ILogger logger = new Logger();
			//IConfig config = new Config();

			//var calculatorFactory = new CalculatorFactory(logger);
			//var c = new C(pA, new B(pA), calculatorFactory, config);
			//var c2 = new C(pA, new B(pA), calculatorFactory, config);
			//var c3 = new C(pA, new B(pA), calculatorFactory, config);
			//var c4 = new C(pA, new B(pA), calculatorFactory, config);

			// Using container
			var builder = new ContainerBuilder();

			// Composition root (UI solution)
			builder.RegisterType<Logger>()
				.As<ILogger>()
				.SingleInstance();

			builder.RegisterType<C>();
			builder.RegisterType<A>();
			builder.RegisterType<B>();
			builder.RegisterType<CalculatorFactory>();
			builder.RegisterType<Config>().As<IConfig>();

			builder.RegisterType<NullLogger>().As<ILogger>();

			var container = builder.Build();

			var logger2 = container.Resolve<ILogger>();
			var c5 = container.Resolve<C>();

			// override some registrations for testing

			var c6 = container.Resolve<C>();
		}
	}
}
