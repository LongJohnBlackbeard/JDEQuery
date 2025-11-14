using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA63E - .
/// </summary>
public class F90CA63E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACAN8.
        /// </summary>
        public const string ACAN8 = "ACAN8";

        /// <summary>
        /// ACCO.
        /// </summary>
        public const string ACCO = "ACCO";

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
        /// ACDTEE.
        /// </summary>
        public const string ACDTEE = "ACDTEE";

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
    public override string TableName => "F90CA63E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACAN8", "ACAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ACCO", "ACCO", JdeDataType.String, 10, true, true),
        new JdeField("ACACTIVID", "ACACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("ACPACTVID", "ACPACTVID", JdeDataType.String, 74),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACDTEE", "ACDTEE", JdeDataType.Date),
        new JdeField("ACUDTTM", "ACUDTTM", JdeDataType.Date),
        new JdeField("ACMKEY", "ACMKEY", JdeDataType.String, 30),
        new JdeField("ACENTRD", "ACENTRD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA63E_0", "Primary Key on ACACTIVID, ACAN8, ACCO", new[] { "ACACTIVID", "ACAN8", "ACCO" }, isUnique: true, isPrimaryKey: true)
    };
}
