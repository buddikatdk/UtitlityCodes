using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_handling
{
    class BloodBank
    {
        private string username;
        private DateTime date_of_birth;
        private int age;
        private string email_id;
        private long mobile_number;
        private string blood_group;

        public string Username { get => username; set => username = value; }
        public DateTime Date_of_birth { get => date_of_birth; set => date_of_birth = value; }
        public int Age { get => age; set => age = value; }
        public string Email_id { get => email_id; set => email_id = value; }
        public long Mobile_number { get => mobile_number; set => mobile_number = value; }
        public string Blood_group { get => blood_group; set => blood_group = value; }

        public BloodBank(string username, DateTime date_of_birth, int age, string email_id, long mobile_number, string blood_group)
        {
            this.username = username;
            this.date_of_birth = date_of_birth;
            this.age = age;
            this.email_id = email_id;
            this.mobile_number = mobile_number;
            this.blood_group = blood_group;
        }

        public bool CheckAge(BloodBank obj)
        {
            //if the age is less than 17 -> return true otherwise false
            if(obj.Age<17)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("Username:{0}\nDate of Birth:{1}\nAge:{2}\nEmail ID:{3}\nMobile number:{4}\nBlood group:{5}", username,date_of_birth.ToString("dd/MM/yyyy"),age,email_id,Mobile_number,blood_group);
        }

    }
}
