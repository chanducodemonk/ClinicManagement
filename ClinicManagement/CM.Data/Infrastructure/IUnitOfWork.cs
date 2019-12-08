﻿using CM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        DataRepository<Patient> PatientRepository { get; set; }
        void SaveChanges();
    }
}
