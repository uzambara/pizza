using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Innoscripta.Pizza.Contracts;
using Innoscripta.Pizza.Contracts.Comment;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Enums;
using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Factories;
using Innoscripta.Pizza.Models;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Innoscripta.Pizza.Services.Implementations
{
    public class CommentService: ICommentService
    {
        // Repositories
        private readonly BaseRepository<CommentEntity> _commentRepository;
        private readonly BaseRepository<UserEntity> _userRepository;

        // Services
        private readonly IUserService _userService;

        // Factories
        private readonly UserEntityFactory _userEntityFactory;
        private readonly CommentFactory _commentFactory;

        // Mapper
        private readonly IMapper _mapper;

        public CommentService(
            BaseRepository<CommentEntity> commentRepository,
            BaseRepository<UserEntity> userRepository,
            IUserService userService,
            UserEntityFactory userEntityFactory,
            CommentFactory commentFactory,
            IMapper mapper)
        {
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _userService = userService;
            _userEntityFactory = userEntityFactory;
            _commentFactory = commentFactory;
            _mapper = mapper;
        }

        public async Task<CommentModel> CreateCommentAsync(AddCommentRequest request)
        {
            var user = await _userService.GetUserByPhoneAsync(request.Phone);
            if (user == null)
            {
                user = _userEntityFactory.Create(
                    request.Name,
                    null,
                    request.Phone,
                    null,
                    CreateUserPlace.FromComment);
                _userRepository.Add(user);
            }

            var comment = _commentFactory.Create(user, request.Text, request.Stars);
            _commentRepository.Add(comment);
            await _commentRepository.SaveChangesAsync();

            return _mapper.Map<CommentModel>(comment);
        }

        public async Task<PartialLoadDataResponse<CommentModel>> GetCommentsAsync(PartialLoadDataRequest request)
        {
            var query = _commentRepository.GetAll().Include(c => c.User);
            var totalCount = await query.CountAsync();
            if (totalCount == 0)
            {
                return PartialLoadDataResponse<CommentModel>.Empty;
            }

            var comments = await query
                .OrderByDescending(comment => comment.Date).Skip(request.Offset)
                .Take(request.ItemsCount)
                .ToListAsync();

            var commentModels = _mapper.Map<List<CommentModel>>(comments);
            return new PartialLoadDataResponse<CommentModel>
            {
                Items = commentModels,
                TotalCount = totalCount,
                MoreItemsExists = commentModels.Count + request.Offset < totalCount
            };
        }
    }
}