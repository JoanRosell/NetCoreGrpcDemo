using Grpc.Net.Client;
using NetCoreGrpcDemo.Client.Contracts;
using NetCoreGrpcDemo.Service.Protos;

namespace NetCoreGrpcDemo.Client.Implementations
{
    public class CalculatorClient : ICalculatorClient
    {
        private readonly string _connectionString;

        public CalculatorClient(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Add(int lhs, int rhs)
        {
            using var channel = GrpcChannel.ForAddress(_connectionString);
            var client = new Calculator.CalculatorClient(channel);
            var res = client.Add(new Operands
            {
                Lhs = lhs,
                Rhs = rhs
            });

            return res.Res;
        }

        public int Subtract(int lhs, int rhs)
        {
            using var channel = GrpcChannel.ForAddress(_connectionString);
            var client = new Calculator.CalculatorClient(channel);
            var res = client.Subtract(new Operands
            {
                Lhs = lhs,
                Rhs = rhs
            });

            return res.Res;
        }

        public int Multiply(int lhs, int rhs)
        {
            using var channel = GrpcChannel.ForAddress(_connectionString);
            var client = new Calculator.CalculatorClient(channel);
            var res = client.Multiply(new Operands
            {
                Lhs = lhs,
                Rhs = rhs
            });

            return res.Res;
        }

        public int Divide(int lhs, int rhs)
        {
            using var channel = GrpcChannel.ForAddress(_connectionString);
            var client = new Calculator.CalculatorClient(channel);
            var res = client.Divide(new Operands
            {
                Lhs = lhs,
                Rhs = rhs
            });

            return res.Res;
        }
    }
}
