using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace InterviewSolution.Medium.Problems
{
    public class XMLEncoding
    {

        public void Encode(XmlElement root, StringBuilder sb)
        {

        }

        private void Encode(string v, StringBuilder sb)
        {
            sb.Append(v);
            sb.Append("");
        }

        private void Encode(XmlAttribute attr, StringBuilder sb)
        {
            //Encode(attr.)
        }


    }
}
