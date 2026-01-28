using System.Data;

namespace Day1
{
    internal static class BusinessLogicLayer
    {   
        public static DataTable getAllInstructors()
        {
           return DBLayer.Select("select I.ins_id, I.ins_name, I.salary, D.Dept_name from Instructor I inner join Department D on I.Dept_id = D.Dept_id");
        }

        public static DataTable getAllDepartments()
        {
            return DBLayer.Select("select Dept_id, Dept_name from Department");
        }

        public static int deleteInstructor(int id)
        {
            return DBLayer.Delete("delete from Instructor where ins_id=@id", id);
        }

        public static int updateInstructor(int? id, string name, double salary, int dept_id)
        {
            return DBLayer.Update("update Instructor set ins_name = @name, salary= @salary, Dept_id=@dept_id where ins_id=@id", id, name, salary, dept_id);
        }

        public static int createInstructor(string name, double salary, int dept_id)
        {
            return DBLayer.Create("insert into Instructor(ins_name, salary, dept_id ) values(@name, @salary, @dept_id)", name, salary, dept_id);
        }

    }
}
