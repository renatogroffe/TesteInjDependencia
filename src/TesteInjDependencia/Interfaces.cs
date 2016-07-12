using System;

namespace TesteInjDependencia
{
    public interface ITesteA
    {
        Guid IdReferencia { get; }
    }

    public interface ITesteB
    {
        Guid IdReferencia { get; }
    }
}