using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Command reqest, CancellationToken cancellationToken)
            {
                _context.Activities.Add(reqest.Activity);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }

    }
}