﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingRepository.Business
{
  public  class CheckBook
    {
        [Key]
        public int Check_id { get; set; }
        public string Check_User_name { get; set; }
        public string Check_apply_Date { get; set; }
        public string Check_status { get; set; }
        public string Check_fixed_Date { get; set; }

    }
}
