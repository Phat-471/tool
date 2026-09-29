using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using ns61;
using ns62;
using ns63;

namespace ns64;

internal class GetStatic_4
{
	private enum AppEnum_970
	{

	}

	internal class GetStatic_1
	{
		private unsafe static uint uintParam(void* pVoid_0, uint uintParam)
		{
			return _return_4;
		}

		private unsafe static bool boolParam(void* pVoid_0, void* pVoid_1, uint uintParam)
		{
			return true;
		}

		private unsafe static void voidParam(void* pVoid_0, byte byteParam, uint uintParam)
		{
		}

		private unsafe static void voidParam(void* pVoid_0, void* pVoid_1, uint uintParam)
		{
		}

		private unsafe static void voidParam(byte* pByte_0, byte* pByte_1, uint uintParam)
		{
		}

		private static uint uintParam(object objectParam, uint uintParam, AppEnum_970 enum24_0)
		{
			return _return_4;
		}

		public static uint uintParam(object objectParam, uint uintParam)
		{
			return _return_4;
		}

		private static uint uintParam(object objectParam, uint uintParam, object objectParam)
		{
			return _return_4;
		}

		internal static object objectParam(object objectParam)
		{
			return null;
		}

		public static byte[] objectParam(object objectParam, uint uintParam)
		{
			return null;
		}

		static GetStatic_1()
		{
			AppClass_960.smethod_23();
		}
	}

	private static object objectParam;

	private static object objectParam;

	private static bool boolParam;

	private static bool boolParam;

