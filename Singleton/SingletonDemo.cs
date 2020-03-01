using System;

namespace Singleton
{
	class SingletonDemo
	{
		static void Main(string[] args)
		{
			LazySingleton s = LazySingleton.Instance;
			LazySingleton m = LazySingleton.Instance;

			LockingSingleton ss = LockingSingleton.GetInstance();
			LockingSingleton mm = LockingSingleton.GetInstance();
		}
	}
}
