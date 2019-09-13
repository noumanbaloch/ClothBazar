using System.ComponentModel.DataAnnotations;

namespace ClothBazar.Entites
{
    public class Config
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
