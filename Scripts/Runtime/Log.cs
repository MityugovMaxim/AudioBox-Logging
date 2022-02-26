using System;
using JetBrains.Annotations;
using UnityEngine;

namespace AudioBox.Logging
{
	public static class Log
	{
		public static void Info(object _Context, string _Message)
		{
			Debug.LogFormat($"<b>[{_Context.GetType().Name}]</b> {_Message}");
		}

		[StringFormatMethod("_Format")]
		public static void Info(object _Context, string _Format, params object[] _Args)
		{
			Debug.LogFormat($"<b>[{_Context.GetType().Name}]</b> {_Format}", _Args);
		}

		[StringFormatMethod("_Format")]
		public static void Info(string _Context, string _Format, params object[] _Args)
		{
			Debug.LogFormat($"<b>[{_Context}]</b> {_Format}", _Args);
		}

		public static void Error(object _Context, string _Message)
		{
			Debug.LogError($"<b>[{_Context.GetType().Name}]</b> {_Message}");
		}

		[StringFormatMethod("_Format")]
		public static void Error(object _Context, string _Format, params object[] _Args)
		{
			Debug.LogErrorFormat($"<b>[{_Context.GetType().Name}]</b> {_Format}", _Args);
		}

		[StringFormatMethod("_Format")]
		public static void Error(string _Context, string _Format, params object[] _Args)
		{
			Debug.LogErrorFormat($"<b>[{_Context}]</b> {_Format}", _Args);
		}

		public static void Warning(object _Context, string _Message)
		{
			Debug.LogWarning($"<b>[{_Context.GetType().Name}]</b> {_Message}");
		}

		[StringFormatMethod("_Format")]
		public static void Warning(object _Context, string _Format, params object[] _Args)
		{
			Debug.LogWarningFormat($"<b>[{_Context.GetType().Name}]</b> {_Format}", _Args);
		}

		[StringFormatMethod("_Format")]
		public static void Warning(string _Context, string _Format, params object[] _Args)
		{
			Debug.LogWarningFormat($"<b>[{_Context}]</b> {_Format}", _Args);
		}

		public static void Exception(object _Context, Exception _Exception)
		{
			Debug.LogError($"<b>[{_Context.GetType().Name}]</b> {_Exception.GetType().Name}. Message: {_Exception.Message}.");
			Debug.LogException(_Exception);
		}
	}
}