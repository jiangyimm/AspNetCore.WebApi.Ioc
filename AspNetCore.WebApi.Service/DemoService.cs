﻿using AspNetCore.WebApi.IService;

namespace AspNetCore.WebApi.Service
{
    public class DemoService : IDemoService
    {
        public string GetString(string text)
        {
            return text;
        }

        public int key { get; set; } = 1;
    }
}
