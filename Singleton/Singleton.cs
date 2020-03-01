using System;


namespace Singleton
{
	class LockingSingleton
	{
		private static LockingSingleton instance = null;

		private static readonly object padlock = new object();

		private LockingSingleton() { }

		public static LockingSingleton GetInstance()
		{
			if (instance == null)
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new LockingSingleton();
					}
				}

				return instance;
			}

			return instance;
		}
	}
}
