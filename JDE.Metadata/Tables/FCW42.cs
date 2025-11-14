using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW42 - .
/// </summary>
public class FCW42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDC9PLNB.
        /// </summary>
        public const string TDC9PLNB = "TDC9PLNB";

        /// <summary>
        /// TDC9PLNT.
        /// </summary>
        public const string TDC9PLNT = "TDC9PLNT";

        /// <summary>
        /// TDPRGR.
        /// </summary>
        public const string TDPRGR = "TDPRGR";

        /// <summary>
        /// TDIGP1.
        /// </summary>
        public const string TDIGP1 = "TDIGP1";

        /// <summary>
        /// TDIGP2.
        /// </summary>
        public const string TDIGP2 = "TDIGP2";

        /// <summary>
        /// TDIGP3.
        /// </summary>
        public const string TDIGP3 = "TDIGP3";

        /// <summary>
        /// TDIGP4.
        /// </summary>
        public const string TDIGP4 = "TDIGP4";

        /// <summary>
        /// TDC9RDRL.
        /// </summary>
        public const string TDC9RDRL = "TDC9RDRL";

        /// <summary>
        /// TDC9COEF.
        /// </summary>
        public const string TDC9COEF = "TDC9COEF";

        /// <summary>
        /// TDC9ICIDB.
        /// </summary>
        public const string TDC9ICIDB = "TDC9ICIDB";

        /// <summary>
        /// TDC9ICIDT.
        /// </summary>
        public const string TDC9ICIDT = "TDC9ICIDT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDC9PLNB", "TDC9PLNB", JdeDataType.Numeric, null, true, true),
        new JdeField("TDC9PLNT", "TDC9PLNT", JdeDataType.Numeric, null, true, true),
        new JdeField("TDPRGR", "TDPRGR", JdeDataType.String, 16, true, true),
        new JdeField("TDIGP1", "TDIGP1", JdeDataType.String, 12, true, true),
        new JdeField("TDIGP2", "TDIGP2", JdeDataType.String, 12, true, true),
        new JdeField("TDIGP3", "TDIGP3", JdeDataType.String, 12, true, true),
        new JdeField("TDIGP4", "TDIGP4", JdeDataType.String, 12, true, true),
        new JdeField("TDC9RDRL", "TDC9RDRL", JdeDataType.String, 20),
        new JdeField("TDC9COEF", "TDC9COEF", JdeDataType.Numeric),
        new JdeField("TDC9ICIDB", "TDC9ICIDB", JdeDataType.Numeric),
        new JdeField("TDC9ICIDT", "TDC9ICIDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW42_0", "Primary Key on TDC9PLNB, TDC9PLNT, TDPRGR, TDIGP1, TDIGP2, TDIGP3, TDIGP4", new[] { "TDC9PLNB", "TDC9PLNT", "TDPRGR", "TDIGP1", "TDIGP2", "TDIGP3", "TDIGP4" }, isUnique: true, isPrimaryKey: true)
    };
}
