using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05107 - .
/// </summary>
public class F05107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CUORMCU.
        /// </summary>
        public const string CUORMCU = "CUORMCU";

        /// <summary>
        /// CUCMPE.
        /// </summary>
        public const string CUCMPE = "CUCMPE";

        /// <summary>
        /// CUCMPC.
        /// </summary>
        public const string CUCMPC = "CUCMPC";

        /// <summary>
        /// CUAN8.
        /// </summary>
        public const string CUAN8 = "CUAN8";

        /// <summary>
        /// CUUSER.
        /// </summary>
        public const string CUUSER = "CUUSER";

        /// <summary>
        /// CUPID.
        /// </summary>
        public const string CUPID = "CUPID";

        /// <summary>
        /// CUJOBN.
        /// </summary>
        public const string CUJOBN = "CUJOBN";

        /// <summary>
        /// CUUPMJ.
        /// </summary>
        public const string CUUPMJ = "CUUPMJ";

        /// <summary>
        /// CUUPMT.
        /// </summary>
        public const string CUUPMT = "CUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CUORMCU", "CUORMCU", JdeDataType.String, 24, true, true),
        new JdeField("CUCMPE", "CUCMPE", JdeDataType.String, 6, true, true),
        new JdeField("CUCMPC", "CUCMPC", JdeDataType.String, 20, true, true),
        new JdeField("CUAN8", "CUAN8", JdeDataType.Numeric),
        new JdeField("CUUSER", "CUUSER", JdeDataType.String, 20),
        new JdeField("CUPID", "CUPID", JdeDataType.String, 20),
        new JdeField("CUJOBN", "CUJOBN", JdeDataType.String, 20),
        new JdeField("CUUPMJ", "CUUPMJ", JdeDataType.Numeric),
        new JdeField("CUUPMT", "CUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05107_0", "Primary Key on CUORMCU, CUCMPE, CUCMPC", new[] { "CUORMCU", "CUCMPE", "CUCMPC" }, isUnique: true, isPrimaryKey: true)
    };
}
