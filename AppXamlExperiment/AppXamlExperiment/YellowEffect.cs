using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXamlExperiment
{
    public class YellowEffect : RoutingEffect
    {
        public YellowEffect() : base("EffectsSample.LabelBGYellowEffect")
        {
            Label lblheader = new Label();
            lblheader.Effects.Add(Effect.Resolve("EffectsSample.LabelBGYellowEffect"));
        }
    }
}
