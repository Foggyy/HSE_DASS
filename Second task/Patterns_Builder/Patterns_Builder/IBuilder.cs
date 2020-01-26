using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    interface IBuilder
    {
        void SetupLegs();
        void SetupBase();
        void TightenTheScrews();
        void SetupSpecificDetail();
    }
}
