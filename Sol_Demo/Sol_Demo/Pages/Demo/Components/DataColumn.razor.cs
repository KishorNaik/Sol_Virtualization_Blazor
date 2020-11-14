using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo.Components
{
    public partial class DataColumn<TItem>
    {
        [Parameter]
        public TItem Item { get; set; }
    }
}