using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Comment;
using Innoscripta.Pizza.Routing;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Innoscripta.Pizza.Controllers
{
    public class CommentController: BaseController
    {
        public readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        [Route(ApiRoutes.Comment.Create)]
        public async Task<AddCommentResponse> CreateComment(AddCommentRequest request)
        {
            await _commentService.CreateCommentAsync(request);
            return new AddCommentResponse();
        }

        [HttpGet]
        [Route(ApiRoutes.Comment.Get)]
        public async Task<GetCommentsResponse> GetComments([FromQuery]GetCommentsRequest request)
        {
            var result = await _commentService.GetCommentsAsync(request);
            return new GetCommentsResponse()
            {
                Items = result.Items,
                TotalCount = result.TotalCount,
                MoreItemsExists = result.MoreItemsExists
            };
        }
    }
}