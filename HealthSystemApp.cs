// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentSolutions.Q2.Health
{
    public class HealthSystemApp
    {
        private readonly Repository<Patient> _patientRepo = new();
        private readonly Repository<Prescription> _prescriptionRepo = new();
        private Dictionary<int, List<Prescription>> _prescriptionMap = new();

        public void SeedData()
        {
            _patientRepo.Add(new Patient(1, "Alice Smith", 30, "Female"));
            _patientRepo.Add(new Patient(2, "Bob Johnson", 45, "Male"));
            _patientRepo.Add(new Patient(3, "Cynthia Lee", 28, "Female"));

            _prescriptionRepo.Add(new Prescription(1, 1, "Amoxicillin 500mg", DateTime.Today.AddDays(-10)));
            _prescriptionRepo.Add(new Prescription(2, 2, "Lisinopril 10mg", DateTime.Today.AddDays(-5)));
            _prescriptionRepo.Add(new Prescription(3, 1, "Ibuprofen 200mg", DateTime.Today.AddDays(-2)));
            _prescriptionRepo.Add(new Prescription(4, 3, "Cetirizine 10mg", DateTime.Today.AddDays(-1)));
            _prescriptionRepo.Add(new Prescription(5, 2, "Metformin 500mg", DateTime.Today));
        }

        public void BuildPrescriptionMap()
        {
            _prescriptionMap = _prescriptionRepo.GetAll()
                .GroupBy(p => p.PatientId)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public void PrintAllPatients()
        {
            Console.WriteLine("All patients:");
            foreach (var p in _patientRepo.GetAll())
                Console.WriteLine(" - " + p);
        }

        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            return _prescriptionMap.TryGetValue(patientId, out var list) ? list : new List<Prescription>();
        }

        public void PrintPrescriptionsForPatient(int id)
        {
            var rx = GetPrescriptionsByPatientId(id);
            Console.WriteLine($"Prescriptions for patient {id}:");
            if (rx.Count == 0) Console.WriteLine(" (none)");
            foreach (var r in rx) Console.WriteLine(" - " + r);
        }

        public void Run()
        {
            Console.WriteLine("=== QUESTION 2: Health System ===");
            SeedData();
            BuildPrescriptionMap();
            PrintAllPatients();
            Console.WriteLine();
            PrintPrescriptionsForPatient(1);
            Console.WriteLine();
        }
    }
}
