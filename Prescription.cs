// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;

namespace AssignmentSolutions.Q2.Health
{
    public class Prescription
    {
        public int Id { get; }
        public int PatientId { get; }
        public string MedicationName { get; }
        public DateTime DateIssued { get; }

        public Prescription(int id, int patientId, string medicationName, DateTime dateIssued)
        {
            Id = id; PatientId = patientId; MedicationName = medicationName; DateIssued = dateIssued;
        }

        public override string ToString() => $"Rx #{Id} for Patient {PatientId}: {MedicationName} on {DateIssued:d}";
    }
}
