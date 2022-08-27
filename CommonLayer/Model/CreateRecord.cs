﻿namespace abc.CommonLayer.Model
    
{

    public class CreateRecordRequest
    {

        public string UserName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        
        public string Photo { get; set; }



    }
    public class CreateRecordResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}

