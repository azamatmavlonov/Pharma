using Pharma.Application.Common.Interfaces;
using Pharma.Application.Common.Interfaces.Repositories;
using Pharma.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pharma.Application.Services
{
    public class MedicamentService : BaseService<Medicament>, IMedicamentService
    {
        private readonly IRepository<Medicament> _repository;

        public MedicamentService(IRepository<Medicament> repository)
        {
            _repository = repository;
        }

        public override Medicament Create(Medicament entity)
        {
            if (entity == null) throw new NullReferenceException();

            _repository.Add(entity);
            _repository.SaveChanges();
            return entity;
        }

        public override bool Delete(ulong id)
        {
            var entity = _repository.FindById(id);

            if (entity == null) throw new NullReferenceException();

            _repository.Delete(entity);
            _repository.SaveChanges();
            return true;
        }

        public override Medicament Get(ulong id)
        {
            var entity = _repository.FindById(id);

            if (entity == null) throw new NullReferenceException();

            return entity;
        }

        public override Medicament Update(Medicament medicament, ulong id)
        {
            var entity = _repository.FindById(id);

            if (entity == null) throw new NullReferenceException();

            entity.Name = medicament.Name;
            entity.Type = medicament.Type;
            entity.Form = medicament.Form;
            entity.Category = medicament.Category;
            entity.Volume = medicament.Volume;
            entity.ProductionData = medicament.ProductionData;
            entity.ShelfLife = medicament.ShelfLife;
            entity.Producer = medicament.Producer;
            entity.Price = medicament.Price;
            entity.IsActive = medicament.IsActive;
            entity.WithPrescription = medicament.WithPrescription;
            entity.Description = medicament.Description;

            _repository.Update(entity);
            _repository.SaveChanges();
            return entity;
        }
    }
}
