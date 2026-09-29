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
using ns62;
using ns63;
using ns64;
using ns65;

namespace ns61;

internal class GetInternal_14
{
	private delegate void GetDelegateVoid_1(object objectParam);

	internal class GetPublic_3 : Attribute
	{
		internal class GetStatic_2<T>
		{
			internal static object objectParam;

			static GetStatic_2()
			{
				voidParam();
				int num = _return_314;
				while (true)
				{
					voidParam();
					while (true)
					{
						voidParam();
						while (true)
						{
							AppClass_969.voidParam();
							num = 9;
							while (true)
							{
								if (num != 9)
								{
									if (num != 990)
									{
										break;
									}
									switch (num)
									{
									case 2:
										goto _goto_1;
									case 0:
										goto _goto_2;
									case _return_314:
										goto _goto_3;
									}
									continue;
								}
								return;
								continue;
								_goto_1:
								break;
							}
							continue;
							_goto_2:
							break;
						}
						continue;
						_goto_3:
						break;
					}
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static object objectParam()
			{
				return null;
			}
		}

		public GetPublic_3(object objectParam)
		{
		}
	}

	internal class AppClass_963
	{
		internal static string boolParam(object objectParam, object objectParam)
		{
			return null;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint GetDelegateUint_4(IntPtr _intptr_4, IntPtr _return_313, IntPtr _intptr_8, uint uintParam, IntPtr _intptr_10, ref uint uintParam);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GetDelegateIntptr_5();

	internal struct AppStruct_964
	{
		internal bool boolParam;

		internal byte[] byte_0;
	}

	internal class GetPublic_6
	{
		private object objectParam;

		public GetPublic_6(Stream streamParam)
		{
			objectParam = new BinaryReader(streamParam);
		}

		[SpecialName]
		internal Stream streamParam()
		{
			return ((BinaryReader)objectParam).BaseStream;
		}

		internal byte[] voidParam(int intParam)
		{
			return ((BinaryReader)objectParam).ReadBytes(intParam);
		}

		internal int intParam(byte[] byte_0, int intParam, int intParam)
		{
			return ((BinaryReader)objectParam).Read(byte_0, intParam, intParam);
		}

		internal int intParam()
		{
			return ((BinaryReader)objectParam).ReadInt32();
		}

		internal void voidParam()
		{
			((BinaryReader)objectParam).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr GetDelegateIntptr_7(IntPtr _intptr_4, string stringParam, uint uintParam);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GetDelegateIntptr_8(IntPtr _intptr_4, uint uintParam, uint uintParam, uint uintParam);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int GetDelegateInt_9(IntPtr _intptr_4, IntPtr _return_313, [In][Out] byte[] byte_0, uint uintParam, out IntPtr _intptr_8);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int GetDelegateInt_10(IntPtr _intptr_4, int intParam, int intParam, ref int intParam);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GetDelegateIntptr_11(uint uintParam, int intParam, uint uintParam);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int GetDelegateInt_12(IntPtr _intptr_4);

	[Flags]
	private enum AppEnum_966
	{

	}

	private static int intParam;

	internal static object objectParam;

	private static bool boolParam;

	private static bool boolParam;

	private static Dictionary<int, int> intParam;

	private static object objectParam;

	internal static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static bool boolParam;

	private static object objectParam;

	private static object objectParam;

	private static IntPtr _intptr_4;

	private static object objectParam;

	private static bool boolParam;

	private static bool boolParam;

	private static long _long_5;

	private static int intParam;

	private static object objectParam;

	private static IntPtr _return_313;

	private static int intParam;

	private static long _long_7;

	private static object objectParam;

	private static IntPtr _intptr_8;

	[GetPublic_3(typeof(GetPublic_3.GetStatic_2<object>[]))]
	private static bool boolParam;

	internal static object objectParam;

	private static List<string> _listString_9;

	private static object objectParam;

	private static object objectParam;

	private static int intParam;

	private static IntPtr _intptr_10;

	private static List<int> _listInt_11;

	internal static object objectParam;

	private static object objectParam;

	private static int intParam;

	private static object objectParam;

	private static bool boolParam;

	private static object objectParam;

	private static object objectParam;

	internal static object objectParam;

	static GetInternal_14()
	{
		boolParam = false;
		objectParam = Type.GetTypeFromHandle(AppClass_968.boolParam(33555523)).Assembly;
		objectParam = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		boolParam = false;
		boolParam = false;
		objectParam = null;
		intParam = null;
		objectParam = new object();
		intParam = 0;
		objectParam = new object();
		_listString_9 = null;
		_listInt_11 = null;
		objectParam = new byte[0];
		objectParam = new byte[0];
		_intptr_8 = IntPtr.Zero;
		_intptr_10 = IntPtr.Zero;
		objectParam = new string[0];
		objectParam = new int[0];
		intParam = _return_314;
		boolParam = false;
		objectParam = new SortedList();
		intParam = 0;
		_long_7 = 0L;
		objectParam = null;
		objectParam = null;
		_long_5 = 0L;
		intParam = 0;
		boolParam = false;
		boolParam = false;
		intParam = 0;
		_intptr_4 = IntPtr.Zero;
		boolParam = false;
		objectParam = new Hashtable();
		objectParam = null;
		objectParam = null;
		objectParam = null;
		objectParam = null;
		objectParam = null;
		objectParam = null;
		_return_313 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void streamParam()
	{
	}

	internal static byte[] boolParam(object objectParam)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - ((Array)objectParam).Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(((Array)objectParam).Length + num / 8 + 8L);
		ulong num3 = (ulong)(((Array)objectParam).Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < ((Array)objectParam).Length; i++)
		{
			array2[i] = ((byte[])objectParam)[i];
		}
		array2[((Array)objectParam).Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFFL);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uintParam = 4023233417u;
		uint uintParam = 2562383102u;
		uint uintParam = 271733878u;
		for (uint num6 = _return_124; num6 < num5 / 16; num6++)
		{
			uint num7 = num6 << 6;
			for (uint num8 = _return_124; num8 < 61; num8 += 4)
			{
				array[num8 >> 2] = (uint)((array2[num7 + (num8 + 3)] << 24) | (array2[num7 + (num8 + 2)] << 16) | (array2[num7 + (num8 + _return_314)] << 8) | array2[num7 + num8]);
			}
			uint num9 = uint_;
			uint num10 = uintParam;
			uint num11 = uintParam;
			uint num12 = uintParam;
			objectParam(ref uint_, uintParam, uintParam, uintParam, _return_124, 7, 1u, array);
			objectParam(ref uintParam, uint_, uintParam, uintParam, 1u, 12, 2u, array);
			objectParam(ref uintParam, uintParam, uint_, uintParam, 2u, 17, 3u, array);
			objectParam(ref uintParam, uintParam, uintParam, uint_, 3u, 22, 4u, array);
			objectParam(ref uint_, uintParam, uintParam, uintParam, 4u, 7, 5u, array);
			objectParam(ref uintParam, uint_, uintParam, uintParam, 5u, 12, 6u, array);
			objectParam(ref uintParam, uintParam, uint_, uintParam, 6u, 17, 7u, array);
			objectParam(ref uintParam, uintParam, uintParam, uint_, 7u, 22, 8u, array);
			objectParam(ref uint_, uintParam, uintParam, uintParam, 8u, 7, 9u, array);
			objectParam(ref uintParam, uint_, uintParam, uintParam, 9u, 12, 10u, array);
			objectParam(ref uintParam, uintParam, uint_, uintParam, 10u, 17, 11u, array);
			objectParam(ref uintParam, uintParam, uintParam, uint_, 11u, 22, 12u, array);
			objectParam(ref uint_, uintParam, uintParam, uintParam, 12u, 7, 13u, array);
			objectParam(ref uintParam, uint_, uintParam, uintParam, 13u, 12, 14u, array);
			objectParam(ref uintParam, uintParam, uint_, uintParam, 14u, 17, 15u, array);
			objectParam(ref uintParam, uintParam, uintParam, uint_, 15u, 22, 16u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 1u, _return_125, 17u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 6u, 9, 18u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 11u, 14, 19u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, _return_124, 20, 20u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 5u, _return_125, 21u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 10u, 9, 22u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 15u, 14, 23u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 4u, 20, 24u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 9u, _return_125, 25u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 14u, 9, 26u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 3u, 14, 27u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 8u, 20, 28u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 13u, _return_125, 29u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 2u, 9, 30u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 7u, 14, 31u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 12u, 20, 32u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 5u, 4, 33u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 8u, 11, 34u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 11u, 16, 35u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 14u, 23, 36u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 1u, 4, 37u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 4u, 11, 38u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 7u, 16, 39u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 10u, 23, 40u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 13u, 4, 41u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, _return_124, 11, 42u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 3u, 16, 43u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 6u, 23, 44u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 9u, 4, 45u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 12u, 11, 46u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 15u, 16, 47u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 2u, 23, 48u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, _return_124, 6, 49u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 7u, 10, 50u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 14u, 15, 51u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 5u, 21, 52u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 12u, 6, 53u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 3u, 10, 54u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 10u, 15, 55u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 1u, 21, 56u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 8u, 6, 57u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 15u, 10, 58u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 6u, 15, 59u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 13u, 21, 60u, array);
			voidParam(ref uint_, uintParam, uintParam, uintParam, 4u, 6, 61u, array);
			voidParam(ref uintParam, uint_, uintParam, uintParam, 11u, 10, 62u, array);
			voidParam(ref uintParam, uintParam, uint_, uintParam, 2u, 15, 63u, array);
			voidParam(ref uintParam, uintParam, uintParam, uint_, 9u, 21, 64u, array);
			uint_ += num9;
			uintParam += num10;
			uintParam += num11;
			uintParam += num12;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uintParam), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uintParam), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uintParam), 0, array3, 12, 4);
		return array3;
	}

	private static void objectParam(ref uint uintParam, uint uintParam, uint uintParam, uint uintParam, uint uintParam, ushort ushortParam, uint uintParam, object objectParam)
	{
		uintParam = uintParam + uintParam(uintParam + ((uintParam & uintParam) | (~uintParam & uintParam)) + ((uint[])objectParam)[uintParam] + ((uint[])objectParam)[uintParam - _return_314], ushortParam);
	}

	private static void voidParam(ref uint uintParam, uint uintParam, uint uintParam, uint uintParam, uint uintParam, ushort ushortParam, uint uintParam, object objectParam)
	{
		uintParam = uintParam + uintParam(uintParam + ((uintParam & uintParam) | (uintParam & ~uintParam)) + ((uint[])objectParam)[uintParam] + ((uint[])objectParam)[uintParam - _return_314], ushortParam);
	}

	private static void voidParam(ref uint uintParam, uint uintParam, uint uintParam, uint uintParam, uint uintParam, ushort ushortParam, uint uintParam, object objectParam)
	{
		uintParam = uintParam + uintParam(uintParam + (uintParam ^ uintParam ^ uintParam) + ((uint[])objectParam)[uintParam] + ((uint[])objectParam)[uintParam - _return_314], ushortParam);
	}

	private static void voidParam(ref uint uintParam, uint uintParam, uint uintParam, uint uintParam, uint uintParam, ushort ushortParam, uint uintParam, object objectParam)
	{
		uintParam = uintParam + uintParam(uintParam + (uintParam ^ (uintParam | ~uintParam)) + ((uint[])objectParam)[uintParam] + ((uint[])objectParam)[uintParam - _return_314], ushortParam);
	}

	private static uint uintParam(uint uintParam, ushort ushortParam)
	{
		return (uintParam >> 32 - ushortParam) | (uintParam << (int)ushortParam);
	}

	internal static bool boolParam()
	{
		if (!boolParam)
		{
			voidParam();
			boolParam = true;
		}
		return boolParam;
	}

	internal GetInternal_14()
	{
	}

	private void voidParam(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		int num = byte_2.Length % 4;
		int num2 = byte_2.Length / 4;
		byte[] array = new byte[byte_2.Length];
		int num3 = byte_0.Length / 4;
		uint num4 = _return_124;
		uint num5 = _return_124;
		uint num6 = _return_124;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = _return_124;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((byte_0[num7 + 3] << 24) | (byte_0[num7 + 2] << 16) | (byte_0[num7 + _return_314] << 8) | byte_0[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - _return_314 && num > 0)
			{
				num6 = _return_124;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= byte_2[byte_2.Length - (_return_314 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((byte_2[num7 + 3] << 24) | (byte_2[num7 + 2] << 16) | (byte_2[num7 + _return_314] << 8) | byte_2[num7]);
			}
			uint num12 = num4;
			num4 = _return_124;
			uint num13 = 1257709153u;
			uint num14 = 807144328u;
			uint num15 = 1022397983u;
			uint num16 = num12;
			num13 = 165448209u;
			num14 = 696972267u;
			uint num17 = 1022397983u;
			num15 = 958800974u;
			if (num16 == 0)
			{
				num16--;
			}
			num17 = num13 / num16 + num16;
			num16 = num13 - num13 + num17 + num13;
			num16 ^= num16 << 7;
			num16 += num14;
			num16 ^= num16 >> _return_314;
			num16 += num15;
			num16 ^= num16 << 25;
			num16 += num16;
			num16 = (((num15 << 3) + num15) ^ num15) + num16;
			num4 = num12 + (uint)(double)num16;
			if (i == num2 - _return_314 && num > 0)
			{
				uint num18 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num18 & num10) >> num11);
				}
			}
			else
			{
				uint num19 = num4 ^ num6;
				array[num9] = (byte)(num19 & 0xFF);
				array[num9 + _return_314] = (byte)((num19 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num19 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num19 & 0xFF000000u) >> 24);
			}
		}
		objectParam = array;
	}

	internal static SymmetricAlgorithm symmetricalgorithmParam()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (boolParam())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new GetReturnNew_15();
		}
		catch
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3._return_125.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
			catch
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
	}

