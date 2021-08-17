﻿namespace Calculator.Pages
{
    public class PossibleCombination
    {
        public string BushingImperial { get; set; }
        public double BushingMetric { get; set; }
        public string TemplateImperial { get; set; }
        public double TemplateMetric { get; set; }

        public PossibleCombination(double Bushing, double Template)
        {
            BushingMetric = Bushing;
            BushingImperial = FractionExtension.ToFraction(BushingMetric / 25.4);
            TemplateMetric = Template;
            TemplateImperial = FractionExtension.ToFraction(Template / 25.4);
        }
    }
}