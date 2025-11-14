using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B010 - .
/// </summary>
public class F76B010 : JdeTable
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
        /// LCB76CSPI.
        /// </summary>
        public const string LCB76CSPI = "LCB76CSPI";

        /// <summary>
        /// LCB76DEBO.
        /// </summary>
        public const string LCB76DEBO = "LCB76DEBO";

        /// <summary>
        /// LCB76CRCO.
        /// </summary>
        public const string LCB76CRCO = "LCB76CRCO";

        /// <summary>
        /// LCB76COCO.
        /// </summary>
        public const string LCB76COCO = "LCB76COCO";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCB76LECO", "LCB76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LCB76CSPI", "LCB76CSPI", JdeDataType.String, 2),
        new JdeField("LCB76DEBO", "LCB76DEBO", JdeDataType.String, 2),
        new JdeField("LCB76CRCO", "LCB76CRCO", JdeDataType.Numeric),
        new JdeField("LCB76COCO", "LCB76COCO", JdeDataType.Numeric),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B010_0", "Primary Key on LCB76LECO", new[] { "LCB76LECO" }, isUnique: true, isPrimaryKey: true)
    };
}
