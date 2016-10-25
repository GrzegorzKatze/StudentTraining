namespace ConsoleApplication1
{
    public class NullConditionalOperatorExample
    {
        public static void NormalCase()
        {
            var ExampleObj = new ExampleObject();
            if (ExampleObj == null)
                return;
            else if (!ExampleObj.Field_A.Equals("default"))
            {
                //log action;
            }
        }

        public static void NullConditionCase()
        {
            ExampleObject ExampleObj = null;
            //ExampleObject ExampleObj = new ExampleObject("non default field content");
            string _fieldContent = ExampleObj?.Field_A;
            string stringMethodContent = ExampleObj?.ToString();
        }

        public static void NullConditionIfCase()
        {
            ExampleObject ExampleObj = null;
            //ExampleObject ExampleObj = new ExampleObject();

            if (ExampleObj.IsFieldAIsDefault())
            {
                //log action
            }

            //if (ExampleObj != null && ExampleObj.IsFieldAIsDefault())
            //{
            //    //log action
            //}

            //if (ExampleObj?.IsFieldAIsDefault() == true)
            //{
            //    //log action
            //}
        }
    }

    internal class ExampleObject
    {
        public string Field_A { get; set; }

        public ExampleObject(string _fieldA = "default")
        {
            Field_A = _fieldA;
        }

        public bool IsFieldAIsDefault()
        {
            if (Field_A.Equals("default"))
                return true;
            else return false;
        }

        public override string ToString()
        {
            return "This is new ToString method definition";
        }
    }
}