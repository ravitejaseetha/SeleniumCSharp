using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserCreatedException("Created by Ravi");
            }
            catch(UserCreatedException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
    [Serializable]
    public class UserCreatedException : Exception
    {
        public UserCreatedException() : base()
        {

        }

        public UserCreatedException(string message) : base(message)
        {

        }

        public UserCreatedException(string message, Exception innerException) : base(message,innerException)
        {

        }

        public UserCreatedException(SerializationInfo info,StreamingContext context) : base(info,context)
        {

        }

    }
}
