using WebBanHang.Models;

namespace WebBanHang.Repositories
{
    public class MockCategoryRepository :ICategoryRepository 
    {
        private List<Category> _categories;
        public MockCategoryRepository()
        {
            _categories = new List<Category>
            {
              new Category {CategoryId = 1, Name = "Laptop"},
              new Category {CategoryId = 2, Name = "Dien thoai"}
            };
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categories;
        }
      
        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(p => p.CategoryId == id);
        }
        public void Add(Category cate)
        {
            cate.CategoryId = _categories.Max(p => p.CategoryId) + 1;
            _categories.Add(cate);
        }
        public void Update(Category cate)
        {
            var index = _categories.FindIndex(p => p.CategoryId == cate.CategoryId);
            if (index != -1)
            {
                _categories[index] = cate;
            }
        }
        public void Delete(int id)
        {
            var cate = GetById(id);
            if (cate != null)
            {
                _categories.Remove(cate);
            }
        }
    }
}
