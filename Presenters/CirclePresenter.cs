using DemoMVP.Models;
using DemoMVP.View;
using System;

namespace DemoMVP.Presenters
{
    public class CirclePresenter
    {
        IView _view;

        public CirclePresenter(IView view)
        {
            _view = view;
        }

        public double CalculateCircleArea()
        {
            CircleModel model = new CircleModel();
            _view.txtArea = model.GetArea(double.Parse(_view.txtRadius)).ToString();
            return Convert.ToDouble(_view.txtArea);
        }

    }
}