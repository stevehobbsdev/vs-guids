// Guids.cs
// MUST match guids.h
using System;

namespace GuidGenerator
{
    static class GuidList
    {
        public const string guidGuidExtensionPkgString = "0ed7fc09-7d7e-40a8-87dc-35f0bb975a0e";
        public const string guidGuidExtensionCmdSetString = "09baf1c6-e392-4290-92d9-9195b5936306";

        public static readonly Guid guidGuidExtensionCmdSet = new Guid(guidGuidExtensionCmdSetString);
    };
}