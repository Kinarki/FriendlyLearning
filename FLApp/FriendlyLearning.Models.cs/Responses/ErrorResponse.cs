using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyLearning.Models.cs.Responses
{
    public class ErrorResponse : BaseResponse
    {
        public List<String> Errors { get; set; }

        public ErrorResponse(string errMsg)
        {
            Errors = new List<string>();

            Errors.Add(errMsg);
            this.IsSuccessful = false;
        }

        public ErrorResponse(IEnumerable<String> errMsg)
        {
            Errors = new List<String>();

            Errors.AddRange(errMsg);
            this.IsSuccessful = false;
        }
    }
}
