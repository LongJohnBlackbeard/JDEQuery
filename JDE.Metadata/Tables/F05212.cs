using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05212 - .
/// </summary>
public class F05212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AVAWBOI.
        /// </summary>
        public const string AVAWBOI = "AVAWBOI";

        /// <summary>
        /// AVAWBTA.
        /// </summary>
        public const string AVAWBTA = "AVAWBTA";

        /// <summary>
        /// AVAWBAV.
        /// </summary>
        public const string AVAWBAV = "AVAWBAV";

        /// <summary>
        /// AVPID.
        /// </summary>
        public const string AVPID = "AVPID";

        /// <summary>
        /// AVUSER.
        /// </summary>
        public const string AVUSER = "AVUSER";

        /// <summary>
        /// AVUPMJ.
        /// </summary>
        public const string AVUPMJ = "AVUPMJ";

        /// <summary>
        /// AVUPMT.
        /// </summary>
        public const string AVUPMT = "AVUPMT";

        /// <summary>
        /// AVMKEY.
        /// </summary>
        public const string AVMKEY = "AVMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F05212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AVAWBOI", "AVAWBOI", JdeDataType.String, 20, true, true),
        new JdeField("AVAWBTA", "AVAWBTA", JdeDataType.String, 20, true, true),
        new JdeField("AVAWBAV", "AVAWBAV", JdeDataType.String, 20),
        new JdeField("AVPID", "AVPID", JdeDataType.String, 20),
        new JdeField("AVUSER", "AVUSER", JdeDataType.String, 20),
        new JdeField("AVUPMJ", "AVUPMJ", JdeDataType.Numeric),
        new JdeField("AVUPMT", "AVUPMT", JdeDataType.Numeric),
        new JdeField("AVMKEY", "AVMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05212_0", "Primary Key on AVAWBOI, AVAWBTA", new[] { "AVAWBOI", "AVAWBTA" }, isUnique: true, isPrimaryKey: true)
    };
}
