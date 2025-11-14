using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B408 - .
/// </summary>
public class F76B408 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STB76SVTC.
        /// </summary>
        public const string STB76SVTC = "STB76SVTC";

        /// <summary>
        /// STB76SENC.
        /// </summary>
        public const string STB76SENC = "STB76SENC";

        /// <summary>
        /// STB76STCD.
        /// </summary>
        public const string STB76STCD = "STB76STCD";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B408";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STB76SVTC", "STB76SVTC", JdeDataType.String, 20, true, true),
        new JdeField("STB76SENC", "STB76SENC", JdeDataType.String, 20),
        new JdeField("STB76STCD", "STB76STCD", JdeDataType.String, 400),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B408_0", "Primary Key on STB76SVTC", new[] { "STB76SVTC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B408_2", "Index on STB76SENC", new[] { "STB76SENC" })
    };
}
