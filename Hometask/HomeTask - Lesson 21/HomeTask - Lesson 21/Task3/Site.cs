using System;

namespace Task3
{
    class Site
    {
        private User[] _users;

        public Site(params User[] users)
        {
            _users = users;
        }

        public User this[int index]
        {
            get { return _users[index]; }
            set { _users[index] = value; }
        }

        public void Display()
        {
            for (int i = 0; i < _users.Length; i++)
            {
                Console.WriteLine(_users[i].GetType().Name);
                _users[i].Add();
                _users[i].Edit();
                _users[i].Read();
                _users[i].Delete();
                Console.WriteLine();
            }
        }

    }
}
