﻿namespace DoIT.Data.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Gpa { get; set; }
        public Lector Lector { get; set; }
        public int LectorId { get; set; }
    }
}
