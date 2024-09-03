﻿using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class Account
    {
        public static ReportViewModel ReportFormMain()
        {
            ReportViewModel rp = new ReportViewModel();
            using(UnitOfWork db = new UnitOfWork())
            {
                DateTime StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var recive = db.AccountingRepository
                    .Get(a => a.TypeID == 1 && a.DateTime >= StartDate && a.DateTime <= EndDate)
                    .Select(a=>a.Amount)
                    .ToList();

                var pay = db.AccountingRepository
                    .Get(a => a.TypeID == 2 && a.DateTime >= StartDate && a.DateTime <= EndDate)
                    .Select(a => a.Amount)
                    .ToList();

                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (recive.Sum() - pay.Sum());
            }
            return rp;
        }
    }
}