﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FXBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FXBehaviour), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("CacheTransform", get_CacheTransform, null);
		L.RegVar("CacheAnimator", get_CacheAnimator, null);
		L.RegVar("CacheCollider", get_CacheCollider, null);
		L.RegVar("CacheImage", get_CacheImage, null);
		L.RegVar("CacheSpriteRenderer", get_CacheSpriteRenderer, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CacheTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FXBehaviour obj = (FXBehaviour)o;
			UnityEngine.Transform ret = obj.CacheTransform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CacheTransform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CacheAnimator(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FXBehaviour obj = (FXBehaviour)o;
			UnityEngine.Animator ret = obj.CacheAnimator;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CacheAnimator on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CacheCollider(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FXBehaviour obj = (FXBehaviour)o;
			UnityEngine.Collider ret = obj.CacheCollider;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CacheCollider on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CacheImage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FXBehaviour obj = (FXBehaviour)o;
			UnityEngine.UI.Image ret = obj.CacheImage;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CacheImage on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CacheSpriteRenderer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FXBehaviour obj = (FXBehaviour)o;
			UnityEngine.SpriteRenderer ret = obj.CacheSpriteRenderer;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CacheSpriteRenderer on a nil value");
		}
	}
}

