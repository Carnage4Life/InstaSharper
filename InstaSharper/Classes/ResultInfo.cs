using System;

namespace InstaSharper.Classes
{
    public class ResultInfo
    {
        public ResultInfo(string message)
        {
            Message = message;
        }

        public ResultInfo(Exception exception)
        {
            Exception = exception;
            Message = exception?.Message;
            ResponseType = ResponseType.InternalException;
        }

        public ResultInfo(ResponseType responseType, string errorMessage)
        {
            ResponseType = responseType;
            Message = errorMessage;
        }

         public ResultInfo(ResponseType responseType, string errorMessage, string url)
        {
            ResponseType = responseType;
            Message = errorMessage;
            ChallengeUrl = url; 
        }

        public string ChallengeUrl { get;  }

        public Exception Exception { get; }

        public string Message { get; }

        public ResponseType ResponseType { get; }

        public override string ToString()
        {
            return $"{ResponseType.ToString()}: {Message}.";
        }
    }
}