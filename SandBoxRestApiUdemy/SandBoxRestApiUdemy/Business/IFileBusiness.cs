using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxRestApiUdemy.Business
{
    public interface IFileBusiness
    {
        byte[] GetPDFFile();
    }
}
