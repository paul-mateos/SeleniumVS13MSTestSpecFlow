using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAAutomationSolution.Environment
{
    public enum EnvironmentType
    {
        [Description("PreProd")]
        PreProd = 0,
        [Description("SIT_BLACK")]
        SIT_BLACK = 1,
        [Description("SIT_WHITE")]
        SIT_WHITE = 2,
        [Description("SIT_GREEN")]
        SIT_GREEN = 3,
        [Description("SIT_ORANGE")]
        SIT_ORANGE = 4,
        [Description("SIT_BLUE")]
        SIT_BLUE = 5,
        [Description("SIT_YELLOW")]
        SIT_YELLOW = 6,
        [Description("SIT_PINK")]
        SIT_PINK = 7,
        [Description("SIT_PURPLE")]
        SIT_PURPLE = 8,
        [Description("SIT_BROWN")]
        SIT_BROWN = 9,

    }
}
