
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.7.2556.0
//  Copyright (c) Microsoft Corporation. All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Lib155
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- 次のカスタム属性が自動的に追加されました。コメントを解除しないでください -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .permissionset reqmin
             = {[mscorlib]System.Security.Permissions.SecurityPermissionAttribute = {property bool 'SkipVerification' = bool(true)}}
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Lib155.dll
// MVID: {D7450E06-EB9C-44D2-8AF4-CB709A349A74}
.custom instance void [mscorlib]System.Security.UnverifiableCodeAttribute::.ctor() = ( 01 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06ED0000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit Class1
       extends [mscorlib]System.Object
{
  .method public hidebysig static int32  Unsafe(string s) cil managed
  {
    // コード サイズ       25 (0x19)
    .maxstack  2
    .locals init (char* V_0,
             string pinned V_1,
             int32 V_2)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  stloc.1
    IL_0003:  ldloc.1
    IL_0004:  conv.u
    IL_0005:  stloc.0
    IL_0006:  ldloc.0
    IL_0007:  brfalse.s  IL_0011

    IL_0009:  ldloc.0
    IL_000a:  call       int32 [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::get_OffsetToStringData()
    IL_000f:  add
    IL_0010:  stloc.0
    IL_0011:  nop
    IL_0012:  ldloc.0
    IL_0013:  ldind.u2
    IL_0014:  stloc.2
    IL_0015:  br.s       IL_0017

    IL_0017:  ldloc.2
    IL_0018:  ret
  } // end of method Class1::Unsafe

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // コード サイズ       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Class1::.ctor

} // end of class Class1


// =============================================================

// *********** 逆アセンブリが完了しました ***********************
// 警告: Win32 リソース ファイル 155.res を作成しました。
