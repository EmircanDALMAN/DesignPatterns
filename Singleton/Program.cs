using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
        }
    }

    class CustomerManager
    {
        //Private yaptık dışarıdan erişilemez diye
        private static CustomerManager _customerManager;
        private static object _lockObject = new object();
        private CustomerManager()
        {

        }

        //Kendisini döndürür
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject) { return _customerManager ??= new CustomerManager(); }
        }
        public void Save()
        {
            Console.WriteLine("Kayıt Başarılı");
        }
    }
}
