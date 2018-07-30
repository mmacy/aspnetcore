﻿namespace Microsoft.AspNetCore.Mvc.Analyzers.TestFiles.ApiActionsDoNotRequireExplicitModelValidationCheckAnalyzerIntegrationTest
{
    [ApiController]
    [Route("/api/[controller]")]
    public class DiagnosticsAreReturned_ForApiActionsWithModelStateChecksWithoutBracing : ControllerBase
    {
        public IActionResult Method(int id)
        {
            if (id == 0)
                return BadRequest();

            /*MM*/if (!ModelState.IsValid)
                return BadRequest();

            return Ok();
        }
    }
}
