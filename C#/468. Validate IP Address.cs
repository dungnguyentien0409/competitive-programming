/*
 * Link: https://leetcode.com/problems/validate-ip-address/
 * Author: Dung Nguyen Tien (Chris)
*/

using System.Text.RegularExpressions;

public class Solution {
    public string ValidIPAddress(string IP) {
        if (IP.IndexOf('.') > 0) {
            return validIPv4(IP) ? "IPv4" : "Neither";
        }
        else {
            return validIPv6(IP) ? "IPv6" : "Neither";
        }
    }
    
    public bool validIPv4(string IP) {
        var strs = IP.Split(".");
        
        if (strs.Length != 4) return false;
        
        foreach(var str in strs) {
            Console.WriteLine(str + " " + Regex.IsMatch(str, "[^0-9]"));
            if (str.Length == 0
               || Regex.IsMatch(str, "[^0-9]")
               || str.Length > 1 && str[0] == '0'
               || str.Length > 3
               || str.CompareTo("255") > 0)
                return false;
        }
        
        return true;
    }
    
    public bool validIPv6(string IP) {
        var strs = IP.Split(":");
        
        if (strs.Length != 8) return false;
        
        foreach(var str in strs) {
            if (str.Length == 0
               || str.Length > 4
               || Regex.IsMatch(str, "[^0-9a-fA-F]"))
                return false;
        }
        
        return true;
    }
}