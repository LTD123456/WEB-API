using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_QLBanHang.Models
{
    public class UtilsID
    {
        [Key]
        public string IDCode { get; set; }

        public string NameCode { get; set; }
        public int Start { get; set; }
        public string Explain { get; set; }
        public int Length { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
