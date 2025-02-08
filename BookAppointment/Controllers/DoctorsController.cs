using BookAppointment.Data;
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
      
    }
}
