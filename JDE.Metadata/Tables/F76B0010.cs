using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0010 - .
/// </summary>
public class F76B0010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCB76LECO.
        /// </summary>
        public const string LCB76LECO = "LCB76LECO";

        /// <summary>
        /// LCB76CSI.
        /// </summary>
        public const string LCB76CSI = "LCB76CSI";

        /// <summary>
        /// LCB76URAT.
        /// </summary>
        public const string LCB76URAT = "LCB76URAT";

        /// <summary>
        /// LCB76URCD.
        /// </summary>
        public const string LCB76URCD = "LCB76URCD";

        /// <summary>
        /// LCB76URDT.
        /// </summary>
        public const string LCB76URDT = "LCB76URDT";

        /// <summary>
        /// LCB76URAB.
        /// </summary>
        public const string LCB76URAB = "LCB76URAB";

        /// <summary>
        /// LCB76URRF.
        /// </summary>
        public const string LCB76URRF = "LCB76URRF";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCB76LECO", "LCB76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LCB76CSI", "LCB76CSI", JdeDataType.String, 2),
        new JdeField("LCB76URAT", "LCB76URAT", JdeDataType.Numeric),
        new JdeField("LCB76URCD", "LCB76URCD", JdeDataType.String, 4),
        new JdeField("LCB76URDT", "LCB76URDT", JdeDataType.Numeric),
        new JdeField("LCB76URAB", "LCB76URAB", JdeDataType.Numeric),
        new JdeField("LCB76URRF", "LCB76URRF", JdeDataType.String, 30),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0010_0", "Primary Key on LCB76LECO", new[] { "LCB76LECO" }, isUnique: true, isPrimaryKey: true)
    };
}
