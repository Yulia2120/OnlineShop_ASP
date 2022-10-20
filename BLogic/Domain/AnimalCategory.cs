#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace BLogic.Domain
{
    public class AnimalCategory : Identity
    {
        [StringLength(90)]
        public string AnimalName { get; set; }
       

       
    }
}