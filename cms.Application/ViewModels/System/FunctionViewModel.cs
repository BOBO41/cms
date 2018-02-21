using cms.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cms.Application.ViewModels.System
{
    public class FunctionViewModel
    {
        [Required]
        public string Name { set; get; }
        [Required]
        public string URL { set; get; }
        public string ParentId { set; get; }
        public string IconCss { get; set; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}
