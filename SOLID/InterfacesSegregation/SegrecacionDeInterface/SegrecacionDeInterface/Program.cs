using System;
using System.Collections.Generic;

namespace SegrecacionDeInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public class SaleService : IBasicAction<User>
        {
            public User Get(int id)
            {
                return new User();
            }
            public List<User> GetList()
            {
                return new List<User>();
            }
            public void Add(User entity)
            {
                Console.WriteLine("Agregamos usuario");
            }
        }

        public class UserService: IBasicAction<User>, IEditableAction<User>
        {
            public User Get(int id)
            {
                return new User();
            }
            public List<User> GetList()
            {
                return new List<User>();
            }
            public void Add(User entity)
            {
                Console.WriteLine("Agregamos usuario");
            }
            public void Delete(User entity)
            {
                Console.WriteLine("Borramos usuario");
            }

            public void Update(User entity)
            {
                Console.WriteLine("Actualizamos usuario");
            }
        }
        public interface IBasicAction<T>
        {
            public T Get(int id);
            public List<T> GetList();

            public void Add(T entity);
            
        }

        public interface IEditableAction<T>
        {
            public void Delete(T entity);

            public void Update(T entity);
        }

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }

        public class Sale
        {
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
