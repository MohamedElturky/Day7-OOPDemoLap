namespace Day7OOPDemoLab
{
    public interface IOperation
    {
        //private int _id;

        //.Net 9 ,10
        //public void Save()
        //{
        //}

        // CRUD Operations
        void Save(Employee Entity);           // Create
        void GetAll();                         // Read All
        Employee GetById(int id);              // Read One
        void Update(int id, Employee NewEntity); // Update
        void Delete(int id);                   // Delete
    }
}
