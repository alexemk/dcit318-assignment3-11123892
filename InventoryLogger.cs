// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AssignmentSolutions.Q5.InventoryLogger
{
    public class InventoryLogger<T> where T : IInventoryEntity
    {
        private List<T> _log = new();
        private readonly string _filePath;

        public InventoryLogger(string filePath) { _filePath = filePath; }

        public void Add(T item) => _log.Add(item);
        public List<T> GetAll() => new(_log);

        public void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_log, new JsonSerializerOptions { WriteIndented = true });
                using var sw = new StreamWriter(_filePath, false);
                sw.Write(json);
            }
            catch (Exception ex) { Console.WriteLine($"Error saving to file: {ex.Message}"); }
        }

        public void LoadFromFile()
        {
            try
            {
                using var sr = new StreamReader(_filePath);
                var json = sr.ReadToEnd();
                var loaded = JsonSerializer.Deserialize<List<T>>(json);
                _log = loaded ?? new List<T>();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Log file not found when loading.");
                _log = new List<T>();
            }
            catch (Exception ex) { Console.WriteLine($"Error loading from file: {ex.Message}"); }
        }
    }
}
