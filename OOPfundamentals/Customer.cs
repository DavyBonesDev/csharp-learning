using System;

namespace OOPfundamentals
{
    class Customer
    {
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _lastName = value; }
        }
        
        public string FirstName { get; set; }
        private string _lastName;
        public string Lastname
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
