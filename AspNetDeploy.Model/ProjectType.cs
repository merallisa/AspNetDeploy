//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetDeploy.Model
{
    using System;
    
    [Flags]
    public enum ProjectType : int
    {
        Undefined = 0,
        Web = 1,
        Console = 2,
        Service = 4,
        ClassLibrary = 8,
        Deployment = 16,
        Database = 32,
        Test = 64,
        WindowsApplication = 128,
        ZipArchive = 256
    }
}