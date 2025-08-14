// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

namespace AssignmentSolutions.Q4.Grading
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int Score { get; set; }

        public string GetGrade()
        {
            if (Score >= 80 && Score <= 100) return "A";
            if (Score >= 70) return "B";
            if (Score >= 60) return "C";
            if (Score >= 50) return "D";
            return "F";
        }

        public override string ToString() => $"{FullName} (ID: {Id}): Score = {Score}, Grade = {GetGrade()}";
    }
}
