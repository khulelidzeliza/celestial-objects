using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.DTO;
using WebApplication5.Mapping;
using WebApplication5.Model;
using WebApplication5.Request;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public CelestialObjectController(DataContext context, IMapper __mapper)
        {
            _dataContext = context;
            _mapper = __mapper;
        }


        // add staff                   1

        [HttpPost("add-new")]

        public ActionResult getCelestial(AddCelestilObject req)
        {
            var celtoAdd = _mapper.Map<CelestialObject>(req);
            _dataContext.CelestialObjects.Add(celtoAdd);
            _dataContext.SaveChanges();

            return Ok(celtoAdd);
        }


        //                        dto 1
        [HttpGet("get-display-info")]
        public ActionResult getDisplayInfo()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<DisplayInfoDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 2

        [HttpGet("get-Detailed-info/{id}")]
        public ActionResult getDetailedInfo(int id)
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<DetInfoDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 3

        [HttpGet("get-CelestialObjects-Scientific")]
        public ActionResult GetObjects()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<ScientificDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 4

        [HttpGet("get-location")]

        public ActionResult GetLocation()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<LocationDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 5

        [HttpGet("get-history")]

        public ActionResult GetHistory()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<HistoryDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 6

        [HttpGet("get-composition")]

        public ActionResult GetComposition()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<CompositionDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 7

        [HttpGet("get-classification")]

        public ActionResult GetClassification()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<ClassificationDTO>>(info);

            return Ok(infostoreturn);
        }


        //                        dto 8

        [HttpGet("get-orbit")]

        public ActionResult GetOrbit()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<OrbitDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 9

        [HttpGet("get-type/{type}")]

        public ActionResult GetClassification(string type)
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<ClassificationDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 10

        [HttpGet("get-constellation/{constellation}")]

        public ActionResult GetConstellation(string constellation)
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<ConstellationDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 11

        [HttpGet("get-interesting")]

        public ActionResult GetInteresting()
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<InterestingDTO>>(info);

            return Ok(infostoreturn);
        }

        //                        dto 12

        [HttpGet("Searc/{constellation}")]

        public ActionResult Search(string constellation)
        {
            var info = _dataContext.CelestialObjects.ToList();
            var infostoreturn = _mapper.Map<List<SearchDTO>>(info);

            return Ok(infostoreturn);
        }


    }
}
