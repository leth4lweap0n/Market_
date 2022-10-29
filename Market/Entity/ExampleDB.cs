using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using Newtonsoft.Json;

namespace Market.Entity
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard
    }

    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] 
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Permission { get; set; }
    }

    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Barkod { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Stock { get; set; }
    }

    public class ConfirmedSalesInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public int MoneyEarned { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
    public class CancelledSalesInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public int UnearnedMoney { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }


    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Barkod { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Count { get; set; }
    }

    
    public class QuickSaleCommonProducts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ProductBarkod { get; set; }
    }
}
