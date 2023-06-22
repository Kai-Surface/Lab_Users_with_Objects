using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Users_with_Objects
{
    internal class JamSession : User
    {
        Guitar _guitarType;
        GuitarPick _pick;
        GuitarStrings _strings;

        public JamSession(Guitar guitarType, GuitarPick pick, GuitarStrings strings, string firstName, string lastName, List<JamSession> jamSession) : base (firstName, lastName, jamSession)
        {
            GuitarType = guitarType;
            Pick = pick;
            Strings = strings;
            List<string> selectedStrings = GetSelectedStrings();
            Strings.SelectedStrings = selectedStrings;
        }

        internal Guitar GuitarType { get => _guitarType; set => _guitarType = value; }
        internal GuitarPick Pick { get => _pick; set => _pick = value; }
        internal GuitarStrings Strings { get => _strings; set => _strings = value; }

        public override string ToString()
        {
            string baseString = base.ToString();
            return $"{baseString} is strumming the {string.Join(",", Strings.Strings)} string(s) on a {GuitarType} with a {Pick.Shape} {Pick.Material} pick.";
        }
    }
}
