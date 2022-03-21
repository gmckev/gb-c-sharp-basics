
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Task_1
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 06 54 61 73 6B 5F 31 00 00 )                // ...Task_1..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 48 50 20 49 6E 63 2E 00 00 )             // ...HP Inc...
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 06 54 61 73 6B 5F 31 00 00 )                // ...Task_1..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 19 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  48 50 20 49 6E 63 2E 20 32 30 32 32 00 00 )       // HP Inc. 2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 64 63 66 32 35 39 31 62 2D 38 63 62 64   // ..$dcf2591b-8cbd
                                                                                                  2D 34 66 38 65 2D 38 38 63 32 2D 35 32 61 33 37   // -4f8e-88c2-52a37
                                                                                                  66 38 39 34 38 32 36 00 00 )                      // f894826..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Task_1.exe
// MVID: {639CF285-E623-4718-971E-D7CDFAA2876C}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x00510000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Task_1.TemperatureCalculator
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       84 (0x54)
    .maxstack  2
    .locals init ([0] float32 minTemp,
             [1] float32 maxTemp,
             [2] float32 averageTemp)
    IL_0000:  nop
    IL_0001:  ldstr      "Enter today's minimum temperature: "
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  call       string [mscorlib]System.Console::ReadLine()
    IL_0011:  call       float32 [mscorlib]System.Single::Parse(string)
    IL_0016:  stloc.0
    IL_0017:  ldstr      "Enter today's maximum temperature: "
    IL_001c:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0021:  nop
    IL_0022:  call       string [mscorlib]System.Console::ReadLine()
    IL_0027:  call       float32 [mscorlib]System.Single::Parse(string)
    IL_002c:  stloc.1
    IL_002d:  ldloc.0
    IL_002e:  ldloc.1
    IL_002f:  add
    IL_0030:  ldc.r4     2.
    IL_0035:  div
    IL_0036:  stloc.2
    IL_0037:  ldstr      "Today's average temperature per celcium is: {0}"
    IL_003c:  ldloc.2
    IL_003d:  box        [mscorlib]System.Single
    IL_0042:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0047:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_004c:  nop
    IL_004d:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_0052:  pop
    IL_0053:  ret
  } // end of method TemperatureCalculator::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method TemperatureCalculator::.ctor

} // end of class Task_1.TemperatureCalculator


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\glebm\Desktop\Geekbrains\gb-c-sharp-basics\Task_1\bin\Debug\TemperatureCalculator.res
