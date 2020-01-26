using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildFurniture()
        {
            builder.SetupLegs();
            builder.SetupBase();
            builder.TightenTheScrews();
            builder.SetupSpecificDetail();
            builder.TightenTheScrews();            
        }
    }
}
