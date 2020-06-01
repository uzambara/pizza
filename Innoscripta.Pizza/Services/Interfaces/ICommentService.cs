using System.Collections.Generic;
using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts;
using Innoscripta.Pizza.Contracts.Comment;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface ICommentService
    {
        Task<CommentModel> CreateCommentAsync(AddCommentRequest request);
        Task<PartialLoadDataResponse<CommentModel>> GetCommentsAsync(PartialLoadDataRequest request);
    }
}