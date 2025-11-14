using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0935 - .
/// </summary>
public class F76B0935 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPB76SBON.
        /// </summary>
        public const string SPB76SBON = "SPB76SBON";

        /// <summary>
        /// SPB76BCSI.
        /// </summary>
        public const string SPB76BCSI = "SPB76BCSI";

        /// <summary>
        /// SPB76BP.
        /// </summary>
        public const string SPB76BP = "SPB76BP";

        /// <summary>
        /// SPB76SH.
        /// </summary>
        public const string SPB76SH = "SPB76SH";

        /// <summary>
        /// SPB76INS.
        /// </summary>
        public const string SPB76INS = "SPB76INS";

        /// <summary>
        /// SPB76URAT.
        /// </summary>
        public const string SPB76URAT = "SPB76URAT";

        /// <summary>
        /// SPB76URCD.
        /// </summary>
        public const string SPB76URCD = "SPB76URCD";

        /// <summary>
        /// SPB76URDT.
        /// </summary>
        public const string SPB76URDT = "SPB76URDT";

        /// <summary>
        /// SPB76URAB.
        /// </summary>
        public const string SPB76URAB = "SPB76URAB";

        /// <summary>
        /// SPB76URRF.
        /// </summary>
        public const string SPB76URRF = "SPB76URRF";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";

        /// <summary>
        /// SPUPMT.
        /// </summary>
        public const string SPUPMT = "SPUPMT";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0935";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPB76SBON", "SPB76SBON", JdeDataType.Numeric, null, true, true),
        new JdeField("SPB76BCSI", "SPB76BCSI", JdeDataType.String, 2),
        new JdeField("SPB76BP", "SPB76BP", JdeDataType.Numeric),
        new JdeField("SPB76SH", "SPB76SH", JdeDataType.String, 80),
        new JdeField("SPB76INS", "SPB76INS", JdeDataType.Numeric),
        new JdeField("SPB76URAT", "SPB76URAT", JdeDataType.Numeric),
        new JdeField("SPB76URCD", "SPB76URCD", JdeDataType.String, 4),
        new JdeField("SPB76URDT", "SPB76URDT", JdeDataType.Numeric),
        new JdeField("SPB76URAB", "SPB76URAB", JdeDataType.Numeric),
        new JdeField("SPB76URRF", "SPB76URRF", JdeDataType.String, 30),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric),
        new JdeField("SPUPMT", "SPUPMT", JdeDataType.Numeric),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0935_0", "Primary Key on SPB76SBON", new[] { "SPB76SBON" }, isUnique: true, isPrimaryKey: true)
    };
}
