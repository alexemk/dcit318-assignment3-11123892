# AssignmentSolutions (Submission-Ready, .NET 6)

**Author:** Alex Kotoka  
**Student ID:** 11123892  
**Date:** August 2025

This solution implements **five** independent programming tasks as a single console application, organized by folders:

- **Q1 (Finance):** Records, interfaces, sealed classes; processors and a `SavingsAccount` enforcing insufficient-funds rule.
- **Q2 (Health):** Generic repository, `Patient`/`Prescription`, grouping via `Dictionary<int, List<Prescription>>`.
- **Q3 (Warehouse):** Generic inventory repository with custom exceptions and try/catch usage in manager methods.
- **Q4 (Grading):** File I/O, validation, and custom exceptions; reads students, assigns grades, writes report.
- **Q5 (Inventory Logger):** Immutable record + generic logger with JSON persistence and robust file handling.

## Build & Run

1. Install **.NET 6 SDK**.
2. Open a terminal in this folder.
3. Run:
   ```bash
   dotnet build
   dotnet run
   ```

### Outputs and Files
- Q4 will use/create `students_input.txt` and write `students_report.txt` in the run directory.
- Q5 will create `inventory_log.json` in the run directory.

All code files contain author and student ID headers and inline comments for clarity.
