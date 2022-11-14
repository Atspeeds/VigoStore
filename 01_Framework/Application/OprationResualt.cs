namespace _01_Framework.Application
{
    public class OprationResualt
    {
        public string Massage { get; set; }
        public bool IsSuccedded { get; set; }

        public OprationResualt Faild(string massage)
        {
            Massage = massage;
            IsSuccedded= false;
            return this;
        }
        public OprationResualt Succedded(string massage ="عملیات با موفقیت انجام شد")
        {
            Massage = massage;
            IsSuccedded = true;
            return this;
        }
    }
}
