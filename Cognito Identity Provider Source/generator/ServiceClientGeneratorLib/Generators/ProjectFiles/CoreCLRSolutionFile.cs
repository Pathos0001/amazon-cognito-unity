﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CoreCLRSolutionFile : CoreCLRSolutionFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.26730.12
MinimumVisualStudioVersion = 10.0.40219.1
Project(""{2150E333-8FDC-42A3-9474-1A3956D46DE8}"") = ""Core"", ""Core"", ""{9863FCB3-BFA4-4B9C-B8F6-302BA5F660B8}""
EndProject
");
            
            #line 12 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    foreach(var project in (IList<SolutionFileCreator.Project>)this.Session["CoreProjects"])
    {

            
            #line default
            #line hidden
            this.Write("Project(\"{9A19103F-16F7-4668-BE54-9A1E7A4F7556}\") = \"");
            
            #line 16 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 16 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectPath));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 16 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 18 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("Project(\"{2150E333-8FDC-42A3-9474-1A3956D46DE8}\") = \"Services\", \"Services\", \"{939" +
                    "EC5C2-8345-43E2-8F97-72EEEBEEA0AB}\"\r\nEndProject\r\n");
            
            #line 23 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    foreach(var folder in (List<SolutionFileCreator.ServiceSolutionFolder>)this.Session["ServiceSolutionFolders"])
    {

            
            #line default
            #line hidden
            this.Write("Project(\"{2150E333-8FDC-42A3-9474-1A3956D46DE8}\") = \"");
            
            #line 27 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 27 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 27 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 29 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"


        foreach(var project in folder.Projects)
        { 

            
            #line default
            #line hidden
            this.Write("Project(\"{9A19103F-16F7-4668-BE54-9A1E7A4F7556}\") = \"");
            
            #line 34 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 34 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectPath));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 34 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 36 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("Project(\"{2150E333-8FDC-42A3-9474-1A3956D46DE8}\") = \"Test\", \"Test\", \"{12EC4E4B-7E" +
                    "2C-4B63-8EF9-7B959F82A89B}\"\r\nEndProject\r\n");
            
            #line 42 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    foreach(var project in (IList<SolutionFileCreator.Project>)this.Session["TestProjects"])
    {

            
            #line default
            #line hidden
            this.Write("Project(\"{9A19103F-16F7-4668-BE54-9A1E7A4F7556}\") = \"");
            
            #line 46 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 46 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectPath));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 46 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 48 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("Global\r\n\tGlobalSection(SolutionConfigurationPlatforms) = preSolution\r\n\t\tDebug|Any" +
                    " CPU = Debug|Any CPU\r\n\t\tRelease|Any CPU = Release|Any CPU\r\n\tEndGlobalSection\r\n\tG" +
                    "lobalSection(ProjectConfigurationPlatforms) = postSolution\r\n");
            
            #line 57 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    foreach(var project in (IList<SolutionFileCreator.Project>)this.Session["CoreProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 61 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.ActiveCfg = Debug|Any CPU\r\n\t\t");
            
            #line 62 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.Build.0 = Debug|Any CPU\r\n\t\t");
            
            #line 63 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.ActiveCfg = Release|Any CPU\r\n\t\t");
            
            #line 64 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.Build.0 = Release|Any CPU\r\n");
            
            #line 65 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    }
    foreach(var folder in (List<SolutionFileCreator.ServiceSolutionFolder>)this.Session["ServiceSolutionFolders"])
    {
        foreach(var project in folder.Projects)
        {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 72 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.ActiveCfg = Debug|Any CPU\r\n\t\t");
            
            #line 73 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.Build.0 = Debug|Any CPU\r\n\t\t");
            
            #line 74 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.ActiveCfg = Release|Any CPU\r\n\t\t");
            
            #line 75 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.Build.0 = Release|Any CPU\r\n");
            
            #line 76 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

        }
    }
    foreach(var project in (IList<SolutionFileCreator.Project>)this.Session["TestProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 82 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.ActiveCfg = Debug|Any CPU\r\n\t\t");
            
            #line 83 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.Build.0 = Debug|Any CPU\r\n\t\t");
            
            #line 84 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.ActiveCfg = Release|Any CPU\r\n\t\t");
            
            #line 85 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.Build.0 = Release|Any CPU\r\n");
            
            #line 86 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("\tEndGlobalSection\r\n\tGlobalSection(SolutionProperties) = preSolution\r\n\t\tHideSoluti" +
                    "onNode = FALSE\r\n\tEndGlobalSection\r\n\tGlobalSection(NestedProjects) = preSolution\r" +
                    "\n");
            
            #line 94 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    foreach(var project in (IList<SolutionFileCreator.Project>)this.Session["CoreProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 98 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = {9863FCB3-BFA4-4B9C-B8F6-302BA5F660B8}\r\n");
            
            #line 99 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    }

    foreach(var folder in (List<SolutionFileCreator.ServiceSolutionFolder>)this.Session["ServiceSolutionFolders"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 105 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = {939EC5C2-8345-43E2-8F97-72EEEBEEA0AB}\r\n");
            
            #line 106 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

        foreach(var project in folder.Projects)
        { 

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 110 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 110 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 111 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

        }
    }
    foreach(var project in (IList<SolutionFileCreator.Project>)this.Session["TestProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 117 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = {12EC4E4B-7E2C-4B63-8EF9-7B959F82A89B}\r\n");
            
            #line 118 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("\tEndGlobalSection\r\n\tGlobalSection(ExtensibilityGlobals) = postSolution\r\n\t\tSolutio" +
                    "nGuid = {");
            
            #line 123 "D:\workspace\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\CoreCLRSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["SolutionGuid"]));
            
            #line default
            #line hidden
            this.Write("}\r\n\tEndGlobalSection\r\nEndGlobal");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class CoreCLRSolutionFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}