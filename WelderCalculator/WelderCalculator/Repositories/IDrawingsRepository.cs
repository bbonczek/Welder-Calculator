﻿using System.Collections.Generic;
using System.Drawing;
using WelderCalculator.Drawings.Chart;
using WelderCalculator.Model;

namespace WelderCalculator.Repositories
{
    public interface IDrawingsRepository
    {
        List<Layer> GetSchaefflerChartImages();
        ChartSizing DeserializeSchaefflerChartSizing();

        List<Layer> GetDeLongChartImages();
        ChartSizing DeserializeDeLongChartSizing();

        Image GetKsLogoImage();
    }
}
