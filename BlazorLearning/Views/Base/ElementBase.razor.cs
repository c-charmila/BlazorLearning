using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorLearning.Models.ElementBases;
using Microsoft.AspNetCore.Components;

namespace BlazorLearning.Views.Base
{
    public partial class ElementBase : ComponentBase
    {
        [Parameter]
        public ElementState State { get; set; }

        [Parameter]
        public RenderFragment Loading { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public RenderFragment Error { get; set; }

        public RenderFragment GetFragment()
        {
            return this.State switch
            {
                ElementState.Loading => Loading,
                ElementState.Content => Content,
                _ => Error
            };
        }
    }
}
