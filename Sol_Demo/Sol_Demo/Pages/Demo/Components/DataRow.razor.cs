using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo.Components
{
    public partial class DataRow
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public String Style { get; set; }

        [Parameter]
        public String Key { get; set; }
    }
}