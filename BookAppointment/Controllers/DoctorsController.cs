using BookAppointment.Data;
using BookAppointment.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAppointment.Controllers
{
    
    public class DoctorsController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

       
        public IActionResult BookAppointment()
        {

            var doctors = dbContext.Doctors;
            return View(doctors);
        }
        public IActionResult CompleteAppointment(String doctorName)
        {
            var doctor = dbContext.Doctors.FirstOrDefault(d => d.Name == doctorName);

            return View(doctor);
        }

        public IActionResult Create(Appointments appointments)
        {
            if (appointments == null)
            {
                return RedirectToAction("NotFoundPage","Home");
            }
            else {
                dbContext.Appointments.Add(new()
                {
                    AppointmentDate = appointments.AppointmentDate,
                    DoctorId = appointments.DoctorId,
                    PatientName = appointments.PatientName,
                    AppointmentTime = appointments.AppointmentTime
                });
                dbContext.SaveChanges();
                return RedirectToAction("BookAppointment");
            }
           
            
        }

    }
}
