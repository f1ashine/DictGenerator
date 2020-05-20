using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DictGenerator
{
    class Config
    {
        public String combinedGroup { set; get; }
        public List<String> Symobls { set; get; }
        public List<String> commonString { set; get; }

        private JObject obj;
        public Config()
        {
            this.combinedGroup = "";
            this.Symobls = new List<string>();
            this.commonString = new List<string>();
        }

        public void setObj(JObject o)
        {
            this.obj = o;
            this.combinedGroup = this.obj["combination"].Value<String>();
        }

        public JObject getObj()
        {
            return this.obj;
        }
    }
}
