// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

namespace AssignmentSolutions.Q2.Health
{
    public class Patient
    {
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }

        public Patient(int id, string name, int age, string gender)
        {
            Id = id; Name = name; Age = age; Gender = gender;
        }

        public override string ToString() => $"Patient #{Id}: {Name}, {Age}, {Gender}";
    }
}
