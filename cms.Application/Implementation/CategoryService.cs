using cms.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using cms.Application.ViewModels.Product;
using cms.Data.IRepositories;
using cms.Infrastructure.Interfaces;
using AutoMapper;
using cms.Data.Entities;
using System.Linq;
using AutoMapper.QueryableExtensions;
using cms.Data.Enum;

namespace cms.Application.Implementation
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }


        public CategoryViewModel Add(CategoryViewModel categoryVm)
        {
            var category = Mapper.Map<CategoryViewModel, Category>(categoryVm);
            _categoryRepository.Add(category);
            return categoryVm;
        }

        public void Delete(int id)
        {
            _categoryRepository.Remove(id);
        }

        public List<CategoryViewModel> GetAll()
        {
            var list = _categoryRepository.FindAll().OrderBy(c => c.ParentId).ProjectTo<CategoryViewModel>().ToList();
            return list;
        }

        public List<CategoryViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _categoryRepository.FindAll(c => c.Name.Contains(keyword)
                    || c.Description.Contains(keyword)).OrderBy(c => c.ParentId).ProjectTo<CategoryViewModel>().ToList();
            }
            else
            {
                return _categoryRepository.FindAll().OrderBy(c => c.ParentId).ProjectTo<CategoryViewModel>().ToList();
            }
        }

        public List<CategoryViewModel> GetAllByParentId(int parentId)
        {
            var list = _categoryRepository.FindAll(c => c.Status == Status.Active && c.ParentId == parentId)
                .ProjectTo<CategoryViewModel>().ToList();
            return list;
        }

        public CategoryViewModel GetById(int id)
        {
            var category = _categoryRepository.FindById(id);
            return Mapper.Map<Category, CategoryViewModel>(category);
        }

        public List<CategoryViewModel> GetHomeCategories(int top)
        {
            throw new NotImplementedException();
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(CategoryViewModel categoryVm)
        {
            var category = Mapper.Map<CategoryViewModel, Category>(categoryVm);
            _categoryRepository.Update(category);
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            var sourceCategory = _categoryRepository.FindById(sourceId);
            sourceCategory.ParentId = targetId;
            _categoryRepository.Update(sourceCategory);

            var sibling = _categoryRepository.FindAll(c => items.ContainsKey(c.Id));
            foreach (var child in sibling)
            {
                child.SortOrder = items[child.Id];
                _categoryRepository.Update(child);
            }
        }
    }
}
