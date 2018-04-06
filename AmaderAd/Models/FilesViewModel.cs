using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AmaderAd.Helpers;


namespace AmaderAd.Models
{
    public class FilesViewModel
    {
        public ViewDataUploadFilesResult[] Files { get; set; }
    }
}