using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B474I - .
/// </summary>
public class F76B474I : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BIMID.
        /// </summary>
        public const string BIMID = "BIMID";

        /// <summary>
        /// BILNID.
        /// </summary>
        public const string BILNID = "BILNID";

        /// <summary>
        /// BIBKCD.
        /// </summary>
        public const string BIBKCD = "BIBKCD";

        /// <summary>
        /// BITYTN.
        /// </summary>
        public const string BITYTN = "BITYTN";

        /// <summary>
        /// BIEDTY.
        /// </summary>
        public const string BIEDTY = "BIEDTY";

        /// <summary>
        /// BILIID.
        /// </summary>
        public const string BILIID = "BILIID";

        /// <summary>
        /// BIBBFCN.
        /// </summary>
        public const string BIBBFCN = "BIBBFCN";

        /// <summary>
        /// BIGLBA.
        /// </summary>
        public const string BIGLBA = "BIGLBA";

        /// <summary>
        /// BIPYIN.
        /// </summary>
        public const string BIPYIN = "BIPYIN";

        /// <summary>
        /// BIBRCB.
        /// </summary>
        public const string BIBRCB = "BIBRCB";

        /// <summary>
        /// BIBDFBKV.
        /// </summary>
        public const string BIBDFBKV = "BIBDFBKV";

        /// <summary>
        /// BIAPTA.
        /// </summary>
        public const string BIAPTA = "BIAPTA";

        /// <summary>
        /// BIEDSP.
        /// </summary>
        public const string BIEDSP = "BIEDSP";

        /// <summary>
        /// BIPID.
        /// </summary>
        public const string BIPID = "BIPID";

        /// <summary>
        /// BIJOBN.
        /// </summary>
        public const string BIJOBN = "BIJOBN";

        /// <summary>
        /// BIUSER.
        /// </summary>
        public const string BIUSER = "BIUSER";

        /// <summary>
        /// BIUPMJ.
        /// </summary>
        public const string BIUPMJ = "BIUPMJ";

        /// <summary>
        /// BIUPMT.
        /// </summary>
        public const string BIUPMT = "BIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B474I";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BIMID", "BIMID", JdeDataType.String, 20, true, true),
        new JdeField("BILNID", "BILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BIBKCD", "BIBKCD", JdeDataType.String, 6),
        new JdeField("BITYTN", "BITYTN", JdeDataType.String, 16),
        new JdeField("BIEDTY", "BIEDTY", JdeDataType.String, 2),
        new JdeField("BILIID", "BILIID", JdeDataType.Numeric),
        new JdeField("BIBBFCN", "BIBBFCN", JdeDataType.Numeric),
        new JdeField("BIGLBA", "BIGLBA", JdeDataType.String, 16),
        new JdeField("BIPYIN", "BIPYIN", JdeDataType.String, 2),
        new JdeField("BIBRCB", "BIBRCB", JdeDataType.String, 4),
        new JdeField("BIBDFBKV", "BIBDFBKV", JdeDataType.String, 60),
        new JdeField("BIAPTA", "BIAPTA", JdeDataType.String, 3000),
        new JdeField("BIEDSP", "BIEDSP", JdeDataType.String, 2),
        new JdeField("BIPID", "BIPID", JdeDataType.String, 20),
        new JdeField("BIJOBN", "BIJOBN", JdeDataType.String, 20),
        new JdeField("BIUSER", "BIUSER", JdeDataType.String, 20),
        new JdeField("BIUPMJ", "BIUPMJ", JdeDataType.Numeric),
        new JdeField("BIUPMT", "BIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B474I_0", "Primary Key on BIMID, BILNID", new[] { "BIMID", "BILNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B474I_2", "Index on BITYTN, BIBKCD, BIEDTY, BIBRCB, BIBDFBKV", new[] { "BITYTN", "BIBKCD", "BIEDTY", "BIBRCB", "BIBDFBKV" }),
        new JdeIndex("F76B474I_3", "Index on BIMID, BIBKCD, BITYTN", new[] { "BIMID", "BIBKCD", "BITYTN" }),
        new JdeIndex("F76B474I_4", "Index on BIMID, BIBKCD, BIEDTY, BIPYIN", new[] { "BIMID", "BIBKCD", "BIEDTY", "BIPYIN" })
    };
}
