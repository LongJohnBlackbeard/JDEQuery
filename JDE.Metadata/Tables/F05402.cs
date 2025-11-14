using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05402 - .
/// </summary>
public class F05402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SASSACTS.
        /// </summary>
        public const string SASSACTS = "SASSACTS";

        /// <summary>
        /// SAOBNM.
        /// </summary>
        public const string SAOBNM = "SAOBNM";

        /// <summary>
        /// SAFMNM.
        /// </summary>
        public const string SAFMNM = "SAFMNM";

        /// <summary>
        /// SAVERS.
        /// </summary>
        public const string SAVERS = "SAVERS";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAUPMT.
        /// </summary>
        public const string SAUPMT = "SAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SASSACTS", "SASSACTS", JdeDataType.String, 20, true, true),
        new JdeField("SAOBNM", "SAOBNM", JdeDataType.String, 20),
        new JdeField("SAFMNM", "SAFMNM", JdeDataType.String, 20),
        new JdeField("SAVERS", "SAVERS", JdeDataType.String, 20),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAUPMT", "SAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05402_0", "Primary Key on SASSACTS", new[] { "SASSACTS" }, isUnique: true, isPrimaryKey: true)
    };
}
