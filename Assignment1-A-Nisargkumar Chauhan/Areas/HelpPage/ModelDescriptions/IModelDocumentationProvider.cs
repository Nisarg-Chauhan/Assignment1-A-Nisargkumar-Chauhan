using System;
using System.Reflection;

namespace Assignment1_A_Nisargkumar_Chauhan.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}