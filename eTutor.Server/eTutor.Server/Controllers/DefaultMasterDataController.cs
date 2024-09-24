using eTutor.DataService.Data;
using eTutor.DataService.Interrfaces;
using eTutor.Server.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTutor.Server.Controllers
{
    public class DefaultMasterDataController : BaseApiController
    {
        private readonly eTutorDbContext _context;
        private readonly IMasterData _masterData;

        public DefaultMasterDataController(eTutorDbContext context, IMasterData masterData)
        {
            _context = context;
            _masterData = masterData;
        }

        [HttpPost]
        public async Task<ActionResult<string>> InsertMasterData(MasterDataNamesDto masterDataNames)
        {
            if (masterDataNames != null)
            {
                foreach(var masterDataName in masterDataNames.TableNames)
                {
                    await _masterData.AddMasterData(masterDataName.ToLower());
                }
            }
            return Ok(masterDataNames);
        }
    }
}
