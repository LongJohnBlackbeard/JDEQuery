using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40540 - .
/// </summary>
public class F40540 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICITM.
        /// </summary>
        public const string ICITM = "ICITM";

        /// <summary>
        /// ICCMDCDE.
        /// </summary>
        public const string ICCMDCDE = "ICCMDCDE";

        /// <summary>
        /// ICUNSPSC.
        /// </summary>
        public const string ICUNSPSC = "ICUNSPSC";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICUPMT.
        /// </summary>
        public const string ICUPMT = "ICUPMT";

        /// <summary>
        /// ICUPMJ.
        /// </summary>
        public const string ICUPMJ = "ICUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40540";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICITM", "ICITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ICCMDCDE", "ICCMDCDE", JdeDataType.String, 30),
        new JdeField("ICUNSPSC", "ICUNSPSC", JdeDataType.String, 16),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICUPMT", "ICUPMT", JdeDataType.Numeric),
        new JdeField("ICUPMJ", "ICUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40540_0", "Primary Key on ICITM", new[] { "ICITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40540_2", "Index on ICCMDCDE, ICITM", new[] { "ICCMDCDE", "ICITM" })
    };
}
