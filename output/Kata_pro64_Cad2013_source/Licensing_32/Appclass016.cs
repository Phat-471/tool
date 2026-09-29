using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Module_21;
using Module_40;
using Module_25;
using UI_Module_42;

namespace _namespace_1;

internal class GetInternal_100
{
	private delegate void GetDelegateVoid_1(object o);

	internal class GetPublic_9 : Attribute
	{
		internal class GetStatic_3<aC0xKSDVeuvUN3vHRIty>
		{
			internal static object _object_2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GetStatic_3()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static GetStatic_3()
			{
				GetUnsafeStaticVoid_152();
				int num = _return_132;
				while (true)
				{
					int num2 = num;
					do
					{
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								if (num2 == 9)
								{
									return;
								}
								goto _goto_3;
							case 0:
								ExecuteAction_142();
								num3 = 6;
								if (0 == 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								break;
							case _return_132:
								ExecuteAction_112();
								num3 = 0;
								if (_return_132 == 0)
								{
									num3 = 7;
								}
								continue;
							}
							goto _goto_4;
							continue;
							_goto_3:
							break;
						}
						continue;
						_goto_4:
						break;
					}
					while (num2 == 990);
					AppClass_054.IveTMUdyS5E();
					num = 9;
					if (_return_132 == 0)
					{
						num = 6;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool IsValid_7()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object GetObject_8()
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetPublic_9(object GetReturn_366)
		{
		}
	}

