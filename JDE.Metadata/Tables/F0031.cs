using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0031 - .
/// </summary>
public class F0031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AVUKID.
        /// </summary>
        public const string AVUKID = "AVUKID";

        /// <summary>
        /// AVAN8BK.
        /// </summary>
        public const string AVAN8BK = "AVAN8BK";

        /// <summary>
        /// AVUPMJ.
        /// </summary>
        public const string AVUPMJ = "AVUPMJ";

        /// <summary>
        /// AVUPMT.
        /// </summary>
        public const string AVUPMT = "AVUPMT";

        /// <summary>
        /// AVPID.
        /// </summary>
        public const string AVPID = "AVPID";

        /// <summary>
        /// AVUSER.
        /// </summary>
        public const string AVUSER = "AVUSER";

        /// <summary>
        /// AVJOBN.
        /// </summary>
        public const string AVJOBN = "AVJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AVUKID", "AVUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("AVAN8BK", "AVAN8BK", JdeDataType.Numeric),
        new JdeField("AVUPMJ", "AVUPMJ", JdeDataType.Numeric),
        new JdeField("AVUPMT", "AVUPMT", JdeDataType.Numeric),
        new JdeField("AVPID", "AVPID", JdeDataType.String, 20),
        new JdeField("AVUSER", "AVUSER", JdeDataType.String, 20),
        new JdeField("AVJOBN", "AVJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0031_0", "Primary Key on AVUKID", new[] { "AVUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
