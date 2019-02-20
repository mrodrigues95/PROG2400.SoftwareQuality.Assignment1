/*
 * SimpleConversionViewModel.cs
 * 
 * Purpose:
 * Store numbers that the user wishes to convert to binary or decimal.
 * 
 * Revision History:
 * Marcus Rodrigues, February 20/2019: Created.
 * 
 */

namespace MRAssignment1.Models
{
    public class SimpleConversionViewModel
    {
        public int NumberToBeConverted { get; set; }
        public int Result { get; set; }
    }
}
