﻿using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository prodcutRepository)
        {
            _productRepository = prodcutRepository;
        }

        public ViewResult List() => View(_productRepository.Products);
    }
}