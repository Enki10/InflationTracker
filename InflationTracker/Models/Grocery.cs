using System.ComponentModel.DataAnnotations;

namespace InflationTracker.Models
{
    public class Grocery
    {
        public int Id { get; set; }
        public CategNames category { get; set; }
        public SMNameType smname { get; set; }
        public String groceryName { get; set; }

        [Required(ErrorMessage = "Enter the issued date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime IssueDate { get; set; }
        public int price { get; set; }
        public Grocery()
        {

        }  
    }

    public enum CategNames { Meat, Veggies, Fruits, FlourBased, Other };
    public enum SMNameType { Mercadona, Lidl, Aldi, Bonpreu, Consum, Caprabo, Carrefour, Dia };
}
