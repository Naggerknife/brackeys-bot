﻿using System.IO;
using System.Collections.Generic;

namespace BrackeysBot
{
    /// <summary>
    /// Provides a table to store the rules for a server.
    /// </summary>
    public class RuleTable : LookupTable<int, string>
    {
        /// <summary>
        /// Returns the rules from the table.
        /// </summary>
        public Dictionary<int, string> Rules => _lookup;

        public RuleTable(string path) : base(path)
        {
        }
    }
}
