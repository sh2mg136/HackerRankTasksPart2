namespace EqualizeTheArray
{
    internal class EmployeeOperations
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){ Company = "Samsung", FirstName = "John", LastName = "Walker", Age = 35 },
            new Employee(){ Company = "Samsung", FirstName = "John", LastName = "Smith", Age = 36 },
            new Employee(){ Company = "Samsung", FirstName = "Albert", LastName = "Einchtein", Age = 30 },
            new Employee(){ Company = "Amazon", FirstName = "Ivan", LastName = "Markes", Age = 26 },
            new Employee(){ Company = "Amazon", FirstName = "Fore", LastName = "Gnassimbe", Age = 25 },
            new Employee(){ Company = "Amazon", FirstName = "Nikolas", LastName = "Maduro", Age = 40 },
            new Employee(){ Company = "Amazon", FirstName = "Joe", LastName = "Baiden", Age = 50 },
            new Employee(){ Company = "Google", FirstName = "Kristianu", LastName = "Ronaldo", Age = 30 },
            new Employee(){ Company = "Google", FirstName = "Leo", LastName = "Messi", Age = 31 },
            new Employee(){ Company = "Google", FirstName = "Bred", LastName = "Pitt", Age = 32 },
            new Employee(){ Company = "Google", FirstName = "Charles", LastName = "Savarin", Age = 39 },
            new Employee(){ Company = "Google", FirstName = "Peter", LastName = "Gabriel", Age = 36 },
            new Employee(){ Company = "Google", FirstName = "Frank", LastName = "Gabriel", Age = 40 },
        };

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var list = employees.GroupBy(x => x.Company).Select(x => new
            {
                Company = x.Key,
                Age = x.Average(e => e.Age)
            }).ToList();

            return list
            .OrderBy(x => x.Company)
            .ThenBy(x => Math.Round(x.Age, 0))
            .ToDictionary(x => x.Company, x => (int)Math.Round(x.Age, 0));
        }

        private static int roundUp(double d)
        {
            if (d % 1 == 0) return (int)d;
            return (int)d + 1;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var list = employees.GroupBy(x => x.Company).Select(x => new
            {
                Company = x.Key,
                Cnt = x.Count()
            })
            .OrderBy((x => x.Company))
            .ToList();

            return list.OrderBy(x => x.Company).ThenBy(x => x.Cnt).ToDictionary(x => x.Company, x => x.Cnt);
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var dict = new Dictionary<string, Employee>();

            if (employees == null || !employees.Any())
                return dict;

            var companies = employees.GroupBy(x => x.Company)
                .Select(x => x.Key)
                .ToList();

            foreach (var c in companies.OrderBy(x => x))
            {
                var e = employees.Where(x => x.Company == c)
                .OrderByDescending(x => x.Age).FirstOrDefault();

                if (e != null)
                {
                    dict.Add(c, e);
                }
            }

            return dict;
        }
    }
}