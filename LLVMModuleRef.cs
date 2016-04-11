﻿namespace LLVMSharp
{
    using System;
    using Api;
    using Utilities;

    public partial struct LLVMModuleRef : IEquatable<LLVMModuleRef>, IHandle<Module>
    {
        IntPtr IHandle<Module>.GetInternalPointer() => this.Pointer;
        Module IHandle<Module>.ToWrapperType() => new Module(this);

        public bool Equals(LLVMModuleRef other)
        {
            return this.Pointer == other.Pointer;
        }

        public override bool Equals(object obj)
        {
            if (obj is LLVMModuleRef)
            {
                return this.Equals((LLVMModuleRef)obj);
            }
            return false;
        }

        public static bool operator ==(LLVMModuleRef op1, LLVMModuleRef op2)
        {
            return op1.Equals(op2);
        }

        public static bool operator !=(LLVMModuleRef op1, LLVMModuleRef op2)
        {
            return !(op1 == op2);
        }

        public override int GetHashCode()
        {
            return this.Pointer.GetHashCode();
        }
    }
}
