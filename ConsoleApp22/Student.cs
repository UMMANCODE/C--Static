using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22 {
    internal class Student {
        private string? _fullname;
        private string? _groupNo;
        private byte _age;

        public string? GroupNo {
            get {
                return _groupNo;
            }
            set {
                if (CheckGroupNo(value)) {
                    _groupNo = value;
                }
               }
        }

        public string? Fullname {
            get {
                return _fullname;
            }
            set {
                if (CheckFullname(value)) {
                    _fullname = value.Trim();
                }
            }
        }

        public byte Age {
            get {
                return _age;
            }
            set {
                if (value > 18 && value < 65) {
                    _age = value;
                }
            }
        }

        public Student(string? fullname, string? groupNo, byte age) {
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }

        public void Display () {
            Console.WriteLine();
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"GroupNo: {GroupNo}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine();
        }

        public static bool CheckGroupNo(string? value) {
            if (value is null) return false;
            if (char.IsLetter(value[0]) && char.IsUpper(value[0])) {
                if (char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3])) {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckFullname(string? value) {
            // Aradaki boslugun birden cox olmamsini yoxlaya bilerdim. Amma hem sualda deyilmeyib, hem de kodu cox uzatmaq istemedim.
            if (value is null) return false;
            value = value.Trim();
            for (int i = 0; i < value.Length; i++) {
                if (!char.IsLetter(value[i]) && !char.IsWhiteSpace(value[i])) {
                    return false;
                }
            }

            if (value.IndexOf(" ") > 0) {
                return true;
            }
            return false;
        }
    }
}
