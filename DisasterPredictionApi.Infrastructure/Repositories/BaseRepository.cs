using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DisasterPredictionApi.Application.Interfaces;
using DisasterPredictionApi.Infrastructure.Data;


namespace DisasterPredictionApi.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbContext;

        public BaseRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbContext = _context.Set<T>();
        }

        // ดึงข้อมูลตาม ID
        public async Task<T?> GetById(int id) => await _dbContext.FindAsync(id);

        // ดึงข้อมูลทั้งหมด
        public async Task<IEnumerable<T>> GetAll() => await _dbContext.ToListAsync();

        // เพิ่มข้อมูล
        public async Task Add(T entity) => await _dbContext.AddAsync(entity);

        // อัพเดทข้อมูล
        public void Update(T entity) => _dbContext.Update(entity);

        // ลบข้อมูล
        public void Remove(T entity) => _dbContext.Remove(entity);
    }

}
