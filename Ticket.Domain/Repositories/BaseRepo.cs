namespace Ticket.Domain.Repositories
{
    public interface IBaseRepo<TEntity>
    {
        /// <summary>
        /// Chèn dữ liệu
        /// </summary>
        /// <param name="entity">Dữ liệu</param>
        /// <param name="action">Id người thực hiện</param>
        /// <returns></returns>
        Task Insert(TEntity entity, string action);

        /// <summary>
        /// Chèn danh sách dữ liệu
        /// </summary>
        /// <param name="entities">Danh sách dữ liệu</param>
        /// <param name="action">Id người thực hiện</param>
        /// <returns></returns>
        Task InsertMultiple(List<TEntity> entities, string action);

        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        /// <param name="entity">Dữ liệu</param>
        /// <param name="action">Id người thực hiện</param>
        /// <returns></returns>
        Task Update(TEntity entity, string action);

        /// <summary>
        /// Cập nhật danh sách dữ liệu
        /// </summary>
        /// <param name="entities">Danh sách dữ liệu</param>
        /// <param name="action">Id người thực hiện</param>
        /// <returns></returns>
        Task UpdateMultiple(List<TEntity> entities, string action);

        /// <summary>
        /// Xóa dữ liệu
        /// </summary>
        /// <param name="entity">Dữ liệu</param>
        /// <param name="action">Id người thực hiện</param>
        /// <returns></returns>
        Task Delete(TEntity entity, string action);

        /// <summary>
        /// Xóa danh sách dữ liệu
        /// </summary>
        /// <param name="entities">Danh sách dữ liệu</param>
        /// <param name="action">Id người thực hiện</param>
        /// <returns></returns>
        Task DeleteMultiple(List<TEntity> entities, string action);
    }

    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : BaseAudit
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbset;
        protected readonly bool _timeGenerateId;

        public BaseRepo(ApplicationDbContext context, bool timeGenerateId = false)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
            _timeGenerateId = timeGenerateId;
        }

        public async Task Insert(TEntity entity, string action)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.CreatedBy = action;
            await _context.BulkInsertAsync([entity]);
        }

        public async Task InsertMultiple(List<TEntity> entities, string action)
        {
            entities.ForEach(_ =>
            {
                _.CreatedAt = ApplicationExtensions.NOW;
                _.CreatedBy = action;
            });
            await _context.BulkInsertAsync(entities);
        }

        public async Task Update(TEntity entity, string action)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            entity.UpdatedBy = action;
            await _context.BulkUpdateAsync([entity]);
        }

        public async Task UpdateMultiple(List<TEntity> entities, string action)
        {
            entities.ForEach(_ =>
            {
                _.UpdatedAt = ApplicationExtensions.NOW;
                _.UpdatedBy = action;
            });
            await _context.BulkUpdateAsync(entities);
        }

        public async Task Delete(TEntity entity, string action)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            entity.UpdatedBy = action;
            entity.IsDeleted = true;
            await _context.BulkUpdateAsync([entity]);
        }

        public async Task DeleteMultiple(List<TEntity> entities, string action)
        {
            entities.ForEach(_ =>
            {
                _.UpdatedAt = ApplicationExtensions.NOW;
                _.UpdatedBy = action;
                _.IsDeleted = true;
            });
            await _context.BulkUpdateAsync(entities);
        }
    }
}
