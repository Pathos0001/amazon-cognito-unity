﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.CodeAnalysis
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\code\dotnet\sdk\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\PropertyValueAssignmentAnalyzer.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class PropertyValueAssignmentAnalyzer : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

using Amazon.CodeAnalysis.Shared;

namespace ");
            
            #line 20 "C:\code\dotnet\sdk\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\PropertyValueAssignmentAnalyzer.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".CodeAnalysis\r\n{\r\n\t[DiagnosticAnalyzer(LanguageNames.CSharp)]\r\n\tpublic class Prop" +
                    "ertyValueAssignmentAnalyzer : AbstractPropertyValueAssignmentAnalyzer\r\n\t{\r\n\t\tpub" +
                    "lic override string GetServiceName()\r\n\t\t{\r\n\t\t\treturn \"");
            
            #line 27 "C:\code\dotnet\sdk\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\PropertyValueAssignmentAnalyzer.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t}\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}