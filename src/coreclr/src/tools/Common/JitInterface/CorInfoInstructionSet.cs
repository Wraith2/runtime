
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// DO NOT EDIT THIS FILE! IT IS AUTOGENERATED
// FROM /src/coreclr/src/tools/Common/JitInterface/ThunkGenerator/InstructionSetDesc.txt
// using /src/coreclr/src/tools/Common/JitInterface/ThunkGenerator/gen.bat

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Internal.TypeSystem;

namespace Internal.JitInterface
{
    public enum InstructionSet
    {
        ILLEGAL = 0,
        NONE = 63,
        ARM64_ArmBase=1,
        ARM64_ArmBase_Arm64=2,
        ARM64_AdvSimd=3,
        ARM64_AdvSimd_Arm64=4,
        ARM64_Aes=5,
        ARM64_Crc32=6,
        ARM64_Crc32_Arm64=7,
        ARM64_Sha1=8,
        ARM64_Sha256=9,
        ARM64_Atomics=10,
        ARM64_Vector64=11,
        ARM64_Vector128=12,
        X64_SSE=1,
        X64_SSE2=2,
        X64_SSE3=3,
        X64_SSSE3=4,
        X64_SSE41=5,
        X64_SSE42=6,
        X64_AVX=7,
        X64_AVX2=8,
        X64_AES=9,
        X64_BMI1=10,
        X64_BMI2=11,
        X64_FMA=12,
        X64_LZCNT=13,
        X64_PCLMULQDQ=14,
        X64_POPCNT=15,
        X64_Vector128=16,
        X64_Vector256=17,
        X64_BMI1_X64=18,
        X64_BMI2_X64=19,
        X64_LZCNT_X64=20,
        X64_POPCNT_X64=21,
        X64_SSE_X64=22,
        X64_SSE2_X64=23,
        X64_SSE41_X64=24,
        X64_SSE42_X64=25,
        X86_SSE=1,
        X86_SSE2=2,
        X86_SSE3=3,
        X86_SSSE3=4,
        X86_SSE41=5,
        X86_SSE42=6,
        X86_AVX=7,
        X86_AVX2=8,
        X86_AES=9,
        X86_BMI1=10,
        X86_BMI2=11,
        X86_FMA=12,
        X86_LZCNT=13,
        X86_PCLMULQDQ=14,
        X86_POPCNT=15,
        X86_Vector128=16,
        X86_Vector256=17,
        X86_BMI1_X64=18,
        X86_BMI2_X64=19,
        X86_LZCNT_X64=20,
        X86_POPCNT_X64=21,
        X86_SSE_X64=22,
        X86_SSE2_X64=23,
        X86_SSE41_X64=24,
        X86_SSE42_X64=25,

    }

    public struct InstructionSetFlags
    {
        ulong _flags;
        
        public void AddInstructionSet(InstructionSet instructionSet)
        {
            _flags = _flags | (((ulong)1) << (int)instructionSet);
        }

        public void RemoveInstructionSet(InstructionSet instructionSet)
        {
            _flags = _flags & ~(((ulong)1) << (int)instructionSet);
        }

        public bool HasInstructionSet(InstructionSet instructionSet)
        {
            return (_flags & (((ulong)1) << (int)instructionSet)) != 0;
        }

        public bool Equals(InstructionSetFlags other)
        {
            return _flags == other._flags;
        }

