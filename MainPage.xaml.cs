using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace XamarinApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Employee> Employees { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            Employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ronald", LastName = "Rumple",
                    Designation = "Network Administrator"
                },
                new Employee
                {
                    FirstName = "Brett", LastName = "Banner",
                    Designation = "Software Developer"
                },
                new Employee
                {
                    FirstName = "Alice", LastName = "Anderson",
                    Designation = "Accountant"
                },
                new Employee
                {
                    FirstName = "James", LastName = "Butler",
                    Designation = "Finance"
                },
                new Employee
                {
                    FirstName = "Carmen", LastName = "Alia",
                    Designation = "Operations"
                }
            };

        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
    }
}
