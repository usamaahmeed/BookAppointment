namespace BookAppointment.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
