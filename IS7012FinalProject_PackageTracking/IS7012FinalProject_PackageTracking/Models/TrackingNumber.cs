using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Models
{
    public class TrackingNumber
    {
        [Key]
        [Display(Name = "Tracking Id")]
        public int TrackingNumberId { get; set; }

        [Display(Name = "User Information")]
        public User User { get; set; }
        public int UserId { get; set; }


        [Display(Name = "Package Information")]
        public Package Package { get; set; }
        public int PackageId { get; set; }


        [Display(Name = "Deliverer Information")]
        public Deliverer Deliverer { get; set; }
        public int DelivererId { get; set; }

        [Display(Name = "Tracking Number")]
        public string trackingNumber => TrackingNumberId.ToString() + UserId.ToString() + PackageId.ToString() + DelivererId.ToString();

    }
}
