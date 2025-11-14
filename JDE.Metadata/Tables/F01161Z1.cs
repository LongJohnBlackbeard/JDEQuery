using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01161Z1 - .
/// </summary>
public class F01161Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LBEDUS.
        /// </summary>
        public const string LBEDUS = "LBEDUS";

        /// <summary>
        /// LBEDBT.
        /// </summary>
        public const string LBEDBT = "LBEDBT";

        /// <summary>
        /// LBEDTN.
        /// </summary>
        public const string LBEDTN = "LBEDTN";

        /// <summary>
        /// LBEDLN.
        /// </summary>
        public const string LBEDLN = "LBEDLN";

        /// <summary>
        /// LBEDCT.
        /// </summary>
        public const string LBEDCT = "LBEDCT";

        /// <summary>
        /// LBTYTN.
        /// </summary>
        public const string LBTYTN = "LBTYTN";

        /// <summary>
        /// LBEDFT.
        /// </summary>
        public const string LBEDFT = "LBEDFT";

        /// <summary>
        /// LBEDDT.
        /// </summary>
        public const string LBEDDT = "LBEDDT";

        /// <summary>
        /// LBDRIN.
        /// </summary>
        public const string LBDRIN = "LBDRIN";

        /// <summary>
        /// LBEDDL.
        /// </summary>
        public const string LBEDDL = "LBEDDL";

        /// <summary>
        /// LBEDSP.
        /// </summary>
        public const string LBEDSP = "LBEDSP";

        /// <summary>
        /// LBPNID.
        /// </summary>
        public const string LBPNID = "LBPNID";

        /// <summary>
        /// LBTNAC.
        /// </summary>
        public const string LBTNAC = "LBTNAC";

        /// <summary>
        /// LBAN8.
        /// </summary>
        public const string LBAN8 = "LBAN8";

        /// <summary>
        /// LBIDLN.
        /// </summary>
        public const string LBIDLN = "LBIDLN";

        /// <summary>
        /// LBEFTB.
        /// </summary>
        public const string LBEFTB = "LBEFTB";

        /// <summary>
        /// LBATYPE.
        /// </summary>
        public const string LBATYPE = "LBATYPE";

        /// <summary>
        /// LBADD1.
        /// </summary>
        public const string LBADD1 = "LBADD1";

        /// <summary>
        /// LBADD2.
        /// </summary>
        public const string LBADD2 = "LBADD2";

        /// <summary>
        /// LBADD3.
        /// </summary>
        public const string LBADD3 = "LBADD3";

        /// <summary>
        /// LBADD4.
        /// </summary>
        public const string LBADD4 = "LBADD4";

        /// <summary>
        /// LBADDZ.
        /// </summary>
        public const string LBADDZ = "LBADDZ";

        /// <summary>
        /// LBCTY1.
        /// </summary>
        public const string LBCTY1 = "LBCTY1";

        /// <summary>
        /// LBCOUN.
        /// </summary>
        public const string LBCOUN = "LBCOUN";

        /// <summary>
        /// LBADDS.
        /// </summary>
        public const string LBADDS = "LBADDS";

        /// <summary>
        /// LBCTR.
        /// </summary>
        public const string LBCTR = "LBCTR";

        /// <summary>
        /// LBEFTF.
        /// </summary>
        public const string LBEFTF = "LBEFTF";

        /// <summary>
        /// LBTORG.
        /// </summary>
        public const string LBTORG = "LBTORG";

        /// <summary>
        /// LBUSER.
        /// </summary>
        public const string LBUSER = "LBUSER";

        /// <summary>
        /// LBPID.
        /// </summary>
        public const string LBPID = "LBPID";

        /// <summary>
        /// LBUPMJ.
        /// </summary>
        public const string LBUPMJ = "LBUPMJ";

        /// <summary>
        /// LBJOBN.
        /// </summary>
        public const string LBJOBN = "LBJOBN";

        /// <summary>
        /// LBTDAY.
        /// </summary>
        public const string LBTDAY = "LBTDAY";

        /// <summary>
        /// LBUPMT.
        /// </summary>
        public const string LBUPMT = "LBUPMT";

        /// <summary>
        /// LBMAINA.
        /// </summary>
        public const string LBMAINA = "LBMAINA";
    }

    /// <inheritdoc />
    public override string TableName => "F01161Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LBEDUS", "LBEDUS", JdeDataType.String, 20, true, true),
        new JdeField("LBEDBT", "LBEDBT", JdeDataType.String, 30, true, true),
        new JdeField("LBEDTN", "LBEDTN", JdeDataType.String, 44, true, true),
        new JdeField("LBEDLN", "LBEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("LBEDCT", "LBEDCT", JdeDataType.String, 4),
        new JdeField("LBTYTN", "LBTYTN", JdeDataType.String, 16),
        new JdeField("LBEDFT", "LBEDFT", JdeDataType.String, 20),
        new JdeField("LBEDDT", "LBEDDT", JdeDataType.Numeric),
        new JdeField("LBDRIN", "LBDRIN", JdeDataType.String, 2),
        new JdeField("LBEDDL", "LBEDDL", JdeDataType.Numeric),
        new JdeField("LBEDSP", "LBEDSP", JdeDataType.String, 2),
        new JdeField("LBPNID", "LBPNID", JdeDataType.String, 30),
        new JdeField("LBTNAC", "LBTNAC", JdeDataType.String, 4),
        new JdeField("LBAN8", "LBAN8", JdeDataType.Numeric),
        new JdeField("LBIDLN", "LBIDLN", JdeDataType.Numeric),
        new JdeField("LBEFTB", "LBEFTB", JdeDataType.Numeric),
        new JdeField("LBATYPE", "LBATYPE", JdeDataType.String, 10),
        new JdeField("LBADD1", "LBADD1", JdeDataType.String, 80),
        new JdeField("LBADD2", "LBADD2", JdeDataType.String, 80),
        new JdeField("LBADD3", "LBADD3", JdeDataType.String, 80),
        new JdeField("LBADD4", "LBADD4", JdeDataType.String, 80),
        new JdeField("LBADDZ", "LBADDZ", JdeDataType.String, 24),
        new JdeField("LBCTY1", "LBCTY1", JdeDataType.String, 50),
        new JdeField("LBCOUN", "LBCOUN", JdeDataType.String, 50),
        new JdeField("LBADDS", "LBADDS", JdeDataType.String, 6),
        new JdeField("LBCTR", "LBCTR", JdeDataType.String, 6),
        new JdeField("LBEFTF", "LBEFTF", JdeDataType.String, 2),
        new JdeField("LBTORG", "LBTORG", JdeDataType.String, 20),
        new JdeField("LBUSER", "LBUSER", JdeDataType.String, 20),
        new JdeField("LBPID", "LBPID", JdeDataType.String, 20),
        new JdeField("LBUPMJ", "LBUPMJ", JdeDataType.Numeric),
        new JdeField("LBJOBN", "LBJOBN", JdeDataType.String, 20),
        new JdeField("LBTDAY", "LBTDAY", JdeDataType.Numeric),
        new JdeField("LBUPMT", "LBUPMT", JdeDataType.Numeric),
        new JdeField("LBMAINA", "LBMAINA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01161Z1_0", "Primary Key on LBEDUS, LBEDBT, LBEDTN, LBEDLN", new[] { "LBEDUS", "LBEDBT", "LBEDTN", "LBEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
