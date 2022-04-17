namespace cafe.entity.Concrete
{
    public class User
    {
        public int ID { get; set; }
        public string FULLNAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORd { get; set; }
        public string MAIL { get; set; }
        public string PHONE { get; set; }
        public bool ISADMIN { get; set; }
        public DateTime CREATEDATE { get; set; }
    }
}