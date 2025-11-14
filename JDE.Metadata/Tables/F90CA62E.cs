using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA62E - .
/// </summary>
public class F90CA62E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACCNAN8.
        /// </summary>
        public const string ACCNAN8 = "ACCNAN8";

        /// <summary>
        /// ACCNLNID.
        /// </summary>
        public const string ACCNLNID = "ACCNLNID";

        /// <summary>
        /// ACACTIVID.
        /// </summary>
        public const string ACACTIVID = "ACACTIVID";

        /// <summary>
        /// ACPACTVID.
        /// </summary>
        public const string ACPACTVID = "ACPACTVID";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACEDATE.
        /// </summary>
        public const string ACEDATE = "ACEDATE";

        /// <summary>
        /// ACUDTTM.
        /// </summary>
        public const string ACUDTTM = "ACUDTTM";

        /// <summary>
        /// ACMKEY.
        /// </summary>
        public const string ACMKEY = "ACMKEY";

        /// <summary>
        /// ACENTRD.
        /// </summary>
        public const string ACENTRD = "ACENTRD";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA62E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACCNAN8", "ACCNAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ACCNLNID", "ACCNLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACACTIVID", "ACACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("ACPACTVID", "ACPACTVID", JdeDataType.String, 74),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACEDATE", "ACEDATE", JdeDataType.Date),
        new JdeField("ACUDTTM", "ACUDTTM", JdeDataType.Date),
        new JdeField("ACMKEY", "ACMKEY", JdeDataType.String, 30),
        new JdeField("ACENTRD", "ACENTRD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA62E_0", "Primary Key on ACCNAN8, ACCNLNID, ACACTIVID", new[] { "ACCNAN8", "ACCNLNID", "ACACTIVID" }, isUnique: true, isPrimaryKey: true)
    };
}
