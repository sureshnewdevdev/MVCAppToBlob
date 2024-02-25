using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppToBlob.Models
{
    /// <summary>
    /// This class contains defination of attendence
    /// </summary>
    public class Attendence
    {
        /// <summary>
        /// Name of the Student
        /// </summary>
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProjectCode { get; set; }

       
    }
}
