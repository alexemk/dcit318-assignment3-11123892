// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;
using System.Collections.Generic;
using System.IO;

namespace AssignmentSolutions.Q4.Grading
{
    public class StudentResultProcessor
    {
        public List<Student> ReadStudentsFromFile(string inputFilePath)
        {
            var students = new List<Student>();
            using var sr = new StreamReader(inputFilePath);
            string? line; int lineNo = 0;
            while ((line = sr.ReadLine()) != null)
            {
                lineNo++;
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');
                if (parts.Length != 3)
                    throw new MissingFieldException($"Line {lineNo}: expected 3 fields, got {parts.Length}.");

                if (!int.TryParse(parts[0].Trim(), out int id))
                    throw new FormatException($"Line {lineNo}: invalid ID format.");

                var name = parts[1].Trim();

                if (!int.TryParse(parts[2].Trim(), out int score))
                    throw new InvalidScoreFormatException($"Line {lineNo}: score is not a valid integer.");

                var student = new Student { Id = id, FullName = name, Score = score };
                students.Add(student);
            }
            return students;
        }

        public void WriteReportToFile(List<Student> students, string outputFilePath)
        {
            using var sw = new StreamWriter(outputFilePath, false);
            foreach (var s in students)
            {
                sw.WriteLine($"{s.FullName} (ID: {s.Id}): Score = {s.Score}, Grade = {s.GetGrade()}");
            }
        }

        public void Run()
        {
            Console.WriteLine("=== QUESTION 4: Grading System (File IO) ===");

            var input = Path.Combine(Environment.CurrentDirectory, "students_input.txt");
            var output = Path.Combine(Environment.CurrentDirectory, "students_report.txt");

            // Create a valid sample input file if not present
            if (!File.Exists(input))
            {
                File.WriteAllLines(input, new[]{ "101, Alice Smith, 84", "102, Brian O'Neil, 73", "103, Carmen Diaz, 59", "104, David Wu, 47" });
            }

            try
            {
                var list = ReadStudentsFromFile(input);
                WriteReportToFile(list, output);
                Console.WriteLine($"Report written to: {output}");
            }
            catch (FileNotFoundException ex) { Console.WriteLine($"File not found: {ex.Message}"); }
            catch (InvalidScoreFormatException ex) { Console.WriteLine($"Invalid score: {ex.Message}"); }
            catch (MissingFieldException ex) { Console.WriteLine($"Missing field: {ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"Unexpected error: {ex.Message}"); }

            Console.WriteLine();
        }
    }
}
