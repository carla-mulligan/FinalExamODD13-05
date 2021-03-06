﻿/*
 * Name : Carla Mulligan 
 * Student Number: S00186667
 * Date: 13/05/2020
 * Subject: Final ODD Exam Sem2
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarlaMulligan_S00186667
{
    public class Phone
    {

        [Key] // needed to use this key to get the database to work
        public string Name { get; set; }

        public int Price { get; set; }

        public string Operating_System { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }
   

        public void IncreasePrice(decimal Pvalue)
        {

            Pvalue = (Pvalue + 100) / 100 * Price;


        }

        public override string ToString()
        {
            return string.Format("{0}", Name); 
        }



    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }

        public DbSet<Phone> Phones { get; set;  }



    }
        

    
}
