

namespace Gestion_de_Estudiantes_por_Asignatura.OperationResult
{
    public class OperationResult<TModel>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public TModel Data { get; set; }

        public OperationResult()
        {
            
        }

        public OperationResult(bool isSuccess, string message, dynamic? data = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public static OperationResult<TModel> Success(string Message, dynamic? data = null) 
        {
            return new OperationResult<TModel>(true, Message, data);
        }

        public static OperationResult<TModel> Failure(string Message) 
        {
            return new OperationResult<TModel>(false, Message);
        }
    }
}
