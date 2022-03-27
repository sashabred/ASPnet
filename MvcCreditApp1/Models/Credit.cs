using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCreditApp1.Models
{
    public class Credit
    {
        public virtual int CreditId { get; set; }

        [DisplayName("Тип кредита")]
        [Required]
        public virtual string Head { get; set; }

        [DisplayName("Период")]
        [Required]
        public virtual int Period { get; set; }

        [DisplayName("Сумма")]
        [Required]
        public virtual int Sum { get; set; }

        [DisplayName("Процент")]
        public virtual int Procent { get; set; }
    }
}