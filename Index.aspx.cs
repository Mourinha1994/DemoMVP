using DemoMVP.Presenters;
using DemoMVP.View;
using System;

namespace DemoMVP
{
    public partial class Index : System.Web.UI.Page, IView
    {
        public string txtArea
        {
            get => lblArea.Text;
            set => lblArea.Text = value;
        }
        string IView.txtRadius
        {
            get => txtRadius.Text;
            set => txtRadius.Text = value;
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            CirclePresenter presenter = new CirclePresenter(this);
            presenter.CalculateCircleArea();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}