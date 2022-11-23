using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkExcercieses.Generics
{
    public interface IMyInterface
    {
        void Run();
    }

    public class Examples<T>
        where T : IMyInterface
    {
        public T Field { get; set; }

        public void Run()
        {
            return;
        }
    }

    public class GenericClass<T, K>
    where T: IMyInterface
    where K: IMyInterface
    {
        public T Field { get; set; }
        public K Field2 { get; set; }        
    }

    public class GenericClassMethods 
    {
        public void Show<T>(T value)
        {
            value.ToString();
        }
    
        public void Run<T>(T value)
            where T: IMyInterface
        {
            value.Run();
        }
    }
}
