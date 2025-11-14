using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6005 - .
/// </summary>
public class F76H6005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACLT.
        /// </summary>
        public const string ACLT = "ACLT";

        /// <summary>
        /// ACAID.
        /// </summary>
        public const string ACAID = "ACAID";

        /// <summary>
        /// ACSBL.
        /// </summary>
        public const string ACSBL = "ACSBL";

        /// <summary>
        /// ACSBLT.
        /// </summary>
        public const string ACSBLT = "ACSBLT";

        /// <summary>
        /// ACCOST.
        /// </summary>
        public const string ACCOST = "ACCOST";

        /// <summary>
        /// ACTORG.
        /// </summary>
        public const string ACTORG = "ACTORG";

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
    public override string TableName => "F76H6005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACLT", "ACLT", JdeDataType.String, 4, true, true),
        new JdeField("ACAID", "ACAID", JdeDataType.String, 16, true, true),
        new JdeField("ACSBL", "ACSBL", JdeDataType.String, 16, true, true),
        new JdeField("ACSBLT", "ACSBLT", JdeDataType.String, 2, true, true),
        new JdeField("ACCOST", "ACCOST", JdeDataType.String, 6),
        new JdeField("ACTORG", "ACTORG", JdeDataType.String, 20),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6005_0", "Primary Key on ACLT, ACAID, ACSBL, ACSBLT", new[] { "ACLT", "ACAID", "ACSBL", "ACSBLT" }, isUnique: true, isPrimaryKey: true)
    };
}
