using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLibrary
{
    public class Customer
    {
        public int CustNo { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int  RewardPoints { get; set; }
        public bool SeniorCitizen  { get; set; }
        public int Age { get; set; }



        public Customer()
        {
            this.CustNo = 0;
            this.FirstName = " ";
            this.Address = " ";
            this.PhoneNumber = " ";
            this.Email = " ";
            this.RewardPoints = 0;
            this.SeniorCitizen = false;
            this.Age = 0;

        }
        public Customer(int custnum , string firstName,string address ,string phoneNum, string email, int rewardPoints,
            bool seniorCitizen, int age)
        {
            this.CustNo = custnum;
            this.FirstName = firstName;
            this.Address = address;
            this.PhoneNumber = phoneNum;
            this.Email = email;
            this.RewardPoints = rewardPoints;
            this.SeniorCitizen = seniorCitizen;
            this.Age = age;

        }

    


    }
}