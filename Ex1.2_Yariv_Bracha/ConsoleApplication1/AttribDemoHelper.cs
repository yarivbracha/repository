using System;
using System.Reflection;

namespace AttribDemo
{
    class AttribDemoHelper
    {
        public bool AnalyzeAssembly(Assembly assembly)
        {
            if (assembly != null)
            {
                bool isApproved = true;
                foreach (Type type in assembly.GetTypes())
                {
                    object[] objects = type.GetCustomAttributes(typeof(CodeReviewAttribute), false);
                    if (objects.Length != 0)
                    {
                        foreach (CodeReviewAttribute codeReviewAttribute in objects)
                        {
                            if (codeReviewAttribute.IsApproved == false)
                            {
                                isApproved = false;
                            }
                            Console.WriteLine("Code review name - {0}\nCode review date: {1}\nIs approved Code review: {2}\n",
                               codeReviewAttribute.ReviewerName, codeReviewAttribute.ReviewDate.ToShortDateString(), codeReviewAttribute.IsApproved);
                        }
                    }
                    else
                    {
                        isApproved = false;
                    }
                }
                return isApproved;
            }
            else
            {
                return false;
            }
            
        }
    }
}
