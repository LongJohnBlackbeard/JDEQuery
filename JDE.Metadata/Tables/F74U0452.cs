using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0452 - .
/// </summary>
public class F74U0452 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPUKSPT.
        /// </summary>
        public const string SPUKSPT = "SPUKSPT";

        /// <summary>
        /// SPDL01.
        /// </summary>
        public const string SPDL01 = "SPDL01";

        /// <summary>
        /// SPUKCCF.
        /// </summary>
        public const string SPUKCCF = "SPUKCCF";

        /// <summary>
        /// SPUKSPCAT1.
        /// </summary>
        public const string SPUKSPCAT1 = "SPUKSPCAT1";

        /// <summary>
        /// SPUKSPCAT2.
        /// </summary>
        public const string SPUKSPCAT2 = "SPUKSPCAT2";

        /// <summary>
        /// SPURCD.
        /// </summary>
        public const string SPURCD = "SPURCD";

        /// <summary>
        /// SPURAT.
        /// </summary>
        public const string SPURAT = "SPURAT";

        /// <summary>
        /// SPURAB.
        /// </summary>
        public const string SPURAB = "SPURAB";

        /// <summary>
        /// SPURRF.
        /// </summary>
        public const string SPURRF = "SPURRF";

        /// <summary>
        /// SPURDT.
        /// </summary>
        public const string SPURDT = "SPURDT";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";

        /// <summary>
        /// SPUPMT.
        /// </summary>
        public const string SPUPMT = "SPUPMT";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0452";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPUKSPT", "SPUKSPT", JdeDataType.String, 2, true, true),
        new JdeField("SPDL01", "SPDL01", JdeDataType.String, 60),
        new JdeField("SPUKCCF", "SPUKCCF", JdeDataType.String, 2),
        new JdeField("SPUKSPCAT1", "SPUKSPCAT1", JdeDataType.String, 6),
        new JdeField("SPUKSPCAT2", "SPUKSPCAT2", JdeDataType.String, 6),
        new JdeField("SPURCD", "SPURCD", JdeDataType.String, 4),
        new JdeField("SPURAT", "SPURAT", JdeDataType.Numeric),
        new JdeField("SPURAB", "SPURAB", JdeDataType.Numeric),
        new JdeField("SPURRF", "SPURRF", JdeDataType.String, 30),
        new JdeField("SPURDT", "SPURDT", JdeDataType.Numeric),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUPMT", "SPUPMT", JdeDataType.Numeric),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0452_0", "Primary Key on SPUKSPT", new[] { "SPUKSPT" }, isUnique: true, isPrimaryKey: true)
    };
}
