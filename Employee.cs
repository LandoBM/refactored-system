namespace CatWorx.BadgeMaker
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        // public int Id;
        // public string PhotoUrl;

        // Employee currentEmployee = new Employee("Vince", "McMahon", 123, "https://placekitten.com/300/300");
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}