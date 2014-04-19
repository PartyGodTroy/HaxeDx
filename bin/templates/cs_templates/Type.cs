using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public  class ValueType : global::haxe.lang.Enum {
		static ValueType() {
			#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.ValueType.constructs = new global::haxe.root.Array<object>(new object[]{"TNull", "TInt", "TFloat", "TBool", "TObject", "TFunction", "TClass", "TEnum", "TUnknown"});
			global::haxe.root.ValueType.TNull = new global::haxe.root.ValueType(((int) (0) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{})) ));
			global::haxe.root.ValueType.TInt = new global::haxe.root.ValueType(((int) (1) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{})) ));
			global::haxe.root.ValueType.TFloat = new global::haxe.root.ValueType(((int) (2) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{})) ));
			global::haxe.root.ValueType.TBool = new global::haxe.root.ValueType(((int) (3) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{})) ));
			global::haxe.root.ValueType.TObject = new global::haxe.root.ValueType(((int) (4) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{})) ));
			global::haxe.root.ValueType.TFunction = new global::haxe.root.ValueType(((int) (5) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{})) ));
			#line 59 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
			global::haxe.root.ValueType.TUnknown = new global::haxe.root.ValueType(((int) (8) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{})) ));
		}
		public    ValueType(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
			#line default
		}
		
		
		public    ValueType(int index, global::haxe.root.Array<object> @params) : base(index, @params){
			unchecked {
			}
			#line default
		}
		
		
		public static  global::haxe.root.Array<object> constructs;
		
		public static  global::haxe.root.ValueType TNull;
		
		public static  global::haxe.root.ValueType TInt;
		
		public static  global::haxe.root.ValueType TFloat;
		
		public static  global::haxe.root.ValueType TBool;
		
		public static  global::haxe.root.ValueType TObject;
		
		public static  global::haxe.root.ValueType TFunction;
		
		public static   global::haxe.root.ValueType TClass(global::System.Type c){
			unchecked {
				#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.ValueType(((int) (6) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{c})) ));
			}
			#line default
		}
		
		
		public static   global::haxe.root.ValueType TEnum(global::System.Type e){
			unchecked {
				#line 58 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.ValueType(((int) (7) ), ((global::haxe.root.Array<object>) (new global::haxe.root.Array<object>(new object[]{e})) ));
			}
			#line default
		}
		
		
		public static  global::haxe.root.ValueType TUnknown;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.ValueType(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.ValueType(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (arr[1]) ))) ));
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root{
	public  class Type : global::haxe.lang.HxObject {
		public    Type(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Type(){
			unchecked {
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::haxe.root.Type.__hx_ctor__Type(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor__Type(global::haxe.root.Type __temp_me10){
			unchecked {
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   global::System.Type getClass<T>(T o){
			
		if (o == null || o is haxe.lang.DynamicObject || o is System.Type)
			return null;

		return o.GetType();
	
		}
		
		
		public static   global::System.Type getEnum(object o){
			
		if (o is System.Enum || o is haxe.lang.Enum)
			return o.GetType();
		return null;
	
		}
		
		
		public static   global::System.Type getSuperClass(global::System.Type c){
			unchecked {
				#line 87 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Type t = ((global::System.Type) (c) );
				global::System.Type @base = t.BaseType;
				if (( ( global::haxe.lang.Runtime.typeEq(@base, default(global::System.Type)) || string.Equals(global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(@base), ""), "haxe.lang.HxObject") ) || string.Equals(global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(@base), ""), "System.Object") )) {
					#line 91 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return default(global::System.Type);
				}
				
				#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ((global::System.Type) (@base) );
			}
			#line default
		}
		
		
		public static   string getClassName(global::System.Type c){
			unchecked {
				#line 98 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				string ret = global::haxe.lang.Runtime.toString(((global::System.Type) (c) ));
				#line 100 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( ( ret.Length > 10 ) && ret.StartsWith("haxe.root.") )) {
					#line 101 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					ret = global::haxe.lang.StringExt.substr(ret, 10, default(global::haxe.lang.Null<int>));
				}
				
				#line 104 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				switch (ret){
					case "System.Int32":
					{
						#line 106 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Int";
					}
					
					
					case "System.Double":
					{
						#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Float";
					}
					
					
					case "System.String":
					{
						#line 108 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "String";
					}
					
					
					case "System.Object":
					{
						#line 109 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Dynamic";
					}
					
					
					case "System.Type":
					{
						#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return "Class";
					}
					
					
					default:
					{
						#line 111 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return global::haxe.lang.Runtime.toString(global::haxe.lang.StringExt.split(ret, "`")[0]);
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   string getEnumName(global::System.Type e){
			unchecked {
				#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				string ret = global::haxe.lang.Runtime.toString(((global::System.Type) (e) ));
				#line 119 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( ( ret.Length > 10 ) && ret.StartsWith("haxe.root.") )) {
					#line 120 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					ret = global::haxe.lang.StringExt.substr(ret, 10, default(global::haxe.lang.Null<int>));
				}
				
				#line 122 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( ( ret.Length == 14 ) && string.Equals(ret, "System.Boolean") )) {
					#line 123 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return "Bool";
				}
				
				#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ret;
			}
			#line default
		}
		
		
		public static   global::System.Type resolveClass(string name){
			unchecked {
				#line 130 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (( global::haxe.lang.StringExt.indexOf(name, ".", default(global::haxe.lang.Null<int>)) == -1 )) {
					#line 131 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					name = global::haxe.lang.Runtime.concat("haxe.root.", name);
				}
				
				#line 133 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Type t = global::System.Type.GetType(((string) (name) ));
				if (global::haxe.lang.Runtime.typeEq(t, default(global::System.Type))) {
					#line 136 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					switch (name){
						case "haxe.root.Int":
						{
							#line 138 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(int)) );
						}
						
						
						case "haxe.root.Float":
						{
							#line 139 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(double)) );
						}
						
						
						case "haxe.root.Class":
						{
							#line 140 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(global::System.Type)) );
						}
						
						
						case "haxe.root.Dynamic":
						{
							#line 141 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(object)) );
						}
						
						
						case "haxe.root.String":
						{
							#line 142 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return ((global::System.Type) (typeof(string)) );
						}
						
						
						default:
						{
							#line 143 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							return default(global::System.Type);
						}
						
					}
					
				}
				 else {
					#line 145 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					if (( t.IsInterface && (((global::System.Type) (typeof(global::haxe.lang.IGenericObject)) )).IsAssignableFrom(((global::System.Type) (t) )) )) {
						#line 146 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						t = default(global::System.Type);
						int i = 0;
						string ts = "";
						while (( global::haxe.lang.Runtime.typeEq(t, default(global::System.Type)) && ( i < 18 ) )){
							#line 151 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							i++;
							ts = global::haxe.lang.Runtime.concat(ts, global::haxe.lang.Runtime.concat((( (( i == 1 )) ? ("") : (",") )), "System.Object"));
							t = global::System.Type.GetType(((string) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(name, "`"), global::haxe.lang.Runtime.toString(i)), "["), ts), "]")) ));
						}
						
						#line 156 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return ((global::System.Type) (t) );
					}
					 else {
						#line 158 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						return ((global::System.Type) (t) );
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   global::System.Type resolveEnum(string name){
			
		if (name == "Bool") return typeof(bool);
		System.Type t = resolveClass(name);
		if (t != null && (t.BaseType.Equals(typeof(System.Enum)) || t.BaseType.Equals(typeof(haxe.lang.Enum))))
			return t;
		return null;
	
		}
		
		
		public static   T createInstance<T>(global::System.Type cl, global::haxe.root.Array args){
			unchecked {
				#line 177 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (global::haxe.lang.Runtime.refEq(cl, typeof(string))) {
					#line 178 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return global::haxe.lang.Runtime.genericCast<T>(args[0]);
				}
				
				#line 179 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Type t = ((global::System.Type) (cl) );
				if (t.IsInterface) {
					#line 183 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					global::System.Type cl1 = global::haxe.root.Type.resolveClass(global::haxe.root.Type.getClassName(cl));
					#line 183 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					t = cl1;
				}
				
				#line 185 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Reflection.ConstructorInfo[] ctors = t.GetConstructors();
				return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callMethod(default(object), ((global::System.Reflection.MethodBase[]) (ctors) ), ( ctors as global::System.Array ).Length, args));
			}
			#line default
		}
		
		
		public static   T createEmptyInstance<T>(global::System.Type cl){
			unchecked {
				#line 191 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::System.Type t = ((global::System.Type) (cl) );
				if (t.IsInterface) {
					#line 195 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					global::System.Type cl1 = global::haxe.root.Type.resolveClass(global::haxe.root.Type.getClassName(cl));
					#line 195 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					t = cl1;
				}
				
				#line 198 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (global::haxe.root.Reflect.hasField(cl, "__hx_createEmpty")) {
					#line 199 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callField(cl, "__hx_createEmpty", 2084789794, default(global::haxe.root.Array)));
				}
				
				#line 200 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return global::haxe.root.Type.createInstance<T>(cl, new global::haxe.root.Array<object>(new object[]{}));
			}
			#line default
		}
		
		
		public static   T createEnum<T>(global::System.Type e, string constr, global::haxe.root.Array @params){
			
		if (@params == null || @params[0] == null)
		{
			object ret = haxe.lang.Runtime.slowGetField(e, constr, true);
			if (ret is haxe.lang.Function)
				throw haxe.lang.HaxeException.wrap("Constructor " + constr + " needs parameters");
			return (T) ret;
		} else {
			return (T) haxe.lang.Runtime.slowCallField(e, constr, @params);
		}
	
		}
		
		
		public static   T createEnumIndex<T>(global::System.Type e, int index, global::haxe.root.Array @params){
			unchecked {
				#line 220 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::haxe.root.Array<object> constr = global::haxe.root.Type.getEnumConstructs(e);
				return global::haxe.root.Type.createEnum<T>(e, global::haxe.lang.Runtime.toString(constr[index]), @params);
			}
			#line default
		}
		
		
		public static   global::haxe.root.Array<object> getInstanceFields(global::System.Type c){
			
		if (c == typeof(string))
		{
			return haxe.lang.StringRefl.fields;
		}

		Array<object> ret = new Array<object>();

        System.Reflection.MemberInfo[] mis = c.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.FlattenHierarchy);
        for (int i = 0; i < mis.Length; i++)
        {
			if (mis[i] is System.Reflection.PropertyInfo)
                continue;
			string n = mis[i].Name;
			if (!n.StartsWith("__hx_") && n[0] != '.' && !n.Equals("Equals") && !n.Equals("ToString") && !n.Equals("GetHashCode") && !n.Equals("GetType"))
				ret.push(mis[i].Name);
        }

		return ret;
	
		}
		
		
		public static   global::haxe.root.Array<object> getClassFields(global::System.Type c){
			
		Array<object> ret = new Array<object>();

		if (c == typeof(string))
		{
			ret.push("fromCharCode");
			return ret;
		}

        System.Reflection.MemberInfo[] mis = c.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        for (int i = 0; i < mis.Length; i++)
        {
            string n = mis[i].Name;
			if (!n.StartsWith("__hx_"))
				ret.push(mis[i].Name);
        }

        return ret;
	
		}
		
		
		public static   global::haxe.root.Array<object> getEnumConstructs(global::System.Type e){
			unchecked {
				#line 272 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				if (global::haxe.root.Reflect.hasField(e, "constructs")) {
					#line 273 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					return ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (global::haxe.lang.Runtime.callField(global::haxe.lang.Runtime.getField(e, "constructs", 1744813180, true), "copy", 1103412149, default(global::haxe.root.Array))) ))) );
				}
				
				#line 274 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
                return global::cs.Lib.array<object>(new object[] { global::System.Enum.GetName((global::System.Type)(global::cs.Lib.nativeType(e)), e) });
				//return global::cs.Lib.array<object>(((object[]) (global::System.Enum.GetNames(((global::System.Type) (global::cs.Lib.nativeType(e)) ))) ));
			}
			#line default
		}
		
		
		public static   global::haxe.root.ValueType @typeof(object v){
			
		if (v == null) return ValueType.TNull;

        System.Type t = v as System.Type;
        if (t != null)
        {
            //class type
            return ValueType.TObject;
        }

        t = v.GetType();
        if (t.IsEnum)
            return ValueType.TEnum(t);
        if (t.IsValueType)
        {
            System.IConvertible vc = v as System.IConvertible;
            if (vc != null)
            {
                switch (vc.GetTypeCode())
                {
                    case System.TypeCode.Boolean: return ValueType.TBool;
                    case System.TypeCode.Double:
						double d = vc.ToDouble(null);
						if (d >= int.MinValue && d <= int.MaxValue && d == vc.ToInt32(null))
							return ValueType.TInt;
						else
							return ValueType.TFloat;
                    case System.TypeCode.Int32:
                        return ValueType.TInt;
                    default:
                        return ValueType.TClass(t);
                }
            } else {
                return ValueType.TClass(t);
            }
        }

        if (v is haxe.lang.IHxObject)
        {
            if (v is haxe.lang.DynamicObject)
                return ValueType.TObject;
            else if (v is haxe.lang.Enum)
                return ValueType.TEnum(t);
            return ValueType.TClass(t);
        } else if (v is haxe.lang.Function) {
            return ValueType.TFunction;
        } else {
            return ValueType.TClass(t);
        }
	
		}
		
		
		public static   bool enumEq<T>(T a, T b){
			
			if (a is haxe.lang.Enum)
				return a.Equals(b);
			else
				return haxe.lang.Runtime.eq(a, b);
	
		}
		
		
		public static   string enumConstructor(object e){
			
		if (e is System.Enum)
			return e + "";
		else
			return ((haxe.lang.Enum) e).getTag();
	
		}
		
		
		public static   global::haxe.root.Array enumParameters(object e){
			
		return ( e is System.Enum ) ? new Array<object>() : ((haxe.lang.Enum) e).@params;
	
		}
		
		
		public static   int enumIndex(object e){
			
		if (e is System.Enum)
			return ((System.IConvertible) e).ToInt32(null);
		else
			return ((haxe.lang.Enum) e).index;
	
		}
		
		
		public static   global::haxe.root.Array<T> allEnums<T>(global::System.Type e){
			unchecked {
				#line 375 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				global::haxe.root.Array<object> ctors = global::haxe.root.Type.getEnumConstructs(e);
				global::haxe.root.Array<T> ret = new global::haxe.root.Array<T>(new T[]{});
				{
					#line 377 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					int _g = 0;
					#line 377 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
					while (( _g < ctors.length )){
						#line 377 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						string ctor = global::haxe.lang.Runtime.toString(ctors[_g]);
						#line 377 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						 ++ _g;
						#line 379 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
						T v = global::haxe.lang.Runtime.genericCast<T>(global::haxe.root.Reflect.field(e, ctor));
						if (global::haxe.root.Std.@is(v, e)) {
							#line 381 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
							ret.push(v);
						}
						
					}
					
				}
				
				#line 384 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return ret;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.Type(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Type.hx"
				return new global::haxe.root.Type();
			}
			#line default
		}
		
		
	}
}


