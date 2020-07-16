using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorLearning.Views.Base
{
    public partial class TextBoxBase : ComponentBase
    {
        [Parameter]
        public int Count { get; set; }

        [Parameter]
        public RenderFragment MoreThanZero { get; set; }

        [Parameter]
        public RenderFragment ZeroOrBelow { get; set; }

        public RenderFragment GetFragmentBasedOnCount()
        {
            return this.Count switch
            {
                { } when Count > 0 => MoreThanZero,
                _ => ZeroOrBelow
            };
        }
    }
}
