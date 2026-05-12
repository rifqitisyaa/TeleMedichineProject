namespace TeleMedichineProject.Models.DTO
{
    public class TariffDto
    {
        public decimal CostPrice { get; set; }
        public decimal? StandardPrice { get; set; }
        public decimal? CustomerPrice { get; set; }
        public decimal? PersonalPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal LaborCost { get; set; }
        public decimal? MinVariablePrice { get; set; }
        public decimal? MaxVariablePrice { get; set; }
        public bool? IsDifferentClass { get; set; }
    }
}
