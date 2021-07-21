using Grpc.Core;
using Microsoft.Extensions.Logging;
using NetCoreGrpcDemo.Service.Protos;
using System.Threading.Tasks;

namespace NetCoreGrpcDemo.Service.Services
{
    public class CalculatorService : Calculator.CalculatorBase
    {
        private readonly ILogger<CalculatorService> _logger;

        public CalculatorService(ILogger<CalculatorService> logger)
        {
            _logger = logger;
        }

        public override Task<Result> Add(Operands operands, ServerCallContext context)
        {
            _logger.LogInformation("Adding {0} and {1}", operands.Lhs, operands.Rhs);
            return Task.FromResult(new Result()
            {
                Res = operands.Lhs + operands.Rhs
            });
        }

        public override Task<Result> Subtract(Operands operands, ServerCallContext context)
        {
            _logger.LogInformation("Subtracting {0} to {1}", operands.Rhs, operands.Lhs);
            return Task.FromResult(new Result()
            {
                Res = operands.Lhs - operands.Rhs
            });
        }

        public override Task<Result> Multiply(Operands operands, ServerCallContext context)
        {
            _logger.LogInformation("Multiplying {0} by {1}", operands.Lhs, operands.Rhs);
            return Task.FromResult(new Result()
            {
                Res = operands.Lhs * operands.Rhs
            });
        }

        public override Task<Result> Divide(Operands operands, ServerCallContext context)
        {
            _logger.LogInformation("Dividing {0} by {1}", operands.Lhs, operands.Rhs);
            return Task.FromResult(new Result()
            {
                Res = operands.Lhs / operands.Rhs
            });
        }
    }
}
