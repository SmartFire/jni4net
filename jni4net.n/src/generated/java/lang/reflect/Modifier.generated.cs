//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Modifier : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toString0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isAbstract1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isInterface2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isProtected3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isPublic4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isFinal5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isNative6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isPrivate7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isStatic8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isStrict9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isSynchronized10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isTransient11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isVolatile12;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_PUBLIC13;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_PRIVATE14;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_PROTECTED15;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_STATIC16;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_FINAL17;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_SYNCHRONIZED18;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_VOLATILE19;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_TRANSIENT20;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_NATIVE21;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_INTERFACE22;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_ABSTRACT23;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_STRICT24;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorModifier25;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Modifier() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n__ctorModifier25, this);
            }
        }
        
        protected Modifier(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Modifier.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_PUBLIC13)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PRIVATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_PRIVATE14)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PROTECTED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_PROTECTED15)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int STATIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_STATIC16)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int FINAL {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_FINAL17)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SYNCHRONIZED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_SYNCHRONIZED18)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int VOLATILE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_VOLATILE19)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int TRANSIENT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_TRANSIENT20)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int NATIVE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_NATIVE21)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int INTERFACE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_INTERFACE22)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ABSTRACT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_ABSTRACT23)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int STRICT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_STRICT24)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.Modifier.staticClass = @__class;
            global::java.lang.reflect.Modifier.j4n_toString0 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "toString", "(I)Ljava/lang/String;");
            global::java.lang.reflect.Modifier.j4n_isAbstract1 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isAbstract", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isInterface2 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isInterface", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isProtected3 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isProtected", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isPublic4 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isPublic", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isFinal5 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isFinal", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isNative6 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isNative", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isPrivate7 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isPrivate", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isStatic8 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isStatic", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isStrict9 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isStrict", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isSynchronized10 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isSynchronized", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isTransient11 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isTransient", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_isVolatile12 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isVolatile", "(I)Z");
            global::java.lang.reflect.Modifier.j4n_PUBLIC13 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Modifier.j4n_PRIVATE14 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PRIVATE", "I");
            global::java.lang.reflect.Modifier.j4n_PROTECTED15 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PROTECTED", "I");
            global::java.lang.reflect.Modifier.j4n_STATIC16 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "STATIC", "I");
            global::java.lang.reflect.Modifier.j4n_FINAL17 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "FINAL", "I");
            global::java.lang.reflect.Modifier.j4n_SYNCHRONIZED18 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "SYNCHRONIZED", "I");
            global::java.lang.reflect.Modifier.j4n_VOLATILE19 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "VOLATILE", "I");
            global::java.lang.reflect.Modifier.j4n_TRANSIENT20 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "TRANSIENT", "I");
            global::java.lang.reflect.Modifier.j4n_NATIVE21 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "NATIVE", "I");
            global::java.lang.reflect.Modifier.j4n_INTERFACE22 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "INTERFACE", "I");
            global::java.lang.reflect.Modifier.j4n_ABSTRACT23 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "ABSTRACT", "I");
            global::java.lang.reflect.Modifier.j4n_STRICT24 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "STRICT", "I");
            global::java.lang.reflect.Modifier.j4n__ctorModifier25 = @__env.GetMethodID(global::java.lang.reflect.Modifier.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_toString0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isAbstract(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isAbstract1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isInterface(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isInterface2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isProtected(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isProtected3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isPublic(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isPublic4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isFinal(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isFinal5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isNative(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isNative6, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isPrivate(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isPrivate7, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isStatic(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isStatic8, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isStrict(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isStrict9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isSynchronized(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isSynchronized10, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isTransient(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isTransient11, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isVolatile(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.j4n_isVolatile12, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.Modifier(@__env);
            }
        }
    }
    #endregion
}
