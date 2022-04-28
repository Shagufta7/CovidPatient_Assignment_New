using CovidPatient_Assignment.Data;
using CovidPatient_Assignment.Interfaces;
using CovidPatient_Assignment.Models;

namespace CovidPatient_Assignment.Repository
{
   
    public class PatientRepository : IPatient
    {
        private readonly ApplicationDbContext _context;

       
        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Patient> patients { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Patient> GetPatient()
        {
            List<Patient> patients = _context.Patients.ToList();
            return patients;
        }

        public List<Patient> GetPatients()
        {
            //IEnumerable<Patient> objCatlist = _context.Patients;
            //return (List<Patient>)objCatlist;
            List<Patient> objCatlist = _context.Patients.ToList();
            return objCatlist;
        }

        Patient IPatient.GetPatient()
        {
            throw new NotImplementedException();
        }
    }
}
