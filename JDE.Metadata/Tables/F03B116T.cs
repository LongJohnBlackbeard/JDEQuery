using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B116T - .
/// </summary>
public class F03B116T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTAN8.
        /// </summary>
        public const string RTAN8 = "RTAN8";

        /// <summary>
        /// RTKCO.
        /// </summary>
        public const string RTKCO = "RTKCO";

        /// <summary>
        /// RTDOC.
        /// </summary>
        public const string RTDOC = "RTDOC";

        /// <summary>
        /// RTDCT.
        /// </summary>
        public const string RTDCT = "RTDCT";

        /// <summary>
        /// RTIVD.
        /// </summary>
        public const string RTIVD = "RTIVD";

        /// <summary>
        /// RTDIGJ.
        /// </summary>
        public const string RTDIGJ = "RTDIGJ";

        /// <summary>
        /// RTCH6.
        /// </summary>
        public const string RTCH6 = "RTCH6";

        /// <summary>
        /// RTAAR.
        /// </summary>
        public const string RTAAR = "RTAAR";

        /// <summary>
        /// RTAARE.
        /// </summary>
        public const string RTAARE = "RTAARE";

        /// <summary>
        /// RTAARN.
        /// </summary>
        public const string RTAARN = "RTAARN";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTUKID.
        /// </summary>
        public const string RTUKID = "RTUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B116T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTAN8", "RTAN8", JdeDataType.Numeric),
        new JdeField("RTKCO", "RTKCO", JdeDataType.String, 10, true, true),
        new JdeField("RTDOC", "RTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RTDCT", "RTDCT", JdeDataType.String, 4, true, true),
        new JdeField("RTIVD", "RTIVD", JdeDataType.Numeric),
        new JdeField("RTDIGJ", "RTDIGJ", JdeDataType.Numeric),
        new JdeField("RTCH6", "RTCH6", JdeDataType.String, 2),
        new JdeField("RTAAR", "RTAAR", JdeDataType.Numeric),
        new JdeField("RTAARE", "RTAARE", JdeDataType.Numeric),
        new JdeField("RTAARN", "RTAARN", JdeDataType.Numeric),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20, true, true),
        new JdeField("RTUKID", "RTUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B116T_0", "Primary Key on RTUSER, RTUKID, RTKCO, RTDOC, RTDCT", new[] { "RTUSER", "RTUKID", "RTKCO", "RTDOC", "RTDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