	internal class GetPublic_11
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetString_10(object GetReturn_366, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetPublic_11()
		{
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint GetDelegateUint_12(IntPtr classthis, IntPtr comp, IntPtr info, uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GetDelegateIntptr_13();

	internal struct AppStruct_020
	{
		internal bool _bool_5;

		internal byte[] _bytearray_6;
	}

	internal class GetPublic_14
	{
		private object _object_7;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetPublic_14(Stream GetReturn_366)
		{
			_object_7 = new BinaryReader(GetReturn_366);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal Stream GetSpecialnameInternalStream_15()
		{
			return ((BinaryReader)_object_7).BaseStream;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] GetByte_16(int GetReturn_366)
		{
			return ((BinaryReader)_object_7).ReadBytes(GetReturn_366);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int GetInt_17(byte[] GetReturn_366, int P_1, int P_2)
		{
			return ((BinaryReader)_object_7).Read(GetReturn_366, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int GetInt_18()
		{
			return ((BinaryReader)_object_7).ReadInt32();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ExecuteAction_19()
		{
			((BinaryReader)_object_7).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr GetDelegateIntptr_20(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GetDelegateIntptr_21(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int GetDelegateInt_22(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int GetDelegateInt_23(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GetDelegateIntptr_24(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int GetDelegateInt_25(IntPtr ptr);

	[Flags]
	private enum AppEnum_022
	{

	}

	private static int _int_8;

	internal static object _object_9;

	private static bool _bool_10;

	private static bool _bool_11;

	private static Dictionary<int, int> xIRDVoxDSLZ;

	private static object _object_12;

	internal static object _object_13;

	private static object _object_14;

	private static object _object_15;

	private static bool _bool_16;

	private static object _object_17;

	private static object _object_18;

	private static IntPtr _intptr_19;

	private static object GetReturn_198;

	private static bool _return_47;

	private static bool _bool_22;

	private static long _long_23;

	private static int _int_24;

	private static object GetReturn_202;

	private static IntPtr _return_131;

	private static int _int_27;

	private static long _long_28;

	private static object GetReturn_200;

	private static IntPtr _intptr_30;

	[GetPublic_9(typeof(GetPublic_9.GetStatic_3<object>[]))]
	private static bool _bool_31;

	internal static object _object_32;

	private static List<string> _listString_33;

	private static object _object_34;

	private static object GetReturn_196;

	private static int _int_36;

	private static IntPtr _intptr_37;

	private static List<int> _listInt_38;

	internal static object _object_39;

	private static object _object_40;

	private static int _int_41;

	private static object _object_42;

	private static bool _bool_43;

	private static object GetReturn_204;

	private static object _object_45;

	internal static object GetReturn_148;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetInternal_100()
	{
		_bool_43 = false;
		_object_32 = Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555523)).Assembly;
		_object_15 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		_bool_22 = false;
		_return_47 = false;
		_object_9 = null;
		xIRDVoxDSLZ = null;
		_object_40 = new object();
		_int_36 = 0;
		_object_42 = new object();
		_listString_33 = null;
		_listInt_38 = null;
		_object_45 = new byte[0];
		_object_18 = new byte[0];
		_intptr_30 = IntPtr.Zero;
		_intptr_37 = IntPtr.Zero;
		_object_34 = new string[0];
		_object_14 = new int[0];
		_int_27 = _return_132;
		_bool_11 = false;
		_object_17 = new SortedList();
		_int_8 = 0;
		_long_28 = 0L;
		GetReturn_148 = null;
		_object_13 = null;
		_long_23 = 0L;
		_int_24 = 0;
		_bool_16 = false;
		_bool_10 = false;
		_int_41 = 0;
		_intptr_19 = IntPtr.Zero;
		_bool_31 = false;
		_object_39 = new Hashtable();
		_object_12 = null;
		GetReturn_196 = null;
		GetReturn_198 = null;
		GetReturn_200 = null;
		GetReturn_202 = null;
		GetReturn_204 = null;
		_return_131 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_27()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] GetReturn_107(object GetReturn_366)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - ((Array)GetReturn_366).Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(((Array)GetReturn_366).Length + num / 8 + 8);
		ulong num3 = (ulong)((Array)GetReturn_366).Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < ((Array)GetReturn_366).Length; i++)
		{
			array2[i] = ((byte[])GetReturn_366)[i];
		}
		array2[((Array)GetReturn_366).Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = _return_66; num10 < num5 / 16; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = _return_66; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + _return_132)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			ExecuteAction_93(ref num6, num7, num8, num9, _return_66, 7, 1u, array);
			ExecuteAction_93(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			ExecuteAction_93(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			ExecuteAction_93(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			ExecuteAction_93(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			ExecuteAction_93(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			ExecuteAction_93(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			ExecuteAction_93(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			ExecuteAction_93(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			ExecuteAction_93(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			ExecuteAction_93(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			ExecuteAction_93(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			ExecuteAction_93(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			ExecuteAction_93(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			ExecuteAction_93(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			ExecuteAction_93(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			ExecuteAction_94(ref num6, num7, num8, num9, 1u, _return_67, 17u, array);
			ExecuteAction_94(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			ExecuteAction_94(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			ExecuteAction_94(ref num7, num8, num9, num6, _return_66, 20, 20u, array);
			ExecuteAction_94(ref num6, num7, num8, num9, 5u, _return_67, 21u, array);
			ExecuteAction_94(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			ExecuteAction_94(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			ExecuteAction_94(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			ExecuteAction_94(ref num6, num7, num8, num9, 9u, _return_67, 25u, array);
			ExecuteAction_94(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			ExecuteAction_94(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			ExecuteAction_94(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			ExecuteAction_94(ref num6, num7, num8, num9, 13u, _return_67, 29u, array);
			ExecuteAction_94(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			ExecuteAction_94(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			ExecuteAction_94(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			ExecuteAction_95(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			ExecuteAction_95(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			ExecuteAction_95(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			ExecuteAction_95(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			ExecuteAction_95(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			ExecuteAction_95(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			ExecuteAction_95(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			ExecuteAction_95(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			ExecuteAction_95(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			ExecuteAction_95(ref num9, num6, num7, num8, _return_66, 11, 42u, array);
			ExecuteAction_95(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			ExecuteAction_95(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			ExecuteAction_95(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			ExecuteAction_95(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			ExecuteAction_95(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			ExecuteAction_95(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			ExecuteAction_96(ref num6, num7, num8, num9, _return_66, 6, 49u, array);
			ExecuteAction_96(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			ExecuteAction_96(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			ExecuteAction_96(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			ExecuteAction_96(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			ExecuteAction_96(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			ExecuteAction_96(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			ExecuteAction_96(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			ExecuteAction_96(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			ExecuteAction_96(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			ExecuteAction_96(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			ExecuteAction_96(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			ExecuteAction_96(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			ExecuteAction_96(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			ExecuteAction_96(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			ExecuteAction_96(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_93(ref uint GetReturn_366, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		GetReturn_366 = P_1 + GetUint_97(GetReturn_366 + ((P_1 & P_2) | (~P_1 & P_3)) + ((uint[])P_7)[P_4] + ((uint[])_object_15)[P_6 - _return_132], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_94(ref uint GetReturn_366, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		GetReturn_366 = P_1 + GetUint_97(GetReturn_366 + ((P_1 & P_3) | (P_2 & ~P_3)) + ((uint[])P_7)[P_4] + ((uint[])_object_15)[P_6 - _return_132], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_95(ref uint GetReturn_366, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		GetReturn_366 = P_1 + GetUint_97(GetReturn_366 + (P_1 ^ P_2 ^ P_3) + ((uint[])P_7)[P_4] + ((uint[])_object_15)[P_6 - _return_132], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_96(ref uint GetReturn_366, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		GetReturn_366 = P_1 + GetUint_97(GetReturn_366 + (P_2 ^ (P_1 | ~P_3)) + ((uint[])P_7)[P_4] + ((uint[])_object_15)[P_6 - _return_132], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint GetUint_97(uint GetReturn_366, ushort P_1)
	{
		return (GetReturn_366 >> 32 - P_1) | (GetReturn_366 << (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_98()
	{
		if (!_bool_22)
		{
			ExecuteAction_104();
			_bool_22 = true;
		}
		return _return_47;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal GetInternal_100()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_101(byte[] GetReturn_366, byte[] P_1, byte[] P_2)
	{
		int num = P_2.Length % 4;
		int num2 = P_2.Length / 4;
		byte[] array = new byte[P_2.Length];
		int num3 = GetReturn_366.Length / 4;
		uint num4 = _return_66;
		uint num5 = _return_66;
		uint num6 = _return_66;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = _return_66;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((GetReturn_366[num7 + 3] << 24) | (GetReturn_366[num7 + 2] << 16) | (GetReturn_366[num7 + _return_132] << 8) | GetReturn_366[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - _return_132 && num > 0)
			{
				num6 = _return_66;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= P_2[P_2.Length - (_return_132 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((P_2[num7 + 3] << 24) | (P_2[num7 + 2] << 16) | (P_2[num7 + _return_132] << 8) | P_2[num7]);
			}
			uint num12 = num4;
			num4 = _return_66;
			uint num13 = 1257709153u;
			uint num14 = 807144328u;
			uint num15 = 1954095982u;
			uint num16 = 1022397983u;
			uint num17 = num12;
			ulong num18 = num14 * num16;
			if (num18 == 0)
			{
				num18--;
			}
			num13 = (uint)(num13 * num13 % num18);
			num15 ^= num14;
			num18 = num13 * 1026830853;
			if (num18 == 0)
			{
				num18--;
			}
			num14 = (uint)(num14 * num14 % num18);
			if (num16 == 0)
			{
				num16--;
			}
			uint num19 = num13 / num16 + num16;
			num16 = ((num13 + num13) ^ num19) + num13;
			if (num17 == 0)
			{
				num17--;
			}
			num19 = num13 / num17 + num17;
			num17 = num13 - num13 + num19 + num13;
			num17 ^= num17 << 7;
			num17 += num14;
			num17 ^= num17 >> _return_132;
			num17 += num16;
			num17 ^= num17 << 25;
			num17 += num17;
			num17 = (((num16 << 3) + num16) ^ num16) + num17;
			num4 = num12 + (uint)(double)num17;
			if (i == num2 - _return_132 && num > 0)
			{
				uint num20 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num20 & num10) >> num11);
				}
			}
			else
			{
				uint num21 = num4 ^ num6;
				array[num9] = (byte)(num21 & 0xFF);
				array[num9 + _return_132] = (byte)((num21 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num21 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num21 & 0xFF000000u) >> 24);
			}
		}
		_object_45 = array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm GetReturn_341()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (IsValid_98())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new GetReturnNew_103();
		}
		catch
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3._return_67.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
			catch
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_104()
	{
		try
		{
			new GetNew_105();
		}
		catch
		{
			_return_47 = true;
			return;
		}
		try
		{
			_return_47 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] GetByte_106(object GetReturn_366)
	{
		if (!IsValid_98())
		{
			return new GetNew_105().ComputeHash((byte[])GetReturn_366);
		}
		return GetReturn_107(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_108(object GetReturn_366, object P_1, uint P_2, object P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)((Array)P_3).Length) ? ((Array)P_3).Length : ((int)P_2));
			((Stream)P_1).Read((byte[])P_3, 0, num);
			ExecuteAction_110(GetReturn_366, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_110(object GetReturn_366, object P_1, int P_2, int P_3)
	{
		((HashAlgorithm)GetReturn_366).TransformBlock((byte[])P_1, P_2, P_3, (byte[])P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint GetReturn_278(uint GetReturn_366, int P_1, long P_2, object P_3)
	{
		for (int i = 0; i < P_1; i++)
		{
			((BinaryReader)P_3).BaseStream.Position = P_2 + (i * 40 + 8);
			uint num = ((BinaryReader)P_3).ReadUInt32();
			uint num2 = ((BinaryReader)P_3).ReadUInt32();
			((BinaryReader)P_3).ReadUInt32();
			uint num3 = ((BinaryReader)P_3).ReadUInt32();
			if (num2 <= GetReturn_366 && GetReturn_366 < num2 + num)
			{
				return num3 + GetReturn_366 - num2;
			}
		}
		return _return_66;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_112()
	{
		int num = 12;
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		int num30 = default(int);
		string text2 = default(string);
		string text = default(string);
		int num32 = default(int);
		bool flag = default(bool);
		int num38 = default(int);
		int num40 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		int num26 = default(int);
		int num28 = default(int);
		int num12 = default(int);
		long num20 = default(long);
		long num19 = default(long);
		uint num14 = default(uint);
		int num8 = default(int);
		long num7 = default(long);
		byte[] array = default(byte[]);
		uint num21 = default(uint);
		uint num16 = default(uint);
		uint num15 = default(uint);
		byte[] array2 = default(byte[]);
		uint num18 = default(uint);
		int num11 = default(int);
		uint num10 = default(uint);
		long num9 = default(long);
		long num17 = default(long);
		int num24 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 27)
						{
							if (num2 == 1008)
							{
								goto _goto_68;
							}
							goto case 18;
						}
						_object_9 = new RSACryptoServiceProvider();
						num3 = 9;
						if (IsValid_289())
						{
							num3 = 0;
						}
						continue;
					case 2:
						try
						{
							hashAlgorithm = (HashAlgorithm)GetObject_248();
							int num29 = 6;
							if (IsValid_289())
							{
								num29 = _return_132;
							}
							while (true)
							{
								switch (num29)
								{
								default:
									if (num30 == 992)
									{
										num29 = num30;
										continue;
									}
									return;
								case _return_132:
									text2 = (string)GetObject_249("SHA1");
									num29 = 2;
									if (!IsValid_289())
									{
										num29 = 10;
									}
									continue;
								case 2:
									if (IsValid_250(text))
									{
										num29 = 6;
										if (GetObject_290() == null)
										{
											num29 = 0;
										}
										continue;
									}
									return;
								case 0:
									break;
								case 4:
									return;
								case 3:
									break;
								}
								break;
							}
						}
						catch
						{
							int num31 = 0;
							if (!IsValid_289())
							{
								num31 = _return_132;
							}
							while (true)
							{
								switch (num31)
								{
								case 0:
									return;
								}
								if (num32 == 988)
								{
									num31 = num32;
									continue;
								}
								return;
							}
						}
						goto case 9;
					case 13:
						if (flag)
						{
							num3 = 4;
							continue;
						}
						goto case _return_132;
					case 8:
						if (text != null)
						{
							num3 = 18;
							if (IsValid_289())
							{
								num3 = 18;
							}
							continue;
						}
						return;
					case 9:
						flag = false;
						num3 = _return_132;
						if (IsValid_289())
						{
							num3 = 10;
						}
						continue;
					case 0:
						text = (string)GetObject_246(GetType_245(typeof(GetInternal_100).TypeHandle).Assembly);
						num3 = 8;
						continue;
					case 17:
						return;
					case 10:
						try
						{
							GetPublic_14 c6d5xyDVUcpbRW3tbpIx = new GetPublic_14((Stream)GetObject_251(_object_32, "HjQMnGZVOF1u8DlLUXnh.GxgNIVZVhQyFGN838LL0"));
							ExecuteAction_253(GetObject_252(c6d5xyDVUcpbRW3tbpIx), 0L);
							byte[] array3 = (byte[])GetObject_255(c6d5xyDVUcpbRW3tbpIx, (int)GetLong_254(GetObject_252(c6d5xyDVUcpbRW3tbpIx)));
							byte[] array4 = new byte[32];
							array4[0] = 125;
							int num33 = 39 + 45;
							array4[0] = (byte)num33;
							int num34 = 201 - 67;
							array4[0] = (byte)num34;
							array4[0] = 92;
							array4[0] = 167;
							num34 = 126 - 42;
							array4[_return_132] = (byte)num34;
							array4[_return_132] = 88;
							array4[_return_132] = 209;
							array4[2] = 125;
							array4[2] = 53;
							array4[2] = 130;
							array4[2] = 98;
							array4[2] = 121;
							num33 = 115 - 77;
							array4[2] = (byte)num33;
							num34 = 135 - 45;
							array4[3] = (byte)num34;
							num33 = 245 - 81;
							array4[3] = (byte)num33;
							array4[3] = 19;
							array4[4] = 163;
							num33 = 2 + 41;
							array4[4] = (byte)num33;
							num34 = 26 + 43;
							array4[4] = (byte)num34;
							num33 = 33 - 8;
							array4[4] = (byte)num33;
							array4[_return_67] = 96;
							num34 = 2 + 119;
							array4[_return_67] = (byte)num34;
							num34 = 80 + 103;
							array4[_return_67] = (byte)num34;
							array4[_return_67] = 171;
							array4[_return_67] = 130;
							num34 = 46 - _return_67;
							array4[_return_67] = (byte)num34;
							array4[6] = 159;
							num34 = 63 + 16;
							array4[6] = (byte)num34;
							array4[6] = 128;
							num34 = 72 + 74;
							array4[7] = (byte)num34;
							array4[7] = 149;
							array4[7] = 137;
							num34 = 88 + 65;
							array4[7] = (byte)num34;
							num33 = 120 + 63;
							array4[7] = (byte)num33;
							num34 = 200 - 66;
							array4[8] = (byte)num34;
							num33 = 48 + 118;
							array4[8] = (byte)num33;
							array4[8] = 134;
							array4[8] = 96;
							num33 = 111 + 30;
							array4[8] = (byte)num33;
							array4[9] = 148;
							array4[9] = 221;
							num34 = 79 + 114;
							array4[9] = (byte)num34;
							num34 = 187 - 62;
							array4[10] = (byte)num34;
							array4[10] = 146;
							array4[10] = 213;
							array4[11] = 90;
							num34 = 145 - 48;
							array4[11] = (byte)num34;
							array4[11] = 101;
							num34 = 122 + 112;
							array4[11] = (byte)num34;
							num33 = 125 - 41;
							array4[11] = (byte)num33;
							array4[11] = 70;
							array4[12] = 104;
							array4[12] = 162;
							num34 = 138 - 46;
							array4[12] = (byte)num34;
							array4[12] = 158;
							array4[12] = 77;
							num34 = 95 + 105;
							array4[13] = (byte)num34;
							array4[13] = 57;
							num34 = 10 + 6;
							array4[13] = (byte)num34;
							array4[13] = 130;
							num33 = 234 - 119;
							array4[13] = (byte)num33;
							array4[14] = 164;
							num34 = 111 + 64;
							array4[14] = (byte)num34;
							num34 = 43 + 65;
							array4[14] = (byte)num34;
							num33 = 63 + 28;
							array4[14] = (byte)num33;
							array4[14] = 218;
							array4[15] = 100;
							array4[15] = 67;
							num34 = 61 - 36;
							array4[15] = (byte)num34;
							num34 = 229 - 76;
							array4[16] = (byte)num34;
							num33 = 32 + _return_132;
							array4[16] = (byte)num33;
							array4[16] = 119;
							num33 = 107 + 91;
							array4[16] = (byte)num33;
							num33 = 132 - 44;
							array4[17] = (byte)num33;
							num33 = 238 - 79;
							array4[17] = (byte)num33;
							num33 = 138 + 18;
							array4[17] = (byte)num33;
							array4[18] = 88;
							num34 = 133 - 44;
							array4[18] = (byte)num34;
							array4[18] = 75;
							array4[18] = 103;
							num33 = 237 - 79;
							array4[19] = (byte)num33;
							array4[19] = 39;
							num33 = 171 + 31;
							array4[19] = (byte)num33;
							array4[20] = 97;
							num34 = 46 + 119;
							array4[20] = (byte)num34;
							num33 = 233 - 77;
							array4[20] = (byte)num33;
							array4[20] = 151;
							array4[21] = 154;
							num33 = 115 + 31;
							array4[21] = (byte)num33;
							array4[21] = 14;
							array4[22] = 148;
							array4[22] = 90;
							array4[22] = _return_132;
							array4[23] = 114;
							num34 = 254 - 84;
							array4[23] = (byte)num34;
							num34 = 232 - 77;
							array4[23] = (byte)num34;
							array4[23] = 65;
							num34 = 252 - 84;
							array4[24] = (byte)num34;
							array4[24] = 86;
							array4[24] = 128;
							array4[24] = 92;
							num33 = 112 - 20;
							array4[24] = (byte)num33;
							array4[25] = 237;
							num33 = 93 + 115;
							array4[25] = (byte)num33;
							array4[25] = 31;
							num34 = 229 - 76;
							array4[25] = (byte)num34;
							num33 = 217 - 119;
							array4[25] = (byte)num33;
							num33 = 83 + 28;
							array4[26] = (byte)num33;
							num33 = 236 - 78;
							array4[26] = (byte)num33;
							num34 = 195 - 65;
							array4[26] = (byte)num34;
							array4[26] = 170;
							num34 = 157 - 52;
							array4[27] = (byte)num34;
							num33 = 102 + 24;
							array4[27] = (byte)num33;
							num34 = 219 - 73;
							array4[27] = (byte)num34;
							num33 = 170 - 56;
							array4[27] = (byte)num33;
							array4[27] = 141;
							num33 = 56 - 9;
							array4[27] = (byte)num33;
							array4[28] = 162;
							array4[28] = 112;
							array4[28] = 111;
							array4[28] = 136;
							num33 = 65 + 121;
							array4[28] = (byte)num33;
							num33 = 59 + 72;
							array4[28] = (byte)num33;
							num34 = 59 + 23;
							array4[29] = (byte)num34;
							num34 = 230 - 76;
							array4[29] = (byte)num34;
							num34 = 130 - 38;
							array4[29] = (byte)num34;
							num33 = 11 + 71;
							array4[30] = (byte)num33;
							array4[30] = 103;
							array4[30] = 94;
							array4[30] = 247;
							array4[31] = 116;
							num34 = 176 - 58;
							array4[31] = (byte)num34;
							array4[31] = 120;
							num34 = 94 + 122;
							array4[31] = (byte)num34;
							num34 = 97 + 124;
							array4[31] = (byte)num34;
							byte[] array5 = array4;
							byte[] array6 = new byte[16]
							{
								116, 0, 0, 0, 0, 0, 0, 0, 0, 0,
								0, 0, 0, 0, 0, 0
							};
							int num35 = 165 - 55;
							array6[0] = (byte)num35;
							array6[0] = 107;
							array6[0] = 160;
							num35 = 33 + 99;
							array6[0] = (byte)num35;
							array6[_return_132] = 146;
							num35 = 119 + 26;
							array6[_return_132] = (byte)num35;
							num35 = 105 - 69;
							array6[_return_132] = (byte)num35;
							array6[2] = 162;
							array6[2] = 165;
							array6[2] = 196;
							num35 = 190 + 50;
							array6[2] = (byte)num35;
							num35 = 4 + 13;
							array6[3] = (byte)num35;
							array6[3] = 104;
							int num36 = 66 + 33;
							array6[3] = (byte)num36;
							num36 = 94 + 41;
							array6[3] = (byte)num36;
							array6[3] = 128;
							array6[3] = 78;
							num36 = 243 - 81;
							array6[4] = (byte)num36;
							num35 = 247 - 82;
							array6[4] = (byte)num35;
							num35 = 115 + 120;
							array6[4] = (byte)num35;
							array6[_return_67] = 103;
							num35 = 115 + 115;
							array6[_return_67] = (byte)num35;
							array6[_return_67] = 135;
							num36 = 167 - 55;
							array6[6] = (byte)num36;
							num36 = 3 + 53;
							array6[6] = (byte)num36;
							num36 = 187 - 93;
							array6[6] = (byte)num36;
							array6[7] = 140;
							array6[7] = 100;
							num36 = 124 + 106;
							array6[7] = (byte)num36;
							num36 = 44 + 103;
							array6[7] = (byte)num36;
							array6[7] = 120;
							num36 = 183 - 61;
							array6[8] = (byte)num36;
							array6[8] = 127;
							num35 = 15 + 16;
							array6[8] = (byte)num35;
							num36 = 174 - 124;
							array6[8] = (byte)num36;
							array6[9] = 82;
							num36 = 191 - 63;
							array6[9] = (byte)num36;
							num35 = 41 + 124;
							array6[9] = (byte)num35;
							num36 = 55 + 25;
							array6[9] = (byte)num36;
							array6[9] = 68;
							num36 = 58 + 27;
							array6[10] = (byte)num36;
							array6[10] = 118;
							array6[10] = 100;
							array6[10] = 123;
							num36 = 72 + 82;
							array6[10] = (byte)num36;
							num36 = 186 + 62;
							array6[10] = (byte)num36;
							num35 = 137 - 45;
							array6[11] = (byte)num35;
							num36 = 171 - 57;
							array6[11] = (byte)num36;
							num35 = 125 + 121;
							array6[11] = (byte)num35;
							array6[12] = 126;
							array6[12] = 117;
							num35 = 113 + 117;
							array6[12] = (byte)num35;
							num36 = 234 - 78;
							array6[13] = (byte)num36;
							array6[13] = 104;
							array6[13] = 122;
							array6[13] = 87;
							num35 = 231 - 77;
							array6[14] = (byte)num35;
							array6[14] = 139;
							array6[14] = 189;
							array6[14] = 197;
							array6[15] = 142;
							array6[15] = 134;
							array6[15] = 140;
							array6[15] = 111;
							array6[15] = 176;
							byte[] array7 = array6;
							object obj4 = GetObject_256();
							ExecuteAction_258(obj4, CipherMode.CBC);
							ICryptoTransform transform = (ICryptoTransform)GetObject_259(obj4, array5, array7);
							Stream stream = (Stream)GetObject_260();
							CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
							ExecuteAction_262(cryptoStream, array3, 0, array3.Length);
							ExecuteAction_263(cryptoStream);
							ExecuteAction_268(_object_9, GetObject_267(GetObject_264(), GetObject_265(stream)));
							ExecuteAction_269(stream);
							ExecuteAction_269(cryptoStream);
							ExecuteAction_270(c6d5xyDVUcpbRW3tbpIx);
							int num37 = 0;
							if (!IsValid_289())
							{
								num37 = _return_132;
							}
							while (true)
							{
								switch (num37)
								{
								default:
									if (num38 == 988)
									{
										num37 = num38;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch
						{
							int num39 = 0;
							if (GetObject_290() == null)
							{
								num39 = _return_132;
							}
							while (true)
							{
								switch (num39)
								{
								default:
									if (num40 == 989)
									{
										num39 = num40;
										continue;
									}
									break;
								case _return_132:
									flag = true;
									num39 = _return_132;
									if (GetObject_290() == null)
									{
										num39 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 13;
					case 16:
						try
						{
							int num25;
							if (binaryReader == null)
							{
								num25 = 8;
								if (IsValid_289())
								{
									num25 = _return_132;
								}
								goto _goto_57;
							}
							goto _goto_55;
							_goto_57:
							while (true)
							{
								switch (num25)
								{
								default:
									if (num26 == 990)
									{
										goto _goto_52;
									}
									break;
								case _return_132:
									goto _goto_54;
								case 2:
									break;
								case 0:
									goto _goto_54;
								}
								goto _goto_55;
								_goto_52:
								num25 = num26;
								continue;
								_goto_54:
								break;
							}
							goto _goto_56;
							_goto_55:
							ExecuteAction_285(binaryReader);
							num25 = 0;
							if (GetObject_290() != null)
							{
								num25 = 4;
							}
							goto _goto_57;
							_goto_56:;
						}
						catch
						{
							int num27 = 3;
							if (GetObject_290() == null)
							{
								num27 = 0;
							}
							while (true)
							{
								switch (num27)
								{
								default:
									if (num28 == 988)
									{
										num27 = num28;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 4;
					case 4:
					case 14:
						if (!flag)
						{
							num3 = 19;
							if (!IsValid_289())
							{
								num3 = 18;
							}
							continue;
						}
						goto case 15;
					case 6:
						return;
					case 20:
						text2 = null;
						num3 = 3;
						if (GetObject_290() == null)
						{
							num3 = 2;
						}
						continue;
					case 12:
						if (_object_9 != null)
						{
							return;
						}
						num3 = 11;
						if (GetObject_290() != null)
						{
							num3 = 11;
						}
						continue;
					case _return_132:
						binaryReader = null;
						num3 = 7;
						continue;
					case 15:
						throw new Exception((string)GetObject_288(GetObject_287(GetObject_286(GetType_245(typeof(GetInternal_100).TypeHandle).Assembly)), " is tampered."));
					case 19:
						flag = false;
						num3 = 6;
						continue;
					case 11:
						ExecuteAction_243();
						num3 = 27;
						if (GetObject_290() == null)
						{
							num3 = 3;
						}
						continue;
					case _return_67:
						num3 = 16;
						continue;
					case 18:
						if (GetInt_247(text) != 0)
						{
							hashAlgorithm = null;
							num3 = 20;
						}
						else
						{
							num3 = 17;
						}
						continue;
					case 3:
						break;
					case 7:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num4 = 45;
							if (IsValid_289())
							{
								num4 = 11;
							}
							while (true)
							{
								int num13;
								switch (num4)
								{
								default:
									if (num12 != 51)
									{
										if (num12 == 1031)
										{
											goto _goto_63;
										}
										goto case 41;
									}
									if (num20 >= num19)
									{
										num4 = 35;
										continue;
									}
									goto case 4;
								case 41:
								case 43:
									num14 = GetUint_277(GetUint_276(binaryReader), num8, num7, binaryReader);
									num4 = 10;
									continue;
								case 31:
									ExecuteAction_271(hashAlgorithm, fileStream, 152u, array);
									num4 = 2;
									continue;
								case 3:
									array = new byte[65536];
									num4 = 31;
									continue;
								case 27:
									num20 = GetLong_275(fileStream);
									num4 = 20;
									if (!IsValid_289())
									{
										num4 = 34;
									}
									continue;
								case 32:
									ExecuteAction_253(fileStream, GetLong_275(fileStream) + num21);
									num4 = 36;
									continue;
								case 15:
									num16 = GetUint_276(binaryReader);
									num4 = 23;
									if (IsValid_289())
									{
										num4 = 25;
									}
									continue;
								case 0:
									ExecuteAction_271(hashAlgorithm, fileStream, num15, array);
									num4 = 14;
									if (GetObject_290() != null)
									{
										num4 = 33;
									}
									continue;
								case 23:
									array2 = (byte[])GetObject_281(binaryReader, (int)num18);
									num4 = 9;
									if (GetObject_290() == null)
									{
										num4 = 29;
									}
									continue;
								case 21:
								case 34:
								case 36:
									if (num15 == 0)
									{
										num4 = 6;
										continue;
									}
									goto case 27;
								case 7:
									num11 = 0;
									num4 = 24;
									if (!IsValid_289())
									{
										num4 = 29;
									}
									continue;
								case _return_132:
									ExecuteAction_253(fileStream, num7 + num11 * 40 + 16);
									num4 = 12;
									if (!IsValid_289())
									{
										num4 = 4;
									}
									continue;
								case 8:
									ExecuteAction_271(hashAlgorithm, fileStream, num10, array);
									num4 = 22;
									continue;
								case _return_67:
									GetObject_280(hashAlgorithm, new byte[0], 0, 0);
									num4 = 16;
									continue;
								case 33:
									ExecuteAction_253(fileStream, num9);
									num4 = 30;
									if (GetObject_290() == null)
									{
										num4 = 7;
									}
									continue;
								case 6:
								case 14:
								case 38:
									num11++;
									num4 = 40;
									continue;
								case 9:
									flag = !IsValid_284(_object_9, GetObject_283(hashAlgorithm), text2, array2);
									num13 = 26;
									goto _goto_62;
								case 18:
									num15 -= num21;
									num4 = 32;
									continue;
								case 11:
									binaryReader = new BinaryReader(fileStream);
									num4 = 3;
									continue;
								case 28:
									if (num21 >= num15)
									{
										num4 = 17;
										if (GetObject_290() == null)
										{
											num4 = 38;
										}
										continue;
									}
									goto case 18;
								case 12:
									num15 = GetUint_276(binaryReader);
									num4 = 15;
									continue;
								case 39:
									ExecuteAction_253(fileStream, 360L);
									num4 = 43;
									continue;
								case 13:
									num10 = (uint)GetLong_279(num17 - num20, num15);
									num4 = 8;
									continue;
								case 17:
								{
									uint num22 = GetUint_276(binaryReader);
									num18 = GetUint_276(binaryReader);
									num17 = GetUint_277(num22, num8, num7, binaryReader);
									num4 = 37;
									if (!IsValid_289())
									{
										num4 = 20;
									}
									continue;
								}
								case 20:
									if (num17 <= num20)
									{
										num13 = 51;
										goto _goto_62;
									}
									goto case 30;
								case 30:
								case 35:
									if (num20 >= num19)
									{
										num4 = 0;
										if (!IsValid_289())
										{
											num4 = 40;
										}
										continue;
									}
									goto case 13;
								case 37:
									num19 = num17 + num18;
									num4 = 33;
									continue;
								case 22:
									num15 -= num10;
									num4 = 34;
									if (!IsValid_289())
									{
										num4 = 32;
									}
									continue;
								case 16:
									ExecuteAction_253(fileStream, num17);
									num13 = 23;
									goto _goto_62;
								case 25:
									ExecuteAction_253(fileStream, num16);
									num4 = 21;
									if (GetObject_290() != null)
									{
										num4 = _return_132;
									}
									continue;
								case 10:
									ExecuteAction_253(fileStream, num14 + 32);
									num4 = 17;
									if (GetObject_290() != null)
									{
										num4 = 25;
									}
									continue;
								case 24:
								case 40:
									if (num11 >= num8)
									{
										num4 = _return_67;
										continue;
									}
									goto case _return_132;
								case 19:
								case 42:
									ExecuteAction_253(fileStream, 376L);
									num13 = 41;
									goto _goto_62;
								case 29:
									ExecuteAction_282(array2);
									num4 = 24;
									if (GetObject_290() == null)
									{
										num4 = 9;
									}
									continue;
								case 4:
									num21 = (uint)(num19 - num20);
									num4 = 28;
									continue;
								case 2:
								{
									bool num5 = GetUshort_272(binaryReader) != 523;
									int num6 = (num5 ? 96 : 112);
									ExecuteAction_253(fileStream, 152L);
									GetInt_273(fileStream, array, 0, num6);
									array[64] = 0;
									array[65] = 0;
									array[66] = 0;
									array[67] = 0;
									ExecuteAction_274(hashAlgorithm, array, 0, num6);
									GetInt_273(fileStream, array, 0, 128);
									array[32] = 0;
									array[33] = 0;
									array[34] = 0;
									array[35] = 0;
									array[36] = 0;
									array[37] = 0;
									array[38] = 0;
									array[39] = 0;
									ExecuteAction_274(hashAlgorithm, array, 0, 128);
									num7 = GetLong_275(fileStream);
									ExecuteAction_253(fileStream, 134L);
									num8 = GetUshort_272(binaryReader);
									ExecuteAction_253(fileStream, num7);
									ExecuteAction_271(hashAlgorithm, fileStream, (uint)(num8 * 40), array);
									num9 = GetLong_275(fileStream);
									if (!num5)
									{
										num4 = 42;
										continue;
									}
									goto case 39;
								}
								case 26:
									break;
									_goto_63:
									num4 = num12;
									continue;
									_goto_62:
									num12 = num13;
									goto _goto_63;
								}
								break;
							}
						}
						catch
						{
							int num23 = _return_67;
							if (IsValid_289())
							{
								num23 = _return_132;
							}
							while (true)
							{
								switch (num23)
								{
								default:
									if (num24 == 989)
									{
										num23 = num24;
										continue;
									}
									break;
								case _return_132:
									break;
								case 0:
									goto _goto_64;
								}
								flag = true;
								num23 = 0;
								if (!IsValid_289())
								{
									num23 = 6;
								}
								continue;
								_goto_64:
								break;
							}
						}
						goto case _return_67;
					}
					goto _goto_130;
					continue;
					_goto_68:
					break;
				}
				continue;
				_goto_130:
				break;
			}
			ExecuteAction_244(true);
			num = 17;
			if (GetObject_290() == null)
			{
				num = 27;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_141(RuntimeTypeHandle GetReturn_366)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(GetReturn_366);
			if (xIRDVoxDSLZ == null)
			{
				lock (_object_40)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555523)).Assembly.GetManifestResourceStream("WinAtEZVFEcaZJ0jELWC.Ecf8kaZVGfufnALiVALx"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = _return_66;
						uint num4 = _return_66;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = _return_66;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - _return_132 && num > 0)
							{
								num4 = _return_66;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (_return_132 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + _return_132] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = 1257709153u;
							uint num12 = 807144328u;
							uint num13 = 1954095982u;
							uint num14 = 1022397983u;
							uint num15 = num10;
							ulong num16 = num12 * num14;
							if (num16 == 0)
							{
								num16--;
							}
							num11 = (uint)(num11 * num11 % num16);
							num13 ^= num12;
							num16 = num11 * 1026830853;
							if (num16 == 0)
							{
								num16--;
							}
							num12 = (uint)(num12 * num12 % num16);
							if (num14 == 0)
							{
								num14--;
							}
							uint num17 = num11 / num14 + num14;
							num14 = ((num11 + num11) ^ num17) + num11;
							if (num15 == 0)
							{
								num15--;
							}
							num17 = num11 / num15 + num15;
							num15 = num11 - num11 + num17 + num11;
							num15 ^= num15 << 7;
							num15 += num12;
							num15 ^= num15 >> _return_132;
							num15 += num14;
							num15 ^= num15 << 25;
							num15 += num15;
							num15 = (((num14 << 3) + num14) ^ num14) + num15;
							num3 = num9 + (uint)(double)num15;
							if (i == num2 - _return_132 && num > 0)
							{
								uint num18 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num18 & num7) >> num8);
								}
							}
							else
							{
								uint num19 = num3 ^ num4;
								array2[num6] = (byte)(num19 & 0xFF);
								array2[num6 + _return_132] = (byte)((num19 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num19 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num19 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num20 = array.Length / 8;
						GetPublic_14 c6d5xyDVUcpbRW3tbpIx = new GetPublic_14(new MemoryStream(array));
						for (int l = 0; l < num20; l++)
						{
							int key = c6d5xyDVUcpbRW3tbpIx.GetInt_18();
							int value = c6d5xyDVUcpbRW3tbpIx.GetInt_18();
							dictionary.Add(key, value);
						}
						c6d5xyDVUcpbRW3tbpIx.ExecuteAction_19();
					}
					xIRDVoxDSLZ = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num21 = xIRDVoxDSLZ[metadataToken];
					bool flag = (num21 & 0x40000000) > 0;
					num21 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555523)).Module.ResolveMethod(num21, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num22 = parameters.Length + _return_132;
					Type[] array3 = new Type[num22];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(16777236));
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + _return_132] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num23 = 0; num23 < num22; num23++)
					{
						switch (num23)
						{
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case _return_132:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num23);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Tailcall);
					iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_142()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_143(object GetReturn_366, int P_1)
	{
		AppClass_364.HlsDkUcVQ8L(0, new object[2] { GetReturn_366, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string GetString_144(int GetReturn_366)
	{
		if (((Array)_object_45).Length == 0)
		{
			_listString_33 = new List<string>();
			_listInt_38 = new List<int>();
			ExecuteAction_143(((Assembly)_object_32).GetManifestResourceStream("XstAdrZVwWH8dJ0kNJ9t.WVdniYZV8e41O0qAYCZD"), GetReturn_366);
		}
		if (_int_36 < 75)
		{
			MethodBase method = new StackFrame(_return_132).GetMethod();
			if ((Assembly)_object_32 != method.DeclaringType.Assembly)
			{
				bool flag = false;
				string name = method.DeclaringType.Assembly.GetName().Name;
				AssemblyName[] referencedAssemblies = ((Assembly)_object_32).GetReferencedAssemblies();
				foreach (AssemblyName assemblyName in referencedAssemblies)
				{
					if (name == assemblyName.Name)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					throw new Exception();
				}
			}
			_int_36++;
		}
		lock (_object_42)
		{
			int num = BitConverter.ToInt32((byte[])_object_45, GetReturn_366);
			if (num < _listInt_38.Count && _listInt_38[num] == GetReturn_366)
			{
				return _listString_33[num];
			}
			try
			{
				AppClass_051.f8oTg3pM5fk();
				byte[] array = new byte[num];
				Array.Copy((Array)_object_45, GetReturn_366 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				_listString_33.Add(text);
				_listInt_38.Add(GetReturn_366);
				Array.Copy(BitConverter.GetBytes(_listString_33.Count - _return_132), 0, (Array)_object_45, GetReturn_366, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string GetString_145(object GetReturn_366)
	{
		"cYg9Y5E6CmPLzgcvSRWqyd".Trim();
		byte[] array = Convert.FromBase64String((string)GetReturn_366);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint GetUint_146(IntPtr GetReturn_366, IntPtr P_1, IntPtr P_2, uint P_3, IntPtr P_4, ref uint P_5)
	{
		IntPtr ptr = P_2;
		if (_bool_43)
		{
			ptr = P_1;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = ((Hashtable)_object_39)[(object)num];
		if (obj != null)
		{
			AppStruct_020 rygSO1DV2NgSiKnVHgu9 = (AppStruct_020)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(rygSO1DV2NgSiKnVHgu9._bytearray_6.Length);
			Marshal.Copy(rygSO1DV2NgSiKnVHgu9._bytearray_6, 0, intPtr, rygSO1DV2NgSiKnVHgu9._bytearray_6.Length);
			if (rygSO1DV2NgSiKnVHgu9._bool_5)
			{
				P_4 = intPtr;
				P_5 = (uint)rygSO1DV2NgSiKnVHgu9._bytearray_6.Length;
				GetInt_199(P_4, rygSO1DV2NgSiKnVHgu9._bytearray_6.Length, 64, ref _int_41);
				return _return_66;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, rygSO1DV2NgSiKnVHgu9._bytearray_6.Length);
			uint result = _return_66;
			if (P_3 != 216669565 || _bool_31)
			{
				result = GetReturn_148(GetReturn_366, P_1, P_2, P_3, P_4, ref P_5);
				Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, IntPtr.Zero);
			}
			else
			{
				_bool_31 = true;
			}
			return result;
		}
		return GetReturn_148(GetReturn_366, P_1, P_2, P_3, P_4, ref P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetInt_149()
	{
		return _return_67;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_150()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Delegate GetReturn_364(IntPtr GetReturn_366, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(16777828)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(16777253)),
			Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(16777257))
		}).Invoke(null, new object[2] { GetReturn_366, P_1 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void GetUnsafeStaticVoid_152()
	{
		int num = 155;
		byte[] array4 = default(byte[]);
		int num15 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		Process process = default(Process);
		int num82 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int num79 = default(int);
		int num25 = default(int);
		int num81 = default(int);
		int num84 = default(int);
		byte[] array = default(byte[]);
		int num14 = default(int);
		byte[] array5 = default(byte[]);
		int num19 = default(int);
		byte[] array14 = default(byte[]);
		uint num5 = default(uint);
		uint num52 = default(uint);
		IntPtr intPtr5 = default(IntPtr);
		byte[] array2 = default(byte[]);
		long value = default(long);
		IntPtr intPtr = default(IntPtr);
		byte[] array15 = default(byte[]);
		GetPublic_14 c6d5xyDVUcpbRW3tbpIx = default(GetPublic_14);
		long num28 = default(long);
		int num34 = default(int);
		int num30 = default(int);
		byte[] array6 = default(byte[]);
		long num23 = default(long);
		int num42 = default(int);
		byte[] array16 = default(byte[]);
		IntPtr intPtr3 = default(IntPtr);
		int num27 = default(int);
		int num91 = default(int);
		MemoryStream memoryStream2 = default(MemoryStream);
		byte[] array22 = default(byte[]);
		uint nativeSizeOfCode = default(uint);
		int num87 = default(int);
		byte* value2 = default(byte*);
		int num90 = default(int);
		int num94 = default(int);
		int num55 = default(int);
		byte[] array17 = default(byte[]);
		int num26 = default(int);
		byte[] array11 = default(byte[]);
		int num17 = default(int);
		byte[] array10 = default(byte[]);
		byte* ptr = default(byte*);
		byte[] array8 = default(byte[]);
		int num29 = default(int);
		uint num65 = default(uint);
		int num64 = default(int);
		byte[] array9 = default(byte[]);
		AppStruct_020 rygSO1DV2NgSiKnVHgu10 = default(AppStruct_020);
		int num37 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array18 = default(byte[]);
		uint num51 = default(uint);
		uint num21 = default(uint);
		byte[] array13 = default(byte[]);
		int num45 = default(int);
		Version version3 = default(Version);
		Version version = default(Version);
		ProcessModule processModule = default(ProcessModule);
		Version version2 = default(Version);
		int num47 = default(int);
		int num31 = default(int);
		IntPtr intPtr8 = default(IntPtr);
		int num35 = default(int);
		int num36 = default(int);
		int num38 = default(int);
		uint num22 = default(uint);
		int num24 = default(int);
		uint num18 = default(uint);
		IntPtr intPtr9 = default(IntPtr);
		CryptoStream cryptoStream = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		IntPtr intPtr4 = default(IntPtr);
		int num50 = default(int);
		IntPtr intPtr7 = default(IntPtr);
		long num39 = default(long);
		int num40 = default(int);
		AppStruct_020 rygSO1DV2NgSiKnVHgu9 = default(AppStruct_020);
		int num53 = default(int);
		IntPtr intPtr6 = default(IntPtr);
		string text2 = default(string);
		int num54 = default(int);
		bool mx1DVqGxQri = default(bool);
		int num74 = default(int);
		ProcessModule processModule2 = default(ProcessModule);
		int num69 = default(int);
		int num73 = default(int);
		int num76 = default(int);
		int num57 = default(int);
		int num63 = default(int);
		int num60 = default(int);
		int num62 = default(int);
		int num41 = default(int);
		int num16 = default(int);
		int num48 = default(int);
		int num20 = default(int);
		int num32 = default(int);
		uint num33 = default(uint);
		byte[] _bytearray_6 = default(byte[]);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					IntPtr zero;
					switch (num3)
					{
					default:
						if (num2 != 661)
						{
							if (num2 == 1642)
							{
								goto _goto_68;
							}
							goto case 420;
						}
						array4[_return_132] = 115;
						num3 = 120;
						continue;
					case 566:
						num15 = 52 + 71;
						num3 = 81;
						continue;
					case 465:
						num15 = 149 - 49;
						num3 = 343;
						if (IsValid_388())
						{
							num3 = 191;
						}
						continue;
					case 543:
						try
						{
							enumerator = (IEnumerator)GetObject_312(GetObject_311(process));
							int num77 = 0;
							if (!IsValid_388())
							{
								num77 = 2;
							}
							while (true)
							{
								switch (num77)
								{
								default:
									if (num82 == 989)
									{
										goto _goto_69;
									}
									break;
								case 0:
									try
									{
										while (true)
										{
											_goto_77:
											int num78;
											if (!IsValid_324(enumerator))
											{
												num78 = _return_132;
												if (!IsValid_388())
												{
													num78 = 11;
												}
												goto _goto_72;
											}
											goto _goto_79;
											_goto_79:
											intPtr2 = GetIntptr_303((ProcessModule)GetObject_313(enumerator));
											num78 = 9;
											if (IsValid_388())
											{
												num78 = 3;
											}
											goto _goto_72;
											_goto_72:
											while (true)
											{
												switch (num78)
												{
												default:
													if (num79 == 12 || num79 != 992)
													{
														goto _goto_78;
													}
													goto _goto_75;
												case 0:
													num25 = 0;
													num79 = 12;
													goto _goto_75;
												case 3:
													if (intPtr2.ToInt64() == _long_23)
													{
														num78 = 7;
														if (IsValid_388())
														{
															num78 = 0;
														}
														continue;
													}
													goto _goto_77;
												case 4:
													break;
												case 2:
													goto _goto_77;
												case _return_132:
													goto _goto_78;
													_goto_75:
													num78 = num79;
													continue;
												}
												break;
											}
											goto _goto_79;
											continue;
											_goto_78:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator as IDisposable;
										int num80 = 3;
										if (GetObject_389() != null)
										{
											num80 = 0;
										}
										while (true)
										{
											switch (num80)
											{
											default:
												if (num81 == 991)
												{
													num80 = num81;
													continue;
												}
												goto case 3;
											case 3:
												if (disposable == null)
												{
													num80 = 2;
													continue;
												}
												break;
											case 2:
												goto _goto_81;
											case _return_132:
												break;
											case 0:
												goto _goto_81;
											}
											ExecuteAction_325(disposable);
											num80 = 4;
											if (GetObject_389() == null)
											{
												num80 = 0;
											}
											continue;
											_goto_81:
											break;
										}
									}
									break;
								case _return_132:
									break;
								}
								break;
								_goto_69:
								num77 = num82;
							}
						}
						catch
						{
							int num83 = _return_132;
							if (GetObject_389() == null)
							{
								num83 = 0;
							}
							while (true)
							{
								switch (num83)
								{
								default:
									if (num84 == 988)
									{
										num83 = num84;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 635;
					case 63:
						array[25] = (byte)num14;
						num3 = 138;
						if (GetObject_389() == null)
						{
							num3 = 106;
						}
						continue;
					case 489:
						array5[num19 + _return_132] = array14[_return_132];
						num3 = 625;
						if (!IsValid_388())
						{
							num3 = 511;
						}
						continue;
					case 287:
						array5[num19] = array14[0];
						num3 = 489;
						continue;
					case 54:
					case 173:
						num5 = num5;
						num3 = 88;
						if (IsValid_388())
						{
							num3 = 564;
						}
						continue;
					case 571:
						num52 = 255u;
						num = 105;
						break;
					case 460:
						num14 = 158 - 52;
						num = 353;
						break;
					case 384:
						intPtr5 = IntPtr.Zero;
						num3 = 159;
						continue;
					case 178:
						array[4] = 61;
						num = 436;
						break;
					case 387:
						num15 = 87 - 50;
						num3 = 284;
						if (GetObject_389() != null)
						{
							num3 = 389;
						}
						continue;
					case 208:
						array[31] = 49;
						num3 = 642;
						continue;
					case 653:
						array2[10] = 170;
						num3 = 389;
						if (IsValid_388())
						{
							num3 = 67;
						}
						continue;
					case 408:
						num15 = 49 + 7;
						num3 = 612;
						continue;
					case 235:
						ExecuteAction_387(new IntPtr(value), intPtr);
						num = 524;
						break;
					case 46:
					case 285:
						array15 = new byte[6];
						num3 = 183;
						continue;
					case 404:
						array2[_return_132] = (byte)num15;
						num3 = 392;
						continue;
					case 626:
						array[10] = (byte)num14;
						num3 = 651;
						if (GetObject_389() == null)
						{
							num3 = 223;
						}
						continue;
					case 628:
						GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 580;
						if (IsValid_388())
						{
							num3 = 296;
						}
						continue;
					case 596:
						num28 = GetLong_368(new IntPtr(value));
						num3 = 229;
						if (GetObject_389() != null)
						{
							num3 = 577;
						}
						continue;
					case 510:
						array[29] = 156;
						num3 = 172;
						continue;
					case 196:
						array[11] = (byte)num14;
						num = 268;
						break;
					case 429:
						array[17] = 251;
						num3 = 374;
						if (GetObject_389() != null)
						{
							num3 = 145;
						}
						continue;
					case 423:
						num14 = 195 - 65;
						num3 = 211;
						if (GetObject_389() != null)
						{
							num3 = 165;
						}
						continue;
					case 614:
						array[12] = 187;
						num3 = 49;
						continue;
					case 20:
					case 263:
						if (num34 >= num30)
						{
							num3 = 627;
							if (GetObject_389() == null)
							{
								num3 = 476;
							}
							continue;
						}
						goto case 452;
					case 615:
						array[0] = 171;
						num3 = 177;
						continue;
					case 73:
						array5[num19 + 3] = array6[3];
						num3 = 76;
						if (GetObject_389() != null)
						{
							num3 = 657;
						}
						continue;
					case 572:
						num14 = 225 - 75;
						num3 = 196;
						continue;
					case 195:
						num14 = 87 + 61;
						num3 = 622;
						continue;
					case 134:
						num14 = 247 - 82;
						num3 = 99;
						continue;
					case 554:
						ExecuteAction_296(new IntPtr(&num23), 0, 0);
						num3 = 144;
						if (!IsValid_388())
						{
							num3 = 225;
						}
						continue;
					case 530:
						num42++;
						num3 = 158;
						continue;
					case 440:
						num15 = 118 + 96;
						num3 = 343;
						continue;
					case 275:
						array5[num19 + 2] = array6[2];
						num3 = 73;
						if (GetObject_389() != null)
						{
							num3 = 264;
						}
						continue;
					case 18:
						array2[14] = (byte)num15;
						num3 = 508;
						continue;
					case 373:
						array2[10] = (byte)num15;
						num3 = 560;
						continue;
					case 639:
						if (GetInt_308() == 4)
						{
							num3 = 39;
							if (!IsValid_388())
							{
								num3 = 329;
							}
							continue;
						}
						goto case 185;
					case 179:
						if (!IsValid_306(GetIntptr_304(GetIntptr_303(GetObject_302(GetObject_301())), "__", 10u), IntPtr.Zero))
						{
							num = 162;
							break;
						}
						goto _goto_129;
					case 327:
						array5[num19 + 3] = array16[3];
						num3 = 197;
						continue;
					case 377:
						if (GetInt_308() == 4)
						{
							num3 = 137;
							continue;
						}
						goto case 499;
					case 488:
						array2[12] = 98;
						num3 = 495;
						continue;
					case 340:
						num14 = 61 + 62;
						num3 = 334;
						if (GetObject_389() != null)
						{
							num3 = 253;
						}
						continue;
					case 145:
						array[29] = (byte)num14;
						num3 = 295;
						continue;
					case 471:
						array14 = null;
						num3 = 528;
						continue;
					case 434:
						num14 = 208 - 69;
						num3 = 470;
						continue;
					case 648:
						num15 = 153 - 51;
						num = 130;
						break;
					case 570:
						num14 = 221 - 73;
						num = 335;
						break;
					case 14:
					case 646:
						GetInt_199(intPtr3, 4, num27, ref num27);
						num3 = 26;
						continue;
					case 229:
					case 617:
						process = (Process)GetObject_301();
						num3 = 534;
						if (GetObject_389() == null)
						{
							num3 = 591;
						}
						continue;
					case 544:
						array2[13] = (byte)num15;
						num3 = 283;
						continue;
					case 379:
						num14 = 60 - 54;
						num3 = 205;
						if (!IsValid_388())
						{
							num3 = 527;
						}
						continue;
					case _return_67:
						array[2] = 173;
						num3 = 598;
						if (GetObject_389() == null)
						{
							num3 = 460;
						}
						continue;
					case 411:
						try
						{
							object obj7 = GetObject_379(GetType_378(GetModulehandle_377(GetObject_376(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), GetModulehandle_377(GetObject_376(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly)));
							int num85 = 17;
							while (true)
							{
								int num92;
								switch (num85)
								{
								default:
									if (num91 == 25)
									{
										goto case 0;
									}
									if (num91 == 1005)
									{
										goto _goto_98;
									}
									goto case 15;
								case 0:
									ExecuteAction_344(memoryStream2, new byte[GetInt_308()], 0, GetInt_308());
									num85 = 14;
									continue;
								case 11:
									if (GetInt_308() == 4)
									{
										num85 = 13;
										continue;
									}
									goto case 3;
								case 8:
									ExecuteAction_347(memoryStream2);
									num92 = 12;
									goto _goto_85;
								case 10:
									ExecuteAction_344(memoryStream2, new byte[GetInt_308()], 0, GetInt_308());
									num85 = 7;
									if (GetObject_389() == null)
									{
										num85 = 11;
									}
									continue;
								case 14:
									ExecuteAction_344(memoryStream2, new byte[GetInt_308()], 0, GetInt_308());
									num85 = 2;
									continue;
								case 15:
									_intptr_19 = (IntPtr)GetObject_379(obj7.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj7);
									num85 = 7;
									continue;
								case 2:
									ExecuteAction_328(memoryStream2, 0L);
									num85 = 17;
									if (GetObject_389() == null)
									{
										num85 = _return_132;
									}
									continue;
								case 17:
									if (obj7 is IntPtr)
									{
										num85 = _return_67;
										if (GetObject_389() == null)
										{
											num85 = 9;
										}
										continue;
									}
									goto case 6;
								case _return_132:
									array22 = (byte[])GetObject_346(memoryStream2);
									num85 = 8;
									continue;
								case 3:
									ExecuteAction_344(memoryStream2, GetObject_380(_intptr_19.ToInt64()), 0, 8);
									num92 = 25;
									goto _goto_85;
								case 9:
									_intptr_19 = (IntPtr)obj7;
									num85 = 6;
									if (!IsValid_388())
									{
										num85 = 16;
									}
									continue;
								case _return_67:
								case 7:
									memoryStream2 = new MemoryStream();
									num85 = 10;
									continue;
								case 12:
									nativeSizeOfCode = _return_66;
									num85 = 4;
									continue;
								case 13:
									ExecuteAction_344(memoryStream2, GetObject_352(_intptr_19.ToInt32()), 0, 4);
									num85 = 0;
									if (!IsValid_388())
									{
										num85 = 25;
									}
									continue;
								case 4:
									try
									{
										byte[] array21 = array22;
										fixed (byte[] array7 = array21)
										{
											int num86;
											if (array21 == null)
											{
												num86 = 14;
												if (GetObject_389() == null)
												{
													num86 = 0;
												}
												goto _goto_97;
											}
											goto _goto_94;
											_goto_91:
											if (num87 == 994)
											{
												goto _goto_95;
											}
											goto _goto_93;
											_goto_95:
											num86 = num87;
											goto _goto_97;
											_goto_97:
											while (true)
											{
												switch (num86)
												{
												default:
													if (num87 != 14)
													{
														goto _goto_91;
													}
													goto case _return_132;
												case 3:
												case 6:
													_object_13(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
													num86 = 4;
													if (GetObject_389() != null)
													{
														num86 = 13;
													}
													continue;
												case 2:
													break;
												case _return_132:
													value2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array7[0]);
													num86 = 6;
													if (GetObject_389() != null)
													{
														num86 = 13;
													}
													continue;
												case 0:
												case _return_67:
													goto _goto_96;
												case 4:
													goto _goto_93;
												}
												break;
											}
											goto _goto_94;
											_goto_94:
											if (array7.Length != 0)
											{
												int num88 = 9;
												if (GetObject_389() == null)
												{
													num88 = 14;
												}
												num87 = num88;
												goto _goto_95;
											}
											goto _goto_96;
											_goto_96:
											value2 = null;
											num86 = 3;
											goto _goto_97;
											_goto_93:;
										}
									}
									finally
									{
										array7 = null;
										int num89 = 3;
										if (GetObject_389() == null)
										{
											num89 = 0;
										}
										while (true)
										{
											switch (num89)
											{
											default:
												if (num90 == 988)
												{
													num89 = num90;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									break;
								case 6:
									if (!IsValid_316(obj7.GetType().ToString(), "System.Reflection.RuntimeModule"))
									{
										num85 = _return_67;
										continue;
									}
									goto case 15;
								case 16:
									break;
									_goto_98:
									num85 = num91;
									continue;
									_goto_85:
									num91 = num92;
									goto _goto_98;
								}
								break;
							}
						}
						catch
						{
							int num93 = _return_132;
							if (IsValid_388())
							{
								num93 = 0;
							}
							while (true)
							{
								switch (num93)
								{
								default:
									if (num94 == 988)
									{
										num93 = num94;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 44;
					case 41:
						num55 = array17.Length / 4;
						num3 = 299;
						if (GetObject_389() == null)
						{
							num3 = 409;
						}
						continue;
					case 498:
						if (GetObject_337(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly) == null)
						{
							num3 = 352;
							continue;
						}
						goto case 204;
					case 330:
						array5[num26 + _return_132] = array6[_return_132];
						num3 = 365;
						if (IsValid_388())
						{
							num3 = 186;
						}
						continue;
					case 334:
						array[9] = (byte)num14;
						num = 379;
						break;
					case 282:
					case 490:
						if (GetInt_308() == 4)
						{
							num3 = _return_132;
							if (!IsValid_388())
							{
								num3 = 628;
							}
							continue;
						}
						goto case 165;
					case 652:
						array[17] = 87;
						num3 = 402;
						continue;
					case 422:
						ExecuteAction_334(array11, 0, array11.Length);
						num3 = 16;
						continue;
					case 390:
						array2[7] = 182;
						num3 = 593;
						continue;
					case 126:
						array[8] = (byte)num14;
						num3 = 111;
						continue;
					case 72:
						num17++;
						num3 = 619;
						continue;
					case 257:
						array10[11] = array11[_return_67];
						num = 595;
						break;
					case 120:
						array4[2] = 99;
						num3 = 380;
						if (GetObject_389() == null)
						{
							num3 = 143;
						}
						continue;
					case 612:
						array2[15] = (byte)num15;
						num3 = 587;
						if (GetObject_389() == null)
						{
							num3 = 387;
						}
						continue;
					case 144:
						ExecuteAction_297(new IntPtr(&num23), 0, 0L);
						num3 = 256;
						if (GetObject_389() == null)
						{
							num3 = 461;
						}
						continue;
					case 401:
						num15 = 18 + 85;
						num = 413;
						break;
					case 158:
					case 258:
						if (num42 >= array10.Length)
						{
							num3 = 230;
							if (GetObject_389() != null)
							{
								num3 = 628;
							}
							continue;
						}
						goto case 13;
					case 7:
					case 270:
						ptr = null;
						num = 136;
						break;
					case 129:
						array4 = new byte[10];
						num3 = 420;
						continue;
					case 402:
						array[17] = 182;
						num3 = 429;
						if (!IsValid_388())
						{
							num3 = 252;
						}
						continue;
					case 485:
						num14 = 65 + 88;
						num3 = 90;
						if (GetObject_389() == null)
						{
							num3 = 453;
						}
						continue;
					case 29:
						num14 = 115 + 58;
						num3 = 90;
						continue;
					case 616:
						array[30] = (byte)num14;
						num3 = 369;
						continue;
					case 313:
						array8[num29 + _return_132] = (byte)((num65 & 0xFF00) >> 8);
						num = 24;
						break;
					case 581:
						array[14] = (byte)num14;
						num3 = 138;
						continue;
					case 161:
						array[_return_67] = (byte)num14;
						num3 = 434;
						continue;
					case 70:
						array[30] = (byte)num14;
						num3 = 481;
						if (!IsValid_388())
						{
							num3 = 287;
						}
						continue;
					case 283:
						num15 = 139 - 46;
						num3 = 18;
						continue;
					case 470:
						array[_return_67] = (byte)num14;
						num3 = 51;
						continue;
					case 493:
						num64 += 8;
						num3 = 417;
						if (!IsValid_388())
						{
							num3 = 238;
						}
						continue;
					case 156:
						if (num30 > 0)
						{
							num3 = 72;
							continue;
						}
						goto case 619;
					case 13:
						array17[num42] ^= array10[num42];
						num = 530;
						break;
					case 631:
						array2[7] = 120;
						num3 = 504;
						continue;
					case 183:
						array15[0] = 103;
						num3 = 8;
						continue;
					case 267:
						num14 = 13 + 11;
						num3 = 561;
						continue;
					case 122:
						array[7] = 221;
						num3 = 303;
						continue;
					case 157:
						c6d5xyDVUcpbRW3tbpIx = new GetPublic_14(new MemoryStream(array9));
						num3 = 112;
						continue;
					case 527:
						num15 = 183 - 114;
						num3 = 404;
						continue;
					case 391:
						array4[9] = 100;
						num = 71;
						break;
					case 232:
						array2[15] = (byte)num15;
						num = 408;
						break;
					case 637:
						array11 = (byte[])GetObject_333(GetObject_332(_object_32));
						num3 = 529;
						continue;
					case 59:
						num14 = 227 + 13;
						num3 = 516;
						continue;
					case 245:
						rygSO1DV2NgSiKnVHgu10 = default(AppStruct_020);
						num3 = 416;
						continue;
					case 504:
						array2[7] = 128;
						num3 = 390;
						continue;
					case 269:
						array5[num26 + 7] = array14[7];
						num3 = 638;
						continue;
					case 375:
						array2[9] = 137;
						num3 = 143;
						if (IsValid_388())
						{
							num3 = 333;
						}
						continue;
					case 420:
						array4[0] = 99;
						num3 = 169;
						continue;
					case 389:
						num37++;
						num3 = 294;
						if (GetObject_389() == null)
						{
							num3 = 507;
						}
						continue;
					case 176:
						ExecuteAction_331(array10);
						num3 = 637;
						continue;
					case 230:
						array3 = array18;
						num3 = 223;
						if (GetObject_389() == null)
						{
							num3 = 311;
						}
						continue;
					case 397:
						num14 = 167 - 55;
						num3 = 616;
						continue;
					case 80:
						num51 = num5 ^ num21;
						num3 = 57;
						if (GetObject_389() == null)
						{
							num3 = 473;
						}
						continue;
					case 16:
					case 545:
						num42 = 0;
						num = 258;
						break;
					case 469:
						rygSO1DV2NgSiKnVHgu10._bool_5 = false;
						num = 428;
						break;
					case 58:
						array13 = null;
						num3 = 182;
						continue;
					case 103:
						_int_8 = intPtr2.ToInt32();
						num3 = 185;
						continue;
					case 518:
						array5[num26 + 3] = array6[3];
						num3 = 293;
						continue;
					case 562:
						array[7] = 168;
						num3 = 344;
						if (GetObject_389() != null)
						{
							num3 = 184;
						}
						continue;
					case 160:
					case 277:
						intPtr = GetIntptr_385(IntPtr.Zero, (uint)array13.Length, 4096u, 64u);
						num3 = 355;
						continue;
					case 487:
						array5[num26 + 6] = array16[6];
						num3 = 540;
						continue;
					case 376:
						array[23] = 150;
						num3 = 272;
						continue;
					case 188:
						_object_13 = new GetDelegateUint_12(GetUint_146);
						num3 = 466;
						continue;
					case 31:
						num14 = 139 - 46;
						num3 = 261;
						continue;
					case 255:
						array4[6] = 46;
						num3 = 506;
						continue;
					case 541:
						array2[10] = 111;
						num3 = 82;
						if (GetObject_389() != null)
						{
							num3 = 118;
						}
						continue;
					case 147:
						array2 = new byte[16];
						num3 = 226;
						if (GetObject_389() != null)
						{
							num3 = 509;
						}
						continue;
					case 153:
						try
						{
							while (true)
							{
								int num43;
								if (!IsValid_324(enumerator))
								{
									num43 = 4;
									goto _goto_108;
								}
								goto _goto_106;
								_goto_108:
								while (true)
								{
									switch (num43)
									{
									default:
										switch (num45)
										{
										case 998:
											break;
										default:
											goto _goto_107;
										case 18:
											goto _goto_102;
										}
										goto _goto_105;
									case 3:
										version3 = new Version(4, 0, 30319, 17921);
										num43 = 12;
										if (IsValid_388())
										{
											num43 = 2;
										}
										continue;
									case 0:
										break;
									case _return_132:
										_bool_43 = true;
										num43 = 9;
										continue;
									case 9:
										goto _goto_107;
									case 7:
										version = new Version(GetInt_318(GetObject_317(processModule)), GetInt_319(GetObject_317(processModule)), GetInt_320(GetObject_317(processModule)), GetInt_321(GetObject_317(processModule)));
										num43 = 6;
										continue;
									case _return_67:
										if (IsValid_316(GetObject_315(GetObject_314(processModule)), "clrjit.dll"))
										{
											num43 = 7;
											if (!IsValid_388())
											{
												num43 = 10;
											}
											continue;
										}
										break;
									case 6:
										version2 = new Version(4, 0, 30319, 17020);
										num43 = 3;
										continue;
									case 10:
										if (IsValid_323(version, version3))
										{
											num43 = _return_132;
											if (GetObject_389() != null)
											{
												num43 = 2;
											}
											continue;
										}
										break;
									case 2:
										if (!IsValid_322(version, version2))
										{
											int num44 = 17;
											if (GetObject_389() == null)
											{
												num44 = 18;
											}
											num45 = num44;
											goto _goto_105;
										}
										goto case 10;
									case 8:
										goto _goto_106;
									case 4:
										goto _goto_107;
										_goto_105:
										num43 = num45;
										continue;
										_goto_102:
										break;
									}
									break;
								}
								continue;
								_goto_106:
								processModule = (ProcessModule)GetObject_313(enumerator);
								num43 = _return_67;
								if (GetObject_389() != null)
								{
									num43 = 7;
								}
								goto _goto_108;
								continue;
								_goto_107:
								break;
							}
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							int num46 = 6;
							if (GetObject_389() == null)
							{
								num46 = 0;
							}
							while (true)
							{
								switch (num46)
								{
								default:
									if (num47 == 990)
									{
										goto _goto_110;
									}
									goto case _return_132;
								case 0:
									if (disposable != null)
									{
										num46 = _return_132;
										if (!IsValid_388())
										{
											num46 = _return_67;
										}
										continue;
									}
									break;
								case _return_132:
									ExecuteAction_325(disposable);
									num47 = 2;
									goto _goto_110;
								case 2:
									break;
									_goto_110:
									num46 = num47;
									continue;
								}
								break;
							}
						}
						goto case 532;
					case 603:
						num14 = 64 + 28;
						num3 = 587;
						continue;
					case 462:
					case 547:
						if (GetLong_353(GetObject_327(c6d5xyDVUcpbRW3tbpIx)) < GetLong_329(GetObject_327(c6d5xyDVUcpbRW3tbpIx)) - _return_132)
						{
							num3 = 128;
							if (!IsValid_388())
							{
								num3 = 276;
							}
							continue;
						}
						goto case 427;
					case 625:
						array5[num19 + 2] = array14[2];
						num = 304;
						break;
					case 56:
						array4[4] = 114;
						num3 = 236;
						continue;
					case 152:
						num14 = 123 + 63;
						num3 = 74;
						if (IsValid_388())
						{
							num3 = 145;
						}
						continue;
					case 548:
						num31 = 0;
						num3 = 430;
						if (GetObject_389() != null)
						{
							num3 = 624;
						}
						continue;
					case 308:
						num15 = 94 + 83;
						num3 = 32;
						continue;
					case 226:
						num15 = 6 + 99;
						num3 = 215;
						continue;
					case 220:
						if (!IsValid_362(intPtr8, IntPtr.Zero))
						{
							num3 = 285;
							continue;
						}
						goto case 129;
					case 278:
						num35 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num = 37;
						break;
					case 321:
						num36 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 491;
						continue;
					case 159:
						intPtr5 = GetIntptr_350(56u, _return_132, (uint)GetInt_349(GetObject_301()));
						num3 = 639;
						continue;
					case 356:
						num14 = 51 + 47;
						num3 = 463;
						continue;
					case 286:
						array18 = (byte[])GetObject_330(c6d5xyDVUcpbRW3tbpIx, (int)GetLong_329(GetObject_327(c6d5xyDVUcpbRW3tbpIx)));
						num3 = 604;
						continue;
					case 350:
						num14 = 84 + _return_132;
						num3 = 617;
						if (IsValid_388())
						{
							num3 = 522;
						}
						continue;
					case 290:
						num38 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 385;
						if (GetObject_389() != null)
						{
							num3 = 267;
						}
						continue;
					case 205:
						array[9] = (byte)num14;
						num3 = 102;
						continue;
					case 256:
						array[22] = 113;
						num3 = 305;
						if (!IsValid_388())
						{
							num3 = 83;
						}
						continue;
					case 645:
						array2[8] = 204;
						num3 = 597;
						continue;
					case 629:
						array16 = null;
						num3 = 359;
						if (IsValid_388())
						{
							num3 = 60;
						}
						continue;
					case 589:
						num28 = 0L;
						num3 = 69;
						if (!IsValid_388())
						{
							num3 = 2;
						}
						continue;
					case 93:
						array4 = new byte[12];
						num3 = 450;
						continue;
					case 595:
						array10[13] = array11[6];
						num3 = 421;
						if (GetObject_389() != null)
						{
							num3 = 291;
						}
						continue;
					case 650:
						array[7] = (byte)num14;
						num3 = 562;
						continue;
					case 91:
						array[9] = (byte)num14;
						num = 340;
						break;
					case 642:
						array[31] = 120;
						num3 = 585;
						if (GetObject_389() == null)
						{
							num3 = 192;
						}
						continue;
					case 491:
						if (num36 == _return_132)
						{
							num3 = 384;
							continue;
						}
						num37 = 0;
						num3 = 123;
						if (!IsValid_388())
						{
							num3 = 23;
						}
						continue;
					case 274:
						array[8] = (byte)num14;
						num3 = 250;
						continue;
					case 67:
						array2[10] = 155;
						num3 = 33;
						continue;
					case 461:
						ExecuteAction_299(new byte[_return_132], 0, GetIntptr_298(8), _return_132);
						num3 = 157;
						if (GetObject_389() == null)
						{
							num3 = 526;
						}
						continue;
					case 204:
						if (GetInt_338(GetObject_337(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly)) > 0)
						{
							num3 = 29;
							if (GetObject_389() == null)
							{
								num3 = 580;
							}
							continue;
						}
						goto case 352;
					case 463:
						array[15] = (byte)num14;
						num3 = 98;
						if (GetObject_389() == null)
						{
							num3 = 241;
						}
						continue;
					case 641:
						if (GetInt_308() == 4)
						{
							num3 = 314;
							if (GetObject_389() != null)
							{
								num3 = 448;
							}
							continue;
						}
						goto case 325;
					case 580:
						ExecuteAction_307();
						num3 = 526;
						if (IsValid_388())
						{
							num3 = 124;
						}
						continue;
					case 634:
						array2[_return_132] = 108;
						num3 = 401;
						continue;
					case 433:
						num14 = 50 + 102;
						num = 581;
						break;
					case 184:
						array[19] = 163;
						num3 = 580;
						if (GetObject_389() == null)
						{
							num3 = 262;
						}
						continue;
					case 119:
						num14 = 154 + 10;
						num3 = 627;
						continue;
					case 155:
						if (!_bool_11)
						{
							num3 = 154;
							if (GetObject_389() != null)
							{
								num3 = 377;
							}
							continue;
						}
						goto case 599;
					case 538:
						array2[11] = 174;
						num3 = 25;
						continue;
					case 605:
						num22 = (uint)num29;
						num3 = 45;
						if (GetObject_389() == null)
						{
							num3 = 289;
						}
						continue;
					case 271:
						array2[4] = 107;
						num3 = 440;
						continue;
					case 50:
						array10[_return_132] = array11[0];
						num3 = 347;
						continue;
					case 21:
						array[28] = 135;
						num3 = 349;
						if (GetObject_389() == null)
						{
							num3 = 479;
						}
						continue;
					case 546:
						num14 = 110 + 11;
						num = 441;
						break;
					case 437:
						num27 = 0;
						num3 = 386;
						if (IsValid_388())
						{
							num3 = 523;
						}
						continue;
					case 577:
						array[24] = 132;
						num3 = 343;
						if (GetObject_389() == null)
						{
							num3 = 603;
						}
						continue;
					case 551:
						_long_23 = intPtr2.ToInt64();
						num3 = 234;
						if (GetObject_389() == null)
						{
							num3 = 151;
						}
						continue;
					case 82:
						num15 = 66 + 66;
						num3 = 373;
						continue;
					case 227:
						num14 = 29 + 23;
						num = 550;
						break;
					case 291:
						array5[num19] = array6[0];
						num3 = 19;
						continue;
					case 111:
						num14 = 46 - 18;
						num3 = 372;
						if (!IsValid_388())
						{
							num3 = 510;
						}
						continue;
					case 125:
						num24 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 210;
						continue;
					case 295:
						num14 = 240 - 80;
						num3 = 121;
						continue;
					case 369:
						num14 = 41 - 9;
						num3 = 70;
						continue;
					case 289:
						num5 += num18;
						num3 = 254;
						continue;
					case 151:
						if (GetInt_308() == 4)
						{
							num3 = 583;
							if (GetObject_389() == null)
							{
								num3 = 640;
							}
							continue;
						}
						goto case 93;
					case 292:
						array2[10] = (byte)num15;
						num3 = 647;
						if (GetObject_389() != null)
						{
							num3 = 384;
						}
						continue;
					case 201:
						array[13] = (byte)num14;
						num3 = 398;
						if (!IsValid_388())
						{
							num3 = 563;
						}
						continue;
					case 533:
						array[19] = 121;
						num3 = 219;
						continue;
					case 574:
						array[22] = 155;
						num3 = 366;
						continue;
					case 293:
						array5[num26 + 4] = array6[4];
						num3 = 517;
						if (!IsValid_388())
						{
							num3 = 62;
						}
						continue;
					case 521:
						num21 = _return_66;
						num3 = 221;
						continue;
					case 96:
						array5[num19] = array16[0];
						num3 = 492;
						if (IsValid_388())
						{
							num3 = 531;
						}
						continue;
					case 565:
						if (GetInt_199(intPtr9, 4, 4, ref num27) == 0)
						{
							num = 535;
							break;
						}
						goto case 480;
					case 497:
						array4[4] = 105;
						num3 = 299;
						if (GetObject_389() != null)
						{
							num3 = 222;
						}
						continue;
					case 60:
						if (GetInt_308() == 4)
						{
							num3 = 239;
							continue;
						}
						goto case 62;
					case 361:
						array[2] = 91;
						num3 = 486;
						if (!IsValid_388())
						{
							num3 = 589;
						}
						continue;
					case 528:
						array6 = null;
						num3 = 629;
						if (GetObject_389() != null)
						{
							num3 = 168;
						}
						continue;
					case 24:
						array8[num29 + 2] = (byte)((num65 & 0xFF0000) >> 16);
						num3 = 104;
						continue;
					case 611:
						array15[2] = 116;
						num3 = 388;
						if (!IsValid_388())
						{
							num3 = 62;
						}
						continue;
					case 560:
						num15 = 170 - 56;
						num3 = 263;
						if (IsValid_388())
						{
							num3 = 320;
						}
						continue;
					case 393:
					{
						MemoryStream memoryStream = new MemoryStream();
						cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						ExecuteAction_344(cryptoStream, array18, 0, array18.Length);
						ExecuteAction_345(cryptoStream);
						array9 = (byte[])GetObject_346(memoryStream);
						ExecuteAction_334(array10, 0, array10.Length);
						ExecuteAction_347(memoryStream);
						num3 = 180;
						if (GetObject_389() != null)
						{
							num3 = 268;
						}
						continue;
					}
					case 492:
						num14 = 200 - 66;
						num3 = 406;
						continue;
					case 583:
						array[19] = 248;
						num3 = 89;
						continue;
					case 505:
						array[21] = 40;
						num3 = 252;
						continue;
					case 237:
						num15 = 31 + 106;
						num3 = 238;
						continue;
					case 95:
						num36 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 559;
						continue;
					case 40:
						array[0] = 89;
						num3 = 633;
						continue;
					case 165:
						num26 = 2;
						num3 = 643;
						if (!IsValid_388())
						{
							num3 = 585;
						}
						continue;
					case 6:
						array5[num26 + 4] = array14[4];
						num3 = 248;
						continue;
					case 247:
						array5[num26 + _return_67] = array16[_return_67];
						num3 = 487;
						continue;
					case 249:
						array2[13] = 89;
						num = 407;
						break;
					case 104:
						array8[num29 + 3] = (byte)((num65 & 0xFF000000u) >> 24);
						num = 534;
						break;
					case 413:
						array2[_return_132] = (byte)num15;
						num3 = 527;
						continue;
					case 163:
						array7 = null;
						num3 = 157;
						if (GetObject_389() != null)
						{
							num3 = 108;
						}
						continue;
					case 338:
						array4[7] = 116;
						num3 = 459;
						if (GetObject_389() == null)
						{
							num3 = 382;
						}
						continue;
					case _return_132:
						num19 = 9;
						num = 96;
						break;
					case 10:
						num14 = 119 + 11;
						num3 = 618;
						if (GetObject_389() != null)
						{
							num3 = 181;
						}
						continue;
					case 309:
						ExecuteAction_354(new IntPtr(intPtr4.ToInt64() + num50 * 4), GetInt_339(c6d5xyDVUcpbRW3tbpIx));
						num3 = 115;
						if (GetObject_389() == null)
						{
							num3 = 199;
						}
						continue;
					case 75:
						array8[num29] = (byte)(num65 & 0xFF);
						num3 = 313;
						continue;
					case 474:
						array5[num26] = array6[0];
						num3 = 330;
						if (GetObject_389() != null)
						{
							num3 = 563;
						}
						continue;
					case 325:
						value = GetLong_368(intPtr7);
						num3 = 632;
						continue;
					case 400:
					case 557:
						num25 = 7680;
						num = 628;
						break;
					case 315:
						array2[9] = 60;
						num3 = 146;
						continue;
					case 341:
						array[22] = 83;
						num3 = 574;
						continue;
					case 306:
						num52 <<= 8;
						num3 = 493;
						if (GetObject_389() != null)
						{
							num3 = 39;
						}
						continue;
					case 43:
						array[3] = (byte)num14;
						num3 = 28;
						if (!IsValid_388())
						{
							num3 = 338;
						}
						continue;
					case 450:
						array4[0] = 109;
						num = 661;
						break;
					case 301:
					case 576:
						if (GetLong_353(GetObject_327(c6d5xyDVUcpbRW3tbpIx)) < GetLong_329(GetObject_327(c6d5xyDVUcpbRW3tbpIx)) - _return_132)
						{
							num3 = 290;
							continue;
						}
						goto case 242;
					case 34:
						ExecuteAction_357(_object_39, num39 + num40, rygSO1DV2NgSiKnVHgu9);
						num3 = 547;
						continue;
					case 654:
						array2[_return_67] = 69;
						num3 = 303;
						if (GetObject_389() == null)
						{
							num3 = 35;
						}
						continue;
					case 438:
						array5[num26 + 3] = array16[3];
						num3 = 425;
						continue;
					case 343:
						array2[4] = (byte)num15;
						num3 = 15;
						continue;
					case 172:
						array[29] = 150;
						num3 = 152;
						continue;
					case 66:
						array[14] = 162;
						num3 = 568;
						continue;
					case 288:
						intPtr8 = IntPtr.Zero;
						num3 = 220;
						continue;
					case 633:
						array[_return_132] = 182;
						num3 = 386;
						continue;
					case 221:
						num53 = 0;
						num3 = 217;
						if (!IsValid_388())
						{
							num3 = 266;
						}
						continue;
					case 425:
						array5[num26 + 4] = array16[4];
						num3 = 247;
						if (!IsValid_388())
						{
							num3 = 421;
						}
						continue;
					case 419:
						array[_return_67] = (byte)num14;
						num3 = 567;
						continue;
					case 348:
						num5 += num18;
						num3 = 521;
						continue;
					case 241:
						array[15] = 101;
						num3 = 117;
						continue;
					case 35:
						array2[6] = 150;
						num3 = 415;
						if (!IsValid_388())
						{
							num3 = 174;
						}
						continue;
					case 2:
						num14 = 20 + 64;
						num3 = 445;
						continue;
					case 578:
						array[27] = 116;
						num3 = 84;
						continue;
					case 568:
						array[15] = 154;
						num3 = 135;
						continue;
					case 563:
						GetInt_293(new IntPtr(&num23), 0);
						num3 = 360;
						continue;
					case 405:
						array[16] = (byte)num14;
						num3 = 267;
						continue;
					case 567:
						array[_return_67] = 184;
						num3 = 646;
						if (GetObject_389() == null)
						{
							num3 = 307;
						}
						continue;
					case 444:
						return;
					case 154:
						_bool_11 = true;
						num3 = 454;
						if (GetObject_389() != null)
						{
							num3 = 65;
						}
						continue;
					case 561:
						array[16] = (byte)num14;
						num3 = 601;
						if (!IsValid_388())
						{
							num3 = 403;
						}
						continue;
					case 406:
						array[12] = (byte)num14;
						num3 = 68;
						continue;
					case 512:
						intPtr6 = GetIntptr_369(_object_13);
						num3 = 314;
						if (IsValid_388())
						{
							num3 = 589;
						}
						continue;
					case 284:
						array2[15] = (byte)num15;
						num3 = 45;
						continue;
					case 198:
						text2 = (string)GetObject_361(GetObject_360(), array4);
						num3 = 621;
						continue;
					case 199:
						num50++;
						num3 = 458;
						continue;
					case 643:
						array5[num26] = array16[0];
						num = 132;
						break;
					case 239:
						array16 = (byte[])GetObject_352(_intptr_19.ToInt32());
						num3 = 318;
						continue;
					case 77:
						num39 = intPtr2.ToInt64();
						num3 = 437;
						continue;
					case 418:
						array[6] = 129;
						num3 = 165;
						if (GetObject_389() == null)
						{
							num3 = 350;
						}
						continue;
					case 452:
						if (num34 > 0)
						{
							num3 = 306;
							continue;
						}
						goto case 417;
					case 514:
					{
						object obj5 = GetObject_340();
						ExecuteAction_342(obj5, CipherMode.CBC);
						transform = (ICryptoTransform)GetObject_343(obj5, array17, array10);
						num3 = 77;
						if (IsValid_388())
						{
							num3 = 27;
						}
						continue;
					}
					case 106:
						array[25] = 35;
						num3 = 485;
						continue;
					case 57:
						num22 = (uint)(num54 * 4);
						num3 = 65;
						continue;
					case 224:
						if (GetInt_338(GetObject_337(_object_32)) == 0)
						{
							num3 = 557;
							continue;
						}
						goto case 628;
					case 214:
						GetInt_199(intPtr9, 4, num27, ref num27);
						num = 389;
						break;
					case 140:
						array2[7] = (byte)num15;
						num3 = 424;
						continue;
					case 218:
						mx1DVqGxQri = false;
						num3 = 462;
						if (!IsValid_388())
						{
							num3 = 544;
						}
						continue;
					case 223:
						array[10] = 94;
						num3 = 119;
						continue;
					case 372:
						array[8] = (byte)num14;
						num = 2;
						break;
					case 591:
						try
						{
							enumerator = (IEnumerator)GetObject_312(GetObject_311(process));
							int num66 = 7;
							if (GetObject_389() == null)
							{
								num66 = _return_132;
							}
							while (true)
							{
								switch (num66)
								{
								default:
									if (num74 == 989)
									{
										goto _goto_111;
									}
									break;
								case _return_132:
									try
									{
										while (true)
										{
											_goto_121:
											int num67;
											if (!IsValid_324(enumerator))
											{
												num67 = 0;
												if (GetObject_389() != null)
												{
													num67 = _return_67;
												}
												goto _goto_114;
											}
											goto _goto_124;
											_goto_124:
											processModule2 = (ProcessModule)GetObject_313(enumerator);
											num67 = 6;
											goto _goto_114;
											_goto_114:
											while (true)
											{
												int num70;
												switch (num67)
												{
												default:
													if (num69 == 16 || num69 != 996)
													{
														goto _goto_121;
													}
													goto _goto_123;
												case 7:
													return;
												case _return_132:
													break;
												case 6:
													if (!IsValid_316(GetObject_314(processModule2), text2))
													{
														num70 = _return_67;
														if (IsValid_388())
														{
															num70 = 16;
														}
														goto _goto_118;
													}
													goto case 4;
												case 4:
												{
													long num71 = num28;
													intPtr2 = GetIntptr_303(processModule2);
													if (num71 >= intPtr2.ToInt64())
													{
														num67 = 2;
														continue;
													}
													goto case 8;
												}
												case _return_67:
													ExecuteAction_307();
													num70 = 7;
													goto _goto_118;
												case 3:
													goto _goto_121;
												case 2:
												{
													long num68 = num28;
													intPtr2 = GetIntptr_303(processModule2);
													if (num68 > intPtr2.ToInt64() + GetInt_370(processModule2))
													{
														num67 = 8;
														continue;
													}
													goto _goto_121;
												}
												case 8:
													if (IsValid_372(GetObject_371(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly), null))
													{
														num67 = _return_67;
														if (!IsValid_388())
														{
															num67 = _return_132;
														}
														continue;
													}
													goto _goto_121;
												case 0:
													goto _goto_122;
													_goto_123:
													num67 = num69;
													continue;
													_goto_118:
													num69 = num70;
													goto _goto_123;
												}
												break;
											}
											goto _goto_124;
											continue;
											_goto_122:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator as IDisposable;
										int num72 = _return_132;
										if (IsValid_388())
										{
											num72 = 2;
										}
										while (true)
										{
											switch (num72)
											{
											default:
												if (num73 == 991)
												{
													num72 = num73;
													continue;
												}
												break;
											case 3:
												ExecuteAction_325(disposable);
												num72 = 8;
												if (IsValid_388())
												{
													num72 = _return_132;
												}
												continue;
											case 0:
												break;
											case 2:
												if (disposable == null)
												{
													num72 = 0;
													if (GetObject_389() != null)
													{
														num72 = 9;
													}
													continue;
												}
												goto case 3;
											case _return_132:
												break;
											}
											break;
										}
									}
									break;
								case 0:
									break;
								}
								break;
								_goto_111:
								num66 = num74;
							}
						}
						catch
						{
							int num75 = _return_132;
							if (IsValid_388())
							{
								num75 = 0;
							}
							while (true)
							{
								switch (num75)
								{
								default:
									if (num76 == 988)
									{
										num75 = num76;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 300;
					case 392:
						array2[2] = 55;
						num3 = 412;
						if (GetObject_389() == null)
						{
							num3 = 280;
						}
						continue;
					case 448:
						array[31] = (byte)num14;
						num3 = 435;
						if (IsValid_388())
						{
							num3 = 345;
						}
						continue;
					case 522:
						array[7] = (byte)num14;
						num3 = 122;
						continue;
					case 359:
						array[31] = (byte)num14;
						num3 = 168;
						continue;
					case 15:
						array2[4] = 61;
						num3 = 213;
						continue;
					case 28:
						array[3] = 123;
						num3 = 240;
						continue;
					case 559:
						if (num36 == 4)
						{
							num3 = 514;
							if (GetObject_389() != null)
							{
								num3 = 266;
							}
							continue;
						}
						goto case 491;
					case 273:
						num14 = 63 + 44;
						num3 = 202;
						continue;
					case 210:
						if (GetInt_199(intPtr4, num24 * 4, 4, ref num27) == 0)
						{
							num3 = 584;
							if (GetObject_389() == null)
							{
								num3 = 36;
							}
							continue;
						}
						goto case 98;
					case 149:
						num14 = 11 + 19;
						num3 = 221;
						if (GetObject_389() == null)
						{
							num3 = 467;
						}
						continue;
					case 484:
						intPtr3 = new IntPtr(_long_28 + GetInt_339(c6d5xyDVUcpbRW3tbpIx) - num25);
						num = 164;
						break;
					case 575:
						num53++;
						num3 = 515;
						if (!IsValid_388())
						{
							num3 = 335;
						}
						continue;
					case 472:
						GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 451;
						if (!IsValid_388())
						{
							num3 = 144;
						}
						continue;
					case 206:
						if (array11.Length == 0)
						{
							num3 = 545;
							continue;
						}
						goto case 50;
					case 189:
						mx1DVqGxQri = true;
						num = 278;
						break;
					case 168:
						array17 = array;
						num3 = 147;
						continue;
					case 167:
						array5[num26 + _return_132] = array14[_return_132];
						num = 212;
						break;
					case 344:
						num14 = 156 - 52;
						num3 = 274;
						continue;
					case 187:
						array[27] = 134;
						num3 = 609;
						continue;
					case 12:
						num28 = GetInt_367(new IntPtr(value));
						num3 = 617;
						continue;
					case 403:
						if (num30 > 0)
						{
							num3 = 80;
							continue;
						}
						goto case 231;
					case 618:
						array[2] = (byte)num14;
						num3 = 435;
						continue;
					case 279:
						array2[0] = 137;
						num3 = 634;
						if (!IsValid_388())
						{
							num3 = 46;
						}
						continue;
					case 494:
						num14 = 170 + 78;
						num3 = 83;
						continue;
					case 360:
						GetLong_294(new IntPtr(&num23), 0);
						num3 = 464;
						continue;
					case 11:
						array[18] = (byte)num14;
						num3 = 273;
						continue;
					case 333:
						num15 = 195 - 65;
						num = 264;
						break;
					case 447:
					{
						byte[] array20 = array9;
						array7 = array20;
						if (array20 == null)
						{
							num3 = 7;
							if (!IsValid_388())
							{
								num3 = 333;
							}
							continue;
						}
						goto case 337;
					}
					case 105:
						num64 = 0;
						num3 = 553;
						continue;
					case 477:
						num14 = 52 + 123;
						num = 126;
						break;
					case 368:
						array2[11] = (byte)num15;
						num3 = 538;
						if (!IsValid_388())
						{
							num3 = 59;
						}
						continue;
					case 0:
						array[20] = (byte)num14;
						num3 = 381;
						continue;
					case 513:
						array2[14] = (byte)num15;
						num3 = 308;
						if (GetObject_389() != null)
						{
							num3 = 233;
						}
						continue;
					case 339:
						array2[_return_67] = 144;
						num3 = 654;
						if (!IsValid_388())
						{
							num3 = 457;
						}
						continue;
					case 138:
						array[14] = 142;
						num3 = 2;
						if (GetObject_389() == null)
						{
							num3 = 329;
						}
						continue;
					case 509:
						num14 = 10 + 117;
						num3 = 332;
						if (GetObject_389() != null)
						{
							num3 = 390;
						}
						continue;
					case 324:
						array[29] = 98;
						num3 = 302;
						if (GetObject_389() != null)
						{
							num3 = 61;
						}
						continue;
					case 200:
						array5[num19 + 2] = array16[2];
						num3 = 327;
						if (GetObject_389() != null)
						{
							num3 = 339;
						}
						continue;
					case 48:
						num14 = 177 - 58;
						num3 = 89;
						if (GetObject_389() == null)
						{
							num3 = 410;
						}
						continue;
					case 552:
						array2[8] = (byte)num15;
						num3 = 566;
						continue;
					case 234:
						rygSO1DV2NgSiKnVHgu9 = default(AppStruct_020);
						num3 = 85;
						continue;
					case 355:
						array5 = array13;
						num3 = 389;
						if (IsValid_388())
						{
							num3 = 471;
						}
						continue;
					case 100:
						if (GetObject_337(_object_32) == null)
						{
							num3 = 400;
							if (!IsValid_388())
							{
								num3 = 545;
							}
							continue;
						}
						goto case 224;
					case 398:
						num14 = 201 - 67;
						num = 588;
						break;
					case 501:
						num34++;
						num3 = 20;
						if (GetObject_389() != null)
						{
							num3 = 38;
						}
						continue;
					case 336:
						try
						{
							GetReturn_148 = (GetDelegateUint_12)GetObject_363(new IntPtr(num28), GetType_358(typeof(GetDelegateUint_12).TypeHandle));
							int num56 = 6;
							if (IsValid_388())
							{
								num56 = 0;
							}
							while (true)
							{
								switch (num56)
								{
								default:
									if (num57 == 988)
									{
										num56 = num57;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch
						{
							int num58 = 0;
							if (!IsValid_388())
							{
								num58 = 0;
							}
							while (true)
							{
								switch (num58)
								{
								default:
									if (num63 == 989)
									{
										goto _goto_125;
									}
									break;
								case 0:
									try
									{
										Delegate obj2 = (Delegate)GetObject_363(new IntPtr(num28), GetType_358(typeof(GetDelegateUint_12).TypeHandle));
										int num59 = 0;
										if (GetObject_389() != null)
										{
											num59 = 6;
										}
										while (true)
										{
											switch (num59)
											{
											default:
												if (num60 == 989)
												{
													num59 = num60;
													continue;
												}
												break;
											case 0:
												break;
											case _return_132:
												goto _goto_126;
											}
											GetReturn_148 = (GetDelegateUint_12)GetObject_374(GetType_358(typeof(GetDelegateUint_12).TypeHandle), GetObject_373(obj2));
											num59 = _return_67;
											if (GetObject_389() == null)
											{
												num59 = _return_132;
											}
											continue;
											_goto_126:
											break;
										}
									}
									catch
									{
										int num61 = 0;
										if (!IsValid_388())
										{
											num61 = _return_67;
										}
										while (true)
										{
											switch (num61)
											{
											case 0:
												goto _goto_128;
											}
											if (num62 == 988)
											{
												num61 = num62;
												continue;
											}
											goto _goto_128;
										}
										_goto_128:;
									}
									break;
								case _return_132:
									break;
								}
								break;
								_goto_125:
								num58 = num63;
							}
						}
						goto case 4;
					case 248:
						array5[num26 + _return_67] = array14[_return_67];
						num3 = 579;
						continue;
					case 297:
						*(long*)(ptr + num41 * 8) ^= 1474535308L;
						num3 = 118;
						continue;
					case 142:
						array[22] = (byte)num14;
						num3 = 341;
						continue;
					case 354:
						array[2] = (byte)num14;
						num3 = 8;
						if (GetObject_389() == null)
						{
							num3 = _return_67;
						}
						continue;
					case 141:
						num54 = num16 % num55;
						num3 = 108;
						continue;
					case 30:
						num14 = 43 - 37;
						num3 = 322;
						continue;
					case 318:
						array14 = (byte[])GetObject_352(intPtr6.ToInt32());
						num3 = 107;
						if (GetObject_389() != null)
						{
							num3 = 405;
						}
						continue;
					case 386:
						num14 = 148 - 49;
						num3 = 131;
						continue;
					case 272:
						array[23] = 94;
						num = 30;
						break;
					case 101:
						array2[2] = (byte)num15;
						num3 = 635;
						if (GetObject_389() == null)
						{
							num3 = 237;
						}
						continue;
					case 36:
						GetInt_199(intPtr4, num24 * 4, 8, ref num27);
						num3 = 98;
						continue;
					case 217:
					case 515:
						if (num53 >= num30)
						{
							num3 = 54;
							continue;
						}
						goto case 38;
					case 135:
						array[15] = 108;
						num3 = 356;
						continue;
					case 435:
						num14 = 172 - 57;
						num3 = 354;
						if (GetObject_389() != null)
						{
							num3 = 223;
						}
						continue;
					case 65:
						num18 = (uint)((array17[num22 + 3] << 24) | (array17[num22 + 2] << 16) | (array17[num22 + _return_132] << 8) | array17[num22]);
						num = 571;
						break;
					case 443:
						if (IsValid_372(GetObject_371(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly), null))
						{
							num = 265;
							break;
						}
						goto case 352;
					case 3:
						array5[num26] = array14[0];
						num3 = 167;
						continue;
					case 175:
						num14 = 125 + 119;
						num = 370;
						break;
					case 280:
						array2[2] = 98;
						num3 = 133;
						continue;
					case 622:
						array[13] = (byte)num14;
						num3 = 573;
						continue;
					case 396:
						array2[3] = 195;
						num3 = 465;
						continue;
					case 506:
						array4[7] = 100;
						num3 = 651;
						continue;
					case 636:
						num14 = 88 + 109;
						num3 = 16;
						if (GetObject_389() == null)
						{
							num3 = 620;
						}
						continue;
					case 9:
						array[29] = 92;
						num3 = 510;
						continue;
					case 25:
						array2[11] = 92;
						num = 276;
						break;
					case 312:
						num14 = 177 - 59;
						num3 = 293;
						if (GetObject_389() == null)
						{
							num3 = 371;
						}
						continue;
					case 79:
						ExecuteAction_383(GetRuntimemethodhandle_382(GetObject_373(GetReturn_148)));
						num3 = 64;
						continue;
					case 358:
						array2[0] = 169;
						num3 = 11;
						if (IsValid_388())
						{
							num3 = 279;
						}
						continue;
					case 502:
						array[12] = 160;
						num3 = 492;
						continue;
					case 347:
						array10[3] = array11[_return_132];
						num3 = 175;
						if (IsValid_388())
						{
							num3 = 61;
						}
						continue;
					case 332:
						array[_return_67] = (byte)num14;
						num3 = 331;
						if (!IsValid_388())
						{
							num3 = 25;
						}
						continue;
					case 121:
						array[30] = (byte)num14;
						num3 = 397;
						continue;
					case 150:
						num15 = 132 + 22;
						num3 = 552;
						continue;
					case 174:
						num14 = 53 + 99;
						num3 = 621;
						if (GetObject_389() == null)
						{
							num3 = 0;
						}
						continue;
					case 456:
						array[19] = 132;
						num3 = 583;
						if (!IsValid_388())
						{
							num3 = 367;
						}
						continue;
					case 627:
						array[10] = (byte)num14;
						num3 = 572;
						continue;
					case 432:
						intPtr2 = GetIntptr_336(((object[])GetObject_335(_object_32))[0]);
						num3 = 344;
						if (GetObject_389() == null)
						{
							num3 = 77;
						}
						continue;
					case 573:
						num14 = 85 + 119;
						num3 = 395;
						continue;
					case 71:
						array4[10] = 108;
						num3 = 88;
						continue;
					case 300:
						num3 = 264;
						if (GetObject_389() == null)
						{
							num3 = 543;
						}
						continue;
					case 421:
						array10[15] = array11[7];
						num = 422;
						break;
					case 366:
						array[22] = 167;
						num3 = 376;
						continue;
					case 61:
						array10[_return_67] = array11[2];
						num3 = 549;
						continue;
					case 177:
						array[0] = 121;
						num3 = 40;
						if (GetObject_389() != null)
						{
							num3 = 299;
						}
						continue;
					case 136:
					case 266:
						num41 = 0;
						num3 = 145;
						if (IsValid_388())
						{
							num3 = 116;
						}
						continue;
					case 378:
						array[14] = (byte)num14;
						num3 = 100;
						if (IsValid_388())
						{
							num3 = 244;
						}
						continue;
					case 351:
						num21 <<= 8;
						num3 = 581;
						if (IsValid_388())
						{
							num3 = 207;
						}
						continue;
					case 385:
						intPtr4 = new IntPtr(_long_28 + num38 - num25);
						num3 = 125;
						continue;
					case 640:
						_int_24 = GetInt_359(_long_23);
						num = 93;
						break;
					case 464:
						ExecuteAction_295(new IntPtr(&num23), 0, IntPtr.Zero);
						num3 = 554;
						continue;
					case 307:
						array[6] = 99;
						num3 = 209;
						continue;
					case 467:
						array[2] = (byte)num14;
						num3 = 361;
						continue;
					case 88:
						array4[11] = 108;
						num3 = 608;
						continue;
					case 186:
						array5[num26 + 2] = array6[2];
						num3 = 518;
						continue;
					case 592:
						num48 = array9.Length / 8;
						num3 = 447;
						if (GetObject_389() != null)
						{
							num3 = 266;
						}
						continue;
					case 219:
						array[19] = 89;
						num3 = 184;
						if (GetObject_389() != null)
						{
							num3 = 59;
						}
						continue;
					case 496:
						array2[14] = 178;
						num3 = 222;
						continue;
					case 8:
						array15[_return_132] = 101;
						num3 = 611;
						continue;
					case 202:
						array[18] = (byte)num14;
						num3 = 606;
						continue;
					case 42:
					case 458:
						if (num50 >= num24)
						{
							num3 = 539;
							continue;
						}
						goto case 309;
					case 524:
						GetInt_199(new IntPtr(value), GetInt_308(), num20, ref num20);
						num3 = 599;
						if (!IsValid_388())
						{
							num3 = 315;
						}
						continue;
					case 516:
						array[11] = (byte)num14;
						num3 = 487;
						if (GetObject_389() == null)
						{
							num3 = 614;
						}
						continue;
					case 47:
						num14 = 109 + 76;
						num3 = 63;
						if (!IsValid_388())
						{
							num3 = 477;
						}
						continue;
					case 131:
						array[_return_132] = (byte)num14;
						num3 = 342;
						if (IsValid_388())
						{
							num3 = 227;
						}
						continue;
					case 370:
						array[_return_132] = (byte)num14;
						num3 = 149;
						if (!IsValid_388())
						{
							num3 = 380;
						}
						continue;
					case 107:
						array6 = (byte[])GetObject_352(GetInt_359(num28));
						num3 = 490;
						continue;
					case 244:
						array[14] = 94;
						num3 = 66;
						continue;
					case 69:
						if (GetInt_308() == 4)
						{
							num3 = 12;
							continue;
						}
						goto case 596;
					case 216:
						num14 = 30 + 64;
						num3 = 240;
						if (GetObject_389() == null)
						{
							num3 = 201;
						}
						continue;
					case 102:
						array[10] = 101;
						num = 570;
						break;
					case 365:
						num15 = 171 - 52;
						num3 = 544;
						continue;
					case 17:
					{
						int num49 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						mx1DVqGxQri = false;
						if (num49 >= 1879048192)
						{
							num3 = 189;
							if (GetObject_389() != null)
							{
								num3 = 187;
							}
							continue;
						}
						goto case 278;
					}
					case 584:
						array2[14] = (byte)num15;
						num3 = 563;
						if (IsValid_388())
						{
							num3 = 496;
						}
						continue;
					case 243:
						num32 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 321;
						continue;
					case 87:
						array[31] = (byte)num14;
						num3 = 294;
						continue;
					case 294:
						num14 = 138 - 46;
						num3 = 380;
						continue;
					case 586:
						array[9] = 146;
						num3 = 503;
						continue;
					case 349:
						zero = IntPtr.Zero;
						num3 = 548;
						continue;
					case 133:
						num15 = 0 + 84;
						num3 = 101;
						if (!IsValid_388())
						{
							num3 = 233;
						}
						continue;
					case 381:
						num14 = 117 + 58;
						num3 = 193;
						if (!IsValid_388())
						{
							num3 = 3;
						}
						continue;
					case 606:
						array[18] = 138;
						num3 = 533;
						continue;
					case 346:
						array5[num26 + 7] = array6[7];
						num3 = 383;
						if (!IsValid_388())
						{
							num3 = 76;
						}
						continue;
					case 542:
						array[7] = (byte)num14;
						num3 = 251;
						continue;
					case 117:
						num14 = 63 + 117;
						num3 = 405;
						continue;
					case 83:
						array[16] = (byte)num14;
						num3 = 536;
						continue;
					case 250:
						num14 = 92 + _return_67;
						num3 = 78;
						continue;
					case 89:
						array[20] = 135;
						num3 = 174;
						continue;
					case 362:
						ExecuteAction_307();
						num3 = 556;
						if (GetObject_389() != null)
						{
							num3 = 468;
						}
						continue;
					case 621:
						intPtr8 = GetExternIntptr_192(text2);
						num3 = 46;
						if (!IsValid_388())
						{
							num3 = 410;
						}
						continue;
					case 148:
						GetInt_199(intPtr3, 4, 8, ref num27);
						num3 = 377;
						continue;
					case 162:
						ExecuteAction_307();
						num = 444;
						break;
					case 116:
					case 613:
						if (num41 >= num48)
						{
							num3 = 163;
							continue;
						}
						goto case 297;
					case 182:
						if (GetInt_308() != 4)
						{
							num3 = 644;
							if (!IsValid_388())
							{
								num3 = 432;
							}
							continue;
						}
						goto case 246;
					case 304:
						array5[num19 + 3] = array14[3];
						num3 = 298;
						continue;
					case 51:
						num14 = 151 - 50;
						num3 = 528;
						if (GetObject_389() == null)
						{
							num3 = 419;
						}
						continue;
					case 185:
						intPtr2 = GetIntptr_336(((object[])GetObject_335(_object_32))[0]);
						num3 = 94;
						continue;
					case 536:
						array[17] = 125;
						num3 = 15;
						if (IsValid_388())
						{
							num3 = 546;
						}
						continue;
					case 453:
						array[26] = (byte)num14;
						num3 = 126;
						if (GetObject_389() == null)
						{
							num3 = 610;
						}
						continue;
					case 124:
						return;
					case 352:
						num3 = 411;
						if (!IsValid_388())
						{
							num3 = 343;
						}
						continue;
					case 607:
					case 632:
						GetIntptr_292(intPtr7, 0);
						num3 = 188;
						continue;
					case 535:
						GetInt_199(intPtr9, 4, 8, ref num27);
						num3 = 480;
						continue;
					case 364:
						num15 = 148 - 49;
						num3 = 585;
						continue;
					case 192:
						num14 = 127 + 16;
						num3 = 359;
						continue;
					case 540:
						array5[num26 + 7] = array16[7];
						num3 = 439;
						if (!IsValid_388())
						{
							num3 = 212;
						}
						continue;
					case 44:
						ExecuteAction_381(GetReturn_148);
						num3 = 591;
						if (IsValid_388())
						{
							num3 = 79;
						}
						continue;
					case 427:
						intPtr2 = GetIntptr_336(((object[])GetObject_335(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly))[0]);
						num3 = 551;
						continue;
					case 457:
						_bool_16 = false;
						num3 = 97;
						continue;
					case 207:
						num21 |= array3[array3.Length - (_return_132 + num53)];
						num3 = 575;
						continue;
					case 212:
						array5[num26 + 2] = array14[2];
						num3 = 598;
						continue;
					case 537:
						array5[num26 + 2] = array16[2];
						num3 = 438;
						continue;
					case 363:
						array[28] = 88;
						num3 = 21;
						if (!IsValid_388())
						{
							num3 = 480;
						}
						continue;
					case 382:
						array4[8] = 46;
						num3 = 391;
						if (!IsValid_388())
						{
							num3 = 496;
						}
						continue;
					case 345:
						num14 = 74 + 33;
						num = 87;
						break;
					case 110:
						array2[12] = 111;
						num3 = 328;
						if (IsValid_388())
						{
							num3 = 114;
						}
						continue;
					case 594:
						array4[2] = 114;
						num3 = 181;
						if (GetObject_389() != null)
						{
							num3 = 352;
						}
						continue;
					case 68:
						array[12] = 254;
						num3 = 216;
						continue;
					case 112:
						ExecuteAction_328(GetObject_327(c6d5xyDVUcpbRW3tbpIx), 0L);
						num3 = 432;
						continue;
					case 455:
						if (num33 == 4109628145u)
						{
							num3 = 179;
							if (!IsValid_388())
							{
								num3 = 237;
							}
							continue;
						}
						goto _goto_129;
					case 222:
						num15 = 59 + 65;
						num3 = 232;
						if (!IsValid_388())
						{
							num3 = 618;
						}
						continue;
					case 127:
						GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 472;
						continue;
					case 38:
						if (num53 > 0)
						{
							num3 = 351;
							continue;
						}
						goto case 207;
					case 367:
						array2[9] = (byte)num15;
						num3 = 541;
						if (GetObject_389() != null)
						{
							num3 = 229;
						}
						continue;
					case 118:
						num41++;
						num3 = 613;
						continue;
					case 85:
						rygSO1DV2NgSiKnVHgu9._bytearray_6 = _bytearray_6;
						num3 = 233;
						continue;
					case 128:
						num40 = GetInt_339(c6d5xyDVUcpbRW3tbpIx) - num25;
						num3 = 17;
						continue;
					case 409:
						num5 = _return_66;
						num3 = 394;
						continue;
					case 529:
						if (array11 != null)
						{
							num3 = 15;
							if (GetObject_389() == null)
							{
								num3 = 206;
							}
							continue;
						}
						goto case 16;
					case 451:
						num32 = GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 95;
						if (!IsValid_388())
						{
							num3 = 332;
						}
						continue;
					case 395:
						array[14] = (byte)num14;
						num3 = 433;
						if (GetObject_389() != null)
						{
							num3 = 260;
						}
						continue;
					case 388:
						array15[3] = 74;
						num3 = 190;
						continue;
					case 146:
						num15 = 209 + 9;
						num3 = 367;
						continue;
					case 597:
						array2[8] = 58;
						num3 = 150;
						if (GetObject_389() != null)
						{
							num3 = 78;
						}
						continue;
					case 620:
						array[27] = (byte)num14;
						num3 = 578;
						continue;
					case 26:
						num31++;
						num3 = 431;
						continue;
					case 410:
						array[21] = (byte)num14;
						num3 = 256;
						continue;
					case 180:
						ExecuteAction_347(cryptoStream);
						num3 = 459;
						if (!IsValid_388())
						{
							num3 = 388;
						}
						continue;
					case 231:
						num65 = num5 ^ num21;
						num3 = 75;
						continue;
					case 371:
						array[12] = (byte)num14;
						num3 = 502;
						continue;
					case 446:
						ExecuteAction_328(GetObject_327(c6d5xyDVUcpbRW3tbpIx), 0L);
						num3 = 286;
						if (GetObject_389() != null)
						{
							num3 = 574;
						}
						continue;
					case 262:
						num14 = 212 - 70;
						num3 = 95;
						if (IsValid_388())
						{
							num3 = 319;
						}
						continue;
					case 99:
						array[16] = (byte)num14;
						num3 = 494;
						continue;
					case 181:
						array4[3] = 106;
						num3 = 531;
						if (GetObject_389() == null)
						{
							num3 = 497;
						}
						continue;
					case 520:
						intPtr9 = new IntPtr(num39 + GetInt_339(c6d5xyDVUcpbRW3tbpIx) - num25);
						num3 = 565;
						if (!IsValid_388())
						{
							num3 = 114;
						}
						continue;
					case 624:
						num21 = _return_66;
						num3 = 156;
						continue;
					case 479:
						num14 = 108 + 98;
						num3 = 414;
						continue;
					case 32:
						array2[14] = (byte)num15;
						num3 = 260;
						continue;
					case 619:
						num22 = _return_66;
						num3 = 309;
						if (IsValid_388())
						{
							num3 = 478;
						}
						continue;
					case 466:
						intPtr6 = IntPtr.Zero;
						num = 512;
						break;
					case 550:
						array[_return_132] = (byte)num14;
						num3 = 175;
						if (GetObject_389() != null)
						{
							num3 = 523;
						}
						continue;
					case 143:
						array4[3] = 111;
						num3 = 530;
						if (IsValid_388())
						{
							num3 = 56;
						}
						continue;
					case 27:
						ExecuteAction_334(array17, 0, array17.Length);
						num3 = 560;
						if (IsValid_388())
						{
							num3 = 393;
						}
						continue;
					case 569:
						num20 = 0;
						num3 = 443;
						continue;
					case 394:
						num18 = _return_66;
						num3 = 624;
						continue;
					case 531:
						array5[num19 + _return_132] = array16[_return_132];
						num3 = 200;
						if (GetObject_389() != null)
						{
							num3 = 424;
						}
						continue;
					case 635:
						GetReturn_148 = null;
						num = 336;
						break;
					case 305:
						num14 = 34 + 35;
						num3 = 142;
						continue;
					case 139:
						array[0] = (byte)num14;
						num3 = 405;
						if (GetObject_389() == null)
						{
							num3 = 615;
						}
						continue;
					case 380:
						array[31] = (byte)num14;
						num3 = 304;
						if (IsValid_388())
						{
							num3 = 208;
						}
						continue;
					case 436:
						array[_return_67] = 116;
						num3 = 509;
						continue;
					case 64:
						ExecuteAction_381(_object_13);
						num = 426;
						break;
					case 53:
						array[3] = (byte)num14;
						num3 = 511;
						continue;
					case 98:
						num50 = 0;
						num3 = 42;
						continue;
					case 215:
						array2[0] = (byte)num15;
						num3 = 364;
						continue;
					case 428:
						ExecuteAction_357(_object_39, 0L, rygSO1DV2NgSiKnVHgu10);
						num3 = 218;
						continue;
					case 238:
						array2[2] = (byte)num15;
						num = 396;
						break;
					case 211:
						array[17] = (byte)num14;
						num3 = 652;
						continue;
					case 55:
						array[28] = (byte)num14;
						num3 = 363;
						continue;
					case 442:
						return;
					case 608:
						text2 = (string)GetObject_361(GetObject_360(), array4);
						num3 = 288;
						if (!IsValid_388())
						{
							num3 = 138;
						}
						continue;
					case 357:
						array2[8] = (byte)num15;
						num3 = 209;
						if (GetObject_389() == null)
						{
							num3 = 648;
						}
						continue;
					case 132:
						array5[num26 + _return_132] = array16[_return_132];
						num3 = 537;
						continue;
					case 170:
						num14 = 79 + 37;
						num3 = 626;
						continue;
					case 45:
						array10 = array2;
						num3 = 176;
						continue;
					case 251:
						num14 = 81 + 29;
						num3 = 650;
						continue;
					case 445:
						array[9] = (byte)num14;
						num3 = 586;
						continue;
					case 601:
						num14 = 77 + 15;
						num3 = 582;
						continue;
					case 415:
						array2[6] = 94;
						num3 = 86;
						if (IsValid_388())
						{
							num3 = 590;
						}
						continue;
					case 296:
						GetInt_339(c6d5xyDVUcpbRW3tbpIx);
						num3 = 127;
						continue;
					case 209:
						num14 = 62 + 10;
						num3 = 661;
						if (IsValid_388())
						{
							num3 = 630;
						}
						continue;
					case 414:
						array[28] = (byte)num14;
						num3 = 324;
						continue;
					case 604:
						array = new byte[32];
						num3 = 166;
						if (!IsValid_388())
						{
							num3 = 479;
						}
						continue;
					case 303:
						num14 = 25 + 43;
						num3 = 542;
						if (GetObject_389() != null)
						{
							num3 = 125;
						}
						continue;
					case 81:
						array2[9] = (byte)num15;
						num3 = 375;
						continue;
					case 123:
					case 507:
						if (num37 >= num32)
						{
							num = 412;
							break;
						}
						goto case 520;
					case 407:
						num15 = 121 + 102;
						num3 = 310;
						if (!IsValid_388())
						{
							num3 = 135;
						}
						continue;
					case 468:
						array15[_return_67] = 116;
						num3 = 448;
						if (IsValid_388())
						{
							num3 = 86;
						}
						continue;
					case 311:
						num30 = array3.Length % 4;
						num3 = 328;
						continue;
					case 236:
						array4[_return_67] = 106;
						num3 = 52;
						if (!IsValid_388())
						{
							num3 = 96;
						}
						continue;
					case 90:
						array[26] = (byte)num14;
						num3 = 187;
						continue;
					case 532:
						c6d5xyDVUcpbRW3tbpIx = new GetPublic_14((Stream)GetObject_326(_object_32, "hPgIOiZVZnG3C7Zie8im.JuPwLmZVCoPtPrXBZioU"));
						num = 446;
						break;
					case 74:
						array[4] = 124;
						num3 = 281;
						continue;
					case 511:
						array[4] = 38;
						num3 = 74;
						continue;
					case 302:
						array[29] = 106;
						num3 = 9;
						continue;
					case 486:
						array[2] = 33;
						num3 = 10;
						continue;
					case 319:
						array[19] = (byte)num14;
						num3 = 501;
						if (IsValid_388())
						{
							num3 = 456;
						}
						continue;
					case 84:
						num14 = 33 + 27;
						num3 = 184;
						if (GetObject_389() == null)
						{
							num3 = 55;
						}
						continue;
					case 22:
						array[8] = 100;
						num3 = 477;
						if (GetObject_389() != null)
						{
							num3 = 621;
						}
						continue;
					case 508:
						num15 = 55 + 24;
						num = 513;
						break;
					case 374:
						num14 = 250 - 83;
						num = 11;
						break;
					case 86:
						text = (string)GetObject_361(GetObject_360(), array15);
						num3 = 475;
						if (!IsValid_388())
						{
							num3 = 133;
						}
						continue;
					case 242:
						GetInt_355(intPtr5);
						num3 = 362;
						continue;
					case 322:
						array[23] = (byte)num14;
						num3 = 577;
						continue;
					case 169:
						array4[_return_132] = 108;
						num3 = 152;
						if (GetObject_389() == null)
						{
							num3 = 594;
						}
						continue;
					case 281:
						array[4] = 169;
						num3 = 178;
						continue;
					case 76:
						num19 = 23;
						num3 = 287;
						continue;
					case 549:
						array10[7] = array11[3];
						num = 555;
						break;
					case 166:
						num14 = 30 + 16;
						num3 = 139;
						continue;
					case 609:
						array[27] = 152;
						num3 = 600;
						continue;
					case 115:
						num14 = 98 + 58;
						num3 = 623;
						continue;
					case 600:
						array[27] = 166;
						num3 = 636;
						continue;
					case 33:
						num15 = 106 - 37;
						num3 = 292;
						continue;
					case 164:
						if (GetInt_199(intPtr3, 4, 4, ref num27) == 0)
						{
							num3 = 148;
							continue;
						}
						goto case 377;
					case 598:
						array5[num26 + 3] = array14[3];
						num = 6;
						break;
					case 416:
						rygSO1DV2NgSiKnVHgu10._bytearray_6 = new byte[_return_132] { 42 };
						num3 = 469;
						continue;
					case 553:
						if (num16 == num17 - _return_132)
						{
							num3 = 253;
							continue;
						}
						goto case 605;
					case 94:
						_long_28 = intPtr2.ToInt64();
						num3 = 349;
						continue;
					case 424:
						num15 = 205 - 68;
						num3 = 357;
						continue;
					case 314:
						value = GetInt_367(intPtr7);
						num3 = 89;
						if (GetObject_389() == null)
						{
							num3 = 607;
						}
						continue;
					case 108:
						num29 = num16 * 4;
						num3 = 57;
						continue;
					case 599:
						ExecuteAction_307();
						num3 = 442;
						continue;
					case 92:
						array[11] = (byte)num14;
						num3 = 31;
						continue;
					case 328:
						num17 = array3.Length / 4;
						num3 = 399;
						continue;
					case 587:
						array[24] = (byte)num14;
						num3 = 225;
						if (!IsValid_388())
						{
							num3 = 128;
						}
						continue;
					case 475:
						intPtr7 = GetIntptr_365((GetDelegateIntptr_13)GetObject_363(GetExternIntptr_193(intPtr8, text), GetType_358(typeof(GetDelegateIntptr_13).TypeHandle)));
						num3 = 194;
						if (GetObject_389() == null)
						{
							num3 = 602;
						}
						continue;
					case 449:
						num14 = 234 - 78;
						num3 = 43;
						continue;
					case 252:
						array[21] = 119;
						num3 = 48;
						continue;
					case 588:
						array[13] = (byte)num14;
						num3 = 195;
						if (!IsValid_388())
						{
							num3 = 330;
						}
						continue;
					case 610:
						array[26] = 98;
						num3 = 29;
						continue;
					case 191:
						array2[3] = (byte)num15;
						num3 = 587;
						if (GetObject_389() == null)
						{
							num3 = 326;
						}
						continue;
					case 260:
						num15 = 53 + 66;
						num3 = 584;
						if (!IsValid_388())
						{
							num3 = 171;
						}
						continue;
					case 37:
						_bytearray_6 = (byte[])GetObject_330(c6d5xyDVUcpbRW3tbpIx, num35);
						num3 = 234;
						continue;
					case 130:
						array2[8] = (byte)num15;
						num3 = 645;
						continue;
					case 326:
						num15 = 139 - 24;
						num3 = 385;
						if (IsValid_388())
						{
							num3 = 109;
						}
						continue;
					case 323:
						array2[_return_67] = (byte)num15;
						num = 525;
						break;
					case 525:
						array2[_return_67] = 160;
						num = 339;
						break;
					case 499:
						GetInt_197(intPtr5, intPtr3, (byte[])GetObject_352(GetInt_339(c6d5xyDVUcpbRW3tbpIx)), 4u, out zero);
						num3 = 646;
						continue;
					case 417:
						array8[num29 + num34] = (byte)((num51 & num52) >> num64);
						num3 = 501;
						continue;
					case 623:
						array[10] = (byte)num14;
						num3 = 170;
						continue;
					case 590:
						array2[6] = 127;
						num3 = 631;
						continue;
					case 310:
						array2[13] = (byte)num15;
						num3 = 365;
						continue;
					case 649:
						array14 = (byte[])GetObject_380(intPtr6.ToInt64());
						num3 = 23;
						continue;
					case 630:
						array[6] = (byte)num14;
						num3 = 418;
						continue;
					case 52:
						array4[6] = 105;
						num3 = 137;
						if (GetObject_389() == null)
						{
							num3 = 338;
						}
						continue;
					case 109:
						array2[3] = (byte)num15;
						num3 = 271;
						continue;
					case 276:
						array2[11] = 117;
						num3 = 488;
						continue;
					case 481:
						num14 = 63 + 54;
						num3 = 448;
						continue;
					case 265:
						if (((Array)GetObject_375(GetObject_371(GetType_358(typeof(GetInternal_100).TypeHandle).Assembly))).Length == 2)
						{
							num3 = 498;
							if (!IsValid_388())
							{
								num3 = 190;
							}
							continue;
						}
						goto case 352;
					case 602:
						value = 0L;
						num3 = 641;
						if (!IsValid_388())
						{
							num3 = 464;
						}
						continue;
					case 268:
						num14 = 167 - 55;
						num = 92;
						break;
					case 331:
						num14 = 161 - 53;
						num3 = 161;
						continue;
					case 556:
						return;
					case 4:
						_ = IntPtr.Zero;
						num3 = 416;
						if (GetObject_389() == null)
						{
							num3 = 569;
						}
						continue;
					case 114:
						array2[12] = 148;
						num3 = 249;
						continue;
					case 476:
					case 534:
						num16++;
						num3 = 203;
						continue;
					case 225:
						array[24] = 117;
						num3 = 317;
						if (GetObject_389() != null)
						{
							num3 = 417;
						}
						continue;
					case 316:
						num23 = 0L;
						num3 = 113;
						if (!IsValid_388())
						{
							num3 = 515;
						}
						continue;
					case 480:
						ExecuteAction_354(intPtr9, GetInt_339(c6d5xyDVUcpbRW3tbpIx));
						num3 = 214;
						continue;
					case 137:
						GetInt_197(intPtr5, intPtr3, (byte[])GetObject_352(GetInt_339(c6d5xyDVUcpbRW3tbpIx)), 4u, out zero);
						num3 = 14;
						continue;
					case 320:
						array2[10] = (byte)num15;
						num3 = 653;
						continue;
					case 473:
						num34 = 0;
						num3 = 263;
						continue;
					case 298:
					case 638:
						ExecuteAction_299(array5, 0, intPtr, array5.Length);
						num3 = 457;
						continue;
					case 478:
						num16 = 0;
						num3 = 259;
						continue;
					case 454:
						num33 = 4059231220u;
						num3 = 316;
						continue;
					case 430:
					case 431:
						if (num31 >= num32)
						{
							num3 = 576;
							continue;
						}
						goto case 484;
					case 190:
						array15[4] = 105;
						num = 468;
						break;
					case 78:
						array[8] = (byte)num14;
						num3 = 22;
						if (!IsValid_388())
						{
							num3 = 116;
						}
						continue;
					case 233:
						rygSO1DV2NgSiKnVHgu9._bool_5 = mx1DVqGxQri;
						num3 = 34;
						continue;
					case 579:
						array5[num26 + 6] = array14[6];
						num3 = 201;
						if (GetObject_389() == null)
						{
							num3 = 269;
						}
						continue;
					case 383:
						num26 = 30;
						num3 = 454;
						if (IsValid_388())
						{
							num3 = 3;
						}
						continue;
					case 526:
						ExecuteAction_300();
						num3 = 420;
						if (IsValid_388())
						{
							num3 = 455;
						}
						continue;
					case 253:
						if (num30 > 0)
						{
							num3 = 390;
							if (GetObject_389() == null)
							{
								num3 = 348;
							}
							continue;
						}
						goto case 605;
					case 171:
						if (IsValid_310(GetType_309("System.Reflection.ReflectionContext", false), null))
						{
							num = 500;
							break;
						}
						goto case 532;
					case 19:
						array5[num19 + _return_132] = array6[_return_132];
						num3 = 125;
						if (GetObject_389() == null)
						{
							num3 = 275;
						}
						continue;
					case 647:
						num15 = 25 + 13;
						num3 = 368;
						continue;
					case 483:
						array[12] = (byte)num14;
						num3 = 312;
						if (GetObject_389() != null)
						{
							num3 = 450;
						}
						continue;
					case 644:
					{
						byte[] array12 = new byte[40];
						ExecuteAction_384(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array13 = array12;
						num3 = 277;
						continue;
					}
					case 353:
						array[3] = (byte)num14;
						num3 = 449;
						if (GetObject_389() != null)
						{
							num3 = 288;
						}
						continue;
					case 651:
						array4[8] = 108;
						num3 = 482;
						continue;
					case 482:
						array4[9] = 108;
						num3 = 198;
						if (!IsValid_388())
						{
							num3 = 381;
						}
						continue;
					case 439:
						num26 = 18;
						num3 = 498;
						if (GetObject_389() == null)
						{
							num3 = 474;
						}
						continue;
					case 503:
						num14 = 169 - 56;
						num3 = 91;
						continue;
					case 62:
						array16 = (byte[])GetObject_380(_intptr_19.ToInt64());
						num3 = 368;
						if (GetObject_389() == null)
						{
							num3 = 649;
						}
						continue;
					case 459:
						ExecuteAction_348(c6d5xyDVUcpbRW3tbpIx);
						num3 = 243;
						continue;
					case 539:
						GetInt_199(intPtr4, num24 * 4, num27, ref num27);
						num3 = 301;
						continue;
					case 555:
						array10[9] = array11[4];
						num3 = 257;
						continue;
					case 329:
						num14 = 249 - 83;
						num3 = 378;
						continue;
					case 194:
						array9 = array8;
						num3 = 592;
						if (GetObject_389() != null)
						{
							num3 = 231;
						}
						continue;
					case 337:
						if (array7.Length != 0)
						{
							num3 = 342;
							if (!IsValid_388())
							{
								num3 = 186;
							}
							continue;
						}
						goto case 7;
					case 335:
						array[10] = (byte)num14;
						num3 = 115;
						continue;
					case 23:
						array6 = (byte[])GetObject_380(num28);
						num3 = 282;
						if (GetObject_389() != null)
						{
							num3 = 361;
						}
						continue;
					case 213:
						num15 = 106 + 28;
						num3 = 141;
						if (IsValid_388())
						{
							num3 = 323;
						}
						continue;
					case 203:
					case 259:
						if (num16 >= num17)
						{
							num3 = 214;
							if (IsValid_388())
							{
								num3 = 194;
							}
							continue;
						}
						goto case 141;
					case 193:
						array[20] = (byte)num14;
						num3 = 505;
						continue;
					case 517:
						array5[num26 + _return_67] = array6[_return_67];
						num3 = 144;
						if (GetObject_389() == null)
						{
							num3 = 228;
						}
						continue;
					case 399:
						array8 = new byte[array3.Length];
						num3 = 41;
						continue;
					case 342:
					case 519:
						ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array7[0]);
						num3 = 266;
						if (GetObject_389() != null)
						{
							num3 = 217;
						}
						continue;
					case 228:
						array5[num26 + 6] = array6[6];
						num3 = 346;
						continue;
					case 264:
						array2[9] = (byte)num15;
						num3 = 315;
						continue;
					case 582:
						array[16] = (byte)num14;
						num3 = 256;
						if (IsValid_388())
						{
							num3 = 134;
						}
						continue;
					case 317:
						array[25] = 131;
						num3 = 21;
						if (GetObject_389() == null)
						{
							num3 = 47;
						}
						continue;
					case 426:
						ExecuteAction_383(GetRuntimemethodhandle_382(GetObject_373(_object_13)));
						num3 = 205;
						if (IsValid_388())
						{
							num3 = 58;
						}
						continue;
					case 261:
						array[11] = (byte)num14;
						num3 = 59;
						continue;
					case 299:
						array4[_return_67] = 116;
						num3 = 255;
						continue;
					case 523:
						num25 = 0;
						num3 = 90;
						if (IsValid_388())
						{
							num3 = 100;
						}
						continue;
					case 49:
						num14 = 106 + 109;
						num3 = 213;
						if (GetObject_389() == null)
						{
							num3 = 483;
						}
						continue;
					case 495:
						array2[12] = 167;
						num3 = 316;
						if (IsValid_388())
						{
							num3 = 110;
						}
						continue;
					case 113:
						GetIntptr_292(new IntPtr(&num23), 0);
						num3 = 563;
						continue;
					case 412:
						_object_39 = new Hashtable(GetInt_339(c6d5xyDVUcpbRW3tbpIx) + _return_132);
						num3 = 245;
						continue;
					case 39:
						intPtr2 = GetIntptr_336(((object[])GetObject_335(_object_32))[0]);
						num3 = 103;
						if (!IsValid_388())
						{
							num3 = 220;
						}
						continue;
					case 240:
						num14 = 179 + 61;
						num = 53;
						break;
					case 254:
						num21 = (uint)((array3[num22 + 3] << 24) | (array3[num22 + 2] << 16) | (array3[num22 + _return_132] << 8) | array3[num22]);
						num3 = 411;
						if (IsValid_388())
						{
							num3 = 173;
						}
						continue;
					case 246:
					{
						byte[] array19 = new byte[30];
						ExecuteAction_384(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array13 = array19;
						num3 = 160;
						continue;
					}
					case 97:
						GetInt_199(new IntPtr(value), GetInt_308(), 64, ref num20);
						num3 = 235;
						continue;
					case 585:
						array2[0] = (byte)num15;
						num3 = 358;
						continue;
					case 593:
						num15 = 124 + 102;
						num3 = 140;
						continue;
					case 500:
						enumerator = (IEnumerator)GetObject_312(GetObject_311(GetObject_301()));
						num3 = 153;
						continue;
					case 441:
						array[17] = (byte)num14;
						num3 = 423;
						continue;
					case 197:
						num19 = 16;
						num3 = 291;
						continue;
					case 558:
						if (num16 == num17 - _return_132)
						{
							num3 = 403;
							continue;
						}
						goto case 231;
					case 564:
						{
							uint num4 = num5;
							uint num6 = num5;
							uint num7 = 1257709153u;
							uint num8 = 807144328u;
							uint num9 = 1954095982u;
							uint num10 = 1022397983u;
							uint num11 = num6;
							ulong num12 = num8 * num10;
							if (num12 == 0)
							{
								num12--;
							}
							num7 = (uint)(num7 * num7 % num12);
							num9 ^= num8;
							num12 = num7 * 1026830853;
							if (num12 == 0)
							{
								num12--;
							}
							num8 = (uint)(num8 * num8 % num12);
							if (num10 == 0)
							{
								num10--;
							}
							uint num13 = num7 / num10 + num10;
							num10 = ((num7 + num7) ^ num13) + num7;
							if (num11 == 0)
							{
								num11--;
							}
							num13 = num7 / num11 + num11;
							num11 = num7 - num7 + num13 + num7;
							num11 ^= num11 << 7;
							num11 += num8;
							num11 ^= num11 >> _return_132;
							num11 += num10;
							num11 ^= num11 << 25;
							num11 += num11;
							num11 = (((num10 << 3) + num10) ^ num10) + num11;
							num5 = num4 + (uint)(double)num11;
							num3 = 558;
							continue;
						}
						_goto_129:
						if (GetInt_308() == 4)
						{
							num3 = 171;
							continue;
						}
						goto case 532;
					}
					goto _goto_130;
					continue;
					_goto_68:
					break;
				}
				continue;
				_goto_130:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_191(object GetReturn_366)
	{
		try
		{
			if (File.Exists(((Assembly)GetReturn_366).Location))
			{
				return ((Assembly)GetReturn_366).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)GetReturn_366).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)GetReturn_366).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(GetReturn_366.GetType().GetProperty("Location").GetValue(GetReturn_366, new object[0])
				.ToString()))
			{
				return GetReturn_366.GetType().GetProperty("Location").GetValue(GetReturn_366, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr GetExternIntptr_192(string GetReturn_366);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr GetExternIntptr_193(IntPtr GetReturn_366, string P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr GetReturn_305(IntPtr GetReturn_366, object P_1, uint P_2)
	{
		if (_object_12 == null)
		{
			_object_12 = (GetDelegateIntptr_20)Marshal.GetDelegateForFunctionPointer(GetExternIntptr_193(GetSpecialnamePrivateStaticIntptr_205(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555532)));
		}
		return _object_12(GetReturn_366, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr GetReturn_386(IntPtr GetReturn_366, uint P_1, uint P_2, uint P_3)
	{
		if (GetReturn_196 == null)
		{
			GetReturn_196 = (GetDelegateIntptr_21)Marshal.GetDelegateForFunctionPointer(GetExternIntptr_193(GetSpecialnamePrivateStaticIntptr_205(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555533)));
		}
		return GetReturn_196(GetReturn_366, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetInt_197(IntPtr GetReturn_366, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (GetReturn_198 == null)
		{
			GetReturn_198 = (GetDelegateInt_22)Marshal.GetDelegateForFunctionPointer(GetExternIntptr_193(GetSpecialnamePrivateStaticIntptr_205(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555534)));
		}
		return GetReturn_198(GetReturn_366, P_1, P_2, P_3, out P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetInt_199(IntPtr GetReturn_366, int P_1, int P_2, ref int P_3)
	{
		if (GetReturn_200 == null)
		{
			GetReturn_200 = (GetDelegateInt_23)Marshal.GetDelegateForFunctionPointer(GetExternIntptr_193(GetSpecialnamePrivateStaticIntptr_205(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555535)));
		}
		return GetReturn_200(GetReturn_366, P_1, P_2, ref P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr GetReturn_351(uint GetReturn_366, int P_1, uint P_2)
	{
		if (GetReturn_202 == null)
		{
			GetReturn_202 = (GetDelegateIntptr_24)Marshal.GetDelegateForFunctionPointer(GetExternIntptr_193(GetSpecialnamePrivateStaticIntptr_205(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555536)));
		}
		return GetReturn_202(GetReturn_366, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetReturn_356(IntPtr GetReturn_366)
	{
		if (GetReturn_204 == null)
		{
			GetReturn_204 = (GetDelegateInt_25)Marshal.GetDelegateForFunctionPointer(GetExternIntptr_193(GetSpecialnamePrivateStaticIntptr_205(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(AppClass_073.fghTg5snajP(33555537)));
		}
		return GetReturn_204(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private static IntPtr GetSpecialnamePrivateStaticIntptr_205()
	{
		if (_return_131 == IntPtr.Zero)
		{
			_return_131 = GetExternIntptr_192("kernel ".Trim() + "32.dll");
		}
		return _return_131;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] GetByte_206(object GetReturn_366)
	{
		using FileStream fileStream = new FileStream((string)GetReturn_366, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Stream GetReturn_261()
	{
		return new MemoryStream();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] GetReturn_266(object GetReturn_366)
	{
		return ((MemoryStream)GetReturn_366).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] GetByte_209(object GetReturn_366)
	{
		Stream stream = GetReturn_261();
		SymmetricAlgorithm symmetricAlgorithm = GetReturn_341();
		symmetricAlgorithm.Key = new byte[32]
		{
			105, 101, 154, 233, 105, 242, 162, 242, 174, 35,
			52, 50, 92, 216, 30, 32, 34, 184, 230, 60,
			130, 188, 90, 153, 208, 38, 230, 66, 151, 181,
			116, 86
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			143, 136, 248, 49, 35, 62, 57, 117, 28, 209,
			158, 46, 142, 81, 253, 34
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])GetReturn_366, 0, ((Array)GetReturn_366).Length);
		cryptoStream.Close();
		byte[] result = GetReturn_266(stream);
		AppClass_051.f8oTg3pM5fk();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] GetByte_210()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] GetByte_211()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] GetByte_212()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] GetByte_213()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] GetByte_214()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] GetByte_215()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] GetByte_216()
	{
		_ = "R7yJgtgiwTxYhJ98ODr".Length;
		_ = 0;
		return new byte[2] { _return_132, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] GetByte_217()
	{
		_ = "fF3JdJdCnaBNOPe56H3pBi".Length;
		_ = 0;
		return new byte[2] { _return_132, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] GetByte_218()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] GetByte_219()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_220(object GetReturn_366)
	{
		return ((GetPublic_14)GetReturn_366).GetSpecialnameInternalStream_15();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_221(object GetReturn_366, long P_1)
	{
		((Stream)GetReturn_366).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_222(object GetReturn_366)
	{
		return ((Stream)GetReturn_366).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_223(object GetReturn_366, int P_1)
	{
		return ((GetPublic_14)GetReturn_366).GetByte_16(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_224(object GetReturn_366)
	{
		((GetPublic_14)GetReturn_366).ExecuteAction_19();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_225(object GetReturn_366)
	{
		Array.Reverse((Array)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_226(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_227(object GetReturn_366)
	{
		return ((AssemblyName)GetReturn_366).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_228()
	{
		return GetReturn_341();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_230(object GetReturn_366, CipherMode P_1)
	{
		((SymmetricAlgorithm)GetReturn_366).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_231(object GetReturn_366, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)GetReturn_366).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_232()
	{
		return GetReturn_261();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_234(object GetReturn_366, object P_1, int P_2, int P_3)
	{
		((Stream)GetReturn_366).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_235(object GetReturn_366)
	{
		((CryptoStream)GetReturn_366).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_236(object GetReturn_366)
	{
		return GetReturn_266(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_238(object GetReturn_366)
	{
		((Stream)GetReturn_366).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_239(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).EntryPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_240(object GetReturn_366, object P_1)
	{
		return (MethodInfo)GetReturn_366 == (MethodInfo)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_241()
	{
		return null == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_242()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_243()
	{
		AppClass_051.f8oTg3pM5fk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_244(bool GetReturn_366)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = GetReturn_366;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type GetType_245(RuntimeTypeHandle GetReturn_366)
	{
		return Type.GetTypeFromHandle(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_246(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_247(object GetReturn_366)
	{
		return ((string)GetReturn_366).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_248()
	{
		return SHA1.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_249(object GetReturn_366)
	{
		return CryptoConfig.MapNameToOID((string)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_250(object GetReturn_366)
	{
		return File.Exists((string)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_251(object GetReturn_366, object P_1)
	{
		return ((Assembly)GetReturn_366).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_252(object GetReturn_366)
	{
		return ((GetPublic_14)GetReturn_366).GetSpecialnameInternalStream_15();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_253(object GetReturn_366, long P_1)
	{
		((Stream)GetReturn_366).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_254(object GetReturn_366)
	{
		return ((Stream)GetReturn_366).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_255(object GetReturn_366, int P_1)
	{
		return ((GetPublic_14)GetReturn_366).GetByte_16(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_256()
	{
		return GetReturn_341();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_258(object GetReturn_366, CipherMode P_1)
	{
		((SymmetricAlgorithm)GetReturn_366).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_259(object GetReturn_366, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)GetReturn_366).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_260()
	{
		return GetReturn_261();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_262(object GetReturn_366, object P_1, int P_2, int P_3)
	{
		((Stream)GetReturn_366).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_263(object GetReturn_366)
	{
		((CryptoStream)GetReturn_366).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_264()
	{
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_265(object GetReturn_366)
	{
		return GetReturn_266(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_267(object GetReturn_366, object P_1)
	{
		return ((Encoding)GetReturn_366).GetString((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_268(object GetReturn_366, object P_1)
	{
		((AsymmetricAlgorithm)GetReturn_366).FromXmlString((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_269(object GetReturn_366)
	{
		((Stream)GetReturn_366).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_270(object GetReturn_366)
	{
		((GetPublic_14)GetReturn_366).ExecuteAction_19();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_271(object GetReturn_366, object P_1, uint P_2, object P_3)
	{
		ExecuteAction_108(GetReturn_366, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort GetUshort_272(object GetReturn_366)
	{
		return ((BinaryReader)GetReturn_366).ReadUInt16();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_273(object GetReturn_366, object P_1, int P_2, int P_3)
	{
		return ((Stream)GetReturn_366).Read((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_274(object GetReturn_366, object P_1, int P_2, int P_3)
	{
		ExecuteAction_110(GetReturn_366, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_275(object GetReturn_366)
	{
		return ((Stream)GetReturn_366).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint GetUint_276(object GetReturn_366)
	{
		return ((BinaryReader)GetReturn_366).ReadUInt32();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint GetUint_277(uint GetReturn_366, int P_1, long P_2, object P_3)
	{
		return GetReturn_278(GetReturn_366, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_279(long GetReturn_366, long P_1)
	{
		return Math.Min(GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_280(object GetReturn_366, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)GetReturn_366).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_281(object GetReturn_366, int P_1)
	{
		return ((BinaryReader)GetReturn_366).ReadBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_282(object GetReturn_366)
	{
		Array.Reverse((Array)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_283(object GetReturn_366)
	{
		return ((HashAlgorithm)GetReturn_366).Hash;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_284(object GetReturn_366, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)GetReturn_366).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_285(object GetReturn_366)
	{
		((BinaryReader)GetReturn_366).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_286(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_287(object GetReturn_366)
	{
		return ((AssemblyName)GetReturn_366).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_288(object GetReturn_366, object P_1)
	{
		return (string)GetReturn_366 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_289()
	{
		return null == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_290()
	{
		return null;
	}

	static int GetInt_291()
	{
		return _return_132;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_292(IntPtr GetReturn_366, int P_1)
	{
		return Marshal.ReadIntPtr(GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_293(IntPtr GetReturn_366, int P_1)
	{
		return Marshal.ReadInt32(GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_294(IntPtr GetReturn_366, int P_1)
	{
		return Marshal.ReadInt64(GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_295(IntPtr GetReturn_366, int P_1, IntPtr P_2)
	{
		Marshal.WriteIntPtr(GetReturn_366, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_296(IntPtr GetReturn_366, int P_1, int P_2)
	{
		Marshal.WriteInt32(GetReturn_366, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_297(IntPtr GetReturn_366, int P_1, long P_2)
	{
		Marshal.WriteInt64(GetReturn_366, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_298(int GetReturn_366)
	{
		return Marshal.AllocCoTaskMem(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_299(object GetReturn_366, int P_1, IntPtr P_2, int P_3)
	{
		Marshal.Copy((byte[])GetReturn_366, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_300()
	{
		ExecuteAction_150();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_301()
	{
		return Process.GetCurrentProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_302(object GetReturn_366)
	{
		return ((Process)GetReturn_366).MainModule;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_303(object GetReturn_366)
	{
		return ((ProcessModule)GetReturn_366).BaseAddress;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_304(IntPtr GetReturn_366, object P_1, uint P_2)
	{
		return GetReturn_305(GetReturn_366, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_306(IntPtr GetReturn_366, IntPtr P_1)
	{
		return GetReturn_366 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_307()
	{
		AppClass_051.f8oTg3pM5fk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_308()
	{
		return IntPtr.Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type GetType_309(object GetReturn_366, bool P_1)
	{
		return Type.GetType((string)GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_310(Type GetReturn_366, Type P_1)
	{
		return GetReturn_366 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_311(object GetReturn_366)
	{
		return ((Process)GetReturn_366).Modules;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_312(object GetReturn_366)
	{
		return ((ReadOnlyCollectionBase)GetReturn_366).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_313(object GetReturn_366)
	{
		return ((IEnumerator)GetReturn_366).Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_314(object GetReturn_366)
	{
		return ((ProcessModule)GetReturn_366).ModuleName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_315(object GetReturn_366)
	{
		return ((string)GetReturn_366).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_316(object GetReturn_366, object P_1)
	{
		return (string)GetReturn_366 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_317(object GetReturn_366)
	{
		return ((ProcessModule)GetReturn_366).FileVersionInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_318(object GetReturn_366)
	{
		return ((FileVersionInfo)GetReturn_366).ProductMajorPart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_319(object GetReturn_366)
	{
		return ((FileVersionInfo)GetReturn_366).ProductMinorPart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_320(object GetReturn_366)
	{
		return ((FileVersionInfo)GetReturn_366).ProductBuildPart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_321(object GetReturn_366)
	{
		return ((FileVersionInfo)GetReturn_366).ProductPrivatePart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_322(object GetReturn_366, object P_1)
	{
		return (Version)GetReturn_366 >= (Version)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_323(object GetReturn_366, object P_1)
	{
		return (Version)GetReturn_366 < (Version)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_324(object GetReturn_366)
	{
		return ((IEnumerator)GetReturn_366).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_325(object GetReturn_366)
	{
		((IDisposable)GetReturn_366).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_326(object GetReturn_366, object P_1)
	{
		return ((Assembly)GetReturn_366).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_327(object GetReturn_366)
	{
		return ((GetPublic_14)GetReturn_366).GetSpecialnameInternalStream_15();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_328(object GetReturn_366, long P_1)
	{
		((Stream)GetReturn_366).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_329(object GetReturn_366)
	{
		return ((Stream)GetReturn_366).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_330(object GetReturn_366, int P_1)
	{
		return ((GetPublic_14)GetReturn_366).GetByte_16(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_331(object GetReturn_366)
	{
		Array.Reverse((Array)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_332(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_333(object GetReturn_366)
	{
		return ((AssemblyName)GetReturn_366).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_334(object GetReturn_366, int P_1, int P_2)
	{
		Array.Clear((Array)GetReturn_366, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_335(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_336(object GetReturn_366)
	{
		return Marshal.GetHINSTANCE((Module)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_337(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_338(object GetReturn_366)
	{
		return ((string)GetReturn_366).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_339(object GetReturn_366)
	{
		return ((GetPublic_14)GetReturn_366).GetInt_18();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_340()
	{
		return GetReturn_341();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_342(object GetReturn_366, CipherMode P_1)
	{
		((SymmetricAlgorithm)GetReturn_366).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_343(object GetReturn_366, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)GetReturn_366).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_344(object GetReturn_366, object P_1, int P_2, int P_3)
	{
		((Stream)GetReturn_366).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_345(object GetReturn_366)
	{
		((CryptoStream)GetReturn_366).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_346(object GetReturn_366)
	{
		return ((MemoryStream)GetReturn_366).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_347(object GetReturn_366)
	{
		((Stream)GetReturn_366).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_348(object GetReturn_366)
	{
		((GetPublic_14)GetReturn_366).ExecuteAction_19();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_349(object GetReturn_366)
	{
		return ((Process)GetReturn_366).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_350(uint GetReturn_366, int P_1, uint P_2)
	{
		return GetReturn_351(GetReturn_366, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_352(int GetReturn_366)
	{
		return BitConverter.GetBytes(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_353(object GetReturn_366)
	{
		return ((Stream)GetReturn_366).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_354(IntPtr GetReturn_366, int P_1)
	{
		Marshal.WriteInt32(GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_355(IntPtr GetReturn_366)
	{
		return GetReturn_356(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_357(object GetReturn_366, object P_1, object P_2)
	{
		((Hashtable)GetReturn_366).Add(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type GetType_358(RuntimeTypeHandle GetReturn_366)
	{
		return Type.GetTypeFromHandle(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_359(long GetReturn_366)
	{
		return Convert.ToInt32(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_360()
	{
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_361(object GetReturn_366, object P_1)
	{
		return ((Encoding)GetReturn_366).GetString((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_362(IntPtr GetReturn_366, IntPtr P_1)
	{
		return GetReturn_366 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_363(IntPtr GetReturn_366, Type P_1)
	{
		return GetReturn_364(GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_365(object GetReturn_366)
	{
		return GetReturn_366();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_367(IntPtr GetReturn_366)
	{
		return Marshal.ReadInt32(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GetLong_368(IntPtr GetReturn_366)
	{
		return Marshal.ReadInt64(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_369(object GetReturn_366)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetInt_370(object GetReturn_366)
	{
		return ((ProcessModule)GetReturn_366).ModuleMemorySize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_371(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).EntryPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_372(object GetReturn_366, object P_1)
	{
		return (MethodInfo)GetReturn_366 != (MethodInfo)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_373(object GetReturn_366)
	{
		return ((Delegate)GetReturn_366).Method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_374(Type GetReturn_366, object P_1)
	{
		return Delegate.CreateDelegate(GetReturn_366, (MethodInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_375(object GetReturn_366)
	{
		return ((MethodBase)GetReturn_366).GetParameters();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_376(object GetReturn_366)
	{
		return ((Assembly)GetReturn_366).ManifestModule;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle GetModulehandle_377(object GetReturn_366)
	{
		return ((Module)GetReturn_366).ModuleHandle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type GetType_378(object GetReturn_366)
	{
		return GetReturn_366.GetType();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_379(object GetReturn_366, object P_1)
	{
		return ((FieldInfo)GetReturn_366).GetValue(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetObject_380(long GetReturn_366)
	{
		return BitConverter.GetBytes(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_381(object GetReturn_366)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeMethodHandle GetRuntimemethodhandle_382(object GetReturn_366)
	{
		return ((MethodBase)GetReturn_366).MethodHandle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_383(RuntimeMethodHandle GetReturn_366)
	{
		RuntimeHelpers.PrepareMethod(GetReturn_366);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_384(object GetReturn_366, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)GetReturn_366, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr GetIntptr_385(IntPtr GetReturn_366, uint P_1, uint P_2, uint P_3)
	{
		return GetReturn_386(GetReturn_366, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExecuteAction_387(IntPtr GetReturn_366, IntPtr P_1)
	{
		Marshal.WriteIntPtr(GetReturn_366, P_1);
	}

	internal static bool IsValid_388()
	{
		return null == null;
	}

	internal static object GetObject_389()
	{
		return null;
	}
}