	private static void uintParam()
	{
		int num = 157;
		byte[] array = default(byte[]);
		int num4 = default(int);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num15 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num33 = default(int);
		byte[] array7 = default(byte[]);
		uint num25 = default(uint);
		int num22 = default(int);
		int num31 = default(int);
		int num7 = default(int);
		int num26 = default(int);
		int num9 = default(int);
		uint num23 = default(uint);
		uint num12 = default(uint);
		int num13 = default(int);
		int num32 = default(int);
		uint num24 = default(uint);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		int num28 = default(int);
		int num30 = default(int);
		uint num10 = default(uint);
		AppClass_960.AppClass_965 object_ = default(AppClass_960.AppClass_965);
		byte[] array6 = default(byte[]);
		byte[] array5 = default(byte[]);
		int num14 = default(int);
		byte[] array8 = default(byte[]);
		uint num6 = default(uint);
		int num8 = default(int);
		uint num11 = default(uint);
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
					case 442:
						array[13] = (byte)num4;
						num3 = 182;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 407;
					case 407:
						num4 = 160;
						goto case 285;
					case 285:
						array[13] = (byte)num4;
						goto case 111;
					case 111:
						num4 = 30;
						num3 = 233;
						if (!boolParam())
						{
							continue;
						}
						goto case 410;
					case 410:
						array[13] = (byte)num4;
						num3 = 191;
						if (!boolParam())
						{
							continue;
						}
						goto case 396;
					case 396:
						num4 = 154;
						goto case 55;
					case 55:
						array[14] = (byte)num4;
						num3 = 287;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 272;
					case 440:
						array2[30] = 136;
						goto case 124;
					case 124:
						num5 = 137;
						num3 = 397;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 13;
					case 439:
						num5 = 116;
						num3 = 254;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 222;
					case 222:
						array2[21] = (byte)num5;
						goto case 333;
					case 333:
						num5 = 164;
						num3 = 257;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 340;
					case 340:
						array2[21] = (byte)num5;
						goto case 301;
					case 301:
						num5 = 89;
						num3 = 150;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 179;
					case 438:
						num4 = 132;
						goto case 192;
					case 192:
						array[8] = (byte)num4;
						goto case 91;
					case 91:
						array[9] = 166;
						num3 = 206;
						if (!boolParam())
						{
							continue;
						}
						goto case 236;
					case 236:
						num4 = 31;
						goto case 257;
					case 257:
						array[9] = (byte)num4;
						num3 = 302;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 368;
					case 368:
						array[9] = 215;
						goto case 383;
					case 383:
						num4 = 170;
						num3 = 43;
						if (!boolParam())
						{
							continue;
						}
						goto case 81;
					case 81:
						array[9] = (byte)num4;
						num3 = 445;
						if (!boolParam())
						{
							continue;
						}
						goto case 216;
					case 216:
						array[9] = 226;
						num3 = 104;
						if (boolParam())
						{
							continue;
						}
						goto case 365;
					case 365:
						array[14] = (byte)num4;
						goto case 107;
					case 107:
						array[14] = 166;
						num3 = 328;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 273;
					case 273:
						num4 = 23;
						goto case 367;
					case 367:
						array[14] = (byte)num4;
						num3 = 238;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 123;
					case 436:
						num5 = 221;
						goto case 322;
					case 322:
						array2[24] = (byte)num5;
						num3 = 195;
						if (boolParam())
						{
							continue;
						}
						goto case 273;
					case 435:
						array2[20] = (byte)num5;
						goto case 33;
					case 33:
						array2[20] = 138;
						goto case 392;
					case 392:
						num5 = 148;
						num3 = 152;
						if (!boolParam())
						{
							continue;
						}
						goto case 288;
					case 288:
						array2[20] = (byte)num5;
						goto case 233;
					case 233:
						array2[20] = 152;
						goto case 59;
					case 59:
						array2[20] = 152;
						num3 = 200;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 439;
					case 434:
						num15 = array4.Length / 4;
						num3 = 319;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 334;
					case 334:
						array3 = new byte[array4.Length];
						goto case 27;
					case 27:
						num33 = array7.Length / 4;
						num3 = 145;
						if (boolParam())
						{
							continue;
						}
						goto case 167;
					case 167:
						array2[5] = 203;
						num3 = 398;
						if (boolParam())
						{
							continue;
						}
						goto case 199;
					case 199:
						array2[28] = 53;
						num3 = 172;
						if (boolParam())
						{
							continue;
						}
						goto case 431;
					case 432:
						num5 = 159;
						goto case 331;
					case 331:
						array2[2] = (byte)num5;
						goto case 53;
					case 53:
						num5 = 146;
						goto case 323;
					case 323:
						array2[2] = (byte)num5;
						num3 = 383;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 151;
					case 151:
						num5 = 140;
						num3 = 50;
						if (boolParam())
						{
							continue;
						}
						goto case 333;
					case 429:
						array2[27] = (byte)num5;
						goto case 290;
					case 290:
						num5 = 102;
						num3 = 293;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 244;
					case 244:
						array2[27] = (byte)num5;
						goto case 427;
					case 427:
						num5 = 38;
						num3 = 364;
						if (boolParam())
						{
							continue;
						}
						goto case 199;
					case 425:
						num25 = _return_4;
						goto case 234;
					case 234:
						num22 = 0;
						num3 = 191;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 88;
					case 88:
						num5 = 58;
						num3 = 217;
						if (boolParam())
						{
							continue;
						}
						goto case 146;
					case 146:
						array2[16] = (byte)num5;
						goto case 388;
					case 388:
						array2[16] = 120;
						goto case 415;
					case 415:
						num5 = 24;
						num3 = 352;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 277;
					case 277:
					case 310:
						if (num31 >= num7)
						{
							num3 = 259;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 93;
						}
						goto case 341;
					case 93:
						num5 = 133;
						num3 = 426;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 269;
					case 269:
						array2[0] = (byte)num5;
						goto case 196;
					case 196:
						num5 = 79;
						num3 = 320;
						if (boolParam())
						{
							continue;
						}
						goto case 75;
					case 75:
						num4 = 85;
						goto case 346;
					case 346:
						array[12] = (byte)num4;
						goto case 36;
					case 36:
						num4 = 53;
						goto case 76;
					case 76:
						array[12] = (byte)num4;
						goto case 7;
					case 7:
						num4 = 143;
						num3 = 312;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 370;
					case 370:
						array[12] = (byte)num4;
						num3 = 158;
						if (!boolParam())
						{
							continue;
						}
						goto case 304;
					case 304:
						num4 = 52;
						num3 = 369;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 361;
					case 361:
						array[6] = 155;
						goto case 15;
					case 15:
						num4 = 100;
						goto case 312;
					case 312:
						array[6] = (byte)num4;
						num3 = 288;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 284;
					case 341:
						if (num31 > 0)
						{
							num3 = 134;
							if (objectParam() == null)
							{
								continue;
							}
							goto case 236;
						}
						goto case 441;
					case 424:
						array2[5] = 158;
						goto case 303;
					case 303:
						num5 = 122;
						num3 = 380;
						if (boolParam())
						{
							continue;
						}
						goto case 293;
					case 293:
						num5 = 158;
						goto case 152;
					case 152:
						array2[4] = (byte)num5;
						num3 = 187;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 131;
					case 131:
						num5 = 129;
						goto case 235;
					case 235:
						array2[4] = (byte)num5;
						goto case 231;
					case 231:
						num5 = 99;
						num3 = 391;
						if (boolParam())
						{
							continue;
						}
						goto case 150;
					case 150:
						array2[10] = 127;
						num3 = 105;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 40;
					case 40:
						array2[10] = 135;
						num3 = 116;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 256;
					case 256:
						array2[10] = 138;
						num3 = 175;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 47;
					case 423:
						num26++;
						goto case 205;
					case 203:
						if (num26 <= 0)
						{
							goto case 41;
						}
						num3 = 189;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 125;
					case 41:
						array3[num9 + num26] = (byte)((num23 & num12) >> num13);
						goto case 423;
					case 205:
					case 276:
						if (num26 < num7)
						{
							goto case 203;
						}
						goto case 163;
					case 125:
						array2[4] = (byte)num5;
						goto case 102;
					case 102:
						num5 = 83;
						num3 = 205;
						if (!boolParam())
						{
							continue;
						}
						goto case 44;
					case 44:
						array2[4] = (byte)num5;
						goto case 424;
					case 422:
						num4 = 111;
						goto case 110;
					case 110:
						array[4] = (byte)num4;
						num3 = 389;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 34;
					case 34:
						num4 = 16;
						num3 = 343;
						if (boolParam())
						{
							continue;
						}
						goto case 332;
					case 421:
						num5 = 100;
						num3 = 366;
						if (boolParam())
						{
							continue;
						}
						goto case 75;
					case 420:
						array2[13] = 120;
						num3 = 95;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 72;
					case 72:
						num4 = 172;
						goto case 399;
					case 399:
						array[11] = (byte)num4;
						goto case 356;
					case 356:
						array[11] = 130;
						num3 = 211;
						if (!boolParam())
						{
							continue;
						}
						goto case 417;
					case 419:
						array2[1] = (byte)num5;
						num3 = 227;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 315;
					case 418:
						array2[9] = 118;
						num3 = 130;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 390;
					case 390:
						num5 = 119;
						goto case 339;
					case 339:
						array2[9] = (byte)num5;
						num3 = 449;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 218;
					case 218:
						array2[9] = 209;
						goto case 267;
					case 267:
						num5 = 119;
						num3 = 254;
						if (!boolParam())
						{
							continue;
						}
						goto case 327;
					case 416:
						num5 = 170;
						goto case 73;
					case 73:
						array2[9] = (byte)num5;
						goto case 166;
					case 166:
						num5 = 40;
						num3 = 371;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 72;
					case 414:
						num32 = num22 % num33;
						num3 = 38;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 296;
					case 296:
						num9 = num22 * 4;
						goto case 18;
					case 18:
						num25 = (uint)(num32 * 4);
						num3 = 288;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 250;
					case 250:
						num24 = (uint)((array7[num25 + 3] << 24) | (array7[num25 + 2] << 16) | (array7[num25 + 1] << 8) | array7[num25]);
						goto case 215;
					case 215:
						num12 = 255u;
						goto case 139;
					case 139:
						num13 = 0;
						num3 = 329;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 242;
					case 413:
						num31 = 0;
						goto case 277;
					case 412:
						array[10] = 150;
						num3 = 111;
						if (!boolParam())
						{
							continue;
						}
						goto case 72;
					case 411:
						num4 = 61;
						num3 = 282;
						if (boolParam())
						{
							continue;
						}
						goto case 111;
					case 409:
						array2[24] = 82;
						num3 = 17;
						if (boolParam())
						{
							continue;
						}
						goto case 226;
					case 406:
						array2[13] = (byte)num5;
						goto case 89;
					case 89:
						num5 = 65;
						num3 = 103;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 228;
					case 228:
						array2[13] = (byte)num5;
						num3 = 126;
						if (!boolParam())
						{
							continue;
						}
						goto case 221;
					case 221:
						array2[14] = 155;
						goto case 60;
					case 60:
						array2[14] = 132;
						num3 = 181;
						if (boolParam())
						{
							continue;
						}
						goto case 95;
					case 95:
						num5 = 139;
						goto case 26;
					case 26:
						array2[13] = (byte)num5;
						goto case 99;
					case 99:
						num5 = 37;
						num3 = 294;
						if (boolParam())
						{
							continue;
						}
						goto case 334;
					case 405:
						try
						{
							voidParam(deflateStream, memoryStream);
							int num27 = 0;
							if (!boolParam())
							{
								goto _goto_10;
							}
							goto _goto_7;
							_goto_10:
							if (num28 == 988)
							{
								num27 = num28;
								goto _goto_7;
							}
							goto _goto_9;
							_goto_7:
							switch (num27)
							{
							case 0:
								goto _goto_9;
							}
							goto _goto_10;
							_goto_9:;
						}
						finally
						{
							if (deflateStream != null)
							{
								goto _goto_19;
							}
							int num29 = 1;
							if (boolParam())
							{
								goto _goto_20;
							}
							goto _goto_17;
							_goto_19:
							voidParam(deflateStream);
							num29 = 2;
							if (objectParam() != null)
							{
								goto _goto_18;
							}
							goto _goto_20;
							_goto_20:
							switch (num29)
							{
							case 0:
								goto _goto_19;
							case 1:
							case 2:
								goto _goto_17;
							}
							goto _goto_18;
							_goto_18:
							if (num30 != 990)
							{
								goto _goto_19;
							}
							num29 = num30;
							goto _goto_20;
							_goto_17:;
						}
						goto case 174;
					case 174:
						objectParam = objectParam(objectParam(memoryStream));
						goto case 38;
					case 38:
						voidParam(memoryStream);
						num3 = 335;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 119;
					case 119:
					case 223:
					case 313:
						objectParam = objectParam((Assembly)objectParam);
						num3 = 56;
						if (boolParam())
						{
							continue;
						}
						goto case 98;
					case 98:
						array[13] = (byte)num4;
						goto case 325;
					case 325:
						num4 = 115;
						goto case 442;
					case 404:
						num5 = 116;
						num3 = 305;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 177;
					case 403:
						array2[13] = (byte)num5;
						num3 = 270;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 420;
					case 402:
						array2[3] = (byte)num5;
						goto case 118;
					case 118:
						num5 = 118;
						num3 = 16;
						if (!boolParam())
						{
							continue;
						}
						goto case 345;
					case 345:
						array2[4] = (byte)num5;
						num3 = 194;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 293;
					case 401:
						num5 = 120;
						goto case 4;
					case 4:
						array2[1] = (byte)num5;
						goto case 136;
					case 136:
						array2[1] = 125;
						goto case 100;
					case 100:
						num5 = 98;
						num3 = 419;
						if (boolParam())
						{
							continue;
						}
						goto case 125;
					case 398:
						num5 = 117;
						goto case 186;
					case 186:
						array2[6] = (byte)num5;
						goto case 154;
					case 154:
						array2[6] = 86;
						goto case 88;
					case 394:
						array2[23] = 104;
						goto case 436;
					case 393:
						num26 = 0;
						goto case 205;
					case 391:
						array2[4] = (byte)num5;
						num3 = 58;
						if (boolParam())
						{
							continue;
						}
						goto case 4;
					case 387:
						array2[12] = 92;
						goto case 21;
					case 21:
						array2[12] = 221;
						goto case 210;
					case 210:
						num5 = 197;
						goto case 403;
					case 386:
						num5 = 141;
						num3 = 55;
						if (!boolParam())
						{
							continue;
						}
						goto case 35;
					case 35:
						array2[6] = (byte)num5;
						goto case 23;
					case 23:
						num5 = 209;
						num3 = 326;
						if (!boolParam())
						{
							continue;
						}
						goto case 188;
					case 188:
						array2[6] = (byte)num5;
						num3 = 204;
						if (boolParam())
						{
							continue;
						}
						goto case 88;
					case 385:
						array2[19] = 134;
						num3 = 140;
						if (boolParam())
						{
							continue;
						}
						goto case 340;
					case 384:
						array3[num9 + 2] = (byte)((num10 & 0xFF0000) >> 16);
						num3 = 362;
						if (boolParam())
						{
							continue;
						}
						goto case 157;
					case 157:
						if (boolParam)
						{
							num3 = 156;
							if (boolParam())
							{
								continue;
							}
							goto case 347;
						}
						goto case 1;
					case 347:
						num5 = 146;
						num3 = 6;
						if (boolParam())
						{
							continue;
						}
						goto case 336;
					case 336:
						num5 = 84;
						num3 = 132;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 190;
					case 1:
						object_ = new AppClass_960.AppClass_965((Stream)uintParam(voidParam(typeof(AppClass_960).TypeHandle).Assembly, AppClass_960.boolParam(0x2339C6FB ^ AppClass_031.class730_0.int_88)));
						goto case 246;
					case 246:
						uintParam(uintParam(object_), 0L);
						goto case 335;
					case 335:
						array6 = new byte[0];
						goto case 128;
					case 128:
						array5 = (byte[])objectParam(object_, (int)objectParam(uintParam(object_)));
						num3 = 284;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 279;
					case 279:
						array2 = new byte[32];
						num3 = 88;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 212;
					case 212:
						num5 = 55;
						num3 = 82;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 327;
					case 382:
						array[0] = (byte)num4;
						goto case 161;
					case 161:
						array[0] = 107;
						goto case 54;
					case 54:
						num4 = 15;
						num3 = 92;
						if (!boolParam())
						{
							continue;
						}
						goto case 20;
					case 20:
						array[0] = (byte)num4;
						num3 = 296;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 11;
					case 11:
						array[1] = 163;
						num3 = 132;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 107;
					case 381:
						array6 = array3;
						num3 = 164;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 20;
					case 380:
						array2[5] = (byte)num5;
						num3 = 29;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 278;
					case 278:
						num5 = 100;
						goto case 24;
					case 24:
						array2[5] = (byte)num5;
						goto case 167;
					case 379:
						array2[30] = 166;
						num3 = 440;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 380;
					case 378:
						array2[2] = 26;
						goto case 209;
					case 209:
						num5 = 34;
						goto case 178;
					case 178:
						array2[3] = (byte)num5;
						goto case 421;
					case 142:
						array7[num14] ^= array8[num14];
						goto case 87;
					case 87:
						num14++;
						goto case 255;
					case 255:
					case 377:
						if (num14 >= array8.Length)
						{
							num3 = 169;
							if (boolParam())
							{
								continue;
							}
							return;
						}
						goto case 142;
					case 376:
						array[12] = 125;
						goto case 75;
					case 375:
						array2[12] = (byte)num5;
						goto case 387;
					case 373:
						array2[15] = (byte)num5;
						goto case 84;
					case 84:
						array2[15] = 239;
						num3 = 395;
						if (boolParam())
						{
							continue;
						}
						goto case 53;
					case 372:
						num5 = 86;
						num3 = 248;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 300;
					case 300:
						array2[18] = (byte)num5;
						num3 = 193;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 355;
					case 355:
						num5 = 157;
						num3 = 43;
						if (!boolParam())
						{
							continue;
						}
						goto case 80;
					case 80:
						array2[18] = (byte)num5;
						goto case 86;
					case 86:
						num5 = 159;
						goto case 262;
					case 262:
						array2[18] = (byte)num5;
						num3 = 12;
						if (boolParam())
						{
							continue;
						}
						goto case 288;
					case 371:
						array2[9] = (byte)num5;
						num3 = 91;
						if (!boolParam())
						{
							continue;
						}
						goto case 418;
					case 366:
						array2[3] = (byte)num5;
						num3 = 184;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 162;
					case 162:
						array2[3] = 154;
						num3 = 49;
						if (boolParam())
						{
							continue;
						}
						goto case 154;
					case 364:
						array2[27] = (byte)num5;
						goto case 360;
					case 360:
						num5 = 154;
						num3 = 400;
						if (!boolParam())
						{
							continue;
						}
						goto case 281;
					case 281:
						array2[27] = (byte)num5;
						goto case 199;
					case 363:
						array2[25] = 121;
						goto case 112;
					case 112:
						array2[25] = 79;
						num3 = 353;
						if (!boolParam())
						{
							continue;
						}
						goto case 30;
					case 362:
						array3[num9 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
						num3 = 399;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 163;
					case 358:
						num10 = num11 ^ num6;
						goto case 28;
					case 28:
						array3[num9] = (byte)(num10 & 0xFF);
						num3 = 143;
						if (objectParam() == null)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 449)
						{
							goto _goto_21;
						}
						array[11] = 146;
						goto case 376;
					case 357:
						array2[7] = (byte)num5;
						num3 = 422;
						if (!boolParam())
						{
							continue;
						}
						goto case 243;
					case 354:
						array2[15] = (byte)num5;
						goto case 39;
					case 39:
						num5 = 84;
						goto case 373;
					case 350:
						num5 = 61;
						goto case 42;
					case 42:
						array2[24] = (byte)num5;
						num3 = 409;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 401;
					case 348:
						num5 = 130;
						num3 = 184;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 23;
					case 344:
						num5 = 110;
						goto case 37;
					case 37:
						array2[7] = (byte)num5;
						goto case 298;
					case 298:
						num5 = 98;
						goto case 321;
					case 321:
						array2[7] = (byte)num5;
						num3 = 266;
						if (!boolParam())
						{
							continue;
						}
						goto case 351;
					case 343:
						array[4] = (byte)num4;
						num3 = 102;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 122;
					case 122:
						num4 = 179;
						goto case 261;
					case 261:
						array[5] = (byte)num4;
						goto case 411;
					case 338:
						array2[14] = (byte)num5;
						num3 = 351;
						if (!boolParam())
						{
							continue;
						}
						goto case 187;
					case 187:
						num5 = 158;
						num3 = 64;
						if (boolParam())
						{
							continue;
						}
						goto case 125;
					case 330:
						num4 = 160;
						num3 = 359;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 380;
					case 329:
						if (num22 == num15 - 1)
						{
							goto case 14;
						}
						goto case 297;
					case 14:
						if (num7 > 0)
						{
							goto case 201;
						}
						goto case 297;
					case 201:
						num6 = _return_4;
						goto case 194;
					case 194:
						num11 += num24;
						goto case 413;
					case 297:
						num25 = (uint)num9;
						num3 = 18;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 289;
					case 289:
						num11 += num24;
						goto case 113;
					case 113:
						num6 = (uint)((array4[num25 + 3] << 24) | (array4[num25 + 2] << 16) | (array4[num25 + 1] << 8) | array4[num25]);
						num3 = 16;
						if (boolParam())
						{
							continue;
						}
						goto case 395;
					case 328:
						array2[31] = 143;
						goto case 46;
					case 46:
						array2[31] = 166;
						goto case 245;
					case 245:
						array7 = array2;
						num3 = 145;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 67;
					case 67:
						array = new byte[16];
						num3 = 182;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 167;
					case 326:
						array[0] = 87;
						num3 = 374;
						if (!boolParam())
						{
							continue;
						}
						goto case 5;
					case 5:
						num4 = 171;
						num3 = 112;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 382;
					case 320:
						array2[0] = (byte)num5;
						goto case 224;
					case 224:
						num5 = 217;
						goto case 133;
					case 133:
						array2[0] = (byte)num5;
						num3 = 96;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 247;
					case 317:
						array2[12] = (byte)num5;
						goto case 77;
					case 77:
						array2[12] = 129;
						num3 = 36;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 229;
					case 229:
						num5 = 121;
						num3 = 335;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 375;
					case 316:
						array[7] = 25;
						num3 = 425;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 214;
					case 214:
						array[8] = 166;
						num3 = 395;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 342;
					case 314:
						if (num8 != 1)
						{
							goto case 2;
						}
						goto case 129;
					case 2:
					case 63:
						objectParam = objectParam(objectParam(array6, _return_4));
						goto case 119;
					case 129:
						memoryStream = new MemoryStream();
						goto case 253;
					case 253:
						deflateStream = new DeflateStream(new MemoryStream(array6), CompressionMode.Decompress);
						goto case 405;
					case 309:
						num5 = 120;
						goto case 435;
					case 307:
						array2[23] = (byte)num5;
						num3 = 394;
						if (boolParam())
						{
							continue;
						}
						goto case 194;
					case 306:
						array[10] = (byte)num4;
						goto case 275;
					case 275:
						num4 = 161;
						num3 = 225;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 162;
					case 305:
						num24 = _return_4;
						num3 = 0;
						if (boolParam())
						{
							continue;
						}
						goto case 108;
					case 108:
						if (num22 == num15 - 1)
						{
							num3 = 74;
							if (boolParam())
							{
								continue;
							}
							goto case 15;
						}
						goto case 358;
					case 302:
						array2[17] = 58;
						num3 = 175;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 70;
					case 70:
						array2[18] = 129;
						num3 = 248;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 372;
					case 299:
						num23 = num11 ^ num6;
						num3 = 393;
						if (boolParam())
						{
							continue;
						}
						goto case 291;
					case 291:
						array2[2] = 84;
						goto case 378;
					case 191:
					case 295:
						if (num22 >= num15)
						{
							num = 381;
							break;
						}
						goto case 414;
					case 294:
						array2[13] = (byte)num5;
						goto case 138;
					case 138:
						num5 = 179;
						num3 = 406;
						if (boolParam())
						{
							continue;
						}
						goto case 181;
					case 181:
						num5 = 133;
						goto case 338;
					case 292:
						array2[23] = 118;
						goto case 135;
					case 135:
						array2[23] = 154;
						num3 = 286;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 362;
					case 287:
						num4 = 90;
						goto case 71;
					case 71:
						array[14] = (byte)num4;
						num3 = 61;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 144;
					case 286:
						num5 = 107;
						goto case 307;
					case 283:
						objectParam = objectParam(array6);
						num3 = 119;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 216;
					case 282:
						array[5] = (byte)num4;
						goto case 3;
					case 3:
						num4 = 161;
						goto case 105;
					case 105:
						array[5] = (byte)num4;
						num3 = 271;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 252;
					case 271:
						num4 = 22;
						goto case 248;
					case 248:
						array[3] = (byte)num4;
						goto case 330;
					case 270:
						array[10] = 129;
						goto case 227;
					case 227:
						array[10] = 151;
						goto case 141;
					case 141:
						array[10] = 99;
						num3 = 412;
						if (boolParam())
						{
							continue;
						}
						goto default;
					case 268:
						if (num7 > 0)
						{
							num3 = 240;
							if (boolParam())
							{
								continue;
							}
							goto case 288;
						}
						goto case 425;
					case 266:
						array2[6] = 187;
						goto case 386;
					case 263:
						array2[28] = (byte)num5;
						num3 = 147;
						if (boolParam())
						{
							continue;
						}
						goto case 335;
					case 260:
						array2[8] = (byte)num5;
						num3 = 170;
						if (boolParam())
						{
							continue;
						}
						goto case 190;
					case 16:
					case 259:
					{
						uint num16 = num11;
						num11 = 255u;
						uint num17 = 1257709153u;
						uint num18 = 807144328u;
						uint num19 = 1022397983u;
						uint num20 = num16;
						num17 = 165448209u;
						num18 = 696972267u;
						uint num21 = 1022397983u;
						num19 = 958800974u;
						if (num20 == 0)
						{
							num20--;
						}
						num21 = num17 / num20 + num20;
						num20 = num17 - num17 + num21 + num17;
						num20 ^= num20 << 7;
						num20 += num18;
						num20 ^= num20 >> 1;
						num20 += num19;
						num20 ^= num20 << 25;
						num20 += num20;
						num20 = (((num19 << 3) + num19) ^ num19) + num20;
						num11 = num16 + (uint)(double)num20;
						goto case 108;
					}
					case 258:
						num5 = 171;
						goto case 117;
					case 117:
						array2[29] = (byte)num5;
						num3 = 47;
						if (boolParam())
						{
							continue;
						}
						goto case 175;
					case 175:
						array2[10] = 160;
						goto case 238;
					case 238:
						num5 = 103;
						goto case 90;
					case 90:
						array2[10] = (byte)num5;
						num3 = 116;
						if (boolParam())
						{
							continue;
						}
						goto case 398;
					case 254:
						num5 = 123;
						num3 = 354;
						if (boolParam())
						{
							continue;
						}
						goto case 12;
					case 12:
						array2[18] = 144;
						goto case 385;
					case 251:
						array2[22] = 175;
						num3 = 97;
						if (!boolParam())
						{
							continue;
						}
						goto case 292;
					case 249:
						num7 = array4.Length % 4;
						num3 = 356;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 434;
					case 240:
						num15++;
						goto case 425;
					case 239:
						array2[11] = 153;
						num3 = 438;
						if (!boolParam())
						{
							continue;
						}
						goto case 19;
					case 19:
						num5 = 73;
						goto case 171;
					case 171:
						array2[11] = (byte)num5;
						goto case 219;
					case 219:
						array2[12] = 160;
						num3 = 220;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 235;
					case 225:
						array[10] = (byte)num4;
						goto case 270;
					case 220:
						num5 = 106;
						goto case 317;
					case 217:
						array2[6] = (byte)num5;
						goto case 266;
					case 213:
						num14 = 0;
						goto case 255;
					case 211:
						array2[7] = (byte)num5;
						num3 = 344;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 282;
					case 208:
						array2[21] = (byte)num5;
						num3 = 31;
						if (boolParam())
						{
							continue;
						}
						goto case 258;
					case 204:
						num5 = 143;
						num3 = 211;
						if (boolParam())
						{
							continue;
						}
						goto case 381;
					case 200:
						array2[25] = (byte)num5;
						num3 = 230;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 363;
					case 198:
						array2[27] = 134;
						goto case 10;
					case 10:
						num5 = 56;
						num3 = 284;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 429;
					case 197:
						array[7] = 122;
						goto case 83;
					case 83:
						array[7] = 132;
						num3 = 316;
						if (boolParam())
						{
							continue;
						}
						goto case 36;
					case 193:
						array2[28] = (byte)num5;
						goto case 109;
					case 109:
						num5 = 253;
						goto case 263;
					case 189:
						num12 <<= 8;
						goto case 79;
					case 79:
						num13 += 8;
						num3 = 41;
						if (boolParam())
						{
							continue;
						}
						goto case 406;
					case 184:
						array2[17] = (byte)num5;
						goto case 302;
					case 182:
						array[0] = 91;
						num3 = 312;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 326;
					case 172:
						num5 = 144;
						goto case 193;
					case 169:
						array4 = array5;
						goto case 249;
					case 168:
						array2[30] = 186;
						goto case 159;
					case 159:
						num5 = 115;
						num3 = 24;
						if (!boolParam())
						{
							continue;
						}
						goto case 144;
					case 165:
						array2[22] = 38;
						num3 = 209;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 251;
					case 164:
						if (num8 != 0)
						{
							goto case 314;
						}
						goto case 283;
					case 160:
						num5 = 122;
						goto case 208;
					case 158:
						num5 = 102;
						num3 = 200;
						if (boolParam())
						{
							continue;
						}
						goto case 73;
					case 155:
						array2[24] = 86;
						num3 = 196;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 120;
					case 120:
						array2[24] = 210;
						num3 = 350;
						if (boolParam())
						{
							continue;
						}
						goto case 187;
					case 153:
						array2[19] = 202;
						goto case 309;
					case 145:
						num11 = _return_4;
						goto case 305;
					case 143:
						array3[num9 + 1] = (byte)((num10 & 0xFF00) >> 8);
						goto case 384;
					case 140:
						num5 = 128;
						goto case 101;
					case 101:
						array2[19] = (byte)num5;
						goto case 115;
					case 115:
						array2[19] = 112;
						num3 = 32;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 53;
					case 137:
						num8 = 1;
						goto case 213;
					case 130:
						num4 = 153;
						goto case 98;
					case 116:
						array2[11] = 119;
						num3 = 197;
						if (!boolParam())
						{
							continue;
						}
						goto case 239;
					case 114:
						array[6] = 156;
						num3 = 361;
						if (boolParam())
						{
							continue;
						}
						goto case 103;
					case 103:
						array2[31] = 125;
						num3 = 328;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 349;
					case 104:
						num4 = 16;
						num3 = 38;
						if (!boolParam())
						{
							continue;
						}
						goto case 306;
					case 97:
						array2[3] = (byte)num5;
						goto case 336;
					case 92:
						array[8] = (byte)num4;
						goto case 438;
					case 85:
						array2[26] = 72;
						goto case 198;
					case 82:
						array2[0] = (byte)num5;
						goto case 93;
					case 74:
						if (num7 <= 0)
						{
							goto case 358;
						}
						num3 = 125;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 299;
					case 69:
						array2[17] = (byte)num5;
						goto case 22;
					case 22:
						num5 = 112;
						num3 = 176;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 421;
					case 68:
						num5 = 84;
						num3 = 368;
						if (objectParam() != null)
						{
							continue;
						}
						goto case 69;
					case 66:
						array2[19] = 101;
						goto case 153;
					case 64:
						array2[15] = (byte)num5;
						goto case 254;
					case 62:
						num5 = 233;
						goto case 260;
					case 61:
						num4 = 85;
						num3 = 365;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 391;
					case 58:
						num5 = 154;
						num3 = 125;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 89;
					case 51:
						array[6] = (byte)num4;
						goto case 114;
					case 49:
						num5 = 89;
						num3 = 97;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 322;
					case 32:
						array2[19] = 100;
						goto case 66;
					case 31:
						array2[21] = 102;
						goto case 404;
					case 29:
						array2[5] = 118;
						goto case 278;
					case 25:
						array[3] = (byte)num4;
						goto case 271;
					case 17:
						num5 = 147;
						num3 = 265;
						if (boolParam())
						{
							continue;
						}
						goto case 265;
					case 6:
						array2[31] = (byte)num5;
						num3 = 103;
						if (objectParam() == null)
						{
							continue;
						}
						goto case 285;
					case 0:
						num6 = _return_4;
						goto case 268;
					case 50:
						array2[2] = (byte)num5;
						num = 291;
						break;
					case 65:
						array[1] = 90;
						goto case 13;
					case 96:
						num5 = 217;
						goto case 180;
					case 106:
						num4 = 130;
						goto case 242;
					case 132:
						array[1] = 97;
						goto case 48;
					case 48:
						array[1] = 126;
						num = 65;
						break;
					case 134:
						num6 <<= 8;
						goto case 441;
					case 147:
						array2[29] = 114;
						goto case 324;
					case 170:
						num5 = 103;
						goto case 433;
					case 173:
						array2[25] = 112;
						goto case 247;
					case 176:
						array2[17] = (byte)num5;
						num = 348;
						break;
					case 180:
						array2[1] = (byte)num5;
						num = 401;
						break;
					case 195:
						array2[24] = 135;
						num = 155;
						break;
					case 265:
						array2[25] = (byte)num5;
						num = 158;
						break;
					case 252:
						num4 = 132;
						num = 51;
						break;
					case 144:
						array2[30] = (byte)num5;
						num = 379;
						break;
					case 319:
						num4 = 101;
						goto case 127;
					case 127:
						array[7] = (byte)num4;
						num = 197;
						break;
					case 247:
						num5 = 235;
						goto case 280;
					case 280:
						array2[26] = (byte)num5;
						goto case 389;
					case 324:
						array2[29] = 161;
						num = 258;
						break;
					case 342:
						array[8] = 226;
						goto case 148;
					case 148:
						array[8] = 114;
						goto case 52;
					case 52:
						num4 = 118;
						num = 92;
						break;
					case 351:
						num5 = 159;
						num = 357;
						break;
					case 352:
						array2[16] = (byte)num5;
						num = 68;
						break;
					case 243:
						array2[7] = 63;
						goto case 408;
					case 359:
						array[3] = (byte)num4;
						goto case 185;
					case 185:
						num4 = 151;
						goto case 226;
					case 30:
						array2[25] = 30;
						num = 173;
						break;
					case 369:
						array[12] = (byte)num4;
						num = 272;
						break;
					case 190:
						array2[3] = (byte)num5;
						goto case 318;
					case 318:
						num5 = 239;
						num = 402;
						break;
					case 389:
						array2[26] = 28;
						goto case 428;
					case 395:
						num5 = 204;
						goto case 126;
					case 126:
						array2[16] = (byte)num5;
						goto case 202;
					case 202:
						num5 = 179;
						num = 146;
						break;
					case 397:
						array2[30] = (byte)num5;
						goto case 230;
					case 230:
						array2[31] = 86;
						num = 347;
						break;
					case 177:
						array2[22] = (byte)num5;
						num = 165;
						break;
					case 408:
						num5 = 101;
						goto case 349;
					case 349:
						array2[8] = (byte)num5;
						goto case 400;
					case 400:
						array2[8] = 96;
						goto case 311;
					case 311:
						num5 = 85;
						goto case 430;
					case 226:
						array[4] = (byte)num4;
						num = 106;
						break;
					case 242:
						array[4] = (byte)num4;
						num = 422;
						break;
					case 327:
						array2[10] = (byte)num5;
						num = 150;
						break;
					case 315:
						num5 = 109;
						goto case 353;
					case 353:
						array2[1] = (byte)num5;
						goto case 332;
					case 417:
						num4 = 144;
						goto case 337;
					case 337:
						array[11] = (byte)num4;
						goto case 78;
					case 78:
						array[11] = 147;
						goto case 8;
					case 8:
						array[11] = 79;
						num = 119;
						if (objectParam() == null)
						{
							num = 449;
						}
						break;
					case 332:
						array2[1] = 89;
						num = 432;
						break;
					case 163:
					case 237:
						num22++;
						num = 295;
						break;
					case 47:
						array2[29] = 88;
						goto case 121;
					case 121:
						array2[29] = 241;
						num = 168;
						break;
					case 284:
						array[6] = 135;
						num = 319;
						break;
					case 426:
						array[2] = 72;
						goto case 274;
					case 274:
						num4 = 89;
						goto case 264;
					case 264:
						array[2] = (byte)num4;
						goto case 43;
					case 43:
						array[2] = 107;
						goto case 149;
					case 149:
						array[2] = 201;
						goto case 374;
					case 374:
						num4 = 132;
						num = 25;
						break;
					case 428:
						array2[26] = 170;
						goto case 9;
					case 9:
						num5 = 99;
						goto case 94;
					case 94:
						array2[26] = (byte)num5;
						goto case 57;
					case 57:
						array2[26] = 113;
						num = 85;
						break;
					case 430:
						array2[8] = (byte)num5;
						num = 62;
						break;
					case 433:
						array2[9] = (byte)num5;
						num = 416;
						break;
					case 123:
						array[15] = 182;
						goto case 183;
					case 183:
						num4 = 144;
						goto case 206;
					case 206:
						array[15] = (byte)num4;
						goto case 232;
					case 232:
						array[15] = 128;
						goto case 308;
					case 308:
						num4 = 190;
						goto case 207;
					case 207:
						array[15] = (byte)num4;
						goto case 437;
					case 437:
						array8 = array;
						num = 137;
						break;
					case 179:
						array2[21] = (byte)num5;
						goto case 241;
					case 241:
						array2[21] = 139;
						num = 160;
						break;
					case 13:
						array[2] = 157;
						num = 426;
						break;
					case 441:
						num6 |= array4[array4.Length - (1 + num31)];
						goto case 431;
					case 431:
						num31++;
						num = 277;
						break;
					case 272:
						array[13] = 136;
						num = 130;
						break;
					case 56:
						boolParam = true;
						return;
					case 45:
					case 156:
						return;
					}
					goto _goto_22;
					continue;
					_goto_21:
					break;
				}
				if (num2 != 1430)
				{
					return;
				}
				continue;
				_goto_22:
				break;
			}
		}
	}

	internal static string[] boolParam(object objectParam)
	{
		if ((Assembly)objectParam == Type.GetTypeFromHandle(AppClass_968.uintParam(33555541)).Assembly)
		{
			if (!boolParam)
			{
				uintParam();
			}
			List<string> list = new List<string>();
			list.AddRange(((Assembly)objectParam).GetManifestResourceNames());
			list.AddRange(((Assembly)objectParam).GetManifestResourceNames());
			return list.ToArray();
		}
		return ((Assembly)objectParam).GetManifestResourceNames();
	}

	private static Assembly voidParam(object objectParam, object objectParam)
	{
		if (!boolParam)
		{
			uintParam();
		}
		string name = ((ResolveEventArgs)objectParam).Name;
		int num = 0;
		while (true)
		{
			if (num < ((Array)objectParam).Length)
			{
				if ((string)((object[])objectParam)[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (Assembly)objectParam;
	}

	public GetStatic_4()
	{
		AppDomain.CurrentDomain.ResourceResolve += voidParam;
		AppClass_967.uintParam();
	}

	internal static void voidParam()
	{
		if (!boolParam)
		{
			boolParam = true;
			new GetStatic_4();
		}
	}

	static GetStatic_4()
	{
		objectParam = new string[0];
		objectParam = null;
		boolParam = false;
		boolParam = false;
	}

	internal static Type voidParam(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object uintParam(object objectParam, object objectParam)
	{
		return ((Assembly)objectParam).GetManifestResourceStream((string)objectParam);
	}

	internal static object uintParam(object objectParam)
	{
		return ((AppClass_960.AppClass_965)objectParam).method_0();
	}

	internal static void uintParam(object objectParam, long longParam)
	{
		((Stream)objectParam).Position = longParam;
	}

	internal static long objectParam(object objectParam)
	{
		return ((Stream)objectParam).Length;
	}

	internal static object objectParam(object objectParam, int intParam)
	{
		return ((AppClass_960.AppClass_965)objectParam).method_1(intParam);
	}

	internal static object objectParam(object objectParam)
	{
		return GetStatic_1.objectParam(objectParam);
	}

	internal static void voidParam(object objectParam, object objectParam)
	{
		((Stream)objectParam).CopyTo((Stream)objectParam);
	}

	internal static void voidParam(object objectParam)
	{
		((IDisposable)objectParam).Dispose();
	}

	internal static object objectParam(object objectParam)
	{
		return ((MemoryStream)objectParam).ToArray();
	}

	internal static void voidParam(object objectParam)
	{
		((Stream)objectParam).Dispose();
	}

	internal static object objectParam(object objectParam, uint uintParam)
	{
		return GetStatic_1.objectParam(objectParam, uintParam);
	}

	internal static object objectParam(object objectParam)
	{
		return ((Assembly)objectParam).GetManifestResourceNames();
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
