using eTutor.DataService.Interrfaces;
using eTutor.DataService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace eTutor.DataService.Data
{
    public class MasterData : IMasterData
    {
        private readonly eTutorDbContext _context;
        public MasterData(eTutorDbContext context)
        {
            _context = context;
        }
        public async Task AddMasterData(string tableName)
        {
            if (await _context.Users.AnyAsync()) return;

            //Insert master data based on table type
            switch (tableName)
            {
                case "usertypes":
                    var userTypes = await System.IO.File.ReadAllTextAsync("MasterData/UserTypes.json");
                    var types = JsonSerializer.Deserialize<List<UserTypes>>(userTypes);
                    foreach (var type in types)
                    {
                        _context.UserTypes.Add(type);
                    }
                    break;
                case "subjects":
                    var subjectTypes = await System.IO.File.ReadAllTextAsync("MasterData/Subjects.json");
                    var subjects = JsonSerializer.Deserialize<List<Subjects>>(subjectTypes);
                    foreach (var subject in subjects)
                    {
                        _context.Subjects.Add(subject);
                    }
                    break;
                case "standards":
                    var standardTypes = await System.IO.File.ReadAllTextAsync("MasterData/Standards.json");
                    var standards = JsonSerializer.Deserialize<List<Standard>>(standardTypes);
                    foreach (var standard in standards)
                    {
                        _context.Standards.Add(standard);
                    }
                    break;
                case "institutes":
                    var institutionTypes = await System.IO.File.ReadAllTextAsync("MasterData/Institutes.json");
                    var institute = JsonSerializer.Deserialize<List<Institute>>(institutionTypes);
                    foreach (var ins in institute)
                    {
                        _context.Institutes.Add(ins);
                    }
                    break;
                case "boards":
                    var boardsTypes = await System.IO.File.ReadAllTextAsync("MasterData/Boards.json");
                    var boards = JsonSerializer.Deserialize<List<BoardOrUniversity>>(boardsTypes);
                    foreach (var board in boards)
                    {
                        _context.BoardOrUniversities.Add(board);
                    }
                    break;
            }
        await _context.SaveChangesAsync();
        }
    }
}
