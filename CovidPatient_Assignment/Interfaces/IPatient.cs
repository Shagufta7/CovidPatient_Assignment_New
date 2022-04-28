using CovidPatient_Assignment.Models;
namespace CovidPatient_Assignment.Interfaces
{
    public interface IPatient
    {
        List<Patient> patients { get; set; }

        List<Patient> GetPatients();
        Patient GetPatient();

    }
}
