namespace Day7OOPDemoLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Session 7 part 1 
            /*
            1 - Object & Class           Done
            2 - Inheritance              Access Modifier
            3 - Polymorphism             Done OverLoading
            4 - Encapsulation            Property Full - Auto (hidden Fields) | hidden Data DLL
            5 - Abstraction
            */

            /*
                ..* Task
            1 - Object & Class     Member class          
            2 - Inheritance             
            3 - Polymorphism            
            4 - Encapsulation           
            5 - Abstraction  (Abstract Class - Interface)
                Company 
             */

            int x = 100;
            int y = 100;
            bool result = x == y;
            int z = x;
            Console.WriteLine(x);
            Console.WriteLine(x += 50);
            Console.WriteLine(z);

            Console.WriteLine(result);
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.Name = "Ahmed";
            Employee e2 = new Employee();
            e2.Id = 1;
            e2.Name = "Ahmed";

            bool resultRef = e1 == e2;
            Console.WriteLine(resultRef);

            Employee e3 = e1;
            e1.Id = 5;
            Console.WriteLine(e1.Id);
            Console.WriteLine(e3.Id);
            //DRY
            //Console.WriteLine(" ----------------- Read All Employee --------------- ");
            //foreach (Employee e in Employee.Employees)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            //Add 
            Employee addEmp = new Employee();
            addEmp.GetAll();
            addEmp.Id = 5;
            addEmp.Name = "Sayed";
            addEmp.Code = 109;
            addEmp.Job = "Eng";
            addEmp.Save(addEmp);
            Console.WriteLine("Saving Done ....");
            addEmp.GetAll();
            //Console.WriteLine(" ----------------- Read All Employee --------------- ");
            //foreach (Employee e in Employee.Employees)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            var emp = new Employee() { Id = 1, Code = 101, Name = "Mahmoud", Job = "Dev" };
            emp.Id = 5;

            new Employee { Id = 1, Code = 101, Name = "Mahmoud", Job = "Dev" };

            var xx = new { Id = 5, Salary = 50000, FullName = "SayedHawas", Email = "Sayed@yahoo.com" };
            xx.Id = 10;

            #endregion

                        #region Task - Full CRUD with OOP Concepts
                        /*
                         * OOP Concepts Demonstrated:
                         * 1 - Object & Class:    Employee class with properties and methods
                         * 2 - Inheritance:       Employee inherits from Human (abstract class)
                         * 3 - Polymorphism:      Override SayHello() and ToString() methods
                         * 4 - Encapsulation:     Private fields (_id, _name, code) with public properties
                         * 5 - Abstraction:       Human (abstract class) + IOperation, ISendEmail (interfaces)
                         */

                        Console.WriteLine("\n========== FULL CRUD DEMO ==========\n");

                        // Create an Employee object (Object & Class)
                        Employee empService = new Employee();

                        // -------- CREATE --------
                        Console.WriteLine(">>> CREATE - Adding new employee");
                        Employee newEmp = new Employee() { Id = 10, Name = "Omar", Code = 110, Job = "Manager" };
                        empService.Save(newEmp);
                        empService.GetAll();

                        // -------- READ ALL --------
                        Console.WriteLine("\n>>> READ ALL - Display all employees");
                        empService.GetAll();

                        // -------- READ BY ID --------
                        Console.WriteLine("\n>>> READ BY ID - Get employee with Id = 2");
                        empService.GetById(2);

                        // -------- UPDATE --------
                        Console.WriteLine("\n>>> UPDATE - Update employee with Id = 2");
                        Employee updatedEmp = new Employee() { Name = "Tamer Updated", Code = 202, Job = "Senior Developer" };
                        empService.Update(2, updatedEmp);
                        empService.GetAll();

                        // -------- DELETE --------
                        Console.WriteLine("\n>>> DELETE - Delete employee with Id = 3");
                        empService.Delete(3);
                        empService.GetAll();

                        // -------- POLYMORPHISM Demo --------
                        Console.WriteLine("\n>>> POLYMORPHISM - Override methods");
                        Console.WriteLine(empService.SayHello());    // Overridden from Human
                        Console.WriteLine(empService.ToString());    // Overridden ToString

                        // -------- INTERFACE Demo (ISendEmail) --------
                        Console.WriteLine("\n>>> ABSTRACTION - Using Interface");
                        // empService.SendEmail("test@email.com"); // Throws NotImplementedException

                        Console.WriteLine("\n========== END CRUD DEMO ==========");
                        #endregion

                        Console.ReadLine();
        }
    }
}
