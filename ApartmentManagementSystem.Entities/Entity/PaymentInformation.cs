﻿using ApartmentManagementSystem.Core.BaseEntity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class PaymentInformation : IEntity
    {
        public int Id { get; set; }
        public bool IsPayed { get; set; }
        public DateTime? DateOfPayment { get; set; } = null;
        public decimal Price { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string? PaymentType { get; set; } = null;


        //fatura türü
        public int? InvoiceTypeId { get; set; }
        public InvoiceType? InvoiceType { get; set; }

        //ödeyen kullanıcı
        [ForeignKey("User")]
        public Guid? UserId { get; set; }
        public User? User { get; set; }

        //daire
        public int FlatId { get; set; }
        public Flat? Flats { get; set; }

    }
}
