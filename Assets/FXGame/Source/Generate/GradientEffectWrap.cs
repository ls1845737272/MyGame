﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GradientEffectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GradientEffect), typeof(UnityEngine.UI.BaseMeshEffect));
		L.RegFunction("ModifyMesh", ModifyMesh);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("topColor", get_topColor, set_topColor);
		L.RegVar("bottomColor", get_bottomColor, set_bottomColor);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ModifyMesh(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Mesh>(L, 2))
			{
				GradientEffect obj = (GradientEffect)ToLua.CheckObject<GradientEffect>(L, 1);
				UnityEngine.Mesh arg0 = (UnityEngine.Mesh)ToLua.ToObject(L, 2);
				obj.ModifyMesh(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.UI.VertexHelper>(L, 2))
			{
				GradientEffect obj = (GradientEffect)ToLua.CheckObject<GradientEffect>(L, 1);
				UnityEngine.UI.VertexHelper arg0 = (UnityEngine.UI.VertexHelper)ToLua.ToObject(L, 2);
				obj.ModifyMesh(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: GradientEffect.ModifyMesh");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
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
	static int get_topColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GradientEffect obj = (GradientEffect)o;
			UnityEngine.Color ret = obj.topColor;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index topColor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bottomColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GradientEffect obj = (GradientEffect)o;
			UnityEngine.Color ret = obj.bottomColor;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bottomColor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_topColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GradientEffect obj = (GradientEffect)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.topColor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index topColor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bottomColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GradientEffect obj = (GradientEffect)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.bottomColor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bottomColor on a nil value");
		}
	}
}

