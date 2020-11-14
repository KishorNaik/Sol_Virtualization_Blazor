using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo.Components
{
    public partial class Table
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}