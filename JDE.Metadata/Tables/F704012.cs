using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704012 - .
/// </summary>
public class F704012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPAN8.
        /// </summary>
        public const string SPAN8 = "SPAN8";

        /// <summary>
        /// SPPE01.
        /// </summary>
        public const string SPPE01 = "SPPE01";

        /// <summary>
        /// SPGLC.
        /// </summary>
        public const string SPGLC = "SPGLC";

        /// <summary>
        /// SPPYE.
        /// </summary>
        public const string SPPYE = "SPPYE";

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
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";

        /// <summary>
        /// SPUPMT.
        /// </summary>
        public const string SPUPMT = "SPUPMT";

        /// <summary>
        /// SPYFUTDT.
        /// </summary>
        public const string SPYFUTDT = "SPYFUTDT";

        /// <summary>
        /// SPFUT6.
        /// </summary>
        public const string SPFUT6 = "SPFUT6";

        /// <summary>
        /// SPFUTCH1.
        /// </summary>
        public const string SPFUTCH1 = "SPFUTCH1";

        /// <summary>
        /// SPFFG1.
        /// </summary>
        public const string SPFFG1 = "SPFFG1";

        /// <summary>
        /// SPFFU4.
        /// </summary>
        public const string SPFFU4 = "SPFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F704012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPAN8", "SPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SPPE01", "SPPE01", JdeDataType.Numeric),
        new JdeField("SPGLC", "SPGLC", JdeDataType.String, 8),
        new JdeField("SPPYE", "SPPYE", JdeDataType.Numeric),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric),
        new JdeField("SPUPMT", "SPUPMT", JdeDataType.Numeric),
        new JdeField("SPYFUTDT", "SPYFUTDT", JdeDataType.Numeric),
        new JdeField("SPFUT6", "SPFUT6", JdeDataType.String, 60),
        new JdeField("SPFUTCH1", "SPFUTCH1", JdeDataType.String, 2),
        new JdeField("SPFFG1", "SPFFG1", JdeDataType.String, 2),
        new JdeField("SPFFU4", "SPFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704012_0", "Primary Key on SPAN8", new[] { "SPAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
