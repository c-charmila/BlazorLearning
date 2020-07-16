using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorLearning.Models.ElementBases;
using BlazorLearning.Models.SearchComponent.Exceptions;
using Microsoft.AspNetCore.Components;

namespace BlazorLearning.Views.Components
{
    public partial class SearchComponent : ComponentBase
    {
        public ElementState State { get; set; }
        public string ErrorMessage { get; set; }
        public SearchComponentException SearchcomponentException { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                await Task.Delay(3000);
                this.State = ElementState.Content;
                await Task.Delay(3000);
                throw new Exception();
            }
            catch (Exception exception)
            {
                this.SearchcomponentException = new SearchComponentException(exception);
                this.ErrorMessage = this.SearchcomponentException.Message;
                State = ElementState.Error;
            }
        }
    }
}
