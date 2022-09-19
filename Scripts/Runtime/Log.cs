using System;
using JetBrains.Annotations;
using UnityEngine;

namespace AudioBox.Logging
{
	public static class Log
	{
		public static void Info(object _Context, string _Message)
		{
			#if UNITY_EDITOR
			Debug.LogFormat($"<b>[{_Context.GetType().Name}]</b> {_Message}");
			#else
			Debug.LogFormat($"{DateTime.Now:HH:mm:ss} [{_Context.GetType().Name}] {_Message}");
			#endif
		}

		[StringFormatMethod("_Format")]
		public static void Info(object _Context, string _Format, params object[] _Args)
		{
			#if UNITY_EDITOR
			Debug.LogFormat($"<b>[{_Context.GetType().Name}]</b> {_Format}", _Args);
			#else
			Debug.LogFormat($"{DateTime.Now:HH:mm:ss} [{_Context.GetType().Name}] {_Format}", _Args);
			#endif
		}

		[StringFormatMethod("_Format")]
		public static void Info(string _Context, string _Format, params object[] _Args)
		{
			#if UNITY_EDITOR
			Debug.LogFormat($"<b>[{_Context}]</b> {_Format}", _Args);
			#else
			Debug.LogFormat($"{DateTime.Now:HH:mm:ss} [{_Context}] {_Format}", _Args);
			#endif
		}

		public static void Error(object _Context, string _Message)
		{
			#if UNITY_EDITOR
			Debug.LogError($"<b>[{_Context.GetType().Name}]</b> {_Message}");
			#else
			Debug.LogError($"[{_Context.GetType().Name}] {_Message}");
			#endif
		}

		public static void Error(Type _Context, string _Message)
		{
			#if UNITY_EDITOR
			Debug.LogError($"<b>[{_Context.Name}]</b> {_Message}");
			#else
			Debug.LogError($"[{_Context.Name}] {_Message}");
			#endif
		}

		[StringFormatMethod("_Format")]
		public static void Error(object _Context, string _Format, params object[] _Args)
		{
			#if UNITY_EDITOR
			Debug.LogErrorFormat($"<b>[{_Context.GetType().Name}]</b> {_Format}", _Args);
			#else
			Debug.LogErrorFormat($"[{_Context.GetType().Name}] {_Format}", _Args);
			#endif
		}

		[StringFormatMethod("_Format")]
		public static void Error(string _Context, string _Format, params object[] _Args)
		{
			#if UNITY_EDITOR
			Debug.LogErrorFormat($"<b>[{_Context}]</b> {_Format}", _Args);
			#else
			Debug.LogErrorFormat($"[{_Context}] {_Format}", _Args);
			#endif
		}

		public static void Warning(object _Context, string _Message)
		{
			#if UNITY_EDITOR
			Debug.LogWarning($"<b>[{_Context.GetType().Name}]</b> {_Message}");
			#else
			Debug.LogWarning($"[{_Context.GetType().Name}] {_Message}");
			#endif
		}

		[StringFormatMethod("_Format")]
		public static void Warning(object _Context, string _Format, params object[] _Args)
		{
			#if UNITY_EDITOR
			Debug.LogWarningFormat($"<b>[{_Context.GetType().Name}]</b> {_Format}", _Args);
			#else
			Debug.LogWarningFormat($"[{_Context.GetType().Name}] {_Format}", _Args);
			#endif
		}

		[StringFormatMethod("_Format")]
		public static void Warning(string _Context, string _Format, params object[] _Args)
		{
			#if UNITY_EDITOR
			Debug.LogWarningFormat($"<b>[{_Context}]</b> {_Format}", _Args);
			#else
			Debug.LogWarningFormat($"[{_Context}] {_Format}", _Args);
			#endif
		}

		public static void Exception(object _Context, Exception _Exception)
		{
			#if UNITY_EDITOR
			Debug.LogError($"<b>[{_Context.GetType().Name}]</b> {_Exception.GetType().Name}. Message: {_Exception.Message}.");
			#else
			Debug.LogError($"[{_Context.GetType().Name}] {_Exception.GetType().Name}. Message: {_Exception.Message}.");
			#endif
			Debug.LogException(_Exception);
		}

		public static void Exception(object _Context, Exception _Exception, string _Message)
		{
			#if UNITY_EDITOR
			Debug.LogError($"<b>[{_Context.GetType().Name}]</b> {_Message}.");
			#else
			Debug.LogError($"[{_Context.GetType().Name}] {_Message}.");
			#endif
			Debug.LogException(_Exception);
		}

		[StringFormatMethod("_Format")]
		public static void Exception(object _Context, Exception _Exception, string _Format, params object[] _Args)
		{
			#if UNITY_EDITOR
			Debug.LogErrorFormat($"<b>[{_Context.GetType().Name}]</b> {_Format}.", _Args);
			#else
			Debug.LogErrorFormat($"[{_Context.GetType().Name}] {_Format}.", _Args);
			#endif
			Debug.LogException(_Exception);
		}
	}
}