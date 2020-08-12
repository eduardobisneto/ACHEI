﻿using achei.comp.repository.domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace achei.comp.repository.mapper
{
    public class Map<T> where T : Base
    {
        public Map(EntityTypeBuilder<T> builder)
        {
            builder
                .HasKey(k => k.Id);
        }
    }
}