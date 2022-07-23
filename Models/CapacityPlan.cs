using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{

    [Table("capacity_plan")]
    public class CapacityPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("cap_view", TypeName = "varchar(200)")]
        public string CapView { get; set; }

        [Column("week_start", TypeName = "varchar(200)")]
        public string WeekStart { get; set; }

        [Column("status", TypeName = "varchar(200)")]
        public string Status { get; set; }

        // Foreign key   
        [ForeignKey("cp_details_id")]
        public virtual CapacityPlanDetails CapacityPlanDetails { get; set; }

        [Column("is_deleted", TypeName = "tinyint(1)")]
        public bool IsDeleted { get; set; }

        public CapacityPlan()
        {
            IsDeleted = false;
        }

    }
}
