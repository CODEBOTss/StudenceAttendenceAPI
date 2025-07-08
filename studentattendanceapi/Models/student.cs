namespace studentattendanceapi.Models
{
    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int rollnumber { get; set; }
        public bool ispresent {  get; set; }
        
        public DateTime Date { get; set; }

    }
}
