using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B422 - .
/// </summary>
public class F76B422 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKBRTX.
        /// </summary>
        public const string TKBRTX = "TKBRTX";

        /// <summary>
        /// TKEFTJ.
        /// </summary>
        public const string TKEFTJ = "TKEFTJ";

        /// <summary>
        /// TKB76MIAM.
        /// </summary>
        public const string TKB76MIAM = "TKB76MIAM";

        /// <summary>
        /// TKTORG.
        /// </summary>
        public const string TKTORG = "TKTORG";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B422";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKBRTX", "TKBRTX", JdeDataType.String, 4, true, true),
        new JdeField("TKEFTJ", "TKEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TKB76MIAM", "TKB76MIAM", JdeDataType.Numeric),
        new JdeField("TKTORG", "TKTORG", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B422_0", "Primary Key on TKBRTX, TKEFTJ", new[] { "TKBRTX", "TKEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B422_2", "Index on TKBRTX, SYS_NC00010$", new[] { "TKBRTX", "SYS_NC00010$" })
    };
}
