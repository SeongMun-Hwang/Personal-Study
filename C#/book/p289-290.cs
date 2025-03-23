using static System.Console;
using System;
using System.Linq;
using System.Globalization;
using System.Net.Http.Headers;

namespace CsConsole
{
    //p288
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();
        public void SetConfig(string item, string value)
        {
            ItemValue itemValue = new ItemValue();
            itemValue.SetValue(this,item,value);
        }

        public string GetConfig(string item)
        {
            foreach(ItemValue itemValue in listConfig)
            {
                if (itemValue.GetItem() == item)
                    return itemValue.GetValue();
            }
            return "";
        }
        private class ItemValue
        {
            private string item;
            private string value;
            public void SetValue(Configuration config,string item, string value)
            {
                this.item = item;
                this.value = value;
                bool found = false;
                for(int i=0; i<config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found =true;
                        break;
                    }
                }
                if(found ==false)
                    config.listConfig.Add(this);
            }
            public string GetItem() { return item; }
            public string GetValue() { return value; }
        }
    }
    
    class MainApp
    {

        static void Main(string[] args)
        {
            //P289
            Configuration config = new Configuration();
            config.SetConfig("version", "V_5.0");
            config.SetConfig("size", "655,324 KB");

            WriteLine(config.GetConfig("version"));
            WriteLine(config.GetConfig("size"));

            config.SetConfig("version", "V_5.0.1");
            WriteLine(config.GetConfig("version"));
            ReadLine();
        }
    }
}