	internal static void voidParam()
	{
		try
		{
			new GetNew_16();
		}
		catch
		{
			boolParam = true;
			return;
		}
		try
		{
			boolParam = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] smethod_9(object objectParam)
	{
		if (!boolParam())
		{
			return new GetNew_16().ComputeHash((byte[])objectParam);
		}
		return boolParam(objectParam);
	}

	internal static void voidParam(object objectParam, object objectParam, uint uintParam, object objectParam)
	{
		while (uintParam != 0)
		{
			int num = ((uintParam > (uint)((Array)objectParam).Length) ? ((Array)objectParam).Length : ((int)uintParam));
			((Stream)objectParam).Read((byte[])objectParam, 0, num);
			voidParam(objectParam, objectParam, 0, num);
			uintParam -= (uint)num;
		}
	}

	internal static void voidParam(object objectParam, object objectParam, int intParam, int intParam)
	{
		((HashAlgorithm)objectParam).TransformBlock((byte[])objectParam, intParam, intParam, (byte[])objectParam, intParam);
	}

	internal static uint uintParam(uint uintParam, int intParam, long longParam, object objectParam)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < intParam)
			{
				((BinaryReader)objectParam).BaseStream.Position = longParam + (num * 40 + 8);
				uint num2 = ((BinaryReader)objectParam).ReadUInt32();
				num3 = ((BinaryReader)objectParam).ReadUInt32();
				((BinaryReader)objectParam).ReadUInt32();
				num4 = ((BinaryReader)objectParam).ReadUInt32();
				if (num3 <= uintParam && uintParam < num3 + num2)
				{
					break;
				}
				num++;
				continue;
			}
			return _return_124;
		}
		return num4 + uintParam - num3;
	}

	internal static void voidParam()
	{
		int num = 12;
		string objectParam = default(string);
		HashAlgorithm object_ = default(HashAlgorithm);
		int num9 = default(int);
		string text = default(string);
		int num11 = default(int);
		int num13 = default(int);
		int num15 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array4 = default(byte[]);
		long num18 = default(long);
		int num19 = default(int);
		long long_ = default(long);
		uint num20 = default(uint);
		uint num21 = default(uint);
		long num22 = default(long);
		int num24 = default(int);
		long num26 = default(long);
		uint num29 = default(uint);
		int num27 = default(int);
		byte[] array5 = default(byte[]);
		long num25 = default(long);
		uint num30 = default(uint);
		uint num28 = default(uint);
		uint num31 = default(uint);
		int num33 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
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
					case 20:
						objectParam = null;
						num3 = 3;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 2;
					case 2:
						try
						{
							object_ = (HashAlgorithm)objectParam();
							int num8 = 6;
							if (boolParam())
							{
								goto _goto_21;
							}
							goto _goto_17;
							_goto_21:
							objectParam = (string)objectParam("SHA1");
							num8 = 2;
							if (!boolParam())
							{
								goto _goto_19;
							}
							goto _goto_17;
							_goto_19:
							if (num9 != 992)
							{
								return;
							}
							num8 = num9;
							goto _goto_17;
							_goto_17:
							while (true)
							{
								switch (num8)
								{
								case 2:
									if (!boolParam(text))
									{
										return;
									}
									num8 = 6;
									if (objectParam() != null)
									{
										continue;
									}
									goto _goto_20;
								case _return_314:
									break;
								default:
									goto _goto_19;
								case 0:
								case 3:
									goto _goto_20;
								case 4:
									return;
								}
								break;
							}
							goto _goto_21;
							_goto_20:;
						}
						catch
						{
							int num10 = 0;
							if (!boolParam())
							{
								goto _goto_25;
							}
							goto _goto_24;
							_goto_25:
							if (num11 != 988)
							{
								return;
							}
							num10 = num11;
							goto _goto_24;
							_goto_24:
							switch (num10)
							{
							case 0:
								return;
							}
							goto _goto_25;
						}
						goto case 9;
					case 9:
						flag = false;
						num3 = _return_314;
						if (!boolParam())
						{
							continue;
						}
						goto case 10;
					case 10:
						try
						{
							GetPublic_6 objectParam = new GetPublic_6((Stream)objectParam(objectParam, "HjQMnGZVOF1u8DlLUXnh.GxgNIVZVhQyFGN838LL0"));
							voidParam(objectParam(objectParam), 0L);
							byte[] array = (byte[])objectParam(objectParam, (int)longParam(objectParam(objectParam)));
							byte[] array2 = new byte[32];
							array2[0] = 125;
							array2[0] = 84;
							array2[0] = 134;
							array2[0] = 92;
							array2[0] = 167;
							array2[_return_314] = 84;
							array2[_return_314] = 88;
							array2[_return_314] = 209;
							array2[2] = 125;
							array2[2] = 53;
							array2[2] = 130;
							array2[2] = 98;
							array2[2] = 121;
							array2[2] = 38;
							array2[3] = 90;
							array2[3] = 164;
							array2[3] = 19;
							array2[4] = 163;
							array2[4] = 43;
							array2[4] = 69;
							array2[4] = 25;
							array2[_return_125] = 96;
							array2[_return_125] = 121;
							array2[_return_125] = 183;
							array2[_return_125] = 171;
							array2[_return_125] = 130;
							array2[_return_125] = 41;
							array2[6] = 159;
							array2[6] = 79;
							array2[6] = 128;
							array2[7] = 146;
							array2[7] = 149;
							array2[7] = 137;
							array2[7] = 153;
							array2[7] = 183;
							array2[8] = 134;
							array2[8] = 166;
							array2[8] = 134;
							array2[8] = 96;
							array2[8] = 141;
							array2[9] = 148;
							array2[9] = 221;
							array2[9] = 193;
							array2[10] = 125;
							array2[10] = 146;
							array2[10] = 213;
							array2[11] = 90;
							array2[11] = 97;
							array2[11] = 101;
							array2[11] = 234;
							array2[11] = 84;
							array2[11] = 70;
							array2[12] = 104;
							array2[12] = 162;
							array2[12] = 92;
							array2[12] = 158;
							array2[12] = 77;
							array2[13] = 200;
							array2[13] = 57;
							array2[13] = 16;
							array2[13] = 130;
							array2[13] = 115;
							array2[14] = 164;
							array2[14] = 175;
							array2[14] = 108;
							array2[14] = 91;
							array2[14] = 218;
							array2[15] = 100;
							array2[15] = 67;
							array2[15] = 25;
							array2[16] = 153;
							array2[16] = 33;
							array2[16] = 119;
							array2[16] = 198;
							array2[17] = 88;
							array2[17] = 159;
							array2[17] = 156;
							array2[18] = 88;
							array2[18] = 89;
							array2[18] = 75;
							array2[18] = 103;
							array2[19] = 158;
							array2[19] = 39;
							array2[19] = 202;
							array2[20] = 97;
							array2[20] = 165;
							array2[20] = 156;
							array2[20] = 151;
							array2[21] = 154;
							array2[21] = 146;
							array2[21] = 14;
							array2[22] = 148;
							array2[22] = 90;
							array2[22] = _return_314;
							array2[23] = 114;
							array2[23] = 170;
							array2[23] = 155;
							array2[23] = 65;
							array2[24] = 168;
							array2[24] = 86;
							array2[24] = 128;
							array2[24] = 92;
							array2[24] = 92;
							array2[25] = 237;
							array2[25] = 208;
							array2[25] = 31;
							array2[25] = 153;
							array2[25] = 98;
							array2[26] = 111;
							array2[26] = 158;
							array2[26] = 130;
							array2[26] = 170;
							array2[27] = 105;
							array2[27] = 126;
							array2[27] = 146;
							array2[27] = 114;
							array2[27] = 141;
							array2[27] = 47;
							array2[28] = 162;
							array2[28] = 112;
							array2[28] = 111;
							array2[28] = 136;
							array2[28] = 186;
							array2[28] = 131;
							array2[29] = 82;
							array2[29] = 154;
							array2[29] = 92;
							array2[30] = 82;
							array2[30] = 103;
							array2[30] = 94;
							array2[30] = 247;
							array2[31] = 116;
							array2[31] = 118;
							array2[31] = 120;
							array2[31] = 216;
							array2[31] = 221;
							byte[] objectParam = array2;
							byte[] array3 = new byte[16];
							array3[0] = 116;
							array3[0] = 110;
							array3[0] = 107;
							array3[0] = 160;
							array3[0] = 132;
							array3[_return_314] = 146;
							array3[_return_314] = 145;
							array3[_return_314] = 36;
							array3[2] = 162;
							array3[2] = 165;
							array3[2] = 196;
							array3[2] = 240;
							array3[3] = 17;
							array3[3] = 104;
							array3[3] = 99;
							array3[3] = 135;
							array3[3] = 128;
							array3[3] = 78;
							array3[4] = 162;
							array3[4] = 165;
							array3[4] = 235;
							array3[_return_125] = 103;
							array3[_return_125] = 230;
							array3[_return_125] = 135;
							array3[6] = 112;
							array3[6] = 56;
							array3[6] = 94;
							array3[7] = 140;
							array3[7] = 100;
							array3[7] = 230;
							array3[7] = 147;
							array3[7] = 120;
							array3[8] = 122;
							array3[8] = 127;
							array3[8] = 31;
							array3[8] = 50;
							array3[9] = 82;
							array3[9] = 128;
							array3[9] = 165;
							array3[9] = 80;
							array3[9] = 68;
							array3[10] = 85;
							array3[10] = 118;
							array3[10] = 100;
							array3[10] = 123;
							array3[10] = 154;
							array3[10] = 248;
							array3[11] = 92;
							array3[11] = 114;
							array3[11] = 246;
							array3[12] = 126;
							array3[12] = 117;
							array3[12] = 230;
							array3[13] = 156;
							array3[13] = 104;
							array3[13] = 122;
							array3[13] = 87;
							array3[14] = 154;
							array3[14] = 139;
							array3[14] = 189;
							array3[14] = 197;
							array3[15] = 142;
							array3[15] = 134;
							array3[15] = 140;
							array3[15] = 111;
							array3[15] = 176;
							byte[] objectParam = array3;
							object objectParam = objectParam();
							voidParam(objectParam, CipherMode.CBC);
							ICryptoTransform transform = (ICryptoTransform)objectParam(objectParam, objectParam, objectParam);
							Stream stream = (Stream)objectParam();
							CryptoStream objectParam = new CryptoStream(stream, transform, CryptoStreamMode.Write);
							voidParam(objectParam, array, 0, array.Length);
							voidParam(objectParam);
							voidParam(objectParam, objectParam(objectParam(), objectParam(stream)));
							voidParam(stream);
							voidParam(objectParam);
							voidParam(objectParam);
							int num12 = 0;
							if (!boolParam())
							{
								goto _goto_31;
							}
							goto _goto_28;
							_goto_31:
							if (num13 == 988)
							{
								num12 = num13;
								goto _goto_28;
							}
							goto _goto_30;
							_goto_28:
							switch (num12)
							{
							case 0:
								goto _goto_30;
							}
							goto _goto_31;
							_goto_30:;
						}
						catch
						{
							int num14 = 0;
							if (objectParam() == null)
							{
								goto _goto_39;
							}
							goto _goto_34;
							_goto_39:
							flag = true;
							num14 = _return_314;
							if (objectParam() != null)
							{
								goto _goto_34;
							}
							goto _goto_35;
							_goto_34:
							while (true)
							{
								switch (num14)
								{
								case _return_314:
									break;
								default:
									if (num15 == 989)
									{
										goto _goto_36;
									}
									goto _goto_38;
								case 0:
									goto _goto_38;
								}
								goto _goto_39;
								_goto_36:
								num14 = num15;
								continue;
								_goto_38:
								break;
							}
							_goto_35:;
						}
						goto case 13;
					case _return_314:
						binaryReader = null;
						goto case 7;
					case 7:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num16 = 45;
							if (boolParam())
							{
								goto _goto_77;
							}
							goto _goto_101;
							_goto_77:
							binaryReader = new BinaryReader(fileStream);
							goto _goto_78;
							_goto_78:
							array4 = new byte[65536];
							goto _goto_73;
							_goto_73:
							voidParam(object_, fileStream, 152u, array4);
							goto _goto_74;
							_goto_74:
							bool num17 = ushortParam(binaryReader) != 523;
							int int_ = (num17 ? 96 : 112);
							voidParam(fileStream, 152L);
							intParam(fileStream, array4, 0, int_);
							array4[64] = 0;
							array4[65] = 0;
							array4[66] = 0;
							array4[67] = 0;
							voidParam(object_, array4, 0, int_);
							intParam(fileStream, array4, 0, 128);
							array4[32] = 0;
							array4[33] = 0;
							array4[34] = 0;
							array4[35] = 0;
							array4[36] = 0;
							array4[37] = 0;
							array4[38] = 0;
							array4[39] = 0;
							voidParam(object_, array4, 0, 128);
							num18 = longParam(fileStream);
							voidParam(fileStream, 134L);
							num19 = ushortParam(binaryReader);
							voidParam(fileStream, num18);
							voidParam(object_, fileStream, (uint)(num19 * 40), array4);
							long_ = longParam(fileStream);
							if (!num17)
							{
								goto _goto_68;
							}
							goto _goto_69;
							_goto_97:
							if (num20 < num21)
							{
								goto _goto_60;
							}
							num16 = 17;
							if (objectParam() == null)
							{
								goto _goto_91;
							}
							goto _goto_101;
							_goto_84:
							objectParam(object_, new byte[0], 0, 0);
							goto _goto_67;
							_goto_67:
							voidParam(fileStream, num22);
							int num23 = 23;
							goto _goto_75;
							_goto_68:
							voidParam(fileStream, 376L);
							num23 = 41;
							goto _goto_75;
							_goto_75:
							num24 = num23;
							goto _goto_96;
							_goto_96:
							num16 = num24;
							goto _goto_101;
							_goto_101:
							while (true)
							{
								switch (num16)
								{
								case 41:
								case 43:
									break;
								case 10:
									goto _goto_94;
								case 25:
									goto _goto_98;
								case _return_314:
									goto _goto_100;
								case 4:
									goto _goto_86;
								case 28:
									goto _goto_97;
								case 18:
									goto _goto_60;
								case 32:
									goto _goto_93;
								case 27:
									goto _goto_90;
								case 6:
								case 14:
								case 38:
									goto _goto_91;
								case 24:
								case 40:
									goto _goto_85;
								case 21:
								case 34:
								case 36:
									goto _goto_92;
								case _return_125:
									goto _goto_84;
								case 16:
									goto _goto_67;
								case 19:
								case 42:
									goto _goto_68;
								case 39:
									goto _goto_69;
								case 37:
									num26 = num22 + num29;
									goto case 33;
								case 33:
									voidParam(fileStream, long_);
									num16 = 30;
									if (objectParam() != null)
									{
										continue;
									}
									goto case 7;
								case 7:
									num27 = 0;
									num16 = 24;
									if (boolParam())
									{
										continue;
									}
									goto case 29;
								case 29:
									voidParam(array5);
									num16 = 24;
									if (objectParam() != null)
									{
										continue;
									}
									goto case 9;
								case 9:
									flag = !boolParam(objectParam, objectParam(object_), objectParam, array5);
									num23 = 26;
									goto _goto_75;
								case 30:
								case 35:
									if (num25 >= num26)
									{
										num16 = 0;
										if (boolParam())
										{
											continue;
										}
										goto _goto_85;
									}
									goto case 13;
								case 13:
									num30 = (uint)longParam(num22 - num25, num21);
									goto case 8;
								case 8:
									voidParam(object_, fileStream, num30, array4);
									goto case 22;
								case 22:
									num21 -= num30;
									num16 = 34;
									if (boolParam())
									{
										continue;
									}
									goto _goto_93;
								case 31:
									goto _goto_73;
								case 2:
									goto _goto_74;
								case 23:
									array5 = (byte[])objectParam(binaryReader, (int)num29);
									num16 = 9;
									if (objectParam() != null)
									{
										continue;
									}
									goto case 29;
								case 20:
									if (num22 <= num25)
									{
										num23 = 51;
										goto _goto_75;
									}
									goto case 30;
								case 17:
								{
									uint uint_ = uintParam(binaryReader);
									num29 = uintParam(binaryReader);
									num22 = uintParam(uint_, num19, num18, binaryReader);
									num16 = 37;
									if (boolParam())
									{
										continue;
									}
									goto case 20;
								}
								case 15:
									num28 = uintParam(binaryReader);
									num16 = 23;
									if (!boolParam())
									{
										continue;
									}
									goto _goto_98;
								case 12:
									num21 = uintParam(binaryReader);
									goto case 15;
								case 11:
									goto _goto_77;
								case 3:
									goto _goto_78;
								case 0:
									voidParam(object_, fileStream, num21, array4);
									num16 = 14;
									if (objectParam() == null)
									{
										continue;
									}
									goto case 33;
								default:
									if (num24 == 51)
									{
										if (num25 < num26)
										{
											goto _goto_86;
										}
										goto case 30;
									}
									goto _goto_80;
								case 26:
									goto _goto_81;
								}
								break;
							}
							goto _goto_102;
							_goto_85:
							if (num27 < num19)
							{
								goto _goto_100;
							}
							goto _goto_84;
							_goto_91:
							num27++;
							goto _goto_85;
							_goto_100:
							voidParam(fileStream, num18 + num27 * 40 + 16L);
							num16 = 12;
							if (!boolParam())
							{
								goto _goto_86;
							}
							goto _goto_101;
							_goto_90:
							num25 = longParam(fileStream);
							num16 = 20;
							if (!boolParam())
							{
								goto _goto_92;
							}
							goto _goto_101;
							_goto_92:
							if (num21 != 0)
							{
								goto _goto_90;
							}
							goto _goto_91;
							_goto_93:
							voidParam(fileStream, longParam(fileStream) + num20);
							goto _goto_92;
							_goto_60:
							num21 -= num20;
							goto _goto_93;
							_goto_102:
							num31 = uintParam(uintParam(binaryReader), num19, num18, binaryReader);
							goto _goto_94;
							_goto_80:
							if (num24 != 1031)
							{
								goto _goto_102;
							}
							goto _goto_96;
							_goto_86:
							num20 = (uint)(num26 - num25);
							goto _goto_97;
							_goto_94:
							voidParam(fileStream, num31 + 32);
							num16 = 17;
							if (objectParam() != null)
							{
								goto _goto_98;
							}
							goto _goto_101;
							_goto_98:
							voidParam(fileStream, num28);
							num16 = 21;
							if (objectParam() != null)
							{
								goto _goto_100;
							}
							goto _goto_101;
							_goto_69:
							voidParam(fileStream, 360L);
							goto _goto_102;
							_goto_81:;
						}
						catch
						{
							int num32 = _return_125;
							if (boolParam())
							{
								goto _goto_109;
							}
							goto _goto_108;
							_goto_109:
							flag = true;
							num32 = 0;
							if (!boolParam())
							{
								goto _goto_111;
							}
							goto _goto_108;
							_goto_111:
							if (num33 != 989)
							{
								goto _goto_109;
							}
							num32 = num33;
							goto _goto_108;
							_goto_108:
							switch (num32)
							{
							case _return_314:
								goto _goto_109;
							case 0:
								goto _goto_110;
							}
							goto _goto_111;
							_goto_110:;
						}
						goto case _return_125;
					case _return_125:
					case 16:
						try
						{
							if (binaryReader != null)
							{
								goto _goto_120;
							}
							int num4 = 8;
							if (!boolParam())
							{
								goto _goto_121;
							}
							goto _goto_118;
							_goto_120:
							voidParam(binaryReader);
							num4 = 0;
							if (objectParam() != null)
							{
								goto _goto_119;
							}
							goto _goto_121;
							_goto_121:
							switch (num4)
							{
							case 2:
								goto _goto_120;
							case 0:
							case _return_314:
								goto _goto_118;
							}
							goto _goto_119;
							_goto_119:
							if (num5 != 990)
							{
								goto _goto_120;
							}
							num4 = num5;
							goto _goto_121;
							_goto_118:;
						}
						catch
						{
							int num6 = 3;
							if (objectParam() != null)
							{
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 != 988)
										{
											break;
										}
										num6 = num7;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 4;
					case 18:
						if (intParam(text) != 0)
						{
							object_ = null;
							goto case 20;
						}
						return;
					case 12:
						if (objectParam == null)
						{
							num3 = 11;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 11;
						}
						return;
					case 11:
						voidParam();
						num3 = 27;
						if (objectParam() != null)
						{
							continue;
						}
						break;
					case 8:
						if (text != null)
						{
							num3 = 18;
							if (!boolParam())
							{
								continue;
							}
							goto case 18;
						}
						return;
					case 0:
						text = (string)objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly);
						goto case 8;
					default:
						if (num2 != 27)
						{
							if (num2 == 1008)
							{
								goto _goto_251;
							}
							goto case 18;
						}
						objectParam = new RSACryptoServiceProvider();
						num3 = 9;
						if (!boolParam())
						{
							continue;
						}
						goto case 0;
					case 13:
						if (!flag)
						{
							goto case _return_314;
						}
						goto case 4;
					case 4:
					case 14:
						if (!flag)
						{
							num3 = 19;
							if (boolParam())
							{
								continue;
							}
							goto case 18;
						}
						goto case 15;
					case 3:
						break;
					case 19:
						flag = false;
						return;
					case 17:
						return;
					case 15:
						throw new Exception((string)objectParam(objectParam(objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly)), " is tampered."));
					case 6:
						return;
					}
					goto _goto_312;
					continue;
					_goto_251:
					break;
				}
				continue;
				_goto_312:
				break;
			}
			voidParam(boolParam: true);
			num = 17;
			if (objectParam() == null)
			{
				num = 27;
			}
		}
	}

	public static void voidParam(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (intParam == null)
			{
				lock (objectParam)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(AppClass_968.boolParam(33555523)).Assembly.GetManifestResourceStream("WinAtEZVFEcaZJ0jELWC.Ecf8kaZVGfufnALiVALx"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = _return_124;
						uint num4 = _return_124;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = _return_124;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - _return_314 && num > 0)
							{
								num4 = _return_124;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (_return_314 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + _return_314] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = 1257709153u;
							uint num12 = 807144328u;
							uint num13 = 1022397983u;
							uint num14 = num10;
							num11 = 165448209u;
							num12 = 696972267u;
							uint num15 = 1022397983u;
							num13 = 958800974u;
							if (num14 == 0)
							{
								num14--;
							}
							num15 = num11 / num14 + num14;
							num14 = num11 - num11 + num15 + num11;
							num14 ^= num14 << 7;
							num14 += num12;
							num14 ^= num14 >> _return_314;
							num14 += num13;
							num14 ^= num14 << 25;
							num14 += num14;
							num14 = (((num13 << 3) + num13) ^ num13) + num14;
							num3 = num9 + (uint)(double)num14;
							if (i == num2 - _return_314 && num > 0)
							{
								uint num16 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num16 & num7) >> num8);
								}
							}
							else
							{
								uint num17 = num3 ^ num4;
								array2[num6] = (byte)(num17 & 0xFF);
								array2[num6 + _return_314] = (byte)((num17 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num17 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num17 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num18 = array.Length / 8;
						GetPublic_6 @class = new GetPublic_6(new MemoryStream(array));
						for (int l = 0; l < num18; l++)
						{
							int key = @class.intParam();
							int value = @class.intParam();
							dictionary.Add(key, value);
						}
						@class.voidParam();
					}
					intParam = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num19 = intParam[metadataToken];
					bool flag = (num19 & 0x40000000) > 0;
					num19 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(AppClass_968.boolParam(33555523)).Module.ResolveMethod(num19, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num20 = parameters.Length + _return_314;
					Type[] array3 = new Type[num20];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = Type.GetTypeFromHandle(AppClass_968.boolParam(16777236));
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + _return_314] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num21 = 0; num21 < num20; num21++)
					{
						switch (num21)
						{
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num21);
							break;
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case _return_314:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
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

	internal static void voidParam()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	private static void voidParam(object objectParam, int intParam)
	{
		AppClass_972.voidParam(0, new object[2] { objectParam, intParam }, null);
	}

	internal static string stringParam(int intParam)
	{
		if (((Array)objectParam).Length == 0)
		{
			_listString_9 = new List<string>();
			_listInt_11 = new List<int>();
			voidParam(((Assembly)objectParam).GetManifestResourceStream("XstAdrZVwWH8dJ0kNJ9t.WVdniYZV8e41O0qAYCZD"), intParam);
		}
		if (intParam < 75)
		{
			MethodBase method = new StackFrame(_return_314).GetMethod();
			if ((Assembly)objectParam != method.DeclaringType.Assembly)
			{
				bool flag = false;
				string name = method.DeclaringType.Assembly.GetName().Name;
				AssemblyName[] referencedAssemblies = ((Assembly)objectParam).GetReferencedAssemblies();
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
			intParam++;
		}
		lock (objectParam)
		{
			int num = BitConverter.ToInt32((byte[])objectParam, intParam);
			if (num < _listInt_11.Count && _listInt_11[num] == intParam)
			{
				return _listString_9[num];
			}
			try
			{
				AppClass_967.boolParam();
				byte[] array = new byte[num];
				Array.Copy((Array)objectParam, intParam + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				_listString_9.Add(text);
				_listInt_11.Add(intParam);
				Array.Copy(BitConverter.GetBytes(_listString_9.Count - _return_314), 0, (Array)objectParam, intParam, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string stringParam(object objectParam)
	{
		"cYg9Y5E6CmPLzgcvSRWqyd".Trim();
		byte[] array = Convert.FromBase64String((string)objectParam);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	internal static uint uintParam(IntPtr intptrParam, IntPtr _intptr_126, IntPtr intptrParam, uint uintParam, IntPtr intptrParam, ref uint uintParam)
	{
		IntPtr ptr = intptrParam;
		if (boolParam)
		{
			ptr = _intptr_126;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = ((Hashtable)objectParam)[(object)num];
		if (obj != null)
		{
			AppStruct_964 @struct = (AppStruct_964)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
			Marshal.Copy(@struct.byte_0, 0, intPtr, @struct.byte_0.Length);
			if (@struct.boolParam)
			{
				intptrParam = intPtr;
				uintParam = (uint)@struct.byte_0.Length;
				intParam(intptrParam, @struct.byte_0.Length, 64, ref intParam);
				return _return_124;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, @struct.byte_0.Length);
			uint result = _return_124;
			if (uintParam == 216669565 && !boolParam)
			{
				boolParam = true;
			}
			else
			{
				result = objectParam(intptrParam, _intptr_126, intptrParam, uintParam, intptrParam, ref uintParam);
				Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, IntPtr.Zero);
			}
			return result;
		}
		return objectParam(intptrParam, _intptr_126, intptrParam, uintParam, intptrParam, ref uintParam);
	}

	private static int intParam()
	{
		return _return_125;
	}

	private static void voidParam()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate delegateParam(IntPtr intptrParam, Type typeParam)
	{
		return (Delegate)Type.GetTypeFromHandle(AppClass_968.boolParam(16777828)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(AppClass_968.boolParam(16777253)),
			Type.GetTypeFromHandle(AppClass_968.boolParam(16777257))
		}).Invoke(null, new object[2] { intptrParam, typeParam });
	}

	internal unsafe static void voidParam()
	{
		int num = 155;
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		byte[] array5 = default(byte[]);
		int num5 = default(int);
		IntPtr intptrParam = default(IntPtr);
		int num20 = default(int);
		uint num88 = default(uint);
		uint num33 = default(uint);
		uint num49 = default(uint);
		int num89 = default(int);
		int num53 = default(int);
		uint num7 = default(uint);
		IntPtr intPtr = default(IntPtr);
		IntPtr _intptr_10 = default(IntPtr);
		byte[] array12 = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array4 = default(byte[]);
		IntPtr intPtr3 = default(IntPtr);
		byte[] array10 = default(byte[]);
		long num16 = default(long);
		byte[] array8 = default(byte[]);
		byte[] array9 = default(byte[]);
		int num14 = default(int);
		int num18 = default(int);
		int num50 = default(int);
		byte[] array13 = default(byte[]);
		int num46 = default(int);
		int num21 = default(int);
		uint num52 = default(uint);
		byte[] array11 = default(byte[]);
		Process objectParam = default(Process);
		IEnumerator enumerator = default(IEnumerator);
		int num70 = default(int);
		int num72 = default(int);
		ProcessModule objectParam = default(ProcessModule);
		string text = default(string);
		int num77 = default(int);
		int num79 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int int_ = default(int);
		int num47 = default(int);
		GetPublic_6 objectParam = default(GetPublic_6);
		int num30 = default(int);
		string string_ = default(string);
		AppStruct_964 struct2 = default(AppStruct_964);
		bool flag = default(bool);
		long num45 = default(long);
		int num57 = default(int);
		byte* ptr = default(byte*);
		int num56 = default(int);
		int num55 = default(int);
		byte[] array19 = default(byte[]);
		IntPtr intPtr4 = default(IntPtr);
		byte[] array = default(byte[]);
		byte[] array15 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num67 = default(int);
		IntPtr intptrParam = default(IntPtr);
		int num68 = default(int);
		long num19 = default(long);
		uint num48 = default(uint);
		int num6 = default(int);
		int num54 = default(int);
		IntPtr intptr_ = default(IntPtr);
		int num31 = default(int);
		uint num34 = default(uint);
		long value = default(long);
		int num4 = default(int);
		int intParam = default(int);
		int num17 = default(int);
		int num51 = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		CryptoStream objectParam = default(CryptoStream);
		byte[] array14 = default(byte[]);
		IntPtr _intptr_8 = default(IntPtr);
		AppStruct_964 @struct = default(AppStruct_964);
		int num36 = default(int);
		MemoryStream objectParam = default(MemoryStream);
		uint uint_ = default(uint);
		byte[] array17 = default(byte[]);
		byte* value2 = default(byte*);
		int num39 = default(int);
		int num42 = default(int);
		int num44 = default(int);
		int num32 = default(int);
		int num23 = default(int);
		int num25 = default(int);
		int num27 = default(int);
		int num29 = default(int);
		byte[] byte_ = default(byte[]);
		int intParam = default(int);
		uint num15 = default(uint);
		int num10 = default(int);
		Version objectParam = default(Version);
		Version objectParam = default(Version);
		Version objectParam = default(Version);
		int num13 = default(int);
		int num81 = default(int);
		int num83 = default(int);
		int num85 = default(int);
		int num87 = default(int);
		int num66 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					IntPtr _intptr_126;
					switch (num3)
					{
					case 654:
						array3[_return_125] = 69;
						num3 = 303;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 35;
					case 35:
						array3[6] = 150;
						num3 = 415;
						if (boolParam())
						{
							continue;
						}
						goto case 174;
					case 174:
						num8 = 152;
						num3 = 621;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 0;
					case 0:
						array5[20] = (byte)num8;
						goto case 381;
					case 381:
						num8 = 175;
						num3 = 193;
						if (boolParam())
						{
							continue;
						}
						goto case 3;
					case 653:
						array3[10] = 170;
						num3 = 389;
						if (!boolParam())
						{
							continue;
						}
						goto case 67;
					case 67:
						array3[10] = 155;
						goto case 33;
					case 33:
						num5 = 69;
						goto case 292;
					case 292:
						array3[10] = (byte)num5;
						num3 = 647;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 384;
					case 384:
						intptrParam = IntPtr.Zero;
						goto case 159;
					case 159:
						intptrParam = intptrParam(56u, _return_314, (uint)intParam(objectParam()));
						goto case 639;
					case 639:
						if (intParam() == 4)
						{
							num3 = 39;
							if (boolParam())
							{
								continue;
							}
							goto case 329;
						}
						goto case 185;
					case 329:
						num8 = 166;
						goto case 378;
					case 378:
						array5[14] = (byte)num8;
						num3 = 100;
						if (!boolParam())
						{
							continue;
						}
						goto case 244;
					case 244:
						array5[14] = 94;
						goto case 66;
					case 66:
						array5[14] = 162;
						goto case 568;
					case 568:
						array5[15] = 154;
						goto case 135;
					case 135:
						array5[15] = 108;
						goto case 356;
					case 356:
						num8 = 98;
						goto case 463;
					case 463:
						array5[15] = (byte)num8;
						num3 = 98;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 241;
					case 241:
						array5[15] = 101;
						goto case 117;
					case 117:
						num8 = 180;
						goto case 405;
					case 405:
						array5[16] = (byte)num8;
						goto case 267;
					case 267:
						num8 = 24;
						goto case 561;
					case 561:
						array5[16] = (byte)num8;
						num3 = 601;
						if (boolParam())
						{
							continue;
						}
						goto case 403;
					case 403:
						if (num20 > 0)
						{
							goto case 80;
						}
						goto case 231;
					case 80:
						num88 = num33 ^ num49;
						num3 = 57;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 473;
					case 473:
						num89 = 0;
						goto case 20;
					case 20:
					case 263:
						if (num89 >= num20)
						{
							num3 = 627;
							if (objectParam() != null)
							{
								continue;
							}
							goto case 476;
						}
						goto case 452;
					case 476:
					case 534:
						num53++;
						goto case 203;
					case 452:
						if (num89 > 0)
						{
							goto case 306;
						}
						goto case 417;
					case 306:
						num7 <<= 8;
						num3 = 493;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 39;
					case 39:
						intPtr = intptrParam(((object[])objectParam(GetInternal_14.objectParam))[0]);
						num3 = 103;
						if (boolParam())
						{
							continue;
						}
						goto case 220;
					case 220:
						if (!boolParam(_intptr_10, IntPtr.Zero))
						{
							goto case 46;
						}
						goto case 129;
					case 46:
					case 285:
						array12 = new byte[6];
						goto case 183;
					case 183:
						array12[0] = 103;
						goto case 8;
					case 8:
						array12[_return_314] = 101;
						goto case 611;
					case 611:
						array12[2] = 116;
						num3 = 388;
						if (boolParam())
						{
							continue;
						}
						goto case 62;
					case 62:
						array2 = (byte[])objectParam(_intptr_4.ToInt64());
						num3 = 368;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 649;
					case 649:
						array4 = (byte[])objectParam(intPtr3.ToInt64());
						goto case 23;
					case 23:
						array10 = (byte[])objectParam(num16);
						num3 = 282;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 361;
					case 361:
						array5[2] = 91;
						num3 = 486;
						if (boolParam())
						{
							continue;
						}
						goto case 589;
					case 589:
						num16 = 0L;
						num3 = 69;
						if (boolParam())
						{
							continue;
						}
						goto case 2;
					case 129:
						array8 = new byte[10];
						goto case 420;
					case 420:
						array8[0] = 99;
						goto case 169;
					case 169:
						array8[_return_314] = 108;
						num3 = 152;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 594;
					case 594:
						array8[2] = 114;
						num3 = 181;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 352;
					case 352:
						num3 = 411;
						if (boolParam())
						{
							continue;
						}
						goto case 343;
					case 343:
						array3[4] = (byte)num5;
						goto case 15;
					case 15:
						array3[4] = 61;
						goto case 213;
					case 213:
						num5 = 134;
						num3 = 141;
						if (!boolParam())
						{
							continue;
						}
						goto case 323;
					case 417:
						array9[num14 + num89] = (byte)((num88 & num7) >> num18);
						goto case 501;
					case 501:
						num89++;
						num3 = 20;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 38;
					case 38:
						if (num50 > 0)
						{
							goto case 351;
						}
						goto case 207;
					case 351:
						num49 <<= 8;
						num3 = 581;
						if (!boolParam())
						{
							continue;
						}
						goto case 207;
					case 207:
						num49 |= array13[array13.Length - (_return_314 + num50)];
						goto case 575;
					case 575:
						num50++;
						num3 = 515;
						if (boolParam())
						{
							continue;
						}
						goto case 335;
					case 335:
						array5[10] = (byte)num8;
						goto case 115;
					case 115:
						num8 = 156;
						goto case 623;
					case 623:
						array5[10] = (byte)num8;
						goto case 170;
					case 170:
						num8 = 116;
						goto case 626;
					case 626:
						array5[10] = (byte)num8;
						num3 = 651;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 223;
					case 185:
						intPtr = intptrParam(((object[])objectParam(GetInternal_14.objectParam))[0]);
						goto case 94;
					case 94:
						_long_7 = intPtr.ToInt64();
						goto case 349;
					case 349:
						_intptr_126 = IntPtr.Zero;
						goto case 548;
					case 548:
						num46 = 0;
						num3 = 430;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 624;
					case 624:
						num49 = _return_124;
						goto case 156;
					case 156:
						if (num20 > 0)
						{
							goto case 72;
						}
						goto case 619;
					case 72:
						num21++;
						goto case 619;
					case 619:
						num52 = _return_124;
						num3 = 309;
						if (!boolParam())
						{
							continue;
						}
						goto case 478;
					case 478:
						num53 = 0;
						goto case 203;
					case 203:
					case 259:
						if (num53 >= num21)
						{
							num3 = 214;
							if (!boolParam())
							{
								continue;
							}
							goto case 194;
						}
						goto case 141;
					case 194:
						array11 = array9;
						num3 = 592;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 231;
					case 652:
						array5[17] = 87;
						goto case 402;
					case 402:
						array5[17] = 182;
						num3 = 429;
						if (boolParam())
						{
							continue;
						}
						goto case 252;
					case 252:
						array5[21] = 119;
						goto case 48;
					case 48:
						num8 = 119;
						num3 = 89;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 410;
					case 410:
						array5[21] = (byte)num8;
						goto case 256;
					case 256:
						array5[22] = 113;
						num3 = 305;
						if (boolParam())
						{
							continue;
						}
						goto case 83;
					case 83:
						array5[16] = (byte)num8;
						goto case 536;
					case 536:
						array5[17] = 125;
						num3 = 15;
						if (!boolParam())
						{
							continue;
						}
						goto case 546;
					case 651:
						array8[8] = 108;
						goto case 482;
					case 482:
						array8[9] = 108;
						num3 = 198;
						if (boolParam())
						{
							continue;
						}
						goto case 381;
					case 650:
						array5[7] = (byte)num8;
						goto case 562;
					case 562:
						array5[7] = 168;
						num3 = 344;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 184;
					case 184:
						array5[19] = 163;
						num3 = 580;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 262;
					case 262:
						num8 = 142;
						num3 = 95;
						if (!boolParam())
						{
							continue;
						}
						goto case 319;
					case 319:
						array5[19] = (byte)num8;
						num3 = 501;
						if (!boolParam())
						{
							continue;
						}
						goto case 456;
					case 456:
						array5[19] = 132;
						num3 = 583;
						if (boolParam())
						{
							continue;
						}
						goto case 367;
					case 367:
						array3[9] = (byte)num5;
						num3 = 541;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 229;
					case 229:
					case 617:
						objectParam = (Process)objectParam();
						num3 = 534;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 591;
					case 591:
						try
						{
							enumerator = (IEnumerator)objectParam(objectParam(objectParam));
							int num69 = 7;
							if (objectParam() == null)
							{
								goto _goto_131;
							}
							while (true)
							{
								switch (num69)
								{
								default:
									if (num70 == 989)
									{
										goto _goto_128;
									}
									goto _goto_130;
								case _return_314:
									break;
								case 0:
									goto _goto_130;
								}
								goto _goto_131;
								_goto_128:
								num69 = num70;
								continue;
								_goto_130:
								break;
							}
							goto _goto_132;
							_goto_131:
							try
							{
								while (true)
								{
									int num71;
									if (!boolParam(enumerator))
									{
										num71 = 0;
										if (objectParam() != null)
										{
											goto _goto_149;
										}
										goto _goto_145;
									}
									goto _goto_153;
									_goto_150:
									if (num72 == 16 || num72 != 996)
									{
										continue;
									}
									goto _goto_147;
									_goto_153:
									objectParam = (ProcessModule)objectParam(enumerator);
									goto _goto_152;
									_goto_152:
									if (boolParam(objectParam(objectParam), text))
									{
										goto _goto_155;
									}
									int num73 = _return_125;
									if (boolParam())
									{
										num73 = 16;
									}
									goto _goto_141;
									_goto_147:
									num71 = num72;
									goto _goto_145;
									_goto_149:
									voidParam();
									num73 = 7;
									goto _goto_141;
									_goto_155:
									long num74 = num16;
									intPtr = intptrParam(objectParam);
									if (num74 < intPtr.ToInt64())
									{
										goto _goto_148;
									}
									goto _goto_151;
									_goto_151:
									long num75 = num16;
									intPtr = intptrParam(objectParam);
									if (num75 <= intPtr.ToInt64() + intParam(objectParam))
									{
										continue;
									}
									goto _goto_148;
									_goto_148:
									if (!boolParam(objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly), null))
									{
										continue;
									}
									num71 = _return_125;
									if (boolParam())
									{
										goto _goto_145;
									}
									goto _goto_153;
									_goto_141:
									num72 = num73;
									goto _goto_147;
									_goto_145:
									switch (num71)
									{
									case 4:
										break;
									case 8:
										goto _goto_148;
									case _return_125:
										goto _goto_149;
									default:
										goto _goto_150;
									case 2:
										goto _goto_151;
									case 6:
										goto _goto_152;
									case _return_314:
										goto _goto_153;
									case 3:
										continue;
									case 0:
										goto _goto_154;
									case 7:
										return;
									}
									goto _goto_155;
									continue;
									_goto_154:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								int num76 = _return_314;
								if (boolParam())
								{
									goto _goto_161;
								}
								goto _goto_167;
								_goto_161:
								if (disposable != null)
								{
									goto _goto_164;
								}
								num76 = 0;
								if (objectParam() != null)
								{
									goto _goto_162;
								}
								goto _goto_167;
								_goto_167:
								switch (num76)
								{
								case 3:
									break;
								case 2:
									goto _goto_161;
								default:
									goto _goto_162;
								case 0:
								case _return_314:
									goto _goto_166;
								}
								goto _goto_164;
								_goto_162:
								if (num77 == 991)
								{
									num76 = num77;
									goto _goto_167;
								}
								goto _goto_166;
								_goto_164:
								voidParam(disposable);
								num76 = 8;
								if (!boolParam())
								{
									goto _goto_167;
								}
								_goto_166:;
							}
							_goto_132:;
						}
						catch
						{
							int num78 = _return_314;
							if (!boolParam())
							{
								while (true)
								{
									switch (num78)
									{
									default:
										if (num79 != 988)
										{
											break;
										}
										num78 = num79;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 300;
					case 647:
						num5 = 38;
						goto case 368;
					case 368:
						array3[11] = (byte)num5;
						num3 = 538;
						if (boolParam())
						{
							continue;
						}
						goto case 59;
					case 59:
						num8 = 240;
						goto case 516;
					case 516:
						array5[11] = (byte)num8;
						num3 = 487;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 614;
					case 614:
						array5[12] = 187;
						goto case 49;
					case 49:
						num8 = 215;
						num3 = 213;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 483;
					case 483:
						array5[12] = (byte)num8;
						num3 = 312;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 450;
					case 14:
					case 646:
						intParam(intPtr2, 4, int_, ref int_);
						goto case 26;
					case 26:
						num46++;
						goto case 430;
					case 430:
					case 431:
						if (num46 >= num47)
						{
							goto case 301;
						}
						goto case 484;
					case 301:
					case 576:
						if (longParam(objectParam(objectParam)) < longParam(objectParam(objectParam)) - 1L)
						{
							goto case 290;
						}
						goto case 242;
					case 290:
						num30 = intParam(objectParam);
						num3 = 385;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 267;
					case 242:
						intParam(intptrParam);
						goto case 362;
					case 362:
						voidParam();
						num3 = 556;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 468;
					case 468:
						array12[_return_125] = 116;
						num3 = 448;
						if (!boolParam())
						{
							continue;
						}
						goto case 86;
					case 86:
						string_ = (string)objectParam(objectParam(), array12);
						num3 = 475;
						if (boolParam())
						{
							continue;
						}
						goto case 133;
					case 133:
						num5 = 84;
						num3 = 101;
						if (boolParam())
						{
							continue;
						}
						goto case 233;
					case 233:
						struct2.boolParam = flag;
						goto case 34;
					case 34:
						voidParam(objectParam, num45 + num57, struct2);
						goto case 462;
					case 462:
					case 547:
						if (longParam(objectParam(objectParam)) < longParam(objectParam(objectParam)) - 1L)
						{
							num3 = 128;
							if (boolParam())
							{
								continue;
							}
							goto case 276;
						}
						goto case 427;
					case 276:
						array3[11] = 117;
						goto case 488;
					case 488:
						array3[12] = 98;
						goto case 495;
					case 495:
						array3[12] = 167;
						num3 = 316;
						if (!boolParam())
						{
							continue;
						}
						goto case 110;
					case 110:
						array3[12] = 111;
						num3 = 328;
						if (!boolParam())
						{
							continue;
						}
						goto case 114;
					case 427:
						intPtr = intptrParam(((object[])objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly))[0]);
						goto case 551;
					case 551:
						_long_5 = intPtr.ToInt64();
						num3 = 234;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 151;
					case 151:
						if (intParam() == 4)
						{
							num3 = 583;
							if (objectParam() != null)
							{
								continue;
							}
							goto case 640;
						}
						goto case 93;
					case 645:
						array3[8] = 204;
						goto case 597;
					case 597:
						array3[8] = 58;
						num3 = 150;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 78;
					case 78:
						array5[8] = (byte)num8;
						num3 = 22;
						if (boolParam())
						{
							continue;
						}
						goto case 116;
					case 297:
						*(long*)(ptr + num56 * 8) ^= 1474535308L;
						goto case 118;
					case 118:
						num56++;
						goto case 116;
					case 116:
					case 613:
						if (num56 < num55)
						{
							goto case 297;
						}
						goto case 163;
					case 163:
						array18 = null;
						num3 = 157;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 108;
					case 644:
					{
						byte[] array22 = new byte[40];
						voidParam(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array19 = array22;
						goto case 160;
					}
					case 160:
					case 277:
						intPtr4 = intptrParam(IntPtr.Zero, (uint)array19.Length, 4096u, 64u);
						goto case 355;
					case 355:
						array = array19;
						num3 = 389;
						if (!boolParam())
						{
							continue;
						}
						goto case 471;
					case 471:
						array4 = null;
						goto case 528;
					case 528:
						array10 = null;
						num3 = 629;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 168;
					case 168:
						array15 = array5;
						goto case 147;
					case 147:
						array3 = new byte[16];
						num3 = 226;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 509;
					case 509:
						num8 = 127;
						num3 = 332;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 390;
					case 390:
						array3[7] = 182;
						goto case 593;
					case 593:
						num5 = 226;
						goto case 140;
					case 140:
						array3[7] = (byte)num5;
						goto case 424;
					case 424:
						num5 = 137;
						goto case 357;
					case 357:
						array3[8] = (byte)num5;
						num3 = 209;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 648;
					case 642:
						array5[31] = 120;
						num3 = 585;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 192;
					case 192:
						num8 = 143;
						goto case 359;
					case 359:
						array5[31] = (byte)num8;
						goto case 168;
					case 641:
						if (intParam() == 4)
						{
							num3 = 314;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 448;
						}
						goto case 325;
					case 448:
						array5[31] = (byte)num8;
						num3 = 435;
						if (!boolParam())
						{
							continue;
						}
						goto case 345;
					case 637:
						array7 = (byte[])objectParam(objectParam(GetInternal_14.objectParam));
						goto case 529;
					case 529:
						if (array7 != null)
						{
							num3 = 15;
							if (objectParam() != null)
							{
								continue;
							}
							goto case 206;
						}
						goto case 16;
					case 206:
						if (array7.Length != 0)
						{
							goto case 50;
						}
						goto case 16;
					case 50:
						array6[_return_314] = array7[0];
						goto case 347;
					case 347:
						array6[3] = array7[_return_314];
						num3 = 175;
						if (!boolParam())
						{
							continue;
						}
						goto case 61;
					case 636:
						num8 = 197;
						num3 = 16;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 620;
					case 620:
						array5[27] = (byte)num8;
						goto case 578;
					case 578:
						array5[27] = 116;
						goto case 84;
					case 84:
						num8 = 60;
						num3 = 184;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 55;
					case 55:
						array5[28] = (byte)num8;
						goto case 363;
					case 363:
						array5[28] = 88;
						num3 = 21;
						if (boolParam())
						{
							continue;
						}
						goto case 480;
					case 633:
						array5[_return_314] = 182;
						goto case 386;
					case 386:
						num8 = 99;
						goto case 131;
					case 131:
						array5[_return_314] = (byte)num8;
						num3 = 342;
						if (!boolParam())
						{
							continue;
						}
						goto case 227;
					case 631:
						array3[7] = 120;
						goto case 504;
					case 504:
						array3[7] = 128;
						goto case 390;
					case 630:
						array5[6] = (byte)num8;
						goto case 418;
					case 418:
						array5[6] = 129;
						num3 = 165;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 350;
					case 350:
						num8 = 85;
						num3 = 617;
						if (!boolParam())
						{
							continue;
						}
						goto case 522;
					case 522:
						array5[7] = (byte)num8;
						goto case 122;
					case 122:
						array5[7] = 221;
						goto case 303;
					case 303:
						num8 = 68;
						num3 = 542;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 125;
					case 125:
						num67 = intParam(objectParam);
						goto case 210;
					case 210:
						if (intParam(intptrParam, num67 * 4, 4, ref int_) == 0)
						{
							num3 = 584;
							if (objectParam() != null)
							{
								continue;
							}
							goto case 36;
						}
						goto case 98;
					case 36:
						intParam(intptrParam, num67 * 4, 8, ref int_);
						goto case 98;
					case 98:
						num68 = 0;
						goto case 42;
					case 309:
						voidParam(new IntPtr(intptrParam.ToInt64() + num68 * 4), intParam(objectParam));
						num3 = 115;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 199;
					case 199:
						num68++;
						goto case 42;
					case 42:
					case 458:
						if (num68 < num67)
						{
							goto case 309;
						}
						goto case 539;
					case 539:
						intParam(intptrParam, num67 * 4, int_, ref int_);
						goto case 301;
					case 629:
						array2 = null;
						num3 = 359;
						if (!boolParam())
						{
							continue;
						}
						goto case 60;
					case 60:
						if (intParam() != 4)
						{
							goto case 62;
						}
						goto case 239;
					case 239:
						array2 = (byte[])objectParam(_intptr_4.ToInt32());
						goto case 318;
					case 318:
						array4 = (byte[])objectParam(intPtr3.ToInt32());
						num3 = 107;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 405;
					case 628:
						intParam(objectParam);
						num3 = 580;
						if (!boolParam())
						{
							continue;
						}
						goto case 296;
					case 296:
						intParam(objectParam);
						goto case 127;
					case 127:
						intParam(objectParam);
						goto case 472;
					case 472:
						intParam(objectParam);
						num3 = 451;
						if (boolParam())
						{
							continue;
						}
						goto case 144;
					case 144:
						voidParam(new IntPtr(&num19), 0, 0L);
						num3 = 256;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 461;
					case 461:
						voidParam(new byte[_return_314], 0, intptrParam(8), _return_314);
						num3 = 157;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 526;
					case 526:
						voidParam();
						num3 = 420;
						if (!boolParam())
						{
							continue;
						}
						goto case 455;
					case 455:
						if (num48 == 4109628145u)
						{
							num3 = 179;
							if (boolParam())
							{
								continue;
							}
							goto case 237;
						}
						goto _goto_252;
					case 622:
						array5[13] = (byte)num8;
						goto case 573;
					case 573:
						num8 = 204;
						goto case 395;
					case 395:
						array5[14] = (byte)num8;
						num3 = 433;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 260;
					case 260:
						num5 = 119;
						num3 = 584;
						if (boolParam())
						{
							continue;
						}
						goto case 171;
					case 621:
						_intptr_10 = LoadLibrary(text);
						num3 = 46;
						if (boolParam())
						{
							continue;
						}
						goto case 410;
					case 618:
						array5[2] = (byte)num8;
						goto case 435;
					case 435:
						num8 = 115;
						num3 = 354;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 223;
					case 616:
						array5[30] = (byte)num8;
						goto case 369;
					case 369:
						num8 = 32;
						goto case 70;
					case 70:
						array5[30] = (byte)num8;
						num3 = 481;
						if (boolParam())
						{
							continue;
						}
						goto case 287;
					case 287:
						array[num6] = array4[0];
						goto case 489;
					case 489:
						array[num6 + _return_314] = array4[_return_314];
						num3 = 625;
						if (boolParam())
						{
							continue;
						}
						goto case 511;
					case 615:
						array5[0] = 171;
						goto case 177;
					case 177:
						array5[0] = 121;
						num3 = 40;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 299;
					case 299:
						array8[_return_125] = 116;
						goto case 255;
					case 255:
						array8[6] = 46;
						goto case 506;
					case 506:
						array8[7] = 100;
						goto case 651;
					case 612:
						array3[15] = (byte)num5;
						num3 = 587;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 387;
					case 387:
						num5 = 37;
						num3 = 284;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 389;
					case 389:
						num54++;
						num3 = 294;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 123;
					case 123:
					case 507:
						if (num54 >= num47)
						{
							num = 412;
							break;
						}
						goto case 520;
					case 520:
						intptr_ = new IntPtr(num45 + intParam(objectParam) - num31);
						num3 = 565;
						if (boolParam())
						{
							continue;
						}
						goto case 114;
					case 610:
						array5[26] = 98;
						goto case 29;
					case 29:
						num8 = 173;
						goto case 90;
					case 90:
						array5[26] = (byte)num8;
						goto case 187;
					case 187:
						array5[27] = 134;
						goto case 609;
					case 609:
						array5[27] = 152;
						goto case 600;
					case 600:
						array5[27] = 166;
						goto case 636;
					case 608:
						text = (string)objectParam(objectParam(), array8);
						num3 = 288;
						if (boolParam())
						{
							continue;
						}
						goto case 138;
					case 138:
						array5[14] = 142;
						num3 = 2;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 329;
					case 606:
						array5[18] = 138;
						goto case 533;
					case 533:
						array5[19] = 121;
						goto case 219;
					case 219:
						array5[19] = 89;
						num3 = 184;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 59;
					case 605:
						num52 = (uint)num14;
						num3 = 45;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 289;
					case 289:
						num33 += num34;
						goto case 254;
					case 254:
						num49 = (uint)((array13[num52 + 3] << 24) | (array13[num52 + 2] << 16) | (array13[num52 + _return_314] << 8) | array13[num52]);
						num3 = 411;
						if (!boolParam())
						{
							continue;
						}
						goto case 54;
					case 54:
					case 173:
						num33 = num33;
						num3 = 88;
						if (!boolParam())
						{
							continue;
						}
						goto case 564;
					case 564:
					{
						uint num59 = num33;
						uint num60 = num33;
						uint num61 = 1257709153u;
						uint num62 = 807144328u;
						uint num63 = 1022397983u;
						uint num64 = num60;
						num61 = 165448209u;
						num62 = 696972267u;
						uint num65 = 1022397983u;
						num63 = 958800974u;
						if (num64 == 0)
						{
							num64--;
						}
						num65 = num61 / num64 + num64;
						num64 = num61 - num61 + num65 + num61;
						num64 ^= num64 << 7;
						num64 += num62;
						num64 ^= num64 >> _return_314;
						num64 += num63;
						num64 ^= num64 << 25;
						num64 += num64;
						num64 = (((num63 << 3) + num63) ^ num63) + num64;
						num33 = num59 + (uint)(double)num64;
						goto case 558;
					}
					case 558:
						if (num53 == num21 - _return_314)
						{
							goto case 403;
						}
						goto case 231;
					case 604:
						array5 = new byte[32];
						num3 = 166;
						if (boolParam())
						{
							continue;
						}
						goto case 479;
					case 479:
						num8 = 206;
						goto case 414;
					case 414:
						array5[28] = (byte)num8;
						goto case 324;
					case 324:
						array5[29] = 98;
						num3 = 302;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 61;
					case 603:
						num8 = 92;
						goto case 587;
					case 587:
						array5[24] = (byte)num8;
						num3 = 225;
						if (boolParam())
						{
							continue;
						}
						goto case 128;
					case 128:
						num57 = intParam(objectParam) - num31;
						goto case 17;
					case 17:
					{
						int num58 = intParam(objectParam);
						flag = false;
						if (num58 >= 1879048192)
						{
							num3 = 189;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 187;
						}
						goto case 278;
					}
					case 602:
						value = 0L;
						num3 = 641;
						if (boolParam())
						{
							continue;
						}
						goto case 464;
					case 464:
						voidParam(new IntPtr(&num19), 0, IntPtr.Zero);
						goto case 554;
					case 554:
						voidParam(new IntPtr(&num19), 0, 0);
						num3 = 144;
						if (boolParam())
						{
							continue;
						}
						goto case 225;
					case 225:
						array5[24] = 117;
						num3 = 317;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 417;
					case 601:
						num8 = 92;
						goto case 582;
					case 582:
						array5[16] = (byte)num8;
						num3 = 256;
						if (!boolParam())
						{
							continue;
						}
						goto case 134;
					case 134:
						num8 = 165;
						goto case 99;
					case 99:
						array5[16] = (byte)num8;
						goto case 494;
					case 494:
						num8 = 248;
						goto case 83;
					case 596:
						num16 = longParam(new IntPtr(value));
						num3 = 229;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 577;
					case 577:
						array5[24] = 132;
						num3 = 343;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 603;
					case 595:
						array6[13] = array7[6];
						num3 = 421;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 291;
					case 291:
						array[num6] = array10[0];
						goto case 19;
					case 19:
						array[num6 + _return_314] = array10[_return_314];
						num3 = 125;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 275;
					case 275:
						array[num6 + 2] = array10[2];
						num3 = 73;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 264;
					case 264:
						array3[9] = (byte)num5;
						goto case 315;
					case 315:
						array3[9] = 60;
						goto case 146;
					case 146:
						num5 = 218;
						goto case 367;
					case 592:
						num55 = array11.Length / 8;
						num3 = 447;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 136;
					case 136:
					case 266:
						num56 = 0;
						num3 = 145;
						if (!boolParam())
						{
							continue;
						}
						goto case 116;
					case 590:
						array3[6] = 127;
						goto case 631;
					case 588:
						array5[13] = (byte)num8;
						num3 = 195;
						if (boolParam())
						{
							continue;
						}
						goto case 330;
					case 330:
						array[num4 + _return_314] = array10[_return_314];
						num3 = 365;
						if (!boolParam())
						{
							continue;
						}
						goto case 186;
					case 186:
						array[num4 + 2] = array10[2];
						goto case 518;
					case 518:
						array[num4 + 3] = array10[3];
						goto case 293;
					case 293:
						array[num4 + 4] = array10[4];
						num3 = 517;
						if (boolParam())
						{
							continue;
						}
						goto case 62;
					case 585:
						array3[0] = (byte)num5;
						goto case 358;
					case 358:
						array3[0] = 169;
						num3 = 11;
						if (!boolParam())
						{
							continue;
						}
						goto case 279;
					case 279:
						array3[0] = 137;
						num3 = 634;
						if (boolParam())
						{
							continue;
						}
						goto case 46;
					case 584:
						array3[14] = (byte)num5;
						num3 = 563;
						if (!boolParam())
						{
							continue;
						}
						goto case 496;
					case 496:
						array3[14] = 178;
						goto case 222;
					case 222:
						num5 = 124;
						num3 = 232;
						if (boolParam())
						{
							continue;
						}
						goto case 618;
					case 583:
						array5[19] = 248;
						goto case 89;
					case 89:
						array5[20] = 135;
						goto case 174;
					case 581:
						array5[14] = (byte)num8;
						goto case 138;
					case 580:
						voidParam();
						num3 = 526;
						if (!boolParam())
						{
							continue;
						}
						return;
					case 579:
						array[num4 + 6] = array4[6];
						num3 = 201;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 269;
					case 569:
						intParam = 0;
						goto case 443;
					case 443:
						if (boolParam(objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly), null))
						{
							num = 265;
							break;
						}
						goto case 352;
					case 567:
						array5[_return_125] = 184;
						num3 = 646;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 307;
					case 307:
						array5[6] = 99;
						goto case 209;
					case 209:
						num8 = 72;
						num3 = 661;
						if (!boolParam())
						{
							continue;
						}
						goto case 630;
					case 566:
						num5 = 123;
						goto case 81;
					case 81:
						array3[9] = (byte)num5;
						goto case 375;
					case 375:
						array3[9] = 137;
						num3 = 143;
						if (!boolParam())
						{
							continue;
						}
						goto case 333;
					case 563:
						intParam(new IntPtr(&num19), 0);
						goto case 360;
					case 360:
						longParam(new IntPtr(&num19), 0);
						goto case 464;
					case 560:
						num5 = 114;
						num3 = 263;
						if (!boolParam())
						{
							continue;
						}
						goto case 320;
					case 320:
						array3[10] = (byte)num5;
						goto case 653;
					case 559:
						if (num17 == 4)
						{
							num3 = 514;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 136;
						}
						goto case 491;
					case 491:
						if (num17 == _return_314)
						{
							goto case 384;
						}
						num54 = 0;
						num3 = 123;
						if (boolParam())
						{
							continue;
						}
						goto case 23;
					case 553:
						if (num53 != num21 - _return_314)
						{
							goto case 605;
						}
						goto case 253;
					case 253:
						if (num20 <= 0)
						{
							goto case 605;
						}
						num3 = 390;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 348;
					case 348:
						num33 += num34;
						goto case 521;
					case 521:
						num49 = _return_124;
						goto case 221;
					case 221:
						num50 = 0;
						num3 = 217;
						if (boolParam())
						{
							continue;
						}
						goto case 136;
					case 552:
						array3[8] = (byte)num5;
						goto case 566;
					case 550:
						array5[_return_314] = (byte)num8;
						num3 = 175;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 523;
					case 523:
						num31 = 0;
						num3 = 90;
						if (!boolParam())
						{
							continue;
						}
						goto case 100;
					case 100:
						if (objectParam(GetInternal_14.objectParam) != null)
						{
							goto case 224;
						}
						num3 = 400;
						if (boolParam())
						{
							continue;
						}
						goto case 16;
					case 224:
						if (intParam(objectParam(GetInternal_14.objectParam)) != 0)
						{
							goto case 628;
						}
						goto case 400;
					case 542:
						array5[7] = (byte)num8;
						goto case 251;
					case 251:
						num8 = 110;
						goto case 650;
					case 541:
						array3[10] = 111;
						num3 = 82;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 118;
					case 540:
						array[num4 + 7] = array2[7];
						num3 = 439;
						if (boolParam())
						{
							continue;
						}
						goto case 212;
					case 537:
						array[num4 + 2] = array2[2];
						goto case 438;
					case 438:
						array[num4 + 3] = array2[3];
						goto case 425;
					case 425:
						array[num4 + 4] = array2[4];
						num3 = 247;
						if (boolParam())
						{
							continue;
						}
						goto case 421;
					case 531:
						array[num6 + _return_314] = array2[_return_314];
						num3 = 200;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 424;
					case 530:
						num51++;
						goto case 158;
					case 158:
					case 258:
						if (num51 >= array6.Length)
						{
							num3 = 230;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 628;
						}
						goto case 13;
					case 527:
						num5 = 69;
						goto case 404;
					case 404:
						array3[_return_314] = (byte)num5;
						goto case 392;
					case 392:
						array3[2] = 55;
						num3 = 412;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 280;
					case 280:
						array3[2] = 98;
						goto case 133;
					case 524:
						intParam(new IntPtr(value), intParam(), intParam, ref intParam);
						num3 = 599;
						if (boolParam())
						{
							continue;
						}
						goto case 315;
					case 342:
					case 519:
						ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array18[0]);
						num3 = 266;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 217;
					case 217:
					case 515:
						if (num50 < num20)
						{
							goto case 38;
						}
						goto case 54;
					case 517:
						array[num4 + _return_125] = array10[_return_125];
						num3 = 144;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 228;
					case 228:
						array[num4 + 6] = array10[6];
						goto case 346;
					case 346:
						array[num4 + 7] = array10[7];
						num3 = 383;
						if (boolParam())
						{
							continue;
						}
						goto case 76;
					case 76:
						num6 = 23;
						goto case 287;
					case 514:
					{
						object objectParam = objectParam();
						voidParam(objectParam, CipherMode.CBC);
						transform = (ICryptoTransform)objectParam(objectParam, array15, array6);
						num3 = 77;
						if (!boolParam())
						{
							continue;
						}
						goto case 27;
					}
					case 27:
						voidParam(array15, 0, array15.Length);
						num3 = 560;
						if (!boolParam())
						{
							continue;
						}
						goto case 393;
					case 393:
					{
						MemoryStream memoryStream = new MemoryStream();
						objectParam = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						voidParam(objectParam, array14, 0, array14.Length);
						voidParam(objectParam);
						array11 = (byte[])objectParam(memoryStream);
						voidParam(array6, 0, array6.Length);
						voidParam(memoryStream);
						num3 = 180;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 268;
					}
					case 513:
						array3[14] = (byte)num5;
						num3 = 308;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 233;
					case 512:
						intPtr3 = intptrParam(GetInternal_14.objectParam);
						num3 = 314;
						if (!boolParam())
						{
							continue;
						}
						goto case 589;
					case 510:
						array5[29] = 156;
						goto case 172;
					case 172:
						array5[29] = 150;
						goto case 152;
					case 152:
						num8 = 186;
						num3 = 74;
						if (!boolParam())
						{
							continue;
						}
						goto case 145;
					case 145:
						array5[29] = (byte)num8;
						goto case 295;
					case 295:
						num8 = 160;
						goto case 121;
					case 121:
						array5[30] = (byte)num8;
						goto case 397;
					case 397:
						num8 = 112;
						goto case 616;
					case 505:
						array5[21] = 40;
						goto case 252;
					case 502:
						array5[12] = 160;
						goto case 492;
					case 492:
						num8 = 134;
						goto case 406;
					case 406:
						array5[12] = (byte)num8;
						goto case 68;
					case 68:
						array5[12] = 254;
						goto case 216;
					case 216:
						num8 = 94;
						num3 = 240;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 201;
					case 201:
						array5[13] = (byte)num8;
						num3 = 398;
						if (boolParam())
						{
							continue;
						}
						goto case 563;
					case 499:
						intParam(intptrParam, intPtr2, (byte[])objectParam(intParam(objectParam)), 4u, out _intptr_126);
						goto case 14;
					case 498:
						if (objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly) == null)
						{
							goto case 352;
						}
						goto case 204;
					case 204:
						if (intParam(objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly)) <= 0)
						{
							goto case 352;
						}
						num3 = 29;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 580;
					case 497:
						array8[4] = 105;
						num3 = 299;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 222;
					case 493:
						num18 += 8;
						num3 = 417;
						if (boolParam())
						{
							continue;
						}
						goto case 238;
					case 282:
					case 490:
						if (intParam() == 4)
						{
							num3 = _return_314;
							if (boolParam())
							{
								continue;
							}
							goto case 628;
						}
						goto case 165;
					case 165:
						num4 = 2;
						num3 = 643;
						if (boolParam())
						{
							continue;
						}
						goto case 585;
					case 487:
						array[num4 + 6] = array2[6];
						goto case 540;
					case 486:
						array5[2] = 33;
						goto case 10;
					case 10:
						num8 = 130;
						num3 = 618;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 181;
					case 181:
						array8[3] = 106;
						num3 = 531;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 497;
					case 485:
						num8 = 153;
						num3 = 90;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 453;
					case 453:
						array5[26] = (byte)num8;
						num3 = 126;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 610;
					case 481:
						num8 = 117;
						goto case 448;
					case 475:
						_intptr_8 = intptrParam((GetDelegateIntptr_5)objectParam(GetProcAddress(_intptr_10, string_), typeParam(typeof(GetDelegateIntptr_5).TypeHandle)));
						num3 = 194;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 602;
					case 474:
						array[num4] = array10[0];
						num3 = 330;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 563;
					case 470:
						array5[_return_125] = (byte)num8;
						goto case 51;
					case 51:
						num8 = 101;
						num3 = 528;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 419;
					case 419:
						array5[_return_125] = (byte)num8;
						goto case 567;
					case 467:
						array5[2] = (byte)num8;
						goto case 361;
					case 465:
						num5 = 100;
						num3 = 343;
						if (!boolParam())
						{
							continue;
						}
						goto case 191;
					case 191:
						array3[3] = (byte)num5;
						num3 = 587;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 326;
					case 326:
						num5 = 115;
						num3 = 385;
						if (!boolParam())
						{
							continue;
						}
						goto case 109;
					case 109:
						array3[3] = (byte)num5;
						goto case 271;
					case 271:
						array3[4] = 107;
						goto case 440;
					case 440:
						num5 = 214;
						goto case 343;
					case 459:
						voidParam(objectParam);
						goto case 243;
					case 243:
						num47 = intParam(objectParam);
						goto case 321;
					case 321:
						num17 = intParam(objectParam);
						goto case 491;
					case 454:
						num48 = 4059231220u;
						goto case 316;
					case 316:
						num19 = 0L;
						num3 = 113;
						if (boolParam())
						{
							continue;
						}
						goto case 217;
					case 451:
						num47 = intParam(objectParam);
						num3 = 95;
						if (boolParam())
						{
							continue;
						}
						goto case 332;
					case 332:
						array5[_return_125] = (byte)num8;
						num3 = 331;
						if (boolParam())
						{
							continue;
						}
						goto case 25;
					case 449:
						num8 = 156;
						goto case 43;
					case 43:
						array5[3] = (byte)num8;
						num3 = 28;
						if (boolParam())
						{
							continue;
						}
						goto case 338;
					case 338:
						array8[7] = 116;
						num3 = 459;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 382;
					case 382:
						array8[8] = 46;
						num3 = 391;
						if (boolParam())
						{
							continue;
						}
						goto case 496;
					case 447:
					{
						byte[] array21 = array11;
						array18 = array21;
						if (array21 != null)
						{
							goto case 337;
						}
						num3 = 7;
						if (boolParam())
						{
							continue;
						}
						goto case 333;
					}
					case 337:
						if (array18.Length != 0)
						{
							num3 = 342;
							if (boolParam())
							{
								continue;
							}
							goto case 186;
						}
						goto case 7;
					case 446:
						voidParam(objectParam(objectParam), 0L);
						num3 = 286;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 574;
					case 441:
						array5[17] = (byte)num8;
						goto case 423;
					case 423:
						num8 = 130;
						num3 = 211;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 165;
					case 439:
						num4 = 18;
						num3 = 498;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 474;
					case 437:
						int_ = 0;
						num3 = 386;
						if (!boolParam())
						{
							continue;
						}
						goto case 523;
					case 436:
						array5[_return_125] = 116;
						goto case 509;
					case 434:
						num8 = 139;
						goto case 470;
					case 432:
						intPtr = intptrParam(((object[])objectParam(GetInternal_14.objectParam))[0]);
						num3 = 344;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 77;
					case 77:
						num45 = intPtr.ToInt64();
						goto case 437;
					case 429:
						array5[17] = 251;
						num3 = 374;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 145;
					case 428:
						voidParam(objectParam, 0L, @struct);
						goto case 218;
					case 218:
						flag = false;
						num3 = 462;
						if (boolParam())
						{
							continue;
						}
						goto case 544;
					case 426:
						voidParam(runtimemethodhandleParam(objectParam(GetInternal_14.objectParam)));
						num3 = 205;
						if (!boolParam())
						{
							continue;
						}
						goto case 58;
					case 58:
						array19 = null;
						goto case 182;
					case 182:
						if (intParam() != 4)
						{
							num3 = 644;
							if (boolParam())
							{
								continue;
							}
							goto case 432;
						}
						goto case 246;
					case 246:
					{
						byte[] array20 = new byte[30];
						voidParam(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array19 = array20;
						goto case 160;
					}
					case 415:
						array3[6] = 94;
						num3 = 86;
						if (!boolParam())
						{
							continue;
						}
						goto case 590;
					case 413:
						array3[_return_314] = (byte)num5;
						goto case 527;
					case 411:
						try
						{
							object obj3 = objectParam(typeParam(modulehandleParam(objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), modulehandleParam(objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly)));
							while (true)
							{
								int num35;
								if (obj3 is IntPtr)
								{
									num35 = _return_125;
									if (objectParam() == null)
									{
										goto _goto_187;
									}
									goto _goto_228;
								}
								goto _goto_191;
								_goto_230:
								int num37;
								num36 = num37;
								goto _goto_222;
								_goto_191:
								if (!boolParam(obj3.GetType().ToString(), "System.Reflection.RuntimeModule"))
								{
									goto _goto_189;
								}
								goto _goto_223;
								_goto_223:
								_intptr_4 = (IntPtr)objectParam(obj3.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj3);
								goto _goto_189;
								_goto_189:
								objectParam = new MemoryStream();
								goto _goto_188;
								_goto_188:
								voidParam(objectParam, new byte[intParam()], 0, intParam());
								num35 = 7;
								if (objectParam() == null)
								{
									goto _goto_185;
								}
								goto _goto_228;
								_goto_228:
								switch (num35)
								{
								case 14:
									break;
								case 2:
									goto _goto_226;
								case _return_314:
									goto _goto_227;
								case 8:
									goto _goto_229;
								case 13:
									goto _goto_216;
								default:
									goto _goto_219;
								case 0:
									goto _goto_221;
								case 11:
									goto _goto_185;
								case 3:
									goto _goto_217;
								case 9:
									goto _goto_187;
								case 10:
									goto _goto_188;
								case _return_125:
								case 7:
									goto _goto_189;
								case 15:
									goto _goto_223;
								case 6:
									goto _goto_191;
								case 17:
									continue;
								case 12:
									uint_ = _return_124;
									goto case 4;
								case 4:
									try
									{
										byte[] array16 = array17;
										fixed (byte[] array18 = array16)
										{
											int num38;
											if (array16 == null)
											{
												num38 = 14;
												if (objectParam() != null)
												{
													goto _goto_205;
												}
												goto _goto_208;
											}
											goto _goto_209;
											_goto_211:
											value2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array18[0]);
											num38 = 6;
											if (objectParam() != null)
											{
												goto _goto_206;
											}
											goto _goto_205;
											_goto_208:
											value2 = null;
											goto _goto_207;
											_goto_207:
											GetInternal_14.objectParam(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref uint_);
											num38 = 4;
											if (objectParam() != null)
											{
												goto _goto_206;
											}
											goto _goto_205;
											_goto_206:
											if (num39 == 14)
											{
												goto _goto_211;
											}
											if (num39 == 994)
											{
												goto _goto_203;
											}
											goto _goto_210;
											_goto_209:
											if (array18.Length != 0)
											{
												int num40 = 9;
												if (objectParam() == null)
												{
													num40 = 14;
												}
												num39 = num40;
												goto _goto_203;
											}
											goto _goto_208;
											_goto_203:
											num38 = num39;
											goto _goto_205;
											_goto_205:
											switch (num38)
											{
											case _return_314:
												break;
											default:
												goto _goto_206;
											case 3:
											case 6:
												goto _goto_207;
											case 0:
											case _return_125:
												goto _goto_208;
											case 2:
												goto _goto_209;
											case 4:
												goto _goto_210;
											}
											goto _goto_211;
											_goto_210:;
										}
									}
									finally
									{
										array18 = null;
										int num41 = 3;
										if (objectParam() != null)
										{
											while (true)
											{
												switch (num41)
												{
												default:
													if (num42 != 988)
													{
														break;
													}
													num41 = num42;
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									goto _goto_213;
								case 16:
									goto _goto_213;
								}
								goto _goto_225;
								_goto_187:
								_intptr_4 = (IntPtr)obj3;
								num35 = 6;
								if (!boolParam())
								{
									break;
								}
								goto _goto_228;
								_goto_185:
								if (intParam() == 4)
								{
									goto _goto_216;
								}
								goto _goto_217;
								_goto_217:
								voidParam(objectParam, objectParam(_intptr_4.ToInt64()), 0, 8);
								num37 = 25;
								goto _goto_230;
								_goto_216:
								voidParam(objectParam, objectParam(_intptr_4.ToInt32()), 0, 4);
								num35 = 0;
								if (!boolParam())
								{
									goto _goto_219;
								}
								goto _goto_228;
								_goto_219:
								if (num36 == 25)
								{
									goto _goto_221;
								}
								if (num36 == 1005)
								{
									goto _goto_222;
								}
								goto _goto_223;
								_goto_222:
								num35 = num36;
								goto _goto_228;
								_goto_221:
								voidParam(objectParam, new byte[intParam()], 0, intParam());
								goto _goto_225;
								_goto_225:
								voidParam(objectParam, new byte[intParam()], 0, intParam());
								goto _goto_226;
								_goto_226:
								voidParam(objectParam, 0L);
								num35 = 17;
								if (objectParam() == null)
								{
									goto _goto_227;
								}
								goto _goto_228;
								_goto_227:
								array17 = (byte[])objectParam(objectParam);
								goto _goto_229;
								_goto_229:
								voidParam(objectParam);
								num37 = 12;
								goto _goto_230;
								continue;
								_goto_213:
								break;
							}
						}
						catch
						{
							int num43 = _return_314;
							if (!boolParam())
							{
								while (true)
								{
									switch (num43)
									{
									default:
										if (num44 != 988)
										{
											break;
										}
										num43 = num44;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 44;
					case 409:
						num33 = _return_124;
						goto case 394;
					case 394:
						num34 = _return_124;
						goto case 624;
					case 408:
						num5 = 56;
						goto case 612;
					case 407:
						num5 = 223;
						num3 = 310;
						if (boolParam())
						{
							continue;
						}
						goto case 135;
					case 399:
						array9 = new byte[array13.Length];
						goto case 41;
					case 41:
						num32 = array15.Length / 4;
						num3 = 299;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 409;
					case 396:
						array3[3] = 195;
						goto case 465;
					case 385:
						intptrParam = new IntPtr(_long_7 + num30 - num31);
						goto case 125;
					case 383:
						num4 = 30;
						num3 = 454;
						if (!boolParam())
						{
							continue;
						}
						goto case 3;
					case 380:
						array5[31] = (byte)num8;
						num3 = 304;
						if (!boolParam())
						{
							continue;
						}
						goto case 208;
					case 208:
						array5[31] = 49;
						goto case 642;
					case 379:
						num8 = 6;
						num3 = 205;
						if (boolParam())
						{
							continue;
						}
						goto case 527;
					case 377:
						if (intParam() != 4)
						{
							goto case 499;
						}
						goto case 137;
					case 137:
						intParam(intptrParam, intPtr2, (byte[])objectParam(intParam(objectParam)), 4u, out _intptr_126);
						goto case 14;
					case 373:
						array3[10] = (byte)num5;
						goto case 560;
					case 371:
						array5[12] = (byte)num8;
						goto case 502;
					case 370:
						array5[_return_314] = (byte)num8;
						num3 = 149;
						if (boolParam())
						{
							continue;
						}
						goto case 380;
					case 364:
						num5 = 99;
						goto case 585;
					case 354:
						array5[2] = (byte)num8;
						num3 = 8;
						if (objectParam() != null)
						{
							continue;
						}
						goto case _return_125;
					case _return_125:
						array5[2] = 173;
						num3 = 598;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 460;
					case 353:
						array5[3] = (byte)num8;
						num3 = 449;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 288;
					case 288:
						_intptr_10 = IntPtr.Zero;
						goto case 220;
					case 344:
						num8 = 104;
						goto case 274;
					case 274:
						array5[8] = (byte)num8;
						goto case 250;
					case 250:
						num8 = 97;
						goto case 78;
					case 340:
						num8 = 123;
						num3 = 334;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 253;
					case 339:
						array3[_return_125] = 144;
						num3 = 654;
						if (boolParam())
						{
							continue;
						}
						goto case 457;
					case 336:
						try
						{
							objectParam = (GetDelegateUint_4)objectParam(new IntPtr(num16), typeParam(typeof(GetDelegateUint_4).TypeHandle));
							int num22 = 6;
							if (!boolParam())
							{
								while (true)
								{
									switch (num22)
									{
									default:
										if (num23 != 988)
										{
											break;
										}
										num22 = num23;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						catch
						{
							int num24 = 0;
							if (!boolParam())
							{
								goto _goto_235;
							}
							while (true)
							{
								switch (num24)
								{
								default:
									if (num25 == 989)
									{
										goto _goto_232;
									}
									goto _goto_234;
								case 0:
									break;
								case _return_314:
									goto _goto_234;
								}
								goto _goto_235;
								_goto_232:
								num24 = num25;
								continue;
								_goto_234:
								break;
							}
							goto _goto_236;
							_goto_235:
							try
							{
								Delegate objectParam = (Delegate)objectParam(new IntPtr(num16), typeParam(typeof(GetDelegateUint_4).TypeHandle));
								int num26 = 0;
								if (objectParam() != null)
								{
									goto _goto_241;
								}
								goto _goto_244;
								_goto_241:
								if (num27 != 989)
								{
									goto _goto_243;
								}
								num26 = num27;
								goto _goto_244;
								_goto_244:
								switch (num26)
								{
								case 0:
									break;
								default:
									goto _goto_241;
								case _return_314:
									goto _goto_242;
								}
								goto _goto_243;
								_goto_243:
								objectParam = (GetDelegateUint_4)objectParam(typeParam(typeof(GetDelegateUint_4).TypeHandle), objectParam(objectParam));
								num26 = _return_125;
								if (objectParam() != null)
								{
									goto _goto_244;
								}
								_goto_242:;
							}
							catch
							{
								int num28 = 0;
								if (!boolParam())
								{
									goto _goto_250;
								}
								goto _goto_247;
								_goto_250:
								if (num29 == 988)
								{
									num28 = num29;
									goto _goto_247;
								}
								goto _goto_249;
								_goto_247:
								switch (num28)
								{
								case 0:
									goto _goto_249;
								}
								goto _goto_250;
								_goto_249:;
							}
							_goto_236:;
						}
						goto case 4;
					case 4:
						num3 = 416;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 569;
					case 331:
						num8 = 108;
						goto case 161;
					case 161:
						array5[_return_125] = (byte)num8;
						goto case 434;
					case 328:
						num21 = array13.Length / 4;
						goto case 399;
					case 327:
						array[num6 + 3] = array2[3];
						goto case 197;
					case 197:
						num6 = 16;
						goto case 291;
					case 322:
						array5[23] = (byte)num8;
						goto case 577;
					case 317:
						array5[25] = 131;
						num3 = 21;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 47;
					case 47:
						num8 = 185;
						num3 = 63;
						if (boolParam())
						{
							continue;
						}
						goto case 477;
					case 314:
						value = intParam(_intptr_8);
						num3 = 89;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 607;
					case 312:
						num8 = 118;
						num3 = 293;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 371;
					case 311:
						num20 = array13.Length % 4;
						goto case 328;
					case 308:
						num5 = 177;
						goto case 32;
					case 32:
						array3[14] = (byte)num5;
						goto case 260;
					case 302:
						array5[29] = 106;
						goto case 9;
					case 9:
						array5[29] = 92;
						goto case 510;
					case 294:
						num8 = 92;
						goto case 380;
					case 286:
						array14 = (byte[])objectParam(objectParam, (int)longParam(objectParam(objectParam)));
						goto case 604;
					case 284:
						array3[15] = (byte)num5;
						goto case 45;
					case 45:
						array6 = array3;
						goto case 176;
					case 176:
						voidParam(array6);
						goto case 637;
					case 273:
						num8 = 107;
						goto case 202;
					case 202:
						array5[18] = (byte)num8;
						goto case 606;
					case 265:
						if (((Array)objectParam(objectParam(typeParam(typeof(GetInternal_14).TypeHandle).Assembly))).Length != 2)
						{
							goto case 352;
						}
						num3 = 498;
						if (boolParam())
						{
							continue;
						}
						goto case 190;
					case 261:
						array5[11] = (byte)num8;
						goto case 59;
					case 248:
						array[num4 + _return_125] = array4[_return_125];
						goto case 579;
					case 247:
						array[num4 + _return_125] = array2[_return_125];
						goto case 487;
					case 236:
						array8[_return_125] = 106;
						num3 = 52;
						if (boolParam())
						{
							continue;
						}
						goto case 96;
					case 96:
						array[num6] = array2[0];
						num3 = 492;
						if (!boolParam())
						{
							continue;
						}
						goto case 531;
					case 234:
						struct2 = default(AppStruct_964);
						goto case 85;
					case 85:
						struct2.byte_0 = byte_;
						goto case 233;
					case 230:
						array13 = array14;
						num3 = 223;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 311;
					case 226:
						num5 = 105;
						goto case 215;
					case 215:
						array3[0] = (byte)num5;
						goto case 364;
					case 211:
						array5[17] = (byte)num8;
						goto case 652;
					case 200:
						array[num6 + 2] = array2[2];
						num3 = 327;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 339;
					case 198:
						text = (string)objectParam(objectParam(), array8);
						goto case 621;
					case 195:
						num8 = 148;
						goto case 622;
					case 193:
						array5[20] = (byte)num8;
						goto case 505;
					case 180:
						voidParam(objectParam);
						num3 = 459;
						if (boolParam())
						{
							continue;
						}
						goto case 388;
					case 166:
						num8 = 46;
						goto case 139;
					case 139:
						array5[0] = (byte)num8;
						num3 = 405;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 615;
					case 164:
						if (intParam(intPtr2, 4, 4, ref int_) != 0)
						{
							goto case 377;
						}
						goto case 148;
					case 148:
						intParam(intPtr2, 4, 8, ref int_);
						goto case 377;
					case 157:
						objectParam = new GetPublic_6(new MemoryStream(array11));
						goto case 112;
					case 112:
						voidParam(objectParam(objectParam), 0L);
						goto case 432;
					case 155:
						if (!boolParam)
						{
							num3 = 154;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 377;
						}
						goto case 599;
					case 154:
						boolParam = true;
						num3 = 454;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 65;
					case 150:
						num5 = 154;
						goto case 552;
					case 149:
						num8 = 30;
						num3 = 221;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 467;
					case 143:
						array8[3] = 111;
						num3 = 530;
						if (!boolParam())
						{
							continue;
						}
						goto case 56;
					case 56:
						array8[4] = 114;
						goto case 236;
					case 132:
						array[num4 + _return_314] = array2[_return_314];
						goto case 537;
					case 130:
						array3[8] = (byte)num5;
						goto case 645;
					case 126:
						array5[8] = (byte)num8;
						goto case 111;
					case 111:
						num8 = 28;
						num3 = 372;
						if (boolParam())
						{
							continue;
						}
						goto case 510;
					case 120:
						array8[2] = 99;
						num3 = 380;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 143;
					case 113:
						intptrParam(new IntPtr(&num19), 0);
						goto case 563;
					case 107:
						array10 = (byte[])objectParam(intParam(num16));
						goto case 282;
					case 106:
						array5[25] = 35;
						goto case 485;
					case 105:
						num18 = 0;
						goto case 553;
					case 103:
						intParam = intPtr.ToInt32();
						goto case 185;
					case 101:
						array3[2] = (byte)num5;
						num3 = 635;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 237;
					case 95:
						num17 = intParam(objectParam);
						goto case 559;
					case 92:
						array5[11] = (byte)num8;
						goto case 31;
					case 31:
						num8 = 93;
						goto case 261;
					case 88:
						array8[11] = 108;
						goto case 608;
					case 87:
						array5[31] = (byte)num8;
						goto case 294;
					case 82:
						num5 = 132;
						goto case 373;
					case 73:
						array[num6 + 3] = array10[3];
						num3 = 76;
						if (objectParam() == null)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 661)
						{
							if (num2 == 1642)
							{
								goto _goto_251;
							}
							goto case 420;
						}
						array8[_return_314] = 115;
						goto case 120;
					case 71:
						array8[10] = 108;
						goto case 88;
					case 69:
						if (intParam() != 4)
						{
							goto case 596;
						}
						goto case 12;
					case 12:
						num16 = intParam(new IntPtr(value));
						goto case 229;
					case 63:
						array5[25] = (byte)num8;
						num3 = 138;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 106;
					case 52:
						array8[6] = 105;
						num3 = 137;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 338;
					case 40:
						array5[0] = 89;
						goto case 633;
					case 37:
						byte_ = (byte[])objectParam(objectParam, intParam);
						goto case 234;
					case 30:
						num8 = 6;
						goto case 322;
					case 22:
						array5[8] = 100;
						num3 = 477;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 621;
					case 21:
						array5[28] = 135;
						num3 = 349;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 479;
					case 11:
						array5[18] = (byte)num8;
						goto case 273;
					case 6:
						array[num4 + 4] = array4[4];
						goto case 248;
					case 300:
						num3 = 264;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 543;
					case 44:
						voidParam(objectParam);
						num3 = 591;
						if (!boolParam())
						{
							continue;
						}
						goto case 79;
					case _return_314:
						num6 = 9;
						num = 96;
						break;
					case 24:
						array9[num14 + 2] = (byte)((num15 & 0xFF0000) >> 16);
						goto case 104;
					case 28:
						array5[3] = 123;
						goto case 240;
					case 53:
						array5[3] = (byte)num8;
						goto case 511;
					case 104:
						array9[num14 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
						num = 534;
						break;
					case 162:
						voidParam();
						num = 444;
						break;
					case 175:
						num8 = 244;
						num = 370;
						break;
					case 179:
						if (!boolParam(intptrParam(intptrParam(objectParam(objectParam())), "__", 10u), IntPtr.Zero))
						{
							num = 162;
							break;
						}
						goto _goto_252;
					case 189:
						flag = true;
						num = 278;
						break;
					case 205:
						array5[9] = (byte)num8;
						goto case 102;
					case 102:
						array5[10] = 101;
						num = 570;
						break;
					case 232:
						array3[15] = (byte)num5;
						num = 408;
						break;
					case 240:
						num8 = 240;
						num = 53;
						break;
					case 304:
						array[num6 + 3] = array4[3];
						goto case 298;
					case 305:
						num8 = 69;
						goto case 142;
					case 142:
						array5[22] = (byte)num8;
						goto case 341;
					case 310:
						array3[13] = (byte)num5;
						goto case 365;
					case 334:
						array5[9] = (byte)num8;
						num = 379;
						break;
					case 341:
						array5[22] = 83;
						goto case 574;
					case 365:
						num5 = 119;
						goto case 544;
					case 372:
						array5[8] = (byte)num8;
						num = 2;
						break;
					case 374:
						num8 = 167;
						num = 11;
						break;
					case 388:
						array12[3] = 74;
						goto case 190;
					case 190:
						array12[4] = 105;
						num = 468;
						break;
					case 391:
						array8[9] = 100;
						num = 71;
						break;
					case 398:
						num8 = 134;
						num = 588;
						break;
					case 79:
						voidParam(runtimemethodhandleParam(objectParam(objectParam)));
						goto case 64;
					case 64:
						voidParam(GetInternal_14.objectParam);
						num = 426;
						break;
					case 412:
						objectParam = new Hashtable(intParam(objectParam) + _return_314);
						goto case 245;
					case 245:
						@struct = default(AppStruct_964);
						goto case 416;
					case 416:
						@struct.byte_0 = new byte[_return_314] { 42 };
						goto case 469;
					case 422:
						voidParam(array7, 0, array7.Length);
						goto case 16;
					case 433:
						num8 = 152;
						num = 581;
						break;
					case 7:
					case 270:
						ptr = null;
						num = 136;
						break;
					case 460:
						num8 = 106;
						num = 353;
						break;
					case 469:
						@struct.boolParam = false;
						num = 428;
						break;
					case 477:
						num8 = 175;
						num = 126;
						break;
					case 500:
						enumerator = (IEnumerator)objectParam(objectParam(objectParam()));
						goto case 153;
					case 153:
						try
						{
							while (boolParam(enumerator))
							{
								while (true)
								{
									_goto_262:
									ProcessModule object_ = (ProcessModule)objectParam(enumerator);
									int num9 = _return_125;
									if (objectParam() != null)
									{
										goto _goto_256;
									}
									goto _goto_279;
									_goto_279:
									while (true)
									{
										switch (num9)
										{
										case 2:
											break;
										case 10:
											goto _goto_275;
										case 7:
											goto _goto_256;
										case 6:
											goto _goto_271;
										case 3:
											goto _goto_272;
										case _return_125:
											if (!boolParam(objectParam(objectParam(object_)), "clrjit.dll"))
											{
												goto _goto_269;
											}
											num9 = 7;
											if (boolParam())
											{
												continue;
											}
											goto _goto_275;
										default:
											goto _goto_261;
										case 8:
											goto _goto_262;
										case 0:
											goto _goto_269;
										case _return_314:
											boolParam = true;
											goto _goto_268;
										case 4:
											goto _goto_268;
										case 9:
											goto _goto_268;
										}
										break;
									}
									goto _goto_277;
									_goto_261:
									switch (num10)
									{
									case 998:
										break;
									default:
										goto _goto_268;
									case 18:
										goto _goto_269;
									}
									goto _goto_276;
									_goto_256:
									objectParam = new Version(intParam(objectParam(object_)), intParam(objectParam(object_)), intParam(objectParam(object_)), intParam(objectParam(object_)));
									goto _goto_271;
									_goto_271:
									objectParam = new Version(4, 0, 30319, 17020);
									goto _goto_272;
									_goto_272:
									objectParam = new Version(4, 0, 30319, 17921);
									num9 = 12;
									if (boolParam())
									{
										goto _goto_277;
									}
									goto _goto_279;
									_goto_277:
									if (boolParam(objectParam, objectParam))
									{
										goto _goto_275;
									}
									int num11 = 17;
									if (objectParam() == null)
									{
										num11 = 18;
									}
									num10 = num11;
									goto _goto_276;
									_goto_275:
									if (!boolParam(objectParam, objectParam))
									{
										break;
									}
									num9 = _return_314;
									if (objectParam() != null)
									{
										goto _goto_277;
									}
									goto _goto_279;
									_goto_276:
									num9 = num10;
									goto _goto_279;
									continue;
									_goto_269:
									break;
								}
								continue;
								_goto_268:
								break;
							}
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							int num12 = 6;
							if (objectParam() == null)
							{
								goto _goto_288;
							}
							goto _goto_290;
							_goto_288:
							if (disposable != null)
							{
								num12 = _return_314;
								if (!boolParam())
								{
									goto _goto_285;
								}
								goto _goto_290;
							}
							goto _goto_287;
							_goto_290:
							switch (num12)
							{
							case 0:
								break;
							default:
								goto _goto_285;
							case _return_314:
								goto _goto_289;
							case 2:
								goto _goto_287;
							}
							goto _goto_288;
							_goto_285:
							if (num13 != 990)
							{
								goto _goto_289;
							}
							num12 = num13;
							goto _goto_290;
							_goto_289:
							voidParam(disposable);
							num13 = 2;
							_goto_287:;
						}
						goto case 532;
					case 268:
						num8 = 112;
						num = 92;
						break;
					case 525:
						array3[_return_125] = 160;
						num = 339;
						break;
					case 13:
						array15[num51] ^= array6[num51];
						num = 530;
						break;
					case 535:
						intParam(intptr_, 4, 8, ref int_);
						goto case 480;
					case 421:
						array6[15] = array7[7];
						num = 422;
						break;
					case 538:
						array3[11] = 174;
						goto case 25;
					case 25:
						array3[11] = 92;
						num = 276;
						break;
					case 212:
						array[num4 + 2] = array4[2];
						goto case 598;
					case 544:
						array3[13] = (byte)num5;
						goto case 283;
					case 283:
						num5 = 93;
						goto case 18;
					case 18:
						array3[14] = (byte)num5;
						goto case 508;
					case 508:
						num5 = 79;
						num = 513;
						break;
					case 555:
						array6[9] = array7[4];
						goto case 257;
					case 257:
						array6[11] = array7[_return_125];
						num = 595;
						break;
					case 400:
					case 557:
						num31 = 7680;
						num = 628;
						break;
					case 565:
						if (intParam(intptr_, 4, 4, ref int_) == 0)
						{
							num = 535;
							break;
						}
						goto case 480;
					case 333:
						num5 = 130;
						num = 264;
						break;
					case 570:
						num8 = 148;
						num = 335;
						break;
					case 571:
						num7 = 255u;
						num = 105;
						break;
					case 574:
						array5[22] = 155;
						goto case 366;
					case 366:
						array5[22] = 167;
						goto case 376;
					case 376:
						array5[23] = 150;
						goto case 272;
					case 272:
						array5[23] = 94;
						num = 30;
						break;
					case 269:
						array[num4 + 7] = array4[7];
						goto case 298;
					case 598:
						array[num4 + 3] = array4[3];
						num = 6;
						break;
					case 278:
						intParam = intParam(objectParam);
						num = 37;
						break;
					case 511:
						array5[4] = 38;
						goto case 74;
					case 74:
						array5[4] = 124;
						goto case 281;
					case 281:
						array5[4] = 169;
						goto case 178;
					case 178:
						array5[4] = 61;
						num = 436;
						break;
					case 625:
						array[num6 + 2] = array4[2];
						num = 304;
						break;
					case 237:
						num5 = 137;
						goto case 238;
					case 238:
						array3[2] = (byte)num5;
						num = 396;
						break;
					case 171:
						if (boolParam(typeParam("System.Reflection.ReflectionContext", boolParam: false), null))
						{
							num = 500;
							break;
						}
						goto case 532;
					case 532:
						objectParam = new GetPublic_6((Stream)objectParam(GetInternal_14.objectParam, "hPgIOiZVZnG3C7Zie8im.JuPwLmZVCoPtPrXBZioU"));
						num = 446;
						break;
					case 227:
						num8 = 52;
						num = 550;
						break;
					case 634:
						array3[_return_314] = 108;
						goto case 401;
					case 401:
						num5 = 103;
						num = 413;
						break;
					case 480:
						voidParam(intptr_, intParam(objectParam));
						goto case 214;
					case 214:
						intParam(intptr_, 4, int_, ref int_);
						num = 389;
						break;
					case 61:
						array6[_return_125] = array7[2];
						goto case 549;
					case 549:
						array6[7] = array7[3];
						num = 555;
						break;
					case 16:
					case 545:
						num51 = 0;
						num = 258;
						break;
					case 298:
					case 638:
						voidParam(array, 0, intPtr4, array.Length);
						goto case 457;
					case 457:
						boolParam = false;
						goto case 97;
					case 97:
						intParam(new IntPtr(value), intParam(), 64, ref intParam);
						goto case 235;
					case 235:
						voidParam(new IntPtr(value), intPtr4);
						num = 524;
						break;
					case 345:
						num8 = 107;
						num = 87;
						break;
					case 325:
						value = longParam(_intptr_8);
						goto case 607;
					case 607:
					case 632:
						intptrParam(_intptr_8, 0);
						goto case 188;
					case 188:
						GetInternal_14.objectParam = new GetDelegateUint_4(uintParam);
						goto case 466;
					case 466:
						intPtr3 = IntPtr.Zero;
						num = 512;
						break;
					case 643:
						array[num4] = array2[0];
						num = 132;
						break;
					case 114:
						array3[12] = 148;
						goto case 249;
					case 249:
						array3[13] = 89;
						num = 407;
						break;
					case 640:
						intParam = intParam(_long_5);
						num = 93;
						break;
					case 93:
						array8 = new byte[12];
						goto case 450;
					case 484:
						intPtr2 = new IntPtr(_long_7 + intParam(objectParam) - num31);
						num = 164;
						break;
					case 450:
						array8[0] = 109;
						num = 661;
						break;
					case 648:
						num5 = 102;
						num = 130;
						break;
					case 543:
						try
						{
							enumerator = (IEnumerator)objectParam(objectParam(objectParam));
							int num80 = 0;
							if (!boolParam())
							{
								goto _goto_311;
							}
							goto _goto_293;
							_goto_311:
							if (num81 == 989)
							{
								num80 = num81;
								goto _goto_293;
							}
							goto _goto_310;
							_goto_293:
							switch (num80)
							{
							case 0:
								try
								{
									while (true)
									{
										int num82;
										if (!boolParam(enumerator))
										{
											num82 = _return_314;
											if (!boolParam())
											{
												goto _goto_302;
											}
											goto _goto_308;
										}
										goto _goto_303;
										_goto_306:
										num31 = 0;
										num83 = 12;
										goto _goto_302;
										_goto_303:
										intPtr = intptrParam((ProcessModule)objectParam(enumerator));
										num82 = 9;
										if (boolParam())
										{
											goto _goto_305;
										}
										goto _goto_308;
										_goto_308:
										switch (num82)
										{
										case 3:
											break;
										case 0:
											goto _goto_306;
										default:
											goto _goto_302;
										case 4:
											goto _goto_303;
										case 2:
											continue;
										case _return_314:
											goto _goto_304;
										}
										goto _goto_305;
										_goto_305:
										if (intPtr.ToInt64() != _long_5)
										{
											continue;
										}
										num82 = 7;
										if (boolParam())
										{
											goto _goto_306;
										}
										goto _goto_308;
										_goto_302:
										if (num83 == 12 || num83 != 992)
										{
											break;
										}
										num82 = num83;
										goto _goto_308;
										continue;
										_goto_304:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									int num84 = 3;
									if (objectParam() == null)
									{
										while (true)
										{
											switch (num84)
											{
											case 3:
												if (disposable == null)
												{
													break;
												}
												goto case _return_314;
											case _return_314:
												voidParam(disposable);
												num84 = 4;
												if (objectParam() != null)
												{
													continue;
												}
												break;
											default:
												if (num85 != 991)
												{
													goto case 3;
												}
												num84 = num85;
												continue;
											case 0:
											case 2:
												break;
											}
											break;
										}
									}
								}
								goto _goto_310;
							case _return_314:
								goto _goto_310;
							}
							goto _goto_311;
							_goto_310:;
						}
						catch
						{
							int num86 = _return_314;
							if (objectParam() != null)
							{
								while (true)
								{
									switch (num86)
									{
									default:
										if (num87 != 988)
										{
											break;
										}
										num86 = num87;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 635;
					case 635:
						objectParam = null;
						num = 336;
						break;
					case 546:
						num8 = 121;
						num = 441;
						break;
					case 2:
						num8 = 84;
						goto case 445;
					case 445:
						array5[9] = (byte)num8;
						goto case 586;
					case 586:
						array5[9] = 146;
						goto case 503;
					case 503:
						num8 = 113;
						goto case 91;
					case 91:
						array5[9] = (byte)num8;
						num = 340;
						break;
					case 323:
						array3[_return_125] = (byte)num5;
						num = 525;
						break;
					case 223:
						array5[10] = 94;
						goto case 119;
					case 119:
						num8 = 164;
						goto case 627;
					case 627:
						array5[10] = (byte)num8;
						goto case 572;
					case 572:
						num8 = 150;
						goto case 196;
					case 196:
						array5[11] = (byte)num8;
						num = 268;
						break;
					case 231:
						num15 = num33 ^ num49;
						goto case 75;
					case 75:
						array9[num14] = (byte)(num15 & 0xFF);
						goto case 313;
					case 313:
						array9[num14 + _return_314] = (byte)((num15 & 0xFF00) >> 8);
						num = 24;
						break;
					case 141:
						num66 = num53 % num32;
						goto case 108;
					case 108:
						num14 = num53 * 4;
						goto case 57;
					case 57:
						num52 = (uint)(num66 * 4);
						goto case 65;
					case 65:
						num34 = (uint)((array15[num52 + 3] << 24) | (array15[num52 + 2] << 16) | (array15[num52 + _return_314] << 8) | array15[num52]);
						num = 571;
						break;
					case 3:
						array[num4] = array4[0];
						goto case 167;
					case 167:
						array[num4 + _return_314] = array4[_return_314];
						num = 212;
						break;
					case 444:
						return;
					case 556:
						return;
					case 124:
						return;
					case 599:
						voidParam();
						return;
					case 442:
						return;
						_goto_252:
						if (intParam() == 4)
						{
							goto case 171;
						}
						goto case 532;
					}
					goto _goto_312;
					continue;
					_goto_251:
					break;
				}
				continue;
				_goto_312:
				break;
			}
		}
	}

	internal static object objectParam(object objectParam)
	{
		try
		{
			if (File.Exists(((Assembly)objectParam).Location))
			{
				return ((Assembly)objectParam).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)objectParam).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)objectParam).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(objectParam.GetType().GetProperty("Location").GetValue(objectParam, new object[0])
				.ToString()))
			{
				return objectParam.GetType().GetProperty("Location").GetValue(objectParam, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string stringParam);

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptrParam, string stringParam);

	private static IntPtr intptrParam(IntPtr intptrParam, object objectParam, uint uintParam)
	{
		if (objectParam == null)
		{
			objectParam = (GetDelegateIntptr_7)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptrParam(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(AppClass_968.boolParam(33555532)));
		}
		return objectParam(intptrParam, (string)objectParam, uintParam);
	}

	private static IntPtr intptrParam(IntPtr intptrParam, uint uintParam, uint uintParam, uint uintParam)
	{
		if (objectParam == null)
		{
			objectParam = (GetDelegateIntptr_8)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptrParam(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(AppClass_968.boolParam(33555533)));
		}
		return objectParam(intptrParam, uintParam, uintParam, uintParam);
	}

	private static int intParam(IntPtr intptrParam, IntPtr _intptr_126, [In][Out] byte[] byte_0, uint uintParam, out IntPtr intptrParam)
	{
		if (objectParam == null)
		{
			objectParam = (GetDelegateInt_9)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptrParam(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(AppClass_968.boolParam(33555534)));
		}
		return objectParam(intptrParam, _intptr_126, byte_0, uintParam, out intptrParam);
	}

	private static int intParam(IntPtr intptrParam, int intParam, int intParam, ref int intParam)
	{
		if (objectParam == null)
		{
			objectParam = (GetDelegateInt_10)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptrParam(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(AppClass_968.boolParam(33555535)));
		}
		return objectParam(intptrParam, intParam, intParam, ref intParam);
	}

	private static IntPtr intptrParam(uint uintParam, int intParam, uint uintParam)
	{
		if (objectParam == null)
		{
			objectParam = (GetDelegateIntptr_11)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptrParam(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(AppClass_968.boolParam(33555536)));
		}
		return objectParam(uintParam, intParam, uintParam);
	}

	private static int intParam(IntPtr intptrParam)
	{
		if (objectParam == null)
		{
			objectParam = (GetDelegateInt_12)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptrParam(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(AppClass_968.boolParam(33555537)));
		}
		return objectParam(intptrParam);
	}

	[SpecialName]
	private static IntPtr intptrParam()
	{
		if (_return_313 == IntPtr.Zero)
		{
			_return_313 = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return _return_313;
	}

	private static byte[] smethod_32(object objectParam)
	{
		using FileStream fileStream = new FileStream((string)objectParam, FileMode.Open, FileAccess.Read, FileShare.Read);
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

	internal static Stream streamParam()
	{
		return new MemoryStream();
	}

	internal static byte[] returnParam(object objectParam)
	{
		return ((MemoryStream)objectParam).ToArray();
	}

	private static byte[] smethod_35(object objectParam)
	{
		Stream stream = streamParam();
		SymmetricAlgorithm symmetricAlgorithm = symmetricalgorithmParam();
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
		cryptoStream.Write((byte[])objectParam, 0, ((Array)objectParam).Length);
		cryptoStream.Close();
		byte[] result = returnParam(stream);
		AppClass_967.boolParam();
		return result;
	}

	private byte[] intParam()
	{
		return null;
	}

	private byte[] intParam()
	{
		return null;
	}

	private byte[] voidParam()
	{
		return null;
	}

	private byte[] method_5()
	{
		return null;
	}

	private byte[] method_6()
	{
		return null;
	}

	private byte[] method_7()
	{
		return null;
	}

	internal byte[] method_8()
	{
		_ = "R7yJgtgiwTxYhJ98ODr".Length;
		return new byte[2] { _return_314, 2 };
	}

	internal byte[] method_9()
	{
		_ = "fF3JdJdCnaBNOPe56H3pBi".Length;
		return new byte[2] { _return_314, 2 };
	}

	internal byte[] method_10()
	{
		return null;
	}

	internal byte[] method_11()
	{
		return null;
	}

	internal static object objectParam(object objectParam)
	{
		return ((GetPublic_6)objectParam).streamParam();
	}

	internal static void voidParam(object objectParam, long longParam)
	{
		((Stream)objectParam).Position = longParam;
	}

	internal static long longParam(object objectParam)
	{
		return ((Stream)objectParam).Length;
	}

	internal static object objectParam(object objectParam, int intParam)
	{
		return ((GetPublic_6)objectParam).voidParam(intParam);
	}

	internal static void voidParam(object objectParam)
	{
		((GetPublic_6)objectParam).voidParam();
	}

	internal static void voidParam(object objectParam)
	{
		Array.Reverse((Array)objectParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).GetName();
	}

	internal static object objectParam(object objectParam)
	{
		return ((AssemblyName)objectParam).GetPublicKeyToken();
	}

	internal static object objectParam()
	{
		return symmetricalgorithmParam();
	}

	internal static void voidParam(object objectParam, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)objectParam).Mode = cipherMode_0;
	}

	internal static object objectParam(object objectParam, object objectParam, object objectParam)
	{
		return ((SymmetricAlgorithm)objectParam).CreateDecryptor((byte[])objectParam, (byte[])objectParam);
	}

	internal static object objectParam()
	{
		return streamParam();
	}

	internal static void voidParam(object objectParam, object objectParam, int intParam, int intParam)
	{
		((Stream)objectParam).Write((byte[])objectParam, intParam, intParam);
	}

	internal static void voidParam(object objectParam)
	{
		((CryptoStream)objectParam).FlushFinalBlock();
	}

	internal static object objectParam(object objectParam)
	{
		return returnParam(objectParam);
	}

	internal static void voidParam(object objectParam)
	{
		((Stream)objectParam).Close();
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).EntryPoint;
	}

	internal static bool boolParam(object objectParam, object objectParam)
	{
		return (MethodInfo)objectParam == (MethodInfo)objectParam;
	}

	internal static bool boolParam()
	{
		return null == null;
	}

	internal static object objectParam()
	{
		return null;
	}

	internal static void voidParam()
	{
		AppClass_967.boolParam();
	}

	internal static void voidParam(bool boolParam)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = boolParam;
	}

	internal static Type typeParam(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).Location;
	}

	internal static int intParam(object objectParam)
	{
		return ((string)objectParam).Length;
	}

	internal static object objectParam()
	{
		return SHA1.Create();
	}

	internal static object objectParam(object objectParam)
	{
		return CryptoConfig.MapNameToOID((string)objectParam);
	}

	internal static bool boolParam(object objectParam)
	{
		return File.Exists((string)objectParam);
	}

	internal static object objectParam(object objectParam, object objectParam)
	{
		return ((Assembly)objectParam).GetManifestResourceStream((string)objectParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((GetPublic_6)objectParam).streamParam();
	}

	internal static void voidParam(object objectParam, long longParam)
	{
		((Stream)objectParam).Position = longParam;
	}

	internal static long longParam(object objectParam)
	{
		return ((Stream)objectParam).Length;
	}

	internal static object objectParam(object objectParam, int intParam)
	{
		return ((GetPublic_6)objectParam).voidParam(intParam);
	}

	internal static object objectParam()
	{
		return symmetricalgorithmParam();
	}

	internal static void voidParam(object objectParam, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)objectParam).Mode = cipherMode_0;
	}

	internal static object objectParam(object objectParam, object objectParam, object objectParam)
	{
		return ((SymmetricAlgorithm)objectParam).CreateDecryptor((byte[])objectParam, (byte[])objectParam);
	}

	internal static object objectParam()
	{
		return streamParam();
	}

	internal static void voidParam(object objectParam, object objectParam, int intParam, int intParam)
	{
		((Stream)objectParam).Write((byte[])objectParam, intParam, intParam);
	}

	internal static void voidParam(object objectParam)
	{
		((CryptoStream)objectParam).FlushFinalBlock();
	}

	internal static object objectParam()
	{
		return Encoding.UTF8;
	}

	internal static object objectParam(object objectParam)
	{
		return returnParam(objectParam);
	}

	internal static object objectParam(object objectParam, object objectParam)
	{
		return ((Encoding)objectParam).GetString((byte[])objectParam);
	}

	internal static void voidParam(object objectParam, object objectParam)
	{
		((AsymmetricAlgorithm)objectParam).FromXmlString((string)objectParam);
	}

	internal static void voidParam(object objectParam)
	{
		((Stream)objectParam).Close();
	}

	internal static void voidParam(object objectParam)
	{
		((GetPublic_6)objectParam).voidParam();
	}

	internal static void voidParam(object objectParam, object objectParam, uint uintParam, object objectParam)
	{
		voidParam(objectParam, objectParam, uintParam, objectParam);
	}

	internal static ushort ushortParam(object objectParam)
	{
		return ((BinaryReader)objectParam).ReadUInt16();
	}

	internal static int intParam(object objectParam, object objectParam, int intParam, int intParam)
	{
		return ((Stream)objectParam).Read((byte[])objectParam, intParam, intParam);
	}

	internal static void voidParam(object objectParam, object objectParam, int intParam, int intParam)
	{
		voidParam(objectParam, objectParam, intParam, intParam);
	}

	internal static long longParam(object objectParam)
	{
		return ((Stream)objectParam).Position;
	}

	internal static uint uintParam(object objectParam)
	{
		return ((BinaryReader)objectParam).ReadUInt32();
	}

	internal static uint uintParam(uint uintParam, int intParam, long longParam, object objectParam)
	{
		return uintParam(uintParam, intParam, longParam, objectParam);
	}

	internal static long longParam(long longParam, long longParam)
	{
		return Math.Min(longParam, longParam);
	}

	internal static object objectParam(object objectParam, object objectParam, int intParam, int intParam)
	{
		return ((HashAlgorithm)objectParam).TransformFinalBlock((byte[])objectParam, intParam, intParam);
	}

	internal static object objectParam(object objectParam, int intParam)
	{
		return ((BinaryReader)objectParam).ReadBytes(intParam);
	}

	internal static void voidParam(object objectParam)
	{
		Array.Reverse((Array)objectParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((HashAlgorithm)objectParam).Hash;
	}

	internal static bool boolParam(object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return ((RSACryptoServiceProvider)objectParam).VerifyHash((byte[])objectParam, (string)objectParam, (byte[])objectParam);
	}

	internal static void voidParam(object objectParam)
	{
		((BinaryReader)objectParam).Close();
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).GetName();
	}

	internal static object objectParam(object objectParam)
	{
		return ((AssemblyName)objectParam).Name;
	}

	internal static object objectParam(object objectParam, object objectParam)
	{
		return (string)objectParam + (string)objectParam;
	}

	internal static bool boolParam()
	{
		return null == null;
	}

	internal static object objectParam()
	{
		return null;
	}

	static int intParam()
	{
		return _return_314;
	}

	internal static IntPtr intptrParam(IntPtr intptrParam, int intParam)
	{
		return Marshal.ReadIntPtr(intptrParam, intParam);
	}

	internal static int intParam(IntPtr intptrParam, int intParam)
	{
		return Marshal.ReadInt32(intptrParam, intParam);
	}

	internal static long longParam(IntPtr intptrParam, int intParam)
	{
		return Marshal.ReadInt64(intptrParam, intParam);
	}

	internal static void voidParam(IntPtr intptrParam, int intParam, IntPtr _intptr_126)
	{
		Marshal.WriteIntPtr(intptrParam, intParam, _intptr_126);
	}

	internal static void voidParam(IntPtr intptrParam, int intParam, int intParam)
	{
		Marshal.WriteInt32(intptrParam, intParam, intParam);
	}

	internal static void voidParam(IntPtr intptrParam, int intParam, long longParam)
	{
		Marshal.WriteInt64(intptrParam, intParam, longParam);
	}

	internal static IntPtr intptrParam(int intParam)
	{
		return Marshal.AllocCoTaskMem(intParam);
	}

	internal static void voidParam(object objectParam, int intParam, IntPtr intptrParam, int intParam)
	{
		Marshal.Copy((byte[])objectParam, intParam, intptrParam, intParam);
	}

	internal static void voidParam()
	{
		voidParam();
	}

	internal static object objectParam()
	{
		return Process.GetCurrentProcess();
	}

	internal static object objectParam(object objectParam)
	{
		return ((Process)objectParam).MainModule;
	}

	internal static IntPtr intptrParam(object objectParam)
	{
		return ((ProcessModule)objectParam).BaseAddress;
	}

	internal static IntPtr intptrParam(IntPtr intptrParam, object objectParam, uint uintParam)
	{
		return intptrParam(intptrParam, objectParam, uintParam);
	}

	internal static bool boolParam(IntPtr intptrParam, IntPtr _intptr_126)
	{
		return intptrParam != _intptr_126;
	}

	internal static void voidParam()
	{
		AppClass_967.boolParam();
	}

	internal static int intParam()
	{
		return IntPtr.Size;
	}

	internal static Type typeParam(object objectParam, bool boolParam)
	{
		return Type.GetType((string)objectParam, boolParam);
	}

	internal static bool boolParam(Type typeParam, Type typeParam)
	{
		return typeParam != typeParam;
	}

	internal static object objectParam(object objectParam)
	{
		return ((Process)objectParam).Modules;
	}

	internal static object objectParam(object objectParam)
	{
		return ((ReadOnlyCollectionBase)objectParam).GetEnumerator();
	}

	internal static object objectParam(object objectParam)
	{
		return ((IEnumerator)objectParam).Current;
	}

	internal static object objectParam(object objectParam)
	{
		return ((ProcessModule)objectParam).ModuleName;
	}

	internal static object objectParam(object objectParam)
	{
		return ((string)objectParam).ToLower();
	}

	internal static bool boolParam(object objectParam, object objectParam)
	{
		return (string)objectParam == (string)objectParam;
	}

	internal static object objectParam(object objectParam)
	{
		return ((ProcessModule)objectParam).FileVersionInfo;
	}

	internal static int intParam(object objectParam)
	{
		return ((FileVersionInfo)objectParam).ProductMajorPart;
	}

	internal static int intParam(object objectParam)
	{
		return ((FileVersionInfo)objectParam).ProductMinorPart;
	}

	internal static int intParam(object objectParam)
	{
		return ((FileVersionInfo)objectParam).ProductBuildPart;
	}

	internal static int intParam(object objectParam)
	{
		return ((FileVersionInfo)objectParam).ProductPrivatePart;
	}

	internal static bool boolParam(object objectParam, object objectParam)
	{
		return (Version)objectParam >= (Version)objectParam;
	}

	internal static bool boolParam(object objectParam, object objectParam)
	{
		return (Version)objectParam < (Version)objectParam;
	}

	internal static bool boolParam(object objectParam)
	{
		return ((IEnumerator)objectParam).MoveNext();
	}

	internal static void voidParam(object objectParam)
	{
		((IDisposable)objectParam).Dispose();
	}

	internal static object objectParam(object objectParam, object objectParam)
	{
		return ((Assembly)objectParam).GetManifestResourceStream((string)objectParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((GetPublic_6)objectParam).streamParam();
	}

	internal static void voidParam(object objectParam, long longParam)
	{
		((Stream)objectParam).Position = longParam;
	}

	internal static long longParam(object objectParam)
	{
		return ((Stream)objectParam).Length;
	}

	internal static object objectParam(object objectParam, int intParam)
	{
		return ((GetPublic_6)objectParam).voidParam(intParam);
	}

	internal static void voidParam(object objectParam)
	{
		Array.Reverse((Array)objectParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).GetName();
	}

	internal static object objectParam(object objectParam)
	{
		return ((AssemblyName)objectParam).GetPublicKeyToken();
	}

	internal static void voidParam(object objectParam, int intParam, int intParam)
	{
		Array.Clear((Array)objectParam, intParam, intParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).GetModules();
	}

	internal static IntPtr intptrParam(object objectParam)
	{
		return Marshal.GetHINSTANCE((Module)objectParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).Location;
	}

	internal static int intParam(object objectParam)
	{
		return ((string)objectParam).Length;
	}

	internal static int intParam(object objectParam)
	{
		return ((GetPublic_6)objectParam).intParam();
	}

	internal static object objectParam()
	{
		return symmetricalgorithmParam();
	}

	internal static void voidParam(object objectParam, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)objectParam).Mode = cipherMode_0;
	}

	internal static object objectParam(object objectParam, object objectParam, object objectParam)
	{
		return ((SymmetricAlgorithm)objectParam).CreateDecryptor((byte[])objectParam, (byte[])objectParam);
	}

	internal static void voidParam(object objectParam, object objectParam, int intParam, int intParam)
	{
		((Stream)objectParam).Write((byte[])objectParam, intParam, intParam);
	}

	internal static void voidParam(object objectParam)
	{
		((CryptoStream)objectParam).FlushFinalBlock();
	}

	internal static object objectParam(object objectParam)
	{
		return ((MemoryStream)objectParam).ToArray();
	}

	internal static void voidParam(object objectParam)
	{
		((Stream)objectParam).Close();
	}

	internal static void voidParam(object objectParam)
	{
		((GetPublic_6)objectParam).voidParam();
	}

	internal static int intParam(object objectParam)
	{
		return ((Process)objectParam).Id;
	}

	internal static IntPtr intptrParam(uint uintParam, int intParam, uint uintParam)
	{
		return intptrParam(uintParam, intParam, uintParam);
	}

	internal static object objectParam(int intParam)
	{
		return BitConverter.GetBytes(intParam);
	}

	internal static long longParam(object objectParam)
	{
		return ((Stream)objectParam).Position;
	}

	internal static void voidParam(IntPtr intptrParam, int intParam)
	{
		Marshal.WriteInt32(intptrParam, intParam);
	}

	internal static int intParam(IntPtr intptrParam)
	{
		return intParam(intptrParam);
	}

	internal static void voidParam(object objectParam, object objectParam, object objectParam)
	{
		((Hashtable)objectParam).Add(objectParam, objectParam);
	}

	internal static Type typeParam(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int intParam(long longParam)
	{
		return Convert.ToInt32(longParam);
	}

	internal static object objectParam()
	{
		return Encoding.UTF8;
	}

	internal static object objectParam(object objectParam, object objectParam)
	{
		return ((Encoding)objectParam).GetString((byte[])objectParam);
	}

	internal static bool boolParam(IntPtr intptrParam, IntPtr _intptr_126)
	{
		return intptrParam == _intptr_126;
	}

	internal static object objectParam(IntPtr intptrParam, Type typeParam)
	{
		return delegateParam(intptrParam, typeParam);
	}

	internal static IntPtr intptrParam(object objectParam)
	{
		return objectParam();
	}

	internal static int intParam(IntPtr intptrParam)
	{
		return Marshal.ReadInt32(intptrParam);
	}

	internal static long longParam(IntPtr intptrParam)
	{
		return Marshal.ReadInt64(intptrParam);
	}

	internal static IntPtr intptrParam(object objectParam)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)objectParam);
	}

	internal static int intParam(object objectParam)
	{
		return ((ProcessModule)objectParam).ModuleMemorySize;
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).EntryPoint;
	}

	internal static bool boolParam(object objectParam, object objectParam)
	{
		return (MethodInfo)objectParam != (MethodInfo)objectParam;
	}

	internal static object objectParam(object objectParam)
	{
		return ((Delegate)objectParam).Method;
	}

	internal static object objectParam(Type typeParam, object objectParam)
	{
		return Delegate.CreateDelegate(typeParam, (MethodInfo)objectParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((MethodBase)objectParam).GetParameters();
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).ManifestModule;
	}

	internal static ModuleHandle modulehandleParam(object objectParam)
	{
		return ((Module)objectParam).ModuleHandle;
	}

	internal static Type typeParam(object objectParam)
	{
		return objectParam.GetType();
	}

	internal static object objectParam(object objectParam, object objectParam)
	{
		return ((FieldInfo)objectParam).GetValue(objectParam);
	}

	internal static object objectParam(long longParam)
	{
		return BitConverter.GetBytes(longParam);
	}

	internal static void voidParam(object objectParam)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)objectParam);
	}

	internal static RuntimeMethodHandle runtimemethodhandleParam(object objectParam)
	{
		return ((MethodBase)objectParam).MethodHandle;
	}

	internal static void voidParam(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void voidParam(object objectParam, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)objectParam, runtimeFieldHandle_0);
	}

	internal static IntPtr intptrParam(IntPtr intptrParam, uint uintParam, uint uintParam, uint uintParam)
	{
		return intptrParam(intptrParam, uintParam, uintParam, uintParam);
	}

	internal static void voidParam(IntPtr intptrParam, IntPtr _intptr_126)
	{
		Marshal.WriteIntPtr(intptrParam, _intptr_126);
	}

	internal static bool boolParam()
	{
		return null == null;
	}

	internal static object objectParam()
	{
		return null;
	}
}
