using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B407 - .
/// </summary>
public class F76B407 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCB76SENC.
        /// </summary>
        public const string NCB76SENC = "NCB76SENC";

        /// <summary>
        /// NCB76NCDC.
        /// </summary>
        public const string NCB76NCDC = "NCB76NCDC";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B407";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCB76SENC", "NCB76SENC", JdeDataType.String, 20, true, true),
        new JdeField("NCB76NCDC", "NCB76NCDC", JdeDataType.String, 400),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B407_0", "Primary Key on NCB76SENC", new[] { "NCB76SENC" }, isUnique: true, isPrimaryKey: true)
    };
}
