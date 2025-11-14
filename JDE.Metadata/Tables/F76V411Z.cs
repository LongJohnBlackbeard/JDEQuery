using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V411Z - .
/// </summary>
public class F76V411Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BIEDUS.
        /// </summary>
        public const string BIEDUS = "BIEDUS";

        /// <summary>
        /// BIEDBT.
        /// </summary>
        public const string BIEDBT = "BIEDBT";

        /// <summary>
        /// BIEDTN.
        /// </summary>
        public const string BIEDTN = "BIEDTN";

        /// <summary>
        /// BIEDLN.
        /// </summary>
        public const string BIEDLN = "BIEDLN";

        /// <summary>
        /// BIAN8.
        /// </summary>
        public const string BIAN8 = "BIAN8";

        /// <summary>
        /// BIV76ISLR.
        /// </summary>
        public const string BIV76ISLR = "BIV76ISLR";

        /// <summary>
        /// BIV76MUNW.
        /// </summary>
        public const string BIV76MUNW = "BIV76MUNW";

        /// <summary>
        /// BIV76VATW.
        /// </summary>
        public const string BIV76VATW = "BIV76VATW";

        /// <summary>
        /// BIV76ICNV.
        /// </summary>
        public const string BIV76ICNV = "BIV76ICNV";

        /// <summary>
        /// BIV76ISFC.
        /// </summary>
        public const string BIV76ISFC = "BIV76ISFC";

        /// <summary>
        /// BITORG.
        /// </summary>
        public const string BITORG = "BITORG";

        /// <summary>
        /// BIUSER.
        /// </summary>
        public const string BIUSER = "BIUSER";

        /// <summary>
        /// BIPID.
        /// </summary>
        public const string BIPID = "BIPID";

        /// <summary>
        /// BIUPMJ.
        /// </summary>
        public const string BIUPMJ = "BIUPMJ";

        /// <summary>
        /// BIUPMT.
        /// </summary>
        public const string BIUPMT = "BIUPMT";

        /// <summary>
        /// BIJOBN.
        /// </summary>
        public const string BIJOBN = "BIJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76V411Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BIEDUS", "BIEDUS", JdeDataType.String, 20, true, true),
        new JdeField("BIEDBT", "BIEDBT", JdeDataType.String, 30, true, true),
        new JdeField("BIEDTN", "BIEDTN", JdeDataType.String, 44, true, true),
        new JdeField("BIEDLN", "BIEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("BIAN8", "BIAN8", JdeDataType.Numeric),
        new JdeField("BIV76ISLR", "BIV76ISLR", JdeDataType.String, 6),
        new JdeField("BIV76MUNW", "BIV76MUNW", JdeDataType.String, 2),
        new JdeField("BIV76VATW", "BIV76VATW", JdeDataType.String, 6),
        new JdeField("BIV76ICNV", "BIV76ICNV", JdeDataType.String, 20),
        new JdeField("BIV76ISFC", "BIV76ISFC", JdeDataType.String, 2),
        new JdeField("BITORG", "BITORG", JdeDataType.String, 20),
        new JdeField("BIUSER", "BIUSER", JdeDataType.String, 20),
        new JdeField("BIPID", "BIPID", JdeDataType.String, 20),
        new JdeField("BIUPMJ", "BIUPMJ", JdeDataType.Numeric),
        new JdeField("BIUPMT", "BIUPMT", JdeDataType.Numeric),
        new JdeField("BIJOBN", "BIJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V411Z_0", "Primary Key on BIEDUS, BIEDBT, BIEDTN, BIEDLN", new[] { "BIEDUS", "BIEDBT", "BIEDTN", "BIEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
