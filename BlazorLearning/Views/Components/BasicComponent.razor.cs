using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorLearning.Models.ElementBases;
using Microsoft.AspNetCore.Components;

namespace BlazorLearning.Views.Components
{
    public partial class BasicComponent : ComponentBase
    {
        [Parameter]
        public RenderFragment ContentComponent { get; set; }

        [Parameter]
        public ElementState State { get; set; }

        [Parameter]
        public string ErrorMessage { get; set; }

    }
}
