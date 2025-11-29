using MrV___ng_1;

namespace Db_First_flame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read(select)
            /*using (HospitalDb12MrvContext db = new HospitalDb12MrvContext())
            {
                var doctors = db.Doctors.Where(d=> d.Salary > 3000);
                foreach (var doctor in doctors)
                {
                    Console.WriteLine(doctor);
                }
            }*/

            //insert
            /* using (HospitalDb12MrvContext db2 = new HospitalDb12MrvContext())
             {
                 Doctor newDoctor = new Doctor()
                 {
                     Name = "Brian",
                     Surname = "Moser",
                     Salary = 4000
                 };
                 db2.Doctors.Add(newDoctor);
                 db2.SaveChanges();
             }*/
            //Update
            /*using (HospitalDb12MrvContext db3 = new HospitalDb12MrvContext())
            {
                var doctorToUpdate = db3.Doctors.FirstOrDefault(d => d.Id == 1);
                if(doctorToUpdate != null)
                {
                    doctorToUpdate.Name = "Ice Truck";
                    doctorToUpdate.Surname = "Killer";
                    doctorToUpdate.Salary = 5000;
                    db3.SaveChanges();
                }
            }*/

            //delete
            /*using (HospitalDb12MrvContext db4 = new HospitalDb12MrvContext())
            {
                var doctorToDelete = db4.Doctors.FirstOrDefault(d => d.Id == 2);
                if(doctorToDelete != null)
                {
                    db4.Doctors.Remove(doctorToDelete);
                    db4.SaveChanges();
                }
            }*/
        }
    }
}
