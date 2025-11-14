using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75014 - .
/// </summary>
public class F75014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JPWTCJP.
        /// </summary>
        public const string JPWTCJP = "JPWTCJP";

        /// <summary>
        /// JPCRCD.
        /// </summary>
        public const string JPCRCD = "JPCRCD";

        /// <summary>
        /// JPATXA.
        /// </summary>
        public const string JPATXA = "JPATXA";

        /// <summary>
        /// JPPCWH.
        /// </summary>
        public const string JPPCWH = "JPPCWH";

        /// <summary>
        /// JPDEDJP.
        /// </summary>
        public const string JPDEDJP = "JPDEDJP";

        /// <summary>
        /// JPUSER.
        /// </summary>
        public const string JPUSER = "JPUSER";

        /// <summary>
        /// JPPID.
        /// </summary>
        public const string JPPID = "JPPID";

        /// <summary>
        /// JPUPMJ.
        /// </summary>
        public const string JPUPMJ = "JPUPMJ";

        /// <summary>
        /// JPJOBN.
        /// </summary>
        public const string JPJOBN = "JPJOBN";

        /// <summary>
        /// JPUPMT.
        /// </summary>
        public const string JPUPMT = "JPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JPWTCJP", "JPWTCJP", JdeDataType.String, 2, true, true),
        new JdeField("JPCRCD", "JPCRCD", JdeDataType.String, 6, true, true),
        new JdeField("JPATXA", "JPATXA", JdeDataType.Numeric, null, true, true),
        new JdeField("JPPCWH", "JPPCWH", JdeDataType.Numeric),
        new JdeField("JPDEDJP", "JPDEDJP", JdeDataType.Numeric),
        new JdeField("JPUSER", "JPUSER", JdeDataType.String, 20),
        new JdeField("JPPID", "JPPID", JdeDataType.String, 20),
        new JdeField("JPUPMJ", "JPUPMJ", JdeDataType.Numeric),
        new JdeField("JPJOBN", "JPJOBN", JdeDataType.String, 20),
        new JdeField("JPUPMT", "JPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75014_0", "Primary Key on JPWTCJP, JPCRCD, JPATXA", new[] { "JPWTCJP", "JPCRCD", "JPATXA" }, isUnique: true, isPrimaryKey: true)
    };
}
