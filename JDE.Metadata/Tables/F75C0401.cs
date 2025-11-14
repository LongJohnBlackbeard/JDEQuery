using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C0401 - .
/// </summary>
public class F75C0401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSCNSIC.
        /// </summary>
        public const string CSCNSIC = "CSCNSIC";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C0401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSCNSIC", "CSCNSIC", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C0401_0", "Primary Key on CSAN8", new[] { "CSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
