using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreGrpcDemo.Client.Contracts
{
    public interface ICalculatorClient
    {
        int Add(int lhs, int rhs);
        int Subtract(int lhs, int rhs);
        int Multiply(int lhs, int rhs);
        int Divide(int lhs, int rhs);
    }
}
