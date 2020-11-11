using RumosSchool.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Application.Services
{
    class ClassroomServices
    {

        private ClassRoomRepository _repo;

        public ClassroomServices()
        {
            _repo = new ClassRoomRepository();
        }
    
    public List<ClassroomServices> GetAll()
        {
            return null;
        }

        public ClassroomServices GetById(int Id)
        {
            return null;
        }

        public void Add(ClassroomServices Classroom)
        {

        }

        public void Update(ClassroomServices Classroom)
        {

        }
        public void Remove(int Id)
        {

        }
    }
}
