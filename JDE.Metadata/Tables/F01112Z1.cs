using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01112Z1 - .
/// </summary>
public class F01112Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBEDUS.
        /// </summary>
        public const string PBEDUS = "PBEDUS";

        /// <summary>
        /// PBEDBT.
        /// </summary>
        public const string PBEDBT = "PBEDBT";

        /// <summary>
        /// PBEDTN.
        /// </summary>
        public const string PBEDTN = "PBEDTN";

        /// <summary>
        /// PBEDLN.
        /// </summary>
        public const string PBEDLN = "PBEDLN";

        /// <summary>
        /// PBEDCT.
        /// </summary>
        public const string PBEDCT = "PBEDCT";

        /// <summary>
        /// PBTYTN.
        /// </summary>
        public const string PBTYTN = "PBTYTN";

        /// <summary>
        /// PBEDFT.
        /// </summary>
        public const string PBEDFT = "PBEDFT";

        /// <summary>
        /// PBEDDT.
        /// </summary>
        public const string PBEDDT = "PBEDDT";

        /// <summary>
        /// PBDRIN.
        /// </summary>
        public const string PBDRIN = "PBDRIN";

        /// <summary>
        /// PBEDDL.
        /// </summary>
        public const string PBEDDL = "PBEDDL";

        /// <summary>
        /// PBEDSP.
        /// </summary>
        public const string PBEDSP = "PBEDSP";

        /// <summary>
        /// PBPNID.
        /// </summary>
        public const string PBPNID = "PBPNID";

        /// <summary>
        /// PBTNAC.
        /// </summary>
        public const string PBTNAC = "PBTNAC";

        /// <summary>
        /// PBAN8.
        /// </summary>
        public const string PBAN8 = "PBAN8";

        /// <summary>
        /// PBIDLN.
        /// </summary>
        public const string PBIDLN = "PBIDLN";

        /// <summary>
        /// PBCNLN.
        /// </summary>
        public const string PBCNLN = "PBCNLN";

        /// <summary>
        /// PBRELY.
        /// </summary>
        public const string PBRELY = "PBRELY";

        /// <summary>
        /// PBRALP.
        /// </summary>
        public const string PBRALP = "PBRALP";

        /// <summary>
        /// PBDDATE.
        /// </summary>
        public const string PBDDATE = "PBDDATE";

        /// <summary>
        /// PBDMON.
        /// </summary>
        public const string PBDMON = "PBDMON";

        /// <summary>
        /// PBDYR.
        /// </summary>
        public const string PBDYR = "PBDYR";

        /// <summary>
        /// PBCP001.
        /// </summary>
        public const string PBCP001 = "PBCP001";

        /// <summary>
        /// PBCP002.
        /// </summary>
        public const string PBCP002 = "PBCP002";

        /// <summary>
        /// PBCP003.
        /// </summary>
        public const string PBCP003 = "PBCP003";

        /// <summary>
        /// PBCP004.
        /// </summary>
        public const string PBCP004 = "PBCP004";

        /// <summary>
        /// PBCP005.
        /// </summary>
        public const string PBCP005 = "PBCP005";

        /// <summary>
        /// PBTORG.
        /// </summary>
        public const string PBTORG = "PBTORG";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";

        /// <summary>
        /// PBTDAY.
        /// </summary>
        public const string PBTDAY = "PBTDAY";

        /// <summary>
        /// PBUPMT.
        /// </summary>
        public const string PBUPMT = "PBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F01112Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBEDUS", "PBEDUS", JdeDataType.String, 20, true, true),
        new JdeField("PBEDBT", "PBEDBT", JdeDataType.String, 30, true, true),
        new JdeField("PBEDTN", "PBEDTN", JdeDataType.String, 44, true, true),
        new JdeField("PBEDLN", "PBEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PBEDCT", "PBEDCT", JdeDataType.String, 4),
        new JdeField("PBTYTN", "PBTYTN", JdeDataType.String, 16),
        new JdeField("PBEDFT", "PBEDFT", JdeDataType.String, 20),
        new JdeField("PBEDDT", "PBEDDT", JdeDataType.Numeric),
        new JdeField("PBDRIN", "PBDRIN", JdeDataType.String, 2),
        new JdeField("PBEDDL", "PBEDDL", JdeDataType.Numeric),
        new JdeField("PBEDSP", "PBEDSP", JdeDataType.String, 2),
        new JdeField("PBPNID", "PBPNID", JdeDataType.String, 30),
        new JdeField("PBTNAC", "PBTNAC", JdeDataType.String, 4),
        new JdeField("PBAN8", "PBAN8", JdeDataType.Numeric),
        new JdeField("PBIDLN", "PBIDLN", JdeDataType.Numeric),
        new JdeField("PBCNLN", "PBCNLN", JdeDataType.Numeric),
        new JdeField("PBRELY", "PBRELY", JdeDataType.String, 10),
        new JdeField("PBRALP", "PBRALP", JdeDataType.String, 80),
        new JdeField("PBDDATE", "PBDDATE", JdeDataType.Numeric),
        new JdeField("PBDMON", "PBDMON", JdeDataType.Numeric),
        new JdeField("PBDYR", "PBDYR", JdeDataType.Numeric),
        new JdeField("PBCP001", "PBCP001", JdeDataType.String, 6),
        new JdeField("PBCP002", "PBCP002", JdeDataType.String, 6),
        new JdeField("PBCP003", "PBCP003", JdeDataType.String, 6),
        new JdeField("PBCP004", "PBCP004", JdeDataType.String, 6),
        new JdeField("PBCP005", "PBCP005", JdeDataType.String, 6),
        new JdeField("PBTORG", "PBTORG", JdeDataType.String, 20),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20),
        new JdeField("PBTDAY", "PBTDAY", JdeDataType.Numeric),
        new JdeField("PBUPMT", "PBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01112Z1_0", "Primary Key on PBEDUS, PBEDBT, PBEDTN, PBEDLN", new[] { "PBEDUS", "PBEDBT", "PBEDTN", "PBEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
