using MediatR;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace AzureStorage.Api
{
    public class GetDigitalAssetByIdQuery
    {
        public class Request : IRequest<Response> {
            public Guid DigitalAssetId { get; set; }
        }

        public class Response
        {
            public DigitalAssetDto DigitalAsset { get; set; }
        }

        public class Handler : IRequestHandler<Request, Response>
        {            
            public Handler()
            {

            }

            public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
