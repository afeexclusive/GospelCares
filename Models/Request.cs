using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models
{
    public class Request
    {
        public int RequestId { get; set; }

        
        public string FullName { get; set; }

        
        [Display(Name ="Pastor In Charge")]
        public string PastorName { get; set; }

       
        public string Branch { get; set; }
        public NeedItems Need { get; set; }

       
        public string Phone { get; set; }

        
        public string Address { get; set; }
        public NeedStatus Status { get; set; }

    }

    public enum NeedItems
    {
        Food,
        Cash
    }

    public enum NeedStatus
    {
        Unconfirmed,
        Confirmed,
        Treated
    }

    public enum BankNames
    {
        
        
        Access,
        [Display(Name = "Eco Bank")]
        Eco,
        FCMB,
        [Display(Name = "Fidelity Bank")]
        Fidelity,
        [Display(Name = "First Bank")]
        First_Bank,
        GTBank,
        [Display(Name = "Polaris(Skye)")]
        Polaris_Skye,
        [Display(Name = "Stanbic IBTC")]
        Stanbic_IBTC,
        [Display(Name = "Sterling Bank")]
        Sterling,
        UBA,
        [Display(Name = "Unity Bank")]
        Unity,
        Wema,
        Zenith
    }
}
