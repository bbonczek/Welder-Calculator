﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WelderCalculator.MaterialModificationView.Serialization;

namespace WelderCalculator.Drawings.SchaefflerChartView
{
    public class SchaefflerChartPresenter
    {
        private readonly ISchaefflerChartView _view;
        private readonly DataConnector _dataConnector;
        private readonly Chart _chart;

        public SchaefflerChartPresenter(ISchaefflerChartView view)
        {
            _view = view;
            _view.Presenter = this; 
            _dataConnector = new DataConnector();

            _chart = new Chart(_dataConnector.GetSchaefflerImages());
        }

        public void OnPaintEvent(IntPtr panelHandle, PaintEventArgs e)
        {
            _chart.Resize(_view.DrawPanelWidth, _view.DrawPanelHeight);

            Graphics graphics = Graphics.FromHwnd(_view.DrawPanelCanvas);
            _chart.Draw(graphics);
        }

    }
}
