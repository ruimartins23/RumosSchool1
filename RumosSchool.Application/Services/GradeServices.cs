using RumosSchool.Data.Repositories;
using RumosSchool.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Application.Services
{
    class GradeServices
    {

        private GradeRepository _repo;

        public GradeRepository()
        {
            _repo = new GradeRepository();
        }
        public List<Grades> GetAll()
        {
            return null;
        }

        public Grades GetById(int Id)
        {
            return null;
        }

        public void Add(Grades Grades)
        {

        }

        public void Update(Grades Grades)
        {

        }
        public void Remove(int Id)
        {

        }
    }
}
