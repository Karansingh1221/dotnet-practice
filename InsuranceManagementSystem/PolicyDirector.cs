using System;
using InsuranceClass;
namespace PolicyDirectorClass{
    class PolicyDirector{
        private Dictionary<int,string> dict=new Dictionary<int,string> ();

        public string this[int id]{
            get{
                if(dict.ContainsKey(id)){
                    return dict[id];
                }else{
                    return "Invalid Id";
                }
            }
            set{
                    dict[id]=value;
            }
        }
        public string this[string name]{
            get{
                return dict.FirstOrDefault(k=>k.Value == name).Value;
            }
        }
    }
}