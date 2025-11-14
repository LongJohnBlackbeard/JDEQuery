using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08116 - .
/// </summary>
public class F08116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACALE.
        /// </summary>
        public const string ACALE = "ACALE";

        /// <summary>
        /// ACHMCO.
        /// </summary>
        public const string ACHMCO = "ACHMCO";

        /// <summary>
        /// ACEFT.
        /// </summary>
        public const string ACEFT = "ACEFT";

        /// <summary>
        /// ACEFTE.
        /// </summary>
        public const string ACEFTE = "ACEFTE";

        /// <summary>
        /// ACALEM.
        /// </summary>
        public const string ACALEM = "ACALEM";

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
    public override string TableName => "F08116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACALE", "ACALE", JdeDataType.String, 20, true, true),
        new JdeField("ACHMCO", "ACHMCO", JdeDataType.String, 10, true, true),
        new JdeField("ACEFT", "ACEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("ACEFTE", "ACEFTE", JdeDataType.Numeric),
        new JdeField("ACALEM", "ACALEM", JdeDataType.String, 20),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08116_0", "Primary Key on ACALE, ACHMCO, ACEFT", new[] { "ACALE", "ACHMCO", "ACEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08116_2", "Index on ACHMCO, SYS_NC00011$", new[] { "ACHMCO", "SYS_NC00011$" })
    };
}
