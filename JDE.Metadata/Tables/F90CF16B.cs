using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF16B - .
/// </summary>
public class F90CF16B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISSCRPTID.
        /// </summary>
        public const string ISSCRPTID = "ISSCRPTID";

        /// <summary>
        /// ISITM.
        /// </summary>
        public const string ISITM = "ISITM";

        /// <summary>
        /// ISUDTTM.
        /// </summary>
        public const string ISUDTTM = "ISUDTTM";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISMKEY.
        /// </summary>
        public const string ISMKEY = "ISMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF16B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISSCRPTID", "ISSCRPTID", JdeDataType.Numeric, null, true, true),
        new JdeField("ISITM", "ISITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ISUDTTM", "ISUDTTM", JdeDataType.Date),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISMKEY", "ISMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF16B_0", "Primary Key on ISSCRPTID, ISITM", new[] { "ISSCRPTID", "ISITM" }, isUnique: true, isPrimaryKey: true)
    };
}
