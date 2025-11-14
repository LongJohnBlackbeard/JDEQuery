using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B945 - .
/// </summary>
public class F76B945 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGJOBS.
        /// </summary>
        public const string SGJOBS = "SGJOBS";

        /// <summary>
        /// SGAN8.
        /// </summary>
        public const string SGAN8 = "SGAN8";

        /// <summary>
        /// SGB76SICO.
        /// </summary>
        public const string SGB76SICO = "SGB76SICO";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGPID.
        /// </summary>
        public const string SGPID = "SGPID";

        /// <summary>
        /// SGJOBN.
        /// </summary>
        public const string SGJOBN = "SGJOBN";

        /// <summary>
        /// SGUPMJ.
        /// </summary>
        public const string SGUPMJ = "SGUPMJ";

        /// <summary>
        /// SGUPMT.
        /// </summary>
        public const string SGUPMT = "SGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B945";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGJOBS", "SGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SGAN8", "SGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SGB76SICO", "SGB76SICO", JdeDataType.String, 6),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20),
        new JdeField("SGPID", "SGPID", JdeDataType.String, 20),
        new JdeField("SGJOBN", "SGJOBN", JdeDataType.String, 20),
        new JdeField("SGUPMJ", "SGUPMJ", JdeDataType.Numeric),
        new JdeField("SGUPMT", "SGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B945_0", "Primary Key on SGJOBS, SGAN8", new[] { "SGJOBS", "SGAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
