namespace Ticket.Infrastructure.Elastics
{
    public interface IEsRepo<T>
    {
        IElasticClient Client();

        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        /// <param name="documents"></param>
        /// <returns></returns>
        Task<IEnumerable<string>> AddOrUpdateBulk(IEnumerable<T> documents);

        /// <summary>
        /// Xóa tất cả dữ liệu của index
        /// </summary>
        /// <returns></returns>
        Task<long> RemoveAll();
    }

    public class EsRepo<T> : IEsRepo<T> where T : class
    {
        private readonly IElasticClient _client;
        private readonly string _indexName;

        public EsRepo(IElasticClient client)
        {
            _client = client;
            _indexName = typeof(T).Name.ToLower();
        }

        public IElasticClient Client()
        {
            return _client;
        }

        public async Task<IEnumerable<string>> AddOrUpdateBulk(IEnumerable<T> documents)
        {
            var response = await _client.BulkAsync(b => b
                   .Index(_indexName)
                   .UpdateMany(documents, (ud, d) => ud.Doc(d).DocAsUpsert(true))
               );
            return response.Items.Select(x => x.Id);
        }

        public async Task<long> RemoveAll()
        {
            var response = await _client.DeleteByQueryAsync<T>(d => d.Index(_indexName).Query(q => q.MatchAll()));
            return response.Deleted;
        }
    }
}
