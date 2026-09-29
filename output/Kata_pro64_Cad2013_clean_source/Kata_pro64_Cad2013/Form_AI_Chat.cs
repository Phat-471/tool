using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

[DesignerGenerated]
public class Form_AI_Chat : UserControl
{
	private struct Xb2eyJDOPFSYmadCTcVO
	{
		public int fEoDO11iH9A;

		public int J4kDO0KX4ti;

		public int pPdDOmIXi58;

		public int IstDOKrk5yb;
	}

	private enum zvWWXkDOfGXY7XRTqyWH
	{

	}

	private enum rD8n9QDOW3NADCnteZvf
	{

	}

	private class XneemADOvJ58IcSa9gII : AI_ChatGPTWebRequest
	{
		[CompilerGenerated]
		private bool kCCDOMZstDr;

		[CompilerGenerated]
		private string TjVDO7oRWFN;

		internal static object CkuLJXT9MkwEiWWTXdp7;

		[SpecialName]
		[CompilerGenerated]
		public bool o6HDOruZimB()
		{
			return true;
		}

		[SpecialName]
		[CompilerGenerated]
		public void rncDOllLXW8(bool bool_0)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public string UemDOSaiftx()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void TZoDOdw2eW9(string string_0)
		{
		}

		static XneemADOvJ58IcSa9gII()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 0:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 3;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_58783c6b9b814700822d1019a7acc9a4 == 0)
							{
								continue;
							}
							return;
						default:
							if (num2 != 9)
							{
								goto end_IL_004d;
							}
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_a50c1cb7e05c492e991b1bdcba875651 != 0)
							{
								continue;
							}
							goto case 0;
						case 1:
							break;
						case 2:
							return;
						}
						goto end_IL_006d;
						continue;
						end_IL_004d:
						break;
					}
					continue;
					end_IL_006d:
					break;
				}
				while (num2 == 990);
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c57d245498d44fafb6366861203ffcfd == 0)
				{
					num = 3;
				}
			}
		}

		internal static bool hO2w9YT97DE4yNA0m53h()
		{
			return true;
		}

		internal static XneemADOvJ58IcSa9gII dNpsLfT9EbbSZJ731FXr()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_280_btnSend_Click : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal Form_AI_Chat _0024VB_0024Me;

		internal Func<string> _0024VB_0024ResumableLocal_getDisplayedElapsed_00240;

		internal string _0024VB_0024ResumableLocal_aiDisplayName_00241;

		internal Task<AIChatResult> _0024VB_0024ResumableLocal_executeTask_00242;

		internal _Closure_0024__280_002D2 _0024VB_0024ResumableLocal__0024VB_0024Closure__00243;

		internal Task<AIChatResult> _0024VB_0024ResumableLocal_executeTask_00244;

		internal _Closure_0024__280_002D3 _0024VB_0024ResumableLocal__0024VB_0024Closure__00245;

		internal Task<AIChatResult> _0024VB_0024ResumableLocal_executeTask_00246;

		internal _Closure_0024__280_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__00247;

		internal bool _0024VB_0024ResumableLocal_keepBusyForCodex_00248;

		internal string _0024VB_0024ResumableLocal_oldPromptLabel_00249;

		internal string _0024VB_0024ResumableLocal_oldBtnText_002410;

		internal TaskAwaiter _0024A0;

		internal TaskAwaiter<AIChatResult> _0024A1;

		internal static object SIXfh5T9sn7XoluiSim7;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_280_btnSend_Click()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_25efeca4a94a44938c6f287ee921250e == 0)
							{
								continue;
							}
							goto default;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 2;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0054;
								}
								goto case 0;
							}
							return;
						case 2:
							break;
						}
						goto end_IL_0067;
						continue;
						end_IL_0054:
						break;
					}
					continue;
					end_IL_0067:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_74fd3f679d7f4193893763ebe442ebc5 != 0)
				{
					num = 5;
				}
			}
		}

		internal static bool BmOZZrT9JxSjPebDdeL0()
		{
			return true;
		}

		internal static object ubDqfRT9edHFcKffKJje()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_323_btnVoice_MouseUp : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal MouseEventArgs _0024VB_0024Local_e;

		internal Form_AI_Chat _0024VB_0024Me;

		internal TaskAwaiter _0024A0;

		internal static object bI5idMT9QweaRrm0lCVH;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_323_btnVoice_MouseUp()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
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
						case 0:
							do
							{
								bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
								num3 = 1;
							}
							while (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 != 0);
							continue;
						default:
							do
							{
								switch (num2)
								{
								case 9:
									break;
								case 990:
									goto end_IL_0049;
								default:
									goto end_IL_0069;
								}
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 0;
							}
							while (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_4303c5f248054e83a5686966604b55b3 == 0);
							continue;
						case 2:
							goto end_IL_0069;
						case 1:
							return;
							end_IL_0049:
							break;
						}
						break;
					}
					continue;
					end_IL_0069:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
			}
		}

		internal static bool L0k6QdT9AkHGUuvI2d5p()
		{
			return true;
		}

		internal static object ssNlPeT9HnmESDRrGY1I()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_325_btnVoiceCommand_MouseUp : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal MouseEventArgs _0024VB_0024Local_e;

		internal Form_AI_Chat _0024VB_0024Me;

		internal TaskAwaiter _0024A0;

		private static object PVdbdhT9LaWyKefBRckv;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_325_btnVoiceCommand_MouseUp()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
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
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_57bb817da9f045ada4d7d6d082ce52c4 == 0)
							{
								continue;
							}
							goto case 1;
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 3;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_02eb9f97d81c4e8f82591f5f747031ca != 0)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0053;
								}
								goto case 2;
							}
							return;
						case 0:
							break;
						}
						goto end_IL_0066;
						continue;
						end_IL_0053:
						break;
					}
					continue;
					end_IL_0066:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
			}
		}

		internal static bool BGMTWrT92aOC4KGwIman()
		{
			return true;
		}

		internal static object PmTLwmT9qAD8VcKaggdf()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_327_StopVoiceCaptureAsync : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder _0024Builder;

		internal Form_AI_Chat _0024VB_0024Me;

		internal bool _0024VB_0024ResumableLocal_isMbkcVoice_00240;

		internal _Closure_0024__327_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__00241;

		internal bool _0024VB_0024ResumableLocal_sendMbkcCommand_00242;

		internal TaskAwaiter<string> _0024A0;

		internal static object QSgoQkT94MkqjlPPHs5A;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_327_StopVoiceCaptureAsync()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 8;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_4c55e99b69ce444aab2045602ec049f1 == 0)
							{
								continue;
							}
							goto case 0;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_bb2f0fc0ebaf421a874128d1fc3d5b38 == 0)
							{
								num = 9;
							}
							goto end_IL_004b;
						case 2:
							return;
						}
						break;
					}
					switch (num2)
					{
					default:
						return;
					case 990:
						break;
					case 9:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						return;
					}
					continue;
					end_IL_004b:
					break;
				}
			}
		}

		internal static bool HpqBpVT9U3jrnKfVLX7b()
		{
			return true;
		}

		internal static object YUiQnbT9tYZFeEEDnevU()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_331_StartEditMbkcVoiceCommand : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal string _0024VB_0024Local_commandText;

		internal Form_AI_Chat _0024VB_0024Me;

		internal TaskAwaiter _0024A0;

		internal static object jIquoqT9zSYiEp1o9SAO;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_331_StartEditMbkcVoiceCommand()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
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
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							goto IL_0011;
						case 1:
							goto IL_0011;
						default:
							if (num2 == 9)
							{
								return;
							}
							goto end_IL_0027;
						case 0:
							break;
						}
						goto end_IL_0050;
						IL_0011:
						b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
						num3 = 2;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_72823ff942d347a096f59781d20eb0d2 == 0)
						{
							goto end_IL_0050;
						}
						continue;
						end_IL_0027:
						break;
					}
					continue;
					end_IL_0050:
					break;
				}
				while (num2 == 990);
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 5;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5ab3671b1a5b4ded9b7d5dd14f4fc909 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool IjlgpyTbwXVrHXLWj4r4()
		{
			return true;
		}

		internal static object AKisdpTb8lYw7AOllnoC()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_360_HandleManualChatGPTWebOutputReadCommand : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder _0024Builder;

		internal string _0024VB_0024Local_userText;

		internal Form_AI_Chat _0024VB_0024Me;

		internal TaskAwaiter<AIChatResult> _0024A0;

		private static object bMqV0ATbneqDpefUiCeX;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_360_HandleManualChatGPTWebOutputReadCommand()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_f09347d075a54e3c9e3affc36c5644b5 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0051;
								}
								goto case 1;
							}
							return;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 2;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_42524d84b15f453da26a7f97a96dac37 == 0)
							{
								continue;
							}
							break;
						case 2:
							break;
						}
						goto end_IL_0064;
						continue;
						end_IL_0051:
						break;
					}
					continue;
					end_IL_0064:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 != 0)
				{
					num = 2;
				}
			}
		}

		internal static bool SC1ZM4TbRyh4wTHpMF9M()
		{
			return true;
		}

		internal static object kFKcLPTbO2XLB7GN2ybQ()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_511_EnumerateExplorerNodes : IDisposable, IEnumerator, IEnumerable, IEnumerable<TreeNode>, IEnumerator<TreeNode>
	{
		public int _0024State;

		public TreeNode _0024Current;

		public int _0024InitialThreadId;

		internal TreeNodeCollection _0024VB_0024Local_nodes;

		internal TreeNodeCollection _0024P_nodes;

		internal Form_AI_Chat _0024VB_0024Me;

		internal IEnumerator _0024S0;

		internal TreeNode _0024VB_0024ResumableLocal_node_00241;

		internal IEnumerator<TreeNode> _0024S2;

		private static VB_0024StateMachine_511_EnumerateExplorerNodes x3tbeATbhj0OJoAU3KBU;

		private TreeNode Current => null;

		object IEnumerator.Current => null;

		public VB_0024StateMachine_511_EnumerateExplorerNodes(int _0024State)
		{
		}

		private void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[CompilerGenerated]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private IEnumerator<TreeNode> GetEnumerator()
		{
			return null;
		}

		IEnumerator<TreeNode> IEnumerable<TreeNode>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
			return this.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void Reset()
		{
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Reset
			this.Reset();
		}

		static VB_0024StateMachine_511_EnumerateExplorerNodes()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
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
						case 1:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944 != 0)
							{
								continue;
							}
							goto case 2;
						default:
							if (num2 != 9)
							{
								break;
							}
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 6;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_d9209192fb5a48db8afe33275173f36c != 0)
							{
								continue;
							}
							goto case 1;
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num = 9;
							goto end_IL_006a;
						case 0:
							return;
						}
						break;
					}
					if (num2 != 990)
					{
						return;
					}
					continue;
					end_IL_006a:
					break;
				}
			}
		}

		internal static bool lVwiQvTbZEf480MDD7bY()
		{
			return true;
		}

		internal static VB_0024StateMachine_511_EnumerateExplorerNodes cTPXT2TbCGlIF0YDYkQ4()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_540_HandleEditMbkcCommandAsync : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder _0024Builder;

		internal string _0024VB_0024Local_suppliedText;

		internal bool _0024VB_0024Local_voiceHandoff;

		internal Form_AI_Chat _0024VB_0024Me;

		internal _Closure_0024__540_002D1 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal string _0024VB_0024ResumableLocal_outputPath_00241;

		internal string _0024VB_0024ResumableLocal_requestId_00242;

		internal JObject _0024VB_0024ResumableLocal_intent_00243;

		internal TaskAwaiter _0024A0;

		internal TaskAwaiter<JObject> _0024A1;

		internal TaskAwaiter<AIChatResult> _0024A2;

		internal static object VlOTQKTbBEjA4FQwe95M;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_540_HandleEditMbkcCommandAsync()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c16368ee47214a3ea92e8fd02e53deed != 0)
							{
								continue;
							}
							goto case 0;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 9;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_2c174d0d9ac34a6c933e3a665cf63f30 != 0)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0053;
								}
								goto case 0;
							}
							return;
						case 2:
							break;
						}
						goto end_IL_0066;
						continue;
						end_IL_0053:
						break;
					}
					continue;
					end_IL_0066:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 1;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_b817d8b77667446197dc2b785b9041c0 != 0)
				{
					num = 9;
				}
			}
		}

		internal static bool hli8MnTbDblnSvNsgkii()
		{
			return true;
		}

		internal static object oq5W8aTbFR8Ay3bYpQi7()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VB_0024StateMachine_541_HandleEditBeamRebarCommandAsync : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder _0024Builder;

		internal string _0024VB_0024Local_suppliedText;

		internal bool _0024VB_0024Local_voiceHandoff;

		internal Form_AI_Chat _0024VB_0024Me;

		internal TaskAwaiter<JObject> _0024A0;

		internal static object Cfj19uTbG65ysgOp8QXq;

		[CompilerGenerated]
		internal void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		static VB_0024StateMachine_541_HandleEditBeamRebarCommandAsync()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						IL_0053:
						switch (num3)
						{
						case 1:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_215ff6740fce4d6085a4965d450b37ab == 0)
							{
								continue;
							}
							goto end_IL_0066;
						case 2:
							goto end_IL_0066;
						case 0:
							return;
							IL_003b:
							while (num2 == 9)
							{
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 1;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 == 0)
								{
									continue;
								}
								goto IL_0053;
							}
							goto IL_0046;
							IL_0046:
							if (num2 == 990)
							{
								goto end_IL_0053;
							}
							goto case 1;
						}
						goto IL_003b;
						continue;
						end_IL_0053:
						break;
					}
					continue;
					end_IL_0066:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
			}
		}

		internal static bool swY76rTbT2nJf8h4Zffq()
		{
			return true;
		}

		internal static object laOGdaTbxk0oDefmKLR4()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__280_002D0
	{
		public Stopwatch _0024VB_0024Local_aiWatch;

		public long _0024VB_0024Local_pausedMilliseconds;

		public Stopwatch _0024VB_0024Local_toolPauseWatch;

		public string _0024VB_0024Local_apiModel;

		public Action _0024VB_0024Local_onBeforeTool;

		public Action _0024VB_0024Local_onAfterTool;

		public _Closure_0024__280_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		internal static _Closure_0024__280_002D0 sL3APmTbaFIsBgd1PxKg;

		public _Closure_0024__280_002D0(_Closure_0024__280_002D0 arg0)
		{
		}

		[SpecialName]
		internal string _Lambda_0024__0()
		{
			return null;
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
		}

		[SpecialName]
		internal AIChatResult _Lambda_0024__5()
		{
			return null;
		}

		static _Closure_0024__280_002D0()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
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
						case 1:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 9;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_fa885cb658d447638297a1e47340b8c6 == 0)
							{
								continue;
							}
							return;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0052;
								}
								goto case 1;
							}
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_1a1ae42c9fb647b2ac3ccb55018de5e5 != 0)
							{
								continue;
							}
							return;
						case 2:
							break;
						case 0:
							return;
						}
						goto end_IL_0065;
						continue;
						end_IL_0052:
						break;
					}
					continue;
					end_IL_0065:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
			}
		}

		internal static bool ElMpjATbyXUCFIYkxwmB()
		{
			return true;
		}

		internal static _Closure_0024__280_002D0 EhxPFfTbI8vTR4NsuSFt()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__280_002D1
	{
		public string _0024VB_0024Local_effectiveUserText;

		public string _0024VB_0024Local_apiKey;

		public string _0024VB_0024Local_prevResponseId;

		public Form_AI_Chat _0024VB_0024Me;

		internal static _Closure_0024__280_002D1 GSnfFpTbN2bCsDyS8wnv;

		public _Closure_0024__280_002D1(_Closure_0024__280_002D1 arg0)
		{
		}

		static _Closure_0024__280_002D1()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 2:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_bb69b688ab23416fb5187846886dbbdf != 0)
							{
								continue;
							}
							return;
						default:
							if (num2 != 9)
							{
								goto end_IL_004d;
							}
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 9;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_42524d84b15f453da26a7f97a96dac37 != 0)
							{
								continue;
							}
							goto case 2;
						case 1:
							break;
						case 0:
							return;
						}
						goto end_IL_006d;
						continue;
						end_IL_004d:
						break;
					}
					if (num2 != 990)
					{
						return;
					}
					continue;
					end_IL_006d:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_4e8e93c04498476f95f43d6dbed4b259 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool U035m4TbiJ1OCJ1nHmAr()
		{
			return true;
		}

		internal static _Closure_0024__280_002D1 wn3QBrTb9f1VYJhMP2oQ()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__280_002D2
	{
		public JObject _0024VB_0024Local_beamState;

		public _Closure_0024__280_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		private static _Closure_0024__280_002D2 eLwuTsTbbp7RFN9qM6ki;

		public _Closure_0024__280_002D2(_Closure_0024__280_002D2 arg0)
		{
		}

		[SpecialName]
		internal AIChatResult _Lambda_0024__3()
		{
			return null;
		}

		static _Closure_0024__280_002D2()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c9fe3f02f7e845bd8d8e0e7e226ffca4 != 0)
							{
								continue;
							}
							break;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 9;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5ab3671b1a5b4ded9b7d5dd14f4fc909 != 0)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0057;
								}
								goto case 1;
							}
							return;
						case 2:
							break;
						}
						goto end_IL_006a;
						continue;
						end_IL_0057:
						break;
					}
					continue;
					end_IL_006a:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_420aff19babf4086bddd3243df310fb2 == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool c9yvdsTbVfatPPMwIhoS()
		{
			return true;
		}

		internal static _Closure_0024__280_002D2 eYjF9CTbkt1NrplemnMB()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__280_002D3
	{
		public AIToolExecutionResult _0024VB_0024Local_directToolResult;

		public _Closure_0024__280_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		private static _Closure_0024__280_002D3 scICWbTb3qUKiCIktZ0V;

		public _Closure_0024__280_002D3(_Closure_0024__280_002D3 arg0)
		{
		}

		[SpecialName]
		internal AIChatResult _Lambda_0024__4()
		{
			return null;
		}

		static _Closure_0024__280_002D3()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 2:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_2d4a32d5aa4341e59cdd7055ceb6be5d == 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0054;
								}
							}
							else
							{
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 3;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_3e20b8f0eaaf4c2c858e7c7ca7131a33 == 0)
								{
									continue;
								}
							}
							goto case 2;
						case 1:
							break;
						case 0:
							return;
						}
						goto end_IL_0067;
						continue;
						end_IL_0054:
						break;
					}
					continue;
					end_IL_0067:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 1;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_559789cacd7f46ac973fb693ed94037f != 0)
				{
					num = 9;
				}
			}
		}

		internal static bool eB9JTQTb5xIHFOa77Ice()
		{
			return true;
		}

		internal static _Closure_0024__280_002D3 l31vnUTbcC6O8rN2atZf()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__327_002D0
	{
		public string _0024VB_0024Local_audioFilePath;

		internal static _Closure_0024__327_002D0 cywNpDTbPeEu1Pgf6M3S;

		static _Closure_0024__327_002D0()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
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
						case 1:
							break;
						default:
							if (num2 == 9)
							{
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 1;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_934fee42d4914438a301122ea3a645b4 != 0)
								{
									continue;
								}
								goto end_IL_0065;
							}
							goto IL_002f;
						case 2:
							goto end_IL_0065;
						case 0:
							return;
						}
						goto IL_000c;
						IL_002f:
						if (num2 == 990)
						{
							break;
						}
						goto IL_000c;
						IL_000c:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 7;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_0ba42bd2348344eaadcfdc98ba87d4f0 == 0)
						{
							return;
						}
					}
					continue;
					end_IL_0065:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
			}
		}

		internal static bool sQytuNTb1jnbiW1xN8wc()
		{
			return true;
		}

		internal static _Closure_0024__327_002D0 duttuRTb0ibQGt7uoquq()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__540_002D0
	{
		public string _0024VB_0024Local_userText;

		public Form_AI_Chat _0024VB_0024Me;

		private static _Closure_0024__540_002D0 n9w45JTVwHm01npUCB9W;

		static _Closure_0024__540_002D0()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
							if (num2 == 9)
							{
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 3;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_0ba42bd2348344eaadcfdc98ba87d4f0 != 0)
								{
									continue;
								}
							}
							else if (num2 == 990)
							{
								goto end_IL_002f;
							}
							goto case 0;
						case 1:
							break;
						case 0:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							return;
						case 2:
							return;
						}
						goto end_IL_004f;
						continue;
						end_IL_002f:
						break;
					}
					continue;
					end_IL_004f:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 7;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_eb282d37369b4f6197140b421715178f == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool jRm5wFTV8RFqDtbwsJ8I()
		{
			return true;
		}

		internal static _Closure_0024__540_002D0 h3SjaxTVnc7bkZlCeuSC()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__540_002D1
	{
		public string _0024VB_0024Local_apiKey;

		public _Closure_0024__540_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		internal static _Closure_0024__540_002D1 GxhpARTVRxlyeovYvw66;

		[SpecialName]
		internal JObject _Lambda_0024__0()
		{
			return null;
		}

		static _Closure_0024__540_002D1()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						IL_0048:
						switch (num3)
						{
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_e751303fb5f34e63bdc0efa39b75b1a1 != 0)
							{
								continue;
							}
							return;
						case 0:
							goto end_IL_0068;
						case 2:
							return;
						}
						while (true)
						{
							switch (num2)
							{
							case 9:
								goto IL_0024;
							default:
								return;
							case 990:
								break;
							}
							break;
							IL_0024:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 2;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_24719cccbece427b9ca340b0b8914683 == 0)
							{
								continue;
							}
							goto IL_0048;
						}
						break;
					}
					continue;
					end_IL_0068:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 9;
			}
		}

		internal static bool D4SNXmTVOR4NJN13nWGZ()
		{
			return true;
		}

		internal static _Closure_0024__540_002D1 sIb4oATVhjc4TaeLjxe0()
		{
			return null;
		}
	}

	private IContainer KEGCqOYxiDl;

	[AccessedThroughProperty("pnlExplorer")]
	[CompilerGenerated]
	private Panel lPDCqhtV8Ij;

	[AccessedThroughProperty("tvScope")]
	[CompilerGenerated]
	private TreeView lXPCqZyZKnm;

	[CompilerGenerated]
	[AccessedThroughProperty("lblExplorer")]
	private Label VrfCqCKaM9H;

	[AccessedThroughProperty("pnlHeader")]
	[CompilerGenerated]
	private Panel cL8CqB7MS2p;

	[CompilerGenerated]
	[AccessedThroughProperty("btnVoiceCommand")]
	private Button KosCqDkJTHj;

	[CompilerGenerated]
	[AccessedThroughProperty("btnVoiceGuide")]
	private Button JJSCqFUImhE;

	[AccessedThroughProperty("lblSubtitle")]
	[CompilerGenerated]
	private Label TQWCqGVwWJk;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTitle")]
	private Label ShlCqTUXAE2;

	[CompilerGenerated]
	[AccessedThroughProperty("pnlSettings")]
	private Panel a3lCqxxkACk;

	[CompilerGenerated]
	[AccessedThroughProperty("btnReset")]
	private Button YYxCqol3ouu;

	[AccessedThroughProperty("cboModel")]
	[CompilerGenerated]
	private ComboBox QoaCq6tVLpf;

	[AccessedThroughProperty("lblModel")]
	[CompilerGenerated]
	private Label ikTCquvAyT7;

	[CompilerGenerated]
	[AccessedThroughProperty("txtApiKey")]
	private TextBox pvjCqaUn7X7;

	[AccessedThroughProperty("lblApiKey")]
	[CompilerGenerated]
	private Label PYSCqyeqm5X;

	[AccessedThroughProperty("pnlChat")]
	[CompilerGenerated]
	private Panel ylHCqI66v3V;

	[CompilerGenerated]
	[AccessedThroughProperty("txtLog")]
	private RichTextBox SPqCqN3MjlS;

	[AccessedThroughProperty("lblChat")]
	[CompilerGenerated]
	private Label ITUCqiLNJwv;

	[AccessedThroughProperty("pnlPrompt")]
	[CompilerGenerated]
	private Panel s9KCq9NOVYL;

	[AccessedThroughProperty("btnVoice")]
	[CompilerGenerated]
	private Button EgCCqbrFUK7;

	[CompilerGenerated]
	[AccessedThroughProperty("btnSend")]
	private Button iu3CqVP9Ajv;

	[AccessedThroughProperty("txtPrompt")]
	[CompilerGenerated]
	private TextBox RA6CqkkC8t3;

	[CompilerGenerated]
	[AccessedThroughProperty("lblPrompt")]
	private Label yCtCq35TQ46;

	[AccessedThroughProperty("prgAiBusy")]
	[CompilerGenerated]
	private ProgressBar UAeCq50Rqpw;

	[AccessedThroughProperty("_accordionHost")]
	[CompilerGenerated]
	private Panel gkiCqcsSI2O;

	[AccessedThroughProperty("_btnExplorerSection")]
	[CompilerGenerated]
	private Button i44CqpIR4G4;

	[AccessedThroughProperty("_btnChatSection")]
	[CompilerGenerated]
	private Button je7CqjcXy86;

	[CompilerGenerated]
	[AccessedThroughProperty("_btnSettingsSection")]
	private Button UZbCqYFmDvE;

	[AccessedThroughProperty("_btnPromptSection")]
	[CompilerGenerated]
	private Button phNCqPCluEl;

	[AccessedThroughProperty("_promptExamplesPanel")]
	[CompilerGenerated]
	private Panel IMJCq1rKgPd;

	[CompilerGenerated]
	[AccessedThroughProperty("_promptExamplesTitle")]
	private Label qcfCq0rE858;

	[AccessedThroughProperty("_promptExamplesBox")]
	[CompilerGenerated]
	private TextBox q2LCqmgWC4Q;

	[CompilerGenerated]
	[AccessedThroughProperty("_chkSelectMBCad")]
	private CheckBox AJdCqKEHgi1;

	[CompilerGenerated]
	[AccessedThroughProperty("_headerTitlePanel")]
	private Panel WvyCqfjafPl;

	[CompilerGenerated]
	[AccessedThroughProperty("_promptBodyPanel")]
	private Panel zdcCqWHXFfY;

	[CompilerGenerated]
	[AccessedThroughProperty("_promptButtonPanel")]
	private Panel JA6CqvknMeV;

	[AccessedThroughProperty("_promptButtonGapPanel")]
	[CompilerGenerated]
	private Panel QgaCqrgUnyE;

	[AccessedThroughProperty("_promptStatusPanel")]
	[CompilerGenerated]
	private Panel x8ZCqluZCQZ;

	[CompilerGenerated]
	[AccessedThroughProperty("_settingsTable")]
	private TableLayoutPanel cnXCqXBA56x;

	private string WtYCqS47LEX;

	private string onoCqdXD1Db;

	private bool WeWCqgMB6fM;

	private readonly AI_VoiceRecorder RvpCqMJDPNK;

	private readonly AI_EditMBKC_ByVoice_Tool RBPCq7bNpaO;

	private readonly AI_EditBeamRebar_ByVoice_Tool jE4CqEeTGle;

	private bool uHnCqsAc5mv;

	private string aDlCqJQBU4j;

	private string N8pCqerYu8R;

	private bool eVjCqQx9LZv;

	private bool DelCqAW82JM;

	private string rAQCqHfXBAj;

	private zvWWXkDOfGXY7XRTqyWH uTfCqLbx5cQ;

	private Button MhGCq2Lst2U;

	private string tnsCqq5VLhJ;

	private string w2UCq4Z0GlN;

	private bool sroCqUYmxH1;

	[CompilerGenerated]
	[AccessedThroughProperty("_codexTimer")]
	private Timer x7LCqtAmTV3;

	[AccessedThroughProperty("_codexLogTimer")]
	[CompilerGenerated]
	private Timer q0bCqzihPhX;

	[CompilerGenerated]
	[AccessedThroughProperty("_codexApprovalTimer")]
	private Timer V2cC4wLGWrd;

	[CompilerGenerated]
	[AccessedThroughProperty("_layoutStabilizeTimer")]
	private Timer NkdC481Gypy;

	private readonly Queue<string> eEKC4njvK2i;

	private readonly object BPTC4RLJXI9;

	private string dnvC4O035Gc;

	private string oIiC4hvG6wO;

	private string sgYC4ZB0jml;

	private JObject p1gC4Cta97f;

	private string feWC4BrRVNV;

	private int s8sC4Dd4MiQ;

	private bool gJ2C4Fy6n80;

	private bool wmlC4GJaeA8;

	private int aKGC4TK3Wl7;

	private rD8n9QDOW3NADCnteZvf BLxC4xJNYxa;

	private string WYLC4oP4I8u;

	private bool m0lC46WZ9Ay;

	private int xGtC4uhUZgx;

	private int ESbC4aK3keP;

	private bool FSZC4ym5WZp;

	private bool MCIC4IMAgm1;

	private int TQxC4NIqAci;

	private bool XYwC4iKBGES;

	private bool SwQC49B90AJ;

	private string YooC4bpbW2V;

	private AI_ChatGPTWebModelClient yX7C4VkURfL;

	private string KWlC4k8bTga;

	private int Q6GC43nZjFU;

	private int U5lC45wBDOy;

	private bool ew9C4crnA1j;

	private List<string> Bd5C4pKsd9r;

	private int g5kC4jaIyis;

	private bool JUOC4YkwLwG;

	private bool GnbC4POMTUs;

	private bool C42C41NX3Et;

	private bool u5XC40FKG4o;

	private bool T0JC4mA2FXP;

	private bool UIlC4KNjOvL;

	private bool b1pC4fSatSY;

	private bool ywZC4WNmnlX;

	private bool QQPC4vZWryo;

	private bool jZhC4r1GZte;

	private bool qtnC4lS5yWQ;

	private bool qhjC4Xav0qh;

	private bool xLFC4Sbcpfx;

	private int woMC4ddGPTL;

	private readonly Size cXXC4ghL840;

	internal static Form_AI_Chat qZpUKdGzdowNbYMJfjWA;

	internal virtual Panel pnlExplorer
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TreeView tvScope
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblExplorer
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlHeader
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnVoiceCommand
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnVoiceGuide
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblSubtitle
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblTitle
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlSettings
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnReset
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox cboModel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblModel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox txtApiKey
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblApiKey
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlChat
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual RichTextBox txtLog
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblChat
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlPrompt
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnVoice
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnSend
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox txtPrompt
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblPrompt
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ProgressBar prgAiBusy
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _accordionHost
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnExplorerSection
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnChatSection
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnSettingsSection
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnPromptSection
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptExamplesPanel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label _promptExamplesTitle
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox _promptExamplesBox
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox _chkSelectMBCad
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _headerTitlePanel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptBodyPanel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptButtonPanel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptButtonGapPanel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptStatusPanel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TableLayoutPanel _settingsTable
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
	}

	[DebuggerStepThrough]
	private void asUCQEc4a0c()
	{
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetAncestor(IntPtr intptr_0, uint uint_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool GetWindowRect(IntPtr intptr_0, ref Xb2eyJDOPFSYmadCTcVO xb2eyJDOPFSYmadCTcVO_0);

	[SpecialName]
	[CompilerGenerated]
	private virtual Timer KW9FVLl9E0j()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void CdxFV2QRQJg(Timer WithEventsValue)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual Timer Wj7FVqhiD0J()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void L52FV4d7GWO(Timer WithEventsValue)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual Timer pXSFVUMDf0H()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void uqKFVtnRyWa(Timer WithEventsValue)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual Timer GC7FVzfwgZm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void iJyFkwQfLc3(Timer WithEventsValue)
	{
	}

	private void IMGCQeSjepZ(object sender, EventArgs e)
	{
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_280_btnSend_Click))]
	private void T8rCQQBMYJN(object sender, EventArgs e)
	{
	}

	private void uBtCQAQesiR(object sender, KeyEventArgs e)
	{
	}

	private void miHCQHmGpB7(object sender, EventArgs e)
	{
	}

	private void NhmCQLyNvSd(object sender, EventArgs e)
	{
	}

	private void ytPCQ2QQ15p()
	{
	}

	private void JODCQqaCy4I()
	{
	}

	private void pLCCQ4T5myh()
	{
	}

	private void GbCCQUxfYxO()
	{
	}

	private void TAgCQtySft6(object sender, EventArgs e)
	{
	}

	private void Y28CQzcP9Cl()
	{
	}

	private void hGDCAwfWwFI(object sender, EventArgs e)
	{
	}

	private void uV6CA8uBP8w(object sender, EventArgs e)
	{
	}

	private void GCPCAn9Mkhx(object sender, EventArgs e)
	{
	}

	private void Nv9CARG5Ncg(object sender, EventArgs e)
	{
	}

	private void kcECAOqUqwV()
	{
	}

	private bool wHOCAh6DpuK(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return true;
	}

	private void I8JCAZaILmb()
	{
	}

	private void vAjCACQrhys()
	{
	}

	private void givCABYDavn(Button button_0, bool bool_0)
	{
	}

	private void FNuCADm0nT4()
	{
	}

	private void n8ACAFrLwaG()
	{
	}

	private int mTECAGluoWu()
	{
		return 0;
	}

	private int IC6CAT8HGvx()
	{
		return 0;
	}

	private float VkyCAxT78Ea()
	{
		return 0f;
	}

	private int YvaCAo6NuDv()
	{
		return 0;
	}

	private void rhiCA6QhShC()
	{
	}

	private int RTuCAuMJs4R()
	{
		return 0;
	}

	private Rectangle VPcCAaciSRf(Control control_0)
	{
		return (Rectangle)(object)null;
	}

	private void bGVCAy5rWLv(object sender, EventArgs e)
	{
	}

	private void gZHCAI73PwX()
	{
	}

	private void zevCANwRJbq(object sender, EventArgs e)
	{
	}

	private void G4ACAilPrb4()
	{
	}

	private void nv3CA9WZWjW()
	{
	}

	private void uktCAboHx7W()
	{
	}

	private void n28CAVQ4rKL()
	{
	}

	private int KC1CAkWpZ8g()
	{
		return 0;
	}

	private int XTSCA3iOKVA(TreeNodeCollection treeNodeCollection_0)
	{
		return 0;
	}

	private void CcdCA5A0d0q(int int_0)
	{
	}

	private int EcqCAcUUvNU()
	{
		return 0;
	}

	private int NWfCAp5m7fO(Button button_0, Panel panel_0, int int_0, int int_1, int int_2, int int_3)
	{
		return 0;
	}

	private int heMCAjI9oRE(int int_0)
	{
		return 0;
	}

	private void tbuCAYFLuHs(string string_0, string string_1, bool bool_0, bool bool_1)
	{
	}

	private void MiKCAPw0BAr(object sender, MouseEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_323_btnVoice_MouseUp))]
	private void JgaCA1hQ9xI(object sender, MouseEventArgs e)
	{
	}

	private void NLcCA0iG2J7(object sender, MouseEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_325_btnVoiceCommand_MouseUp))]
	private void J4sCAmpF13Y(object sender, MouseEventArgs e)
	{
	}

	private void joCCAKUrdFb(Button button_0, zvWWXkDOfGXY7XRTqyWH zvWWXkDOfGXY7XRTqyWH_0)
	{
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_327_StopVoiceCaptureAsync))]
	private Task zGtCAfmcHm3()
	{
		return null;
	}

	private void Pp5CAWKnN8f(string string_0)
	{
	}

	private string O9HCAvLDibE()
	{
		return null;
	}

	private void SKQCAr2mrO1(object sender, EventArgs e)
	{
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_331_StartEditMbkcVoiceCommand))]
	private void YTACAlkhCa1(string string_0)
	{
	}

	private void AosCAXvZpD9(object sender, EventArgs e)
	{
	}

	private void LonCAS5sW19(string string_0)
	{
	}

	private void C9lCAdIvHhe()
	{
	}

	private void yLYCAgwuqrQ(bool bool_0)
	{
	}

	private void mTPCAMpxib0(string string_0, string string_1)
	{
	}

	private void kuCCA7INf0i()
	{
	}

	private void SmoCAEcW8cS()
	{
	}

	private bool ox7CAssXmOi(string string_0)
	{
		return true;
	}

	private bool C5SCAJI0fT9(string string_0)
	{
		return true;
	}

	private string zFvCAeEqbQG(string string_0)
	{
		return null;
	}

	private string cEGCAQk6Zbo()
	{
		return null;
	}

	private string NalCAA27mrN()
	{
		return null;
	}

	private string xDNCAHlFqQe()
	{
		return null;
	}

	private string nXqCALdUkO1()
	{
		return null;
	}

	private void ksLCA2HkSna()
	{
	}

	private void rleCAq8f8Og()
	{
	}

	private void clcCA4WHfDs()
	{
	}

	private void iadCAU9cmA4()
	{
	}

	private void PktCAtcrEkj(object sender, EventArgs e)
	{
	}

	private bool fjKCAzI8N5o(string string_0)
	{
		return true;
	}

	private string HPfCHw1LAxf()
	{
		return null;
	}

	private bool TAXCH8NbI7k(string string_0, string string_1)
	{
		return true;
	}

	private bool YGWCHnli7Ra(string string_0, string string_1)
	{
		return true;
	}

	private string nfOCHRt6Di4(bool bool_0)
	{
		return null;
	}

	private string uRxCHOm1AFI()
	{
		return null;
	}

	private bool CisCHh6ODLF(string string_0)
	{
		return true;
	}

	private bool YwnCHZIjTxG(string string_0)
	{
		return true;
	}

	private void nhECHCGGOpk(string string_0)
	{
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_360_HandleManualChatGPTWebOutputReadCommand))]
	private Task x7pCHB2hfjc(string string_0)
	{
		return null;
	}

	private bool HwFCHD4IwaM(AIChatResult aichatResult_0)
	{
		return true;
	}

	private string H24CHFqMvbJ()
	{
		return null;
	}

	private bool b8xCHG9cUDr(bool bool_0)
	{
		return true;
	}

	private bool nU8CHT3Ypnw(bool bool_0)
	{
		return true;
	}

	private void HpvCHxj82Yl(Task<AIChatResult> task_0, XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0)
	{
	}

	private void sBZCHouOn7p(Task<AIChatResult> task_0, XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0)
	{
	}

	private void XePCH6frNvQ(string string_0)
	{
	}

	private bool KJuCHuekyC5(string string_0)
	{
		return true;
	}

	private string N7DCHaX85Aw(string string_0)
	{
		return null;
	}

	private AI_ChatGPTWebModelClient oBeCHyrbJJ0()
	{
		return null;
	}

	private string NhsCHILstD7()
	{
		return null;
	}

	private string dD5CHNOSWyt()
	{
		return null;
	}

	private XneemADOvJ58IcSa9gII bY2CHimcwXS(bool bool_0)
	{
		return null;
	}

	private bool j6WCH9l58Q4()
	{
		return true;
	}

	private string JdNCHbVtqqQ(string string_0)
	{
		return null;
	}

	private string I6CCHVdtJ0F(string string_0)
	{
		return null;
	}

	private string mMaCHk2l9Le(XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0)
	{
		return null;
	}

	private string qmXCH3DAgHr(XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0, bool bool_0, string string_0)
	{
		return null;
	}

	private string waMCH5WuSYe(XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0, bool bool_0)
	{
		return null;
	}

	private string hYDCHclvNeX(XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0, bool bool_0)
	{
		return null;
	}

	private string gWnCHpK2elT(XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0, bool bool_0)
	{
		return null;
	}

	private string jfUCHjE7Niy()
	{
		return null;
	}

	private string oYxCHYnGAXn()
	{
		return null;
	}

	private string flmCHPhi35S()
	{
		return null;
	}

	private string S9HCH1XZICC()
	{
		return null;
	}

	private string n3oCH0NdCuN()
	{
		return null;
	}

	private bool KobCHm1DEyR()
	{
		return true;
	}

	private string nGiCHK7dv2m(bool bool_0)
	{
		return null;
	}

	private string P07CHfmb6KV(string string_0)
	{
		return null;
	}

	private bool IZmCHWey38A(bool bool_0)
	{
		return true;
	}

	private bool g3vCHvfNYWO(string string_0)
	{
		return true;
	}

	private JObject VAYCHrk5aRq(string string_0)
	{
		return null;
	}

	private bool AwMCHlFB2BQ(bool bool_0, bool bool_1)
	{
		return true;
	}

	private bool QhvCHXXhg5Z(string string_0)
	{
		return true;
	}

	private bool jkeCHS9c2AI(string string_0)
	{
		return true;
	}

	private bool cqwCHdMADbk(string string_0)
	{
		return true;
	}

	private bool ewmCHgfVRet(string string_0)
	{
		return true;
	}

	private List<string> bAfCHMQrwZZ(string string_0)
	{
		return null;
	}

	private bool BSXCH7IMYNS(string string_0)
	{
		return true;
	}

	private void LoRCHEa81Y3(string string_0)
	{
	}

	private List<string> dvNCHsif9X1(string string_0)
	{
		return null;
	}

	private string btwCHJUNgyY(string string_0)
	{
		return null;
	}

	private string iSiCHePON79()
	{
		return null;
	}

	private string W36CHQEGrfo(List<string> list_0)
	{
		return null;
	}

	private JArray D6SCHATZD72()
	{
		return null;
	}

	private string O4DCHHURJXf(XneemADOvJ58IcSa9gII xneemADOvJ58IcSa9gII_0, string string_0)
	{
		return null;
	}

	private string JDdCHLSYeaV()
	{
		return null;
	}

	private void nk2CH2aCHcc(string string_0, List<string> list_0)
	{
	}

	private string OFiCHqSRmpD(bool bool_0)
	{
		return null;
	}

	private void wbCCH4mnqBt(List<string> list_0, string string_0)
	{
	}

	private string drUCHUEpCTL(string string_0)
	{
		return null;
	}

	private string kTHCHtouBhX(string string_0)
	{
		return null;
	}

	private void gSpCHzVn8Cx(string string_0, AIToolExecutionResult aitoolExecutionResult_0)
	{
	}

	private void kDICLw50cwk(string string_0)
	{
	}

	private string ghaCL8TG2HL(AIToolExecutionResult aitoolExecutionResult_0)
	{
		return null;
	}

	private string v5kCLnD1Wgj(string string_0)
	{
		return null;
	}

	private string Ug8CLRSFHrB()
	{
		return null;
	}

	private void PAnCLOfvSbI(AIToolExecutionResult aitoolExecutionResult_0, string string_0)
	{
	}

	private void RaCCLhpqY3I()
	{
	}

	private void yLkCLZDdC4p(List<JArray> list_0, JArray jarray_0)
	{
	}

	private void bV8CLCZeCj9(List<JArray> list_0, JArray jarray_0)
	{
	}

	private void VgYCLBKrnAM(List<JArray> list_0, JArray jarray_0)
	{
	}

	private bool jAhCLDHD4NU(List<JArray> list_0, ref double double_0, ref double double_1, ref double double_2, ref double double_3)
	{
		return true;
	}

	private double oqBCLFbgZCa(JArray jarray_0, int int_0)
	{
		return 0.0;
	}

	private void wfvCLGIMGg8(Graphics graphics_0, JArray jarray_0, Func<JArray, PointF> func_0, Color color_0, Color color_1, float float_0)
	{
	}

	private void aQxCLTJ3gCZ(Graphics graphics_0, JArray jarray_0, Func<JArray, PointF> func_0)
	{
	}

	private void KlyCLxtqvSx(Graphics graphics_0, JArray jarray_0, Func<JArray, PointF> func_0)
	{
	}

	private void VeGCLoWRnQ0(JObject jobject_0, ref Color color_0, ref Color color_1, ref Color color_2)
	{
	}

	private string rbLCL6ogaAa(int int_0, JObject jobject_0)
	{
		return null;
	}

	private string Fe5CLuPlZkl(JObject jobject_0)
	{
		return null;
	}

	private string NXgCLaVtMZC(string string_0)
	{
		return null;
	}

	private void SRrCLyNTvxM(Graphics graphics_0, JArray jarray_0, Func<JArray, PointF> func_0, Color color_0, Color color_1, float float_0)
	{
	}

	private void OXsCLIFTx4x(Graphics graphics_0, JArray jarray_0, Func<JArray, PointF> func_0, string string_0, Color color_0)
	{
	}

	private RectangleF pYKCLNylE8r(List<PointF> list_0)
	{
		return (RectangleF)(object)null;
	}

	private PointF Q3ICLiVgMs1(RectangleF rectangleF_0, PointF pointF_0, SizeF sizeF_0)
	{
		return (PointF)(object)null;
	}

	private PointF oDxCL9pg38s(RectangleF rectangleF_0, PointF pointF_0, PointF pointF_1)
	{
		return (PointF)(object)null;
	}

	private void VpACLbooha4(Graphics graphics_0, string string_0, Font font_0, PointF pointF_0, Color color_0)
	{
	}

	private void OoNCLVVr51Q(string string_0, string string_1)
	{
	}

	private bool mVKCLkCOWXy(bool bool_0)
	{
		return true;
	}

	private bool AnsCL3TsAeS(bool bool_0)
	{
		return true;
	}

	private string ncUCL5B4puc(string string_0, bool bool_0, bool bool_1)
	{
		return null;
	}

	private string oHnCLc6UXCU(string string_0)
	{
		return null;
	}

	private bool eP2CLpD4HUC()
	{
		return true;
	}

	private void oFHCLjuWwU7()
	{
	}

	private string RZMCLYrM0hU(bool bool_0)
	{
		return null;
	}

	private string E0eCLPpQ0mF()
	{
		return null;
	}

	private string wFOCL13j58B(bool bool_0)
	{
		return null;
	}

	private string jMACL0tdKjf(string string_0)
	{
		return null;
	}

	private void sJWCLm5nVwv(object sender, DataReceivedEventArgs e)
	{
	}

	private void Mm4CLKCiFCs(object sender, EventArgs e)
	{
	}

	private void ySQCLfA0TP4(string string_0)
	{
	}

	private void AqyCLWRWBBL(object sender, EventArgs e)
	{
	}

	private void WYPCLvZr4kL()
	{
	}

	private void IIVCLrN2FqB(object sender, EventArgs e)
	{
	}

	private void Ro4CLl3Pes5(bool bool_0)
	{
	}

	private void VOUCLXaSiuj(string string_0)
	{
	}

	private bool hMqCLSi43K4()
	{
		return true;
	}

	private IAIToolDefinition WXXCLdsZ3BZ()
	{
		return null;
	}

	private string QRACLgjAgaA()
	{
		return null;
	}

	private void FLsCLMhSufM()
	{
	}

	private bool b9JCL7uy0Cx()
	{
		return true;
	}

	private bool XCoCLEaD2Rc()
	{
		return true;
	}

	private bool wO0CLsx2b0Y()
	{
		return true;
	}

	private void serCLJSXSra(int int_0, bool bool_0)
	{
	}

	private void LgBCLeDIEE8(int int_0)
	{
	}

	private string zTfCLQP5jH1(int int_0)
	{
		return null;
	}

	private void tFeCLANU4fM()
	{
	}

	private void YvdCLHvfEsO()
	{
	}

	private void HQHCLLkxq1o(object sender, EventArgs e)
	{
	}

	private void zJ9CL2wVEPD(object sender, EventArgs e)
	{
	}

	private void hJ5CLq7nq41(object sender, EventArgs e)
	{
	}

	private void HVWCL4WiCsT()
	{
	}

	private void Kw0CLUgWMSC(string string_0)
	{
	}

	private string H3rCLtI1ycD(int int_0, string string_0)
	{
		return null;
	}

	private void b7xCLzYLihS(bool bool_0)
	{
	}

	private void vGAC2wARsPK(string string_0)
	{
	}

	private bool PB3C280Llxy()
	{
		return true;
	}

	private bool RHEC2nRgvU2()
	{
		return true;
	}

	private bool b9MC2R22roR()
	{
		return true;
	}

	private void RmtC2OTgIKL(ref double double_0, ref bool bool_0)
	{
	}

	private void SytC2hZ5LPf(double double_0, bool bool_0)
	{
	}

	private string WOWC2ZQIt1Q(bool bool_0)
	{
		return null;
	}

	private void kmKC2CwY8HW()
	{
	}

	private void u7gC2ByhVYJ()
	{
	}

	private void JfpC2DunugK()
	{
	}

	private void TQtC2FD00X8()
	{
	}

	private void nVhC2Gg7jT3(string string_0)
	{
	}

	private string nyjC2T8Ibuv(string string_0)
	{
		return null;
	}

	private string ESjC2xQmQcu(string string_0)
	{
		return null;
	}

	private JObject MyFC2olvqyd(string string_0)
	{
		return null;
	}

	private bool BYmC26W8cfs(JObject jobject_0)
	{
		return true;
	}

	private JObject owNC2uXyqXE(JObject jobject_0, JObject jobject_1)
	{
		return null;
	}

	private JObject Kf9C2amyXNj(JObject jobject_0, JObject jobject_1)
	{
		return null;
	}

	private JArray xFUC2yL6wQi(JObject jobject_0, string string_0)
	{
		return null;
	}

	private void Xj6C2I2bl7b(JArray jarray_0, JArray jarray_1, JArray jarray_2, JObject jobject_0)
	{
	}

	private JArray KTpC2NpNrcp(JArray jarray_0, JArray jarray_1, JArray jarray_2, JObject jobject_0)
	{
		return null;
	}

	private string yXKC2iRPwx1(JObject jobject_0)
	{
		return null;
	}

	private void sLuC29g02BF(JArray jarray_0, string string_0)
	{
	}

	private string RCTC2bP3C2h(JArray jarray_0)
	{
		return null;
	}

	private void eFnC2VUmShA(JArray jarray_0, string string_0)
	{
	}

	private string zRoC2kyxDmq(JArray jarray_0, string string_0)
	{
		return null;
	}

	private void BcfC23trYHN(JArray jarray_0, string string_0)
	{
	}

	private void mKdC25mMNAS(JArray jarray_0, JObject jobject_0)
	{
	}

	private string sAsC2ccJ6F5(JArray jarray_0)
	{
		return null;
	}

	private string EJGC2pKoA2y(JObject jobject_0)
	{
		return null;
	}

	private JToken VGCC2j7WZxu(JToken jtoken_0)
	{
		return null;
	}

	private string s6EC2YtAaSW(string string_0)
	{
		return null;
	}

	private void hDhC2PX5K5f()
	{
	}

	private bool e3YC21KKZuQ()
	{
		return true;
	}

	private void m4uC20syubg()
	{
	}

	[IteratorStateMachine(typeof(VB_0024StateMachine_511_EnumerateExplorerNodes))]
	private IEnumerable<TreeNode> tlEC2mg7aYi(TreeNodeCollection treeNodeCollection_0)
	{
		return null;
	}

	private string m86C2KgT7Xo(TreeNode treeNode_0)
	{
		return null;
	}

	private string wDeC2fkSpZe(string string_0)
	{
		return null;
	}

	private TreeNode AgnC2WvWidc(string string_0)
	{
		return null;
	}

	private TreeNode BE5C2vBtjKC(string string_0, params string[] children)
	{
		return null;
	}

	private TreeNode lm9C2rZe6n0(TreeNode treeNode_0, string string_0, params string[] children)
	{
		return null;
	}

	private void OYDC2lAYuhU(object sender, TreeViewCancelEventArgs e)
	{
	}

	private void c3gC2XWhTIR(object sender, TreeViewEventArgs e)
	{
	}

	private void n8VC2Sw0pQk(object sender, TreeViewEventArgs e)
	{
	}

	private void suLC2dAQoCj()
	{
	}

	private string exSC2giaNUi(string string_0, bool bool_0, bool bool_1, bool bool_2)
	{
		return null;
	}

	private bool nOgC2M3Tt1F()
	{
		return true;
	}

	private bool YyvC278iERs()
	{
		return true;
	}

	private bool FUiC2Ed2opn()
	{
		return true;
	}

	private rD8n9QDOW3NADCnteZvf KSMC2smlE78()
	{
		return (rD8n9QDOW3NADCnteZvf)(object)null;
	}

	private void IOeC2JOXuY9(bool? nullable_0 = null)
	{
	}

	private void ffrC2eARHuD()
	{
	}

	private List<string> tJ0C2Q9Qmy3()
	{
		return null;
	}

	private List<string> uZeC2A7TDDS(TreeNode treeNode_0)
	{
		return null;
	}

	private string rIDC2HEF4ch()
	{
		return null;
	}

	private string PMOC2LH5QKX(string string_0)
	{
		return null;
	}

	private void hqYC22JjkyL(object sender, EventArgs e)
	{
	}

	private bool SmjC2qRvMNq()
	{
		return true;
	}

	private static bool fWuC24bv326(object object_0)
	{
		return true;
	}

	private bool wqIC2UF0Uxo()
	{
		return true;
	}

	private bool BCjC2tH118D()
	{
		return true;
	}

	private void nMHC2zjoOak()
	{
	}

	private void dCICqwtgrAo()
	{
	}

	private void LwICq8xPBGq(bool bool_0)
	{
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_540_HandleEditMbkcCommandAsync))]
	private Task DxnCqn3AHRs(string string_0 = null, bool bool_0 = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_541_HandleEditBeamRebarCommandAsync))]
	private Task AccCqRllFDX(string string_0 = null, bool bool_0 = false)
	{
		return null;
	}

	static Form_AI_Chat()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_0067:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
						b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
						num3 = 5;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_e722010689ee4fbe88edb9e655ec8567 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
						num = 9;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_37b0091396744102a21e76ffc34b8972 != 0)
						{
							num = 1;
						}
						goto end_IL_0047;
					case 0:
						return;
					}
					switch (num2)
					{
					case 9:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 6;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 == 0)
						{
							continue;
						}
						return;
					default:
						return;
					case 990:
						break;
					}
					goto IL_0067;
					continue;
					end_IL_0047:
					break;
				}
				break;
			}
		}
	}

	internal static bool uK223OGzgpaQ3KJ3v26t()
	{
		return true;
	}

	internal static Form_AI_Chat Si11nlGzM4g31Yb1qdHl()
	{
		return null;
	}
}
