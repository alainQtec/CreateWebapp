using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Created based on the Guide https://www.red-gate.com/simple-talk/development/dotnet-development/using-c-to-create-powershell-cmdlets-the-basics/
namespace CreateWebapp
{
    [Cmdlet(VerbsCommon.New, "WebApp")]
    [OutputType(typeof(WebappTemplate))]
    public class NewWebApp : Cmdlet
    {
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
                Position = 0,
                ValueFromPipelineByPropertyName = true,
                ValueFromPipeline = true)]
        [Alias("vendor")]
        public string[] Author { get; set; }

        [Parameter(Position = 3)]
        public int Id { get; set; }
     
    }
}

namespace CreateWebapp
{
    public class WebappTemplate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Author { get; set; }
    }
}
