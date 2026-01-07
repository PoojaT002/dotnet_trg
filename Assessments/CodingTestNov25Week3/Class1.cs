using System.Reflection.PortableExecutable;

namespace CodingTestNov25Week3
{
    public class Class1
    {
        public class EmployeeRecord
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }
            public bool IsVetran { get; set; }
        }

        public interface IEmployeeDataReader
        {
            EmployeeRecord GetEmployeeRecord(int employeeId);
        }

        public class MockEmployeeDataReader : IEmployeeDataReader
        {
            public EmployeeRecord GetEmployeeRecord(int employeeId)
            {
                if (employeeId == 101)
                    return new EmployeeRecord { Id = 101, Name = "Pooja", Role = "Manager", IsVetran = true };

                if (employeeId == 102)
                    return new EmployeeRecord { Id = 102, Name = "Preeti", Role = "Manager", IsVetran = false };

                if (employeeId == 103)
                    return new EmployeeRecord { Id = 103, Name = "Amit", Role = "Developer", IsVetran = true };

                if (employeeId == 104)
                    return new EmployeeRecord { Id = 104, Name = "Arun", Role = "Intern", IsVetran = false };

                return new EmployeeRecord { Id = employeeId, Name = "Unknown", Role = "Other", IsVetran = false };
            }
        }

        public class PayrollProcessor
        {
            private readonly IEmployeeDataReader _reader;

            private static readonly Dictionary<int, decimal> BaseSalaries = new()
            {
                [101] = 65000m,
                [102] = 120000m,
                [103] = 52000m,
                [104] = 135000m
            };

            public PayrollProcessor(IEmployeeDataReader reader)
            {
                _reader = reader;
            }

            public decimal CalculateTotalCompensation(int employeeId)
            {
                var emp = _reader.GetEmployeeRecord(employeeId);

                BaseSalaries.TryGetValue(employeeId, out decimal salary);

                decimal bonus = emp switch
                {
                    { Role: "Manager", IsVetran: true } => 10000m,
                    { Role: "Manager", IsVetran: false } => 5000m,
                    { Role: "Developer" } => 2000m,
                    { Role: "Intern" } => 500m,
                    _ => 0m
                };

                return salary + bonus;
            }
        }
    }
}
