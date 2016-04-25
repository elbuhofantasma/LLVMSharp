﻿namespace LLVMSharp.Api.TargetInitializers
{
    public sealed class MipsTargetInitializer : 
        ITarget, ITargetInfo, ITargetMC, IAsmPrinter, IAsmParser, IDisassembler
    {
        internal MipsTargetInitializer()
        {            
        }

        public void Target()
        {
            LLVM.InitializeMipsTarget();
        }

        public void TargetInfo()
        {
            LLVM.InitializeMipsTargetInfo();
        }

        public void TargetMC()
        {
            LLVM.InitializeMipsTargetMC();
        }

        public void AsmPrinter()
        {
            LLVM.InitializeMipsAsmPrinter();
        }

        public void AsmParser()
        {
            LLVM.InitializeMipsAsmParser();
        }

        public void Disassembler()
        {
            LLVM.InitializeMipsDisassembler();
        }
    }
}
