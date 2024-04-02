using MultiShop.DtoLayer.CommentDtos.UserCommentDtos;

namespace MultiShop.WebUI.Services.CommentServices
{
    public interface ICommentService
    {
        Task<List<ResultUserCommentDto>> GetAllComment();
        Task CreateComment(CreateUserCommentDto createCommentDto);
        Task UpdateComment(UpdateUserCommentDto updateCommentDto);
        Task DeleteComment(string id);
        Task<UpdateUserCommentDto> GetByIdComment(string id);
        Task<List<ResultUserCommentDto>> CommentListByProductId(string id);
    }
}
