using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class ConnectionManagerExample
    {
        static void Main(string[] args)
        {
			var connectionManager1 = ConnectionManager.Instance();
			var connectionManager2 = ConnectionManager.Instance();
			var connectionManager3 = ConnectionManager.Instance();

			Console.WriteLine(connectionManager1.WhoAmI());
			Console.WriteLine(connectionManager2.WhoAmI());
			Console.WriteLine(connectionManager3.WhoAmI());

			Cat c = new Cat();
			c.MiauTheConnectionManager();

        }
    }



	public class Cat
	{
		public Cat ()
		{

		}

		public void MiauTheConnectionManager()
		{
			var connMan = ConnectionManager.Instance();
			Console.WriteLine("Miau : " + connMan.GetHashCode());
		}
	}

	public class ConnectionManager
	{
		private static ConnectionManager _connManager = null;
		private static object _padlock = new Object();
		private ConnectionManager() { }

		public static ConnectionManager Instance()
		{
			lock (_padlock)
			{
				if(_connManager == null)
				{
					_connManager = new ConnectionManager();
				}
			}

			return _connManager;
		}

		public string WhoAmI()
		{
			return this.GetHashCode().ToString();
		}
	}
}
