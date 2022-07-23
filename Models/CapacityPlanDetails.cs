using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models
{
    [Table("capacity_plan_details")]
    public class CapacityPlanDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name", TypeName = "varchar(200)")]
        public string Name { get; set; }

        [Column("date_from", TypeName = "varchar(200)")]
        public string DateFrom { get; set; }

        [Column("date_to", TypeName = "varchar(200)")]
        public string DateTo { get; set; }

        // Foreign key   
        [ForeignKey("project_id")]
        public virtual Project Project { get; set; }

        [Column("is_deleted", TypeName = "tinyint(1)")]
        public bool IsDeleted { get; set; }

        public CapacityPlanDetails() {
            IsDeleted = false;
        }

    }
}
