using System.ComponentModel.DataAnnotations;

namespace Core.Enums
{
    public enum TransmissionTypeEnum
    {
        [Display(Name = "Auto")]
        Auto = 0,
        [Display(Name = "Manual")]
        Manual = 1
    }
}
