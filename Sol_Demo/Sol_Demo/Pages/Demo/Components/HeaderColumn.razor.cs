using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo.Components
{
    public partial class HeaderColumn
    {
        [Parameter]
        public string HeaderName { get; set; }
    }
}