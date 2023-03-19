using System.ComponentModel.DataAnnotations;

namespace Shopping_WebAPI1.Entities
{
    public class Entity
    {
        [Key] //Decoradores

        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; }//? indica que puede ser null
        public DateTime? ModifiedDate { get; set; }
    }
}
