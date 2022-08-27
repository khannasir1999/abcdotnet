namespace abc.CommonLayer.Model
{
    public class UpdateRecordRequest
    {
        public int id { set; get; }
        public string Username { set; get; }

        public int Age { set; get; }
         public string Password { set; get; }
        public string Confirm_Password { set; get; }


    }
    public class UpdateRecordResponse
    {


        public bool IsSuccess { set; get; }
        public string Message { set; get; }
    }
}
