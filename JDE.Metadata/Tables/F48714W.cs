using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48714W - .
/// </summary>
public class F48714W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MUUKID.
        /// </summary>
        public const string MUUKID = "MUUKID";

        /// <summary>
        /// MUDOCO.
        /// </summary>
        public const string MUDOCO = "MUDOCO";

        /// <summary>
        /// MUEV01.
        /// </summary>
        public const string MUEV01 = "MUEV01";

        /// <summary>
        /// MUEV02.
        /// </summary>
        public const string MUEV02 = "MUEV02";

        /// <summary>
        /// MUPID.
        /// </summary>
        public const string MUPID = "MUPID";

        /// <summary>
        /// MUJOBN.
        /// </summary>
        public const string MUJOBN = "MUJOBN";

        /// <summary>
        /// MUUSER.
        /// </summary>
        public const string MUUSER = "MUUSER";

        /// <summary>
        /// MUUPMJ.
        /// </summary>
        public const string MUUPMJ = "MUUPMJ";

        /// <summary>
        /// MUUPMT.
        /// </summary>
        public const string MUUPMT = "MUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48714W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MUUKID", "MUUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("MUDOCO", "MUDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("MUEV01", "MUEV01", JdeDataType.String, 2),
        new JdeField("MUEV02", "MUEV02", JdeDataType.String, 2),
        new JdeField("MUPID", "MUPID", JdeDataType.String, 20),
        new JdeField("MUJOBN", "MUJOBN", JdeDataType.String, 20),
        new JdeField("MUUSER", "MUUSER", JdeDataType.String, 20),
        new JdeField("MUUPMJ", "MUUPMJ", JdeDataType.Numeric),
        new JdeField("MUUPMT", "MUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48714W_0", "Primary Key on MUUKID, MUDOCO", new[] { "MUUKID", "MUDOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
