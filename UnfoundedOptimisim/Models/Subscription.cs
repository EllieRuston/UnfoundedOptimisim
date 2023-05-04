using System.ComponentModel.DataAnnotations;

namespace UnfoundedOptimism.Models
{
    public class Subscription
    {
        [Key]
        public int SubID { get; set; }
        public string SubName { get; set; }
        public string Type { get; set; }
        public int Frequency { get; set; }
        public int NumOfBottles { get; set; }
        public int RewardPoints { get; set; }
    }
}