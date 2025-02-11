﻿using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.Student
{
    public class StudentsClassRoom
    {
        public StudentsClassRoom(int id)
        {
            Id = id;
        }

        public StudentsClassRoom(int studentsId, int classRoomId)
        {
            Students = new Students(studentsId);
            ClassRoom = new ClassRoom(classRoomId);
        }

        public int Id { get; set; }
        public int StudentsId { get; set; }
        public Students Students { get; set; }
        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