        public static InstructionSetFlags ExpandInstructionSetByImplication(TargetArchitecture architecture, InstructionSetFlags input)
        {
            InstructionSetFlags oldflags = input;
            InstructionSetFlags resultflags = input;
            do
            {
                oldflags = resultflags;
                switch(architecture)
                {

                case TargetArchitecture.ARM64:
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_ArmBase))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_ArmBase_Arm64);
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_AdvSimd))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_AdvSimd_Arm64);
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_Crc32))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_Crc32_Arm64);
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_AdvSimd))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_ArmBase);
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_Aes))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_ArmBase);
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_Crc32))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_ArmBase);
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_Sha1))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_ArmBase);
                    if (resultflags.HasInstructionSet(InstructionSet.ARM64_Sha256))
                        resultflags.AddInstructionSet(InstructionSet.ARM64_ArmBase);
                    break;

                case TargetArchitecture.X64:
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE2))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE2_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE41))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE41_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE42))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE42_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_BMI1))
                        resultflags.AddInstructionSet(InstructionSet.X64_BMI1_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_BMI2))
                        resultflags.AddInstructionSet(InstructionSet.X64_BMI2_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_LZCNT))
                        resultflags.AddInstructionSet(InstructionSet.X64_LZCNT_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_POPCNT))
                        resultflags.AddInstructionSet(InstructionSet.X64_POPCNT_X64);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE2))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE3))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE2);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSSE3))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE3);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE41))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSSE3);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_SSE42))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE41);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_AVX))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE42);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_AVX2))
                        resultflags.AddInstructionSet(InstructionSet.X64_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_AES))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE2);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_BMI1))
                        resultflags.AddInstructionSet(InstructionSet.X64_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_BMI2))
                        resultflags.AddInstructionSet(InstructionSet.X64_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_FMA))
                        resultflags.AddInstructionSet(InstructionSet.X64_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_PCLMULQDQ))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE2);
                    if (resultflags.HasInstructionSet(InstructionSet.X64_POPCNT))
                        resultflags.AddInstructionSet(InstructionSet.X64_SSE42);
                    break;

                case TargetArchitecture.X86:
                    if (resultflags.HasInstructionSet(InstructionSet.X86_SSE2))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_SSE3))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE2);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_SSSE3))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE3);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_SSE41))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSSE3);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_SSE42))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE41);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_AVX))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE42);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_AVX2))
                        resultflags.AddInstructionSet(InstructionSet.X86_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_AES))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE2);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_BMI1))
                        resultflags.AddInstructionSet(InstructionSet.X86_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_BMI2))
                        resultflags.AddInstructionSet(InstructionSet.X86_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_FMA))
                        resultflags.AddInstructionSet(InstructionSet.X86_AVX);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_PCLMULQDQ))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE2);
                    if (resultflags.HasInstructionSet(InstructionSet.X86_POPCNT))
                        resultflags.AddInstructionSet(InstructionSet.X86_SSE42);
                    break;

                }
            } while (!oldflags.Equals(resultflags));
            return resultflags;
        }

        public static IEnumerable<KeyValuePair<string,InstructionSet>> ArchitectureToValidInstructionSets(TargetArchitecture architecture)
        {
            switch (architecture)
            {

                case TargetArchitecture.ARM64:
                    yield return new KeyValuePair<string, InstructionSet>("ArmBase", InstructionSet.ARM64_ArmBase);
                    yield return new KeyValuePair<string, InstructionSet>("AdvSimd", InstructionSet.ARM64_AdvSimd);
                    yield return new KeyValuePair<string, InstructionSet>("Aes", InstructionSet.ARM64_Aes);
                    yield return new KeyValuePair<string, InstructionSet>("Crc32", InstructionSet.ARM64_Crc32);
                    yield return new KeyValuePair<string, InstructionSet>("Sha1", InstructionSet.ARM64_Sha1);
                    yield return new KeyValuePair<string, InstructionSet>("Sha256", InstructionSet.ARM64_Sha256);
                    yield return new KeyValuePair<string, InstructionSet>("Atomics", InstructionSet.ARM64_Atomics);
                    yield return new KeyValuePair<string, InstructionSet>("Vector64", InstructionSet.ARM64_Vector64);
                    yield return new KeyValuePair<string, InstructionSet>("Vector128", InstructionSet.ARM64_Vector128);
                    break;

                case TargetArchitecture.X64:
                    yield return new KeyValuePair<string, InstructionSet>("Sse", InstructionSet.X64_SSE);
                    yield return new KeyValuePair<string, InstructionSet>("Sse2", InstructionSet.X64_SSE2);
                    yield return new KeyValuePair<string, InstructionSet>("Sse3", InstructionSet.X64_SSE3);
                    yield return new KeyValuePair<string, InstructionSet>("Ssse3", InstructionSet.X64_SSSE3);
                    yield return new KeyValuePair<string, InstructionSet>("Sse41", InstructionSet.X64_SSE41);
                    yield return new KeyValuePair<string, InstructionSet>("Sse42", InstructionSet.X64_SSE42);
                    yield return new KeyValuePair<string, InstructionSet>("Avx", InstructionSet.X64_AVX);
                    yield return new KeyValuePair<string, InstructionSet>("Avx2", InstructionSet.X64_AVX2);
                    yield return new KeyValuePair<string, InstructionSet>("Aes", InstructionSet.X64_AES);
                    yield return new KeyValuePair<string, InstructionSet>("Bmi1", InstructionSet.X64_BMI1);
                    yield return new KeyValuePair<string, InstructionSet>("Bmi2", InstructionSet.X64_BMI2);
                    yield return new KeyValuePair<string, InstructionSet>("Fma", InstructionSet.X64_FMA);
                    yield return new KeyValuePair<string, InstructionSet>("Lzcnt", InstructionSet.X64_LZCNT);
                    yield return new KeyValuePair<string, InstructionSet>("Pclmulqdq", InstructionSet.X64_PCLMULQDQ);
                    yield return new KeyValuePair<string, InstructionSet>("Popcnt", InstructionSet.X64_POPCNT);
                    yield return new KeyValuePair<string, InstructionSet>("Vector128", InstructionSet.X64_Vector128);
                    yield return new KeyValuePair<string, InstructionSet>("Vector256", InstructionSet.X64_Vector256);
                    break;

                case TargetArchitecture.X86:
                    yield return new KeyValuePair<string, InstructionSet>("Sse", InstructionSet.X86_SSE);
                    yield return new KeyValuePair<string, InstructionSet>("Sse2", InstructionSet.X86_SSE2);
                    yield return new KeyValuePair<string, InstructionSet>("Sse3", InstructionSet.X86_SSE3);
                    yield return new KeyValuePair<string, InstructionSet>("Ssse3", InstructionSet.X86_SSSE3);
                    yield return new KeyValuePair<string, InstructionSet>("Sse41", InstructionSet.X86_SSE41);
                    yield return new KeyValuePair<string, InstructionSet>("Sse42", InstructionSet.X86_SSE42);
                    yield return new KeyValuePair<string, InstructionSet>("Avx", InstructionSet.X86_AVX);
                    yield return new KeyValuePair<string, InstructionSet>("Avx2", InstructionSet.X86_AVX2);
                    yield return new KeyValuePair<string, InstructionSet>("Aes", InstructionSet.X86_AES);
                    yield return new KeyValuePair<string, InstructionSet>("Bmi1", InstructionSet.X86_BMI1);
                    yield return new KeyValuePair<string, InstructionSet>("Bmi2", InstructionSet.X86_BMI2);
                    yield return new KeyValuePair<string, InstructionSet>("Fma", InstructionSet.X86_FMA);
                    yield return new KeyValuePair<string, InstructionSet>("Lzcnt", InstructionSet.X86_LZCNT);
                    yield return new KeyValuePair<string, InstructionSet>("Pclmulqdq", InstructionSet.X86_PCLMULQDQ);
                    yield return new KeyValuePair<string, InstructionSet>("Popcnt", InstructionSet.X86_POPCNT);
                    yield return new KeyValuePair<string, InstructionSet>("Vector128", InstructionSet.X86_Vector128);
                    yield return new KeyValuePair<string, InstructionSet>("Vector256", InstructionSet.X86_Vector256);
                    break;

            }
        }

        public void Set64BitInstructionSetVariants(TargetArchitecture architecture)
        {
            switch (architecture)
            {

                case TargetArchitecture.ARM64:
                    if (HasInstructionSet(InstructionSet.ARM64_ArmBase))
                        AddInstructionSet(InstructionSet.ARM64_ArmBase_Arm64);
                    if (HasInstructionSet(InstructionSet.ARM64_AdvSimd))
                        AddInstructionSet(InstructionSet.ARM64_AdvSimd_Arm64);
                    if (HasInstructionSet(InstructionSet.ARM64_Crc32))
                        AddInstructionSet(InstructionSet.ARM64_Crc32_Arm64);
                    break;

                case TargetArchitecture.X64:
                    if (HasInstructionSet(InstructionSet.X64_SSE))
                        AddInstructionSet(InstructionSet.X64_SSE_X64);
                    if (HasInstructionSet(InstructionSet.X64_SSE2))
                        AddInstructionSet(InstructionSet.X64_SSE2_X64);
                    if (HasInstructionSet(InstructionSet.X64_SSE41))
                        AddInstructionSet(InstructionSet.X64_SSE41_X64);
                    if (HasInstructionSet(InstructionSet.X64_SSE42))
                        AddInstructionSet(InstructionSet.X64_SSE42_X64);
                    if (HasInstructionSet(InstructionSet.X64_BMI1))
                        AddInstructionSet(InstructionSet.X64_BMI1_X64);
                    if (HasInstructionSet(InstructionSet.X64_BMI2))
                        AddInstructionSet(InstructionSet.X64_BMI2_X64);
                    if (HasInstructionSet(InstructionSet.X64_LZCNT))
                        AddInstructionSet(InstructionSet.X64_LZCNT_X64);
                    if (HasInstructionSet(InstructionSet.X64_POPCNT))
                        AddInstructionSet(InstructionSet.X64_POPCNT_X64);
                    break;

                case TargetArchitecture.X86:
                    break;

            }
        }
    }
}
