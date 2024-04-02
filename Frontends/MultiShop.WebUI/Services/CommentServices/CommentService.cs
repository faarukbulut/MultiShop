using MultiShop.DtoLayer.CommentDtos.UserCommentDtos;

namespace MultiShop.WebUI.Services.CommentServices
{
    public class CommentService : ICommentService
    {
        private readonly HttpClient _httpClient;

        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateComment(CreateUserCommentDto createCommentDto)
        {
            await _httpClient.PostAsJsonAsync<CreateUserCommentDto>("comments", createCommentDto);
        }

        public async Task DeleteComment(string id)
        {
            await _httpClient.DeleteAsync("comments?id=" + id);
        }

        public async Task<List<ResultUserCommentDto>> GetAllComment()
        {
            var responseMessage = await _httpClient.GetAsync("comments");
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultUserCommentDto>>();
            return values;
        }

        public async Task<UpdateUserCommentDto> GetByIdComment(string id)
        {
            var responseMessage = await _httpClient.GetAsync("comments/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateUserCommentDto>();
            return values;
        }

        public async Task UpdateComment(UpdateUserCommentDto updateCommentDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateUserCommentDto>("comments", updateCommentDto);
        }

        public async Task<List<ResultUserCommentDto>> CommentListByProductId(string id)
        {
            var responseMessage = await _httpClient.GetAsync("comments/commentlistbyproductid/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultUserCommentDto>>();
            return values;
        }
    }
}
