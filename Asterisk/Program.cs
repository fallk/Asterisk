using System;
using System.Collections.Generic;

namespace Asterisk
{
    internal class Program
    {
        private const string Asterisk =
                @"          !
         ""#
         $%
         &'
         ()
         *+
         ,-
         ./
         01
23456789:;<=>?@ABCDEF
GHIJKLMNOPQRSTUVWXYZ[
        \]^_
       `a  bc
      de    fg
     hi      jk
    lm        no
   pq          rs
  tu            vw
 xy              z{
|}                ~";
        public static void Main(string[] args)
        {
            Console.WriteLine(Asterisk);
        }
    }
}