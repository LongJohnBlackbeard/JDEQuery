using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08043 - .
/// </summary>
public class F08043 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACDTAL.
        /// </summary>
        public const string ACDTAL = "ACDTAL";

        /// <summary>
        /// ACHRSS.
        /// </summary>
        public const string ACHRSS = "ACHRSS";

        /// <summary>
        /// ACIGLE.
        /// </summary>
        public const string ACIGLE = "ACIGLE";

        /// <summary>
        /// ACBDLS.
        /// </summary>
        public const string ACBDLS = "ACBDLS";

        /// <summary>
        /// ACOTPS.
        /// </summary>
        public const string ACOTPS = "ACOTPS";

        /// <summary>
        /// ACMLT.
        /// </summary>
        public const string ACMLT = "ACMLT";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08043";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACDTAL", "ACDTAL", JdeDataType.String, 20, true, true),
        new JdeField("ACHRSS", "ACHRSS", JdeDataType.String, 20, true, true),
        new JdeField("ACIGLE", "ACIGLE", JdeDataType.String, 2),
        new JdeField("ACBDLS", "ACBDLS", JdeDataType.String, 20),
        new JdeField("ACOTPS", "ACOTPS", JdeDataType.String, 6),
        new JdeField("ACMLT", "ACMLT", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08043_0", "Primary Key on ACDTAL, ACHRSS", new[] { "ACDTAL", "ACHRSS" }, isUnique: true, isPrimaryKey: true)
    };
}
