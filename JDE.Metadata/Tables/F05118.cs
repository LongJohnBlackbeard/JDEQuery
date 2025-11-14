using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05118 - .
/// </summary>
public class F05118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACAGGC.
        /// </summary>
        public const string ACAGGC = "ACAGGC";

        /// <summary>
        /// ACCMPE.
        /// </summary>
        public const string ACCMPE = "ACCMPE";

        /// <summary>
        /// ACCMPC.
        /// </summary>
        public const string ACCMPC = "ACCMPC";

        /// <summary>
        /// ACDL01.
        /// </summary>
        public const string ACDL01 = "ACDL01";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACAGGC", "ACAGGC", JdeDataType.String, 20, true, true),
        new JdeField("ACCMPE", "ACCMPE", JdeDataType.String, 6, true, true),
        new JdeField("ACCMPC", "ACCMPC", JdeDataType.String, 20, true, true),
        new JdeField("ACDL01", "ACDL01", JdeDataType.String, 60),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05118_0", "Primary Key on ACAGGC, ACCMPE, ACCMPC", new[] { "ACAGGC", "ACCMPE", "ACCMPC" }, isUnique: true, isPrimaryKey: true)
    };
}
