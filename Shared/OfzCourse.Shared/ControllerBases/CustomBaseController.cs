using Microsoft.AspNetCore.Mvc;
using OfzCourse.Shared.Dtos;

namespace OfzCourse.Shared.ControllerBases
{
    public class CustomBaseController: ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
