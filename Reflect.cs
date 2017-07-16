using System;
using System.Reflection;

public class Reflect1{
    public static void Main(){
        Type t = typeof(string);
        MethodInfo[] methods =  t.GetMethods();
        foreach(MethodInfo info in methods){
            if(info.Name.Equals("ToUpper")){ //有两个ToUpper,如何区分?
                var result = info.Invoke("asdf",null);
                Console.WriteLine(result);
                break;
            }
        }
    }
}